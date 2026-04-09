using System.Collections.Generic;
using System.Threading.Tasks;
using IPGeolocation.Internal;
using IPGeolocation.Test.IpLocation.Support;
using Xunit;

namespace IPGeolocation.Test.IpLocation;

public sealed class IpGeolocationClientTests
{
    [Fact]
    public async Task LookupBuildsRequestWithExpectedHeaders()
    {
        var transport = new FakeTransport();
        transport.QueueResponse(new HttpResponseData(
            200,
            """{"ip":"8.8.8.8"}""",
            new Dictionary<string, IReadOnlyList<string>>()));

        using var client = new IPGeolocation.IpGeolocationClient(
            new IPGeolocation.IpGeolocationClientConfig(apiKey: "test-key", requestOrigin: "https://app.example.com"),
            transport);

        await client.LookupIpGeolocationAsync(new IPGeolocation.LookupIpGeolocationRequest(
            ip: "8.8.8.8",
            include: new[] { "security" },
            userAgent: "custom-agent"));

        Assert.NotNull(transport.LastRequest);
        Assert.Contains("/v3/ipgeo?", transport.LastRequest!.Url);
        Assert.Contains("apiKey=test-key", transport.LastRequest.Url);
        Assert.Contains("ip=8.8.8.8", transport.LastRequest.Url);
        Assert.Contains("include=security", transport.LastRequest.Url);
        Assert.Equal("application/json", transport.LastRequest.Headers["Accept"]);
        Assert.Equal("https://app.example.com", transport.LastRequest.Headers["Origin"]);
        Assert.Equal("custom-agent", transport.LastRequest.Headers["User-Agent"]);
    }

    [Fact]
    public async Task TypedMethodsRejectXml()
    {
        var transport = new FakeTransport();
        using var client = new IPGeolocation.IpGeolocationClient(
            new IPGeolocation.IpGeolocationClientConfig(apiKey: "test-key"),
            transport);

        var error = await Assert.ThrowsAsync<IPGeolocation.ValidationException>(() =>
            client.LookupIpGeolocationAsync(new IPGeolocation.LookupIpGeolocationRequest(output: IPGeolocation.ResponseFormat.Xml)));

        Assert.Equal("typed methods support JSON only", error.Message);
    }

    [Fact]
    public async Task BulkLookupRequiresApiKey()
    {
        var transport = new FakeTransport();
        using var client = new IPGeolocation.IpGeolocationClient(
            new IPGeolocation.IpGeolocationClientConfig(requestOrigin: "https://app.example.com"),
            transport);

        var error = await Assert.ThrowsAsync<IPGeolocation.ValidationException>(() =>
            client.BulkLookupIpGeolocationAsync(new IPGeolocation.BulkLookupIpGeolocationRequest(new[] { "8.8.8.8" })));

        Assert.Equal("bulk lookup requires apiKey in client config", error.Message);
    }

    [Fact]
    public async Task ApiErrorsUseNestedErrorMessage()
    {
        var transport = new FakeTransport();
        transport.QueueResponse(new HttpResponseData(
            400,
            """{"error":{"message":"Invalid IP address."}}""",
            new Dictionary<string, IReadOnlyList<string>>()));

        using var client = new IPGeolocation.IpGeolocationClient(
            new IPGeolocation.IpGeolocationClientConfig(apiKey: "test-key"),
            transport);

        var error = await Assert.ThrowsAsync<IPGeolocation.BadRequestException>(() =>
            client.LookupIpGeolocationAsync(new IPGeolocation.LookupIpGeolocationRequest(ip: "bad-ip")));

        Assert.Equal("Invalid IP address.", error.Message);
    }
}

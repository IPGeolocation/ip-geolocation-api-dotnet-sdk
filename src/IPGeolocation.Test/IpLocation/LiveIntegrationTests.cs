using System.Linq;
using System.Threading.Tasks;
using IPGeolocation.Test.IpLocation.Support;
using Xunit;

namespace IPGeolocation.Test.IpLocation;

public sealed class LiveIntegrationTests
{
    [SkippableFact]
    public async Task ArabicLookupsLive()
    {
        var apiKey = LiveTestGuard.RequirePaidKeyForLive();
        using var client = new IpGeolocationClient(new IpGeolocationClientConfig(apiKey: apiKey));

        var single = await client.LookupIpGeolocationAsync(new LookupIpGeolocationRequest(ip: "8.8.8.8", lang: "ar"));
        var bulk = await client.BulkLookupIpGeolocationAsync(new BulkLookupIpGeolocationRequest(new[] { "8.8.8.8" }, lang: "ar"));

        Assert.Matches(@"[\u0600-\u06ff]", single.Data.Location?.CountryName ?? string.Empty);
        Assert.Matches(@"[\u0600-\u06ff]", Assert.IsType<BulkLookupSuccess>(Assert.Single(bulk.Data)).Data.Location?.CountryName ?? string.Empty);
    }

    [SkippableFact]
    public async Task SingleLookupLive()
    {
        var apiKey = LiveTestGuard.RequireFreeKey();
        using var client = new IPGeolocation.IpGeolocationClient(new IPGeolocation.IpGeolocationClientConfig(apiKey: apiKey));

        var response = await client.LookupIpGeolocationAsync(new IPGeolocation.LookupIpGeolocationRequest(ip: "8.8.8.8"));

        Assert.Equal("8.8.8.8", response.Data.Ip);
        Assert.False(string.IsNullOrWhiteSpace(response.Data.Location?.CountryName));
    }

    [SkippableFact]
    public async Task SingleRawXmlLive()
    {
        var apiKey = LiveTestGuard.RequireFreeKey();
        using var client = new IPGeolocation.IpGeolocationClient(new IPGeolocation.IpGeolocationClientConfig(apiKey: apiKey));

        var response = await client.LookupIpGeolocationRawAsync(new IPGeolocation.LookupIpGeolocationRequest(
            ip: "8.8.8.8",
            output: IPGeolocation.ResponseFormat.Xml));

        Assert.Contains("<ip>8.8.8.8</ip>", response.Data);
    }

    [SkippableFact]
    public async Task BulkLookupLive()
    {
        var apiKey = LiveTestGuard.RequirePaidKeyForLive();
        using var client = new IPGeolocation.IpGeolocationClient(new IPGeolocation.IpGeolocationClientConfig(apiKey: apiKey));

        var response = await client.BulkLookupIpGeolocationAsync(new IPGeolocation.BulkLookupIpGeolocationRequest(new[] { "8.8.8.8", "1.1.1.1" }));

        Assert.Equal(2, response.Data.Count);
        Assert.True(response.Data.OfType<IPGeolocation.BulkLookupSuccess>().Any());
    }
}

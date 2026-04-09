using System.Collections.Generic;
using Xunit;

namespace IPGeolocation.Test.IpLocation;

public sealed class PublicApiTests
{
    [Fact]
    public void CoreClassesAreUsable()
    {
        var config = new IPGeolocation.IpGeolocationClientConfig(apiKey: "test-key");
        using var client = new IPGeolocation.IpGeolocationClient(config);
        var request = new IPGeolocation.LookupIpGeolocationRequest(ip: "8.8.8.8");
        var metadata = new IPGeolocation.ApiResponseMetadata(null, null, 200, 5, new Dictionary<string, IReadOnlyList<string>>());
        var response = new IPGeolocation.ApiResponse<IPGeolocation.IpGeolocationResponse>(
            new IPGeolocation.IpGeolocationResponse(
                ip: "8.8.8.8",
                asn: new IPGeolocation.AsnInfo(asNumber: "AS15169"),
                company: new IPGeolocation.CompanyInfo(name: "Google LLC")),
            metadata);
        var success = new IPGeolocation.BulkLookupSuccess(new IPGeolocation.IpGeolocationResponse(ip: "8.8.8.8"));
        var error = new IPGeolocation.BulkLookupError(new IPGeolocation.BulkLookupErrorDetails("Invalid IP address."));

        Assert.Equal("test-key", config.ApiKey);
        Assert.Equal("8.8.8.8", request.Ip);
        Assert.Equal("8.8.8.8", response.Data.Ip);
        Assert.Equal("AS15169", response.Data.Asn?.AsNumber);
        Assert.Equal("Google LLC", response.Data.Company?.Name);
        Assert.True(success.IsSuccess);
        Assert.False(error.IsSuccess);
        Assert.Equal("Invalid IP address.", error.Error.Message);
    }
}

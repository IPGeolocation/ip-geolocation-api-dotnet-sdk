using System.Collections.Generic;
using Xunit;

namespace IPGeolocation.Test.IpLocation;

public sealed class RequestModelTests
{
    [Fact]
    public void LookupRequestNormalizesListsAndHeaders()
    {
        var request = new IPGeolocation.LookupIpGeolocationRequest(
            ip: " 8.8.8.8 ",
            lang: "EN",
            include: new[] { "security", "security", "abuse" },
            fields: new[] { "location.country_name" },
            excludes: new[] { "currency" },
            userAgent: "custom-agent",
            headers: new Dictionary<string, string>
            {
                ["X-Test"] = "value"
            });

        Assert.Equal("8.8.8.8", request.Ip);
        Assert.Equal("en", request.Lang);
        Assert.Equal(new[] { "security", "abuse" }, request.Include);
        Assert.Equal("custom-agent", request.UserAgent);
        Assert.Equal("value", request.Headers["X-Test"]);
    }

    [Fact]
    public void BulkRequestRejectsEmptyIps()
    {
        var error = Assert.Throws<IPGeolocation.ValidationException>(() =>
            new IPGeolocation.BulkLookupIpGeolocationRequest(System.Array.Empty<string>()));

        Assert.Equal("ips must contain at least one IP address or domain", error.Message);
    }
}

using System.Linq;
using IPGeolocation.Internal;
using Xunit;

namespace IPGeolocation.Test.IpLocation;

public sealed class SerDeTests
{
    [Fact]
    public void ParsesMixedBulkSuccessAndError()
    {
        const string body = """
            [
              { "ip": "8.8.8.8", "location": { "country_name": "United States" } },
              { "message": "Invalid IP address." },
              { "error": { "message": "Quota exceeded." } }
            ]
            """;

        var result = SerDe.ParseBulkLookup(body);

        Assert.Equal(3, result.Count);
        var success = Assert.IsType<IPGeolocation.BulkLookupSuccess>(result[0]);
        var error1 = Assert.IsType<IPGeolocation.BulkLookupError>(result[1]);
        var error2 = Assert.IsType<IPGeolocation.BulkLookupError>(result[2]);
        Assert.Equal("8.8.8.8", success.Data.Ip);
        Assert.Equal("Invalid IP address.", error1.Error.Message);
        Assert.Equal("Quota exceeded.", error2.Error.Message);
    }

    [Fact]
    public void ApiExceptionPrefersNestedErrorMessage()
    {
        var error = SerDe.ToApiException(400, """{"error":{"message":"Invalid IP address."}}""");

        Assert.IsType<IPGeolocation.BadRequestException>(error);
        Assert.Equal("Invalid IP address.", error.Message);
    }

    [Fact]
    public void SingleLookupParsingDoesNotInventMissingFields()
    {
        var response = SerDe.ParseSingleLookup("""
            {
              "ip": "8.8.8.8",
              "location": { "country_name": "United States" },
              "security": { "threat_score": 1.5 }
            }
            """);

        Assert.Equal("8.8.8.8", response.Ip);
        Assert.Equal("United States", response.Location?.CountryName);
        Assert.Equal(1.5d, response.Security?.ThreatScore);
        Assert.Null(response.TimeZone);
        Assert.Null(response.Network);
    }

    [Fact]
    public void SingleLookupParsesTopLevelAsnAndCompany()
    {
        var response = SerDe.ParseSingleLookup("""
            {
              "ip": "8.8.8.8",
              "network": {
                "connection_type": "Corporate",
                "route": "8.8.8.0/24",
                "is_anycast": true
              },
              "asn": {
                "as_number": "AS15169",
                "organization": "Google LLC"
              },
              "company": {
                "name": "Google LLC",
                "domain": "google.com"
              }
            }
            """);

        Assert.Equal("Corporate", response.Network?.ConnectionType);
        Assert.Equal("AS15169", response.Asn?.AsNumber);
        Assert.Equal("Google LLC", response.Asn?.Organization);
        Assert.Equal("Google LLC", response.Company?.Name);
        Assert.Equal("google.com", response.Company?.Domain);
    }

    [Fact]
    public void BulkLookupParsesTopLevelAsnAndCompanyOnSuccessItems()
    {
        const string body = """
            [
              {
                "ip": "8.8.8.8",
                "asn": { "as_number": "AS15169" },
                "company": { "name": "Google LLC" }
              }
            ]
            """;

        var result = SerDe.ParseBulkLookup(body);
        var success = Assert.IsType<IPGeolocation.BulkLookupSuccess>(Assert.Single(result));

        Assert.Equal("AS15169", success.Data.Asn?.AsNumber);
        Assert.Equal("Google LLC", success.Data.Company?.Name);
    }
}

using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using IPGeolocation.Test.IpLocation.Support;
using Xunit;

namespace IPGeolocation.Test.IpLocation;

public sealed class LiveFieldParityTests
{
    [SkippableFact]
    public async Task SingleTypedAndRawShareKeyFields()
    {
        var apiKey = LiveTestGuard.RequirePaidKey();
        using var client = new IPGeolocation.IpGeolocationClient(new IPGeolocation.IpGeolocationClientConfig(apiKey: apiKey));

        var request = new IPGeolocation.LookupIpGeolocationRequest(
            ip: "8.8.8.8",
            include: new[] { "security" },
            fields: new[] { "location.country_name", "security.threat_score", "asn.as_number", "company.name" });

        var typed = await client.LookupIpGeolocationAsync(request);
        var raw = await client.LookupIpGeolocationRawAsync(request);

        using var document = JsonDocument.Parse(raw.Data);
        Assert.Equal(typed.Data.Ip, document.RootElement.GetProperty("ip").GetString());
        Assert.Equal(typed.Data.Location?.CountryName, document.RootElement.GetProperty("location").GetProperty("country_name").GetString());
        Assert.Equal(typed.Data.Asn?.AsNumber, document.RootElement.GetProperty("asn").GetProperty("as_number").GetString());
        Assert.Equal(typed.Data.Company?.Name, document.RootElement.GetProperty("company").GetProperty("name").GetString());

        var rawThreatScore = document.RootElement.GetProperty("security").GetProperty("threat_score").GetDouble();
        Assert.Equal(typed.Data.Security?.ThreatScore, rawThreatScore);
    }

    [SkippableFact]
    public async Task BulkTypedAndRawShareSuccessIpValues()
    {
        var apiKey = LiveTestGuard.RequirePaidKey();
        using var client = new IPGeolocation.IpGeolocationClient(new IPGeolocation.IpGeolocationClientConfig(apiKey: apiKey));

        var request = new IPGeolocation.BulkLookupIpGeolocationRequest(new[] { "8.8.8.8", "1.1.1.1" });
        var typed = await client.BulkLookupIpGeolocationAsync(request);
        var raw = await client.BulkLookupIpGeolocationRawAsync(request);

        var typedIps = typed.Data.OfType<IPGeolocation.BulkLookupSuccess>().Select(item => item.Data.Ip).Where(value => value is not null).ToArray();
        var typedAsns = typed.Data
            .OfType<IPGeolocation.BulkLookupSuccess>()
            .Select(item => item.Data.Asn?.AsNumber)
            .Where(value => value is not null)
            .ToArray();

        using var document = JsonDocument.Parse(raw.Data);
        var rawIps = document.RootElement
            .EnumerateArray()
            .Where(item => item.TryGetProperty("ip", out _))
            .Select(item => item.GetProperty("ip").GetString())
            .Where(value => value is not null)
            .ToArray();
        var rawAsns = document.RootElement
            .EnumerateArray()
            .Where(item => item.TryGetProperty("asn", out _))
            .Select(item => item.GetProperty("asn").GetProperty("as_number").GetString())
            .Where(value => value is not null)
            .ToArray();

        Assert.Equal(typedIps, rawIps);
        Assert.Equal(typedAsns, rawAsns);
    }
}

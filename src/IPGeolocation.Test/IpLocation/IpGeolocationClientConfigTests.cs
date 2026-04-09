using System;
using System.Text.Json;
using Xunit;

namespace IPGeolocation.Test.IpLocation;

public sealed class IpGeolocationClientConfigTests
{
    [Fact]
    public void NormalizesRequestOriginAndBaseUrl()
    {
        var config = new IPGeolocation.IpGeolocationClientConfig(
            apiKey: "test-key",
            requestOrigin: "https://app.example.com/",
            baseUrl: "https://api.ipgeolocation.io/");

        Assert.Equal("test-key", config.ApiKey);
        Assert.Equal("https://app.example.com", config.RequestOrigin);
        Assert.Equal("https://api.ipgeolocation.io", config.BaseUrl);
        Assert.Equal(TimeSpan.FromSeconds(10), config.ConnectTimeout);
        Assert.Equal(TimeSpan.FromSeconds(30), config.ReadTimeout);
    }

    [Fact]
    public void RejectsRequestOriginWithPath()
    {
        var error = Assert.Throws<IPGeolocation.ValidationException>(() =>
            new IPGeolocation.IpGeolocationClientConfig(requestOrigin: "https://app.example.com/path"));

        Assert.Equal("requestOrigin must not include a path", error.Message);
    }

    [Fact]
    public void SafeDictionaryAndJsonSerializationHideApiKey()
    {
        var config = new IPGeolocation.IpGeolocationClientConfig(apiKey: "test-key");

        Assert.Equal("[REDACTED]", config.ToSafeDictionary()["apiKey"]);

        var json = JsonSerializer.Serialize(config);
        Assert.DoesNotContain("test-key", json, StringComparison.Ordinal);
        Assert.DoesNotContain("apiKey", json, StringComparison.Ordinal);
    }
}

using System;
using System.Collections.Generic;
using System.Threading;
using System.Text.Json.Serialization;

namespace IPGeolocation;

public sealed class IpGeolocationClientConfig
{
    public const string DefaultBaseUrl = "https://api.ipgeolocation.io";
    public static readonly TimeSpan DefaultConnectTimeout = TimeSpan.FromSeconds(10);
    public static readonly TimeSpan DefaultReadTimeout = TimeSpan.FromSeconds(30);

    public IpGeolocationClientConfig(
        string? apiKey = null,
        string? requestOrigin = null,
        string baseUrl = DefaultBaseUrl,
        TimeSpan? connectTimeout = null,
        TimeSpan? readTimeout = null)
    {
        ApiKey = NormalizeApiKey(apiKey);
        RequestOrigin = NormalizeRequestOrigin(requestOrigin);
        BaseUrl = NormalizeBaseUrl(baseUrl);
        ConnectTimeout = NormalizeTimeout(connectTimeout ?? DefaultConnectTimeout, "connectTimeout");
        ReadTimeout = NormalizeTimeout(readTimeout ?? DefaultReadTimeout, "readTimeout");
    }

    [JsonIgnore]
    public string? ApiKey { get; }

    public string? RequestOrigin { get; }

    public string BaseUrl { get; }

    public TimeSpan ConnectTimeout { get; }

    public TimeSpan ReadTimeout { get; }

    public IReadOnlyDictionary<string, object?> ToSafeDictionary()
    {
        return new Dictionary<string, object?>
        {
            ["apiKey"] = ApiKey is null ? null : "[REDACTED]",
            ["requestOrigin"] = RequestOrigin,
            ["baseUrl"] = BaseUrl,
            ["connectTimeout"] = ConnectTimeout.TotalSeconds,
            ["readTimeout"] = ReadTimeout.TotalSeconds,
        };
    }

    private static string? NormalizeApiKey(string? value)
    {
        if (value is null)
        {
            return null;
        }

        var normalized = value.Trim();
        if (normalized.Length == 0)
        {
            throw new ValidationException("apiKey must not be blank");
        }

        return normalized;
    }

    private static string? NormalizeRequestOrigin(string? value)
    {
        if (value is null)
        {
            return null;
        }

        var normalized = value.Trim();
        if (normalized.Length == 0)
        {
            throw new ValidationException("requestOrigin must not be blank");
        }

        if (normalized.Contains('\r') || normalized.Contains('\n'))
        {
            throw new ValidationException("requestOrigin must not contain CR or LF");
        }

        if (!Uri.TryCreate(normalized, UriKind.Absolute, out var uri) || (uri.Scheme != Uri.UriSchemeHttp && uri.Scheme != Uri.UriSchemeHttps))
        {
            throw new ValidationException("requestOrigin must be an absolute http or https origin");
        }

        if (!string.IsNullOrEmpty(uri.AbsolutePath) && uri.AbsolutePath != "/")
        {
            throw new ValidationException("requestOrigin must not include a path");
        }

        if (!string.IsNullOrEmpty(uri.Query) || !string.IsNullOrEmpty(uri.Fragment))
        {
            throw new ValidationException("requestOrigin must not include query or fragment");
        }

        if (!string.IsNullOrEmpty(uri.UserInfo))
        {
            throw new ValidationException("requestOrigin must not include userinfo");
        }

        var builder = new UriBuilder(uri.Scheme, uri.Host, uri.IsDefaultPort ? -1 : uri.Port);
        return builder.Uri.ToString().TrimEnd('/');
    }

    private static string NormalizeBaseUrl(string value)
    {
        var normalized = value.Trim().TrimEnd('/');
        if (normalized.Length == 0)
        {
            throw new ValidationException("baseUrl must not be blank");
        }

        if (!Uri.TryCreate(normalized, UriKind.Absolute, out var uri) || (uri.Scheme != Uri.UriSchemeHttp && uri.Scheme != Uri.UriSchemeHttps))
        {
            throw new ValidationException("baseUrl must be an absolute http or https URL");
        }

        if (!string.IsNullOrEmpty(uri.Query) || !string.IsNullOrEmpty(uri.Fragment))
        {
            throw new ValidationException("baseUrl must not include query or fragment");
        }

        if (!string.IsNullOrEmpty(uri.UserInfo))
        {
            throw new ValidationException("baseUrl must not include userinfo");
        }

        return normalized;
    }

    private static TimeSpan NormalizeTimeout(TimeSpan value, string fieldName)
    {
        if (value <= TimeSpan.Zero || value == Timeout.InfiniteTimeSpan)
        {
            throw new ValidationException(fieldName + " must be greater than zero");
        }

        return value;
    }
}

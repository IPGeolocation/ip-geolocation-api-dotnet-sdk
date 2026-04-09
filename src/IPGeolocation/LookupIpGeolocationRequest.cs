using System.Collections.Generic;

namespace IPGeolocation;

public sealed class LookupIpGeolocationRequest
{
    public LookupIpGeolocationRequest(
        string? ip = null,
        string? lang = null,
        IEnumerable<string>? include = null,
        IEnumerable<string>? fields = null,
        IEnumerable<string>? excludes = null,
        string? userAgent = null,
        IReadOnlyDictionary<string, string>? headers = null,
        ResponseFormat output = ResponseFormat.Json)
    {
        Ip = Internal.RequestNormalizer.NormalizeLookupIp(ip);
        Lang = Internal.RequestNormalizer.NormalizeLanguage(lang);
        Include = Internal.RequestNormalizer.NormalizeStringList(include, "include");
        Fields = Internal.RequestNormalizer.NormalizeStringList(fields, "fields");
        Excludes = Internal.RequestNormalizer.NormalizeStringList(excludes, "excludes");
        UserAgent = Internal.RequestNormalizer.NormalizeOptionalHeaderValue(userAgent, "userAgent");
        Headers = Internal.RequestNormalizer.NormalizeHeaders(headers);
        Output = output;
    }

    public string? Ip { get; }
    public string? Lang { get; }
    public IReadOnlyList<string> Include { get; }
    public IReadOnlyList<string> Fields { get; }
    public IReadOnlyList<string> Excludes { get; }
    public string? UserAgent { get; }
    public IReadOnlyDictionary<string, string> Headers { get; }
    public ResponseFormat Output { get; }
}

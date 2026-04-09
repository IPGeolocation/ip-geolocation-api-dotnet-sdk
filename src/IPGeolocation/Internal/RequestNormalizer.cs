using System;
using System.Collections.Generic;

namespace IPGeolocation.Internal;

internal static class RequestNormalizer
{
    private static readonly HashSet<string> AllowedLanguages = new(StringComparer.OrdinalIgnoreCase)
    {
        "en", "de", "ru", "ja", "fr", "cn", "es", "cs", "it", "ko", "fa", "pt"
    };

    internal static string? NormalizeLookupIp(string? value)
    {
        if (value is null)
        {
            return null;
        }

        var normalized = value.Trim();
        if (normalized.Length == 0)
        {
            throw new ValidationException("ip must not be blank");
        }

        if (normalized.Contains('\r') || normalized.Contains('\n'))
        {
            throw new ValidationException("ip must not contain CR or LF");
        }

        return normalized;
    }

    internal static IReadOnlyList<string> NormalizeIpList(IEnumerable<string> values)
    {
        if (values is null)
        {
            throw new ValidationException("ips must not be null");
        }

        var normalized = NormalizeStringList(values, "ips");
        if (normalized.Count == 0)
        {
            throw new ValidationException("ips must contain at least one IP address or domain");
        }

        if (normalized.Count > 50000)
        {
            throw new ValidationException("ips must not contain more than 50000 entries");
        }

        return normalized;
    }

    internal static string? NormalizeLanguage(string? value)
    {
        if (value is null)
        {
            return null;
        }

        var normalized = value.Trim();
        if (normalized.Length == 0)
        {
            throw new ValidationException("lang must not be blank");
        }

        if (!AllowedLanguages.Contains(normalized))
        {
            throw new ValidationException("lang must be one of: en, de, ru, ja, fr, cn, es, cs, it, ko, fa, pt");
        }

        return normalized.ToLowerInvariant();
    }

    internal static IReadOnlyList<string> NormalizeStringList(IEnumerable<string>? values, string fieldName)
    {
        if (values is null)
        {
            return Array.Empty<string>();
        }

        var result = new List<string>();
        var seen = new HashSet<string>(StringComparer.Ordinal);

        foreach (var value in values)
        {
            if (value is null)
            {
                throw new ValidationException(fieldName + " must not contain null values");
            }

            var normalized = value.Trim();
            if (normalized.Length == 0)
            {
                throw new ValidationException(fieldName + " must not contain blank values");
            }

            if (seen.Add(normalized))
            {
                result.Add(normalized);
            }
        }

        return result;
    }

    internal static string? NormalizeOptionalHeaderValue(string? value, string fieldName)
    {
        if (value is null)
        {
            return null;
        }

        var normalized = value.Trim();
        if (normalized.Length == 0)
        {
            throw new ValidationException(fieldName + " must not be blank");
        }

        if (normalized.Contains('\r') || normalized.Contains('\n'))
        {
            throw new ValidationException(fieldName + " must not contain CR or LF");
        }

        return normalized;
    }

    internal static IReadOnlyDictionary<string, string> NormalizeHeaders(IReadOnlyDictionary<string, string>? headers)
    {
        if (headers is null || headers.Count == 0)
        {
            return new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        }

        var result = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        foreach (var entry in headers)
        {
            var name = entry.Key?.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ValidationException("headers must not contain blank names");
            }

            var value = entry.Value?.Trim();
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ValidationException("headers must not contain blank values");
            }

            if (name.Contains('\r') || name.Contains('\n') || value.Contains('\r') || value.Contains('\n'))
            {
                throw new ValidationException("headers must not contain CR or LF");
            }

            result[name] = value;
        }

        return result;
    }
}

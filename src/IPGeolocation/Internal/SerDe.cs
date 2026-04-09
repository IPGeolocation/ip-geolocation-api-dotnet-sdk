using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text.Json;

namespace IPGeolocation.Internal;

internal static class SerDe
{
    internal static void ValidateJsonOutput(ResponseFormat output)
    {
        if (output != ResponseFormat.Json)
        {
            throw new ValidationException("typed methods support JSON only");
        }
    }

    internal static string BuildQueryString(IEnumerable<KeyValuePair<string, string?>> values)
    {
        var parts = new List<string>();
        foreach (var entry in values)
        {
            if (string.IsNullOrEmpty(entry.Value))
            {
                continue;
            }

            parts.Add(Uri.EscapeDataString(entry.Key) + "=" + Uri.EscapeDataString(entry.Value));
        }

        return parts.Count == 0 ? string.Empty : "?" + string.Join("&", parts);
    }

    internal static string ResolveUserAgent(string? requestUserAgent, IReadOnlyDictionary<string, string> headers, string defaultUserAgent)
    {
        if (!string.IsNullOrWhiteSpace(requestUserAgent))
        {
            return requestUserAgent;
        }

        return headers.TryGetValue("User-Agent", out var value) && !string.IsNullOrWhiteSpace(value)
            ? value
            : defaultUserAgent;
    }

    internal static ApiResponseMetadata ToMetadata(int statusCode, int durationMs, IReadOnlyDictionary<string, IReadOnlyList<string>> headers)
    {
        return new ApiResponseMetadata(
            creditsCharged: TryReadIntHeader(headers, "X-Credits-Charged"),
            successfulRecords: TryReadIntHeader(headers, "X-Successful-Records"),
            statusCode: statusCode,
            durationMs: durationMs,
            rawHeaders: headers
        );
    }

    internal static ApiException ToApiException(int statusCode, string body)
    {
        var message = ExtractApiMessage(body) ?? DefaultApiMessage(statusCode);

        return statusCode switch
        {
            400 => new BadRequestException(message),
            401 => new UnauthorizedException(message),
            403 => new ForbiddenException(message),
            404 => new NotFoundException(message),
            405 => new MethodNotAllowedException(message),
            413 => new ContentTooLargeException(message),
            415 => new UnsupportedMediaTypeException(message),
            423 => new LockedException(message),
            429 => new TooManyRequestsException(message),
            499 => new CustomStatus499Exception(message),
            500 => new InternalServerErrorException(message),
            _ => new ApiException((HttpStatusCode)statusCode, message),
        };
    }

    internal static IpGeolocationResponse ParseSingleLookup(string body)
    {
        try
        {
            using var document = JsonDocument.Parse(body);
            if (document.RootElement.ValueKind != JsonValueKind.Object)
            {
                throw new SerializationException("Expected a JSON object for single lookup response");
            }

            return ParseResponse(document.RootElement);
        }
        catch (JsonException error)
        {
            throw new SerializationException("Failed to parse single lookup response body", error);
        }
    }

    internal static IReadOnlyList<BulkLookupResult> ParseBulkLookup(string body)
    {
        try
        {
            using var document = JsonDocument.Parse(body);
            if (document.RootElement.ValueKind != JsonValueKind.Array)
            {
                throw new SerializationException("Expected a JSON array for bulk lookup response");
            }

            var result = new List<BulkLookupResult>();
            foreach (var item in document.RootElement.EnumerateArray())
            {
                if (IsBulkError(item))
                {
                    result.Add(new BulkLookupError(new BulkLookupErrorDetails(ReadBulkErrorMessage(item))));
                }
                else
                {
                    result.Add(new BulkLookupSuccess(ParseResponse(item)));
                }
            }

            return result;
        }
        catch (JsonException error)
        {
            throw new SerializationException("Failed to parse bulk lookup response body", error);
        }
    }

    private static bool IsBulkError(JsonElement item)
    {
        return item.ValueKind == JsonValueKind.Object
            && (item.TryGetProperty("error", out _) || (item.TryGetProperty("message", out _) && !item.TryGetProperty("ip", out _)));
    }

    private static string ReadBulkErrorMessage(JsonElement item)
    {
        return ReadString(item, "message")
            ?? (item.TryGetProperty("error", out var errorObject) ? ReadString(errorObject, "message") : null)
            ?? "Bulk lookup item failed";
    }

    private static IpGeolocationResponse ParseResponse(JsonElement root)
    {
        return new IpGeolocationResponse(
            ip: ReadString(root, "ip"),
            hostname: ReadString(root, "hostname"),
            domain: ReadString(root, "domain"),
            location: ReadObject(root, "location", ParseLocation),
            countryMetadata: ReadObject(root, "country_metadata", ParseCountryMetadata),
            currency: ReadObject(root, "currency", ParseCurrency),
            network: ReadObject(root, "network", ParseNetwork),
            asn: ReadObject(root, "asn", ParseAsn),
            company: ReadObject(root, "company", ParseCompany),
            timeZone: ReadObject(root, "time_zone", ParseTimeZone),
            security: ReadObject(root, "security", ParseSecurity),
            userAgent: ReadObject(root, "user_agent", ParseUserAgent),
            abuse: ReadObject(root, "abuse", ParseAbuse)
        );
    }

    private static IpLocation ParseLocation(JsonElement root) => new(
        continentCode: ReadString(root, "continent_code"),
        continentName: ReadString(root, "continent_name"),
        countryCode2: ReadString(root, "country_code2"),
        countryCode3: ReadString(root, "country_code3"),
        countryName: ReadString(root, "country_name"),
        countryNameOfficial: ReadString(root, "country_name_official"),
        countryCapital: ReadString(root, "country_capital"),
        stateProv: ReadString(root, "state_prov"),
        stateCode: ReadString(root, "state_code"),
        district: ReadString(root, "district"),
        city: ReadString(root, "city"),
        locality: ReadString(root, "locality"),
        accuracyRadius: ReadString(root, "accuracy_radius"),
        confidence: ReadString(root, "confidence"),
        dmaCode: ReadString(root, "dma_code"),
        zipcode: ReadString(root, "zipcode"),
        latitude: ReadString(root, "latitude"),
        longitude: ReadString(root, "longitude"),
        isEu: ReadBool(root, "is_eu"),
        countryFlag: ReadString(root, "country_flag"),
        geonameId: ReadString(root, "geoname_id"),
        countryEmoji: ReadString(root, "country_emoji"));

    private static CountryMetadata ParseCountryMetadata(JsonElement root) => new(
        callingCode: ReadString(root, "calling_code"),
        tld: ReadString(root, "tld"),
        languages: ReadStringArray(root, "languages"));

    private static CurrencyInfo ParseCurrency(JsonElement root) => new(
        code: ReadString(root, "code"),
        name: ReadString(root, "name"),
        symbol: ReadString(root, "symbol"));

    private static NetworkInfo ParseNetwork(JsonElement root) => new(
        connectionType: ReadString(root, "connection_type"),
        route: ReadString(root, "route"),
        isAnycast: ReadBool(root, "is_anycast"));

    private static AsnInfo ParseAsn(JsonElement root) => new(
        asNumber: ReadString(root, "as_number"),
        organization: ReadString(root, "organization"),
        country: ReadString(root, "country"),
        type: ReadString(root, "type"),
        domain: ReadString(root, "domain"),
        dateAllocated: ReadString(root, "date_allocated"),
        rir: ReadString(root, "rir"));

    private static CompanyInfo ParseCompany(JsonElement root) => new(
        name: ReadString(root, "name"),
        type: ReadString(root, "type"),
        domain: ReadString(root, "domain"));

    private static IpTimeZone ParseTimeZone(JsonElement root) => new(
        name: ReadString(root, "name"),
        offset: ReadDouble(root, "offset"),
        offsetWithDst: ReadDouble(root, "offset_with_dst"),
        currentTime: ReadString(root, "current_time"),
        currentTimeUnix: ReadDouble(root, "current_time_unix"),
        currentTzAbbreviation: ReadString(root, "current_timezone_abbreviation"),
        currentTzFullName: ReadString(root, "current_timezone_name"),
        standardTzAbbreviation: ReadString(root, "timezone_abbreviation"),
        standardTzFullName: ReadString(root, "timezone_name"),
        isDst: ReadBool(root, "is_dst"),
        dstSavings: ReadDouble(root, "dst_savings"),
        dstExists: ReadBool(root, "dst_exists"),
        dstTzAbbreviation: ReadString(root, "dst_timezone_abbreviation"),
        dstTzFullName: ReadString(root, "dst_timezone_name"),
        dstStart: ReadObject(root, "dst_start", ParseDstTransition),
        dstEnd: ReadObject(root, "dst_end", ParseDstTransition));

    private static DstTransition ParseDstTransition(JsonElement root) => new(
        utcTime: ReadString(root, "utc_time"),
        duration: ReadString(root, "duration"),
        gap: ReadBool(root, "gap"),
        dateTimeAfter: ReadString(root, "date_time_after"),
        dateTimeBefore: ReadString(root, "date_time_before"),
        overlap: ReadBool(root, "overlap"));

    private static SecurityInfo ParseSecurity(JsonElement root) => new(
        threatScore: ReadDouble(root, "threat_score"),
        isTor: ReadBool(root, "is_tor"),
        isProxy: ReadBool(root, "is_proxy"),
        proxyProviderNames: ReadStringArray(root, "proxy_provider_names"),
        proxyConfidenceScore: ReadDouble(root, "proxy_confidence_score"),
        proxyLastSeen: ReadString(root, "proxy_last_seen"),
        isResidentialProxy: ReadBool(root, "is_residential_proxy"),
        isVpn: ReadBool(root, "is_vpn"),
        vpnProviderNames: ReadStringArray(root, "vpn_provider_names"),
        vpnConfidenceScore: ReadDouble(root, "vpn_confidence_score"),
        vpnLastSeen: ReadString(root, "vpn_last_seen"),
        isRelay: ReadBool(root, "is_relay"),
        relayProviderName: ReadString(root, "relay_provider_name"),
        isAnonymous: ReadBool(root, "is_anonymous"),
        isKnownAttacker: ReadBool(root, "is_known_attacker"),
        isBot: ReadBool(root, "is_bot"),
        isSpam: ReadBool(root, "is_spam"),
        isCloudProvider: ReadBool(root, "is_cloud_provider"),
        cloudProviderName: ReadString(root, "cloud_provider_name"));

    private static AbuseContact ParseAbuse(JsonElement root) => new(
        route: ReadString(root, "route"),
        country: ReadString(root, "country"),
        name: ReadString(root, "name"),
        organization: ReadString(root, "organization"),
        kind: ReadString(root, "kind"),
        address: ReadString(root, "address"),
        emails: ReadStringArray(root, "emails"),
        phoneNumbers: ReadStringArray(root, "phone_numbers"));

    private static UserAgentInfo ParseUserAgent(JsonElement root) => new(
        name: ReadString(root, "name"),
        type: ReadString(root, "type"),
        version: ReadString(root, "version"),
        versionMajor: ReadString(root, "version_major"),
        device: ReadObject(root, "device", ParseUserAgentDevice),
        engine: ReadObject(root, "engine", ParseUserAgentEngine),
        operatingSystem: ReadObject(root, "operating_system", ParseOperatingSystem));

    private static UserAgentDevice ParseUserAgentDevice(JsonElement root) => new(
        name: ReadString(root, "name"),
        type: ReadString(root, "type"),
        brand: ReadString(root, "brand"),
        cpu: ReadString(root, "cpu"));

    private static UserAgentEngine ParseUserAgentEngine(JsonElement root) => new(
        name: ReadString(root, "name"),
        type: ReadString(root, "type"),
        version: ReadString(root, "version"),
        versionMajor: ReadString(root, "version_major"));

    private static UserAgentOperatingSystem ParseOperatingSystem(JsonElement root) => new(
        name: ReadString(root, "name"),
        version: ReadString(root, "version"));

    private static string? ExtractApiMessage(string body)
    {
        if (string.IsNullOrWhiteSpace(body))
        {
            return null;
        }

        try
        {
            using var document = JsonDocument.Parse(body);
            if (document.RootElement.ValueKind != JsonValueKind.Object)
            {
                return body.Trim();
            }

            return ReadString(document.RootElement, "message")
                ?? (document.RootElement.TryGetProperty("error", out var errorObject) ? ReadString(errorObject, "message") : null)
                ?? body.Trim();
        }
        catch (JsonException)
        {
            return body.Trim();
        }
    }

    private static string DefaultApiMessage(int statusCode) => statusCode switch
    {
        400 => "Bad request",
        401 => "Unauthorized",
        403 => "Forbidden",
        404 => "Not found",
        405 => "Method not allowed",
        413 => "Content too large",
        415 => "Unsupported media type",
        423 => "Locked",
        429 => "Too many requests",
        499 => "Client closed request",
        500 => "Internal server error",
        _ => "API request failed with status code " + statusCode,
    };

    private static int? TryReadIntHeader(IReadOnlyDictionary<string, IReadOnlyList<string>> headers, string name)
    {
        if (!headers.TryGetValue(name, out var values))
        {
            return null;
        }

        var value = values.FirstOrDefault();
        return int.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var parsed)
            ? parsed
            : null;
    }

    private static string? ReadString(JsonElement root, string propertyName)
    {
        if (!root.TryGetProperty(propertyName, out var property) || property.ValueKind == JsonValueKind.Null)
        {
            return null;
        }

        return property.ValueKind switch
        {
            JsonValueKind.String => property.GetString(),
            JsonValueKind.Number => property.GetRawText(),
            JsonValueKind.True => bool.TrueString.ToLowerInvariant(),
            JsonValueKind.False => bool.FalseString.ToLowerInvariant(),
            _ => null
        };
    }

    private static bool? ReadBool(JsonElement root, string propertyName)
    {
        if (!root.TryGetProperty(propertyName, out var property) || property.ValueKind == JsonValueKind.Null)
        {
            return null;
        }

        return property.ValueKind switch
        {
            JsonValueKind.True => true,
            JsonValueKind.False => false,
            JsonValueKind.String when bool.TryParse(property.GetString(), out var parsed) => parsed,
            _ => null
        };
    }

    private static double? ReadDouble(JsonElement root, string propertyName)
    {
        if (!root.TryGetProperty(propertyName, out var property) || property.ValueKind == JsonValueKind.Null)
        {
            return null;
        }

        if (property.ValueKind == JsonValueKind.Number && property.TryGetDouble(out var number))
        {
            return number;
        }

        if (property.ValueKind == JsonValueKind.String
            && double.TryParse(property.GetString(), NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out var parsed))
        {
            return parsed;
        }

        return null;
    }

    private static IReadOnlyList<string>? ReadStringArray(JsonElement root, string propertyName)
    {
        if (!root.TryGetProperty(propertyName, out var property) || property.ValueKind == JsonValueKind.Null)
        {
            return null;
        }

        if (property.ValueKind != JsonValueKind.Array)
        {
            return null;
        }

        var values = new List<string>();
        foreach (var item in property.EnumerateArray())
        {
            var value = item.ValueKind == JsonValueKind.String ? item.GetString() : item.GetRawText();
            if (!string.IsNullOrWhiteSpace(value))
            {
                values.Add(value);
            }
        }

        return values;
    }

    private static T? ReadObject<T>(JsonElement root, string propertyName, Func<JsonElement, T> parser) where T : class
    {
        if (!root.TryGetProperty(propertyName, out var property) || property.ValueKind == JsonValueKind.Null)
        {
            return null;
        }

        if (property.ValueKind == JsonValueKind.Array && property.GetArrayLength() == 0)
        {
            return null;
        }

        return property.ValueKind == JsonValueKind.Object ? parser(property) : null;
    }
}

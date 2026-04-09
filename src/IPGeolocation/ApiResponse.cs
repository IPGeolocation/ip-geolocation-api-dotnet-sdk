using System;
using System.Collections.Generic;
using System.Linq;

namespace IPGeolocation;

public sealed class ApiResponse<T>
{
    public ApiResponse(T data, ApiResponseMetadata metadata)
    {
        Data = data;
        Metadata = metadata ?? throw new ArgumentNullException(nameof(metadata));
    }

    public T Data { get; }

    public ApiResponseMetadata Metadata { get; }
}

public sealed class ApiResponseMetadata
{
    public ApiResponseMetadata(
        int? creditsCharged,
        int? successfulRecords,
        int statusCode,
        int durationMs,
        IReadOnlyDictionary<string, IReadOnlyList<string>>? rawHeaders = null)
    {
        if (statusCode < 100 || statusCode > 599)
        {
            throw new ArgumentOutOfRangeException(nameof(statusCode), "statusCode must be between 100 and 599");
        }

        if (durationMs < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(durationMs), "durationMs must be greater than or equal to zero");
        }

        CreditsCharged = creditsCharged;
        SuccessfulRecords = successfulRecords;
        StatusCode = statusCode;
        DurationMs = durationMs;
        RawHeaders = rawHeaders ?? new Dictionary<string, IReadOnlyList<string>>(StringComparer.OrdinalIgnoreCase);
    }

    public int? CreditsCharged { get; }

    public int? SuccessfulRecords { get; }

    public int StatusCode { get; }

    public int DurationMs { get; }

    public IReadOnlyDictionary<string, IReadOnlyList<string>> RawHeaders { get; }

    public IReadOnlyList<string> HeaderValues(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("header name must not be blank", nameof(name));
        }

        return RawHeaders.TryGetValue(name, out var values)
            ? values
            : Array.Empty<string>();
    }

    public string? FirstHeaderValue(string name)
    {
        return HeaderValues(name).FirstOrDefault();
    }
}

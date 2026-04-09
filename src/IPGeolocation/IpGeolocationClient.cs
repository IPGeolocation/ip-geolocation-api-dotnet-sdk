using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using IPGeolocation.Internal;

namespace IPGeolocation;

/// <summary>
/// Main client for the IPGeolocation.io IP Location API.
///
/// Homepage: https://ipgeolocation.io
/// IP Location API: https://ipgeolocation.io/ip-location-api.html
/// Documentation: https://ipgeolocation.io/documentation/ip-location-api.html
/// </summary>
public sealed class IpGeolocationClient : IDisposable
{
    private readonly IpGeolocationClientConfig _config;
    private readonly HttpTransport _transport;
    private readonly bool _ownsTransport;
    private bool _disposed;

    public IpGeolocationClient(IpGeolocationClientConfig? config = null)
        : this(config, null)
    {
    }

    internal IpGeolocationClient(IpGeolocationClientConfig? config, HttpTransport? transport)
    {
        _config = config ?? new IpGeolocationClientConfig();
        _transport = transport ?? new HttpClientTransport();
        _ownsTransport = transport is null;
    }

    public static string DefaultUserAgent => "ipgeolocation-dotnet-sdk/" + SdkVersion.Value;

    public void Dispose()
    {
        if (_disposed)
        {
            return;
        }

        _disposed = true;
        if (_ownsTransport)
        {
            _transport.Dispose();
        }
    }

    public async Task<ApiResponse<IpGeolocationResponse>> LookupIpGeolocationAsync(
        LookupIpGeolocationRequest? request = null,
        CancellationToken cancellationToken = default)
    {
        EnsureNotDisposed();
        var typedRequest = request ?? new LookupIpGeolocationRequest();
        ValidateLookupRequestBase();
        SerDe.ValidateJsonOutput(typedRequest.Output);

        var (response, durationMs) = await ExecuteWithMetricsAsync(BuildLookupHttpRequest(typedRequest), cancellationToken).ConfigureAwait(false);
        if (!IsSuccessStatus(response.StatusCode))
        {
            throw SerDe.ToApiException(response.StatusCode, response.Body);
        }

        return new ApiResponse<IpGeolocationResponse>(
            SerDe.ParseSingleLookup(response.Body),
            SerDe.ToMetadata(response.StatusCode, durationMs, response.Headers)
        );
    }

    public async Task<ApiResponse<string>> LookupIpGeolocationRawAsync(
        LookupIpGeolocationRequest? request = null,
        CancellationToken cancellationToken = default)
    {
        EnsureNotDisposed();
        var typedRequest = request ?? new LookupIpGeolocationRequest();
        ValidateLookupRequestBase();

        var (response, durationMs) = await ExecuteWithMetricsAsync(BuildLookupHttpRequest(typedRequest), cancellationToken).ConfigureAwait(false);
        if (!IsSuccessStatus(response.StatusCode))
        {
            throw SerDe.ToApiException(response.StatusCode, response.Body);
        }

        return new ApiResponse<string>(
            response.Body,
            SerDe.ToMetadata(response.StatusCode, durationMs, response.Headers)
        );
    }

    public async Task<ApiResponse<IReadOnlyList<BulkLookupResult>>> BulkLookupIpGeolocationAsync(
        BulkLookupIpGeolocationRequest request,
        CancellationToken cancellationToken = default)
    {
        EnsureNotDisposed();
        if (request is null)
        {
            throw new ArgumentNullException(nameof(request));
        }
        ValidateBulkRequestBase();
        SerDe.ValidateJsonOutput(request.Output);

        var (response, durationMs) = await ExecuteWithMetricsAsync(BuildBulkHttpRequest(request), cancellationToken).ConfigureAwait(false);
        if (!IsSuccessStatus(response.StatusCode))
        {
            throw SerDe.ToApiException(response.StatusCode, response.Body);
        }

        return new ApiResponse<IReadOnlyList<BulkLookupResult>>(
            SerDe.ParseBulkLookup(response.Body),
            SerDe.ToMetadata(response.StatusCode, durationMs, response.Headers)
        );
    }

    public async Task<ApiResponse<string>> BulkLookupIpGeolocationRawAsync(
        BulkLookupIpGeolocationRequest request,
        CancellationToken cancellationToken = default)
    {
        EnsureNotDisposed();
        if (request is null)
        {
            throw new ArgumentNullException(nameof(request));
        }
        ValidateBulkRequestBase();

        var (response, durationMs) = await ExecuteWithMetricsAsync(BuildBulkHttpRequest(request), cancellationToken).ConfigureAwait(false);
        if (!IsSuccessStatus(response.StatusCode))
        {
            throw SerDe.ToApiException(response.StatusCode, response.Body);
        }

        return new ApiResponse<string>(
            response.Body,
            SerDe.ToMetadata(response.StatusCode, durationMs, response.Headers)
        );
    }

    private void EnsureNotDisposed()
    {
        if (_disposed)
        {
            throw new ValidationException("client is disposed");
        }
    }

    private void ValidateLookupRequestBase()
    {
        if (_config.ApiKey is null && _config.RequestOrigin is null)
        {
            throw new ValidationException("single lookup requires apiKey or requestOrigin in client config");
        }
    }

    private void ValidateBulkRequestBase()
    {
        if (_config.ApiKey is null)
        {
            throw new ValidationException("bulk lookup requires apiKey in client config");
        }
    }

    private HttpRequestData BuildLookupHttpRequest(LookupIpGeolocationRequest request)
    {
        var headers = BuildHeaders(request.Headers, request.UserAgent, request.Output, includeContentType: false);
        var query = SerDe.BuildQueryString(new Dictionary<string, string?>
        {
            ["apiKey"] = _config.ApiKey,
            ["ip"] = request.Ip,
            ["lang"] = request.Lang,
            ["include"] = request.Include.Count == 0 ? null : string.Join(",", request.Include),
            ["fields"] = request.Fields.Count == 0 ? null : string.Join(",", request.Fields),
            ["excludes"] = request.Excludes.Count == 0 ? null : string.Join(",", request.Excludes),
            ["output"] = request.Output == ResponseFormat.Xml ? "xml" : "json",
        });

        return new HttpRequestData(
            url: _config.BaseUrl + "/v3/ipgeo" + query,
            method: HttpMethod.Get,
            headers: headers,
            body: null,
            connectTimeout: _config.ConnectTimeout,
            readTimeout: _config.ReadTimeout
        );
    }

    private HttpRequestData BuildBulkHttpRequest(BulkLookupIpGeolocationRequest request)
    {
        string payload;
        try
        {
            payload = JsonSerializer.Serialize(new Dictionary<string, IReadOnlyList<string>>
            {
                ["ips"] = request.Ips
            });
        }
        catch (Exception error)
        {
            throw new SerializationException("Failed to serialize bulk lookup request body", error);
        }

        var headers = BuildHeaders(request.Headers, request.UserAgent, request.Output, includeContentType: true);
        var query = SerDe.BuildQueryString(new Dictionary<string, string?>
        {
            ["apiKey"] = _config.ApiKey,
            ["lang"] = request.Lang,
            ["include"] = request.Include.Count == 0 ? null : string.Join(",", request.Include),
            ["fields"] = request.Fields.Count == 0 ? null : string.Join(",", request.Fields),
            ["excludes"] = request.Excludes.Count == 0 ? null : string.Join(",", request.Excludes),
            ["output"] = request.Output == ResponseFormat.Xml ? "xml" : "json",
        });

        return new HttpRequestData(
            url: _config.BaseUrl + "/v3/ipgeo-bulk" + query,
            method: HttpMethod.Post,
            headers: headers,
            body: payload,
            connectTimeout: _config.ConnectTimeout,
            readTimeout: _config.ReadTimeout
        );
    }

    private Dictionary<string, string> BuildHeaders(
        IReadOnlyDictionary<string, string> requestHeaders,
        string? requestUserAgent,
        ResponseFormat output,
        bool includeContentType)
    {
        var headers = new Dictionary<string, string>(requestHeaders, StringComparer.OrdinalIgnoreCase);

        headers["User-Agent"] = SerDe.ResolveUserAgent(requestUserAgent, requestHeaders, DefaultUserAgent);
        headers["Accept"] = output == ResponseFormat.Xml ? "application/xml" : "application/json";

        if (_config.RequestOrigin is not null)
        {
            headers["Origin"] = _config.RequestOrigin;
        }

        if (includeContentType)
        {
            headers["Content-Type"] = "application/json";
        }

        return headers;
    }

    private async Task<(HttpResponseData Response, int DurationMs)> ExecuteWithMetricsAsync(HttpRequestData request, CancellationToken cancellationToken)
    {
        var stopwatch = Stopwatch.StartNew();
        var response = await _transport.SendAsync(request, cancellationToken).ConfigureAwait(false);
        stopwatch.Stop();
        return (response, (int)stopwatch.ElapsedMilliseconds);
    }

    private static bool IsSuccessStatus(int statusCode)
    {
        return statusCode >= 200 && statusCode <= 299;
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IPGeolocation.Internal;

internal sealed class HttpClientTransport : HttpTransport
{
    internal const int DefaultMaxResponseBodyBytes = 134217728;

    private readonly HttpClient _httpClient;
    private readonly int _maxResponseBodyBytes;

    internal HttpClientTransport(HttpClient? httpClient = null, int maxResponseBodyBytes = DefaultMaxResponseBodyBytes)
    {
        if (maxResponseBodyBytes <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(maxResponseBodyBytes), "maxResponseBodyBytes must be greater than zero");
        }

        _httpClient = httpClient ?? new HttpClient
        {
            Timeout = Timeout.InfiniteTimeSpan
        };
        _maxResponseBodyBytes = maxResponseBodyBytes;
    }

    public void Dispose()
    {
        _httpClient.Dispose();
    }

    public async Task<HttpResponseData> SendAsync(HttpRequestData request, CancellationToken cancellationToken)
    {
        using var message = new HttpRequestMessage(request.Method, request.Url);

        if (request.Body is not null)
        {
            message.Content = new StringContent(request.Body, Encoding.UTF8);
        }

        foreach (var header in request.Headers)
        {
            if (!message.Headers.TryAddWithoutValidation(header.Key, header.Value))
            {
                message.Content ??= new StringContent(string.Empty, Encoding.UTF8);

                if (string.Equals(header.Key, "Content-Type", StringComparison.OrdinalIgnoreCase))
                {
                    message.Content.Headers.ContentType = MediaTypeHeaderValue.Parse(header.Value);
                }
                else
                {
                    message.Content.Headers.TryAddWithoutValidation(header.Key, header.Value);
                }
            }
        }

        HttpResponseMessage response;
        using (var connectCts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken))
        {
            connectCts.CancelAfter(request.ConnectTimeout);

            try
            {
                response = await _httpClient.SendAsync(message, HttpCompletionOption.ResponseHeadersRead, connectCts.Token).ConfigureAwait(false);
            }
            catch (OperationCanceledException error) when (connectCts.IsCancellationRequested && !cancellationToken.IsCancellationRequested)
            {
                throw new RequestTimeoutException("HTTP request timed out while opening the connection or waiting for response headers", error);
            }
            catch (HttpRequestException error)
            {
                throw new TransportException("HTTP transport error", error);
            }
        }

        using (response)
        {
            var body = await ReadBodyAsync(response, request.ReadTimeout, cancellationToken).ConfigureAwait(false);
            var headers = new Dictionary<string, IReadOnlyList<string>>(StringComparer.OrdinalIgnoreCase);

            foreach (var header in response.Headers)
            {
                headers[header.Key] = header.Value.ToArray();
            }

            foreach (var header in response.Content.Headers)
            {
                headers[header.Key] = header.Value.ToArray();
            }

            return new HttpResponseData((int)response.StatusCode, body, headers);
        }
    }

    private async Task<string> ReadBodyAsync(HttpResponseMessage response, TimeSpan readTimeout, CancellationToken cancellationToken)
    {
        Stream stream;
        try
        {
            stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        }
        catch (HttpRequestException error)
        {
            throw new TransportException("HTTP transport error while opening the response body stream", error);
        }
        catch (IOException error)
        {
            throw new TransportException("HTTP transport error while opening the response body stream", error);
        }

        await using var responseStream = stream;
        await using var buffer = new MemoryStream();
        var chunk = new byte[8192];

        while (true)
        {
            int bytesRead;
            using (var readCts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken))
            {
                readCts.CancelAfter(readTimeout);

                try
                {
                    bytesRead = await responseStream.ReadAsync(chunk.AsMemory(0, chunk.Length), readCts.Token).ConfigureAwait(false);
                }
                catch (OperationCanceledException error) when (readCts.IsCancellationRequested && !cancellationToken.IsCancellationRequested)
                {
                    throw new RequestTimeoutException("HTTP request timed out while waiting for response body data", error);
                }
                catch (HttpRequestException error)
                {
                    throw new TransportException("HTTP transport error while reading the response body", error);
                }
                catch (IOException error)
                {
                    throw new TransportException("HTTP transport error while reading the response body", error);
                }
            }

            if (bytesRead == 0)
            {
                break;
            }

            if (buffer.Length + bytesRead > _maxResponseBodyBytes)
            {
                throw new TransportException("Response body exceeded max size of " + _maxResponseBodyBytes + " bytes");
            }

            await buffer.WriteAsync(chunk.AsMemory(0, bytesRead), cancellationToken).ConfigureAwait(false);
        }

        return Encoding.UTF8.GetString(buffer.ToArray());
    }
}

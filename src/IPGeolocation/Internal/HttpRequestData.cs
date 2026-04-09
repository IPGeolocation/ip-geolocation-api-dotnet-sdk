using System;
using System.Collections.Generic;
using System.Net.Http;

namespace IPGeolocation.Internal;

internal sealed class HttpRequestData
{
    internal HttpRequestData(
        string url,
        HttpMethod method,
        IReadOnlyDictionary<string, string> headers,
        string? body,
        TimeSpan connectTimeout,
        TimeSpan readTimeout)
    {
        Url = url;
        Method = method;
        Headers = headers;
        Body = body;
        ConnectTimeout = connectTimeout;
        ReadTimeout = readTimeout;
    }

    internal string Url { get; }
    internal HttpMethod Method { get; }
    internal IReadOnlyDictionary<string, string> Headers { get; }
    internal string? Body { get; }
    internal TimeSpan ConnectTimeout { get; }
    internal TimeSpan ReadTimeout { get; }
}

using System.Collections.Generic;

namespace IPGeolocation.Internal;

internal sealed class HttpResponseData
{
    internal HttpResponseData(int statusCode, string body, IReadOnlyDictionary<string, IReadOnlyList<string>> headers)
    {
        StatusCode = statusCode;
        Body = body;
        Headers = headers;
    }

    internal int StatusCode { get; }
    internal string Body { get; }
    internal IReadOnlyDictionary<string, IReadOnlyList<string>> Headers { get; }
}

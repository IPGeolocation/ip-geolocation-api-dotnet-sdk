using System;
using System.Threading;
using System.Threading.Tasks;

namespace IPGeolocation.Internal;

internal interface HttpTransport : IDisposable
{
    Task<HttpResponseData> SendAsync(HttpRequestData request, CancellationToken cancellationToken);
}

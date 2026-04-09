using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using IPGeolocation.Internal;

namespace IPGeolocation.Test.IpLocation.Support;

internal sealed class FakeTransport : HttpTransport
{
    private readonly Queue<Func<HttpRequestData, HttpResponseData>> _responses = new();

    internal HttpRequestData? LastRequest { get; private set; }

    internal bool Disposed { get; private set; }

    internal void QueueResponse(HttpResponseData response)
    {
        _responses.Enqueue(_ => response);
    }

    internal void QueueException(Exception exception)
    {
        _responses.Enqueue(_ => throw exception);
    }

    public void Dispose()
    {
        Disposed = true;
    }

    public Task<HttpResponseData> SendAsync(HttpRequestData request, CancellationToken cancellationToken)
    {
        LastRequest = request;
        if (_responses.Count == 0)
        {
            throw new InvalidOperationException("No fake response queued");
        }

        return Task.FromResult(_responses.Dequeue()(request));
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using IPGeolocation.Internal;
using Xunit;

namespace IPGeolocation.Test.IpLocation;

public sealed class HttpClientTransportTests
{
    [Fact]
    public async Task ReturnsResponseDataAndHeaders()
    {
        using var client = new HttpClient(new StubHandler(_ =>
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("""{"ip":"8.8.8.8"}""")
            };
            response.Headers.Add("X-Credits-Charged", "1");
            return response;
        }));
        using var transport = new HttpClientTransport(client);

        var response = await transport.SendAsync(
            new HttpRequestData(
                "https://api.ipgeolocation.io/v3/ipgeo?apiKey=test-key",
                HttpMethod.Get,
                new Dictionary<string, string> { ["Accept"] = "application/json" },
                null,
                TimeSpan.FromSeconds(10),
                TimeSpan.FromSeconds(30)),
            CancellationToken.None);

        Assert.Equal(200, response.StatusCode);
        Assert.Equal("""{"ip":"8.8.8.8"}""", response.Body);
        Assert.Equal("1", response.Headers["X-Credits-Charged"][0]);
    }

    [Fact]
    public async Task RejectsResponseBodyThatExceedsConfiguredLimit()
    {
        using var client = new HttpClient(new StubHandler(_ =>
        {
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("12345")
            };
        }));
        using var transport = new HttpClientTransport(client, maxResponseBodyBytes: 4);

        var error = await Assert.ThrowsAsync<IPGeolocation.TransportException>(() =>
            transport.SendAsync(
                new HttpRequestData(
                    "https://api.ipgeolocation.io/v3/ipgeo",
                    HttpMethod.Get,
                    new Dictionary<string, string>(),
                    null,
                    TimeSpan.FromSeconds(10),
                    TimeSpan.FromSeconds(30)),
                CancellationToken.None));

        Assert.Equal("Response body exceeded max size of 4 bytes", error.Message);
    }

    [Fact]
    public async Task WrapsResponseBodyStreamOpenFailuresInTransportException()
    {
        using var client = new HttpClient(new StubHandler(_ =>
        {
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new FailingOpenContent(new HttpRequestException("stream open failed"))
            };
        }));
        using var transport = new HttpClientTransport(client);

        var error = await Assert.ThrowsAsync<IPGeolocation.TransportException>(() =>
            transport.SendAsync(CreateRequest(readTimeout: TimeSpan.FromMilliseconds(50)), CancellationToken.None));

        Assert.Equal("HTTP transport error while opening the response body stream", error.Message);
        Assert.IsType<HttpRequestException>(error.InnerException);
    }

    [Fact]
    public async Task WrapsMidBodyReadFailuresInTransportException()
    {
        using var client = new HttpClient(new StubHandler(_ =>
        {
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StreamContent(new FaultingReadStream(
                    Encoding.UTF8.GetBytes("""{"ip":"8.8.8.8"}"""),
                    new IOException("stream read failed")))
            };
        }));
        using var transport = new HttpClientTransport(client);

        var error = await Assert.ThrowsAsync<IPGeolocation.TransportException>(() =>
            transport.SendAsync(CreateRequest(readTimeout: TimeSpan.FromMilliseconds(50)), CancellationToken.None));

        Assert.Equal("HTTP transport error while reading the response body", error.Message);
        Assert.IsType<IOException>(error.InnerException);
    }

    [Fact]
    public async Task WrapsReadTimeoutDuringBodyReadInRequestTimeoutException()
    {
        using var client = new HttpClient(new StubHandler(_ =>
        {
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StreamContent(new TimeoutReadStream())
            };
        }));
        using var transport = new HttpClientTransport(client);

        var error = await Assert.ThrowsAsync<IPGeolocation.RequestTimeoutException>(() =>
            transport.SendAsync(CreateRequest(readTimeout: TimeSpan.FromMilliseconds(50)), CancellationToken.None));

        Assert.Equal("HTTP request timed out while waiting for response body data", error.Message);
        Assert.IsAssignableFrom<OperationCanceledException>(error.InnerException);
    }

    private static HttpRequestData CreateRequest(TimeSpan? connectTimeout = null, TimeSpan? readTimeout = null)
    {
        return new HttpRequestData(
            "https://api.ipgeolocation.io/v3/ipgeo",
            HttpMethod.Get,
            new Dictionary<string, string>(),
            null,
            connectTimeout ?? TimeSpan.FromSeconds(10),
            readTimeout ?? TimeSpan.FromSeconds(30));
    }

    private sealed class StubHandler : HttpMessageHandler
    {
        private readonly Func<HttpRequestMessage, HttpResponseMessage> _handler;

        public StubHandler(Func<HttpRequestMessage, HttpResponseMessage> handler)
        {
            _handler = handler;
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_handler(request));
        }
    }

    private sealed class FailingOpenContent : HttpContent
    {
        private readonly Exception _error;

        public FailingOpenContent(Exception error)
        {
            _error = error;
        }

        protected override Task SerializeToStreamAsync(Stream stream, TransportContext? context)
        {
            throw new NotSupportedException();
        }

        protected override bool TryComputeLength(out long length)
        {
            length = 0;
            return false;
        }

        protected override Task<Stream> CreateContentReadStreamAsync()
        {
            return Task.FromException<Stream>(_error);
        }
    }

    private sealed class FaultingReadStream : Stream
    {
        private readonly byte[] _prefix;
        private readonly Exception _error;
        private int _position;
        private bool _failed;

        public FaultingReadStream(byte[] prefix, Exception error)
        {
            _prefix = prefix;
            _error = error;
        }

        public override bool CanRead => true;
        public override bool CanSeek => false;
        public override bool CanWrite => false;
        public override long Length => throw new NotSupportedException();
        public override long Position
        {
            get => _position;
            set => throw new NotSupportedException();
        }

        public override void Flush()
        {
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            if (_position < _prefix.Length)
            {
                var bytesToCopy = Math.Min(count, _prefix.Length - _position);
                Array.Copy(_prefix, _position, buffer, offset, bytesToCopy);
                _position += bytesToCopy;
                return bytesToCopy;
            }

            if (_failed)
            {
                return 0;
            }

            _failed = true;
            throw _error;
        }

        public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default)
        {
            if (_position < _prefix.Length)
            {
                var bytesToCopy = Math.Min(buffer.Length, _prefix.Length - _position);
                _prefix.AsMemory(_position, bytesToCopy).CopyTo(buffer);
                _position += bytesToCopy;
                return ValueTask.FromResult(bytesToCopy);
            }

            if (_failed)
            {
                return ValueTask.FromResult(0);
            }

            _failed = true;
            return ValueTask.FromException<int>(_error);
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            throw new NotSupportedException();
        }

        public override void SetLength(long value)
        {
            throw new NotSupportedException();
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            throw new NotSupportedException();
        }
    }

    private sealed class TimeoutReadStream : Stream
    {
        public override bool CanRead => true;
        public override bool CanSeek => false;
        public override bool CanWrite => false;
        public override long Length => throw new NotSupportedException();
        public override long Position
        {
            get => 0;
            set => throw new NotSupportedException();
        }

        public override void Flush()
        {
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            throw new NotSupportedException();
        }

        public override async ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default)
        {
            await Task.Delay(Timeout.InfiniteTimeSpan, cancellationToken).ConfigureAwait(false);
            return 0;
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            throw new NotSupportedException();
        }

        public override void SetLength(long value)
        {
            throw new NotSupportedException();
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            throw new NotSupportedException();
        }
    }
}

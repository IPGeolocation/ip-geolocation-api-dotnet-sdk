using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using IPGeolocation.Internal;
using IPGeolocation.Test.IpLocation.Support;
using Xunit;

namespace IPGeolocation.Test.IpLocation;

public sealed class ErrorHandlingTests
{
    private const string ApiKey = "test-secret+/value";

    public static IEnumerable<object[]> ApiFailures()
    {
        var statuses = new (int Status, Type Type)[]
        {
            (400, typeof(BadRequestException)), (401, typeof(UnauthorizedException)),
            (403, typeof(ForbiddenException)), (404, typeof(NotFoundException)),
            (405, typeof(MethodNotAllowedException)), (413, typeof(ContentTooLargeException)),
            (415, typeof(UnsupportedMediaTypeException)), (423, typeof(LockedException)),
            (429, typeof(TooManyRequestsException)), (499, typeof(CustomStatus499Exception)),
            (500, typeof(InternalServerErrorException)), (502, typeof(ApiException))
        };
        for (var method = 0; method < 4; method++)
        {
            foreach (var status in statuses) yield return new object[] { method, status.Status, status.Type };
        }
    }

    [Theory]
    [MemberData(nameof(ApiFailures))]
    public async Task ApiErrorsHideKeysAndPreserveStatus(int method, int status, Type expectedType)
    {
        var transport = Response(status, JsonSerializer.Serialize(new { message = "Invalid API key: " + ApiKey }));
        using var client = Client(transport);

        var error = await Assert.ThrowsAnyAsync<ApiException>(() => Invoke(client, method));

        Assert.Equal(expectedType, error.GetType());
        Assert.Equal((HttpStatusCode)status, error.StatusCode);
        Assert.Equal("Invalid API key: [REDACTED]", error.Message);
        AssertHidden(error);
        Assert.Contains("apiKey=" + Uri.EscapeDataString(ApiKey), transport.LastRequest!.Url);
    }

    [Theory]
    [InlineData("plain")]
    [InlineData("encoded")]
    [InlineData("encoded-lower")]
    [InlineData("nested")]
    public async Task RedactsDifferentErrorBodies(string form)
    {
        var encoded = Uri.EscapeDataString(ApiKey);
        var body = form switch
        {
            "plain" => "<html>Invalid key " + ApiKey + "</html>",
            "encoded" => "Request failed: ?apiKey=" + encoded,
            "encoded-lower" => "Request failed: ?apiKey=" + encoded.Replace("%2B", "%2b").Replace("%2F", "%2f"),
            "nested" => JsonSerializer.Serialize(new { error = new { message = ApiKey } }),
            _ => JsonSerializer.Serialize(new { details = ApiKey })
        };
        using var client = Client(Response(503, body));

        var error = await Assert.ThrowsAsync<ApiException>(() => client.LookupIpGeolocationRawAsync());

        AssertHidden(error);
        Assert.DoesNotContain(encoded, error.ToString(), StringComparison.OrdinalIgnoreCase);
        Assert.Contains("[REDACTED]", error.Message);
    }

    [Theory]
    [InlineData("{\"details\":\"test\\u002Dsecret+/value\"}")]
    [InlineData("[\"test\\u002Dsecret+/value\"]")]
    [InlineData("{\"error\":{\"details\":\"test\\u002Dsecret+/value\"}}")]
    [InlineData("{\"message\":\"test\\u002Dsecret+/value\"")]
    [InlineData("\" \"")]
    public async Task UnknownStructuredErrorsUseTheStatusMessage(string body)
    {
        using var client = Client(Response(401, body));

        var error = await Assert.ThrowsAsync<UnauthorizedException>(() => client.LookupIpGeolocationAsync());

        Assert.Equal("Unauthorized", error.Message);
        AssertHidden(error);
    }

    [Fact]
    public async Task OverlyNestedJsonErrorsUseTheStatusMessage()
    {
        var body = new string('[', 70) + "\"test\\u002Dsecret+/value\"" + new string(']', 70);
        using var client = Client(Response(401, body));

        var error = await Assert.ThrowsAsync<UnauthorizedException>(() => client.LookupIpGeolocationAsync());

        Assert.Equal("Unauthorized", error.Message);
    }

    [Theory]
    [InlineData("{\"message\":\"test\\u002Dsecret+/value\"}")]
    [InlineData("{\"error\":{\"message\":\"test\\u002Dsecret+/value\"}}")]
    [InlineData("\"test\\u002Dsecret+/value\"")]
    public async Task JsonEscapesAreDecodedBeforeRedaction(string body)
    {
        using var client = Client(Response(401, body));

        var error = await Assert.ThrowsAsync<UnauthorizedException>(() => client.LookupIpGeolocationAsync());

        Assert.Equal("[REDACTED]", error.Message);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    public async Task TransportErrorsDoNotRetainOriginalDetails(int method)
    {
        var detail = new SecretException(ApiKey);
        var original = new TransportException("Network error " + ApiKey, new AggregateException(detail));
        original.Data["key"] = ApiKey;
        original.HelpLink = "https://example.invalid/" + ApiKey;
        var transport = new FakeTransport();
        transport.QueueException(original);
        using var client = Client(transport);

        var error = await Assert.ThrowsAsync<TransportException>(() => Invoke(client, method));

        AssertHidden(error);
        Assert.NotSame(original, error);
        for (Exception? current = error; current is not null; current = current.InnerException)
        {
            Assert.NotSame(original, current);
            Assert.NotSame(detail, current);
            Assert.Empty(current.Data);
            Assert.Null(current.HelpLink);
            Assert.IsNotType<SecretException>(current);
            Assert.IsNotType<AggregateException>(current);
        }
    }

    [Fact]
    public async Task DeepErrorDetailsAreBounded()
    {
        Exception detail = new SecretException(ApiKey);
        for (var i = 0; i < 100; i++) detail = new Exception("Nested " + ApiKey, detail);
        var transport = new FakeTransport();
        transport.QueueException(new RequestTimeoutException("Timeout " + ApiKey, detail));
        using var client = Client(transport);

        var error = await Assert.ThrowsAsync<RequestTimeoutException>(() => client.LookupIpGeolocationAsync());

        AssertHidden(error);
        var depth = 0;
        for (Exception? current = error; current is not null; current = current.InnerException) depth++;
        Assert.InRange(depth, 1, 12);
    }

    [Fact]
    public async Task CallerCancellationRemainsCancellation()
    {
        using var source = new CancellationTokenSource();
        source.Cancel();
        var transport = new FakeTransport();
        transport.QueueException(new OperationCanceledException("Cancelled " + ApiKey, new SecretException(ApiKey), source.Token));
        using var client = Client(transport);

        var task = client.LookupIpGeolocationAsync(cancellationToken: source.Token);
        var error = await Assert.ThrowsAnyAsync<OperationCanceledException>(() => task);

        Assert.True(task.IsCanceled);
        Assert.Equal(source.Token, error.CancellationToken);
        AssertHidden(error);
    }

    [Fact]
    public async Task OriginOnlyRequestsKeepTheirOriginalErrorDetails()
    {
        var original = new TransportException("Unchanged details", new HttpRequestException("Original cause"));
        var transport = new FakeTransport();
        transport.QueueException(original);
        using var client = new IpGeolocationClient(new IpGeolocationClientConfig(requestOrigin: "https://example.com"), transport);

        var error = await Assert.ThrowsAsync<TransportException>(() => client.LookupIpGeolocationAsync());

        Assert.Same(original, error);
    }

    [Fact]
    public async Task TypedBulkRedactsOnlyErrorMessages()
    {
        var body = JsonSerializer.Serialize(new object[] { new { ip = ApiKey }, new { error = new { message = ApiKey } } });
        using var client = Client(Response(200, body));

        var result = await client.BulkLookupIpGeolocationAsync(new BulkLookupIpGeolocationRequest(new[] { "8.8.8.8" }));

        Assert.Equal(ApiKey, Assert.IsType<BulkLookupSuccess>(result.Data[0]).Data.Ip);
        Assert.Equal("[REDACTED]", Assert.IsType<BulkLookupError>(result.Data[1]).Error.Message);
    }

    [Theory]
    [InlineData(false, ResponseFormat.Json)]
    [InlineData(false, ResponseFormat.Xml)]
    [InlineData(true, ResponseFormat.Json)]
    [InlineData(true, ResponseFormat.Xml)]
    public async Task SuccessfulRawBodiesStayUnchanged(bool bulk, ResponseFormat output)
    {
        var body = output == ResponseFormat.Json ? JsonSerializer.Serialize(new { message = ApiKey }) : "<value>" + ApiKey + "</value>";
        using var client = Client(Response(200, body));

        var result = bulk
            ? await client.BulkLookupIpGeolocationRawAsync(new BulkLookupIpGeolocationRequest(new[] { "8.8.8.8" }, output: output))
            : await client.LookupIpGeolocationRawAsync(new LookupIpGeolocationRequest(output: output));

        Assert.Equal(body, result.Data);
    }

    [Fact]
    public async Task JsonParseErrorsDoNotExposeKeysInTheirDetails()
    {
        using var client = Client(Response(200, "{\"" + ApiKey + "\": invalid}"));

        var error = await Assert.ThrowsAsync<SerializationException>(() => client.LookupIpGeolocationAsync());

        AssertHidden(error);
    }

    [Theory]
    [InlineData("test-key")]
    [InlineData("test+key/with spaces")]
    [InlineData("test-مفتاح-🔑")]
    [InlineData("test-\"quoted\"-key")]
    [InlineData("test.*(key)[1]")]
    public async Task EncodedKeysAreHiddenWithoutChangingAuthentication(string key)
    {
        var json = JsonSerializer.Serialize(key);
        var forms = new[] { key, Uri.EscapeDataString(key), json.Substring(1, json.Length - 2) };
        foreach (var form in forms)
        {
            var transport = Response(401, "Rejected: " + form);
            using var client = new IpGeolocationClient(new IpGeolocationClientConfig(apiKey: key), transport);

            var error = await Assert.ThrowsAsync<UnauthorizedException>(() => client.LookupIpGeolocationRawAsync());

            Assert.Equal("Rejected: [REDACTED]", error.Message);
            Assert.Contains("apiKey=" + Uri.EscapeDataString(key), transport.LastRequest!.Url);
        }
    }

    [Fact]
    public async Task UnreadableErrorMessagesDoNotReplaceTheSdkError()
    {
        var transport = new FakeTransport();
        transport.QueueException(new TransportException("Failure", new UnreadableException()));
        using var client = Client(transport);

        var error = await Assert.ThrowsAsync<TransportException>(() => client.LookupIpGeolocationAsync());

        Assert.Equal("Failure", error.Message);
        Assert.Contains("Error details unavailable.", error.InnerException!.Message);
        AssertHidden(error);
    }

    [Fact]
    public async Task TaskCancellationKeepsItsTypeAndToken()
    {
        using var source = new CancellationTokenSource();
        source.Cancel();
        var transport = new FakeTransport();
        transport.QueueException(new TaskCanceledException(ApiKey, null, source.Token));
        using var client = Client(transport);

        var task = client.LookupIpGeolocationAsync(cancellationToken: source.Token);
        var error = await Assert.ThrowsAsync<TaskCanceledException>(() => task);

        Assert.True(task.IsCanceled);
        Assert.Equal(source.Token, error.CancellationToken);
        Assert.Equal("[REDACTED]", error.Message);
    }

    private static FakeTransport Response(int status, string body)
    {
        var transport = new FakeTransport();
        transport.QueueResponse(new HttpResponseData(status, body, new Dictionary<string, IReadOnlyList<string>>()));
        return transport;
    }

    private static IpGeolocationClient Client(FakeTransport transport) => new(new IpGeolocationClientConfig(apiKey: ApiKey), transport);

    private static Task Invoke(IpGeolocationClient client, int method) => method switch
    {
        0 => client.LookupIpGeolocationAsync(),
        1 => client.LookupIpGeolocationRawAsync(),
        2 => client.BulkLookupIpGeolocationAsync(new BulkLookupIpGeolocationRequest(new[] { "8.8.8.8" })),
        _ => client.BulkLookupIpGeolocationRawAsync(new BulkLookupIpGeolocationRequest(new[] { "8.8.8.8" }))
    };

    private static void AssertHidden(Exception error) => Assert.DoesNotContain(ApiKey, error.ToString(), StringComparison.Ordinal);

    private sealed class SecretException : Exception
    {
        public SecretException(string key) : base("Underlying error " + key)
        {
            Secret = key;
            Data["key"] = key;
        }

        public string Secret { get; }
        public override string ToString() => Secret;
    }

    private sealed class UnreadableException : Exception
    {
        public override string Message => throw new InvalidOperationException(ApiKey);
    }
}

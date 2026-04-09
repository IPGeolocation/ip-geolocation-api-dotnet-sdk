using System;
using System.Net;

namespace IPGeolocation;

public class IpGeolocationException : Exception
{
    public IpGeolocationException(string message, Exception? innerException = null)
        : base(message, innerException)
    {
    }
}

public sealed class ValidationException : IpGeolocationException
{
    public ValidationException(string message)
        : base(message)
    {
    }
}

public class TransportException : IpGeolocationException
{
    public TransportException(string message, Exception? innerException = null)
        : base(message, innerException)
    {
    }
}

public sealed class RequestTimeoutException : TransportException
{
    public RequestTimeoutException(string message, Exception? innerException = null)
        : base(message, innerException)
    {
    }
}

public sealed class SerializationException : IpGeolocationException
{
    public SerializationException(string message, Exception? innerException = null)
        : base(message, innerException)
    {
    }
}

public class ApiException : IpGeolocationException
{
    public ApiException(HttpStatusCode statusCode, string message)
        : base(message)
    {
        StatusCode = statusCode;
    }

    public HttpStatusCode StatusCode { get; }
}

public sealed class BadRequestException : ApiException
{
    public BadRequestException(string message) : base(HttpStatusCode.BadRequest, message) { }
}

public sealed class UnauthorizedException : ApiException
{
    public UnauthorizedException(string message) : base(HttpStatusCode.Unauthorized, message) { }
}

public sealed class ForbiddenException : ApiException
{
    public ForbiddenException(string message) : base(HttpStatusCode.Forbidden, message) { }
}

public sealed class NotFoundException : ApiException
{
    public NotFoundException(string message) : base(HttpStatusCode.NotFound, message) { }
}

public sealed class MethodNotAllowedException : ApiException
{
    public MethodNotAllowedException(string message) : base(HttpStatusCode.MethodNotAllowed, message) { }
}

public sealed class ContentTooLargeException : ApiException
{
    public ContentTooLargeException(string message) : base(HttpStatusCode.RequestEntityTooLarge, message) { }
}

public sealed class UnsupportedMediaTypeException : ApiException
{
    public UnsupportedMediaTypeException(string message) : base(HttpStatusCode.UnsupportedMediaType, message) { }
}

public sealed class LockedException : ApiException
{
    public LockedException(string message) : base((HttpStatusCode)423, message) { }
}

public sealed class TooManyRequestsException : ApiException
{
    public TooManyRequestsException(string message) : base((HttpStatusCode)429, message) { }
}

public sealed class CustomStatus499Exception : ApiException
{
    public CustomStatus499Exception(string message) : base((HttpStatusCode)499, message) { }
}

public sealed class InternalServerErrorException : ApiException
{
    public InternalServerErrorException(string message) : base(HttpStatusCode.InternalServerError, message) { }
}

using System;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IPGeolocation.Internal;

internal static class ErrorSanitizer
{
    internal static string Redact(string value, string? apiKey)
    {
        if (apiKey is null) return value;

        try
        {
            var json = JsonSerializer.Serialize(apiKey);
            var forms = new[] { apiKey, Uri.EscapeDataString(apiKey), json.Substring(1, json.Length - 2) };
            var pattern = string.Join("|", forms.Distinct(StringComparer.OrdinalIgnoreCase)
                .OrderByDescending(form => form.Length).Select(Regex.Escape));
            return new Regex(pattern, RegexOptions.CultureInvariant | RegexOptions.IgnoreCase, TimeSpan.FromSeconds(1))
                .Replace(value, "[REDACTED]");
        }
        catch (Exception)
        {
            return "Error details omitted.";
        }
    }

    internal static Exception Sanitize(Exception error, string apiKey)
    {
        var message = Redact(ReadMessage(error), apiKey);
        var inner = CopyDetails(error.InnerException, apiKey, 0);

        return error switch
        {
            ApiException api when api.GetType() == typeof(ApiException) => new ApiException(api.StatusCode, message),
            ApiException api => SerDe.CreateApiException((int)api.StatusCode, message),
            ValidationException _ => new ValidationException(message),
            RequestTimeoutException _ => new RequestTimeoutException(message, inner),
            TransportException _ => new TransportException(message, inner),
            SerializationException _ => new SerializationException(message, inner),
            IpGeolocationException _ => new IpGeolocationException(message, inner),
            TaskCanceledException canceled => new TaskCanceledException(message, inner, canceled.CancellationToken),
            OperationCanceledException canceled => new OperationCanceledException(message, inner, canceled.CancellationToken),
            _ => new TransportException(message, CopyDetails(error, apiKey, 0))
        };
    }

    private static Exception? CopyDetails(Exception? error, string apiKey, int depth)
    {
        if (error is null) return null;
        if (depth == 8) return new Exception("Additional error details omitted.");

        return new Exception(
            Redact(error.GetType().Name + ": " + ReadMessage(error), apiKey),
            CopyDetails(error.InnerException, apiKey, depth + 1));
    }

    private static string ReadMessage(Exception error)
    {
        try
        {
            return error.Message;
        }
        catch (Exception)
        {
            return "Error details unavailable.";
        }
    }
}

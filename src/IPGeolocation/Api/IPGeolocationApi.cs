

#nullable enable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using IPGeolocation.Client;
using IPGeolocation.Model;

namespace IPGeolocation.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// This class is registered as transient.
    /// </summary>
    public interface IIPGeolocationApi : IApi
    {
        /// <summary>
        /// The class containing the events
        /// </summary>
        IPLocationApiEvents Events { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This feature is available only on our paid API subscriptions (STANDARD or ADVANCED). This endpoint allows you to perform the geolocation lookup for multiple IPv4, IPv6 addresses or domain names (maximum 50,000) at the same time. The requests count per lookup is equal to total IP addresses or domain names passed. To perform bulk IP Geolocation Lookup, send a POST request and pass the \&quot;ips\&quot; array as JSON data along with it.  
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="bulkIPRequest"></param>
        /// <param name="lang">By default, the API responds in English. You can change the response language by passing the language code as a query parameter &#x60;lang&#x60;. Multi language feature is available only for &#x60;paid users&#x60;. (optional)</param>
        /// <param name="fields">you can filter the API response by specifying the fields that you need, instead of getting the full response. To do this, pass the desired field names using the &#x60;fields&#x60; query parameter with each field represented as a dot-separated path. (optional)</param>
        /// <param name="excludes">you can also filter the API response by excluding specific fields (except the IP address) that you don&#39;t need. To do this, pass the unwanted field names using the excludes query parameter, with each field represented as a dot-separated path (optional)</param>
        /// <param name="include">IP Geolocation API also provides IP-Security, abuse, timezone, user-agent and DMA (Designated Market Area) code, which is specifically used in the US for marketing and regional targeting information on Advanced API subscription, but doesn&#39;t respond it by default. To get these information along with the geolocation information, you must pass the &#x60;include&#x3D;security&#x60; or &#x60;include&#x3D;abuse&#x60; or &#x60;include&#x3D;dma&#x60; or &#x60;include&#x3D;time_zone&#x60; or &#x60;include&#x3D;user-agent&#x60; or you can fetch multiples by adding values in comma-separated way. In addition to that, IPGeolocation API also provide hostname lookup for an IP address on all the paid API subscriptions (STANDARD and ADVANCED), but doesn&#39;t respond it by default. To get the hostname for an IP address, you can pass one of the three values &#x60;hostname, liveHostname, hostnameFallbackLive&#x60; as a URL parameter &#x60;include&#x3D;&#x60;. (optional)</param>
        /// <param name="output">Desired output format(json or xml). (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IBulkIPGeolocationApiResponse"/>&gt;</returns>
        Task<IBulkIPGeolocationApiResponse> GetBulkIpGeolocationAsync(BulkIPRequest bulkIPRequest, Option<string> lang = default, Option<string> fields = default, Option<string> excludes = default, Option<string> include = default, Option<string> output = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// This feature is available only on our paid API subscriptions (STANDARD or ADVANCED). This endpoint allows you to perform the geolocation lookup for multiple IPv4, IPv6 addresses or domain names (maximum 50,000) at the same time. The requests count per lookup is equal to total IP addresses or domain names passed. To perform bulk IP Geolocation Lookup, send a POST request and pass the \&quot;ips\&quot; array as JSON data along with it.  
        /// </remarks>
        /// <param name="bulkIPRequest"></param>
        /// <param name="lang">By default, the API responds in English. You can change the response language by passing the language code as a query parameter &#x60;lang&#x60;. Multi language feature is available only for &#x60;paid users&#x60;. (optional)</param>
        /// <param name="fields">you can filter the API response by specifying the fields that you need, instead of getting the full response. To do this, pass the desired field names using the &#x60;fields&#x60; query parameter with each field represented as a dot-separated path. (optional)</param>
        /// <param name="excludes">you can also filter the API response by excluding specific fields (except the IP address) that you don&#39;t need. To do this, pass the unwanted field names using the excludes query parameter, with each field represented as a dot-separated path (optional)</param>
        /// <param name="include">IP Geolocation API also provides IP-Security, abuse, timezone, user-agent and DMA (Designated Market Area) code, which is specifically used in the US for marketing and regional targeting information on Advanced API subscription, but doesn&#39;t respond it by default. To get these information along with the geolocation information, you must pass the &#x60;include&#x3D;security&#x60; or &#x60;include&#x3D;abuse&#x60; or &#x60;include&#x3D;dma&#x60; or &#x60;include&#x3D;time_zone&#x60; or &#x60;include&#x3D;user-agent&#x60; or you can fetch multiples by adding values in comma-separated way. In addition to that, IPGeolocation API also provide hostname lookup for an IP address on all the paid API subscriptions (STANDARD and ADVANCED), but doesn&#39;t respond it by default. To get the hostname for an IP address, you can pass one of the three values &#x60;hostname, liveHostname, hostnameFallbackLive&#x60; as a URL parameter &#x60;include&#x3D;&#x60;. (optional)</param>
        /// <param name="output">Desired output format(json or xml). (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IBulkIPGeolocationApiResponse"/>?&gt;</returns>
        Task<IBulkIPGeolocationApiResponse?> GetBulkIpGeolocationOrDefaultAsync(BulkIPRequest bulkIPRequest, Option<string> lang = default, Option<string> fields = default, Option<string> excludes = default, Option<string> include = default, Option<string> output = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// IP Geolocation API provides real-time and accurate geolocation, network, abuse, and security information for any IPv4 or IPv6 address and domain name along with the user-agent detail for the provided user-agent string. You can geolocate your online visitors and provide them the customized user-experience accordingly.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ip">In order to find geolocation information about an IP (ipv4 ipv6) address or a domain name, pass it as a query parameter ip. When this endpoint is queried without an IP address, it returns the geolocation information of the device/client which is calling it (optional)</param>
        /// <param name="lang">By default, the API responds in English. You can change the response language by passing the language code as a query parameter &#x60;lang&#x60;. Multi language feature is available only for &#x60;paid users&#x60;. (optional)</param>
        /// <param name="fields">you can filter the API response by specifying the fields that you need, instead of getting the full response. To do this, pass the desired field names using the &#x60;fields&#x60; query parameter with each field represented as a dot-separated path. (optional)</param>
        /// <param name="excludes">you can also filter the API response by excluding specific fields (except the IP address) that you don&#39;t need. To do this, pass the unwanted field names using the excludes query parameter, with each field represented as a dot-separated path (optional)</param>
        /// <param name="include">IP Geolocation API also provides IP-Security, abuse, timezone, user-agent and DMA (Designated Market Area) code, which is specifically used in the US for marketing and regional targeting information on Advanced API subscription, but doesn&#39;t respond it by default. To get these information along with the geolocation information, you must pass the &#x60;include&#x3D;security&#x60; or &#x60;include&#x3D;abuse&#x60; or &#x60;include&#x3D;dma&#x60; or &#x60;include&#x3D;time_zone&#x60; or &#x60;include&#x3D;user-agent&#x60; or you can fetch multiples by adding values in comma-separated way. In addition to that, IPGeolocation API also provide hostname lookup for an IP address on all the paid API subscriptions (STANDARD and ADVANCED), but doesn&#39;t respond it by default. To get the hostname for an IP address, you can pass one of the three values &#x60;hostname, liveHostname, hostnameFallbackLive&#x60; as a URL parameter &#x60;include&#x3D;&#x60;. (optional)</param>
        /// <param name="output">Desired output format (json or xml). (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IGetIpGeolocationApiResponse"/>&gt;</returns>
        Task<IGetIpGeolocationApiResponse> GetIpGeolocationAsync(Option<string> ip = default, Option<string> lang = default, Option<string> fields = default, Option<string> excludes = default, Option<string> include = default, Option<string> output = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// IP Geolocation API provides real-time and accurate geolocation, network, abuse, and security information for any IPv4 or IPv6 address and domain name along with the user-agent detail for the provided user-agent string. You can geolocate your online visitors and provide them the customized user-experience accordingly.
        /// </remarks>
        /// <param name="ip">In order to find geolocation information about an IP (ipv4 ipv6) address or a domain name, pass it as a query parameter ip. When this endpoint is queried without an IP address, it returns the geolocation information of the device/client which is calling it (optional)</param>
        /// <param name="lang">By default, the API responds in English. You can change the response language by passing the language code as a query parameter &#x60;lang&#x60;. Multi language feature is available only for &#x60;paid users&#x60;. (optional)</param>
        /// <param name="fields">you can filter the API response by specifying the fields that you need, instead of getting the full response. To do this, pass the desired field names using the &#x60;fields&#x60; query parameter with each field represented as a dot-separated path. (optional)</param>
        /// <param name="excludes">you can also filter the API response by excluding specific fields (except the IP address) that you don&#39;t need. To do this, pass the unwanted field names using the excludes query parameter, with each field represented as a dot-separated path (optional)</param>
        /// <param name="include">IP Geolocation API also provides IP-Security, abuse, timezone, user-agent and DMA (Designated Market Area) code, which is specifically used in the US for marketing and regional targeting information on Advanced API subscription, but doesn&#39;t respond it by default. To get these information along with the geolocation information, you must pass the &#x60;include&#x3D;security&#x60; or &#x60;include&#x3D;abuse&#x60; or &#x60;include&#x3D;dma&#x60; or &#x60;include&#x3D;time_zone&#x60; or &#x60;include&#x3D;user-agent&#x60; or you can fetch multiples by adding values in comma-separated way. In addition to that, IPGeolocation API also provide hostname lookup for an IP address on all the paid API subscriptions (STANDARD and ADVANCED), but doesn&#39;t respond it by default. To get the hostname for an IP address, you can pass one of the three values &#x60;hostname, liveHostname, hostnameFallbackLive&#x60; as a URL parameter &#x60;include&#x3D;&#x60;. (optional)</param>
        /// <param name="output">Desired output format (json or xml). (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IGetIpGeolocationApiResponse"/>?&gt;</returns>
        Task<IGetIpGeolocationApiResponse?> GetIpGeolocationOrDefaultAsync(Option<string> ip = default, Option<string> lang = default, Option<string> fields = default, Option<string> excludes = default, Option<string> include = default, Option<string> output = default, System.Threading.CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The <see cref="IBulkIPGeolocationApiResponse"/>
    /// </summary>
    public interface IBulkIPGeolocationApiResponse : IPGeolocation.Client.IApiResponse, IOk<List<BulkGeolocationResponse>?>, IBadRequest<IPGeolocation.Model.ErrorResponse?>, IUnauthorized<IPGeolocation.Model.ErrorResponse?>, IForbidden<IPGeolocation.Model.ErrorResponse?>, INotFound<IPGeolocation.Model.ErrorResponse?>, IMethodNotAllowed<IPGeolocation.Model.ErrorResponse?>, IContentTooLarge<IPGeolocation.Model.ErrorResponse?>, IUnsupportedMediaType<IPGeolocation.Model.ErrorResponse?>, ILocked<IPGeolocation.Model.ErrorResponse?>, ITooManyRequests<IPGeolocation.Model.ErrorResponse?>, ICustomHttpStatusCode499<IPGeolocation.Model.ErrorResponse?>, IInternalServerError<IPGeolocation.Model.ErrorResponse?>
    {
        /// <summary>
        /// Returns true if the response is 200 Ok
        /// </summary>
        /// <returns></returns>
        bool IsOk { get; }

        /// <summary>
        /// Returns true if the response is 400 BadRequest
        /// </summary>
        /// <returns></returns>
        bool IsBadRequest { get; }

        /// <summary>
        /// Returns true if the response is 401 Unauthorized
        /// </summary>
        /// <returns></returns>
        bool IsUnauthorized { get; }

        /// <summary>
        /// Returns true if the response is 403 Forbidden
        /// </summary>
        /// <returns></returns>
        bool IsForbidden { get; }

        /// <summary>
        /// Returns true if the response is 404 NotFound
        /// </summary>
        /// <returns></returns>
        bool IsNotFound { get; }

        /// <summary>
        /// Returns true if the response is 405 MethodNotAllowed
        /// </summary>
        /// <returns></returns>
        bool IsMethodNotAllowed { get; }

        /// <summary>
        /// Returns true if the response is 413 ContentTooLarge
        /// </summary>
        /// <returns></returns>
        bool IsContentTooLarge { get; }

        /// <summary>
        /// Returns true if the response is 415 UnsupportedMediaType
        /// </summary>
        /// <returns></returns>
        bool IsUnsupportedMediaType { get; }

        /// <summary>
        /// Returns true if the response is 423 Locked
        /// </summary>
        /// <returns></returns>
        bool IsLocked { get; }

        /// <summary>
        /// Returns true if the response is 429 TooManyRequests
        /// </summary>
        /// <returns></returns>
        bool IsTooManyRequests { get; }

        /// <summary>
        /// Returns true if the response is 499 CustomHttpStatusCode499
        /// </summary>
        /// <returns></returns>
        bool IsCustomHttpStatusCode499 { get; }

        /// <summary>
        /// Returns true if the response is 500 InternalServerError
        /// </summary>
        /// <returns></returns>
        bool IsInternalServerError { get; }
    }

    /// <summary>
    /// The <see cref="IGetIpGeolocationApiResponse"/>
    /// </summary>
    public interface IGetIpGeolocationApiResponse : IPGeolocation.Client.IApiResponse, IOk<IPGeolocation.Model.GeolocationResponse?>, IBadRequest<IPGeolocation.Model.ErrorResponse?>, IUnauthorized<IPGeolocation.Model.ErrorResponse?>, IForbidden<IPGeolocation.Model.ErrorResponse?>, INotFound<IPGeolocation.Model.ErrorResponse?>, IMethodNotAllowed<IPGeolocation.Model.ErrorResponse?>, ILocked<IPGeolocation.Model.ErrorResponse?>, ITooManyRequests<IPGeolocation.Model.ErrorResponse?>, ICustomHttpStatusCode499<IPGeolocation.Model.ErrorResponse?>, IInternalServerError<IPGeolocation.Model.ErrorResponse?>
    {
        /// <summary>
        /// Returns true if the response is 200 Ok
        /// </summary>
        /// <returns></returns>
        bool IsOk { get; }

        /// <summary>
        /// Returns true if the response is 400 BadRequest
        /// </summary>
        /// <returns></returns>
        bool IsBadRequest { get; }

        /// <summary>
        /// Returns true if the response is 401 Unauthorized
        /// </summary>
        /// <returns></returns>
        bool IsUnauthorized { get; }

        /// <summary>
        /// Returns true if the response is 403 Forbidden
        /// </summary>
        /// <returns></returns>
        bool IsForbidden { get; }

        /// <summary>
        /// Returns true if the response is 404 NotFound
        /// </summary>
        /// <returns></returns>
        bool IsNotFound { get; }

        /// <summary>
        /// Returns true if the response is 405 MethodNotAllowed
        /// </summary>
        /// <returns></returns>
        bool IsMethodNotAllowed { get; }

        /// <summary>
        /// Returns true if the response is 423 Locked
        /// </summary>
        /// <returns></returns>
        bool IsLocked { get; }

        /// <summary>
        /// Returns true if the response is 429 TooManyRequests
        /// </summary>
        /// <returns></returns>
        bool IsTooManyRequests { get; }

        /// <summary>
        /// Returns true if the response is 499 CustomHttpStatusCode499
        /// </summary>
        /// <returns></returns>
        bool IsCustomHttpStatusCode499 { get; }

        /// <summary>
        /// Returns true if the response is 500 InternalServerError
        /// </summary>
        /// <returns></returns>
        bool IsInternalServerError { get; }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class IPLocationApiEvents
    {
        /// <summary>
        /// The event raised after the server response
        /// </summary>
        public event EventHandler<ApiResponseEventArgs>? OnGetBulkIpGeolocation;

        /// <summary>
        /// The event raised after an error querying the server
        /// </summary>
        public event EventHandler<ExceptionEventArgs>? OnErrorGetBulkIpGeolocation;

        internal void ExecuteOnGetBulkIpGeolocation(IPGeolocationApi.BulkIPGeolocationApiResponse apiResponse)
        {
            OnGetBulkIpGeolocation?.Invoke(this, new ApiResponseEventArgs(apiResponse));
        }

        internal void ExecuteOnErrorGetBulkIpGeolocation(Exception exception)
        {
            OnErrorGetBulkIpGeolocation?.Invoke(this, new ExceptionEventArgs(exception));
        }

        /// <summary>
        /// The event raised after the server response
        /// </summary>
        public event EventHandler<ApiResponseEventArgs>? OnGetIpGeolocation;

        /// <summary>
        /// The event raised after an error querying the server
        /// </summary>
        public event EventHandler<ExceptionEventArgs>? OnErrorGetIpGeolocation;

        internal void ExecuteOnGetIpGeolocation(IPGeolocationApi.GetIpGeolocationApiResponse apiResponse)
        {
            OnGetIpGeolocation?.Invoke(this, new ApiResponseEventArgs(apiResponse));
        }

        internal void ExecuteOnErrorGetIpGeolocation(Exception exception)
        {
            OnErrorGetIpGeolocation?.Invoke(this, new ExceptionEventArgs(exception));
        }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public sealed partial class IPGeolocationApi : IIPGeolocationApi
    {
        private JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        /// The logger factory
        /// </summary>
        public ILoggerFactory LoggerFactory { get; }

        /// <summary>
        /// The logger
        /// </summary>
        public ILogger<IPGeolocationApi> Logger { get; }

        /// <summary>
        /// The HttpClient
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// The class containing the events
        /// </summary>
        public IPLocationApiEvents Events { get; }

        /// <summary>
        /// A token provider of type <see cref="ApiKeyProvider"/>
        /// </summary>
        public TokenProvider<ApiKeyToken> ApiKeyProvider { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="IPGeolocationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public IPGeolocationApi(ILogger<IPGeolocationApi> logger, ILoggerFactory loggerFactory, HttpClient httpClient, JsonSerializerOptionsProvider jsonSerializerOptionsProvider, IPLocationApiEvents iPLocationApiEvents,
            TokenProvider<ApiKeyToken> apiKeyProvider)
        {
            _jsonSerializerOptions = jsonSerializerOptionsProvider.Options;
            LoggerFactory = loggerFactory;
            Logger = LoggerFactory.CreateLogger<IPGeolocationApi>();
            HttpClient = httpClient;
            Events = iPLocationApiEvents;
            ApiKeyProvider = apiKeyProvider;
        }

        partial void FormatGetBulkIpGeolocation(BulkIPRequest bulkIPRequest, ref Option<string> lang, ref Option<string> fields, ref Option<string> excludes, ref Option<string> include, ref Option<string> output);

        /// <summary>
        /// Validates the request parameters
        /// </summary>
        /// <param name="bulkIPRequest"></param>
        /// <param name="lang"></param>
        /// <param name="fields"></param>
        /// <param name="excludes"></param>
        /// <param name="include"></param>
        /// <param name="output"></param>
        /// <returns></returns>
        private void ValidateGetBulkIpGeolocation(BulkIPRequest bulkIPRequest, Option<string> lang, Option<string> fields, Option<string> excludes, Option<string> include, Option<string> output)
        {
            if (bulkIPRequest == null)
                throw new ArgumentNullException(nameof(bulkIPRequest));

            if (lang.IsSet && lang.Value == null)
                throw new ArgumentNullException(nameof(lang));

            if (fields.IsSet && fields.Value == null)
                throw new ArgumentNullException(nameof(fields));

            if (excludes.IsSet && excludes.Value == null)
                throw new ArgumentNullException(nameof(excludes));

            if (include.IsSet && include.Value == null)
                throw new ArgumentNullException(nameof(include));

            if (output.IsSet && output.Value == null)
                throw new ArgumentNullException(nameof(output));
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="bulkIPRequest"></param>
        /// <param name="lang"></param>
        /// <param name="fields"></param>
        /// <param name="excludes"></param>
        /// <param name="include"></param>
        /// <param name="output"></param>
        private void AfterGetBulkIpGeolocationDefaultImplementation(IBulkIPGeolocationApiResponse apiResponseLocalVar, BulkIPRequest bulkIPRequest, Option<string> lang, Option<string> fields, Option<string> excludes, Option<string> include, Option<string> output)
        {
            bool suppressDefaultLog = false;
            AfterGetBulkIpGeolocation(ref suppressDefaultLog, apiResponseLocalVar, bulkIPRequest, lang, fields, excludes, include, output);
            if (!suppressDefaultLog)
                Logger.LogInformation("{0,-9} | {1} | {3}", (apiResponseLocalVar.DownloadedAt - apiResponseLocalVar.RequestedAt).TotalSeconds, apiResponseLocalVar.StatusCode, apiResponseLocalVar.Path);
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="bulkIPRequest"></param>
        /// <param name="lang"></param>
        /// <param name="fields"></param>
        /// <param name="excludes"></param>
        /// <param name="include"></param>
        /// <param name="output"></param>
        partial void AfterGetBulkIpGeolocation(ref bool suppressDefaultLog, IBulkIPGeolocationApiResponse apiResponseLocalVar, BulkIPRequest bulkIPRequest, Option<string> lang, Option<string> fields, Option<string> excludes, Option<string> include, Option<string> output);

        /// <summary>
        /// Logs exceptions that occur while retrieving the server response
        /// </summary>
        /// <param name="exceptionLocalVar"></param>
        /// <param name="pathFormatLocalVar"></param>
        /// <param name="pathLocalVar"></param>
        /// <param name="bulkIPRequest"></param>
        /// <param name="lang"></param>
        /// <param name="fields"></param>
        /// <param name="excludes"></param>
        /// <param name="include"></param>
        /// <param name="output"></param>
        private void OnErrorGetBulkIpGeolocationDefaultImplementation(Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, BulkIPRequest bulkIPRequest, Option<string> lang, Option<string> fields, Option<string> excludes, Option<string> include, Option<string> output)
        {
            bool suppressDefaultLogLocalVar = false;
            OnErrorGetBulkIpGeolocation(ref suppressDefaultLogLocalVar, exceptionLocalVar, pathFormatLocalVar, pathLocalVar, bulkIPRequest, lang, fields, excludes, include, output);
            if (!suppressDefaultLogLocalVar)
                Logger.LogError(exceptionLocalVar, "An error occurred while sending the request to the server.");
        }

        /// <summary>
        /// A partial method that gives developers a way to provide customized exception handling
        /// </summary>
        /// <param name="suppressDefaultLogLocalVar"></param>
        /// <param name="exceptionLocalVar"></param>
        /// <param name="pathFormatLocalVar"></param>
        /// <param name="pathLocalVar"></param>
        /// <param name="bulkIPRequest"></param>
        /// <param name="lang"></param>
        /// <param name="fields"></param>
        /// <param name="excludes"></param>
        /// <param name="include"></param>
        /// <param name="output"></param>
        partial void OnErrorGetBulkIpGeolocation(ref bool suppressDefaultLogLocalVar, Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, BulkIPRequest bulkIPRequest, Option<string> lang, Option<string> fields, Option<string> excludes, Option<string> include, Option<string> output);

        /// <summary>
        ///  This feature is available only on our paid API subscriptions (STANDARD or ADVANCED). This endpoint allows you to perform the geolocation lookup for multiple IPv4, IPv6 addresses or domain names (maximum 50,000) at the same time. The requests count per lookup is equal to total IP addresses or domain names passed. To perform bulk IP Geolocation Lookup, send a POST request and pass the \&quot;ips\&quot; array as JSON data along with it.  
        /// </summary>
        /// <param name="bulkIPRequest"></param>
        /// <param name="lang">By default, the API responds in English. You can change the response language by passing the language code as a query parameter &#x60;lang&#x60;. Multi language feature is available only for &#x60;paid users&#x60;. (optional)</param>
        /// <param name="fields">you can filter the API response by specifying the fields that you need, instead of getting the full response. To do this, pass the desired field names using the &#x60;fields&#x60; query parameter with each field represented as a dot-separated path. (optional)</param>
        /// <param name="excludes">you can also filter the API response by excluding specific fields (except the IP address) that you don&#39;t need. To do this, pass the unwanted field names using the excludes query parameter, with each field represented as a dot-separated path (optional)</param>
        /// <param name="include">IP Geolocation API also provides IP-Security, abuse, timezone, user-agent and DMA (Designated Market Area) code, which is specifically used in the US for marketing and regional targeting information on Advanced API subscription, but doesn&#39;t respond it by default. To get these information along with the geolocation information, you must pass the &#x60;include&#x3D;security&#x60; or &#x60;include&#x3D;abuse&#x60; or &#x60;include&#x3D;dma&#x60; or &#x60;include&#x3D;time_zone&#x60; or &#x60;include&#x3D;user-agent&#x60; or you can fetch multiples by adding values in comma-separated way. In addition to that, IPGeolocation API also provide hostname lookup for an IP address on all the paid API subscriptions (STANDARD and ADVANCED), but doesn&#39;t respond it by default. To get the hostname for an IP address, you can pass one of the three values &#x60;hostname, liveHostname, hostnameFallbackLive&#x60; as a URL parameter &#x60;include&#x3D;&#x60;. (optional)</param>
        /// <param name="output">Desired output format(json or xml). (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IBulkIPGeolocationApiResponse"/>&gt;</returns>
        public async Task<IBulkIPGeolocationApiResponse?> GetBulkIpGeolocationOrDefaultAsync(BulkIPRequest bulkIPRequest, Option<string> lang = default, Option<string> fields = default, Option<string> excludes = default, Option<string> include = default, Option<string> output = default, System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await GetBulkIpGeolocationAsync(bulkIPRequest, lang, fields, excludes, include, output, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        ///  This feature is available only on our paid API subscriptions (STANDARD or ADVANCED). This endpoint allows you to perform the geolocation lookup for multiple IPv4, IPv6 addresses or domain names (maximum 50,000) at the same time. The requests count per lookup is equal to total IP addresses or domain names passed. To perform bulk IP Geolocation Lookup, send a POST request and pass the \&quot;ips\&quot; array as JSON data along with it.  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="bulkIPRequest"></param>
        /// <param name="lang">By default, the API responds in English. You can change the response language by passing the language code as a query parameter &#x60;lang&#x60;. Multi language feature is available only for &#x60;paid users&#x60;. (optional)</param>
        /// <param name="fields">you can filter the API response by specifying the fields that you need, instead of getting the full response. To do this, pass the desired field names using the &#x60;fields&#x60; query parameter with each field represented as a dot-separated path. (optional)</param>
        /// <param name="excludes">you can also filter the API response by excluding specific fields (except the IP address) that you don&#39;t need. To do this, pass the unwanted field names using the excludes query parameter, with each field represented as a dot-separated path (optional)</param>
        /// <param name="include">IP Geolocation API also provides IP-Security, abuse, timezone, user-agent and DMA (Designated Market Area) code, which is specifically used in the US for marketing and regional targeting information on Advanced API subscription, but doesn&#39;t respond it by default. To get these information along with the geolocation information, you must pass the &#x60;include&#x3D;security&#x60; or &#x60;include&#x3D;abuse&#x60; or &#x60;include&#x3D;dma&#x60; or &#x60;include&#x3D;time_zone&#x60; or &#x60;include&#x3D;user-agent&#x60; or you can fetch multiples by adding values in comma-separated way. In addition to that, IPGeolocation API also provide hostname lookup for an IP address on all the paid API subscriptions (STANDARD and ADVANCED), but doesn&#39;t respond it by default. To get the hostname for an IP address, you can pass one of the three values &#x60;hostname, liveHostname, hostnameFallbackLive&#x60; as a URL parameter &#x60;include&#x3D;&#x60;. (optional)</param>
        /// <param name="output">Desired output format(json or xml). (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IBulkIPGeolocationApiResponse"/>&gt;</returns>
        public async Task<IBulkIPGeolocationApiResponse> GetBulkIpGeolocationAsync(BulkIPRequest bulkIPRequest, Option<string> lang = default, Option<string> fields = default, Option<string> excludes = default, Option<string> include = default, Option<string> output = default, System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                ValidateGetBulkIpGeolocation(bulkIPRequest, lang, fields, excludes, include, output);

                FormatGetBulkIpGeolocation(bulkIPRequest, ref lang, ref fields, ref excludes, ref include, ref output);

                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress!.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = HttpClient.BaseAddress.AbsolutePath == "/"
                        ? "/ipgeo-bulk"
                        : string.Concat(HttpClient.BaseAddress.AbsolutePath, "/ipgeo-bulk");

                    System.Collections.Specialized.NameValueCollection parseQueryStringLocalVar = System.Web.HttpUtility.ParseQueryString(string.Empty);

                    if (lang.IsSet)
                        parseQueryStringLocalVar["lang"] = ClientUtils.ParameterToString(lang.Value);

                    if (fields.IsSet)
                        parseQueryStringLocalVar["fields"] = ClientUtils.ParameterToString(fields.Value);

                    if (excludes.IsSet)
                        parseQueryStringLocalVar["excludes"] = ClientUtils.ParameterToString(excludes.Value);

                    if (include.IsSet)
                        parseQueryStringLocalVar["include"] = ClientUtils.ParameterToString(include.Value);

                    if (output.IsSet)
                        parseQueryStringLocalVar["output"] = ClientUtils.ParameterToString(output.Value);

                    uriBuilderLocalVar.Query = parseQueryStringLocalVar.ToString();

                    httpRequestMessageLocalVar.Content = (bulkIPRequest as object) is System.IO.Stream stream
                        ? httpRequestMessageLocalVar.Content = new StreamContent(stream)
                        : httpRequestMessageLocalVar.Content = new StringContent(JsonSerializer.Serialize(bulkIPRequest, _jsonSerializerOptions));

                    List<TokenBase> tokenBaseLocalVars = new List<TokenBase>();
                    ApiKeyToken apiKeyTokenLocalVar1 = (ApiKeyToken)await ApiKeyProvider.GetAsync("apiKey", cancellationToken).ConfigureAwait(false);
                    tokenBaseLocalVars.Add(apiKeyTokenLocalVar1);

                    apiKeyTokenLocalVar1.UseInQuery(httpRequestMessageLocalVar, uriBuilderLocalVar, parseQueryStringLocalVar);

                    uriBuilderLocalVar.Query = parseQueryStringLocalVar.ToString();
                    httpRequestMessageLocalVar.RequestUri = uriBuilderLocalVar.Uri;

                    string[] contentTypes = new string[] {
                        "application/json"
                    };

                    string? contentTypeLocalVar = ClientUtils.SelectHeaderContentType(contentTypes);

                    if (contentTypeLocalVar != null && httpRequestMessageLocalVar.Content != null)
                        httpRequestMessageLocalVar.Content.Headers.ContentType = new MediaTypeHeaderValue(contentTypeLocalVar);

                    string[] acceptLocalVars = new string[] {
                        "application/json",
                        "application/xml"
                    };

                    string? acceptLocalVar = ClientUtils.SelectHeaderAccept(acceptLocalVars);

                    if (acceptLocalVar != null)
                        httpRequestMessageLocalVar.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(acceptLocalVar));
                    httpRequestMessageLocalVar.Method = new HttpMethod("POST");

                    DateTime requestedAtLocalVar = DateTime.UtcNow;

                    using (HttpResponseMessage httpResponseMessageLocalVar = await HttpClient.SendAsync(httpRequestMessageLocalVar, cancellationToken).ConfigureAwait(false))
                    {
                        string responseContentLocalVar = await httpResponseMessageLocalVar.Content.ReadAsStringAsync().ConfigureAwait(false);

                        ILogger<BulkIPGeolocationApiResponse> apiResponseLoggerLocalVar = LoggerFactory.CreateLogger<BulkIPGeolocationApiResponse>();

                        BulkIPGeolocationApiResponse apiResponseLocalVar = new BulkIPGeolocationApiResponse(apiResponseLoggerLocalVar, httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, "/ipgeo-bulk", requestedAtLocalVar, _jsonSerializerOptions);
                        AfterGetBulkIpGeolocationDefaultImplementation(apiResponseLocalVar, bulkIPRequest, lang, fields, excludes, include, output);

                        Events.ExecuteOnGetBulkIpGeolocation(apiResponseLocalVar);

                        if (apiResponseLocalVar.StatusCode == (HttpStatusCode)429)
                            foreach (TokenBase tokenBaseLocalVar in tokenBaseLocalVars)
                                tokenBaseLocalVar.BeginRateLimit();

                        return apiResponseLocalVar;
                    }
                }
            }
            catch (Exception e)
            {
                OnErrorGetBulkIpGeolocationDefaultImplementation(e, "/ipgeo-bulk", uriBuilderLocalVar.Path, bulkIPRequest, lang, fields, excludes, include, output);
                Events.ExecuteOnErrorGetBulkIpGeolocation(e);
                throw;
            }
        }

        /// <summary>
        /// The <see cref="BulkIPGeolocationApiResponse"/>
        /// </summary>
        public partial class BulkIPGeolocationApiResponse : IPGeolocation.Client.ApiResponse, IBulkIPGeolocationApiResponse
        {
            /// <summary>
            /// The logger
            /// </summary>
            public ILogger<BulkIPGeolocationApiResponse> Logger { get; }

            /// <summary>
            /// The <see cref="BulkIPGeolocationApiResponse"/>
            /// </summary>
            /// <param name="logger"></param>
            /// <param name="httpRequestMessage"></param>
            /// <param name="httpResponseMessage"></param>
            /// <param name="rawContent"></param>
            /// <param name="path"></param>
            /// <param name="requestedAt"></param>
            /// <param name="jsonSerializerOptions"></param>
            public BulkIPGeolocationApiResponse(ILogger<BulkIPGeolocationApiResponse> logger, System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage, string rawContent, string path, DateTime requestedAt, System.Text.Json.JsonSerializerOptions jsonSerializerOptions) : base(httpRequestMessage, httpResponseMessage, rawContent, path, requestedAt, jsonSerializerOptions)
            {
                Logger = logger;
                OnCreated(httpRequestMessage, httpResponseMessage);
            }

            partial void OnCreated(global::System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage);

            /// <summary>
            /// Returns true if the response is 200 Ok
            /// </summary>
            /// <returns></returns>
            public bool IsOk => 200 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 200 Ok
            /// </summary>
            /// <returns></returns>
            public List<BulkGeolocationResponse>? Ok()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsOk
                    ? System.Text.Json.JsonSerializer.Deserialize<List<BulkGeolocationResponse>>(RawContent, _jsonSerializerOptions)
                    : default;
            }

            /// <summary>
            /// Returns true if the response is 200 Ok and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryOk(out List<BulkGeolocationResponse>? result)
            {
                result = null;

                try
                {
                    result = Ok();
                }
                catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)200);
                }

                return result != null;
            }

            /// <summary>
            /// Returns true if the response is 400 BadRequest
            /// </summary>
            /// <returns></returns>
            public bool IsBadRequest => 400 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 400 BadRequest
            /// </summary>
            /// <returns></returns>
            public IPGeolocation.Model.ErrorResponse? BadRequest()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsBadRequest
                    ? System.Text.Json.JsonSerializer.Deserialize<IPGeolocation.Model.ErrorResponse>(RawContent, _jsonSerializerOptions)
                    : default;
            }

            /// <summary>
            /// Returns true if the response is 400 BadRequest and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryBadRequest(out IPGeolocation.Model.ErrorResponse? result)
            {
                result = null;

                try
                {
                    result = BadRequest();
                }
                catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)400);
                }

                return result != null;
            }

            /// <summary>
            /// Returns true if the response is 401 Unauthorized
            /// </summary>
            /// <returns></returns>
            public bool IsUnauthorized => 401 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 401 Unauthorized
            /// </summary>
            /// <returns></returns>
            public IPGeolocation.Model.ErrorResponse? Unauthorized()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsUnauthorized
                    ? System.Text.Json.JsonSerializer.Deserialize<IPGeolocation.Model.ErrorResponse>(RawContent, _jsonSerializerOptions)
                    : default;
            }

            /// <summary>
            /// Returns true if the response is 401 Unauthorized and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryUnauthorized(out IPGeolocation.Model.ErrorResponse? result)
            {
                result = null;

                try
                {
                    result = Unauthorized();
                }
                catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)401);
                }

                return result != null;
            }

            /// <summary>
            /// Returns true if the response is 403 Forbidden
            /// </summary>
            /// <returns></returns>
            public bool IsForbidden => 403 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 403 Forbidden
            /// </summary>
            /// <returns></returns>
            public IPGeolocation.Model.ErrorResponse? Forbidden()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsForbidden
                    ? System.Text.Json.JsonSerializer.Deserialize<IPGeolocation.Model.ErrorResponse>(RawContent, _jsonSerializerOptions)
                    : default;
            }

            /// <summary>
            /// Returns true if the response is 403 Forbidden and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryForbidden(out IPGeolocation.Model.ErrorResponse? result)
            {
                result = null;

                try
                {
                    result = Forbidden();
                }
                catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)403);
                }

                return result != null;
            }

            /// <summary>
            /// Returns true if the response is 404 NotFound
            /// </summary>
            /// <returns></returns>
            public bool IsNotFound => 404 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 404 NotFound
            /// </summary>
            /// <returns></returns>
            public IPGeolocation.Model.ErrorResponse? NotFound()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsNotFound
                    ? System.Text.Json.JsonSerializer.Deserialize<IPGeolocation.Model.ErrorResponse>(RawContent, _jsonSerializerOptions)
                    : default;
            }

            /// <summary>
            /// Returns true if the response is 404 NotFound and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryNotFound(out IPGeolocation.Model.ErrorResponse? result)
            {
                result = null;

                try
                {
                    result = NotFound();
                }
                catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)404);
                }

                return result != null;
            }

            /// <summary>
            /// Returns true if the response is 405 MethodNotAllowed
            /// </summary>
            /// <returns></returns>
            public bool IsMethodNotAllowed => 405 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 405 MethodNotAllowed
            /// </summary>
            /// <returns></returns>
            public IPGeolocation.Model.ErrorResponse? MethodNotAllowed()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsMethodNotAllowed
                    ? System.Text.Json.JsonSerializer.Deserialize<IPGeolocation.Model.ErrorResponse>(RawContent, _jsonSerializerOptions)
                    : default;
            }

            /// <summary>
            /// Returns true if the response is 405 MethodNotAllowed and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryMethodNotAllowed(out IPGeolocation.Model.ErrorResponse? result)
            {
                result = null;

                try
                {
                    result = MethodNotAllowed();
                }
                catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)405);
                }

                return result != null;
            }

            /// <summary>
            /// Returns true if the response is 413 ContentTooLarge
            /// </summary>
            /// <returns></returns>
            public bool IsContentTooLarge => 413 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 413 ContentTooLarge
            /// </summary>
            /// <returns></returns>
            public IPGeolocation.Model.ErrorResponse? ContentTooLarge()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsContentTooLarge
                    ? System.Text.Json.JsonSerializer.Deserialize<IPGeolocation.Model.ErrorResponse>(RawContent, _jsonSerializerOptions)
                    : default;
            }

            /// <summary>
            /// Returns true if the response is 413 ContentTooLarge and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryContentTooLarge(out IPGeolocation.Model.ErrorResponse? result)
            {
                result = null;

                try
                {
                    result = ContentTooLarge();
                }
                catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)413);
                }

                return result != null;
            }

            /// <summary>
            /// Returns true if the response is 415 UnsupportedMediaType
            /// </summary>
            /// <returns></returns>
            public bool IsUnsupportedMediaType => 415 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 415 UnsupportedMediaType
            /// </summary>
            /// <returns></returns>
            public IPGeolocation.Model.ErrorResponse? UnsupportedMediaType()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsUnsupportedMediaType
                    ? System.Text.Json.JsonSerializer.Deserialize<IPGeolocation.Model.ErrorResponse>(RawContent, _jsonSerializerOptions)
                    : default;
            }

            /// <summary>
            /// Returns true if the response is 415 UnsupportedMediaType and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryUnsupportedMediaType(out IPGeolocation.Model.ErrorResponse? result)
            {
                result = null;

                try
                {
                    result = UnsupportedMediaType();
                }
                catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)415);
                }

                return result != null;
            }

            /// <summary>
            /// Returns true if the response is 423 Locked
            /// </summary>
            /// <returns></returns>
            public bool IsLocked => 423 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 423 Locked
            /// </summary>
            /// <returns></returns>
            public IPGeolocation.Model.ErrorResponse? Locked()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsLocked
                    ? System.Text.Json.JsonSerializer.Deserialize<IPGeolocation.Model.ErrorResponse>(RawContent, _jsonSerializerOptions)
                    : default;
            }

            /// <summary>
            /// Returns true if the response is 423 Locked and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryLocked(out IPGeolocation.Model.ErrorResponse? result)
            {
                result = null;

                try
                {
                    result = Locked();
                }
                catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)423);
                }

                return result != null;
            }

            /// <summary>
            /// Returns true if the response is 429 TooManyRequests
            /// </summary>
            /// <returns></returns>
            public bool IsTooManyRequests => 429 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 429 TooManyRequests
            /// </summary>
            /// <returns></returns>
            public IPGeolocation.Model.ErrorResponse? TooManyRequests()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsTooManyRequests
                    ? System.Text.Json.JsonSerializer.Deserialize<IPGeolocation.Model.ErrorResponse>(RawContent, _jsonSerializerOptions)
                    : default;
            }

            /// <summary>
            /// Returns true if the response is 429 TooManyRequests and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryTooManyRequests(out IPGeolocation.Model.ErrorResponse? result)
            {
                result = null;

                try
                {
                    result = TooManyRequests();
                }
                catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)429);
                }

                return result != null;
            }

            /// <summary>
            /// Returns true if the response is 499 CustomHttpStatusCode499
            /// </summary>
            /// <returns></returns>
            public bool IsCustomHttpStatusCode499 => 499 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 499 CustomHttpStatusCode499
            /// </summary>
            /// <returns></returns>
            public IPGeolocation.Model.ErrorResponse? CustomHttpStatusCode499()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsCustomHttpStatusCode499
                    ? System.Text.Json.JsonSerializer.Deserialize<IPGeolocation.Model.ErrorResponse>(RawContent, _jsonSerializerOptions)
                    : default;
            }

            /// <summary>
            /// Returns true if the response is 499 CustomHttpStatusCode499 and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryCustomHttpStatusCode499(out IPGeolocation.Model.ErrorResponse? result)
            {
                result = null;

                try
                {
                    result = CustomHttpStatusCode499();
                }
                catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)499);
                }

                return result != null;
            }

            /// <summary>
            /// Returns true if the response is 500 InternalServerError
            /// </summary>
            /// <returns></returns>
            public bool IsInternalServerError => 500 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 500 InternalServerError
            /// </summary>
            /// <returns></returns>
            public IPGeolocation.Model.ErrorResponse? InternalServerError()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsInternalServerError
                    ? System.Text.Json.JsonSerializer.Deserialize<IPGeolocation.Model.ErrorResponse>(RawContent, _jsonSerializerOptions)
                    : default;
            }

            /// <summary>
            /// Returns true if the response is 500 InternalServerError and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryInternalServerError(out IPGeolocation.Model.ErrorResponse? result)
            {
                result = null;

                try
                {
                    result = InternalServerError();
                }
                catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)500);
                }

                return result != null;
            }

            private void OnDeserializationErrorDefaultImplementation(Exception exception, HttpStatusCode httpStatusCode)
            {
                bool suppressDefaultLog = false;
                OnDeserializationError(ref suppressDefaultLog, exception, httpStatusCode);
                if (!suppressDefaultLog)
                    Logger.LogError(exception, "An error occurred while deserializing the {code} response.", httpStatusCode);
            }

            partial void OnDeserializationError(ref bool suppressDefaultLog, Exception exception, HttpStatusCode httpStatusCode);
        }

        partial void FormatGetIpGeolocation(ref Option<string> ip, ref Option<string> lang, ref Option<string> fields, ref Option<string> excludes, ref Option<string> include, ref Option<string> output);

        /// <summary>
        /// Validates the request parameters
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="lang"></param>
        /// <param name="fields"></param>
        /// <param name="excludes"></param>
        /// <param name="include"></param>
        /// <param name="output"></param>
        /// <returns></returns>
        private void ValidateGetIpGeolocation(Option<string> ip, Option<string> lang, Option<string> fields, Option<string> excludes, Option<string> include, Option<string> output)
        {
            if (ip.IsSet && ip.Value == null)
                throw new ArgumentNullException(nameof(ip));

            if (lang.IsSet && lang.Value == null)
                throw new ArgumentNullException(nameof(lang));

            if (fields.IsSet && fields.Value == null)
                throw new ArgumentNullException(nameof(fields));

            if (excludes.IsSet && excludes.Value == null)
                throw new ArgumentNullException(nameof(excludes));

            if (include.IsSet && include.Value == null)
                throw new ArgumentNullException(nameof(include));

            if (output.IsSet && output.Value == null)
                throw new ArgumentNullException(nameof(output));
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="ip"></param>
        /// <param name="lang"></param>
        /// <param name="fields"></param>
        /// <param name="excludes"></param>
        /// <param name="include"></param>
        /// <param name="output"></param>
        private void AfterGetIpGeolocationDefaultImplementation(IGetIpGeolocationApiResponse apiResponseLocalVar, Option<string> ip, Option<string> lang, Option<string> fields, Option<string> excludes, Option<string> include, Option<string> output)
        {
            bool suppressDefaultLog = false;
            AfterGetIpGeolocation(ref suppressDefaultLog, apiResponseLocalVar, ip, lang, fields, excludes, include, output);
            if (!suppressDefaultLog)
                Logger.LogInformation("{0,-9} | {1} | {3}", (apiResponseLocalVar.DownloadedAt - apiResponseLocalVar.RequestedAt).TotalSeconds, apiResponseLocalVar.StatusCode, apiResponseLocalVar.Path);
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="ip"></param>
        /// <param name="lang"></param>
        /// <param name="fields"></param>
        /// <param name="excludes"></param>
        /// <param name="include"></param>
        /// <param name="output"></param>
        partial void AfterGetIpGeolocation(ref bool suppressDefaultLog, IGetIpGeolocationApiResponse apiResponseLocalVar, Option<string> ip, Option<string> lang, Option<string> fields, Option<string> excludes, Option<string> include, Option<string> output);

        /// <summary>
        /// Logs exceptions that occur while retrieving the server response
        /// </summary>
        /// <param name="exceptionLocalVar"></param>
        /// <param name="pathFormatLocalVar"></param>
        /// <param name="pathLocalVar"></param>
        /// <param name="ip"></param>
        /// <param name="lang"></param>
        /// <param name="fields"></param>
        /// <param name="excludes"></param>
        /// <param name="include"></param>
        /// <param name="output"></param>
        private void OnErrorGetIpGeolocationDefaultImplementation(Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, Option<string> ip, Option<string> lang, Option<string> fields, Option<string> excludes, Option<string> include, Option<string> output)
        {
            bool suppressDefaultLogLocalVar = false;
            OnErrorGetIpGeolocation(ref suppressDefaultLogLocalVar, exceptionLocalVar, pathFormatLocalVar, pathLocalVar, ip, lang, fields, excludes, include, output);
            if (!suppressDefaultLogLocalVar)
                Logger.LogError(exceptionLocalVar, "An error occurred while sending the request to the server.");
        }

        /// <summary>
        /// A partial method that gives developers a way to provide customized exception handling
        /// </summary>
        /// <param name="suppressDefaultLogLocalVar"></param>
        /// <param name="exceptionLocalVar"></param>
        /// <param name="pathFormatLocalVar"></param>
        /// <param name="pathLocalVar"></param>
        /// <param name="ip"></param>
        /// <param name="lang"></param>
        /// <param name="fields"></param>
        /// <param name="excludes"></param>
        /// <param name="include"></param>
        /// <param name="output"></param>
        partial void OnErrorGetIpGeolocation(ref bool suppressDefaultLogLocalVar, Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, Option<string> ip, Option<string> lang, Option<string> fields, Option<string> excludes, Option<string> include, Option<string> output);

        /// <summary>
        ///  IP Geolocation API provides real-time and accurate geolocation, network, abuse, and security information for any IPv4 or IPv6 address and domain name along with the user-agent detail for the provided user-agent string. You can geolocate your online visitors and provide them the customized user-experience accordingly.
        /// </summary>
        /// <param name="ip">In order to find geolocation information about an IP (ipv4 ipv6) address or a domain name, pass it as a query parameter ip. When this endpoint is queried without an IP address, it returns the geolocation information of the device/client which is calling it (optional)</param>
        /// <param name="lang">By default, the API responds in English. You can change the response language by passing the language code as a query parameter &#x60;lang&#x60;. Multi language feature is available only for &#x60;paid users&#x60;. (optional)</param>
        /// <param name="fields">you can filter the API response by specifying the fields that you need, instead of getting the full response. To do this, pass the desired field names using the &#x60;fields&#x60; query parameter with each field represented as a dot-separated path. (optional)</param>
        /// <param name="excludes">you can also filter the API response by excluding specific fields (except the IP address) that you don&#39;t need. To do this, pass the unwanted field names using the excludes query parameter, with each field represented as a dot-separated path (optional)</param>
        /// <param name="include">IP Geolocation API also provides IP-Security, abuse, timezone, user-agent and DMA (Designated Market Area) code, which is specifically used in the US for marketing and regional targeting information on Advanced API subscription, but doesn&#39;t respond it by default. To get these information along with the geolocation information, you must pass the &#x60;include&#x3D;security&#x60; or &#x60;include&#x3D;abuse&#x60; or &#x60;include&#x3D;dma&#x60; or &#x60;include&#x3D;time_zone&#x60; or &#x60;include&#x3D;user-agent&#x60; or you can fetch multiples by adding values in comma-separated way. In addition to that, IPGeolocation API also provide hostname lookup for an IP address on all the paid API subscriptions (STANDARD and ADVANCED), but doesn&#39;t respond it by default. To get the hostname for an IP address, you can pass one of the three values &#x60;hostname, liveHostname, hostnameFallbackLive&#x60; as a URL parameter &#x60;include&#x3D;&#x60;. (optional)</param>
        /// <param name="output">Desired output format (json or xml). (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IGetIpGeolocationApiResponse"/>&gt;</returns>
        public async Task<IGetIpGeolocationApiResponse?> GetIpGeolocationOrDefaultAsync(Option<string> ip = default, Option<string> lang = default, Option<string> fields = default, Option<string> excludes = default, Option<string> include = default, Option<string> output = default, System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await GetIpGeolocationAsync(ip, lang, fields, excludes, include, output, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        ///  IP Geolocation API provides real-time and accurate geolocation, network, abuse, and security information for any IPv4 or IPv6 address and domain name along with the user-agent detail for the provided user-agent string. You can geolocate your online visitors and provide them the customized user-experience accordingly.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ip">In order to find geolocation information about an IP (ipv4 ipv6) address or a domain name, pass it as a query parameter ip. When this endpoint is queried without an IP address, it returns the geolocation information of the device/client which is calling it (optional)</param>
        /// <param name="lang">By default, the API responds in English. You can change the response language by passing the language code as a query parameter &#x60;lang&#x60;. Multi language feature is available only for &#x60;paid users&#x60;. (optional)</param>
        /// <param name="fields">you can filter the API response by specifying the fields that you need, instead of getting the full response. To do this, pass the desired field names using the &#x60;fields&#x60; query parameter with each field represented as a dot-separated path. (optional)</param>
        /// <param name="excludes">you can also filter the API response by excluding specific fields (except the IP address) that you don&#39;t need. To do this, pass the unwanted field names using the excludes query parameter, with each field represented as a dot-separated path (optional)</param>
        /// <param name="include">IP Geolocation API also provides IP-Security, abuse, timezone, user-agent and DMA (Designated Market Area) code, which is specifically used in the US for marketing and regional targeting information on Advanced API subscription, but doesn&#39;t respond it by default. To get these information along with the geolocation information, you must pass the &#x60;include&#x3D;security&#x60; or &#x60;include&#x3D;abuse&#x60; or &#x60;include&#x3D;dma&#x60; or &#x60;include&#x3D;time_zone&#x60; or &#x60;include&#x3D;user-agent&#x60; or you can fetch multiples by adding values in comma-separated way. In addition to that, IPGeolocation API also provide hostname lookup for an IP address on all the paid API subscriptions (STANDARD and ADVANCED), but doesn&#39;t respond it by default. To get the hostname for an IP address, you can pass one of the three values &#x60;hostname, liveHostname, hostnameFallbackLive&#x60; as a URL parameter &#x60;include&#x3D;&#x60;. (optional)</param>
        /// <param name="output">Desired output format (json or xml). (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IGetIpGeolocationApiResponse"/>&gt;</returns>
        public async Task<IGetIpGeolocationApiResponse> GetIpGeolocationAsync(Option<string> ip = default, Option<string> lang = default, Option<string> fields = default, Option<string> excludes = default, Option<string> include = default, Option<string> output = default, System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                ValidateGetIpGeolocation(ip, lang, fields, excludes, include, output);

                FormatGetIpGeolocation(ref ip, ref lang, ref fields, ref excludes, ref include, ref output);

                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress!.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = HttpClient.BaseAddress.AbsolutePath == "/"
                        ? "/ipgeo"
                        : string.Concat(HttpClient.BaseAddress.AbsolutePath, "/ipgeo");

                    System.Collections.Specialized.NameValueCollection parseQueryStringLocalVar = System.Web.HttpUtility.ParseQueryString(string.Empty);

                    if (ip.IsSet)
                        parseQueryStringLocalVar["ip"] = ClientUtils.ParameterToString(ip.Value);

                    if (lang.IsSet)
                        parseQueryStringLocalVar["lang"] = ClientUtils.ParameterToString(lang.Value);

                    if (fields.IsSet)
                        parseQueryStringLocalVar["fields"] = ClientUtils.ParameterToString(fields.Value);

                    if (excludes.IsSet)
                        parseQueryStringLocalVar["excludes"] = ClientUtils.ParameterToString(excludes.Value);

                    if (include.IsSet)
                        parseQueryStringLocalVar["include"] = ClientUtils.ParameterToString(include.Value);

                    if (output.IsSet)
                        parseQueryStringLocalVar["output"] = ClientUtils.ParameterToString(output.Value);

                    uriBuilderLocalVar.Query = parseQueryStringLocalVar.ToString();

                    List<TokenBase> tokenBaseLocalVars = new List<TokenBase>();
                    ApiKeyToken apiKeyTokenLocalVar1 = (ApiKeyToken)await ApiKeyProvider.GetAsync("apiKey", cancellationToken).ConfigureAwait(false);
                    tokenBaseLocalVars.Add(apiKeyTokenLocalVar1);

                    apiKeyTokenLocalVar1.UseInQuery(httpRequestMessageLocalVar, uriBuilderLocalVar, parseQueryStringLocalVar);

                    uriBuilderLocalVar.Query = parseQueryStringLocalVar.ToString();
                    httpRequestMessageLocalVar.RequestUri = uriBuilderLocalVar.Uri;

                    string[] acceptLocalVars = new string[] {
                        "application/json",
                        "application/xml"
                    };

                    string? acceptLocalVar = ClientUtils.SelectHeaderAccept(acceptLocalVars);

                    if (acceptLocalVar != null)
                        httpRequestMessageLocalVar.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(acceptLocalVar));
                    httpRequestMessageLocalVar.Method = new HttpMethod("GET");

                    DateTime requestedAtLocalVar = DateTime.UtcNow;

                    using (HttpResponseMessage httpResponseMessageLocalVar = await HttpClient.SendAsync(httpRequestMessageLocalVar, cancellationToken).ConfigureAwait(false))
                    {
                        string responseContentLocalVar = await httpResponseMessageLocalVar.Content.ReadAsStringAsync().ConfigureAwait(false);

                        ILogger<GetIpGeolocationApiResponse> apiResponseLoggerLocalVar = LoggerFactory.CreateLogger<GetIpGeolocationApiResponse>();

                        GetIpGeolocationApiResponse apiResponseLocalVar = new GetIpGeolocationApiResponse(apiResponseLoggerLocalVar, httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, "/ipgeo", requestedAtLocalVar, _jsonSerializerOptions);

                        AfterGetIpGeolocationDefaultImplementation(apiResponseLocalVar, ip, lang, fields, excludes, include, output);

                        Events.ExecuteOnGetIpGeolocation(apiResponseLocalVar);

                        if (apiResponseLocalVar.StatusCode == (HttpStatusCode)429)
                            foreach (TokenBase tokenBaseLocalVar in tokenBaseLocalVars)
                                tokenBaseLocalVar.BeginRateLimit();

                        return apiResponseLocalVar;
                    }
                }
            }
            catch (Exception e)
            {
                OnErrorGetIpGeolocationDefaultImplementation(e, "/ipgeo", uriBuilderLocalVar.Path, ip, lang, fields, excludes, include, output);
                Events.ExecuteOnErrorGetIpGeolocation(e);
                throw;
            }
        }

        /// <summary>
        /// The <see cref="GetIpGeolocationApiResponse"/>
        /// </summary>
        public partial class GetIpGeolocationApiResponse : IPGeolocation.Client.ApiResponse, IGetIpGeolocationApiResponse
        {
            /// <summary>
            /// The logger
            /// </summary>
            public ILogger<GetIpGeolocationApiResponse> Logger { get; }

            /// <summary>
            /// The <see cref="GetIpGeolocationApiResponse"/>
            /// </summary>
            /// <param name="logger"></param>
            /// <param name="httpRequestMessage"></param>
            /// <param name="httpResponseMessage"></param>
            /// <param name="rawContent"></param>
            /// <param name="path"></param>
            /// <param name="requestedAt"></param>
            /// <param name="jsonSerializerOptions"></param>
            public GetIpGeolocationApiResponse(ILogger<GetIpGeolocationApiResponse> logger, System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage, string rawContent, string path, DateTime requestedAt, System.Text.Json.JsonSerializerOptions jsonSerializerOptions) : base(httpRequestMessage, httpResponseMessage, rawContent, path, requestedAt, jsonSerializerOptions)
            {
                Logger = logger;
                OnCreated(httpRequestMessage, httpResponseMessage);
            }

            partial void OnCreated(global::System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage);

            /// <summary>
            /// Returns true if the response is 200 Ok
            /// </summary>
            /// <returns></returns>
            public bool IsOk => 200 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 200 Ok
            /// </summary>
            /// <returns></returns>
            public IPGeolocation.Model.GeolocationResponse? Ok()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsOk
                    ? System.Text.Json.JsonSerializer.Deserialize<IPGeolocation.Model.GeolocationResponse>(RawContent, _jsonSerializerOptions)
                    : default;
            }

            /// <summary>
            /// Returns true if the response is 200 Ok and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryOk(out IPGeolocation.Model.GeolocationResponse? result)
            {
                result = null;

                try
                {
                    result = Ok();
                }
                catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)200);
                }

                return result != null;
            }

            /// <summary>
            /// Returns true if the response is 400 BadRequest
            /// </summary>
            /// <returns></returns>
            public bool IsBadRequest => 400 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 400 BadRequest
            /// </summary>
            /// <returns></returns>
            public IPGeolocation.Model.ErrorResponse? BadRequest()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsBadRequest
                    ? System.Text.Json.JsonSerializer.Deserialize<IPGeolocation.Model.ErrorResponse>(RawContent, _jsonSerializerOptions)
                    : default;
            }

            /// <summary>
            /// Returns true if the response is 400 BadRequest and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryBadRequest(out IPGeolocation.Model.ErrorResponse? result)
            {
                result = null;

                try
                {
                    result = BadRequest();
                }
                catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)400);
                }

                return result != null;
            }

            /// <summary>
            /// Returns true if the response is 401 Unauthorized
            /// </summary>
            /// <returns></returns>
            public bool IsUnauthorized => 401 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 401 Unauthorized
            /// </summary>
            /// <returns></returns>
            public IPGeolocation.Model.ErrorResponse? Unauthorized()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsUnauthorized
                    ? System.Text.Json.JsonSerializer.Deserialize<IPGeolocation.Model.ErrorResponse>(RawContent, _jsonSerializerOptions)
                    : default;
            }

            /// <summary>
            /// Returns true if the response is 401 Unauthorized and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryUnauthorized(out IPGeolocation.Model.ErrorResponse? result)
            {
                result = null;

                try
                {
                    result = Unauthorized();
                }
                catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)401);
                }

                return result != null;
            }

            /// <summary>
            /// Returns true if the response is 403 Forbidden
            /// </summary>
            /// <returns></returns>
            public bool IsForbidden => 403 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 403 Forbidden
            /// </summary>
            /// <returns></returns>
            public IPGeolocation.Model.ErrorResponse? Forbidden()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsForbidden
                    ? System.Text.Json.JsonSerializer.Deserialize<IPGeolocation.Model.ErrorResponse>(RawContent, _jsonSerializerOptions)
                    : default;
            }

            /// <summary>
            /// Returns true if the response is 403 Forbidden and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryForbidden(out IPGeolocation.Model.ErrorResponse? result)
            {
                result = null;

                try
                {
                    result = Forbidden();
                }
                catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)403);
                }

                return result != null;
            }

            /// <summary>
            /// Returns true if the response is 404 NotFound
            /// </summary>
            /// <returns></returns>
            public bool IsNotFound => 404 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 404 NotFound
            /// </summary>
            /// <returns></returns>
            public IPGeolocation.Model.ErrorResponse? NotFound()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsNotFound
                    ? System.Text.Json.JsonSerializer.Deserialize<IPGeolocation.Model.ErrorResponse>(RawContent, _jsonSerializerOptions)
                    : default;
            }

            /// <summary>
            /// Returns true if the response is 404 NotFound and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryNotFound(out IPGeolocation.Model.ErrorResponse? result)
            {
                result = null;

                try
                {
                    result = NotFound();
                }
                catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)404);
                }

                return result != null;
            }

            /// <summary>
            /// Returns true if the response is 405 MethodNotAllowed
            /// </summary>
            /// <returns></returns>
            public bool IsMethodNotAllowed => 405 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 405 MethodNotAllowed
            /// </summary>
            /// <returns></returns>
            public IPGeolocation.Model.ErrorResponse? MethodNotAllowed()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsMethodNotAllowed
                    ? System.Text.Json.JsonSerializer.Deserialize<IPGeolocation.Model.ErrorResponse>(RawContent, _jsonSerializerOptions)
                    : default;
            }

            /// <summary>
            /// Returns true if the response is 405 MethodNotAllowed and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryMethodNotAllowed(out IPGeolocation.Model.ErrorResponse? result)
            {
                result = null;

                try
                {
                    result = MethodNotAllowed();
                }
                catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)405);
                }

                return result != null;
            }

            /// <summary>
            /// Returns true if the response is 423 Locked
            /// </summary>
            /// <returns></returns>
            public bool IsLocked => 423 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 423 Locked
            /// </summary>
            /// <returns></returns>
            public IPGeolocation.Model.ErrorResponse? Locked()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsLocked
                    ? System.Text.Json.JsonSerializer.Deserialize<IPGeolocation.Model.ErrorResponse>(RawContent, _jsonSerializerOptions)
                    : default;
            }

            /// <summary>
            /// Returns true if the response is 423 Locked and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryLocked(out IPGeolocation.Model.ErrorResponse? result)
            {
                result = null;

                try
                {
                    result = Locked();
                }
                catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)423);
                }

                return result != null;
            }

            /// <summary>
            /// Returns true if the response is 429 TooManyRequests
            /// </summary>
            /// <returns></returns>
            public bool IsTooManyRequests => 429 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 429 TooManyRequests
            /// </summary>
            /// <returns></returns>
            public IPGeolocation.Model.ErrorResponse? TooManyRequests()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsTooManyRequests
                    ? System.Text.Json.JsonSerializer.Deserialize<IPGeolocation.Model.ErrorResponse>(RawContent, _jsonSerializerOptions)
                    : default;
            }

            /// <summary>
            /// Returns true if the response is 429 TooManyRequests and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryTooManyRequests(out IPGeolocation.Model.ErrorResponse? result)
            {
                result = null;

                try
                {
                    result = TooManyRequests();
                }
                catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)429);
                }

                return result != null;
            }

            /// <summary>
            /// Returns true if the response is 499 CustomHttpStatusCode499
            /// </summary>
            /// <returns></returns>
            public bool IsCustomHttpStatusCode499 => 499 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 499 CustomHttpStatusCode499
            /// </summary>
            /// <returns></returns>
            public IPGeolocation.Model.ErrorResponse? CustomHttpStatusCode499()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsCustomHttpStatusCode499
                    ? System.Text.Json.JsonSerializer.Deserialize<IPGeolocation.Model.ErrorResponse>(RawContent, _jsonSerializerOptions)
                    : default;
            }

            /// <summary>
            /// Returns true if the response is 499 CustomHttpStatusCode499 and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryCustomHttpStatusCode499(out IPGeolocation.Model.ErrorResponse? result)
            {
                result = null;

                try
                {
                    result = CustomHttpStatusCode499();
                }
                catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)499);
                }

                return result != null;
            }

            /// <summary>
            /// Returns true if the response is 500 InternalServerError
            /// </summary>
            /// <returns></returns>
            public bool IsInternalServerError => 500 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 500 InternalServerError
            /// </summary>
            /// <returns></returns>
            public IPGeolocation.Model.ErrorResponse? InternalServerError()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsInternalServerError
                    ? System.Text.Json.JsonSerializer.Deserialize<IPGeolocation.Model.ErrorResponse>(RawContent, _jsonSerializerOptions)
                    : default;
            }

            /// <summary>
            /// Returns true if the response is 500 InternalServerError and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryInternalServerError(out IPGeolocation.Model.ErrorResponse? result)
            {
                result = null;

                try
                {
                    result = InternalServerError();
                }
                catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)500);
                }

                return result != null;
            }

            private void OnDeserializationErrorDefaultImplementation(Exception exception, HttpStatusCode httpStatusCode)
            {
                bool suppressDefaultLog = false;
                OnDeserializationError(ref suppressDefaultLog, exception, httpStatusCode);
                if (!suppressDefaultLog)
                    Logger.LogError(exception, "An error occurred while deserializing the {code} response.", httpStatusCode);
            }

            partial void OnDeserializationError(ref bool suppressDefaultLog, Exception exception, HttpStatusCode httpStatusCode);
        }
    }
}

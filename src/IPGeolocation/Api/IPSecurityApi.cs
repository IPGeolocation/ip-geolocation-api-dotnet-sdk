

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
    public interface IIPSecurityApi : IApi
    {
        /// <summary>
        /// The class containing the events
        /// </summary>
        SecurityApiEvents Events { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// The Bulk IP Security Lookup API can provide security details for up to &#x60;50,000&#x60; bulk IPs. This API also has parameters to customize the response, just like the single IP Security Lookup API.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="bulkIPRequest"></param>
        /// <param name="include">Include optional objects like &#x60;location&#x60;, &#x60;network&#x60;.  Use comma-separated values. Example: include&#x3D;location,network  (optional)</param>
        /// <param name="fields">Get specific fields, objects from the response. (optional)</param>
        /// <param name="excludes">Exclude specific fields, objects from the response. (optional)</param>
        /// <param name="output">Desired output format. (optional)</param>
        /// <param name="lang">By default, the API responds in English. You can change the response language by passing the language code as a query parameter &#x60;lang&#x60;. Multi language feature is available only for &#x60;paid users&#x60;. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IBulkIPSecurityInfoApiResponse"/>&gt;</returns>
        Task<IBulkIPSecurityInfoApiResponse> GetBulkIpSecurityInfoAsync(BulkIPRequest bulkIPRequest, Option<string> include = default, Option<string> fields = default, Option<string> excludes = default, Option<string> output = default, Option<string> lang = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// The Bulk IP Security Lookup API can provide security details for up to &#x60;50,000&#x60; bulk IPs. This API also has parameters to customize the response, just like the single IP Security Lookup API.
        /// </remarks>
        /// <param name="bulkIPRequest"></param>
        /// <param name="include">Include optional objects like &#x60;location&#x60;, &#x60;network&#x60;.  Use comma-separated values. Example: include&#x3D;location,network  (optional)</param>
        /// <param name="fields">Get specific fields, objects from the response. (optional)</param>
        /// <param name="excludes">Exclude specific fields, objects from the response. (optional)</param>
        /// <param name="output">Desired output format. (optional)</param>
        /// <param name="lang">By default, the API responds in English. You can change the response language by passing the language code as a query parameter &#x60;lang&#x60;. Multi language feature is available only for &#x60;paid users&#x60;. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IBulkIPSecurityInfoApiResponse"/>?&gt;</returns>
        Task<IBulkIPSecurityInfoApiResponse?> GetBulkIpSecurityInfoOrDefaultAsync(BulkIPRequest bulkIPRequest, Option<string> include = default, Option<string> fields = default, Option<string> excludes = default, Option<string> output = default, Option<string> lang = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// IP Security API provides security details of a given IP. It detects whether the IP is proxy, tor or bot. It also shows the proxy types of the IP (like VPN, PROXY, RELAY etc.) with it&#39;s VPN/proxy service provider making our API powerful VPN checker. It finds the IPs that are involved in spam activities. It also checks whether the IP links to a cloud provider and includes the provider&#39;s name.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ip">query parameter &#39;ip&#39;. If not provided, will be your network IP (optional)</param>
        /// <param name="include">Include optional details like location and/or network. (optional)</param>
        /// <param name="fields">Get specific fields, objects from the response. (optional)</param>
        /// <param name="excludes">Exclude specific fields, objects from the response. (optional)</param>
        /// <param name="output">Desired output format (json or xml). (optional)</param>
        /// <param name="lang">By default, the API responds in English. You can change the response language by passing the language code as a query parameter &#x60;lang&#x60;. Multi language feature is available only for &#x60;paid users&#x60;. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IIPSecurityInfoApiResponse"/>&gt;</returns>
        Task<IIPSecurityInfoApiResponse> GetIpSecurityInfoAsync(Option<string> ip = default, Option<string> include = default, Option<string> fields = default, Option<string> excludes = default, Option<string> output = default, Option<string> lang = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// IP Security API provides security details of a given IP. It detects whether the IP is proxy, tor or bot. It also shows the proxy types of the IP (like VPN, PROXY, RELAY etc.) with it&#39;s VPN/proxy service provider making our API powerful VPN checker. It finds the IPs that are involved in spam activities. It also checks whether the IP links to a cloud provider and includes the provider&#39;s name.
        /// </remarks>
        /// <param name="ip">query parameter &#39;ip&#39;. If not provided, will be your network IP (optional)</param>
        /// <param name="include">Include optional details like location and/or network. (optional)</param>
        /// <param name="fields">Get specific fields, objects from the response. (optional)</param>
        /// <param name="excludes">Exclude specific fields, objects from the response. (optional)</param>
        /// <param name="output">Desired output format (json or xml). (optional)</param>
        /// <param name="lang">By default, the API responds in English. You can change the response language by passing the language code as a query parameter &#x60;lang&#x60;. Multi language feature is available only for &#x60;paid users&#x60;. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IIPSecurityInfoApiResponse"/>?&gt;</returns>
        Task<IIPSecurityInfoApiResponse?> GetIpSecurityInfoOrDefaultAsync(Option<string> ip = default, Option<string> include = default, Option<string> fields = default, Option<string> excludes = default, Option<string> output = default, Option<string> lang = default, System.Threading.CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The <see cref="IBulkIPSecurityInfoApiResponse"/>
    /// </summary>
    public interface IBulkIPSecurityInfoApiResponse : IPGeolocation.Client.IApiResponse, IOk<List<BulkIPSecurityResponse>?>, IBadRequest<IPGeolocation.Model.ErrorResponse?>, IUnauthorized<IPGeolocation.Model.ErrorResponse?>, IForbidden<IPGeolocation.Model.ErrorResponse?>, INotFound<IPGeolocation.Model.ErrorResponse?>, IMethodNotAllowed<IPGeolocation.Model.ErrorResponse?>, IContentTooLarge<IPGeolocation.Model.ErrorResponse?>, ITooManyRequests<IPGeolocation.Model.ErrorResponse?>, ICustomHttpStatusCode499<IPGeolocation.Model.ErrorResponse?>, IInternalServerError<IPGeolocation.Model.ErrorResponse?>
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
    /// The <see cref="IIPSecurityInfoApiResponse"/>
    /// </summary>
    public interface IIPSecurityInfoApiResponse : IPGeolocation.Client.IApiResponse, IOk<IPGeolocation.Model.SecurityAPIResponse?>, IBadRequest<IPGeolocation.Model.ErrorResponse?>, IUnauthorized<IPGeolocation.Model.ErrorResponse?>, INotFound<IPGeolocation.Model.ErrorResponse?>, IMethodNotAllowed<IPGeolocation.Model.ErrorResponse?>, ITooManyRequests<IPGeolocation.Model.ErrorResponse?>, ICustomHttpStatusCode499<IPGeolocation.Model.ErrorResponse?>, IInternalServerError<IPGeolocation.Model.ErrorResponse?>
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
    public class SecurityApiEvents
    {
        /// <summary>
        /// The event raised after the server response
        /// </summary>
        public event EventHandler<ApiResponseEventArgs>? OnGetBulkIpSecurityInfo;

        /// <summary>
        /// The event raised after an error querying the server
        /// </summary>
        public event EventHandler<ExceptionEventArgs>? OnErrorGetBulkIpSecurityInfo;

        internal void ExecuteOnGetBulkIpSecurityInfo(SecurityApi.BulkIPSecurityInfoApiResponse apiResponse)
        {
            OnGetBulkIpSecurityInfo?.Invoke(this, new ApiResponseEventArgs(apiResponse));
        }

        internal void ExecuteOnErrorGetBulkIpSecurityInfo(Exception exception)
        {
            OnErrorGetBulkIpSecurityInfo?.Invoke(this, new ExceptionEventArgs(exception));
        }

        /// <summary>
        /// The event raised after the server response
        /// </summary>
        public event EventHandler<ApiResponseEventArgs>? OnGetIpSecurityInfo;

        /// <summary>
        /// The event raised after an error querying the server
        /// </summary>
        public event EventHandler<ExceptionEventArgs>? OnErrorGetIpSecurityInfo;

        internal void ExecuteOnGetIpSecurityInfo(SecurityApi.IPSecurityInfoApiResponse apiResponse)
        {
            OnGetIpSecurityInfo?.Invoke(this, new ApiResponseEventArgs(apiResponse));
        }

        internal void ExecuteOnErrorGetIpSecurityInfo(Exception exception)
        {
            OnErrorGetIpSecurityInfo?.Invoke(this, new ExceptionEventArgs(exception));
        }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public sealed partial class SecurityApi : IIPSecurityApi
    {
        private JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        /// The logger factory
        /// </summary>
        public ILoggerFactory LoggerFactory { get; }

        /// <summary>
        /// The logger
        /// </summary>
        public ILogger<SecurityApi> Logger { get; }

        /// <summary>
        /// The HttpClient
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// The class containing the events
        /// </summary>
        public SecurityApiEvents Events { get; }

        /// <summary>
        /// A token provider of type <see cref="ApiKeyProvider"/>
        /// </summary>
        public TokenProvider<ApiKeyToken> ApiKeyProvider { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SecurityApi(ILogger<SecurityApi> logger, ILoggerFactory loggerFactory, HttpClient httpClient, JsonSerializerOptionsProvider jsonSerializerOptionsProvider, SecurityApiEvents securityApiEvents,
            TokenProvider<ApiKeyToken> apiKeyProvider)
        {
            _jsonSerializerOptions = jsonSerializerOptionsProvider.Options;
            LoggerFactory = loggerFactory;
            Logger = LoggerFactory.CreateLogger<SecurityApi>();
            HttpClient = httpClient;
            Events = securityApiEvents;
            ApiKeyProvider = apiKeyProvider;
        }

        partial void FormatGetBulkIpSecurityInfo(BulkIPRequest bulkIPRequest, ref Option<string> include, ref Option<string> fields, ref Option<string> excludes, ref Option<string> output, ref Option<string> lang);

        /// <summary>
        /// Validates the request parameters
        /// </summary>
        /// <param name="bulkIPRequest"></param>
        /// <param name="include"></param>
        /// <param name="fields"></param>
        /// <param name="excludes"></param>
        /// <param name="output"></param>
        /// <param name="lang"></param>
        /// <returns></returns>
        private void ValidateGetBulkIpSecurityInfo(BulkIPRequest bulkIPRequest, Option<string> include, Option<string> fields, Option<string> excludes, Option<string> output, Option<string> lang)
        {
            if (bulkIPRequest == null)
                throw new ArgumentNullException(nameof(bulkIPRequest));

            if (include.IsSet && include.Value == null)
                throw new ArgumentNullException(nameof(include));

            if (fields.IsSet && fields.Value == null)
                throw new ArgumentNullException(nameof(fields));

            if (excludes.IsSet && excludes.Value == null)
                throw new ArgumentNullException(nameof(excludes));

            if (output.IsSet && output.Value == null)
                throw new ArgumentNullException(nameof(output));

            if (lang.IsSet && lang.Value == null)
                throw new ArgumentNullException(nameof(lang));
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="bulkIPRequest"></param>
        /// <param name="include"></param>
        /// <param name="fields"></param>
        /// <param name="excludes"></param>
        /// <param name="output"></param>
        /// <param name="lang"></param>
        private void AfterGetBulkIpSecurityInfoDefaultImplementation(IBulkIPSecurityInfoApiResponse apiResponseLocalVar, BulkIPRequest bulkIPRequest, Option<string> include, Option<string> fields, Option<string> excludes, Option<string> output, Option<string> lang)
        {
            bool suppressDefaultLog = false;
            AfterGetBulkIpSecurityInfo(ref suppressDefaultLog, apiResponseLocalVar, bulkIPRequest, include, fields, excludes, output, lang);
            if (!suppressDefaultLog)
                Logger.LogInformation("{0,-9} | {1} | {3}", (apiResponseLocalVar.DownloadedAt - apiResponseLocalVar.RequestedAt).TotalSeconds, apiResponseLocalVar.StatusCode, apiResponseLocalVar.Path);
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="bulkIPRequest"></param>
        /// <param name="include"></param>
        /// <param name="fields"></param>
        /// <param name="excludes"></param>
        /// <param name="output"></param>
        /// <param name="lang"></param>
        partial void AfterGetBulkIpSecurityInfo(ref bool suppressDefaultLog, IBulkIPSecurityInfoApiResponse apiResponseLocalVar, BulkIPRequest bulkIPRequest, Option<string> include, Option<string> fields, Option<string> excludes, Option<string> output, Option<string> lang);

        /// <summary>
        /// Logs exceptions that occur while retrieving the server response
        /// </summary>
        /// <param name="exceptionLocalVar"></param>
        /// <param name="pathFormatLocalVar"></param>
        /// <param name="pathLocalVar"></param>
        /// <param name="bulkIPRequest"></param>
        /// <param name="include"></param>
        /// <param name="fields"></param>
        /// <param name="excludes"></param>
        /// <param name="output"></param>
        /// <param name="lang"></param>
        private void OnErrorGetBulkIpSecurityInfoDefaultImplementation(Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, BulkIPRequest bulkIPRequest, Option<string> include, Option<string> fields, Option<string> excludes, Option<string> output, Option<string> lang)
        {
            bool suppressDefaultLogLocalVar = false;
            OnErrorGetBulkIpSecurityInfo(ref suppressDefaultLogLocalVar, exceptionLocalVar, pathFormatLocalVar, pathLocalVar, bulkIPRequest, include, fields, excludes, output, lang);
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
        /// <param name="include"></param>
        /// <param name="fields"></param>
        /// <param name="excludes"></param>
        /// <param name="output"></param>
        /// <param name="lang"></param>
        partial void OnErrorGetBulkIpSecurityInfo(ref bool suppressDefaultLogLocalVar, Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, BulkIPRequest bulkIPRequest, Option<string> include, Option<string> fields, Option<string> excludes, Option<string> output, Option<string> lang);

        /// <summary>
        ///  The Bulk IP Security Lookup API can provide security details for up to &#x60;50,000&#x60; bulk IPs. This API also has parameters to customize the response, just like the single IP Security Lookup API.
        /// </summary>
        /// <param name="bulkIPRequest"></param>
        /// <param name="include">Include optional objects like &#x60;location&#x60;, &#x60;network&#x60;.  Use comma-separated values. Example: include&#x3D;location,network  (optional)</param>
        /// <param name="fields">Get specific fields, objects from the response. (optional)</param>
        /// <param name="excludes">Exclude specific fields, objects from the response. (optional)</param>
        /// <param name="output">Desired output format. (optional)</param>
        /// <param name="lang">By default, the API responds in English. You can change the response language by passing the language code as a query parameter &#x60;lang&#x60;. Multi language feature is available only for &#x60;paid users&#x60;. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IBulkIPSecurityInfoApiResponse"/>&gt;</returns>
        public async Task<IBulkIPSecurityInfoApiResponse?> GetBulkIpSecurityInfoOrDefaultAsync(BulkIPRequest bulkIPRequest, Option<string> include = default, Option<string> fields = default, Option<string> excludes = default, Option<string> output = default, Option<string> lang = default, System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await GetBulkIpSecurityInfoAsync(bulkIPRequest, include, fields, excludes, output, lang, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        ///  The Bulk IP Security Lookup API can provide security details for up to &#x60;50,000&#x60; bulk IPs. This API also has parameters to customize the response, just like the single IP Security Lookup API.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="bulkIPRequest"></param>
        /// <param name="include">Include optional objects like &#x60;location&#x60;, &#x60;network&#x60;.  Use comma-separated values. Example: include&#x3D;location,network  (optional)</param>
        /// <param name="fields">Get specific fields, objects from the response. (optional)</param>
        /// <param name="excludes">Exclude specific fields, objects from the response. (optional)</param>
        /// <param name="output">Desired output format. (optional)</param>
        /// <param name="lang">By default, the API responds in English. You can change the response language by passing the language code as a query parameter &#x60;lang&#x60;. Multi language feature is available only for &#x60;paid users&#x60;. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IBulkIPSecurityInfoApiResponse"/>&gt;</returns>
        public async Task<IBulkIPSecurityInfoApiResponse> GetBulkIpSecurityInfoAsync(BulkIPRequest bulkIPRequest, Option<string> include = default, Option<string> fields = default, Option<string> excludes = default, Option<string> output = default, Option<string> lang = default, System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                ValidateGetBulkIpSecurityInfo(bulkIPRequest, include, fields, excludes, output, lang);

                FormatGetBulkIpSecurityInfo(bulkIPRequest, ref include, ref fields, ref excludes, ref output, ref lang);

                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress!.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = HttpClient.BaseAddress.AbsolutePath == "/"
                        ? "/security-bulk"
                        : string.Concat(HttpClient.BaseAddress.AbsolutePath, "/security-bulk");

                    System.Collections.Specialized.NameValueCollection parseQueryStringLocalVar = System.Web.HttpUtility.ParseQueryString(string.Empty);

                    if (include.IsSet)
                        parseQueryStringLocalVar["include"] = ClientUtils.ParameterToString(include.Value);

                    if (fields.IsSet)
                        parseQueryStringLocalVar["fields"] = ClientUtils.ParameterToString(fields.Value);

                    if (excludes.IsSet)
                        parseQueryStringLocalVar["excludes"] = ClientUtils.ParameterToString(excludes.Value);

                    if (output.IsSet)
                        parseQueryStringLocalVar["output"] = ClientUtils.ParameterToString(output.Value);

                    if (lang.IsSet)
                        parseQueryStringLocalVar["lang"] = ClientUtils.ParameterToString(lang.Value);

                    uriBuilderLocalVar.Query = parseQueryStringLocalVar.ToString();

                    httpRequestMessageLocalVar.Content = (bulkIPRequest as object) is System.IO.Stream stream
                        ? httpRequestMessageLocalVar.Content = new StreamContent(stream)
                        : httpRequestMessageLocalVar.Content = new StringContent(JsonSerializer.Serialize(bulkIPRequest, _jsonSerializerOptions));

                    List<TokenBase> tokenBaseLocalVars = new List<TokenBase>();
                    ApiKeyToken apiKeyTokenLocalVar1 = (ApiKeyToken) await ApiKeyProvider.GetAsync("apiKey", cancellationToken).ConfigureAwait(false);
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

                        ILogger<BulkIPSecurityInfoApiResponse> apiResponseLoggerLocalVar = LoggerFactory.CreateLogger<BulkIPSecurityInfoApiResponse>();

                        BulkIPSecurityInfoApiResponse apiResponseLocalVar = new BulkIPSecurityInfoApiResponse(apiResponseLoggerLocalVar, httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, "/security-bulk", requestedAtLocalVar, _jsonSerializerOptions);

                        AfterGetBulkIpSecurityInfoDefaultImplementation(apiResponseLocalVar, bulkIPRequest, include, fields, excludes, output, lang);

                        Events.ExecuteOnGetBulkIpSecurityInfo(apiResponseLocalVar);

                        if (apiResponseLocalVar.StatusCode == (HttpStatusCode) 429)
                            foreach(TokenBase tokenBaseLocalVar in tokenBaseLocalVars)
                                tokenBaseLocalVar.BeginRateLimit();

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorGetBulkIpSecurityInfoDefaultImplementation(e, "/security-bulk", uriBuilderLocalVar.Path, bulkIPRequest, include, fields, excludes, output, lang);
                Events.ExecuteOnErrorGetBulkIpSecurityInfo(e);
                throw;
            }
        }

        /// <summary>
        /// The <see cref="BulkIPSecurityInfoApiResponse"/>
        /// </summary>
        public partial class BulkIPSecurityInfoApiResponse : IPGeolocation.Client.ApiResponse, IBulkIPSecurityInfoApiResponse
        {
            /// <summary>
            /// The logger
            /// </summary>
            public ILogger<BulkIPSecurityInfoApiResponse> Logger { get; }

            /// <summary>
            /// The <see cref="BulkIPSecurityInfoApiResponse"/>
            /// </summary>
            /// <param name="logger"></param>
            /// <param name="httpRequestMessage"></param>
            /// <param name="httpResponseMessage"></param>
            /// <param name="rawContent"></param>
            /// <param name="path"></param>
            /// <param name="requestedAt"></param>
            /// <param name="jsonSerializerOptions"></param>
            public BulkIPSecurityInfoApiResponse(ILogger<BulkIPSecurityInfoApiResponse> logger, System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage, string rawContent, string path, DateTime requestedAt, System.Text.Json.JsonSerializerOptions jsonSerializerOptions) : base(httpRequestMessage, httpResponseMessage, rawContent, path, requestedAt, jsonSerializerOptions)
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
            public List<BulkIPSecurityResponse>? Ok()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsOk
                    ? System.Text.Json.JsonSerializer.Deserialize<List<BulkIPSecurityResponse>>(RawContent, _jsonSerializerOptions)
                    : default;
            }

            /// <summary>
            /// Returns true if the response is 200 Ok and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryOk(out List<BulkIPSecurityResponse>? result)
            {
                result = null;

                try
                {
                    result = Ok();
                } catch (Exception e)
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
                } catch (Exception e)
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
                } catch (Exception e)
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
                } catch (Exception e)
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
                } catch (Exception e)
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
                } catch (Exception e)
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
                } catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)413);
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
                } catch (Exception e)
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
                } catch (Exception e)
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
                } catch (Exception e)
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

        partial void FormatGetIpSecurityInfo(ref Option<string> ip, ref Option<string> include, ref Option<string> fields, ref Option<string> excludes, ref Option<string> output, ref Option<string> lang);

        /// <summary>
        /// Validates the request parameters
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="include"></param>
        /// <param name="fields"></param>
        /// <param name="excludes"></param>
        /// <param name="output"></param>
        /// <param name="lang"></param>
        /// <returns></returns>
        private void ValidateGetIpSecurityInfo(Option<string> ip, Option<string> include, Option<string> fields, Option<string> excludes, Option<string> output, Option<string> lang)
        {
            if (ip.IsSet && ip.Value == null)
                throw new ArgumentNullException(nameof(ip));

            if (include.IsSet && include.Value == null)
                throw new ArgumentNullException(nameof(include));

            if (fields.IsSet && fields.Value == null)
                throw new ArgumentNullException(nameof(fields));

            if (excludes.IsSet && excludes.Value == null)
                throw new ArgumentNullException(nameof(excludes));

            if (output.IsSet && output.Value == null)
                throw new ArgumentNullException(nameof(output));

            if (lang.IsSet && lang.Value == null)
                throw new ArgumentNullException(nameof(lang));
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="ip"></param>
        /// <param name="include"></param>
        /// <param name="fields"></param>
        /// <param name="excludes"></param>
        /// <param name="output"></param>
        /// <param name="lang"></param>
        private void AfterGetIpSecurityInfoDefaultImplementation(IIPSecurityInfoApiResponse apiResponseLocalVar, Option<string> ip, Option<string> include, Option<string> fields, Option<string> excludes, Option<string> output, Option<string> lang)
        {
            bool suppressDefaultLog = false;
            AfterGetIpSecurityInfo(ref suppressDefaultLog, apiResponseLocalVar, ip, include, fields, excludes, output, lang);
            if (!suppressDefaultLog)
                Logger.LogInformation("{0,-9} | {1} | {3}", (apiResponseLocalVar.DownloadedAt - apiResponseLocalVar.RequestedAt).TotalSeconds, apiResponseLocalVar.StatusCode, apiResponseLocalVar.Path);
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="ip"></param>
        /// <param name="include"></param>
        /// <param name="fields"></param>
        /// <param name="excludes"></param>
        /// <param name="output"></param>
        /// <param name="lang"></param>
        partial void AfterGetIpSecurityInfo(ref bool suppressDefaultLog, IIPSecurityInfoApiResponse apiResponseLocalVar, Option<string> ip, Option<string> include, Option<string> fields, Option<string> excludes, Option<string> output, Option<string> lang);

        /// <summary>
        /// Logs exceptions that occur while retrieving the server response
        /// </summary>
        /// <param name="exceptionLocalVar"></param>
        /// <param name="pathFormatLocalVar"></param>
        /// <param name="pathLocalVar"></param>
        /// <param name="ip"></param>
        /// <param name="include"></param>
        /// <param name="fields"></param>
        /// <param name="excludes"></param>
        /// <param name="output"></param>
        /// <param name="lang"></param>
        private void OnErrorGetIpSecurityInfoDefaultImplementation(Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, Option<string> ip, Option<string> include, Option<string> fields, Option<string> excludes, Option<string> output, Option<string> lang)
        {
            bool suppressDefaultLogLocalVar = false;
            OnErrorGetIpSecurityInfo(ref suppressDefaultLogLocalVar, exceptionLocalVar, pathFormatLocalVar, pathLocalVar, ip, include, fields, excludes, output, lang);
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
        /// <param name="include"></param>
        /// <param name="fields"></param>
        /// <param name="excludes"></param>
        /// <param name="output"></param>
        /// <param name="lang"></param>
        partial void OnErrorGetIpSecurityInfo(ref bool suppressDefaultLogLocalVar, Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, Option<string> ip, Option<string> include, Option<string> fields, Option<string> excludes, Option<string> output, Option<string> lang);

        /// <summary>
        ///  IP Security API provides security details of a given IP. It detects whether the IP is proxy, tor or bot. It also shows the proxy types of the IP (like VPN, PROXY, RELAY etc.) with it&#39;s VPN/proxy service provider making our API powerful VPN checker. It finds the IPs that are involved in spam activities. It also checks whether the IP links to a cloud provider and includes the provider&#39;s name.
        /// </summary>
        /// <param name="ip">query parameter &#39;ip&#39;. If not provided, will be your network IP (optional)</param>
        /// <param name="include">Include optional details like location and/or network. (optional)</param>
        /// <param name="fields">Get specific fields, objects from the response. (optional)</param>
        /// <param name="excludes">Exclude specific fields, objects from the response. (optional)</param>
        /// <param name="output">Desired output format (json or xml). (optional)</param>
        /// <param name="lang">By default, the API responds in English. You can change the response language by passing the language code as a query parameter &#x60;lang&#x60;. Multi language feature is available only for &#x60;paid users&#x60;. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IIPSecurityInfoApiResponse"/>&gt;</returns>
        public async Task<IIPSecurityInfoApiResponse?> GetIpSecurityInfoOrDefaultAsync(Option<string> ip = default, Option<string> include = default, Option<string> fields = default, Option<string> excludes = default, Option<string> output = default, Option<string> lang = default, System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await GetIpSecurityInfoAsync(ip, include, fields, excludes, output, lang, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        ///  IP Security API provides security details of a given IP. It detects whether the IP is proxy, tor or bot. It also shows the proxy types of the IP (like VPN, PROXY, RELAY etc.) with it&#39;s VPN/proxy service provider making our API powerful VPN checker. It finds the IPs that are involved in spam activities. It also checks whether the IP links to a cloud provider and includes the provider&#39;s name.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ip">query parameter &#39;ip&#39;. If not provided, will be your network IP (optional)</param>
        /// <param name="include">Include optional details like location and/or network. (optional)</param>
        /// <param name="fields">Get specific fields, objects from the response. (optional)</param>
        /// <param name="excludes">Exclude specific fields, objects from the response. (optional)</param>
        /// <param name="output">Desired output format (json or xml). (optional)</param>
        /// <param name="lang">By default, the API responds in English. You can change the response language by passing the language code as a query parameter &#x60;lang&#x60;. Multi language feature is available only for &#x60;paid users&#x60;. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IIPSecurityInfoApiResponse"/>&gt;</returns>
        public async Task<IIPSecurityInfoApiResponse> GetIpSecurityInfoAsync(Option<string> ip = default, Option<string> include = default, Option<string> fields = default, Option<string> excludes = default, Option<string> output = default, Option<string> lang = default, System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                ValidateGetIpSecurityInfo(ip, include, fields, excludes, output, lang);

                FormatGetIpSecurityInfo(ref ip, ref include, ref fields, ref excludes, ref output, ref lang);

                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress!.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = HttpClient.BaseAddress.AbsolutePath == "/"
                        ? "/security"
                        : string.Concat(HttpClient.BaseAddress.AbsolutePath, "/security");

                    System.Collections.Specialized.NameValueCollection parseQueryStringLocalVar = System.Web.HttpUtility.ParseQueryString(string.Empty);

                    if (ip.IsSet)
                        parseQueryStringLocalVar["ip"] = ClientUtils.ParameterToString(ip.Value);

                    if (include.IsSet)
                        parseQueryStringLocalVar["include"] = ClientUtils.ParameterToString(include.Value);

                    if (fields.IsSet)
                        parseQueryStringLocalVar["fields"] = ClientUtils.ParameterToString(fields.Value);

                    if (excludes.IsSet)
                        parseQueryStringLocalVar["excludes"] = ClientUtils.ParameterToString(excludes.Value);

                    if (output.IsSet)
                        parseQueryStringLocalVar["output"] = ClientUtils.ParameterToString(output.Value);

                    if (lang.IsSet)
                        parseQueryStringLocalVar["lang"] = ClientUtils.ParameterToString(lang.Value);

                    uriBuilderLocalVar.Query = parseQueryStringLocalVar.ToString();

                    List<TokenBase> tokenBaseLocalVars = new List<TokenBase>();
                    ApiKeyToken apiKeyTokenLocalVar1 = (ApiKeyToken) await ApiKeyProvider.GetAsync("apiKey", cancellationToken).ConfigureAwait(false);
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
                    httpRequestMessageLocalVar.Headers.UserAgent.ParseAdd("IPGeolocation.NET-SDK/2.0.0");
                    DateTime requestedAtLocalVar = DateTime.UtcNow;

                    using (HttpResponseMessage httpResponseMessageLocalVar = await HttpClient.SendAsync(httpRequestMessageLocalVar, cancellationToken).ConfigureAwait(false))
                    {
                        string responseContentLocalVar = await httpResponseMessageLocalVar.Content.ReadAsStringAsync().ConfigureAwait(false);

                        ILogger<IPSecurityInfoApiResponse> apiResponseLoggerLocalVar = LoggerFactory.CreateLogger<IPSecurityInfoApiResponse>();

                        IPSecurityInfoApiResponse apiResponseLocalVar = new IPSecurityInfoApiResponse(apiResponseLoggerLocalVar, httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, "/security", requestedAtLocalVar, _jsonSerializerOptions);

                        AfterGetIpSecurityInfoDefaultImplementation(apiResponseLocalVar, ip, include, fields, excludes, output, lang);

                        Events.ExecuteOnGetIpSecurityInfo(apiResponseLocalVar);

                        if (apiResponseLocalVar.StatusCode == (HttpStatusCode) 429)
                            foreach(TokenBase tokenBaseLocalVar in tokenBaseLocalVars)
                                tokenBaseLocalVar.BeginRateLimit();

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorGetIpSecurityInfoDefaultImplementation(e, "/security", uriBuilderLocalVar.Path, ip, include, fields, excludes, output, lang);
                Events.ExecuteOnErrorGetIpSecurityInfo(e);
                throw;
            }
        }

        /// <summary>
        /// The <see cref="IPSecurityInfoApiResponse"/>
        /// </summary>
        public partial class IPSecurityInfoApiResponse : IPGeolocation.Client.ApiResponse, IIPSecurityInfoApiResponse
        {
            /// <summary>
            /// The logger
            /// </summary>
            public ILogger<IPSecurityInfoApiResponse> Logger { get; }

            /// <summary>
            /// The <see cref="IPSecurityInfoApiResponse"/>
            /// </summary>
            /// <param name="logger"></param>
            /// <param name="httpRequestMessage"></param>
            /// <param name="httpResponseMessage"></param>
            /// <param name="rawContent"></param>
            /// <param name="path"></param>
            /// <param name="requestedAt"></param>
            /// <param name="jsonSerializerOptions"></param>
            public IPSecurityInfoApiResponse(ILogger<IPSecurityInfoApiResponse> logger, System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage, string rawContent, string path, DateTime requestedAt, System.Text.Json.JsonSerializerOptions jsonSerializerOptions) : base(httpRequestMessage, httpResponseMessage, rawContent, path, requestedAt, jsonSerializerOptions)
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
            public IPGeolocation.Model.SecurityAPIResponse? Ok()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsOk
                    ? System.Text.Json.JsonSerializer.Deserialize<IPGeolocation.Model.SecurityAPIResponse>(RawContent, _jsonSerializerOptions)
                    : default;
            }

            /// <summary>
            /// Returns true if the response is 200 Ok and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryOk(out IPGeolocation.Model.SecurityAPIResponse? result)
            {
                result = null;

                try
                {
                    result = Ok();
                } catch (Exception e)
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
                } catch (Exception e)
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
                } catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)401);
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
                } catch (Exception e)
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
                } catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)405);
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
                } catch (Exception e)
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
                } catch (Exception e)
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
                } catch (Exception e)
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



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
    public interface IAbuseContactApi : IApi
    {
        /// <summary>
        /// The class containing the events
        /// </summary>
        AbuseContactApiEvents Events { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// The Abuse Contact API provides essential contact information to report abusive activity associated with IP addresses. By querying an IP address (IPv4 or IPv6), users receive detailed abuse contact data, including the responsible organization, abuse handling role, contact emails, phone numbers, and registered address. This enables users to swiftly take action to report and mitigate threats such as spam, DDoS attacks, and phishing.     In addition to abuse-specific contacts, the API also includes registration metadata like the registered country and abuse handle. This empowers cybersecurity teams, hosting providers, and compliance entities to take appropriate legal or administrative action. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ip">query parameter &#39;ip&#39;. (optional)</param>
        /// <param name="excludes">You can exclude specific fields from the API response (except the ip field) by listing them in the excludes parameter as a comma-separated list. For example, you want to remove emails and handle from api response, you can put the keys in excludes parameter like this. (optional)</param>
        /// <param name="fields">You can customize the API response by using the fields parameter to include only the specific data you need. For example, to retrieve only the role and emails, specify these keys in the fields parameter as shown below. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IAbuseContactInfoApiResponse"/>&gt;</returns>
        Task<IAbuseContactInfoApiResponse> GetAbuseContactInfoAsync(Option<string> ip = default, Option<string> excludes = default, Option<string> fields = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// The Abuse Contact API provides essential contact information to report abusive activity associated with IP addresses. By querying an IP address (IPv4 or IPv6), users receive detailed abuse contact data, including the responsible organization, abuse handling role, contact emails, phone numbers, and registered address. This enables users to swiftly take action to report and mitigate threats such as spam, DDoS attacks, and phishing.     In addition to abuse-specific contacts, the API also includes registration metadata like the registered country and abuse handle. This empowers cybersecurity teams, hosting providers, and compliance entities to take appropriate legal or administrative action. 
        /// </remarks>
        /// <param name="ip">query parameter &#39;ip&#39;. (optional)</param>
        /// <param name="excludes">You can exclude specific fields from the API response (except the ip field) by listing them in the excludes parameter as a comma-separated list. For example, you want to remove emails and handle from api response, you can put the keys in excludes parameter like this. (optional)</param>
        /// <param name="fields">You can customize the API response by using the fields parameter to include only the specific data you need. For example, to retrieve only the role and emails, specify these keys in the fields parameter as shown below. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IAbuseContactInfoApiResponse"/>?&gt;</returns>
        Task<IAbuseContactInfoApiResponse?> GetAbuseContactInfoOrDefaultAsync(Option<string> ip = default, Option<string> excludes = default, Option<string> fields = default, System.Threading.CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The <see cref="IAbuseContactInfoApiResponse"/>
    /// </summary>
    public interface IAbuseContactInfoApiResponse : IPGeolocation.Client.IApiResponse, IOk<IPGeolocation.Model.AbuseResponse?>, IBadRequest<IPGeolocation.Model.ErrorResponse?>, IUnauthorized<IPGeolocation.Model.ErrorResponse?>, INotFound<IPGeolocation.Model.ErrorResponse?>, IMethodNotAllowed<IPGeolocation.Model.ErrorResponse?>, ITooManyRequests<IPGeolocation.Model.ErrorResponse?>, ICustomHttpStatusCode499<IPGeolocation.Model.ErrorResponse?>, IInternalServerError<IPGeolocation.Model.ErrorResponse?>
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
    public class AbuseContactApiEvents
    {
        /// <summary>
        /// The event raised after the server response
        /// </summary>
        public event EventHandler<ApiResponseEventArgs>? OnGetAbuseContactInfo;

        /// <summary>
        /// The event raised after an error querying the server
        /// </summary>
        public event EventHandler<ExceptionEventArgs>? OnErrorGetAbuseContactInfo;

        internal void ExecuteOnGetAbuseContactInfo(AbuseContactApi.AbuseContactInfoApiResponse apiResponse)
        {
            OnGetAbuseContactInfo?.Invoke(this, new ApiResponseEventArgs(apiResponse));
        }

        internal void ExecuteOnErrorGetAbuseContactInfo(Exception exception)
        {
            OnErrorGetAbuseContactInfo?.Invoke(this, new ExceptionEventArgs(exception));
        }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public sealed partial class AbuseContactApi : IAbuseContactApi
    {
        private JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        /// The logger factory
        /// </summary>
        public ILoggerFactory LoggerFactory { get; }

        /// <summary>
        /// The logger
        /// </summary>
        public ILogger<AbuseContactApi> Logger { get; }

        /// <summary>
        /// The HttpClient
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// The class containing the events
        /// </summary>
        public AbuseContactApiEvents Events { get; }

        /// <summary>
        /// A token provider of type <see cref="ApiKeyProvider"/>
        /// </summary>
        public TokenProvider<ApiKeyToken> ApiKeyProvider { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AbuseContactApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AbuseContactApi(ILogger<AbuseContactApi> logger, ILoggerFactory loggerFactory, HttpClient httpClient, JsonSerializerOptionsProvider jsonSerializerOptionsProvider, AbuseContactApiEvents abuseContactApiEvents,
            TokenProvider<ApiKeyToken> apiKeyProvider)
        {
            _jsonSerializerOptions = jsonSerializerOptionsProvider.Options;
            LoggerFactory = loggerFactory;
            Logger = LoggerFactory.CreateLogger<AbuseContactApi>();
            HttpClient = httpClient;
            Events = abuseContactApiEvents;
            ApiKeyProvider = apiKeyProvider;
        }

        partial void FormatGetAbuseContactInfo(ref Option<string> ip, ref Option<string> excludes, ref Option<string> fields);

        /// <summary>
        /// Validates the request parameters
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="excludes"></param>
        /// <param name="fields"></param>
        /// <returns></returns>
        private void ValidateGetAbuseContactInfo(Option<string> ip, Option<string> excludes, Option<string> fields)
        {
            if (ip.IsSet && ip.Value == null)
                throw new ArgumentNullException(nameof(ip));

            if (excludes.IsSet && excludes.Value == null)
                throw new ArgumentNullException(nameof(excludes));

            if (fields.IsSet && fields.Value == null)
                throw new ArgumentNullException(nameof(fields));
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="ip"></param>
        /// <param name="excludes"></param>
        /// <param name="fields"></param>
        private void AfterGetAbuseContactInfoDefaultImplementation(IAbuseContactInfoApiResponse apiResponseLocalVar, Option<string> ip, Option<string> excludes, Option<string> fields)
        {
            bool suppressDefaultLog = false;
            AfterGetAbuseContactInfo(ref suppressDefaultLog, apiResponseLocalVar, ip, excludes, fields);
            if (!suppressDefaultLog)
                Logger.LogInformation("{0,-9} | {1} | {3}", (apiResponseLocalVar.DownloadedAt - apiResponseLocalVar.RequestedAt).TotalSeconds, apiResponseLocalVar.StatusCode, apiResponseLocalVar.Path);
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="ip"></param>
        /// <param name="excludes"></param>
        /// <param name="fields"></param>
        partial void AfterGetAbuseContactInfo(ref bool suppressDefaultLog, IAbuseContactInfoApiResponse apiResponseLocalVar, Option<string> ip, Option<string> excludes, Option<string> fields);

        /// <summary>
        /// Logs exceptions that occur while retrieving the server response
        /// </summary>
        /// <param name="exceptionLocalVar"></param>
        /// <param name="pathFormatLocalVar"></param>
        /// <param name="pathLocalVar"></param>
        /// <param name="ip"></param>
        /// <param name="excludes"></param>
        /// <param name="fields"></param>
        private void OnErrorGetAbuseContactInfoDefaultImplementation(Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, Option<string> ip, Option<string> excludes, Option<string> fields)
        {
            bool suppressDefaultLogLocalVar = false;
            OnErrorGetAbuseContactInfo(ref suppressDefaultLogLocalVar, exceptionLocalVar, pathFormatLocalVar, pathLocalVar, ip, excludes, fields);
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
        /// <param name="excludes"></param>
        /// <param name="fields"></param>
        partial void OnErrorGetAbuseContactInfo(ref bool suppressDefaultLogLocalVar, Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, Option<string> ip, Option<string> excludes, Option<string> fields);

        /// <summary>
        ///  The Abuse Contact API provides essential contact information to report abusive activity associated with IP addresses. By querying an IP address (IPv4 or IPv6), users receive detailed abuse contact data, including the responsible organization, abuse handling role, contact emails, phone numbers, and registered address. This enables users to swiftly take action to report and mitigate threats such as spam, DDoS attacks, and phishing.     In addition to abuse-specific contacts, the API also includes registration metadata like the registered country and abuse handle. This empowers cybersecurity teams, hosting providers, and compliance entities to take appropriate legal or administrative action. 
        /// </summary>
        /// <param name="ip">query parameter &#39;ip&#39;. (optional)</param>
        /// <param name="excludes">You can exclude specific fields from the API response (except the ip field) by listing them in the excludes parameter as a comma-separated list. For example, you want to remove emails and handle from api response, you can put the keys in excludes parameter like this. (optional)</param>
        /// <param name="fields">You can customize the API response by using the fields parameter to include only the specific data you need. For example, to retrieve only the role and emails, specify these keys in the fields parameter as shown below. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IAbuseContactInfoApiResponse"/>&gt;</returns>
        public async Task<IAbuseContactInfoApiResponse?> GetAbuseContactInfoOrDefaultAsync(Option<string> ip = default, Option<string> excludes = default, Option<string> fields = default, System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await GetAbuseContactInfoAsync(ip, excludes, fields, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        ///  The Abuse Contact API provides essential contact information to report abusive activity associated with IP addresses. By querying an IP address (IPv4 or IPv6), users receive detailed abuse contact data, including the responsible organization, abuse handling role, contact emails, phone numbers, and registered address. This enables users to swiftly take action to report and mitigate threats such as spam, DDoS attacks, and phishing.     In addition to abuse-specific contacts, the API also includes registration metadata like the registered country and abuse handle. This empowers cybersecurity teams, hosting providers, and compliance entities to take appropriate legal or administrative action. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ip">query parameter &#39;ip&#39;. (optional)</param>
        /// <param name="excludes">You can exclude specific fields from the API response (except the ip field) by listing them in the excludes parameter as a comma-separated list. For example, you want to remove emails and handle from api response, you can put the keys in excludes parameter like this. (optional)</param>
        /// <param name="fields">You can customize the API response by using the fields parameter to include only the specific data you need. For example, to retrieve only the role and emails, specify these keys in the fields parameter as shown below. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IAbuseContactInfoApiResponse"/>&gt;</returns>
        public async Task<IAbuseContactInfoApiResponse> GetAbuseContactInfoAsync(Option<string> ip = default, Option<string> excludes = default, Option<string> fields = default, System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                ValidateGetAbuseContactInfo(ip, excludes, fields);

                FormatGetAbuseContactInfo(ref ip, ref excludes, ref fields);

                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress!.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = HttpClient.BaseAddress.AbsolutePath == "/"
                        ? "/abuse"
                        : string.Concat(HttpClient.BaseAddress.AbsolutePath, "/abuse");

                    System.Collections.Specialized.NameValueCollection parseQueryStringLocalVar = System.Web.HttpUtility.ParseQueryString(string.Empty);

                    if (ip.IsSet)
                        parseQueryStringLocalVar["ip"] = ClientUtils.ParameterToString(ip.Value);

                    if (excludes.IsSet)
                        parseQueryStringLocalVar["excludes"] = ClientUtils.ParameterToString(excludes.Value);

                    if (fields.IsSet)
                        parseQueryStringLocalVar["fields"] = ClientUtils.ParameterToString(fields.Value);

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

                    DateTime requestedAtLocalVar = DateTime.UtcNow;

                    using (HttpResponseMessage httpResponseMessageLocalVar = await HttpClient.SendAsync(httpRequestMessageLocalVar, cancellationToken).ConfigureAwait(false))
                    {
                        string responseContentLocalVar = await httpResponseMessageLocalVar.Content.ReadAsStringAsync().ConfigureAwait(false);

                        ILogger<AbuseContactInfoApiResponse> apiResponseLoggerLocalVar = LoggerFactory.CreateLogger<AbuseContactInfoApiResponse>();

                        AbuseContactInfoApiResponse apiResponseLocalVar = new AbuseContactInfoApiResponse(apiResponseLoggerLocalVar, httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, "/abuse", requestedAtLocalVar, _jsonSerializerOptions);

                        AfterGetAbuseContactInfoDefaultImplementation(apiResponseLocalVar, ip, excludes, fields);

                        Events.ExecuteOnGetAbuseContactInfo(apiResponseLocalVar);

                        if (apiResponseLocalVar.StatusCode == (HttpStatusCode) 429)
                            foreach(TokenBase tokenBaseLocalVar in tokenBaseLocalVars)
                                tokenBaseLocalVar.BeginRateLimit();

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorGetAbuseContactInfoDefaultImplementation(e, "/abuse", uriBuilderLocalVar.Path, ip, excludes, fields);
                Events.ExecuteOnErrorGetAbuseContactInfo(e);
                throw;
            }
        }

        /// <summary>
        /// The <see cref="AbuseContactInfoApiResponse"/>
        /// </summary>
        public partial class AbuseContactInfoApiResponse : IPGeolocation.Client.ApiResponse, IAbuseContactInfoApiResponse
        {
            /// <summary>
            /// The logger
            /// </summary>
            public ILogger<AbuseContactInfoApiResponse> Logger { get; }

            /// <summary>
            /// The <see cref="AbuseContactInfoApiResponse"/>
            /// </summary>
            /// <param name="logger"></param>
            /// <param name="httpRequestMessage"></param>
            /// <param name="httpResponseMessage"></param>
            /// <param name="rawContent"></param>
            /// <param name="path"></param>
            /// <param name="requestedAt"></param>
            /// <param name="jsonSerializerOptions"></param>
            public AbuseContactInfoApiResponse(ILogger<AbuseContactInfoApiResponse> logger, System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage, string rawContent, string path, DateTime requestedAt, System.Text.Json.JsonSerializerOptions jsonSerializerOptions) : base(httpRequestMessage, httpResponseMessage, rawContent, path, requestedAt, jsonSerializerOptions)
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
            public IPGeolocation.Model.AbuseResponse? Ok()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsOk
                    ? System.Text.Json.JsonSerializer.Deserialize<IPGeolocation.Model.AbuseResponse>(RawContent, _jsonSerializerOptions)
                    : default;
            }

            /// <summary>
            /// Returns true if the response is 200 Ok and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryOk(out IPGeolocation.Model.AbuseResponse? result)
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

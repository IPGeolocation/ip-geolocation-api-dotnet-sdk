

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
    public interface IAstronomyApi : IApi
    {
        /// <summary>
        /// The class containing the events
        /// </summary>
        AstronomyApiEvents Events { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// The Astronomy API provides the location-based rise and set times for the Sun and Moon along with the current position, distance from earth, and azimuth of the Sun and the Moon for a specific date at the queried time. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ip">query paramter &#39;ip&#39;. If not provided, will be your network IP (optional)</param>
        /// <param name="location">query paramter &#39;location&#39;. If not provided, will be your ip location (optional)</param>
        /// <param name="lat">query paramter &#39;lat&#39;. (optional)</param>
        /// <param name="varLong">query paramter &#39;long&#39;. (optional)</param>
        /// <param name="date">The date (YYYY-MM-DD) to lookup for. default will be the current date (optional)</param>
        /// <param name="elevation">query parameter &#39;elevation&#39; (optional)</param>
        /// <param name="output">Desired output format. (optional)</param>
        /// <param name="lang">By default, the API responds in English. You can change the response language by passing the language code as a query parameter &#x60;lang&#x60;. Multi language feature is available only for &#x60;paid users&#x60;. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IAstronomyDetailsApiResponse"/>&gt;</returns>
        Task<IAstronomyDetailsApiResponse> GetAstronomyDetailsAsync(Option<string> ip = default, Option<string> location = default, Option<string> lat = default, Option<string> varLong = default, Option<string> date = default, Option<double> elevation = default, Option<string> output = default, Option<string> lang = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// The Astronomy API provides the location-based rise and set times for the Sun and Moon along with the current position, distance from earth, and azimuth of the Sun and the Moon for a specific date at the queried time. 
        /// </remarks>
        /// <param name="ip">query paramter &#39;ip&#39;. If not provided, will be your network IP (optional)</param>
        /// <param name="location">query paramter &#39;location&#39;. If not provided, will be your ip location (optional)</param>
        /// <param name="lat">query paramter &#39;lat&#39;. (optional)</param>
        /// <param name="varLong">query paramter &#39;long&#39;. (optional)</param>
        /// <param name="date">The date (YYYY-MM-DD) to lookup for. default will be the current date (optional)</param>
        /// <param name="elevation">query parameter &#39;elevation&#39; (optional)</param>
        /// <param name="output">Desired output format. (optional)</param>
        /// <param name="lang">By default, the API responds in English. You can change the response language by passing the language code as a query parameter &#x60;lang&#x60;. Multi language feature is available only for &#x60;paid users&#x60;. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IAstronomyDetailsApiResponse"/>?&gt;</returns>
        Task<IAstronomyDetailsApiResponse?> GetAstronomyDetailsOrDefaultAsync(Option<string> ip = default, Option<string> location = default, Option<string> lat = default, Option<string> varLong = default, Option<string> date = default, Option<double> elevation = default, Option<string> output = default, Option<string> lang = default, System.Threading.CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The <see cref="IAstronomyDetailsApiResponse"/>
    /// </summary>
    public interface IAstronomyDetailsApiResponse : IPGeolocation.Client.IApiResponse, IOk<IPGeolocation.Model.AstronomyResponse?>, IBadRequest<IPGeolocation.Model.ErrorResponse?>, IUnauthorized<IPGeolocation.Model.ErrorResponse?>, IMethodNotAllowed<IPGeolocation.Model.ErrorResponse?>, ITooManyRequests<IPGeolocation.Model.ErrorResponse?>, ICustomHttpStatusCode499<IPGeolocation.Model.ErrorResponse?>, IInternalServerError<IPGeolocation.Model.ErrorResponse?>
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
    public class AstronomyApiEvents
    {
        /// <summary>
        /// The event raised after the server response
        /// </summary>
        public event EventHandler<ApiResponseEventArgs>? OnGetAstronomyDetails;

        /// <summary>
        /// The event raised after an error querying the server
        /// </summary>
        public event EventHandler<ExceptionEventArgs>? OnErrorGetAstronomyDetails;

        internal void ExecuteOnGetAstronomyDetails(AstronomyApi.AstronomyDetailsApiResponse apiResponse)
        {
            OnGetAstronomyDetails?.Invoke(this, new ApiResponseEventArgs(apiResponse));
        }

        internal void ExecuteOnErrorGetAstronomyDetails(Exception exception)
        {
            OnErrorGetAstronomyDetails?.Invoke(this, new ExceptionEventArgs(exception));
        }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public sealed partial class AstronomyApi : IAstronomyApi
    {
        private JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        /// The logger factory
        /// </summary>
        public ILoggerFactory LoggerFactory { get; }

        /// <summary>
        /// The logger
        /// </summary>
        public ILogger<AstronomyApi> Logger { get; }

        /// <summary>
        /// The HttpClient
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// The class containing the events
        /// </summary>
        public AstronomyApiEvents Events { get; }

        /// <summary>
        /// A token provider of type <see cref="ApiKeyProvider"/>
        /// </summary>
        public TokenProvider<ApiKeyToken> ApiKeyProvider { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AstronomyApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AstronomyApi(ILogger<AstronomyApi> logger, ILoggerFactory loggerFactory, HttpClient httpClient, JsonSerializerOptionsProvider jsonSerializerOptionsProvider, AstronomyApiEvents astronomyApiEvents,
            TokenProvider<ApiKeyToken> apiKeyProvider)
        {
            _jsonSerializerOptions = jsonSerializerOptionsProvider.Options;
            LoggerFactory = loggerFactory;
            Logger = LoggerFactory.CreateLogger<AstronomyApi>();
            HttpClient = httpClient;
            Events = astronomyApiEvents;
            ApiKeyProvider = apiKeyProvider;
        }

        partial void FormatGetAstronomyDetails(ref Option<string> ip, ref Option<string> location, ref Option<string> lat, ref Option<string> varLong, ref Option<string> date, ref Option<double> elevation, ref Option<string> output, ref Option<string> lang);

        /// <summary>
        /// Validates the request parameters
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="location"></param>
        /// <param name="lat"></param>
        /// <param name="varLong"></param>
        /// <param name="date"></param>
        /// <param name="output"></param>
        /// <param name="lang"></param>
        /// <returns></returns>
        private void ValidateGetAstronomyDetails(Option<string> ip, Option<string> location, Option<string> lat, Option<string> varLong, Option<string> date, Option<string> output, Option<string> lang)
        {
            if (ip.IsSet && ip.Value == null)
                throw new ArgumentNullException(nameof(ip));

            if (location.IsSet && location.Value == null)
                throw new ArgumentNullException(nameof(location));

            if (lat.IsSet && lat.Value == null)
                throw new ArgumentNullException(nameof(lat));

            if (varLong.IsSet && varLong.Value == null)
                throw new ArgumentNullException(nameof(varLong));

            if (date.IsSet && date.Value == null)
                throw new ArgumentNullException(nameof(date));

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
        /// <param name="location"></param>
        /// <param name="lat"></param>
        /// <param name="varLong"></param>
        /// <param name="date"></param>
        /// <param name="elevation"></param>
        /// <param name="output"></param>
        /// <param name="lang"></param>
        private void AfterGetAstronomyDetailsDefaultImplementation(IAstronomyDetailsApiResponse apiResponseLocalVar, Option<string> ip, Option<string> location, Option<string> lat, Option<string> varLong, Option<string> date, Option<double> elevation, Option<string> output, Option<string> lang)
        {
            bool suppressDefaultLog = false;
            AfterGetAstronomyDetails(ref suppressDefaultLog, apiResponseLocalVar, ip, location, lat, varLong, date, elevation, output, lang);
            if (!suppressDefaultLog)
                Logger.LogInformation("{0,-9} | {1} | {3}", (apiResponseLocalVar.DownloadedAt - apiResponseLocalVar.RequestedAt).TotalSeconds, apiResponseLocalVar.StatusCode, apiResponseLocalVar.Path);
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="ip"></param>
        /// <param name="location"></param>
        /// <param name="lat"></param>
        /// <param name="varLong"></param>
        /// <param name="date"></param>
        /// <param name="elevation"></param>
        /// <param name="output"></param>
        /// <param name="lang"></param>
        partial void AfterGetAstronomyDetails(ref bool suppressDefaultLog, IAstronomyDetailsApiResponse apiResponseLocalVar, Option<string> ip, Option<string> location, Option<string> lat, Option<string> varLong, Option<string> date, Option<double> elevation, Option<string> output, Option<string> lang);

        /// <summary>
        /// Logs exceptions that occur while retrieving the server response
        /// </summary>
        /// <param name="exceptionLocalVar"></param>
        /// <param name="pathFormatLocalVar"></param>
        /// <param name="pathLocalVar"></param>
        /// <param name="ip"></param>
        /// <param name="location"></param>
        /// <param name="lat"></param>
        /// <param name="varLong"></param>
        /// <param name="date"></param>
        /// <param name="elevation"></param>
        /// <param name="output"></param>
        /// <param name="lang"></param>
        private void OnErrorGetAstronomyDetailsDefaultImplementation(Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, Option<string> ip, Option<string> location, Option<string> lat, Option<string> varLong, Option<string> date, Option<double> elevation, Option<string> output, Option<string> lang)
        {
            bool suppressDefaultLogLocalVar = false;
            OnErrorGetAstronomyDetails(ref suppressDefaultLogLocalVar, exceptionLocalVar, pathFormatLocalVar, pathLocalVar, ip, location, lat, varLong, date, elevation, output, lang);
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
        /// <param name="location"></param>
        /// <param name="lat"></param>
        /// <param name="varLong"></param>
        /// <param name="date"></param>
        /// <param name="elevation"></param>
        /// <param name="output"></param>
        /// <param name="lang"></param>
        partial void OnErrorGetAstronomyDetails(ref bool suppressDefaultLogLocalVar, Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, Option<string> ip, Option<string> location, Option<string> lat, Option<string> varLong, Option<string> date, Option<double> elevation, Option<string> output, Option<string> lang);

        /// <summary>
        ///  The Astronomy API provides the location-based rise and set times for the Sun and Moon along with the current position, distance from earth, and azimuth of the Sun and the Moon for a specific date at the queried time. 
        /// </summary>
        /// <param name="ip">query paramter &#39;ip&#39;. If not provided, will be your network IP (optional)</param>
        /// <param name="location">query paramter &#39;location&#39;. If not provided, will be your ip location (optional)</param>
        /// <param name="lat">query paramter &#39;lat&#39;. (optional)</param>
        /// <param name="varLong">query paramter &#39;long&#39;. (optional)</param>
        /// <param name="date">The date (YYYY-MM-DD) to lookup for. default will be the current date (optional)</param>
        /// <param name="elevation">query parameter &#39;elevation&#39; (optional)</param>
        /// <param name="output">Desired output format. (optional)</param>
        /// <param name="lang">By default, the API responds in English. You can change the response language by passing the language code as a query parameter &#x60;lang&#x60;. Multi language feature is available only for &#x60;paid users&#x60;. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IAstronomyDetailsApiResponse"/>&gt;</returns>
        public async Task<IAstronomyDetailsApiResponse?> GetAstronomyDetailsOrDefaultAsync(Option<string> ip = default, Option<string> location = default, Option<string> lat = default, Option<string> varLong = default, Option<string> date = default, Option<double> elevation = default, Option<string> output = default, Option<string> lang = default, System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await GetAstronomyDetailsAsync(ip, location, lat, varLong, date, elevation, output, lang, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        ///  The Astronomy API provides the location-based rise and set times for the Sun and Moon along with the current position, distance from earth, and azimuth of the Sun and the Moon for a specific date at the queried time. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ip">query paramter &#39;ip&#39;. If not provided, will be your network IP (optional)</param>
        /// <param name="location">query paramter &#39;location&#39;. If not provided, will be your ip location (optional)</param>
        /// <param name="lat">query paramter &#39;lat&#39;. (optional)</param>
        /// <param name="varLong">query paramter &#39;long&#39;. (optional)</param>
        /// <param name="date">The date (YYYY-MM-DD) to lookup for. default will be the current date (optional)</param>
        /// <param name="elevation">query parameter &#39;elevation&#39; (optional)</param>
        /// <param name="output">Desired output format. (optional)</param>
        /// <param name="lang">By default, the API responds in English. You can change the response language by passing the language code as a query parameter &#x60;lang&#x60;. Multi language feature is available only for &#x60;paid users&#x60;. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IAstronomyDetailsApiResponse"/>&gt;</returns>
        public async Task<IAstronomyDetailsApiResponse> GetAstronomyDetailsAsync(Option<string> ip = default, Option<string> location = default, Option<string> lat = default, Option<string> varLong = default, Option<string> date = default, Option<double> elevation = default, Option<string> output = default, Option<string> lang = default, System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                ValidateGetAstronomyDetails(ip, location, lat, varLong, date, output, lang);

                FormatGetAstronomyDetails(ref ip, ref location, ref lat, ref varLong, ref date, ref elevation, ref output, ref lang);

                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress!.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = HttpClient.BaseAddress.AbsolutePath == "/"
                        ? "/astronomy"
                        : string.Concat(HttpClient.BaseAddress.AbsolutePath, "/astronomy");

                    System.Collections.Specialized.NameValueCollection parseQueryStringLocalVar = System.Web.HttpUtility.ParseQueryString(string.Empty);

                    if (ip.IsSet)
                        parseQueryStringLocalVar["ip"] = ClientUtils.ParameterToString(ip.Value);

                    if (location.IsSet)
                        parseQueryStringLocalVar["location"] = ClientUtils.ParameterToString(location.Value);

                    if (lat.IsSet)
                        parseQueryStringLocalVar["lat"] = ClientUtils.ParameterToString(lat.Value);

                    if (varLong.IsSet)
                        parseQueryStringLocalVar["long"] = ClientUtils.ParameterToString(varLong.Value);

                    if (date.IsSet)
                        parseQueryStringLocalVar["date"] = ClientUtils.ParameterToString(date.Value);

                    if (elevation.IsSet)
                        parseQueryStringLocalVar["elevation"] = ClientUtils.ParameterToString(elevation.Value);

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

                    DateTime requestedAtLocalVar = DateTime.UtcNow;

                    using (HttpResponseMessage httpResponseMessageLocalVar = await HttpClient.SendAsync(httpRequestMessageLocalVar, cancellationToken).ConfigureAwait(false))
                    {
                        string responseContentLocalVar = await httpResponseMessageLocalVar.Content.ReadAsStringAsync().ConfigureAwait(false);

                        ILogger<AstronomyDetailsApiResponse> apiResponseLoggerLocalVar = LoggerFactory.CreateLogger<AstronomyDetailsApiResponse>();

                        AstronomyDetailsApiResponse apiResponseLocalVar = new AstronomyDetailsApiResponse(apiResponseLoggerLocalVar, httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, "/astronomy", requestedAtLocalVar, _jsonSerializerOptions);

                        AfterGetAstronomyDetailsDefaultImplementation(apiResponseLocalVar, ip, location, lat, varLong, date, elevation, output, lang);

                        Events.ExecuteOnGetAstronomyDetails(apiResponseLocalVar);

                        if (apiResponseLocalVar.StatusCode == (HttpStatusCode) 429)
                            foreach(TokenBase tokenBaseLocalVar in tokenBaseLocalVars)
                                tokenBaseLocalVar.BeginRateLimit();

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorGetAstronomyDetailsDefaultImplementation(e, "/astronomy", uriBuilderLocalVar.Path, ip, location, lat, varLong, date, elevation, output, lang);
                Events.ExecuteOnErrorGetAstronomyDetails(e);
                throw;
            }
        }

        /// <summary>
        /// The <see cref="AstronomyDetailsApiResponse"/>
        /// </summary>
        public partial class AstronomyDetailsApiResponse : IPGeolocation.Client.ApiResponse, IAstronomyDetailsApiResponse
        {
            /// <summary>
            /// The logger
            /// </summary>
            public ILogger<AstronomyDetailsApiResponse> Logger { get; }

            /// <summary>
            /// The <see cref="AstronomyDetailsApiResponse"/>
            /// </summary>
            /// <param name="logger"></param>
            /// <param name="httpRequestMessage"></param>
            /// <param name="httpResponseMessage"></param>
            /// <param name="rawContent"></param>
            /// <param name="path"></param>
            /// <param name="requestedAt"></param>
            /// <param name="jsonSerializerOptions"></param>
            public AstronomyDetailsApiResponse(ILogger<AstronomyDetailsApiResponse> logger, System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage, string rawContent, string path, DateTime requestedAt, System.Text.Json.JsonSerializerOptions jsonSerializerOptions) : base(httpRequestMessage, httpResponseMessage, rawContent, path, requestedAt, jsonSerializerOptions)
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
            public IPGeolocation.Model.AstronomyResponse? Ok()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsOk
                    ? System.Text.Json.JsonSerializer.Deserialize<IPGeolocation.Model.AstronomyResponse>(RawContent, _jsonSerializerOptions)
                    : default;
            }

            /// <summary>
            /// Returns true if the response is 200 Ok and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryOk(out IPGeolocation.Model.AstronomyResponse? result)
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

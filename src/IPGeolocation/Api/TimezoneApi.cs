

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
    public interface ITimezoneApi : IApi
    {
        /// <summary>
        /// The class containing the events
        /// </summary>
        TimezoneApiEvents Events { get; }

        /// <summary>
        /// Timezone information details
        /// </summary>
        /// <remarks>
        /// The Time Zone API provides current time, date, and time zone-related information. It supports various input types including time zone name, geographic coordinates, addresses, IPs, and location codes.  The API determines the time zone based on the following priority order if multiple parameters are provided:   1. Time Zone Name   2. Geographic Coordinates (latitude &amp; longitude)   3. Location Address   4. IP Address   5. IATA Code   6. ICAO Code   7. UN/LOCODE  Enriched response data is returned based on the type of input: - IP: includes geolocation info - Address: includes location metadata - IATA/ICAO: includes airport info - UN/LOCODE: includes city details  You can call the time zone API without passing any time zone, coordinates, IATA, ICAO, LO code or IP address as well. It will use the calling machine&#39;s IP address to return the regional time zone information. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="tz">pass a valid time zone name as a query parameter tz to get the time zone information. (optional)</param>
        /// <param name="location">pass any address of a location as the query parameter location to get the time zone information. (optional)</param>
        /// <param name="lat">pass the latitude of a location as query parameters to get the time zone information. (optional)</param>
        /// <param name="varLong">pass the longitude of a location as query parameters to get the time zone information. (optional)</param>
        /// <param name="ip">You can pass any IPv4 or IPv6 address as a query parameter ip to get the regional timezone information. (optional)</param>
        /// <param name="iataCode">pass any 3 letter IATA code as a query paramter iata_code to get the comprehensive airport details along with the time zone information, in which that airport exists. (optional)</param>
        /// <param name="icaoCode">pass any 4 letter ICAO code as a query paramter icao_code to get the comprehensive airport details along with the time zone information, in which that airport exists. (optional)</param>
        /// <param name="loCode">pass any 5 letter UNLOCODE as a query paramter lo_code to get the comprehensive lo code/city details along with the time zone information of the concerned city. (optional)</param>
        /// <param name="output">Desired output format (json or xml). (optional)</param>
        /// <param name="lang">By default, the API responds in English. You can change the response language by passing the language code as a query parameter &#x60;lang&#x60;. Multi language feature is available only for &#x60;paid users&#x60;. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ITimezoneInfoApiResponse"/>&gt;</returns>
        Task<ITimezoneInfoApiResponse> GetTimezoneInfoAsync(Option<string> tz = default, Option<string> location = default, Option<float> lat = default, Option<float> varLong = default, Option<string> ip = default, Option<string> iataCode = default, Option<string> icaoCode = default, Option<string> loCode = default, Option<string> output = default, Option<string> lang = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Timezone information details
        /// </summary>
        /// <remarks>
        /// The Time Zone API provides current time, date, and time zone-related information. It supports various input types including time zone name, geographic coordinates, addresses, IPs, and location codes.  The API determines the time zone based on the following priority order if multiple parameters are provided:   1. Time Zone Name   2. Geographic Coordinates (latitude &amp; longitude)   3. Location Address   4. IP Address   5. IATA Code   6. ICAO Code   7. UN/LOCODE  Enriched response data is returned based on the type of input: - IP: includes geolocation info - Address: includes location metadata - IATA/ICAO: includes airport info - UN/LOCODE: includes city details  You can call the time zone API without passing any time zone, coordinates, IATA, ICAO, LO code or IP address as well. It will use the calling machine&#39;s IP address to return the regional time zone information. 
        /// </remarks>
        /// <param name="tz">pass a valid time zone name as a query parameter tz to get the time zone information. (optional)</param>
        /// <param name="location">pass any address of a location as the query parameter location to get the time zone information. (optional)</param>
        /// <param name="lat">pass the latitude of a location as query parameters to get the time zone information. (optional)</param>
        /// <param name="varLong">pass the longitude of a location as query parameters to get the time zone information. (optional)</param>
        /// <param name="ip">You can pass any IPv4 or IPv6 address as a query parameter ip to get the regional timezone information. (optional)</param>
        /// <param name="iataCode">pass any 3 letter IATA code as a query paramter iata_code to get the comprehensive airport details along with the time zone information, in which that airport exists. (optional)</param>
        /// <param name="icaoCode">pass any 4 letter ICAO code as a query paramter icao_code to get the comprehensive airport details along with the time zone information, in which that airport exists. (optional)</param>
        /// <param name="loCode">pass any 5 letter UNLOCODE as a query paramter lo_code to get the comprehensive lo code/city details along with the time zone information of the concerned city. (optional)</param>
        /// <param name="output">Desired output format (json or xml). (optional)</param>
        /// <param name="lang">By default, the API responds in English. You can change the response language by passing the language code as a query parameter &#x60;lang&#x60;. Multi language feature is available only for &#x60;paid users&#x60;. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ITimezoneInfoApiResponse"/>?&gt;</returns>
        Task<ITimezoneInfoApiResponse?> GetTimezoneInfoOrDefaultAsync(Option<string> tz = default, Option<string> location = default, Option<float> lat = default, Option<float> varLong = default, Option<string> ip = default, Option<string> iataCode = default, Option<string> icaoCode = default, Option<string> loCode = default, Option<string> output = default, Option<string> lang = default, System.Threading.CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The <see cref="ITimezoneInfoApiResponse"/>
    /// </summary>
    public interface ITimezoneInfoApiResponse : IPGeolocation.Client.IApiResponse, IOk<IPGeolocation.Model.TimeZoneDetailedResponse?>, IBadRequest<IPGeolocation.Model.ErrorResponse?>, IUnauthorized<IPGeolocation.Model.ErrorResponse?>, INotFound<IPGeolocation.Model.ErrorResponse?>, IMethodNotAllowed<IPGeolocation.Model.ErrorResponse?>, ITooManyRequests<IPGeolocation.Model.ErrorResponse?>, ICustomHttpStatusCode499<IPGeolocation.Model.ErrorResponse?>, IInternalServerError<IPGeolocation.Model.ErrorResponse?>
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
    public class TimezoneApiEvents
    {
        /// <summary>
        /// The event raised after the server response
        /// </summary>
        public event EventHandler<ApiResponseEventArgs>? OnGetTimezoneInfo;

        /// <summary>
        /// The event raised after an error querying the server
        /// </summary>
        public event EventHandler<ExceptionEventArgs>? OnErrorGetTimezoneInfo;

        internal void ExecuteOnGetTimezoneInfo(TimezoneApi.TimezoneInfoApiResponse apiResponse)
        {
            OnGetTimezoneInfo?.Invoke(this, new ApiResponseEventArgs(apiResponse));
        }

        internal void ExecuteOnErrorGetTimezoneInfo(Exception exception)
        {
            OnErrorGetTimezoneInfo?.Invoke(this, new ExceptionEventArgs(exception));
        }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public sealed partial class TimezoneApi : ITimezoneApi
    {
        private JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        /// The logger factory
        /// </summary>
        public ILoggerFactory LoggerFactory { get; }

        /// <summary>
        /// The logger
        /// </summary>
        public ILogger<TimezoneApi> Logger { get; }

        /// <summary>
        /// The HttpClient
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// The class containing the events
        /// </summary>
        public TimezoneApiEvents Events { get; }

        /// <summary>
        /// A token provider of type <see cref="ApiKeyProvider"/>
        /// </summary>
        public TokenProvider<ApiKeyToken> ApiKeyProvider { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimezoneApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TimezoneApi(ILogger<TimezoneApi> logger, ILoggerFactory loggerFactory, HttpClient httpClient, JsonSerializerOptionsProvider jsonSerializerOptionsProvider, TimezoneApiEvents timezoneApiEvents,
            TokenProvider<ApiKeyToken> apiKeyProvider)
        {
            _jsonSerializerOptions = jsonSerializerOptionsProvider.Options;
            LoggerFactory = loggerFactory;
            Logger = LoggerFactory.CreateLogger<TimezoneApi>();
            HttpClient = httpClient;
            Events = timezoneApiEvents;
            ApiKeyProvider = apiKeyProvider;
        }

        partial void FormatGetTimezoneInfo(ref Option<string> tz, ref Option<string> location, ref Option<float> lat, ref Option<float> varLong, ref Option<string> ip, ref Option<string> iataCode, ref Option<string> icaoCode, ref Option<string> loCode, ref Option<string> output, ref Option<string> lang);

        /// <summary>
        /// Validates the request parameters
        /// </summary>
        /// <param name="tz"></param>
        /// <param name="location"></param>
        /// <param name="ip"></param>
        /// <param name="iataCode"></param>
        /// <param name="icaoCode"></param>
        /// <param name="loCode"></param>
        /// <param name="output"></param>
        /// <param name="lang"></param>
        /// <returns></returns>
        private void ValidateGetTimezoneInfo(Option<string> tz, Option<string> location, Option<string> ip, Option<string> iataCode, Option<string> icaoCode, Option<string> loCode, Option<string> output, Option<string> lang)
        {
            if (tz.IsSet && tz.Value == null)
                throw new ArgumentNullException(nameof(tz));

            if (location.IsSet && location.Value == null)
                throw new ArgumentNullException(nameof(location));

            if (ip.IsSet && ip.Value == null)
                throw new ArgumentNullException(nameof(ip));

            if (iataCode.IsSet && iataCode.Value == null)
                throw new ArgumentNullException(nameof(iataCode));

            if (icaoCode.IsSet && icaoCode.Value == null)
                throw new ArgumentNullException(nameof(icaoCode));

            if (loCode.IsSet && loCode.Value == null)
                throw new ArgumentNullException(nameof(loCode));

            if (output.IsSet && output.Value == null)
                throw new ArgumentNullException(nameof(output));

            if (lang.IsSet && lang.Value == null)
                throw new ArgumentNullException(nameof(lang));
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="tz"></param>
        /// <param name="location"></param>
        /// <param name="lat"></param>
        /// <param name="varLong"></param>
        /// <param name="ip"></param>
        /// <param name="iataCode"></param>
        /// <param name="icaoCode"></param>
        /// <param name="loCode"></param>
        /// <param name="output"></param>
        /// <param name="lang"></param>
        private void AfterGetTimezoneInfoDefaultImplementation(ITimezoneInfoApiResponse apiResponseLocalVar, Option<string> tz, Option<string> location, Option<float> lat, Option<float> varLong, Option<string> ip, Option<string> iataCode, Option<string> icaoCode, Option<string> loCode, Option<string> output, Option<string> lang)
        {
            bool suppressDefaultLog = false;
            AfterGetTimezoneInfo(ref suppressDefaultLog, apiResponseLocalVar, tz, location, lat, varLong, ip, iataCode, icaoCode, loCode, output, lang);
            if (!suppressDefaultLog)
                Logger.LogInformation("{0,-9} | {1} | {3}", (apiResponseLocalVar.DownloadedAt - apiResponseLocalVar.RequestedAt).TotalSeconds, apiResponseLocalVar.StatusCode, apiResponseLocalVar.Path);
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="tz"></param>
        /// <param name="location"></param>
        /// <param name="lat"></param>
        /// <param name="varLong"></param>
        /// <param name="ip"></param>
        /// <param name="iataCode"></param>
        /// <param name="icaoCode"></param>
        /// <param name="loCode"></param>
        /// <param name="output"></param>
        /// <param name="lang"></param>
        partial void AfterGetTimezoneInfo(ref bool suppressDefaultLog, ITimezoneInfoApiResponse apiResponseLocalVar, Option<string> tz, Option<string> location, Option<float> lat, Option<float> varLong, Option<string> ip, Option<string> iataCode, Option<string> icaoCode, Option<string> loCode, Option<string> output, Option<string> lang);

        /// <summary>
        /// Logs exceptions that occur while retrieving the server response
        /// </summary>
        /// <param name="exceptionLocalVar"></param>
        /// <param name="pathFormatLocalVar"></param>
        /// <param name="pathLocalVar"></param>
        /// <param name="tz"></param>
        /// <param name="location"></param>
        /// <param name="lat"></param>
        /// <param name="varLong"></param>
        /// <param name="ip"></param>
        /// <param name="iataCode"></param>
        /// <param name="icaoCode"></param>
        /// <param name="loCode"></param>
        /// <param name="output"></param>
        /// <param name="lang"></param>
        private void OnErrorGetTimezoneInfoDefaultImplementation(Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, Option<string> tz, Option<string> location, Option<float> lat, Option<float> varLong, Option<string> ip, Option<string> iataCode, Option<string> icaoCode, Option<string> loCode, Option<string> output, Option<string> lang)
        {
            bool suppressDefaultLogLocalVar = false;
            OnErrorGetTimezoneInfo(ref suppressDefaultLogLocalVar, exceptionLocalVar, pathFormatLocalVar, pathLocalVar, tz, location, lat, varLong, ip, iataCode, icaoCode, loCode, output, lang);
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
        /// <param name="tz"></param>
        /// <param name="location"></param>
        /// <param name="lat"></param>
        /// <param name="varLong"></param>
        /// <param name="ip"></param>
        /// <param name="iataCode"></param>
        /// <param name="icaoCode"></param>
        /// <param name="loCode"></param>
        /// <param name="output"></param>
        /// <param name="lang"></param>
        partial void OnErrorGetTimezoneInfo(ref bool suppressDefaultLogLocalVar, Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, Option<string> tz, Option<string> location, Option<float> lat, Option<float> varLong, Option<string> ip, Option<string> iataCode, Option<string> icaoCode, Option<string> loCode, Option<string> output, Option<string> lang);

        /// <summary>
        /// Timezone information details The Time Zone API provides current time, date, and time zone-related information. It supports various input types including time zone name, geographic coordinates, addresses, IPs, and location codes.  The API determines the time zone based on the following priority order if multiple parameters are provided:   1. Time Zone Name   2. Geographic Coordinates (latitude &amp; longitude)   3. Location Address   4. IP Address   5. IATA Code   6. ICAO Code   7. UN/LOCODE  Enriched response data is returned based on the type of input: - IP: includes geolocation info - Address: includes location metadata - IATA/ICAO: includes airport info - UN/LOCODE: includes city details  You can call the time zone API without passing any time zone, coordinates, IATA, ICAO, LO code or IP address as well. It will use the calling machine&#39;s IP address to return the regional time zone information. 
        /// </summary>
        /// <param name="tz">pass a valid time zone name as a query parameter tz to get the time zone information. (optional)</param>
        /// <param name="location">pass any address of a location as the query parameter location to get the time zone information. (optional)</param>
        /// <param name="lat">pass the latitude of a location as query parameters to get the time zone information. (optional)</param>
        /// <param name="varLong">pass the longitude of a location as query parameters to get the time zone information. (optional)</param>
        /// <param name="ip">You can pass any IPv4 or IPv6 address as a query parameter ip to get the regional timezone information. (optional)</param>
        /// <param name="iataCode">pass any 3 letter IATA code as a query paramter iata_code to get the comprehensive airport details along with the time zone information, in which that airport exists. (optional)</param>
        /// <param name="icaoCode">pass any 4 letter ICAO code as a query paramter icao_code to get the comprehensive airport details along with the time zone information, in which that airport exists. (optional)</param>
        /// <param name="loCode">pass any 5 letter UNLOCODE as a query paramter lo_code to get the comprehensive lo code/city details along with the time zone information of the concerned city. (optional)</param>
        /// <param name="output">Desired output format (json or xml). (optional)</param>
        /// <param name="lang">By default, the API responds in English. You can change the response language by passing the language code as a query parameter &#x60;lang&#x60;. Multi language feature is available only for &#x60;paid users&#x60;. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ITimezoneInfoApiResponse"/>&gt;</returns>
        public async Task<ITimezoneInfoApiResponse?> GetTimezoneInfoOrDefaultAsync(Option<string> tz = default, Option<string> location = default, Option<float> lat = default, Option<float> varLong = default, Option<string> ip = default, Option<string> iataCode = default, Option<string> icaoCode = default, Option<string> loCode = default, Option<string> output = default, Option<string> lang = default, System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await GetTimezoneInfoAsync(tz, location, lat, varLong, ip, iataCode, icaoCode, loCode, output, lang, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Timezone information details The Time Zone API provides current time, date, and time zone-related information. It supports various input types including time zone name, geographic coordinates, addresses, IPs, and location codes.  The API determines the time zone based on the following priority order if multiple parameters are provided:   1. Time Zone Name   2. Geographic Coordinates (latitude &amp; longitude)   3. Location Address   4. IP Address   5. IATA Code   6. ICAO Code   7. UN/LOCODE  Enriched response data is returned based on the type of input: - IP: includes geolocation info - Address: includes location metadata - IATA/ICAO: includes airport info - UN/LOCODE: includes city details  You can call the time zone API without passing any time zone, coordinates, IATA, ICAO, LO code or IP address as well. It will use the calling machine&#39;s IP address to return the regional time zone information. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="tz">pass a valid time zone name as a query parameter tz to get the time zone information. (optional)</param>
        /// <param name="location">pass any address of a location as the query parameter location to get the time zone information. (optional)</param>
        /// <param name="lat">pass the latitude of a location as query parameters to get the time zone information. (optional)</param>
        /// <param name="varLong">pass the longitude of a location as query parameters to get the time zone information. (optional)</param>
        /// <param name="ip">You can pass any IPv4 or IPv6 address as a query parameter ip to get the regional timezone information. (optional)</param>
        /// <param name="iataCode">pass any 3 letter IATA code as a query paramter iata_code to get the comprehensive airport details along with the time zone information, in which that airport exists. (optional)</param>
        /// <param name="icaoCode">pass any 4 letter ICAO code as a query paramter icao_code to get the comprehensive airport details along with the time zone information, in which that airport exists. (optional)</param>
        /// <param name="loCode">pass any 5 letter UNLOCODE as a query paramter lo_code to get the comprehensive lo code/city details along with the time zone information of the concerned city. (optional)</param>
        /// <param name="output">Desired output format (json or xml). (optional)</param>
        /// <param name="lang">By default, the API responds in English. You can change the response language by passing the language code as a query parameter &#x60;lang&#x60;. Multi language feature is available only for &#x60;paid users&#x60;. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ITimezoneInfoApiResponse"/>&gt;</returns>
        public async Task<ITimezoneInfoApiResponse> GetTimezoneInfoAsync(Option<string> tz = default, Option<string> location = default, Option<float> lat = default, Option<float> varLong = default, Option<string> ip = default, Option<string> iataCode = default, Option<string> icaoCode = default, Option<string> loCode = default, Option<string> output = default, Option<string> lang = default, System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                ValidateGetTimezoneInfo(tz, location, ip, iataCode, icaoCode, loCode, output, lang);

                FormatGetTimezoneInfo(ref tz, ref location, ref lat, ref varLong, ref ip, ref iataCode, ref icaoCode, ref loCode, ref output, ref lang);

                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress!.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = HttpClient.BaseAddress.AbsolutePath == "/"
                        ? "/timezone"
                        : string.Concat(HttpClient.BaseAddress.AbsolutePath, "/timezone");

                    System.Collections.Specialized.NameValueCollection parseQueryStringLocalVar = System.Web.HttpUtility.ParseQueryString(string.Empty);

                    if (tz.IsSet)
                        parseQueryStringLocalVar["tz"] = ClientUtils.ParameterToString(tz.Value);

                    if (location.IsSet)
                        parseQueryStringLocalVar["location"] = ClientUtils.ParameterToString(location.Value);

                    if (lat.IsSet)
                        parseQueryStringLocalVar["lat"] = ClientUtils.ParameterToString(lat.Value);

                    if (varLong.IsSet)
                        parseQueryStringLocalVar["long"] = ClientUtils.ParameterToString(varLong.Value);

                    if (ip.IsSet)
                        parseQueryStringLocalVar["ip"] = ClientUtils.ParameterToString(ip.Value);

                    if (iataCode.IsSet)
                        parseQueryStringLocalVar["iata_code"] = ClientUtils.ParameterToString(iataCode.Value);

                    if (icaoCode.IsSet)
                        parseQueryStringLocalVar["icao_code"] = ClientUtils.ParameterToString(icaoCode.Value);

                    if (loCode.IsSet)
                        parseQueryStringLocalVar["lo_code"] = ClientUtils.ParameterToString(loCode.Value);

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

                        ILogger<TimezoneInfoApiResponse> apiResponseLoggerLocalVar = LoggerFactory.CreateLogger<TimezoneInfoApiResponse>();

                        TimezoneInfoApiResponse apiResponseLocalVar = new TimezoneInfoApiResponse(apiResponseLoggerLocalVar, httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, "/timezone", requestedAtLocalVar, _jsonSerializerOptions);

                        AfterGetTimezoneInfoDefaultImplementation(apiResponseLocalVar, tz, location, lat, varLong, ip, iataCode, icaoCode, loCode, output, lang);

                        Events.ExecuteOnGetTimezoneInfo(apiResponseLocalVar);

                        if (apiResponseLocalVar.StatusCode == (HttpStatusCode) 429)
                            foreach(TokenBase tokenBaseLocalVar in tokenBaseLocalVars)
                                tokenBaseLocalVar.BeginRateLimit();

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorGetTimezoneInfoDefaultImplementation(e, "/timezone", uriBuilderLocalVar.Path, tz, location, lat, varLong, ip, iataCode, icaoCode, loCode, output, lang);
                Events.ExecuteOnErrorGetTimezoneInfo(e);
                throw;
            }
        }

        /// <summary>
        /// The <see cref="TimezoneInfoApiResponse"/>
        /// </summary>
        public partial class TimezoneInfoApiResponse : IPGeolocation.Client.ApiResponse, ITimezoneInfoApiResponse
        {
            /// <summary>
            /// The logger
            /// </summary>
            public ILogger<TimezoneInfoApiResponse> Logger { get; }

            /// <summary>
            /// The <see cref="TimezoneInfoApiResponse"/>
            /// </summary>
            /// <param name="logger"></param>
            /// <param name="httpRequestMessage"></param>
            /// <param name="httpResponseMessage"></param>
            /// <param name="rawContent"></param>
            /// <param name="path"></param>
            /// <param name="requestedAt"></param>
            /// <param name="jsonSerializerOptions"></param>
            public TimezoneInfoApiResponse(ILogger<TimezoneInfoApiResponse> logger, System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage, string rawContent, string path, DateTime requestedAt, System.Text.Json.JsonSerializerOptions jsonSerializerOptions) : base(httpRequestMessage, httpResponseMessage, rawContent, path, requestedAt, jsonSerializerOptions)
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
            public IPGeolocation.Model.TimeZoneDetailedResponse? Ok()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsOk
                    ? System.Text.Json.JsonSerializer.Deserialize<IPGeolocation.Model.TimeZoneDetailedResponse>(RawContent, _jsonSerializerOptions)
                    : default;
            }

            /// <summary>
            /// Returns true if the response is 200 Ok and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryOk(out IPGeolocation.Model.TimeZoneDetailedResponse? result)
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

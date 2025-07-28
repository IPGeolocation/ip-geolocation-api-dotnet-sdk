

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
    public interface ITimeConversionApi : IApi
    {
        /// <summary>
        /// The class containing the events
        /// </summary>
        TimeConversionApiEvents Events { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// You can convert a timestamp provided as a query paramter time from one time zone to another time zone.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="time">time parameter takes the input in the following two formats: i) &#39;yyyy-MM-dd HH:mm&#39;, and ii) &#39;yyyy-MM-dd HH:mm:ss&#39;. This parameter is optional and you can omit it to convert the current time between two coordinates, time zones or locations. (optional)</param>
        /// <param name="tzFrom">timezone to convert from (optional)</param>
        /// <param name="tzTo">timezone to convert to (optional)</param>
        /// <param name="latFrom">latitude to convert from (optional)</param>
        /// <param name="longFrom">longitude to convert from (optional)</param>
        /// <param name="latTo">latitude to convert to (optional)</param>
        /// <param name="longTo">longitude to convert to (optional)</param>
        /// <param name="locationFrom">location to convert from (optional)</param>
        /// <param name="locationTo">location to convert to (optional)</param>
        /// <param name="icaoFrom">location to convert from (optional)</param>
        /// <param name="icaoTo">location to convert to (optional)</param>
        /// <param name="iataFrom">location to convert from (optional)</param>
        /// <param name="iataTo">location to convert to (optional)</param>
        /// <param name="locodeFrom">location to convert from (optional)</param>
        /// <param name="locodeTo">location to convert to (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ITimeConversionApiResponse"/>&gt;</returns>
        Task<ITimeConversionApiResponse> ConvertTimeBetweenTimezonesAsync(Option<string> time = default, Option<string> tzFrom = default, Option<string> tzTo = default, Option<float> latFrom = default, Option<float> longFrom = default, Option<float> latTo = default, Option<float> longTo = default, Option<string> locationFrom = default, Option<string> locationTo = default, Option<string> icaoFrom = default, Option<string> icaoTo = default, Option<string> iataFrom = default, Option<string> iataTo = default, Option<string> locodeFrom = default, Option<string> locodeTo = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// You can convert a timestamp provided as a query paramter time from one time zone to another time zone.
        /// </remarks>
        /// <param name="time">time parameter takes the input in the following two formats: i) &#39;yyyy-MM-dd HH:mm&#39;, and ii) &#39;yyyy-MM-dd HH:mm:ss&#39;. This parameter is optional and you can omit it to convert the current time between two coordinates, time zones or locations. (optional)</param>
        /// <param name="tzFrom">timezone to convert from (optional)</param>
        /// <param name="tzTo">timezone to convert to (optional)</param>
        /// <param name="latFrom">latitude to convert from (optional)</param>
        /// <param name="longFrom">longitude to convert from (optional)</param>
        /// <param name="latTo">latitude to convert to (optional)</param>
        /// <param name="longTo">longitude to convert to (optional)</param>
        /// <param name="locationFrom">location to convert from (optional)</param>
        /// <param name="locationTo">location to convert to (optional)</param>
        /// <param name="icaoFrom">location to convert from (optional)</param>
        /// <param name="icaoTo">location to convert to (optional)</param>
        /// <param name="iataFrom">location to convert from (optional)</param>
        /// <param name="iataTo">location to convert to (optional)</param>
        /// <param name="locodeFrom">location to convert from (optional)</param>
        /// <param name="locodeTo">location to convert to (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ITimeConversionApiResponse"/>?&gt;</returns>
        Task<ITimeConversionApiResponse?> ConvertTimeBetweenTimezonesOrDefaultAsync(Option<string> time = default, Option<string> tzFrom = default, Option<string> tzTo = default, Option<float> latFrom = default, Option<float> longFrom = default, Option<float> latTo = default, Option<float> longTo = default, Option<string> locationFrom = default, Option<string> locationTo = default, Option<string> icaoFrom = default, Option<string> icaoTo = default, Option<string> iataFrom = default, Option<string> iataTo = default, Option<string> locodeFrom = default, Option<string> locodeTo = default, System.Threading.CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The <see cref="ITimeConversionApiResponse"/>
    /// </summary>
    public interface ITimeConversionApiResponse : IPGeolocation.Client.IApiResponse, IOk<IPGeolocation.Model.TimeConversionResponse?>, IBadRequest<IPGeolocation.Model.ErrorResponse?>, IUnauthorized<IPGeolocation.Model.ErrorResponse?>, INotFound<IPGeolocation.Model.ErrorResponse?>, IMethodNotAllowed<IPGeolocation.Model.ErrorResponse?>, ITooManyRequests<IPGeolocation.Model.ErrorResponse?>, ICustomHttpStatusCode499<IPGeolocation.Model.ErrorResponse?>, IInternalServerError<IPGeolocation.Model.ErrorResponse?>
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
    public class TimeConversionApiEvents
    {
        /// <summary>
        /// The event raised after the server response
        /// </summary>
        public event EventHandler<ApiResponseEventArgs>? OnConvertTimeBetweenTimezones;

        /// <summary>
        /// The event raised after an error querying the server
        /// </summary>
        public event EventHandler<ExceptionEventArgs>? OnErrorConvertTimeBetweenTimezones;

        internal void ExecuteOnConvertTimeBetweenTimezones(TimeConversionApi.TimeConversionApiResponse apiResponse)
        {
            OnConvertTimeBetweenTimezones?.Invoke(this, new ApiResponseEventArgs(apiResponse));
        }

        internal void ExecuteOnErrorConvertTimeBetweenTimezones(Exception exception)
        {
            OnErrorConvertTimeBetweenTimezones?.Invoke(this, new ExceptionEventArgs(exception));
        }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public sealed partial class TimeConversionApi : ITimeConversionApi
    {
        private JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        /// The logger factory
        /// </summary>
        public ILoggerFactory LoggerFactory { get; }

        /// <summary>
        /// The logger
        /// </summary>
        public ILogger<TimeConversionApi> Logger { get; }

        /// <summary>
        /// The HttpClient
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// The class containing the events
        /// </summary>
        public TimeConversionApiEvents Events { get; }

        /// <summary>
        /// A token provider of type <see cref="ApiKeyProvider"/>
        /// </summary>
        public TokenProvider<ApiKeyToken> ApiKeyProvider { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeConversionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TimeConversionApi(ILogger<TimeConversionApi> logger, ILoggerFactory loggerFactory, HttpClient httpClient, JsonSerializerOptionsProvider jsonSerializerOptionsProvider, TimeConversionApiEvents timeConversionApiEvents,
            TokenProvider<ApiKeyToken> apiKeyProvider)
        {
            _jsonSerializerOptions = jsonSerializerOptionsProvider.Options;
            LoggerFactory = loggerFactory;
            Logger = LoggerFactory.CreateLogger<TimeConversionApi>();
            HttpClient = httpClient;
            Events = timeConversionApiEvents;
            ApiKeyProvider = apiKeyProvider;
        }

        partial void FormatConvertTimeBetweenTimezones(ref Option<string> time, ref Option<string> tzFrom, ref Option<string> tzTo, ref Option<float> latFrom, ref Option<float> longFrom, ref Option<float> latTo, ref Option<float> longTo, ref Option<string> locationFrom, ref Option<string> locationTo, ref Option<string> icaoFrom, ref Option<string> icaoTo, ref Option<string> iataFrom, ref Option<string> iataTo, ref Option<string> locodeFrom, ref Option<string> locodeTo);

        /// <summary>
        /// Validates the request parameters
        /// </summary>
        /// <param name="time"></param>
        /// <param name="tzFrom"></param>
        /// <param name="tzTo"></param>
        /// <param name="locationFrom"></param>
        /// <param name="locationTo"></param>
        /// <param name="icaoFrom"></param>
        /// <param name="icaoTo"></param>
        /// <param name="iataFrom"></param>
        /// <param name="iataTo"></param>
        /// <param name="locodeFrom"></param>
        /// <param name="locodeTo"></param>
        /// <returns></returns>
        private void ValidateConvertTimeBetweenTimezones(Option<string> time, Option<string> tzFrom, Option<string> tzTo, Option<string> locationFrom, Option<string> locationTo, Option<string> icaoFrom, Option<string> icaoTo, Option<string> iataFrom, Option<string> iataTo, Option<string> locodeFrom, Option<string> locodeTo)
        {
            if (time.IsSet && time.Value == null)
                throw new ArgumentNullException(nameof(time));

            if (tzFrom.IsSet && tzFrom.Value == null)
                throw new ArgumentNullException(nameof(tzFrom));

            if (tzTo.IsSet && tzTo.Value == null)
                throw new ArgumentNullException(nameof(tzTo));

            if (locationFrom.IsSet && locationFrom.Value == null)
                throw new ArgumentNullException(nameof(locationFrom));

            if (locationTo.IsSet && locationTo.Value == null)
                throw new ArgumentNullException(nameof(locationTo));

            if (icaoFrom.IsSet && icaoFrom.Value == null)
                throw new ArgumentNullException(nameof(icaoFrom));

            if (icaoTo.IsSet && icaoTo.Value == null)
                throw new ArgumentNullException(nameof(icaoTo));

            if (iataFrom.IsSet && iataFrom.Value == null)
                throw new ArgumentNullException(nameof(iataFrom));

            if (iataTo.IsSet && iataTo.Value == null)
                throw new ArgumentNullException(nameof(iataTo));

            if (locodeFrom.IsSet && locodeFrom.Value == null)
                throw new ArgumentNullException(nameof(locodeFrom));

            if (locodeTo.IsSet && locodeTo.Value == null)
                throw new ArgumentNullException(nameof(locodeTo));
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="time"></param>
        /// <param name="tzFrom"></param>
        /// <param name="tzTo"></param>
        /// <param name="latFrom"></param>
        /// <param name="longFrom"></param>
        /// <param name="latTo"></param>
        /// <param name="longTo"></param>
        /// <param name="locationFrom"></param>
        /// <param name="locationTo"></param>
        /// <param name="icaoFrom"></param>
        /// <param name="icaoTo"></param>
        /// <param name="iataFrom"></param>
        /// <param name="iataTo"></param>
        /// <param name="locodeFrom"></param>
        /// <param name="locodeTo"></param>
        private void AfterConvertTimeBetweenTimezonesDefaultImplementation(ITimeConversionApiResponse apiResponseLocalVar, Option<string> time, Option<string> tzFrom, Option<string> tzTo, Option<float> latFrom, Option<float> longFrom, Option<float> latTo, Option<float> longTo, Option<string> locationFrom, Option<string> locationTo, Option<string> icaoFrom, Option<string> icaoTo, Option<string> iataFrom, Option<string> iataTo, Option<string> locodeFrom, Option<string> locodeTo)
        {
            bool suppressDefaultLog = false;
            AfterConvertTimeBetweenTimezones(ref suppressDefaultLog, apiResponseLocalVar, time, tzFrom, tzTo, latFrom, longFrom, latTo, longTo, locationFrom, locationTo, icaoFrom, icaoTo, iataFrom, iataTo, locodeFrom, locodeTo);
            if (!suppressDefaultLog)
                Logger.LogInformation("{0,-9} | {1} | {3}", (apiResponseLocalVar.DownloadedAt - apiResponseLocalVar.RequestedAt).TotalSeconds, apiResponseLocalVar.StatusCode, apiResponseLocalVar.Path);
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="time"></param>
        /// <param name="tzFrom"></param>
        /// <param name="tzTo"></param>
        /// <param name="latFrom"></param>
        /// <param name="longFrom"></param>
        /// <param name="latTo"></param>
        /// <param name="longTo"></param>
        /// <param name="locationFrom"></param>
        /// <param name="locationTo"></param>
        /// <param name="icaoFrom"></param>
        /// <param name="icaoTo"></param>
        /// <param name="iataFrom"></param>
        /// <param name="iataTo"></param>
        /// <param name="locodeFrom"></param>
        /// <param name="locodeTo"></param>
        partial void AfterConvertTimeBetweenTimezones(ref bool suppressDefaultLog, ITimeConversionApiResponse apiResponseLocalVar, Option<string> time, Option<string> tzFrom, Option<string> tzTo, Option<float> latFrom, Option<float> longFrom, Option<float> latTo, Option<float> longTo, Option<string> locationFrom, Option<string> locationTo, Option<string> icaoFrom, Option<string> icaoTo, Option<string> iataFrom, Option<string> iataTo, Option<string> locodeFrom, Option<string> locodeTo);

        /// <summary>
        /// Logs exceptions that occur while retrieving the server response
        /// </summary>
        /// <param name="exceptionLocalVar"></param>
        /// <param name="pathFormatLocalVar"></param>
        /// <param name="pathLocalVar"></param>
        /// <param name="time"></param>
        /// <param name="tzFrom"></param>
        /// <param name="tzTo"></param>
        /// <param name="latFrom"></param>
        /// <param name="longFrom"></param>
        /// <param name="latTo"></param>
        /// <param name="longTo"></param>
        /// <param name="locationFrom"></param>
        /// <param name="locationTo"></param>
        /// <param name="icaoFrom"></param>
        /// <param name="icaoTo"></param>
        /// <param name="iataFrom"></param>
        /// <param name="iataTo"></param>
        /// <param name="locodeFrom"></param>
        /// <param name="locodeTo"></param>
        private void OnErrorConvertTimeBetweenTimezonesDefaultImplementation(Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, Option<string> time, Option<string> tzFrom, Option<string> tzTo, Option<float> latFrom, Option<float> longFrom, Option<float> latTo, Option<float> longTo, Option<string> locationFrom, Option<string> locationTo, Option<string> icaoFrom, Option<string> icaoTo, Option<string> iataFrom, Option<string> iataTo, Option<string> locodeFrom, Option<string> locodeTo)
        {
            bool suppressDefaultLogLocalVar = false;
            OnErrorConvertTimeBetweenTimezones(ref suppressDefaultLogLocalVar, exceptionLocalVar, pathFormatLocalVar, pathLocalVar, time, tzFrom, tzTo, latFrom, longFrom, latTo, longTo, locationFrom, locationTo, icaoFrom, icaoTo, iataFrom, iataTo, locodeFrom, locodeTo);
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
        /// <param name="time"></param>
        /// <param name="tzFrom"></param>
        /// <param name="tzTo"></param>
        /// <param name="latFrom"></param>
        /// <param name="longFrom"></param>
        /// <param name="latTo"></param>
        /// <param name="longTo"></param>
        /// <param name="locationFrom"></param>
        /// <param name="locationTo"></param>
        /// <param name="icaoFrom"></param>
        /// <param name="icaoTo"></param>
        /// <param name="iataFrom"></param>
        /// <param name="iataTo"></param>
        /// <param name="locodeFrom"></param>
        /// <param name="locodeTo"></param>
        partial void OnErrorConvertTimeBetweenTimezones(ref bool suppressDefaultLogLocalVar, Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, Option<string> time, Option<string> tzFrom, Option<string> tzTo, Option<float> latFrom, Option<float> longFrom, Option<float> latTo, Option<float> longTo, Option<string> locationFrom, Option<string> locationTo, Option<string> icaoFrom, Option<string> icaoTo, Option<string> iataFrom, Option<string> iataTo, Option<string> locodeFrom, Option<string> locodeTo);

        /// <summary>
        ///  You can convert a timestamp provided as a query paramter time from one time zone to another time zone.
        /// </summary>
        /// <param name="time">time parameter takes the input in the following two formats: i) &#39;yyyy-MM-dd HH:mm&#39;, and ii) &#39;yyyy-MM-dd HH:mm:ss&#39;. This parameter is optional and you can omit it to convert the current time between two coordinates, time zones or locations. (optional)</param>
        /// <param name="tzFrom">timezone to convert from (optional)</param>
        /// <param name="tzTo">timezone to convert to (optional)</param>
        /// <param name="latFrom">latitude to convert from (optional)</param>
        /// <param name="longFrom">longitude to convert from (optional)</param>
        /// <param name="latTo">latitude to convert to (optional)</param>
        /// <param name="longTo">longitude to convert to (optional)</param>
        /// <param name="locationFrom">location to convert from (optional)</param>
        /// <param name="locationTo">location to convert to (optional)</param>
        /// <param name="icaoFrom">location to convert from (optional)</param>
        /// <param name="icaoTo">location to convert to (optional)</param>
        /// <param name="iataFrom">location to convert from (optional)</param>
        /// <param name="iataTo">location to convert to (optional)</param>
        /// <param name="locodeFrom">location to convert from (optional)</param>
        /// <param name="locodeTo">location to convert to (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ITimeConversionApiResponse"/>&gt;</returns>
        public async Task<ITimeConversionApiResponse?> ConvertTimeBetweenTimezonesOrDefaultAsync(Option<string> time = default, Option<string> tzFrom = default, Option<string> tzTo = default, Option<float> latFrom = default, Option<float> longFrom = default, Option<float> latTo = default, Option<float> longTo = default, Option<string> locationFrom = default, Option<string> locationTo = default, Option<string> icaoFrom = default, Option<string> icaoTo = default, Option<string> iataFrom = default, Option<string> iataTo = default, Option<string> locodeFrom = default, Option<string> locodeTo = default, System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await ConvertTimeBetweenTimezonesAsync(time, tzFrom, tzTo, latFrom, longFrom, latTo, longTo, locationFrom, locationTo, icaoFrom, icaoTo, iataFrom, iataTo, locodeFrom, locodeTo, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        ///  You can convert a timestamp provided as a query paramter time from one time zone to another time zone.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="time">time parameter takes the input in the following two formats: i) &#39;yyyy-MM-dd HH:mm&#39;, and ii) &#39;yyyy-MM-dd HH:mm:ss&#39;. This parameter is optional and you can omit it to convert the current time between two coordinates, time zones or locations. (optional)</param>
        /// <param name="tzFrom">timezone to convert from (optional)</param>
        /// <param name="tzTo">timezone to convert to (optional)</param>
        /// <param name="latFrom">latitude to convert from (optional)</param>
        /// <param name="longFrom">longitude to convert from (optional)</param>
        /// <param name="latTo">latitude to convert to (optional)</param>
        /// <param name="longTo">longitude to convert to (optional)</param>
        /// <param name="locationFrom">location to convert from (optional)</param>
        /// <param name="locationTo">location to convert to (optional)</param>
        /// <param name="icaoFrom">location to convert from (optional)</param>
        /// <param name="icaoTo">location to convert to (optional)</param>
        /// <param name="iataFrom">location to convert from (optional)</param>
        /// <param name="iataTo">location to convert to (optional)</param>
        /// <param name="locodeFrom">location to convert from (optional)</param>
        /// <param name="locodeTo">location to convert to (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ITimeConversionApiResponse"/>&gt;</returns>
        public async Task<ITimeConversionApiResponse> ConvertTimeBetweenTimezonesAsync(Option<string> time = default, Option<string> tzFrom = default, Option<string> tzTo = default, Option<float> latFrom = default, Option<float> longFrom = default, Option<float> latTo = default, Option<float> longTo = default, Option<string> locationFrom = default, Option<string> locationTo = default, Option<string> icaoFrom = default, Option<string> icaoTo = default, Option<string> iataFrom = default, Option<string> iataTo = default, Option<string> locodeFrom = default, Option<string> locodeTo = default, System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                ValidateConvertTimeBetweenTimezones(time, tzFrom, tzTo, locationFrom, locationTo, icaoFrom, icaoTo, iataFrom, iataTo, locodeFrom, locodeTo);

                FormatConvertTimeBetweenTimezones(ref time, ref tzFrom, ref tzTo, ref latFrom, ref longFrom, ref latTo, ref longTo, ref locationFrom, ref locationTo, ref icaoFrom, ref icaoTo, ref iataFrom, ref iataTo, ref locodeFrom, ref locodeTo);

                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress!.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = HttpClient.BaseAddress.AbsolutePath == "/"
                        ? "/timezone/convert"
                        : string.Concat(HttpClient.BaseAddress.AbsolutePath, "/timezone/convert");

                    System.Collections.Specialized.NameValueCollection parseQueryStringLocalVar = System.Web.HttpUtility.ParseQueryString(string.Empty);

                    if (time.IsSet)
                        parseQueryStringLocalVar["time"] = ClientUtils.ParameterToString(time.Value);

                    if (tzFrom.IsSet)
                        parseQueryStringLocalVar["tz_from"] = ClientUtils.ParameterToString(tzFrom.Value);

                    if (tzTo.IsSet)
                        parseQueryStringLocalVar["tz_to"] = ClientUtils.ParameterToString(tzTo.Value);

                    if (latFrom.IsSet)
                        parseQueryStringLocalVar["lat_from"] = ClientUtils.ParameterToString(latFrom.Value);

                    if (longFrom.IsSet)
                        parseQueryStringLocalVar["long_from"] = ClientUtils.ParameterToString(longFrom.Value);

                    if (latTo.IsSet)
                        parseQueryStringLocalVar["lat_to"] = ClientUtils.ParameterToString(latTo.Value);

                    if (longTo.IsSet)
                        parseQueryStringLocalVar["long_to"] = ClientUtils.ParameterToString(longTo.Value);

                    if (locationFrom.IsSet)
                        parseQueryStringLocalVar["location_from"] = ClientUtils.ParameterToString(locationFrom.Value);

                    if (locationTo.IsSet)
                        parseQueryStringLocalVar["location_to"] = ClientUtils.ParameterToString(locationTo.Value);

                    if (icaoFrom.IsSet)
                        parseQueryStringLocalVar["icao_from"] = ClientUtils.ParameterToString(icaoFrom.Value);

                    if (icaoTo.IsSet)
                        parseQueryStringLocalVar["icao_to"] = ClientUtils.ParameterToString(icaoTo.Value);

                    if (iataFrom.IsSet)
                        parseQueryStringLocalVar["iata_from"] = ClientUtils.ParameterToString(iataFrom.Value);

                    if (iataTo.IsSet)
                        parseQueryStringLocalVar["iata_to"] = ClientUtils.ParameterToString(iataTo.Value);

                    if (locodeFrom.IsSet)
                        parseQueryStringLocalVar["locode_from"] = ClientUtils.ParameterToString(locodeFrom.Value);

                    if (locodeTo.IsSet)
                        parseQueryStringLocalVar["locode_to"] = ClientUtils.ParameterToString(locodeTo.Value);

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

                        ILogger<TimeConversionApiResponse> apiResponseLoggerLocalVar = LoggerFactory.CreateLogger<TimeConversionApiResponse>();

                        TimeConversionApiResponse apiResponseLocalVar = new TimeConversionApiResponse(apiResponseLoggerLocalVar, httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, "/timezone/convert", requestedAtLocalVar, _jsonSerializerOptions);

                        AfterConvertTimeBetweenTimezonesDefaultImplementation(apiResponseLocalVar, time, tzFrom, tzTo, latFrom, longFrom, latTo, longTo, locationFrom, locationTo, icaoFrom, icaoTo, iataFrom, iataTo, locodeFrom, locodeTo);

                        Events.ExecuteOnConvertTimeBetweenTimezones(apiResponseLocalVar);

                        if (apiResponseLocalVar.StatusCode == (HttpStatusCode) 429)
                            foreach(TokenBase tokenBaseLocalVar in tokenBaseLocalVars)
                                tokenBaseLocalVar.BeginRateLimit();

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorConvertTimeBetweenTimezonesDefaultImplementation(e, "/timezone/convert", uriBuilderLocalVar.Path, time, tzFrom, tzTo, latFrom, longFrom, latTo, longTo, locationFrom, locationTo, icaoFrom, icaoTo, iataFrom, iataTo, locodeFrom, locodeTo);
                Events.ExecuteOnErrorConvertTimeBetweenTimezones(e);
                throw;
            }
        }

        /// <summary>
        /// The <see cref="TimeConversionApiResponse"/>
        /// </summary>
        public partial class TimeConversionApiResponse : IPGeolocation.Client.ApiResponse, ITimeConversionApiResponse
        {
            /// <summary>
            /// The logger
            /// </summary>
            public ILogger<TimeConversionApiResponse> Logger { get; }

            /// <summary>
            /// The <see cref="TimeConversionApiResponse"/>
            /// </summary>
            /// <param name="logger"></param>
            /// <param name="httpRequestMessage"></param>
            /// <param name="httpResponseMessage"></param>
            /// <param name="rawContent"></param>
            /// <param name="path"></param>
            /// <param name="requestedAt"></param>
            /// <param name="jsonSerializerOptions"></param>
            public TimeConversionApiResponse(ILogger<TimeConversionApiResponse> logger, System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage, string rawContent, string path, DateTime requestedAt, System.Text.Json.JsonSerializerOptions jsonSerializerOptions) : base(httpRequestMessage, httpResponseMessage, rawContent, path, requestedAt, jsonSerializerOptions)
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
            public IPGeolocation.Model.TimeConversionResponse? Ok()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsOk
                    ? System.Text.Json.JsonSerializer.Deserialize<IPGeolocation.Model.TimeConversionResponse>(RawContent, _jsonSerializerOptions)
                    : default;
            }

            /// <summary>
            /// Returns true if the response is 200 Ok and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryOk(out IPGeolocation.Model.TimeConversionResponse? result)
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

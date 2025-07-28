/*
 * IPGeolocation.io - IP intelligence products
 *
 * Ipgeolocation provides a set of APIs to make ip based decisions.
 *
 */

#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using IPGeolocation.Api;
using IPGeolocation.Model;

namespace IPGeolocation.Client
{
    /// <summary>
    /// Provides hosting configuration for IPGeolocation
    /// </summary>
    public class HostConfiguration
    {
        private readonly IServiceCollection _services;
        private readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions();

        internal bool HttpClientsAdded { get; private set; }

        /// <summary>
        /// Instantiates the class 
        /// </summary>
        /// <param name="services"></param>
        public HostConfiguration(IServiceCollection services)
        {
            _services = services;
            _jsonOptions.Converters.Add(new JsonStringEnumConverter());
            _jsonOptions.Converters.Add(new DateTimeJsonConverter());
            _jsonOptions.Converters.Add(new DateTimeNullableJsonConverter());
            _jsonOptions.Converters.Add(new ASNConnectionJsonConverter());
            _jsonOptions.Converters.Add(new ASNResponseJsonConverter());
            _jsonOptions.Converters.Add(new ASNResponseAsnJsonConverter());
            _jsonOptions.Converters.Add(new ASNResponseXMLJsonConverter());
            _jsonOptions.Converters.Add(new ASNResponseXMLAsnJsonConverter());
            _jsonOptions.Converters.Add(new AbuseJsonConverter());
            _jsonOptions.Converters.Add(new AbuseResponseJsonConverter());
            _jsonOptions.Converters.Add(new AbuseResponseXMLJsonConverter());
            _jsonOptions.Converters.Add(new AstronomyJsonConverter());
            _jsonOptions.Converters.Add(new AstronomyEveningJsonConverter());
            _jsonOptions.Converters.Add(new AstronomyLocationJsonConverter());
            _jsonOptions.Converters.Add(new AstronomyMorningJsonConverter());
            _jsonOptions.Converters.Add(new AstronomyResponseJsonConverter());
            _jsonOptions.Converters.Add(new AstronomyXMLResponseJsonConverter());
            _jsonOptions.Converters.Add(new CountryMetadataJsonConverter());
            _jsonOptions.Converters.Add(new CurrencyJsonConverter());
            _jsonOptions.Converters.Add(new ErrorResponseJsonConverter());
            _jsonOptions.Converters.Add(new ErrorXMLResponseJsonConverter());
            _jsonOptions.Converters.Add(new ErrorXMLResponseArrayJsonConverter());
            _jsonOptions.Converters.Add(new GeolocationResponseJsonConverter());
            _jsonOptions.Converters.Add(new GeolocationXMLResponseJsonConverter());
            _jsonOptions.Converters.Add(new GeolocationXMLResponseArrayJsonConverter());
            _jsonOptions.Converters.Add(new BulkGeolocationResponseJsonConverter());
            _jsonOptions.Converters.Add(new BulkGeolocationResponse1JsonConverter());
            _jsonOptions.Converters.Add(new BulkIPRequestJsonConverter());
            _jsonOptions.Converters.Add(new BulkIPSecurityResponseJsonConverter());
            _jsonOptions.Converters.Add(new BulkIPSecurityResponse1JsonConverter());
            _jsonOptions.Converters.Add(new LocationJsonConverter());
            _jsonOptions.Converters.Add(new LocationMinimalJsonConverter());
            _jsonOptions.Converters.Add(new ModelTimeZoneJsonConverter());
            _jsonOptions.Converters.Add(new NetworkJsonConverter());
            _jsonOptions.Converters.Add(new NetworkAsnJsonConverter());
            _jsonOptions.Converters.Add(new NetworkCompanyJsonConverter());
            _jsonOptions.Converters.Add(new NetworkMinimalJsonConverter());
            _jsonOptions.Converters.Add(new NetworkMinimalAsnJsonConverter());
            _jsonOptions.Converters.Add(new NetworkMinimalCompanyJsonConverter());
            _jsonOptions.Converters.Add(new BulkUserAgentRequestJsonConverter());
            _jsonOptions.Converters.Add(new UserAgentRequestJsonConverter());
            _jsonOptions.Converters.Add(new SecurityJsonConverter());
            _jsonOptions.Converters.Add(new SecurityAPIResponseJsonConverter());
            _jsonOptions.Converters.Add(new SecurityAPIXMLResponseJsonConverter());
            _jsonOptions.Converters.Add(new SecurityAPIXMLResponseArrayJsonConverter());
            _jsonOptions.Converters.Add(new TimeConversionResponseJsonConverter());
            _jsonOptions.Converters.Add(new TimeConversionXMLResponseJsonConverter());
            _jsonOptions.Converters.Add(new TimeZoneDetailedResponseJsonConverter());
            _jsonOptions.Converters.Add(new TimeZoneDetailedXMLResponseJsonConverter());
            _jsonOptions.Converters.Add(new TimeZoneDstEndJsonConverter());
            _jsonOptions.Converters.Add(new TimeZoneDstStartJsonConverter());
            _jsonOptions.Converters.Add(new TimezoneAirportJsonConverter());
            _jsonOptions.Converters.Add(new TimezoneDetailJsonConverter());
            _jsonOptions.Converters.Add(new TimezoneDetailDstEndJsonConverter());
            _jsonOptions.Converters.Add(new TimezoneDetailDstStartJsonConverter());
            _jsonOptions.Converters.Add(new TimezoneLocationJsonConverter());
            _jsonOptions.Converters.Add(new TimezoneLocodeJsonConverter());
            _jsonOptions.Converters.Add(new UserAgentDataJsonConverter());
            _jsonOptions.Converters.Add(new UserAgentDataDeviceJsonConverter());
            _jsonOptions.Converters.Add(new UserAgentDataEngineJsonConverter());
            _jsonOptions.Converters.Add(new UserAgentDataOperatingSystemJsonConverter());
            _jsonOptions.Converters.Add(new UserAgentXMLDataJsonConverter());
            _jsonOptions.Converters.Add(new UserAgentXMLDataArrayJsonConverter());
            JsonSerializerOptionsProvider jsonSerializerOptionsProvider = new JsonSerializerOptionsProvider(_jsonOptions);
            _services.AddSingleton(jsonSerializerOptionsProvider);
            _services.AddSingleton<IApiFactory, ApiFactory>();
            _services.AddSingleton<ASNLookupApiEvents>();
            _services.AddTransient<IASNLookupApi, ASNLookupApi>();
            _services.AddSingleton<AbuseContactApiEvents>();
            _services.AddTransient<IAbuseContactApi, AbuseContactApi>();
            _services.AddSingleton<AstronomyApiEvents>();
            _services.AddTransient<IAstronomyApi, AstronomyApi>();
            _services.AddSingleton<IPLocationApiEvents>();
            _services.AddTransient<IIPGeolocationApi, IPGeolocationApi>();
            _services.AddSingleton<SecurityApiEvents>();
            _services.AddTransient<IIPSecurityApi, SecurityApi>();
            _services.AddSingleton<TimeConversionApiEvents>();
            _services.AddTransient<ITimeConversionApi, TimeConversionApi>();
            _services.AddSingleton<TimezoneApiEvents>();
            _services.AddTransient<ITimezoneApi, TimezoneApi>();
            _services.AddSingleton<UserAgentApiEvents>();
            _services.AddTransient<IUserAgentApi, UserAgentApi>();
        }

        /// <summary>
        /// Configures the HttpClients.
        /// </summary>
        /// <param name="client"></param>
        /// <param name="builder"></param>
        /// <returns></returns>
        public HostConfiguration AddApiHttpClients
        (
            Action<HttpClient>? client = null, Action<IHttpClientBuilder>? builder = null)
        {
            if (client == null)
                client = c => c.BaseAddress = new Uri(ClientUtils.BASE_ADDRESS);

            List<IHttpClientBuilder> builders = new List<IHttpClientBuilder>();

            builders.Add(_services.AddHttpClient<IASNLookupApi, ASNLookupApi>(client));
            builders.Add(_services.AddHttpClient<IAbuseContactApi, AbuseContactApi>(client));
            builders.Add(_services.AddHttpClient<IAstronomyApi, AstronomyApi>(client));
            builders.Add(_services.AddHttpClient<IIPGeolocationApi, IPGeolocationApi>(client));
            builders.Add(_services.AddHttpClient<IIPSecurityApi, SecurityApi>(client));
            builders.Add(_services.AddHttpClient<ITimeConversionApi, TimeConversionApi>(client));
            builders.Add(_services.AddHttpClient<ITimezoneApi, TimezoneApi>(client));
            builders.Add(_services.AddHttpClient<IUserAgentApi, UserAgentApi>(client));
            
            if (builder != null)
                foreach (IHttpClientBuilder instance in builders)
                    builder(instance);

            HttpClientsAdded = true;

            return this;
        }

        /// <summary>
        /// Configures the JsonSerializerSettings
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public HostConfiguration ConfigureJsonOptions(Action<JsonSerializerOptions> options)
        {
            options(_jsonOptions);

            return this;
        }

        /// <summary>
        /// Adds tokens to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <param name="token"></param>
        /// <returns></returns>
        public HostConfiguration AddTokens<TTokenBase>(TTokenBase token) where TTokenBase : TokenBase
        {
            return AddTokens(new TTokenBase[]{ token });
        }

        /// <summary>
        /// Adds tokens to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <param name="tokens"></param>
        /// <returns></returns>
        public HostConfiguration AddTokens<TTokenBase>(IEnumerable<TTokenBase> tokens) where TTokenBase : TokenBase
        {
            TokenContainer<TTokenBase> container = new TokenContainer<TTokenBase>(tokens);
            _services.AddSingleton(services => container);

            return this;
        }

        /// <summary>
        /// Adds a token provider to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenProvider"></typeparam>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <returns></returns>
        public HostConfiguration UseProvider<TTokenProvider, TTokenBase>() 
            where TTokenProvider : TokenProvider<TTokenBase>
            where TTokenBase : TokenBase
        {
            _services.AddSingleton<TTokenProvider>();
            _services.AddSingleton<TokenProvider<TTokenBase>>(services => services.GetRequiredService<TTokenProvider>());

            return this;
        }
    }
}

/*
 * IPGeolocation.io - IP intelligence products
 *
 * Ipgeolocation provides a set of APIs to make ip based decisions.
 *
 */

#nullable enable

using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using IPGeolocation.Client;

namespace IPGeolocation.Extensions
{
    /// <summary>
    /// Extension methods for IServiceCollection
    /// </summary>
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Add the api to your host builder.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="options"></param>
        public static void AddApi(this IServiceCollection services, Action<HostConfiguration> options)
        {
            HostConfiguration config = new HostConfiguration(services);
            options(config);
            AddApi(services, config);
        }

        internal static void AddApi(IServiceCollection services, HostConfiguration host)
        {
            if (!host.HttpClientsAdded)
                host.AddApiHttpClients();

            services.AddSingleton<CookieContainer>();

            // ensure that a token provider was provided for this token type
            // if not, default to RateLimitProvider
            var containerServices = services.Where(s => s.ServiceType.IsGenericType &&
                s.ServiceType.GetGenericTypeDefinition().IsAssignableFrom(typeof(TokenContainer<>))).ToArray();

            foreach(var containerService in containerServices)
            {
                var tokenType = containerService.ServiceType.GenericTypeArguments[0];

                var provider = services.FirstOrDefault(s => s.ServiceType.IsAssignableFrom(typeof(TokenProvider<>).MakeGenericType(tokenType)));

                if (provider == null)
                {
                    services.AddSingleton(typeof(RateLimitProvider<>).MakeGenericType(tokenType));
                    services.AddSingleton(typeof(TokenProvider<>).MakeGenericType(tokenType), 
                        s => s.GetRequiredService(typeof(RateLimitProvider<>).MakeGenericType(tokenType)));
                }
            }
        }
    }
}

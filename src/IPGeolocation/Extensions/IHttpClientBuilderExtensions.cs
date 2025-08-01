/*
 * IPGeolocation.io - IP intelligence products
 *
 * Ipgeolocation provides a set of APIs to make ip based decisions.
 *
 */

#nullable enable

using System;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using Polly.Timeout;
using Polly.Extensions.Http;
using Polly;

namespace IPGeolocation.Extensions
{
    /// <summary>
    /// Extension methods for IHttpClientBuilder
    /// </summary>
    public static class IHttpClientBuilderExtensions
    {
        /// <summary>
        /// Adds a Polly retry policy to your clients.
        /// </summary>
        /// <param name="client"></param>
        /// <param name="retries"></param>
        /// <returns></returns>
        public static IHttpClientBuilder AddRetryPolicy(this IHttpClientBuilder client, int retries)
        {
            client.AddPolicyHandler(RetryPolicy(retries));

            return client;
        }

        /// <summary>
        /// Adds a Polly timeout policy to your clients.
        /// </summary>
        /// <param name="client"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public static IHttpClientBuilder AddTimeoutPolicy(this IHttpClientBuilder client, TimeSpan timeout)
        {
            client.AddPolicyHandler(TimeoutPolicy(timeout));

            return client;
        }

        /// <summary>
        /// Adds a Polly circuit breaker to your clients.
        /// </summary>
        /// <param name="client"></param>
        /// <param name="handledEventsAllowedBeforeBreaking"></param>
        /// <param name="durationOfBreak"></param>
        /// <returns></returns>
        public static IHttpClientBuilder AddCircuitBreakerPolicy(this IHttpClientBuilder client, int handledEventsAllowedBeforeBreaking, TimeSpan durationOfBreak)
        {
            client.AddTransientHttpErrorPolicy(builder => CircuitBreakerPolicy(builder, handledEventsAllowedBeforeBreaking, durationOfBreak));

            return client;
        }

        private static Polly.Retry.AsyncRetryPolicy<HttpResponseMessage> RetryPolicy(int retries)
            => HttpPolicyExtensions
                .HandleTransientHttpError()
                .Or<TimeoutRejectedException>()
                .RetryAsync(retries);

        private static AsyncTimeoutPolicy<HttpResponseMessage> TimeoutPolicy(TimeSpan timeout)
            => Policy.TimeoutAsync<HttpResponseMessage>(timeout);

        private static Polly.CircuitBreaker.AsyncCircuitBreakerPolicy<HttpResponseMessage> CircuitBreakerPolicy(
            PolicyBuilder<HttpResponseMessage> builder, int handledEventsAllowedBeforeBreaking, TimeSpan durationOfBreak)
                => builder.CircuitBreakerAsync(handledEventsAllowedBeforeBreaking, durationOfBreak);
    }
}

/*
 * IPGeolocation.io - IP intelligence products
 *
 * Ipgeolocation provides a set of APIs to make ip based decisions.
 *
 */

using System;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Security.Cryptography;
using IPGeolocation.Client;
using IPGeolocation.Api;
using IPGeolocation.Extensions;
using Xunit;

namespace IPGeolocation.Test.Api
{
    /// <summary>
    ///  Tests the dependency injection.
    /// </summary>
    public class DependencyInjectionTest
    {
        private readonly IHost _hostUsingConfigureWithoutAClient =
            Host.CreateDefaultBuilder(Array.Empty<string>()).ConfigureApi((context, services, options) =>
            {
                ApiKeyToken apiKeyToken1 = new ApiKeyToken("your_actual_api_key_here");
                options.AddTokens(apiKeyToken1);
            })
            .Build();

        private readonly IHost _hostUsingConfigureWithAClient =
            Host.CreateDefaultBuilder(Array.Empty<string>()).ConfigureApi((context, services, options) =>
            {
                ApiKeyToken apiKeyToken1 = new ApiKeyToken("your_actual_api_key_here");
                options.AddTokens(apiKeyToken1);
                options.AddApiHttpClients(client => client.BaseAddress = new Uri(ClientUtils.BASE_ADDRESS));
            })
            .Build();

        private readonly IHost _hostUsingAddWithoutAClient =
            Host.CreateDefaultBuilder(Array.Empty<string>()).ConfigureServices((host, services) =>
            {
                services.AddApi(options =>
                {
                    ApiKeyToken apiKeyToken1 = new ApiKeyToken("your_actual_api_key_here");
                    options.AddTokens(apiKeyToken1);
                });
            })
            .Build();

        private readonly IHost _hostUsingAddWithAClient =
            Host.CreateDefaultBuilder(Array.Empty<string>()).ConfigureServices((host, services) =>
            {
                services.AddApi(options =>
                {
                    ApiKeyToken apiKeyToken1 = new ApiKeyToken("your_actual_api_key_here");
                    options.AddTokens(apiKeyToken1);
                    options.AddApiHttpClients(client => client.BaseAddress = new Uri(ClientUtils.BASE_ADDRESS));
                });
            })
            .Build();

        /// <summary>
        /// Test dependency injection when using the configure method
        /// </summary>
        [Fact]
        public void ConfigureApiWithAClientTest()
        {
            var aSNLookupApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IASNLookupApi>();
            Assert.True(aSNLookupApi.HttpClient.BaseAddress != null);

            var abuseContactApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IAbuseContactApi>();
            Assert.True(abuseContactApi.HttpClient.BaseAddress != null);

            var astronomyApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IAstronomyApi>();
            Assert.True(astronomyApi.HttpClient.BaseAddress != null);

            var iPLocationApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IPGeolocationApi>();
            Assert.True(iPLocationApi.HttpClient.BaseAddress != null);

            var securityApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IIPSecurityApi>();
            Assert.True(securityApi.HttpClient.BaseAddress != null);

            var timeConversionApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<ITimeConversionApi>();
            Assert.True(timeConversionApi.HttpClient.BaseAddress != null);

            var timezoneApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<ITimezoneApi>();
            Assert.True(timezoneApi.HttpClient.BaseAddress != null);

            var userAgentApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IUserAgentApi>();
            Assert.True(userAgentApi.HttpClient.BaseAddress != null);
        }

        /// <summary>
        /// Test dependency injection when using the configure method
        /// </summary>
        [Fact]
        public void ConfigureApiWithoutAClientTest()
        {
            var aSNLookupApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IASNLookupApi>();
            Assert.True(aSNLookupApi.HttpClient.BaseAddress != null);

            var abuseContactApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IAbuseContactApi>();
            Assert.True(abuseContactApi.HttpClient.BaseAddress != null);

            var astronomyApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IAstronomyApi>();
            Assert.True(astronomyApi.HttpClient.BaseAddress != null);

            var iPLocationApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IPGeolocationApi>();
            Assert.True(iPLocationApi.HttpClient.BaseAddress != null);

            var securityApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IIPSecurityApi>();
            Assert.True(securityApi.HttpClient.BaseAddress != null);

            var timeConversionApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<ITimeConversionApi>();
            Assert.True(timeConversionApi.HttpClient.BaseAddress != null);

            var timezoneApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<ITimezoneApi>();
            Assert.True(timezoneApi.HttpClient.BaseAddress != null);

            var userAgentApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IUserAgentApi>();
            Assert.True(userAgentApi.HttpClient.BaseAddress != null);
        }

        /// <summary>
        /// Test dependency injection when using the add method
        /// </summary>
        [Fact]
        public void AddApiWithAClientTest()
        {
            var aSNLookupApi = _hostUsingAddWithAClient.Services.GetRequiredService<IASNLookupApi>();
            Assert.True(aSNLookupApi.HttpClient.BaseAddress != null);

            var abuseContactApi = _hostUsingAddWithAClient.Services.GetRequiredService<IAbuseContactApi>();
            Assert.True(abuseContactApi.HttpClient.BaseAddress != null);

            var astronomyApi = _hostUsingAddWithAClient.Services.GetRequiredService<IAstronomyApi>();
            Assert.True(astronomyApi.HttpClient.BaseAddress != null);

            var iPLocationApi = _hostUsingAddWithAClient.Services.GetRequiredService<IPGeolocationApi>();
            Assert.True(iPLocationApi.HttpClient.BaseAddress != null);

            var securityApi = _hostUsingAddWithAClient.Services.GetRequiredService<IIPSecurityApi>();
            Assert.True(securityApi.HttpClient.BaseAddress != null);

            var timeConversionApi = _hostUsingAddWithAClient.Services.GetRequiredService<ITimeConversionApi>();
            Assert.True(timeConversionApi.HttpClient.BaseAddress != null);

            var timezoneApi = _hostUsingAddWithAClient.Services.GetRequiredService<ITimezoneApi>();
            Assert.True(timezoneApi.HttpClient.BaseAddress != null);

            var userAgentApi = _hostUsingAddWithAClient.Services.GetRequiredService<IUserAgentApi>();
            Assert.True(userAgentApi.HttpClient.BaseAddress != null);
        }

        /// <summary>
        /// Test dependency injection when using the add method
        /// </summary>
        [Fact]
        public void AddApiWithoutAClientTest()
        {
            var aSNLookupApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IASNLookupApi>();
            Assert.True(aSNLookupApi.HttpClient.BaseAddress != null);

            var abuseContactApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IAbuseContactApi>();
            Assert.True(abuseContactApi.HttpClient.BaseAddress != null);

            var astronomyApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IAstronomyApi>();
            Assert.True(astronomyApi.HttpClient.BaseAddress != null);

            var iPLocationApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IPGeolocationApi>();
            Assert.True(iPLocationApi.HttpClient.BaseAddress != null);

            var securityApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IIPSecurityApi>();
            Assert.True(securityApi.HttpClient.BaseAddress != null);

            var timeConversionApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<ITimeConversionApi>();
            Assert.True(timeConversionApi.HttpClient.BaseAddress != null);

            var timezoneApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<ITimezoneApi>();
            Assert.True(timezoneApi.HttpClient.BaseAddress != null);

            var userAgentApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IUserAgentApi>();
            Assert.True(userAgentApi.HttpClient.BaseAddress != null);
        }
    }
}

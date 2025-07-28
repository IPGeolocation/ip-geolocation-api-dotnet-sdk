/*
 * IPGeolocation.io - IP intelligence products
 *
 * Ipgeolocation provides a set of APIs to make ip based decisions.
 *
 */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.Json;
using Xunit;
using Microsoft.Extensions.DependencyInjection;
using IPGeolocation.Api;
using IPGeolocation.Model;


/* *********************************************************************************
*              Follow these manual steps to construct tests.
*              This file will not be overwritten.
*  *********************************************************************************
* 1. Navigate to ApiTests.Base.cs and ensure any tokens are being created correctly.
*    Take care not to commit credentials to any repository.
*
* 2. Mocking is coordinated by ApiTestsBase#AddApiHttpClients.
*    To mock the client, use the generic AddApiHttpClients.
*    To mock the server, change the client's BaseAddress.
*
* 3. Locate the test you want below
*      - remove the skip property from the Fact attribute
*      - set the value of any variables if necessary
*
* 4. Run the tests and ensure they work.
*
*/


namespace IPGeolocation.Test.Api
{
    /// <summary>
    ///  Class for testing UserAgentApi
    /// </summary>
    public sealed class UserAgentApiTests : ApiTestsBase
    {
        private readonly IUserAgentApi _instance;

        public UserAgentApiTests() : base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<IUserAgentApi>();
        }

        /// <summary>
        /// Test GetUserAgentDetails
        /// </summary>
        [Fact(Skip = "not implemented")]
        public async Task GetUserAgentDetailsAsyncTest()
        {
            Client.Option<string> userAgent = default!;
            Client.Option<string> output = default!;
            var response = await _instance.GetUserAgentDetailsAsync(userAgent, output);
            var model = response.Ok();
            Console.WriteLine(JsonSerializer.Serialize(model, new JsonSerializerOptions { WriteIndented = true }));
            Assert.IsType<UserAgentData>(model);
        }

        /// <summary>
        /// Test ParseBulkUserAgentStrings
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task ParseBulkUserAgentStringsAsyncTest()
        {
            BulkUserAgentRequest bulkUserAgentRequest = new()
            {
                UaStrings = ["Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/125.0.0.0 Safari/537.36",
                            "Mozilla/5.0 (iPhone; CPU iPhone OS 16_0 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/16.0 Mobile/15E148 Safari/604.1"]
            };
            Client.Option<string> output = default!;
            var response = await _instance.ParseBulkUserAgentStringsAsync(output, bulkUserAgentRequest);
            var model = response.Ok();
            Console.WriteLine(JsonSerializer.Serialize(model, new JsonSerializerOptions { WriteIndented = true }));
            Assert.IsType<List<UserAgentData>>(model);
        }

        /// <summary>
        /// Test ParseUserAgentString
        /// </summary>
        [Fact(Skip = "not implemented")]
        public async Task ParseUserAgentStringAsyncTest()
        {
            Client.Option<string> output = default!;
            Client.Option<UserAgentRequest> userAgentRequest = default!;
            var response = await _instance.ParseUserAgentStringAsync(output, userAgentRequest);
            var model = response.Ok();
            Assert.IsType<UserAgentData>(model);
        }
    }
}

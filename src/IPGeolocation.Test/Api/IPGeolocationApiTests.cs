/*
 * IPGeolocation.io - IP intelligence products
 *
 * Ipgeolocation provides a set of APIs to make ip based decisions.
 *
 */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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
    ///  Class for testing IPLocationApi
    /// </summary>
    public sealed class IPGeolocationApiTests : ApiTestsBase
    {
        private readonly IIPGeolocationApi _instance;

        public IPGeolocationApiTests() : base(Array.Empty<string>())
        {

            _instance = _host.Services.GetRequiredService<IIPGeolocationApi>();
        }

        /// <summary>
        /// Test GetBulkIpGeolocation
        /// </summary>
        [Fact(Skip = "not implemented")]
        public async Task GetBulkIpGeolocationAsyncTest()
        {
            BulkIPRequest bulkIPRequest = new()
            {
                Ips = ["8.8.8.8", "1.1.1.1"]
            };
            Client.Option<string> lang = default!;
            Client.Option<string> fields = default;
            Client.Option<string> excludes = default;
            Client.Option<string> include = default;
            Client.Option<string> output = default!;
            var response = await _instance.GetBulkIpGeolocationAsync(bulkIPRequest, lang, fields, excludes, include, output);
            var model = response.Ok();
            Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(model, new System.Text.Json.JsonSerializerOptions { WriteIndented = true }));
            Assert.IsType<List<BulkGeolocationResponse>>(model);
        }

        /// <summary>
        /// Test GetIpGeolocation
        /// </summary>
        [Fact(Skip = "not implemented")]
        public async Task GetIpGeolocationAsyncTest()
        {
            Client.Option<string> ip = default!;
            Client.Option<string> lang = default!;
            Client.Option<string> fields = default!;
            Client.Option<string> excludes = default!;
            Client.Option<string> include = default!;
            Client.Option<string> output = default!;
            var response = await _instance.GetIpGeolocationAsync(ip, lang, fields, excludes, include, output);
            var model = response.Ok();
            Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(model, new System.Text.Json.JsonSerializerOptions { WriteIndented = true }));
            Assert.IsType<GeolocationResponse>(model);
        }
    }
}

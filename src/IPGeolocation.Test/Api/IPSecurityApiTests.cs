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
    ///  Class for testing SecurityApi
    /// </summary>
    public sealed class IPSecurityApiTests : ApiTestsBase
    {
        private readonly IIPSecurityApi _instance;

        public IPSecurityApiTests() : base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<IIPSecurityApi>();
        }

        /// <summary>
        /// Test GetBulkIpSecurityInfo
        /// </summary>
        [Fact(Skip = "not implemented")]
        public async Task GetBulkIpSecurityInfoAsyncTest()
        {
            BulkIPRequest bulkRequest = new()
            {
                Ips = ["2.56.188.34", "2.56.188.35"]
            };
            Client.Option<string> include = default!;
            Client.Option<string> fields = default!;
            Client.Option<string> excludes = default!;
            Client.Option<string> output = default!;
            Client.Option<string> lang = default!;
            var response = await _instance.GetBulkIpSecurityInfoAsync(bulkRequest, include, fields, excludes, output, lang);
            var model = response.Ok();
            Console.WriteLine(JsonSerializer.Serialize(model, new JsonSerializerOptions { WriteIndented = true }));
            Assert.IsType<List<BulkIPSecurityResponse>>(model);
        }

        /// <summary>
        /// Test GetIpSecurityInfo
        /// </summary>
        [Fact(Skip = "not implemented")]
        public async Task GetIpSecurityInfoAsyncTest()
        {
            Client.Option<string> ip = default!;
            Client.Option<string> include = default!;
            Client.Option<string> fields = default!;
            Client.Option<string> excludes = default!;
            Client.Option<string> output = default!;
            Client.Option<string> lang = default!;
            var response = await _instance.GetIpSecurityInfoAsync(ip, include, fields, excludes, output, lang);
            var model = response.Ok();
            Console.WriteLine(JsonSerializer.Serialize(model, new JsonSerializerOptions { WriteIndented = true }));
            Assert.IsType<SecurityAPIResponse>(model);
        }
    }
}

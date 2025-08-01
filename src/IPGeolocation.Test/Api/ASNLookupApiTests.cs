/*
 * IPGeolocation.io - IP intelligence products
 *
 * Ipgeolocation provides a set of APIs to make ip based decisions.
 *
 */

using System;
using System.Collections.Generic;
using System.Text.Json;
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
    ///  Class for testing ASNLookupApi
    /// </summary>
    public sealed class ASNLookupApiTests : ApiTestsBase
    {
        private readonly IASNLookupApi _instance;

        public ASNLookupApiTests() : base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<IASNLookupApi>();
        }

        /// <summary>
        /// Test GetAsnInfo
        /// </summary>
        [Fact (Skip ="not implemented")]
        public async Task GetAsnInfoAsyncTest()
        {
            Client.Option<string> ip = default!;
            Client.Option<int> asn = default!;
            Client.Option<string> include = default!;
            Client.Option<string> excludes = default!;
            Client.Option<string> fields = default!;
            var response = await _instance.GetAsnInfoAsync(ip, asn, include, excludes, fields);
            var model = response.Ok();
            Console.WriteLine(JsonSerializer.Serialize(model, new JsonSerializerOptions { WriteIndented = true }));
            Assert.IsType<ASNResponse>(model);
        }
    }
}

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
    ///  Class for testing TimeConversionApi
    /// </summary>
    public sealed class TimeConversionApiTests : ApiTestsBase
    {
        private readonly ITimeConversionApi _instance;

        public TimeConversionApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<ITimeConversionApi>();
        }

        /// <summary>
        /// Test ConvertTimeBetweenTimezones
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task ConvertTimeBetweenTimezonesAsyncTest()
        {
            Client.Option<string> time = default!;
            Client.Option<string> tzFrom = default!;
            Client.Option<string> tzTo = default!;
            Client.Option<float> latFrom = default!;
            Client.Option<float> longFrom = default!;
            Client.Option<float> latTo = default!;
            Client.Option<float> longTo = default!;
            Client.Option<string> locationFrom = default!;
            Client.Option<string> locationTo = default!;
            Client.Option<string> icaoFrom = default!;
            Client.Option<string> icaoTo = default!;
            Client.Option<string> iataFrom = default!;
            Client.Option<string> iataTo = default!;
            Client.Option<string> locodeFrom = default!;
            Client.Option<string> locodeTo = default!;
            var response = await _instance.ConvertTimeBetweenTimezonesAsync(time, tzFrom, tzTo, latFrom, longFrom, latTo, longTo, locationFrom, locationTo, icaoFrom, icaoTo, iataFrom, iataTo, locodeFrom, locodeTo);
            var model = response.Ok();
            Console.WriteLine(JsonSerializer.Serialize(model, new JsonSerializerOptions { WriteIndented = true }));
            Assert.IsType<TimeConversionResponse>(model);
        }
    }
}

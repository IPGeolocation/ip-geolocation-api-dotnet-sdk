/*
 * IPGeolocation.io - IP intelligence products
 *
 * Ipgeolocation provides a set of APIs to make ip based decisions.
 *
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IPGeolocation.Model;
using IPGeolocation.Client;
using System.Reflection;

namespace IPGeolocation.Test.Model
{
    /// <summary>
    ///  Class for testing BulkUserAgentRequest
    /// </summary>
    
    public class BulkUserAgentRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for BulkUserAgentRequest
        //private BulkUserAgentRequest instance;

        public BulkUserAgentRequestTests()
        {
            // TODO uncomment below to create an instance of BulkUserAgentRequest
            //instance = new BulkUserAgentRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BulkUserAgentRequest
        /// </summary>
        [Fact]
        public void BulkUserAgentRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" BulkUserAgentRequest
            //Assert.IsType<BulkUserAgentRequest>(instance);
        }

        /// <summary>
        /// Test the property 'UaStrings'
        /// </summary>
        [Fact]
        public void UaStringsTest()
        {
            // TODO unit test for the property 'UaStrings'
        }
    }
}

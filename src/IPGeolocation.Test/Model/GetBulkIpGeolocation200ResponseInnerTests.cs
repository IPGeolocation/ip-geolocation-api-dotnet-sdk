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
    ///  Class for testing BulkGeolocationResponse
    /// </summary>
    
    public class BulkGeolocationResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for BulkGeolocationResponse
        //private BulkGeolocationResponse instance;

        public BulkGeolocationResponseTests()
        {
            // TODO uncomment below to create an instance of BulkGeolocationResponse
            //instance = new BulkGeolocationResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BulkGeolocationResponse
        /// </summary>
        [Fact]
        public void BulkGeolocationResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" BulkGeolocationResponse
            //Assert.IsType<BulkGeolocationResponse>(instance);
        }

        /// <summary>
        /// Test the property 'VarTimeZone'
        /// </summary>
        [Fact]
        public void VarTimeZoneTest()
        {
            // TODO unit test for the property 'VarTimeZone'
        }
    }
}

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
    ///  Class for testing BulkGeolocationResponse1
    /// </summary>
    
    public class BulkGeolocationResponse1Tests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for BulkGeolocationResponse1
        //private BulkGeolocationResponse1 instance;

        public BulkGeolocationResponse1Tests()
        {
            // TODO uncomment below to create an instance of BulkGeolocationResponse1
            //instance = new BulkGeolocationResponse1();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BulkGeolocationResponse1
        /// </summary>
        [Fact]
        public void BulkGeolocationResponse1InstanceTest()
        {
            // TODO uncomment below to test "IsType" BulkGeolocationResponse1
            //Assert.IsType<BulkGeolocationResponse1>(instance);
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

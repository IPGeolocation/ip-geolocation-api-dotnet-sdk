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
    ///  Class for testing BulkIPRequest
    /// </summary>
    
    public class BulkIPRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for BulkIPRequest
        //private BulkIPRequest instance;

        public BulkIPRequestTests()
        {
            // TODO uncomment below to create an instance of BulkIPRequest
            //instance = new BulkIPRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BulkIPRequest
        /// </summary>
        [Fact]
        public void BulkIPRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" BulkIPRequest
            //Assert.IsType<BulkIPRequest>(instance);
        }

        /// <summary>
        /// Test the property 'Ips'
        /// </summary>
        [Fact]
        public void IpsTest()
        {
            // TODO unit test for the property 'Ips'
        }
    }
}

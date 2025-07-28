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
    ///  Class for testing BulkIPSecurityResponse
    /// </summary>
    
    public class BulkIPSecurityResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for BulkIPSecurityResponse
        //private BulkIPSecurityResponse instance;

        public BulkIPSecurityResponseTests()
        {
            // TODO uncomment below to create an instance of BulkIPSecurityResponse
            //instance = new BulkIPSecurityResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BulkIPSecurityResponse
        /// </summary>
        [Fact]
        public void BulkIPSecurityResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" BulkIPSecurityResponse
            //Assert.IsType<BulkIPSecurityResponse>(instance);
        }
    }
}

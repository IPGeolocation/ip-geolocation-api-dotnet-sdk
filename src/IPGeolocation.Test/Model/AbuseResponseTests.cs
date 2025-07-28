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
    ///  Class for testing AbuseResponse
    /// </summary>
    
    public class AbuseResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for AbuseResponse
        //private AbuseResponse instance;

        public AbuseResponseTests()
        {
            // TODO uncomment below to create an instance of AbuseResponse
            //instance = new AbuseResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AbuseResponse
        /// </summary>
        [Fact]
        public void AbuseResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" AbuseResponse
            //Assert.IsType<AbuseResponse>(instance);
        }

        /// <summary>
        /// Test the property 'Ip'
        /// </summary>
        [Fact]
        public void IpTest()
        {
            // TODO unit test for the property 'Ip'
        }

        /// <summary>
        /// Test the property 'Abuse'
        /// </summary>
        [Fact]
        public void AbuseTest()
        {
            // TODO unit test for the property 'Abuse'
        }
    }
}

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
    ///  Class for testing ASNResponse
    /// </summary>
    
    public class ASNResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ASNResponse
        //private ASNResponse instance;

        public ASNResponseTests()
        {
            // TODO uncomment below to create an instance of ASNResponse
            //instance = new ASNResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ASNResponse
        /// </summary>
        [Fact]
        public void ASNResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" ASNResponse
            //Assert.IsType<ASNResponse>(instance);
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
        /// Test the property 'Asn'
        /// </summary>
        [Fact]
        public void AsnTest()
        {
            // TODO unit test for the property 'Asn'
        }
    }
}

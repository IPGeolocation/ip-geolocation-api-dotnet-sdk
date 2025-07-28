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
    ///  Class for testing ASNResponseXML
    /// </summary>
    
    public class ASNResponseXMLTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ASNResponseXML
        //private ASNResponseXML instance;

        public ASNResponseXMLTests()
        {
            // TODO uncomment below to create an instance of ASNResponseXML
            //instance = new ASNResponseXML();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ASNResponseXML
        /// </summary>
        [Fact]
        public void ASNResponseXMLInstanceTest()
        {
            // TODO uncomment below to test "IsType" ASNResponseXML
            //Assert.IsType<ASNResponseXML>(instance);
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

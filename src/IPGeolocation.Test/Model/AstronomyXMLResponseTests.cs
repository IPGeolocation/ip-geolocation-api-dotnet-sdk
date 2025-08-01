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
    ///  Class for testing AstronomyXMLResponse
    /// </summary>
    
    public class AstronomyXMLResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for AstronomyXMLResponse
        //private AstronomyXMLResponse instance;

        public AstronomyXMLResponseTests()
        {
            // TODO uncomment below to create an instance of AstronomyXMLResponse
            //instance = new AstronomyXMLResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AstronomyXMLResponse
        /// </summary>
        [Fact]
        public void AstronomyXMLResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" AstronomyXMLResponse
            //Assert.IsType<AstronomyXMLResponse>(instance);
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
        /// Test the property 'Location'
        /// </summary>
        [Fact]
        public void LocationTest()
        {
            // TODO unit test for the property 'Location'
        }

        /// <summary>
        /// Test the property 'Astronomy'
        /// </summary>
        [Fact]
        public void AstronomyTest()
        {
            // TODO unit test for the property 'Astronomy'
        }
    }
}

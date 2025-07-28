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
    ///  Class for testing AstronomyResponse
    /// </summary>
    
    public class AstronomyResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for AstronomyResponse
        //private AstronomyResponse instance;

        public AstronomyResponseTests()
        {
            // TODO uncomment below to create an instance of AstronomyResponse
            //instance = new AstronomyResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AstronomyResponse
        /// </summary>
        [Fact]
        public void AstronomyResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" AstronomyResponse
            //Assert.IsType<AstronomyResponse>(instance);
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

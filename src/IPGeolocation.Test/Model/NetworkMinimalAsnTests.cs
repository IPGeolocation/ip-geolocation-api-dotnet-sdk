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
    ///  Class for testing NetworkMinimalAsn
    /// </summary>
    
    public class NetworkMinimalAsnTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for NetworkMinimalAsn
        //private NetworkMinimalAsn instance;

        public NetworkMinimalAsnTests()
        {
            // TODO uncomment below to create an instance of NetworkMinimalAsn
            //instance = new NetworkMinimalAsn();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of NetworkMinimalAsn
        /// </summary>
        [Fact]
        public void NetworkMinimalAsnInstanceTest()
        {
            // TODO uncomment below to test "IsType" NetworkMinimalAsn
            //Assert.IsType<NetworkMinimalAsn>(instance);
        }

        /// <summary>
        /// Test the property 'AsNumber'
        /// </summary>
        [Fact]
        public void AsNumberTest()
        {
            // TODO unit test for the property 'AsNumber'
        }

        /// <summary>
        /// Test the property 'Organization'
        /// </summary>
        [Fact]
        public void OrganizationTest()
        {
            // TODO unit test for the property 'Organization'
        }

        /// <summary>
        /// Test the property 'Country'
        /// </summary>
        [Fact]
        public void CountryTest()
        {
            // TODO unit test for the property 'Country'
        }
    }
}

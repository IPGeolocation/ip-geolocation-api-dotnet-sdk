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
    ///  Class for testing NetworkMinimal
    /// </summary>
    
    public class NetworkMinimalTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for NetworkMinimal
        //private NetworkMinimal instance;

        public NetworkMinimalTests()
        {
            // TODO uncomment below to create an instance of NetworkMinimal
            //instance = new NetworkMinimal();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of NetworkMinimal
        /// </summary>
        [Fact]
        public void NetworkMinimalInstanceTest()
        {
            // TODO uncomment below to test "IsType" NetworkMinimal
            //Assert.IsType<NetworkMinimal>(instance);
        }

        /// <summary>
        /// Test the property 'Asn'
        /// </summary>
        [Fact]
        public void AsnTest()
        {
            // TODO unit test for the property 'Asn'
        }

        /// <summary>
        /// Test the property 'Company'
        /// </summary>
        [Fact]
        public void CompanyTest()
        {
            // TODO unit test for the property 'Company'
        }
    }
}

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
    ///  Class for testing Network
    /// </summary>
    
    public class NetworkTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Network
        //private Network instance;

        public NetworkTests()
        {
            // TODO uncomment below to create an instance of Network
            //instance = new Network();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Network
        /// </summary>
        [Fact]
        public void NetworkInstanceTest()
        {
            // TODO uncomment below to test "IsType" Network
            //Assert.IsType<Network>(instance);
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
        /// Test the property 'ConnectionType'
        /// </summary>
        [Fact]
        public void ConnectionTypeTest()
        {
            // TODO unit test for the property 'ConnectionType'
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

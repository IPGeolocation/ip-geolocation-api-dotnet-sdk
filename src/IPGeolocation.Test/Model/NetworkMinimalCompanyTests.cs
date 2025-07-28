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
    ///  Class for testing NetworkMinimalCompany
    /// </summary>
    
    public class NetworkMinimalCompanyTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for NetworkMinimalCompany
        //private NetworkMinimalCompany instance;

        public NetworkMinimalCompanyTests()
        {
            // TODO uncomment below to create an instance of NetworkMinimalCompany
            //instance = new NetworkMinimalCompany();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of NetworkMinimalCompany
        /// </summary>
        [Fact]
        public void NetworkMinimalCompanyInstanceTest()
        {
            // TODO uncomment below to test "IsType" NetworkMinimalCompany
            //Assert.IsType<NetworkMinimalCompany>(instance);
        }

        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
    }
}

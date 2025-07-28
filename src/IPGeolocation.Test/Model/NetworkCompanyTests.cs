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
    ///  Class for testing NetworkCompany
    /// </summary>
    
    public class NetworkCompanyTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for NetworkCompany
        //private NetworkCompany instance;

        public NetworkCompanyTests()
        {
            // TODO uncomment below to create an instance of NetworkCompany
            //instance = new NetworkCompany();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of NetworkCompany
        /// </summary>
        [Fact]
        public void NetworkCompanyInstanceTest()
        {
            // TODO uncomment below to test "IsType" NetworkCompany
            //Assert.IsType<NetworkCompany>(instance);
        }

        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }

        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }

        /// <summary>
        /// Test the property 'Domain'
        /// </summary>
        [Fact]
        public void DomainTest()
        {
            // TODO unit test for the property 'Domain'
        }
    }
}

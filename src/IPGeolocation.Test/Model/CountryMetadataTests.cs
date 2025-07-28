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
    ///  Class for testing CountryMetadata
    /// </summary>
    
    public class CountryMetadataTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CountryMetadata
        //private CountryMetadata instance;

        public CountryMetadataTests()
        {
            // TODO uncomment below to create an instance of CountryMetadata
            //instance = new CountryMetadata();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CountryMetadata
        /// </summary>
        [Fact]
        public void CountryMetadataInstanceTest()
        {
            // TODO uncomment below to test "IsType" CountryMetadata
            //Assert.IsType<CountryMetadata>(instance);
        }

        /// <summary>
        /// Test the property 'CallingCode'
        /// </summary>
        [Fact]
        public void CallingCodeTest()
        {
            // TODO unit test for the property 'CallingCode'
        }

        /// <summary>
        /// Test the property 'Tld'
        /// </summary>
        [Fact]
        public void TldTest()
        {
            // TODO unit test for the property 'Tld'
        }

        /// <summary>
        /// Test the property 'Languages'
        /// </summary>
        [Fact]
        public void LanguagesTest()
        {
            // TODO unit test for the property 'Languages'
        }
    }
}

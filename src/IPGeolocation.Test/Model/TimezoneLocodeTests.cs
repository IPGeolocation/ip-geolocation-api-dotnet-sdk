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
    ///  Class for testing TimezoneLocode
    /// </summary>
    
    public class TimezoneLocodeTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for TimezoneLocode
        //private TimezoneLocode instance;

        public TimezoneLocodeTests()
        {
            // TODO uncomment below to create an instance of TimezoneLocode
            //instance = new TimezoneLocode();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TimezoneLocode
        /// </summary>
        [Fact]
        public void TimezoneLocodeInstanceTest()
        {
            // TODO uncomment below to test "IsType" TimezoneLocode
            //Assert.IsType<TimezoneLocode>(instance);
        }

        /// <summary>
        /// Test the property 'LoCode'
        /// </summary>
        [Fact]
        public void LoCodeTest()
        {
            // TODO unit test for the property 'LoCode'
        }

        /// <summary>
        /// Test the property 'City'
        /// </summary>
        [Fact]
        public void CityTest()
        {
            // TODO unit test for the property 'City'
        }

        /// <summary>
        /// Test the property 'StateCode'
        /// </summary>
        [Fact]
        public void StateCodeTest()
        {
            // TODO unit test for the property 'StateCode'
        }

        /// <summary>
        /// Test the property 'CountryCode'
        /// </summary>
        [Fact]
        public void CountryCodeTest()
        {
            // TODO unit test for the property 'CountryCode'
        }

        /// <summary>
        /// Test the property 'CountryName'
        /// </summary>
        [Fact]
        public void CountryNameTest()
        {
            // TODO unit test for the property 'CountryName'
        }

        /// <summary>
        /// Test the property 'LocationType'
        /// </summary>
        [Fact]
        public void LocationTypeTest()
        {
            // TODO unit test for the property 'LocationType'
        }

        /// <summary>
        /// Test the property 'Latitude'
        /// </summary>
        [Fact]
        public void LatitudeTest()
        {
            // TODO unit test for the property 'Latitude'
        }

        /// <summary>
        /// Test the property 'Longitude'
        /// </summary>
        [Fact]
        public void LongitudeTest()
        {
            // TODO unit test for the property 'Longitude'
        }
    }
}

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
    ///  Class for testing TimeZoneDetailedResponse
    /// </summary>
    
    public class TimeZoneDetailedResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for TimeZoneDetailedResponse
        //private TimeZoneDetailedResponse instance;

        public TimeZoneDetailedResponseTests()
        {
            // TODO uncomment below to create an instance of TimeZoneDetailedResponse
            //instance = new TimeZoneDetailedResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TimeZoneDetailedResponse
        /// </summary>
        [Fact]
        public void TimeZoneDetailedResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" TimeZoneDetailedResponse
            //Assert.IsType<TimeZoneDetailedResponse>(instance);
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
        /// Test the property 'AirportDetails'
        /// </summary>
        [Fact]
        public void AirportDetailsTest()
        {
            // TODO unit test for the property 'AirportDetails'
        }

        /// <summary>
        /// Test the property 'LoCodeDetails'
        /// </summary>
        [Fact]
        public void LoCodeDetailsTest()
        {
            // TODO unit test for the property 'LoCodeDetails'
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
        /// Test the property 'VarTimeZone'
        /// </summary>
        [Fact]
        public void VarTimeZoneTest()
        {
            // TODO unit test for the property 'VarTimeZone'
        }
    }
}

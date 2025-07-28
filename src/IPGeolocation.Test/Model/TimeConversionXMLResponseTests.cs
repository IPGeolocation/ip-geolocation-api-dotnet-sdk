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
    ///  Class for testing TimeConversionXMLResponse
    /// </summary>
    
    public class TimeConversionXMLResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for TimeConversionXMLResponse
        //private TimeConversionXMLResponse instance;

        public TimeConversionXMLResponseTests()
        {
            // TODO uncomment below to create an instance of TimeConversionXMLResponse
            //instance = new TimeConversionXMLResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TimeConversionXMLResponse
        /// </summary>
        [Fact]
        public void TimeConversionXMLResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" TimeConversionXMLResponse
            //Assert.IsType<TimeConversionXMLResponse>(instance);
        }

        /// <summary>
        /// Test the property 'OriginalTime'
        /// </summary>
        [Fact]
        public void OriginalTimeTest()
        {
            // TODO unit test for the property 'OriginalTime'
        }

        /// <summary>
        /// Test the property 'ConvertedTime'
        /// </summary>
        [Fact]
        public void ConvertedTimeTest()
        {
            // TODO unit test for the property 'ConvertedTime'
        }

        /// <summary>
        /// Test the property 'DiffHour'
        /// </summary>
        [Fact]
        public void DiffHourTest()
        {
            // TODO unit test for the property 'DiffHour'
        }

        /// <summary>
        /// Test the property 'DiffMin'
        /// </summary>
        [Fact]
        public void DiffMinTest()
        {
            // TODO unit test for the property 'DiffMin'
        }
    }
}

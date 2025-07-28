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
    ///  Class for testing ErrorResponse
    /// </summary>
    
    public class ErrorResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ErrorResponse
        //private ErrorResponse instance;

        public ErrorResponseTests()
        {
            // TODO uncomment below to create an instance of ErrorResponse
            //instance = new ErrorResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ErrorResponse
        /// </summary>
        [Fact]
        public void ErrorResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" ErrorResponse
            //Assert.IsType<ErrorResponse>(instance);
        }

        /// <summary>
        /// Test the property 'Message'
        /// </summary>
        [Fact]
        public void MessageTest()
        {
            // TODO unit test for the property 'Message'
        }
    }
}

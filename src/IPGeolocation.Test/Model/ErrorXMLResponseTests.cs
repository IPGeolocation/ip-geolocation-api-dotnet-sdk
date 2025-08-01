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
    ///  Class for testing ErrorXMLResponse
    /// </summary>
    
    public class ErrorXMLResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ErrorXMLResponse
        //private ErrorXMLResponse instance;

        public ErrorXMLResponseTests()
        {
            // TODO uncomment below to create an instance of ErrorXMLResponse
            //instance = new ErrorXMLResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ErrorXMLResponse
        /// </summary>
        [Fact]
        public void ErrorXMLResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" ErrorXMLResponse
            //Assert.IsType<ErrorXMLResponse>(instance);
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

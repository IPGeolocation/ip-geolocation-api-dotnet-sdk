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
    ///  Class for testing ErrorXMLResponseArray
    /// </summary>
    
    public class ErrorXMLResponseArrayTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ErrorXMLResponseArray
        //private ErrorXMLResponseArray instance;

        public ErrorXMLResponseArrayTests()
        {
            // TODO uncomment below to create an instance of ErrorXMLResponseArray
            //instance = new ErrorXMLResponseArray();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ErrorXMLResponseArray
        /// </summary>
        [Fact]
        public void ErrorXMLResponseArrayInstanceTest()
        {
            // TODO uncomment below to test "IsType" ErrorXMLResponseArray
            //Assert.IsType<ErrorXMLResponseArray>(instance);
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

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
    ///  Class for testing UserAgentRequest
    /// </summary>
    
    public class UserAgentRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for UserAgentRequest
        //private UserAgentRequest instance;

        public UserAgentRequestTests()
        {
            // TODO uncomment below to create an instance of UserAgentRequest
            //instance = new UserAgentRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UserAgentRequest
        /// </summary>
        [Fact]
        public void UserAgentRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" UserAgentRequest
            //Assert.IsType<UserAgentRequest>(instance);
        }

        /// <summary>
        /// Test the property 'UaString'
        /// </summary>
        [Fact]
        public void UaStringTest()
        {
            // TODO unit test for the property 'UaString'
        }
    }
}

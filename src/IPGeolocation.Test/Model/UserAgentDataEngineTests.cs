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
    ///  Class for testing UserAgentDataEngine
    /// </summary>
    
    public class UserAgentDataEngineTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for UserAgentDataEngine
        //private UserAgentDataEngine instance;

        public UserAgentDataEngineTests()
        {
            // TODO uncomment below to create an instance of UserAgentDataEngine
            //instance = new UserAgentDataEngine();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UserAgentDataEngine
        /// </summary>
        [Fact]
        public void UserAgentDataEngineInstanceTest()
        {
            // TODO uncomment below to test "IsType" UserAgentDataEngine
            //Assert.IsType<UserAgentDataEngine>(instance);
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
        /// Test the property 'VarVersion'
        /// </summary>
        [Fact]
        public void VarVersionTest()
        {
            // TODO unit test for the property 'VarVersion'
        }

        /// <summary>
        /// Test the property 'VersionMajor'
        /// </summary>
        [Fact]
        public void VersionMajorTest()
        {
            // TODO unit test for the property 'VersionMajor'
        }
    }
}

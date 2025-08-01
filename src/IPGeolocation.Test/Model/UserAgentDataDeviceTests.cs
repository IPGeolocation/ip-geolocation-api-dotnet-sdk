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
    ///  Class for testing UserAgentDataDevice
    /// </summary>
    
    public class UserAgentDataDeviceTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for UserAgentDataDevice
        //private UserAgentDataDevice instance;

        public UserAgentDataDeviceTests()
        {
            // TODO uncomment below to create an instance of UserAgentDataDevice
            //instance = new UserAgentDataDevice();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UserAgentDataDevice
        /// </summary>
        [Fact]
        public void UserAgentDataDeviceInstanceTest()
        {
            // TODO uncomment below to test "IsType" UserAgentDataDevice
            //Assert.IsType<UserAgentDataDevice>(instance);
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
        /// Test the property 'Brand'
        /// </summary>
        [Fact]
        public void BrandTest()
        {
            // TODO unit test for the property 'Brand'
        }

        /// <summary>
        /// Test the property 'Cpu'
        /// </summary>
        [Fact]
        public void CpuTest()
        {
            // TODO unit test for the property 'Cpu'
        }
    }
}

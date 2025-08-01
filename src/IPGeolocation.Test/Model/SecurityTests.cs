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
    ///  Class for testing Security
    /// </summary>
    
    public class SecurityTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Security
        //private Security instance;

        public SecurityTests()
        {
            // TODO uncomment below to create an instance of Security
            //instance = new Security();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Security
        /// </summary>
        [Fact]
        public void SecurityInstanceTest()
        {
            // TODO uncomment below to test "IsType" Security
            //Assert.IsType<Security>(instance);
        }

        /// <summary>
        /// Test the property 'ThreatScore'
        /// </summary>
        [Fact]
        public void ThreatScoreTest()
        {
            // TODO unit test for the property 'ThreatScore'
        }

        /// <summary>
        /// Test the property 'IsTor'
        /// </summary>
        [Fact]
        public void IsTorTest()
        {
            // TODO unit test for the property 'IsTor'
        }

        /// <summary>
        /// Test the property 'IsProxy'
        /// </summary>
        [Fact]
        public void IsProxyTest()
        {
            // TODO unit test for the property 'IsProxy'
        }

        /// <summary>
        /// Test the property 'ProxyType'
        /// </summary>
        [Fact]
        public void ProxyTypeTest()
        {
            // TODO unit test for the property 'ProxyType'
        }

        /// <summary>
        /// Test the property 'ProxyProvider'
        /// </summary>
        [Fact]
        public void ProxyProviderTest()
        {
            // TODO unit test for the property 'ProxyProvider'
        }

        /// <summary>
        /// Test the property 'IsAnonymous'
        /// </summary>
        [Fact]
        public void IsAnonymousTest()
        {
            // TODO unit test for the property 'IsAnonymous'
        }

        /// <summary>
        /// Test the property 'IsKnownAttacker'
        /// </summary>
        [Fact]
        public void IsKnownAttackerTest()
        {
            // TODO unit test for the property 'IsKnownAttacker'
        }

        /// <summary>
        /// Test the property 'IsSpam'
        /// </summary>
        [Fact]
        public void IsSpamTest()
        {
            // TODO unit test for the property 'IsSpam'
        }

        /// <summary>
        /// Test the property 'IsBot'
        /// </summary>
        [Fact]
        public void IsBotTest()
        {
            // TODO unit test for the property 'IsBot'
        }

        /// <summary>
        /// Test the property 'IsCloudProvider'
        /// </summary>
        [Fact]
        public void IsCloudProviderTest()
        {
            // TODO unit test for the property 'IsCloudProvider'
        }

        /// <summary>
        /// Test the property 'CloudProvider'
        /// </summary>
        [Fact]
        public void CloudProviderTest()
        {
            // TODO unit test for the property 'CloudProvider'
        }
    }
}

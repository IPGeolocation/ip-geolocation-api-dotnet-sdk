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
    ///  Class for testing ASNConnection
    /// </summary>
    
    public class ASNConnectionTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ASNConnection
        //private ASNConnection instance;

        public ASNConnectionTests()
        {
            // TODO uncomment below to create an instance of ASNConnection
            //instance = new ASNConnection();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ASNConnection
        /// </summary>
        [Fact]
        public void ASNConnectionInstanceTest()
        {
            // TODO uncomment below to test "IsType" ASNConnection
            //Assert.IsType<ASNConnection>(instance);
        }

        /// <summary>
        /// Test the property 'AsNumber'
        /// </summary>
        [Fact]
        public void AsNumberTest()
        {
            // TODO unit test for the property 'AsNumber'
        }

        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Fact]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }

        /// <summary>
        /// Test the property 'Country'
        /// </summary>
        [Fact]
        public void CountryTest()
        {
            // TODO unit test for the property 'Country'
        }
    }
}

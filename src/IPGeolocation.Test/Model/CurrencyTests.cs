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
    ///  Class for testing Currency
    /// </summary>
    
    public class CurrencyTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Currency
        //private Currency instance;

        public CurrencyTests()
        {
            // TODO uncomment below to create an instance of Currency
            //instance = new Currency();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Currency
        /// </summary>
        [Fact]
        public void CurrencyInstanceTest()
        {
            // TODO uncomment below to test "IsType" Currency
            //Assert.IsType<Currency>(instance);
        }

        /// <summary>
        /// Test the property 'Code'
        /// </summary>
        [Fact]
        public void CodeTest()
        {
            // TODO unit test for the property 'Code'
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
        /// Test the property 'Symbol'
        /// </summary>
        [Fact]
        public void SymbolTest()
        {
            // TODO unit test for the property 'Symbol'
        }
    }
}

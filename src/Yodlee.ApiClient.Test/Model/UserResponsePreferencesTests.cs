/*
 * Yodlee Core APIs
 *
 * This file describes the Yodlee Platform APIs using the swagger notation. You can use this swagger file to generate client side SDKs to the Yodlee Platform APIs for many different programming languages. Yodlee API v1.1 - Overview</a>.<br><br>You will have to set the header before making the API call. The following headers apply to all the APIs:<ul><li>Authorization: This header holds the access token</li> <li> Api-Version: 1.1</li></ul><b>Note</b>: If there are any API-specific headers, they are mentioned explicitly in the respective API's description.
 *
 * The version of the OpenAPI document: 1.1.0
 * Contact: developer@yodlee.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Model;
using Yodlee.ApiClient.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Yodlee.ApiClient.Test.Model
{
    /// <summary>
    ///  Class for testing UserResponsePreferences
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class UserResponsePreferencesTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for UserResponsePreferences
        //private UserResponsePreferences instance;

        public UserResponsePreferencesTests()
        {
            // TODO uncomment below to create an instance of UserResponsePreferences
            //instance = new UserResponsePreferences();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UserResponsePreferences
        /// </summary>
        [Fact]
        public void UserResponsePreferencesInstanceTest()
        {
            // TODO uncomment below to test "IsType" UserResponsePreferences
            //Assert.IsType<UserResponsePreferences>(instance);
        }


        /// <summary>
        /// Test the property 'DateFormat'
        /// </summary>
        [Fact]
        public void DateFormatTest()
        {
            // TODO unit test for the property 'DateFormat'
        }
        /// <summary>
        /// Test the property 'TimeZone'
        /// </summary>
        [Fact]
        public void TimeZoneTest()
        {
            // TODO unit test for the property 'TimeZone'
        }
        /// <summary>
        /// Test the property 'Currency'
        /// </summary>
        [Fact]
        public void CurrencyTest()
        {
            // TODO unit test for the property 'Currency'
        }
        /// <summary>
        /// Test the property 'Locale'
        /// </summary>
        [Fact]
        public void LocaleTest()
        {
            // TODO unit test for the property 'Locale'
        }

    }

}

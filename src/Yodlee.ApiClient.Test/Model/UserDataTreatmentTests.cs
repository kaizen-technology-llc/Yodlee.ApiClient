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
    ///  Class for testing UserDataTreatment
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class UserDataTreatmentTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for UserDataTreatment
        //private UserDataTreatment instance;

        public UserDataTreatmentTests()
        {
            // TODO uncomment below to create an instance of UserDataTreatment
            //instance = new UserDataTreatment();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UserDataTreatment
        /// </summary>
        [Fact]
        public void UserDataTreatmentInstanceTest()
        {
            // TODO uncomment below to test "IsType" UserDataTreatment
            //Assert.IsType<UserDataTreatment>(instance);
        }


        /// <summary>
        /// Test the property 'DataHandling'
        /// </summary>
        [Fact]
        public void DataHandlingTest()
        {
            // TODO unit test for the property 'DataHandling'
        }
        /// <summary>
        /// Test the property 'CdrPolicy'
        /// </summary>
        [Fact]
        public void CdrPolicyTest()
        {
            // TODO unit test for the property 'CdrPolicy'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Fact]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }

    }

}
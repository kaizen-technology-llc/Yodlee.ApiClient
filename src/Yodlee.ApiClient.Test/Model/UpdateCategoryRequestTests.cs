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
    ///  Class for testing UpdateCategoryRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class UpdateCategoryRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for UpdateCategoryRequest
        //private UpdateCategoryRequest instance;

        public UpdateCategoryRequestTests()
        {
            // TODO uncomment below to create an instance of UpdateCategoryRequest
            //instance = new UpdateCategoryRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UpdateCategoryRequest
        /// </summary>
        [Fact]
        public void UpdateCategoryRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" UpdateCategoryRequest
            //Assert.IsType<UpdateCategoryRequest>(instance);
        }


        /// <summary>
        /// Test the property 'HighLevelCategoryName'
        /// </summary>
        [Fact]
        public void HighLevelCategoryNameTest()
        {
            // TODO unit test for the property 'HighLevelCategoryName'
        }
        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'Source'
        /// </summary>
        [Fact]
        public void SourceTest()
        {
            // TODO unit test for the property 'Source'
        }
        /// <summary>
        /// Test the property 'CategoryName'
        /// </summary>
        [Fact]
        public void CategoryNameTest()
        {
            // TODO unit test for the property 'CategoryName'
        }

    }

}
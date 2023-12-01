/*
 * Yodlee Core APIs
 *
 * This file describes the Yodlee Platform APIs using the swagger notation. You can use this swagger file to generate client side SDKs to the Yodlee Platform APIs for many different programming languages. Yodlee API v1.1 - Overview</a>.<br><br>You will have to set the header before making the API call. The following headers apply to all the APIs:<ul><li>Authorization: This header holds the access token</li> <li> Api-Version: 1.1</li></ul><b>Note</b>: If there are any API-specific headers, they are mentioned explicitly in the respective API's description.
 *
 * The version of the OpenAPI document: 1.1.0
 * Contact: developer@yodlee.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Api;
// uncomment below to import models
//using Yodlee.ApiClient.Model;

namespace Yodlee.ApiClient.Test.Api
{
    /// <summary>
    ///  Class for testing DataExtractsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DataExtractsApiTests : IDisposable
    {
        private DataExtractsApi instance;

        public DataExtractsApiTests()
        {
            instance = new DataExtractsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DataExtractsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DataExtractsApi
            //Assert.IsType<DataExtractsApi>(instance);
        }

        /// <summary>
        /// Test GetDataExtractsEvents
        /// </summary>
        [Fact]
        public void GetDataExtractsEventsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventName = null;
            //string fromDate = null;
            //string toDate = null;
            //var response = instance.GetDataExtractsEvents(eventName, fromDate, toDate);
            //Assert.IsType<DataExtractsEventResponse>(response);
        }

        /// <summary>
        /// Test GetDataExtractsUserData
        /// </summary>
        [Fact]
        public void GetDataExtractsUserDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fromDate = null;
            //string loginName = null;
            //string toDate = null;
            //var response = instance.GetDataExtractsUserData(fromDate, loginName, toDate);
            //Assert.IsType<DataExtractsUserDataResponse>(response);
        }
    }
}

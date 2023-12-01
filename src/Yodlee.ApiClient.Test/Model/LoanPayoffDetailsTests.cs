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
    ///  Class for testing LoanPayoffDetails
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class LoanPayoffDetailsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for LoanPayoffDetails
        //private LoanPayoffDetails instance;

        public LoanPayoffDetailsTests()
        {
            // TODO uncomment below to create an instance of LoanPayoffDetails
            //instance = new LoanPayoffDetails();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of LoanPayoffDetails
        /// </summary>
        [Fact]
        public void LoanPayoffDetailsInstanceTest()
        {
            // TODO uncomment below to test "IsType" LoanPayoffDetails
            //Assert.IsType<LoanPayoffDetails>(instance);
        }


        /// <summary>
        /// Test the property 'PayByDate'
        /// </summary>
        [Fact]
        public void PayByDateTest()
        {
            // TODO unit test for the property 'PayByDate'
        }
        /// <summary>
        /// Test the property 'PayoffAmount'
        /// </summary>
        [Fact]
        public void PayoffAmountTest()
        {
            // TODO unit test for the property 'PayoffAmount'
        }
        /// <summary>
        /// Test the property 'OutstandingBalance'
        /// </summary>
        [Fact]
        public void OutstandingBalanceTest()
        {
            // TODO unit test for the property 'OutstandingBalance'
        }

    }

}

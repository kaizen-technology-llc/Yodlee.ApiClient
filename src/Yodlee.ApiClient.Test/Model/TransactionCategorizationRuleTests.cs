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
    ///  Class for testing TransactionCategorizationRule
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TransactionCategorizationRuleTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for TransactionCategorizationRule
        //private TransactionCategorizationRule instance;

        public TransactionCategorizationRuleTests()
        {
            // TODO uncomment below to create an instance of TransactionCategorizationRule
            //instance = new TransactionCategorizationRule();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TransactionCategorizationRule
        /// </summary>
        [Fact]
        public void TransactionCategorizationRuleInstanceTest()
        {
            // TODO uncomment below to test "IsType" TransactionCategorizationRule
            //Assert.IsType<TransactionCategorizationRule>(instance);
        }


        /// <summary>
        /// Test the property 'RuleClauses'
        /// </summary>
        [Fact]
        public void RuleClausesTest()
        {
            // TODO unit test for the property 'RuleClauses'
        }
        /// <summary>
        /// Test the property 'UserDefinedRuleId'
        /// </summary>
        [Fact]
        public void UserDefinedRuleIdTest()
        {
            // TODO unit test for the property 'UserDefinedRuleId'
        }
        /// <summary>
        /// Test the property 'CategoryLevelId'
        /// </summary>
        [Fact]
        public void CategoryLevelIdTest()
        {
            // TODO unit test for the property 'CategoryLevelId'
        }
        /// <summary>
        /// Test the property 'TransactionCategorisationId'
        /// </summary>
        [Fact]
        public void TransactionCategorisationIdTest()
        {
            // TODO unit test for the property 'TransactionCategorisationId'
        }
        /// <summary>
        /// Test the property 'MemId'
        /// </summary>
        [Fact]
        public void MemIdTest()
        {
            // TODO unit test for the property 'MemId'
        }
        /// <summary>
        /// Test the property 'RulePriority'
        /// </summary>
        [Fact]
        public void RulePriorityTest()
        {
            // TODO unit test for the property 'RulePriority'
        }

    }

}

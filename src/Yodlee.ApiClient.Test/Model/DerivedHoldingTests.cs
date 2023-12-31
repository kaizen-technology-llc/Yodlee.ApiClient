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
    ///  Class for testing DerivedHolding
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DerivedHoldingTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DerivedHolding
        //private DerivedHolding instance;

        public DerivedHoldingTests()
        {
            // TODO uncomment below to create an instance of DerivedHolding
            //instance = new DerivedHolding();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DerivedHolding
        /// </summary>
        [Fact]
        public void DerivedHoldingInstanceTest()
        {
            // TODO uncomment below to test "IsType" DerivedHolding
            //Assert.IsType<DerivedHolding>(instance);
        }


        /// <summary>
        /// Test the property 'Symbol'
        /// </summary>
        [Fact]
        public void SymbolTest()
        {
            // TODO unit test for the property 'Symbol'
        }
        /// <summary>
        /// Test the property 'ExercisedQuantity'
        /// </summary>
        [Fact]
        public void ExercisedQuantityTest()
        {
            // TODO unit test for the property 'ExercisedQuantity'
        }
        /// <summary>
        /// Test the property 'CusipNumber'
        /// </summary>
        [Fact]
        public void CusipNumberTest()
        {
            // TODO unit test for the property 'CusipNumber'
        }
        /// <summary>
        /// Test the property 'AssetClassification'
        /// </summary>
        [Fact]
        public void AssetClassificationTest()
        {
            // TODO unit test for the property 'AssetClassification'
        }
        /// <summary>
        /// Test the property 'VestedQuantity'
        /// </summary>
        [Fact]
        public void VestedQuantityTest()
        {
            // TODO unit test for the property 'VestedQuantity'
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
        /// Test the property 'UnvestedValue'
        /// </summary>
        [Fact]
        public void UnvestedValueTest()
        {
            // TODO unit test for the property 'UnvestedValue'
        }
        /// <summary>
        /// Test the property 'SecurityStyle'
        /// </summary>
        [Fact]
        public void SecurityStyleTest()
        {
            // TODO unit test for the property 'SecurityStyle'
        }
        /// <summary>
        /// Test the property 'VestedValue'
        /// </summary>
        [Fact]
        public void VestedValueTest()
        {
            // TODO unit test for the property 'VestedValue'
        }
        /// <summary>
        /// Test the property 'OptionType'
        /// </summary>
        [Fact]
        public void OptionTypeTest()
        {
            // TODO unit test for the property 'OptionType'
        }
        /// <summary>
        /// Test the property 'LastUpdated'
        /// </summary>
        [Fact]
        public void LastUpdatedTest()
        {
            // TODO unit test for the property 'LastUpdated'
        }
        /// <summary>
        /// Test the property 'MatchStatus'
        /// </summary>
        [Fact]
        public void MatchStatusTest()
        {
            // TODO unit test for the property 'MatchStatus'
        }
        /// <summary>
        /// Test the property 'HoldingType'
        /// </summary>
        [Fact]
        public void HoldingTypeTest()
        {
            // TODO unit test for the property 'HoldingType'
        }
        /// <summary>
        /// Test the property 'MaturityDate'
        /// </summary>
        [Fact]
        public void MaturityDateTest()
        {
            // TODO unit test for the property 'MaturityDate'
        }
        /// <summary>
        /// Test the property 'Price'
        /// </summary>
        [Fact]
        public void PriceTest()
        {
            // TODO unit test for the property 'Price'
        }
        /// <summary>
        /// Test the property 'Term'
        /// </summary>
        [Fact]
        public void TermTest()
        {
            // TODO unit test for the property 'Term'
        }
        /// <summary>
        /// Test the property 'ContractQuantity'
        /// </summary>
        [Fact]
        public void ContractQuantityTest()
        {
            // TODO unit test for the property 'ContractQuantity'
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
        /// Test the property 'IsShort'
        /// </summary>
        [Fact]
        public void IsShortTest()
        {
            // TODO unit test for the property 'IsShort'
        }
        /// <summary>
        /// Test the property 'Value'
        /// </summary>
        [Fact]
        public void ValueTest()
        {
            // TODO unit test for the property 'Value'
        }
        /// <summary>
        /// Test the property 'ExpirationDate'
        /// </summary>
        [Fact]
        public void ExpirationDateTest()
        {
            // TODO unit test for the property 'ExpirationDate'
        }
        /// <summary>
        /// Test the property 'InterestRate'
        /// </summary>
        [Fact]
        public void InterestRateTest()
        {
            // TODO unit test for the property 'InterestRate'
        }
        /// <summary>
        /// Test the property 'Quantity'
        /// </summary>
        [Fact]
        public void QuantityTest()
        {
            // TODO unit test for the property 'Quantity'
        }
        /// <summary>
        /// Test the property 'AccruedInterest'
        /// </summary>
        [Fact]
        public void AccruedInterestTest()
        {
            // TODO unit test for the property 'AccruedInterest'
        }
        /// <summary>
        /// Test the property 'GrantDate'
        /// </summary>
        [Fact]
        public void GrantDateTest()
        {
            // TODO unit test for the property 'GrantDate'
        }
        /// <summary>
        /// Test the property 'Sedol'
        /// </summary>
        [Fact]
        public void SedolTest()
        {
            // TODO unit test for the property 'Sedol'
        }
        /// <summary>
        /// Test the property 'VestedSharesExercisable'
        /// </summary>
        [Fact]
        public void VestedSharesExercisableTest()
        {
            // TODO unit test for the property 'VestedSharesExercisable'
        }
        /// <summary>
        /// Test the property 'Spread'
        /// </summary>
        [Fact]
        public void SpreadTest()
        {
            // TODO unit test for the property 'Spread'
        }
        /// <summary>
        /// Test the property 'AccountId'
        /// </summary>
        [Fact]
        public void AccountIdTest()
        {
            // TODO unit test for the property 'AccountId'
        }
        /// <summary>
        /// Test the property 'EnrichedDescription'
        /// </summary>
        [Fact]
        public void EnrichedDescriptionTest()
        {
            // TODO unit test for the property 'EnrichedDescription'
        }
        /// <summary>
        /// Test the property 'CouponRate'
        /// </summary>
        [Fact]
        public void CouponRateTest()
        {
            // TODO unit test for the property 'CouponRate'
        }
        /// <summary>
        /// Test the property 'CreatedDate'
        /// </summary>
        [Fact]
        public void CreatedDateTest()
        {
            // TODO unit test for the property 'CreatedDate'
        }
        /// <summary>
        /// Test the property 'AccruedIncome'
        /// </summary>
        [Fact]
        public void AccruedIncomeTest()
        {
            // TODO unit test for the property 'AccruedIncome'
        }
        /// <summary>
        /// Test the property 'SecurityType'
        /// </summary>
        [Fact]
        public void SecurityTypeTest()
        {
            // TODO unit test for the property 'SecurityType'
        }
        /// <summary>
        /// Test the property 'ProviderAccountId'
        /// </summary>
        [Fact]
        public void ProviderAccountIdTest()
        {
            // TODO unit test for the property 'ProviderAccountId'
        }
        /// <summary>
        /// Test the property 'UnvestedQuantity'
        /// </summary>
        [Fact]
        public void UnvestedQuantityTest()
        {
            // TODO unit test for the property 'UnvestedQuantity'
        }
        /// <summary>
        /// Test the property 'CostBasis'
        /// </summary>
        [Fact]
        public void CostBasisTest()
        {
            // TODO unit test for the property 'CostBasis'
        }
        /// <summary>
        /// Test the property 'VestingDate'
        /// </summary>
        [Fact]
        public void VestingDateTest()
        {
            // TODO unit test for the property 'VestingDate'
        }
        /// <summary>
        /// Test the property 'Isin'
        /// </summary>
        [Fact]
        public void IsinTest()
        {
            // TODO unit test for the property 'Isin'
        }
        /// <summary>
        /// Test the property 'StrikePrice'
        /// </summary>
        [Fact]
        public void StrikePriceTest()
        {
            // TODO unit test for the property 'StrikePrice'
        }

    }

}

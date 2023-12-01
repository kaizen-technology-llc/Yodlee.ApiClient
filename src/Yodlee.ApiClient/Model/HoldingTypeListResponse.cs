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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Yodlee.ApiClient.Client.OpenAPIDateConverter;

namespace Yodlee.ApiClient.Model
{
    /// <summary>
    /// HoldingTypeListResponse
    /// </summary>
    [DataContract(Name = "HoldingTypeListResponse")]
    public partial class HoldingTypeListResponse : IEquatable<HoldingTypeListResponse>, IValidatableObject
    {
        /// <summary>
        /// Defines HoldingType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HoldingTypeEnum
        {
            /// <summary>
            /// Enum Stock for value: stock
            /// </summary>
            [EnumMember(Value = "stock")]
            Stock = 1,

            /// <summary>
            /// Enum MutualFund for value: mutualFund
            /// </summary>
            [EnumMember(Value = "mutualFund")]
            MutualFund = 2,

            /// <summary>
            /// Enum Bond for value: bond
            /// </summary>
            [EnumMember(Value = "bond")]
            Bond = 3,

            /// <summary>
            /// Enum CD for value: CD
            /// </summary>
            [EnumMember(Value = "CD")]
            CD = 4,

            /// <summary>
            /// Enum Option for value: option
            /// </summary>
            [EnumMember(Value = "option")]
            Option = 5,

            /// <summary>
            /// Enum MoneyMarketFund for value: moneyMarketFund
            /// </summary>
            [EnumMember(Value = "moneyMarketFund")]
            MoneyMarketFund = 6,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 7,

            /// <summary>
            /// Enum Remic for value: remic
            /// </summary>
            [EnumMember(Value = "remic")]
            Remic = 8,

            /// <summary>
            /// Enum Future for value: future
            /// </summary>
            [EnumMember(Value = "future")]
            Future = 9,

            /// <summary>
            /// Enum Commodity for value: commodity
            /// </summary>
            [EnumMember(Value = "commodity")]
            Commodity = 10,

            /// <summary>
            /// Enum Currency for value: currency
            /// </summary>
            [EnumMember(Value = "currency")]
            Currency = 11,

            /// <summary>
            /// Enum UnitInvestmentTrust for value: unitInvestmentTrust
            /// </summary>
            [EnumMember(Value = "unitInvestmentTrust")]
            UnitInvestmentTrust = 12,

            /// <summary>
            /// Enum EmployeeStockOption for value: employeeStockOption
            /// </summary>
            [EnumMember(Value = "employeeStockOption")]
            EmployeeStockOption = 13,

            /// <summary>
            /// Enum InsuranceAnnuity for value: insuranceAnnuity
            /// </summary>
            [EnumMember(Value = "insuranceAnnuity")]
            InsuranceAnnuity = 14,

            /// <summary>
            /// Enum Unknown for value: unknown
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown = 15,

            /// <summary>
            /// Enum PreferredStock for value: preferredStock
            /// </summary>
            [EnumMember(Value = "preferredStock")]
            PreferredStock = 16,

            /// <summary>
            /// Enum ETF for value: ETF
            /// </summary>
            [EnumMember(Value = "ETF")]
            ETF = 17,

            /// <summary>
            /// Enum Warrants for value: warrants
            /// </summary>
            [EnumMember(Value = "warrants")]
            Warrants = 18,

            /// <summary>
            /// Enum DigitalAsset for value: digitalAsset
            /// </summary>
            [EnumMember(Value = "digitalAsset")]
            DigitalAsset = 19

        }



        /// <summary>
        /// Gets or Sets HoldingType
        /// </summary>
        [DataMember(Name = "holdingType", EmitDefaultValue = false)]
        public List<HoldingTypeEnum> HoldingType { get; set; }

        /// <summary>
        /// Returns false as HoldingType should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeHoldingType()
        {
            return false;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="HoldingTypeListResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public HoldingTypeListResponse()
        {
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HoldingTypeListResponse {\n");
            sb.Append("  HoldingType: ").Append(HoldingType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as HoldingTypeListResponse);
        }

        /// <summary>
        /// Returns true if HoldingTypeListResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of HoldingTypeListResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HoldingTypeListResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.HoldingType == input.HoldingType ||
                    this.HoldingType.SequenceEqual(input.HoldingType)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.HoldingType.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

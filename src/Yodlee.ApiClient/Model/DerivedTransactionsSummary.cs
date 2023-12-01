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
    /// DerivedTransactionsSummary
    /// </summary>
    [DataContract(Name = "DerivedTransactionsSummary")]
    public partial class DerivedTransactionsSummary : IEquatable<DerivedTransactionsSummary>, IValidatableObject
    {
        /// <summary>
        /// Type of categories provided by transactions/categories service.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, bank, investment&lt;br&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt;
        /// </summary>
        /// <value>Type of categories provided by transactions/categories service.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, bank, investment&lt;br&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CategoryTypeEnum
        {
            /// <summary>
            /// Enum TRANSFER for value: TRANSFER
            /// </summary>
            [EnumMember(Value = "TRANSFER")]
            TRANSFER = 1,

            /// <summary>
            /// Enum DEFERREDCOMPENSATION for value: DEFERRED_COMPENSATION
            /// </summary>
            [EnumMember(Value = "DEFERRED_COMPENSATION")]
            DEFERREDCOMPENSATION = 2,

            /// <summary>
            /// Enum UNCATEGORIZE for value: UNCATEGORIZE
            /// </summary>
            [EnumMember(Value = "UNCATEGORIZE")]
            UNCATEGORIZE = 3,

            /// <summary>
            /// Enum INCOME for value: INCOME
            /// </summary>
            [EnumMember(Value = "INCOME")]
            INCOME = 4,

            /// <summary>
            /// Enum EXPENSE for value: EXPENSE
            /// </summary>
            [EnumMember(Value = "EXPENSE")]
            EXPENSE = 5

        }


        /// <summary>
        /// Type of categories provided by transactions/categories service.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, bank, investment&lt;br&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt;
        /// </summary>
        /// <value>Type of categories provided by transactions/categories service.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, bank, investment&lt;br&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt;</value>
        [DataMember(Name = "categoryType", EmitDefaultValue = false)]
        public CategoryTypeEnum? CategoryType { get; set; }

        /// <summary>
        /// Returns false as CategoryType should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCategoryType()
        {
            return false;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="DerivedTransactionsSummary" /> class.
        /// </summary>
        /// <param name="creditTotal">creditTotal.</param>
        /// <param name="links">links.</param>
        /// <param name="debitTotal">debitTotal.</param>
        public DerivedTransactionsSummary(Money creditTotal = default(Money), DerivedTransactionsLinks links = default(DerivedTransactionsLinks), Money debitTotal = default(Money))
        {
            this.CreditTotal = creditTotal;
            this.Links = links;
            this.DebitTotal = debitTotal;
        }

        /// <summary>
        /// Summary of transaction amouts at category level.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, bank, investment&lt;br&gt;
        /// </summary>
        /// <value>Summary of transaction amouts at category level.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, bank, investment&lt;br&gt;</value>
        [DataMember(Name = "categorySummary", EmitDefaultValue = false)]
        public List<DerivedCategorySummary> CategorySummary { get; private set; }

        /// <summary>
        /// Returns false as CategorySummary should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCategorySummary()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CreditTotal
        /// </summary>
        [DataMember(Name = "creditTotal", EmitDefaultValue = false)]
        public Money CreditTotal { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public DerivedTransactionsLinks Links { get; set; }

        /// <summary>
        /// Gets or Sets DebitTotal
        /// </summary>
        [DataMember(Name = "debitTotal", EmitDefaultValue = false)]
        public Money DebitTotal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DerivedTransactionsSummary {\n");
            sb.Append("  CategoryType: ").Append(CategoryType).Append("\n");
            sb.Append("  CategorySummary: ").Append(CategorySummary).Append("\n");
            sb.Append("  CreditTotal: ").Append(CreditTotal).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  DebitTotal: ").Append(DebitTotal).Append("\n");
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
            return this.Equals(input as DerivedTransactionsSummary);
        }

        /// <summary>
        /// Returns true if DerivedTransactionsSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of DerivedTransactionsSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DerivedTransactionsSummary input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CategoryType == input.CategoryType ||
                    this.CategoryType.Equals(input.CategoryType)
                ) && 
                (
                    this.CategorySummary == input.CategorySummary ||
                    this.CategorySummary != null &&
                    input.CategorySummary != null &&
                    this.CategorySummary.SequenceEqual(input.CategorySummary)
                ) && 
                (
                    this.CreditTotal == input.CreditTotal ||
                    (this.CreditTotal != null &&
                    this.CreditTotal.Equals(input.CreditTotal))
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this.DebitTotal == input.DebitTotal ||
                    (this.DebitTotal != null &&
                    this.DebitTotal.Equals(input.DebitTotal))
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
                hashCode = (hashCode * 59) + this.CategoryType.GetHashCode();
                if (this.CategorySummary != null)
                {
                    hashCode = (hashCode * 59) + this.CategorySummary.GetHashCode();
                }
                if (this.CreditTotal != null)
                {
                    hashCode = (hashCode * 59) + this.CreditTotal.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                if (this.DebitTotal != null)
                {
                    hashCode = (hashCode * 59) + this.DebitTotal.GetHashCode();
                }
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

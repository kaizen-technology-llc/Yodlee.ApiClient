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
    /// VerificationBankTransferCode
    /// </summary>
    [DataContract(Name = "VerificationBankTransferCode")]
    public partial class VerificationBankTransferCode : IEquatable<VerificationBankTransferCode>, IValidatableObject
    {
        /// <summary>
        /// The bank transfer code type varies depending on the region of the account origination. &lt;br&gt;&lt;b&gt;Account Type&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, investment&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;br&gt;&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;POST verification&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt;
        /// </summary>
        /// <value>The bank transfer code type varies depending on the region of the account origination. &lt;br&gt;&lt;b&gt;Account Type&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, investment&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;br&gt;&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;POST verification&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum BSB for value: BSB
            /// </summary>
            [EnumMember(Value = "BSB")]
            BSB = 1,

            /// <summary>
            /// Enum IFSC for value: IFSC
            /// </summary>
            [EnumMember(Value = "IFSC")]
            IFSC = 2,

            /// <summary>
            /// Enum ROUTINGNUMBER for value: ROUTING_NUMBER
            /// </summary>
            [EnumMember(Value = "ROUTING_NUMBER")]
            ROUTINGNUMBER = 3,

            /// <summary>
            /// Enum SORTCODE for value: SORT_CODE
            /// </summary>
            [EnumMember(Value = "SORT_CODE")]
            SORTCODE = 4

        }


        /// <summary>
        /// The bank transfer code type varies depending on the region of the account origination. &lt;br&gt;&lt;b&gt;Account Type&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, investment&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;br&gt;&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;POST verification&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt;
        /// </summary>
        /// <value>The bank transfer code type varies depending on the region of the account origination. &lt;br&gt;&lt;b&gt;Account Type&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, investment&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;br&gt;&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;POST verification&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt;</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VerificationBankTransferCode" /> class.
        /// </summary>
        /// <param name="id">The FI&#39;s branch identification number.Additional Details: The routing number of the bank account in the United States. For non-United States accounts, it is the IFSC code (India), BSB number (Australia), and sort code (United Kingdom). &lt;br&gt;&lt;b&gt;Account Type&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, investment&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;br&gt;&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;POST verification&lt;/li&gt;&lt;/ul&gt;.</param>
        /// <param name="type">The bank transfer code type varies depending on the region of the account origination. &lt;br&gt;&lt;b&gt;Account Type&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, investment&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;br&gt;&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;POST verification&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt;.</param>
        public VerificationBankTransferCode(string id = default(string), TypeEnum? type = default(TypeEnum?))
        {
            this.Id = id;
            this.Type = type;
        }

        /// <summary>
        /// The FI&#39;s branch identification number.Additional Details: The routing number of the bank account in the United States. For non-United States accounts, it is the IFSC code (India), BSB number (Australia), and sort code (United Kingdom). &lt;br&gt;&lt;b&gt;Account Type&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, investment&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;br&gt;&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;POST verification&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <value>The FI&#39;s branch identification number.Additional Details: The routing number of the bank account in the United States. For non-United States accounts, it is the IFSC code (India), BSB number (Australia), and sort code (United Kingdom). &lt;br&gt;&lt;b&gt;Account Type&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, investment&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;br&gt;&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;li&gt;POST verification&lt;/li&gt;&lt;/ul&gt;</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VerificationBankTransferCode {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as VerificationBankTransferCode);
        }

        /// <summary>
        /// Returns true if VerificationBankTransferCode instances are equal
        /// </summary>
        /// <param name="input">Instance of VerificationBankTransferCode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VerificationBankTransferCode input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
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

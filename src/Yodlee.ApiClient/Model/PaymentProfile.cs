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
    /// PaymentProfile
    /// </summary>
    [DataContract(Name = "PaymentProfile")]
    public partial class PaymentProfile : IEquatable<PaymentProfile>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentProfile" /> class.
        /// </summary>
        /// <param name="identifier">identifier.</param>
        /// <param name="address">The address of the lender to which the monthly payments or the loan payoff amount should be paid. &lt;br&gt;&lt;b&gt;Additional Details:&lt;/b&gt;The address field applies only to the student loan account type.&lt;br&gt;&lt;b&gt;Account Type&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: loan&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;br&gt;&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;/ul&gt;.</param>
        /// <param name="paymentBankTransferCode">paymentBankTransferCode.</param>
        public PaymentProfile(PaymentIdentifier identifier = default(PaymentIdentifier), List<AccountAddress> address = default(List<AccountAddress>), PaymentBankTransferCode paymentBankTransferCode = default(PaymentBankTransferCode))
        {
            this.Identifier = identifier;
            this.Address = address;
            this.PaymentBankTransferCode = paymentBankTransferCode;
        }

        /// <summary>
        /// Gets or Sets Identifier
        /// </summary>
        [DataMember(Name = "identifier", EmitDefaultValue = false)]
        public PaymentIdentifier Identifier { get; set; }

        /// <summary>
        /// The address of the lender to which the monthly payments or the loan payoff amount should be paid. &lt;br&gt;&lt;b&gt;Additional Details:&lt;/b&gt;The address field applies only to the student loan account type.&lt;br&gt;&lt;b&gt;Account Type&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: loan&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;br&gt;&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <value>The address of the lender to which the monthly payments or the loan payoff amount should be paid. &lt;br&gt;&lt;b&gt;Additional Details:&lt;/b&gt;The address field applies only to the student loan account type.&lt;br&gt;&lt;b&gt;Account Type&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: loan&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;br&gt;&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;/ul&gt;</value>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public List<AccountAddress> Address { get; set; }

        /// <summary>
        /// Gets or Sets PaymentBankTransferCode
        /// </summary>
        [DataMember(Name = "paymentBankTransferCode", EmitDefaultValue = false)]
        public PaymentBankTransferCode PaymentBankTransferCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentProfile {\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  PaymentBankTransferCode: ").Append(PaymentBankTransferCode).Append("\n");
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
            return this.Equals(input as PaymentProfile);
        }

        /// <summary>
        /// Returns true if PaymentProfile instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentProfile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentProfile input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.Address == input.Address ||
                    this.Address != null &&
                    input.Address != null &&
                    this.Address.SequenceEqual(input.Address)
                ) && 
                (
                    this.PaymentBankTransferCode == input.PaymentBankTransferCode ||
                    (this.PaymentBankTransferCode != null &&
                    this.PaymentBankTransferCode.Equals(input.PaymentBankTransferCode))
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
                if (this.Identifier != null)
                {
                    hashCode = (hashCode * 59) + this.Identifier.GetHashCode();
                }
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.PaymentBankTransferCode != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentBankTransferCode.GetHashCode();
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

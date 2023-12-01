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
    /// TransactionDays
    /// </summary>
    [DataContract(Name = "TransactionDays")]
    public partial class TransactionDays : IEquatable<TransactionDays>, IValidatableObject
    {
        /// <summary>
        /// Defines FullAccountNumberFields
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FullAccountNumberFieldsEnum
        {
            /// <summary>
            /// Enum PaymentAccountNumber for value: paymentAccountNumber
            /// </summary>
            [EnumMember(Value = "paymentAccountNumber")]
            PaymentAccountNumber = 1,

            /// <summary>
            /// Enum UnmaskedAccountNumber for value: unmaskedAccountNumber
            /// </summary>
            [EnumMember(Value = "unmaskedAccountNumber")]
            UnmaskedAccountNumber = 2

        }



        /// <summary>
        /// Gets or Sets FullAccountNumberFields
        /// </summary>
        [DataMember(Name = "fullAccountNumberFields", EmitDefaultValue = false)]
        public List<FullAccountNumberFieldsEnum> FullAccountNumberFields { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionDays" /> class.
        /// </summary>
        /// <param name="fullAccountNumberFields">fullAccountNumberFields.</param>
        /// <param name="numberOfTransactionDays">numberOfTransactionDays.</param>
        public TransactionDays(List<FullAccountNumberFieldsEnum> fullAccountNumberFields = default(List<FullAccountNumberFieldsEnum>), int numberOfTransactionDays = default(int))
        {
            this.FullAccountNumberFields = fullAccountNumberFields;
            this.NumberOfTransactionDays = numberOfTransactionDays;
        }

        /// <summary>
        /// Gets or Sets NumberOfTransactionDays
        /// </summary>
        [DataMember(Name = "numberOfTransactionDays", EmitDefaultValue = false)]
        public int NumberOfTransactionDays { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionDays {\n");
            sb.Append("  FullAccountNumberFields: ").Append(FullAccountNumberFields).Append("\n");
            sb.Append("  NumberOfTransactionDays: ").Append(NumberOfTransactionDays).Append("\n");
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
            return this.Equals(input as TransactionDays);
        }

        /// <summary>
        /// Returns true if TransactionDays instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionDays to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionDays input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FullAccountNumberFields == input.FullAccountNumberFields ||
                    this.FullAccountNumberFields.SequenceEqual(input.FullAccountNumberFields)
                ) && 
                (
                    this.NumberOfTransactionDays == input.NumberOfTransactionDays ||
                    this.NumberOfTransactionDays.Equals(input.NumberOfTransactionDays)
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
                hashCode = (hashCode * 59) + this.FullAccountNumberFields.GetHashCode();
                hashCode = (hashCode * 59) + this.NumberOfTransactionDays.GetHashCode();
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
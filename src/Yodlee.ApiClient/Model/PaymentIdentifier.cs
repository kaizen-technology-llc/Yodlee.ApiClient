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
    /// PaymentIdentifier
    /// </summary>
    [DataContract(Name = "PaymentIdentifier")]
    public partial class PaymentIdentifier : IEquatable<PaymentIdentifier>, IValidatableObject
    {
        /// <summary>
        /// Type of Identifier
        /// </summary>
        /// <value>Type of Identifier</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum REFERENCENUMBER for value: REFERENCE_NUMBER
            /// </summary>
            [EnumMember(Value = "REFERENCE_NUMBER")]
            REFERENCENUMBER = 1,

            /// <summary>
            /// Enum PLATFORMCODE for value: PLATFORM_CODE
            /// </summary>
            [EnumMember(Value = "PLATFORM_CODE")]
            PLATFORMCODE = 2

        }


        /// <summary>
        /// Type of Identifier
        /// </summary>
        /// <value>Type of Identifier</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Returns false as Type should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeType()
        {
            return false;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentIdentifier" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentIdentifier()
        {
        }

        /// <summary>
        /// Value of the identifier
        /// </summary>
        /// <value>Value of the identifier</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; private set; }

        /// <summary>
        /// Returns false as Value should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeValue()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentIdentifier {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as PaymentIdentifier);
        }

        /// <summary>
        /// Returns true if PaymentIdentifier instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentIdentifier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentIdentifier input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
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

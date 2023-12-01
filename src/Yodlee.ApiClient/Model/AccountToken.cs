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
    /// AccountToken
    /// </summary>
    [DataContract(Name = "AccountToken")]
    public partial class AccountToken : IEquatable<AccountToken>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountToken" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public AccountToken()
        {
        }

        /// <summary>
        /// The unique token that the payment partner can use to make API request to the Envestnet | Yodlee system.
        /// </summary>
        /// <value>The unique token that the payment partner can use to make API request to the Envestnet | Yodlee system.</value>
        [DataMember(Name = "processorToken", EmitDefaultValue = false)]
        public string ProcessorToken { get; private set; }

        /// <summary>
        /// Returns false as ProcessorToken should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeProcessorToken()
        {
            return false;
        }
        /// <summary>
        /// The unique identifier for the user&#39;s account.
        /// </summary>
        /// <value>The unique identifier for the user&#39;s account.</value>
        [DataMember(Name = "accountId", EmitDefaultValue = false)]
        public long AccountId { get; private set; }

        /// <summary>
        /// Returns false as AccountId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAccountId()
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
            sb.Append("class AccountToken {\n");
            sb.Append("  ProcessorToken: ").Append(ProcessorToken).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
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
            return this.Equals(input as AccountToken);
        }

        /// <summary>
        /// Returns true if AccountToken instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountToken input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ProcessorToken == input.ProcessorToken ||
                    (this.ProcessorToken != null &&
                    this.ProcessorToken.Equals(input.ProcessorToken))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    this.AccountId.Equals(input.AccountId)
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
                if (this.ProcessorToken != null)
                {
                    hashCode = (hashCode * 59) + this.ProcessorToken.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
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
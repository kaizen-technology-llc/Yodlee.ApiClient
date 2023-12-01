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
    /// ProviderAccountResponse
    /// </summary>
    [DataContract(Name = "ProviderAccountResponse")]
    public partial class ProviderAccountResponse : IEquatable<ProviderAccountResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderAccountResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ProviderAccountResponse()
        {
        }

        /// <summary>
        /// Gets or Sets ProviderAccount
        /// </summary>
        [DataMember(Name = "providerAccount", EmitDefaultValue = false)]
        public List<ProviderAccount> ProviderAccount { get; private set; }

        /// <summary>
        /// Returns false as ProviderAccount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeProviderAccount()
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
            sb.Append("class ProviderAccountResponse {\n");
            sb.Append("  ProviderAccount: ").Append(ProviderAccount).Append("\n");
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
            return this.Equals(input as ProviderAccountResponse);
        }

        /// <summary>
        /// Returns true if ProviderAccountResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ProviderAccountResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProviderAccountResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ProviderAccount == input.ProviderAccount ||
                    this.ProviderAccount != null &&
                    input.ProviderAccount != null &&
                    this.ProviderAccount.SequenceEqual(input.ProviderAccount)
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
                if (this.ProviderAccount != null)
                {
                    hashCode = (hashCode * 59) + this.ProviderAccount.GetHashCode();
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

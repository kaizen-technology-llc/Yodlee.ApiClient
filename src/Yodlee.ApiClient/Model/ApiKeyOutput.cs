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
    /// ApiKeyOutput
    /// </summary>
    [DataContract(Name = "ApiKeyOutput")]
    public partial class ApiKeyOutput : IEquatable<ApiKeyOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyOutput" /> class.
        /// </summary>
        /// <param name="expiresIn">Time in seconds after which the JWT token created for users expires.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET /auth/apiKey&lt;/li&gt;&lt;li&gt;POST /auth/apiKey&lt;/li&gt;&lt;/ul&gt;.</param>
        /// <param name="createdDate">The date on which the apiKey was created for the customer.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET /auth/apiKey&lt;/li&gt;&lt;li&gt;POST /auth/apiKey&lt;/li&gt;&lt;/ul&gt;.</param>
        /// <param name="publicKey">Public key uploaded by the customer while generating ApiKey.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET /auth/apiKey&lt;/li&gt;&lt;li&gt;POST /auth/apiKey&lt;/li&gt;&lt;/ul&gt;.</param>
        /// <param name="key">ApiKey or the issuer key used to generate the JWT token for authentication.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET /auth/apiKey&lt;/li&gt;&lt;li&gt;POST /auth/apiKey&lt;/li&gt;&lt;/ul&gt;.</param>
        public ApiKeyOutput(long expiresIn = default(long), string createdDate = default(string), string publicKey = default(string), string key = default(string))
        {
            this.ExpiresIn = expiresIn;
            this.CreatedDate = createdDate;
            this.PublicKey = publicKey;
            this.Key = key;
        }

        /// <summary>
        /// Time in seconds after which the JWT token created for users expires.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET /auth/apiKey&lt;/li&gt;&lt;li&gt;POST /auth/apiKey&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <value>Time in seconds after which the JWT token created for users expires.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET /auth/apiKey&lt;/li&gt;&lt;li&gt;POST /auth/apiKey&lt;/li&gt;&lt;/ul&gt;</value>
        [DataMember(Name = "expiresIn", EmitDefaultValue = false)]
        public long ExpiresIn { get; set; }

        /// <summary>
        /// The date on which the apiKey was created for the customer.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET /auth/apiKey&lt;/li&gt;&lt;li&gt;POST /auth/apiKey&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <value>The date on which the apiKey was created for the customer.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET /auth/apiKey&lt;/li&gt;&lt;li&gt;POST /auth/apiKey&lt;/li&gt;&lt;/ul&gt;</value>
        [DataMember(Name = "createdDate", EmitDefaultValue = false)]
        public string CreatedDate { get; set; }

        /// <summary>
        /// Public key uploaded by the customer while generating ApiKey.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET /auth/apiKey&lt;/li&gt;&lt;li&gt;POST /auth/apiKey&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <value>Public key uploaded by the customer while generating ApiKey.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET /auth/apiKey&lt;/li&gt;&lt;li&gt;POST /auth/apiKey&lt;/li&gt;&lt;/ul&gt;</value>
        [DataMember(Name = "publicKey", EmitDefaultValue = false)]
        public string PublicKey { get; set; }

        /// <summary>
        /// ApiKey or the issuer key used to generate the JWT token for authentication.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET /auth/apiKey&lt;/li&gt;&lt;li&gt;POST /auth/apiKey&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <value>ApiKey or the issuer key used to generate the JWT token for authentication.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET /auth/apiKey&lt;/li&gt;&lt;li&gt;POST /auth/apiKey&lt;/li&gt;&lt;/ul&gt;</value>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApiKeyOutput {\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
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
            return this.Equals(input as ApiKeyOutput);
        }

        /// <summary>
        /// Returns true if ApiKeyOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiKeyOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiKeyOutput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ExpiresIn == input.ExpiresIn ||
                    this.ExpiresIn.Equals(input.ExpiresIn)
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.PublicKey == input.PublicKey ||
                    (this.PublicKey != null &&
                    this.PublicKey.Equals(input.PublicKey))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
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
                hashCode = (hashCode * 59) + this.ExpiresIn.GetHashCode();
                if (this.CreatedDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedDate.GetHashCode();
                }
                if (this.PublicKey != null)
                {
                    hashCode = (hashCode * 59) + this.PublicKey.GetHashCode();
                }
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
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
            // PublicKey (string) maxLength
            if (this.PublicKey != null && this.PublicKey.Length > 2147483647)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PublicKey, length must be less than 2147483647.", new [] { "PublicKey" });
            }

            // PublicKey (string) minLength
            if (this.PublicKey != null && this.PublicKey.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PublicKey, length must be greater than 1.", new [] { "PublicKey" });
            }

            yield break;
        }
    }

}

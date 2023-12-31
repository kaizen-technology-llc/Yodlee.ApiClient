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
    /// RenewConsentRequest
    /// </summary>
    [DataContract(Name = "RenewConsentRequest")]
    public partial class RenewConsentRequest : IEquatable<RenewConsentRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenewConsentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RenewConsentRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RenewConsentRequest" /> class.
        /// </summary>
        /// <param name="preferences">preferences.</param>
        /// <param name="renewal">renewal.</param>
        /// <param name="clientTrustedAdvisor">describes information of client trusted advisor. (required).</param>
        public RenewConsentRequest(RenewConsentPreferences preferences = default(RenewConsentPreferences), RenewalConsent renewal = default(RenewalConsent), List<ClientTrustedAdvisor> clientTrustedAdvisor = default(List<ClientTrustedAdvisor>))
        {
            // to ensure "clientTrustedAdvisor" is required (not null)
            if (clientTrustedAdvisor == null)
            {
                throw new ArgumentNullException("clientTrustedAdvisor is a required property for RenewConsentRequest and cannot be null");
            }
            this.ClientTrustedAdvisor = clientTrustedAdvisor;
            this.Preferences = preferences;
            this.Renewal = renewal;
        }

        /// <summary>
        /// Gets or Sets Preferences
        /// </summary>
        [DataMember(Name = "preferences", EmitDefaultValue = false)]
        public RenewConsentPreferences Preferences { get; set; }

        /// <summary>
        /// Gets or Sets Renewal
        /// </summary>
        [DataMember(Name = "renewal", EmitDefaultValue = false)]
        public RenewalConsent Renewal { get; set; }

        /// <summary>
        /// describes information of client trusted advisor.
        /// </summary>
        /// <value>describes information of client trusted advisor.</value>
        [DataMember(Name = "clientTrustedAdvisor", IsRequired = true, EmitDefaultValue = true)]
        public List<ClientTrustedAdvisor> ClientTrustedAdvisor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RenewConsentRequest {\n");
            sb.Append("  Preferences: ").Append(Preferences).Append("\n");
            sb.Append("  Renewal: ").Append(Renewal).Append("\n");
            sb.Append("  ClientTrustedAdvisor: ").Append(ClientTrustedAdvisor).Append("\n");
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
            return this.Equals(input as RenewConsentRequest);
        }

        /// <summary>
        /// Returns true if RenewConsentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RenewConsentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RenewConsentRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Preferences == input.Preferences ||
                    (this.Preferences != null &&
                    this.Preferences.Equals(input.Preferences))
                ) && 
                (
                    this.Renewal == input.Renewal ||
                    (this.Renewal != null &&
                    this.Renewal.Equals(input.Renewal))
                ) && 
                (
                    this.ClientTrustedAdvisor == input.ClientTrustedAdvisor ||
                    this.ClientTrustedAdvisor != null &&
                    input.ClientTrustedAdvisor != null &&
                    this.ClientTrustedAdvisor.SequenceEqual(input.ClientTrustedAdvisor)
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
                if (this.Preferences != null)
                {
                    hashCode = (hashCode * 59) + this.Preferences.GetHashCode();
                }
                if (this.Renewal != null)
                {
                    hashCode = (hashCode * 59) + this.Renewal.GetHashCode();
                }
                if (this.ClientTrustedAdvisor != null)
                {
                    hashCode = (hashCode * 59) + this.ClientTrustedAdvisor.GetHashCode();
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

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
    /// UserDataTreatment
    /// </summary>
    [DataContract(Name = "UserDataTreatment")]
    public partial class UserDataTreatment : IEquatable<UserDataTreatment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserDataTreatment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserDataTreatment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserDataTreatment" /> class.
        /// </summary>
        /// <param name="dataHandling">dataHandling (required).</param>
        /// <param name="cdrPolicy">cdrPolicy (required).</param>
        /// <param name="description">After we have finished using your data or you have withdraw your consent to use the data, it will be de-identified as per our (required).</param>
        public UserDataTreatment(DataHandling dataHandling = default(DataHandling), CdrPolicy cdrPolicy = default(CdrPolicy), string description = default(string))
        {
            // to ensure "dataHandling" is required (not null)
            if (dataHandling == null)
            {
                throw new ArgumentNullException("dataHandling is a required property for UserDataTreatment and cannot be null");
            }
            this.DataHandling = dataHandling;
            // to ensure "cdrPolicy" is required (not null)
            if (cdrPolicy == null)
            {
                throw new ArgumentNullException("cdrPolicy is a required property for UserDataTreatment and cannot be null");
            }
            this.CdrPolicy = cdrPolicy;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for UserDataTreatment and cannot be null");
            }
            this.Description = description;
        }

        /// <summary>
        /// Gets or Sets DataHandling
        /// </summary>
        [DataMember(Name = "dataHandling", IsRequired = true, EmitDefaultValue = true)]
        public DataHandling DataHandling { get; set; }

        /// <summary>
        /// Gets or Sets CdrPolicy
        /// </summary>
        [DataMember(Name = "cdrPolicy", IsRequired = true, EmitDefaultValue = true)]
        public CdrPolicy CdrPolicy { get; set; }

        /// <summary>
        /// After we have finished using your data or you have withdraw your consent to use the data, it will be de-identified as per our
        /// </summary>
        /// <value>After we have finished using your data or you have withdraw your consent to use the data, it will be de-identified as per our</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserDataTreatment {\n");
            sb.Append("  DataHandling: ").Append(DataHandling).Append("\n");
            sb.Append("  CdrPolicy: ").Append(CdrPolicy).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as UserDataTreatment);
        }

        /// <summary>
        /// Returns true if UserDataTreatment instances are equal
        /// </summary>
        /// <param name="input">Instance of UserDataTreatment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserDataTreatment input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DataHandling == input.DataHandling ||
                    (this.DataHandling != null &&
                    this.DataHandling.Equals(input.DataHandling))
                ) && 
                (
                    this.CdrPolicy == input.CdrPolicy ||
                    (this.CdrPolicy != null &&
                    this.CdrPolicy.Equals(input.CdrPolicy))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.DataHandling != null)
                {
                    hashCode = (hashCode * 59) + this.DataHandling.GetHashCode();
                }
                if (this.CdrPolicy != null)
                {
                    hashCode = (hashCode * 59) + this.CdrPolicy.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
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

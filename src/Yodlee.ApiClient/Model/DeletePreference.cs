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
    /// DeletePreference
    /// </summary>
    [DataContract(Name = "DeletePreference")]
    public partial class DeletePreference : IEquatable<DeletePreference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeletePreference" /> class.
        /// </summary>
        /// <param name="description">Delete Preference Descritption.</param>
        /// <param name="alternateDescription">Delete Preference Alternate Descritption.</param>
        /// <param name="labelDescription">Delete Preference LabelDescritption.</param>
        public DeletePreference(string description = default(string), string alternateDescription = default(string), string labelDescription = default(string))
        {
            this.Description = description;
            this.AlternateDescription = alternateDescription;
            this.LabelDescription = labelDescription;
        }

        /// <summary>
        /// Delete Preference Descritption
        /// </summary>
        /// <value>Delete Preference Descritption</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Delete Preference Alternate Descritption
        /// </summary>
        /// <value>Delete Preference Alternate Descritption</value>
        [DataMember(Name = "alternateDescription", EmitDefaultValue = false)]
        public string AlternateDescription { get; set; }

        /// <summary>
        /// Delete Preference LabelDescritption
        /// </summary>
        /// <value>Delete Preference LabelDescritption</value>
        [DataMember(Name = "labelDescription", EmitDefaultValue = false)]
        public string LabelDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeletePreference {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  AlternateDescription: ").Append(AlternateDescription).Append("\n");
            sb.Append("  LabelDescription: ").Append(LabelDescription).Append("\n");
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
            return this.Equals(input as DeletePreference);
        }

        /// <summary>
        /// Returns true if DeletePreference instances are equal
        /// </summary>
        /// <param name="input">Instance of DeletePreference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeletePreference input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.AlternateDescription == input.AlternateDescription ||
                    (this.AlternateDescription != null &&
                    this.AlternateDescription.Equals(input.AlternateDescription))
                ) && 
                (
                    this.LabelDescription == input.LabelDescription ||
                    (this.LabelDescription != null &&
                    this.LabelDescription.Equals(input.LabelDescription))
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
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.AlternateDescription != null)
                {
                    hashCode = (hashCode * 59) + this.AlternateDescription.GetHashCode();
                }
                if (this.LabelDescription != null)
                {
                    hashCode = (hashCode * 59) + this.LabelDescription.GetHashCode();
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
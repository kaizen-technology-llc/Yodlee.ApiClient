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
    /// UpdateCategoryRequest
    /// </summary>
    [DataContract(Name = "UpdateCategoryRequest")]
    public partial class UpdateCategoryRequest : IEquatable<UpdateCategoryRequest>, IValidatableObject
    {
        /// <summary>
        /// Defines Source
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SourceEnum
        {
            /// <summary>
            /// Enum SYSTEM for value: SYSTEM
            /// </summary>
            [EnumMember(Value = "SYSTEM")]
            SYSTEM = 1,

            /// <summary>
            /// Enum USER for value: USER
            /// </summary>
            [EnumMember(Value = "USER")]
            USER = 2

        }


        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", IsRequired = true, EmitDefaultValue = true)]
        public SourceEnum Source { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCategoryRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateCategoryRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCategoryRequest" /> class.
        /// </summary>
        /// <param name="highLevelCategoryName">highLevelCategoryName.</param>
        /// <param name="id">id (required).</param>
        /// <param name="source">source (required).</param>
        /// <param name="categoryName">categoryName.</param>
        public UpdateCategoryRequest(string highLevelCategoryName = default(string), long id = default(long), SourceEnum source = default(SourceEnum), string categoryName = default(string))
        {
            this.Id = id;
            this.Source = source;
            this.HighLevelCategoryName = highLevelCategoryName;
            this.CategoryName = categoryName;
        }

        /// <summary>
        /// Gets or Sets HighLevelCategoryName
        /// </summary>
        [DataMember(Name = "highLevelCategoryName", EmitDefaultValue = false)]
        public string HighLevelCategoryName { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets CategoryName
        /// </summary>
        [DataMember(Name = "categoryName", EmitDefaultValue = false)]
        public string CategoryName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateCategoryRequest {\n");
            sb.Append("  HighLevelCategoryName: ").Append(HighLevelCategoryName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  CategoryName: ").Append(CategoryName).Append("\n");
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
            return this.Equals(input as UpdateCategoryRequest);
        }

        /// <summary>
        /// Returns true if UpdateCategoryRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateCategoryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateCategoryRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.HighLevelCategoryName == input.HighLevelCategoryName ||
                    (this.HighLevelCategoryName != null &&
                    this.HighLevelCategoryName.Equals(input.HighLevelCategoryName))
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Source == input.Source ||
                    this.Source.Equals(input.Source)
                ) && 
                (
                    this.CategoryName == input.CategoryName ||
                    (this.CategoryName != null &&
                    this.CategoryName.Equals(input.CategoryName))
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
                if (this.HighLevelCategoryName != null)
                {
                    hashCode = (hashCode * 59) + this.HighLevelCategoryName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                hashCode = (hashCode * 59) + this.Source.GetHashCode();
                if (this.CategoryName != null)
                {
                    hashCode = (hashCode * 59) + this.CategoryName.GetHashCode();
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
            // Id (long) minimum
            if (this.Id < (long)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must be a value greater than or equal to 1.", new [] { "Id" });
            }

            yield break;
        }
    }

}

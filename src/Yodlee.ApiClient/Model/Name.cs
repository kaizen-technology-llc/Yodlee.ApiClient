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
    /// Name
    /// </summary>
    [DataContract(Name = "Name")]
    public partial class Name : IEquatable<Name>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Name" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Name()
        {
        }

        /// <summary>
        /// Middle name.
        /// </summary>
        /// <value>Middle name.</value>
        [DataMember(Name = "middle", EmitDefaultValue = false)]
        public string Middle { get; private set; }

        /// <summary>
        /// Returns false as Middle should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMiddle()
        {
            return false;
        }
        /// <summary>
        /// Last name.
        /// </summary>
        /// <value>Last name.</value>
        [DataMember(Name = "last", EmitDefaultValue = false)]
        public string Last { get; private set; }

        /// <summary>
        /// Returns false as Last should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLast()
        {
            return false;
        }
        /// <summary>
        /// Full name.
        /// </summary>
        /// <value>Full name.</value>
        [DataMember(Name = "fullName", EmitDefaultValue = false)]
        public string FullName { get; private set; }

        /// <summary>
        /// Returns false as FullName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFullName()
        {
            return false;
        }
        /// <summary>
        /// First name.
        /// </summary>
        /// <value>First name.</value>
        [DataMember(Name = "first", EmitDefaultValue = false)]
        public string First { get; private set; }

        /// <summary>
        /// Returns false as First should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFirst()
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
            sb.Append("class Name {\n");
            sb.Append("  Middle: ").Append(Middle).Append("\n");
            sb.Append("  Last: ").Append(Last).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  First: ").Append(First).Append("\n");
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
            return this.Equals(input as Name);
        }

        /// <summary>
        /// Returns true if Name instances are equal
        /// </summary>
        /// <param name="input">Instance of Name to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Name input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Middle == input.Middle ||
                    (this.Middle != null &&
                    this.Middle.Equals(input.Middle))
                ) && 
                (
                    this.Last == input.Last ||
                    (this.Last != null &&
                    this.Last.Equals(input.Last))
                ) && 
                (
                    this.FullName == input.FullName ||
                    (this.FullName != null &&
                    this.FullName.Equals(input.FullName))
                ) && 
                (
                    this.First == input.First ||
                    (this.First != null &&
                    this.First.Equals(input.First))
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
                if (this.Middle != null)
                {
                    hashCode = (hashCode * 59) + this.Middle.GetHashCode();
                }
                if (this.Last != null)
                {
                    hashCode = (hashCode * 59) + this.Last.GetHashCode();
                }
                if (this.FullName != null)
                {
                    hashCode = (hashCode * 59) + this.FullName.GetHashCode();
                }
                if (this.First != null)
                {
                    hashCode = (hashCode * 59) + this.First.GetHashCode();
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
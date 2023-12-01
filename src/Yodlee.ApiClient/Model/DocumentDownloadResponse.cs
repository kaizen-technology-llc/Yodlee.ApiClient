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
    /// DocumentDownloadResponse
    /// </summary>
    [DataContract(Name = "DocumentDownloadResponse")]
    public partial class DocumentDownloadResponse : IEquatable<DocumentDownloadResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentDownloadResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public DocumentDownloadResponse()
        {
        }

        /// <summary>
        /// Gets or Sets Document
        /// </summary>
        [DataMember(Name = "document", EmitDefaultValue = false)]
        public List<DocumentDownload> Document { get; private set; }

        /// <summary>
        /// Returns false as Document should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDocument()
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
            sb.Append("class DocumentDownloadResponse {\n");
            sb.Append("  Document: ").Append(Document).Append("\n");
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
            return this.Equals(input as DocumentDownloadResponse);
        }

        /// <summary>
        /// Returns true if DocumentDownloadResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentDownloadResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentDownloadResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Document == input.Document ||
                    this.Document != null &&
                    input.Document != null &&
                    this.Document.SequenceEqual(input.Document)
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
                if (this.Document != null)
                {
                    hashCode = (hashCode * 59) + this.Document.GetHashCode();
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

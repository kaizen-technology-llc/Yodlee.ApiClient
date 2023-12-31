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
    /// DataHandling
    /// </summary>
    [DataContract(Name = "DataHandling")]
    public partial class DataHandling : IEquatable<DataHandling>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataHandling" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DataHandling() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DataHandling" /> class.
        /// </summary>
        /// <param name="dataList">We will apply the CDR de-identificatiion process. &lt;br/&gt; De-identificatied data will be used without further consent.&lt;br/&gt; De-identification of CDR data means your data cannot be associated with your identity after de-identification process takes place. (required).</param>
        /// <param name="headerDescription">De-identification of data (required).</param>
        public DataHandling(List<string> dataList = default(List<string>), string headerDescription = default(string))
        {
            // to ensure "dataList" is required (not null)
            if (dataList == null)
            {
                throw new ArgumentNullException("dataList is a required property for DataHandling and cannot be null");
            }
            this.DataList = dataList;
            // to ensure "headerDescription" is required (not null)
            if (headerDescription == null)
            {
                throw new ArgumentNullException("headerDescription is a required property for DataHandling and cannot be null");
            }
            this.HeaderDescription = headerDescription;
        }

        /// <summary>
        /// We will apply the CDR de-identificatiion process. &lt;br/&gt; De-identificatied data will be used without further consent.&lt;br/&gt; De-identification of CDR data means your data cannot be associated with your identity after de-identification process takes place.
        /// </summary>
        /// <value>We will apply the CDR de-identificatiion process. &lt;br/&gt; De-identificatied data will be used without further consent.&lt;br/&gt; De-identification of CDR data means your data cannot be associated with your identity after de-identification process takes place.</value>
        [DataMember(Name = "dataList", IsRequired = true, EmitDefaultValue = true)]
        public List<string> DataList { get; set; }

        /// <summary>
        /// De-identification of data
        /// </summary>
        /// <value>De-identification of data</value>
        [DataMember(Name = "headerDescription", IsRequired = true, EmitDefaultValue = true)]
        public string HeaderDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DataHandling {\n");
            sb.Append("  DataList: ").Append(DataList).Append("\n");
            sb.Append("  HeaderDescription: ").Append(HeaderDescription).Append("\n");
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
            return this.Equals(input as DataHandling);
        }

        /// <summary>
        /// Returns true if DataHandling instances are equal
        /// </summary>
        /// <param name="input">Instance of DataHandling to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataHandling input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DataList == input.DataList ||
                    this.DataList != null &&
                    input.DataList != null &&
                    this.DataList.SequenceEqual(input.DataList)
                ) && 
                (
                    this.HeaderDescription == input.HeaderDescription ||
                    (this.HeaderDescription != null &&
                    this.HeaderDescription.Equals(input.HeaderDescription))
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
                if (this.DataList != null)
                {
                    hashCode = (hashCode * 59) + this.DataList.GetHashCode();
                }
                if (this.HeaderDescription != null)
                {
                    hashCode = (hashCode * 59) + this.HeaderDescription.GetHashCode();
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

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
    /// DataExtractsEventData
    /// </summary>
    [DataContract(Name = "DataExtractsEventData")]
    public partial class DataExtractsEventData : IEquatable<DataExtractsEventData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataExtractsEventData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public DataExtractsEventData()
        {
        }

        /// <summary>
        /// Gets or Sets FromDate
        /// </summary>
        [DataMember(Name = "fromDate", EmitDefaultValue = false)]
        public string FromDate { get; private set; }

        /// <summary>
        /// Returns false as FromDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFromDate()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets UserData
        /// </summary>
        [DataMember(Name = "userData", EmitDefaultValue = false)]
        public List<DataExtractsEventUserData> UserData { get; private set; }

        /// <summary>
        /// Returns false as UserData should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUserData()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets UserCount
        /// </summary>
        [DataMember(Name = "userCount", EmitDefaultValue = false)]
        public int UserCount { get; private set; }

        /// <summary>
        /// Returns false as UserCount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUserCount()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets ToDate
        /// </summary>
        [DataMember(Name = "toDate", EmitDefaultValue = false)]
        public string ToDate { get; private set; }

        /// <summary>
        /// Returns false as ToDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeToDate()
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
            sb.Append("class DataExtractsEventData {\n");
            sb.Append("  FromDate: ").Append(FromDate).Append("\n");
            sb.Append("  UserData: ").Append(UserData).Append("\n");
            sb.Append("  UserCount: ").Append(UserCount).Append("\n");
            sb.Append("  ToDate: ").Append(ToDate).Append("\n");
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
            return this.Equals(input as DataExtractsEventData);
        }

        /// <summary>
        /// Returns true if DataExtractsEventData instances are equal
        /// </summary>
        /// <param name="input">Instance of DataExtractsEventData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataExtractsEventData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FromDate == input.FromDate ||
                    (this.FromDate != null &&
                    this.FromDate.Equals(input.FromDate))
                ) && 
                (
                    this.UserData == input.UserData ||
                    this.UserData != null &&
                    input.UserData != null &&
                    this.UserData.SequenceEqual(input.UserData)
                ) && 
                (
                    this.UserCount == input.UserCount ||
                    this.UserCount.Equals(input.UserCount)
                ) && 
                (
                    this.ToDate == input.ToDate ||
                    (this.ToDate != null &&
                    this.ToDate.Equals(input.ToDate))
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
                if (this.FromDate != null)
                {
                    hashCode = (hashCode * 59) + this.FromDate.GetHashCode();
                }
                if (this.UserData != null)
                {
                    hashCode = (hashCode * 59) + this.UserData.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UserCount.GetHashCode();
                if (this.ToDate != null)
                {
                    hashCode = (hashCode * 59) + this.ToDate.GetHashCode();
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
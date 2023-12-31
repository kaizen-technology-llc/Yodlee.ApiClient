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
    /// AutoRefresh
    /// </summary>
    [DataContract(Name = "AutoRefresh")]
    public partial class AutoRefresh : IEquatable<AutoRefresh>, IValidatableObject
    {
        /// <summary>
        /// Indicates the reason for the status.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt;
        /// </summary>
        /// <value>Indicates the reason for the status.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AdditionalStatusEnum
        {
            /// <summary>
            /// Enum SCHEDULED for value: SCHEDULED
            /// </summary>
            [EnumMember(Value = "SCHEDULED")]
            SCHEDULED = 1,

            /// <summary>
            /// Enum TEMPERROR for value: TEMP_ERROR
            /// </summary>
            [EnumMember(Value = "TEMP_ERROR")]
            TEMPERROR = 2,

            /// <summary>
            /// Enum SITEBLOCKING for value: SITE_BLOCKING
            /// </summary>
            [EnumMember(Value = "SITE_BLOCKING")]
            SITEBLOCKING = 3,

            /// <summary>
            /// Enum SITENOTSUPPORTED for value: SITE_NOT_SUPPORTED
            /// </summary>
            [EnumMember(Value = "SITE_NOT_SUPPORTED")]
            SITENOTSUPPORTED = 4,

            /// <summary>
            /// Enum REALTIMEMFAREQUIRED for value: REAL_TIME_MFA_REQUIRED
            /// </summary>
            [EnumMember(Value = "REAL_TIME_MFA_REQUIRED")]
            REALTIMEMFAREQUIRED = 5,

            /// <summary>
            /// Enum USERACTIONREQUIRED for value: USER_ACTION_REQUIRED
            /// </summary>
            [EnumMember(Value = "USER_ACTION_REQUIRED")]
            USERACTIONREQUIRED = 6,

            /// <summary>
            /// Enum UNSUBSCRIBED for value: UNSUBSCRIBED
            /// </summary>
            [EnumMember(Value = "UNSUBSCRIBED")]
            UNSUBSCRIBED = 7,

            /// <summary>
            /// Enum MANUALACCOUNT for value: MANUAL_ACCOUNT
            /// </summary>
            [EnumMember(Value = "MANUAL_ACCOUNT")]
            MANUALACCOUNT = 8

        }


        /// <summary>
        /// Indicates the reason for the status.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt;
        /// </summary>
        /// <value>Indicates the reason for the status.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt;</value>
        [DataMember(Name = "additionalStatus", EmitDefaultValue = false)]
        public AdditionalStatusEnum? AdditionalStatus { get; set; }

        /// <summary>
        /// Returns false as AdditionalStatus should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAdditionalStatus()
        {
            return false;
        }
        /// <summary>
        /// Indicates whether auto refresh is enabled or disabled.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt;
        /// </summary>
        /// <value>Indicates whether auto refresh is enabled or disabled.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum ENABLED for value: ENABLED
            /// </summary>
            [EnumMember(Value = "ENABLED")]
            ENABLED = 1,

            /// <summary>
            /// Enum DISABLED for value: DISABLED
            /// </summary>
            [EnumMember(Value = "DISABLED")]
            DISABLED = 2

        }


        /// <summary>
        /// Indicates whether auto refresh is enabled or disabled.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt;
        /// </summary>
        /// <value>Indicates whether auto refresh is enabled or disabled.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt;</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Returns false as Status should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStatus()
        {
            return false;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRefresh" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public AutoRefresh()
        {
        }

        /// <summary>
        /// Date on which the auto refresh status is determined.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <value>Date on which the auto refresh status is determined.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;/ul&gt;</value>
        [DataMember(Name = "asOfDate", EmitDefaultValue = false)]
        public string AsOfDate { get; private set; }

        /// <summary>
        /// Returns false as AsOfDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAsOfDate()
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
            sb.Append("class AutoRefresh {\n");
            sb.Append("  AdditionalStatus: ").Append(AdditionalStatus).Append("\n");
            sb.Append("  AsOfDate: ").Append(AsOfDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as AutoRefresh);
        }

        /// <summary>
        /// Returns true if AutoRefresh instances are equal
        /// </summary>
        /// <param name="input">Instance of AutoRefresh to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutoRefresh input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AdditionalStatus == input.AdditionalStatus ||
                    this.AdditionalStatus.Equals(input.AdditionalStatus)
                ) && 
                (
                    this.AsOfDate == input.AsOfDate ||
                    (this.AsOfDate != null &&
                    this.AsOfDate.Equals(input.AsOfDate))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
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
                hashCode = (hashCode * 59) + this.AdditionalStatus.GetHashCode();
                if (this.AsOfDate != null)
                {
                    hashCode = (hashCode * 59) + this.AsOfDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
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

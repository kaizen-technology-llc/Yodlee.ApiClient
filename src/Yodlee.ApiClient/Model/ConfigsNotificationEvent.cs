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
    /// ConfigsNotificationEvent
    /// </summary>
    [DataContract(Name = "ConfigsNotificationEvent")]
    public partial class ConfigsNotificationEvent : IEquatable<ConfigsNotificationEvent>, IValidatableObject
    {
        /// <summary>
        /// Name of the event for which the customers must subscribe to receive notifications.&lt;br&gt;&lt;b&gt;Valid Value:&lt;/b&gt; Notification Events Name&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET configs/notifications/events&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt;
        /// </summary>
        /// <value>Name of the event for which the customers must subscribe to receive notifications.&lt;br&gt;&lt;b&gt;Valid Value:&lt;/b&gt; Notification Events Name&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET configs/notifications/events&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NameEnum
        {
            /// <summary>
            /// Enum REFRESH for value: REFRESH
            /// </summary>
            [EnumMember(Value = "REFRESH")]
            REFRESH = 1,

            /// <summary>
            /// Enum DATAUPDATES for value: DATA_UPDATES
            /// </summary>
            [EnumMember(Value = "DATA_UPDATES")]
            DATAUPDATES = 2,

            /// <summary>
            /// Enum AUTOREFRESHUPDATES for value: AUTO_REFRESH_UPDATES
            /// </summary>
            [EnumMember(Value = "AUTO_REFRESH_UPDATES")]
            AUTOREFRESHUPDATES = 3,

            /// <summary>
            /// Enum LATESTBALANCEUPDATES for value: LATEST_BALANCE_UPDATES
            /// </summary>
            [EnumMember(Value = "LATEST_BALANCE_UPDATES")]
            LATESTBALANCEUPDATES = 4,

            /// <summary>
            /// Enum CREDITACCELERATORREPORTUPDATES for value: CREDIT_ACCELERATOR_REPORT_UPDATES
            /// </summary>
            [EnumMember(Value = "CREDIT_ACCELERATOR_REPORT_UPDATES")]
            CREDITACCELERATORREPORTUPDATES = 5

        }


        /// <summary>
        /// Name of the event for which the customers must subscribe to receive notifications.&lt;br&gt;&lt;b&gt;Valid Value:&lt;/b&gt; Notification Events Name&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET configs/notifications/events&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt;
        /// </summary>
        /// <value>Name of the event for which the customers must subscribe to receive notifications.&lt;br&gt;&lt;b&gt;Valid Value:&lt;/b&gt; Notification Events Name&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET configs/notifications/events&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt;</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public NameEnum? Name { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigsNotificationEvent" /> class.
        /// </summary>
        /// <param name="name">Name of the event for which the customers must subscribe to receive notifications.&lt;br&gt;&lt;b&gt;Valid Value:&lt;/b&gt; Notification Events Name&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET configs/notifications/events&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt;.</param>
        /// <param name="callbackUrl">URL to which the notification should be posted.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET configs/notifications/events&lt;/li&gt;&lt;/ul&gt;.</param>
        public ConfigsNotificationEvent(NameEnum? name = default(NameEnum?), string callbackUrl = default(string))
        {
            this.Name = name;
            this.CallbackUrl = callbackUrl;
        }

        /// <summary>
        /// URL to which the notification should be posted.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET configs/notifications/events&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <value>URL to which the notification should be posted.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET configs/notifications/events&lt;/li&gt;&lt;/ul&gt;</value>
        [DataMember(Name = "callbackUrl", EmitDefaultValue = false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConfigsNotificationEvent {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
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
            return this.Equals(input as ConfigsNotificationEvent);
        }

        /// <summary>
        /// Returns true if ConfigsNotificationEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfigsNotificationEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigsNotificationEvent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    this.Name.Equals(input.Name)
                ) && 
                (
                    this.CallbackUrl == input.CallbackUrl ||
                    (this.CallbackUrl != null &&
                    this.CallbackUrl.Equals(input.CallbackUrl))
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
                hashCode = (hashCode * 59) + this.Name.GetHashCode();
                if (this.CallbackUrl != null)
                {
                    hashCode = (hashCode * 59) + this.CallbackUrl.GetHashCode();
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
            // CallbackUrl (string) maxLength
            if (this.CallbackUrl != null && this.CallbackUrl.Length > 2147483647)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CallbackUrl, length must be less than 2147483647.", new [] { "CallbackUrl" });
            }

            // CallbackUrl (string) minLength
            if (this.CallbackUrl != null && this.CallbackUrl.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CallbackUrl, length must be greater than 1.", new [] { "CallbackUrl" });
            }

            yield break;
        }
    }

}

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
    /// UserDetail
    /// </summary>
    [DataContract(Name = "UserDetail")]
    public partial class UserDetail : IEquatable<UserDetail>, IValidatableObject
    {
        /// <summary>
        /// Defines RoleType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RoleTypeEnum
        {
            /// <summary>
            /// Enum INDIVIDUAL for value: INDIVIDUAL
            /// </summary>
            [EnumMember(Value = "INDIVIDUAL")]
            INDIVIDUAL = 1

        }


        /// <summary>
        /// Gets or Sets RoleType
        /// </summary>
        [DataMember(Name = "roleType", EmitDefaultValue = false)]
        public RoleTypeEnum? RoleType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserDetail" /> class.
        /// </summary>
        /// <param name="preferences">preferences.</param>
        /// <param name="address">address.</param>
        /// <param name="phoneNumber">phoneNumber.</param>
        /// <param name="name">name.</param>
        /// <param name="roleType">roleType.</param>
        /// <param name="segmentName">segmentName.</param>
        public UserDetail(UserResponsePreferences preferences = default(UserResponsePreferences), UserAddress address = default(UserAddress), string phoneNumber = default(string), Name name = default(Name), RoleTypeEnum? roleType = default(RoleTypeEnum?), string segmentName = default(string))
        {
            this.Preferences = preferences;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.Name = name;
            this.RoleType = roleType;
            this.SegmentName = segmentName;
        }

        /// <summary>
        /// Gets or Sets Preferences
        /// </summary>
        [DataMember(Name = "preferences", EmitDefaultValue = false)]
        public UserResponsePreferences Preferences { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public UserAddress Address { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The login name of the user used for authentication.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;POST user/register&lt;/li&gt;&lt;li&gt;GET user&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <value>The login name of the user used for authentication.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;POST user/register&lt;/li&gt;&lt;li&gt;GET user&lt;/li&gt;&lt;/ul&gt;</value>
        [DataMember(Name = "loginName", EmitDefaultValue = false)]
        public string LoginName { get; private set; }

        /// <summary>
        /// Returns false as LoginName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLoginName()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public Name Name { get; set; }

        /// <summary>
        /// The unique identifier of a consumer/user in Yodlee system for whom the API services would be accessed for.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;POST user/samlLogin&lt;/li&gt;&lt;li&gt;POST user/register&lt;/li&gt;&lt;li&gt;GET user&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <value>The unique identifier of a consumer/user in Yodlee system for whom the API services would be accessed for.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;POST user/samlLogin&lt;/li&gt;&lt;li&gt;POST user/register&lt;/li&gt;&lt;li&gt;GET user&lt;/li&gt;&lt;/ul&gt;</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// The email address of the user.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET user&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <value>The email address of the user.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET user&lt;/li&gt;&lt;/ul&gt;</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; private set; }

        /// <summary>
        /// Returns false as Email should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEmail()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets SegmentName
        /// </summary>
        [DataMember(Name = "segmentName", EmitDefaultValue = false)]
        public string SegmentName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserDetail {\n");
            sb.Append("  Preferences: ").Append(Preferences).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  LoginName: ").Append(LoginName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RoleType: ").Append(RoleType).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  SegmentName: ").Append(SegmentName).Append("\n");
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
            return this.Equals(input as UserDetail);
        }

        /// <summary>
        /// Returns true if UserDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of UserDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserDetail input)
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
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.LoginName == input.LoginName ||
                    (this.LoginName != null &&
                    this.LoginName.Equals(input.LoginName))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.RoleType == input.RoleType ||
                    this.RoleType.Equals(input.RoleType)
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.SegmentName == input.SegmentName ||
                    (this.SegmentName != null &&
                    this.SegmentName.Equals(input.SegmentName))
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
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.PhoneNumber != null)
                {
                    hashCode = (hashCode * 59) + this.PhoneNumber.GetHashCode();
                }
                if (this.LoginName != null)
                {
                    hashCode = (hashCode * 59) + this.LoginName.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                hashCode = (hashCode * 59) + this.RoleType.GetHashCode();
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.SegmentName != null)
                {
                    hashCode = (hashCode * 59) + this.SegmentName.GetHashCode();
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

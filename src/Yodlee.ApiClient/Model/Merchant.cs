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
    /// Merchant
    /// </summary>
    [DataContract(Name = "Merchant")]
    public partial class Merchant : IEquatable<Merchant>, IValidatableObject
    {
        /// <summary>
        /// The source through which merchant information is retrieved.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,insurance,loan&lt;br&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt;
        /// </summary>
        /// <value>The source through which merchant information is retrieved.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,insurance,loan&lt;br&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SourceEnum
        {
            /// <summary>
            /// Enum YODLEE for value: YODLEE
            /// </summary>
            [EnumMember(Value = "YODLEE")]
            YODLEE = 1,

            /// <summary>
            /// Enum FACTUAL for value: FACTUAL
            /// </summary>
            [EnumMember(Value = "FACTUAL")]
            FACTUAL = 2

        }


        /// <summary>
        /// The source through which merchant information is retrieved.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,insurance,loan&lt;br&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt;
        /// </summary>
        /// <value>The source through which merchant information is retrieved.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,insurance,loan&lt;br&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt;</value>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public SourceEnum? Source { get; set; }

        /// <summary>
        /// Returns false as Source should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSource()
        {
            return false;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Merchant" /> class.
        /// </summary>
        /// <param name="address">address.</param>
        /// <param name="contact">contact.</param>
        /// <param name="coordinates">coordinates.</param>
        public Merchant(AccountAddress address = default(AccountAddress), Contact contact = default(Contact), Coordinates coordinates = default(Coordinates))
        {
            this.Address = address;
            this.Contact = contact;
            this.Coordinates = coordinates;
        }

        /// <summary>
        /// The website of the merchant.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,loan&lt;br&gt;
        /// </summary>
        /// <value>The website of the merchant.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,loan&lt;br&gt;</value>
        [DataMember(Name = "website", EmitDefaultValue = false)]
        public string Website { get; private set; }

        /// <summary>
        /// Returns false as Website should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeWebsite()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public AccountAddress Address { get; set; }

        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name = "contact", EmitDefaultValue = false)]
        public Contact Contact { get; set; }

        /// <summary>
        /// The business categories of the merchant.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard&lt;br&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt;
        /// </summary>
        /// <value>The business categories of the merchant.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard&lt;br&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt;</value>
        [DataMember(Name = "categoryLabel", EmitDefaultValue = false)]
        public List<string> CategoryLabel { get; private set; }

        /// <summary>
        /// Returns false as CategoryLabel should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCategoryLabel()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Coordinates
        /// </summary>
        [DataMember(Name = "coordinates", EmitDefaultValue = false)]
        public Coordinates Coordinates { get; set; }

        /// <summary>
        /// The name of the merchant.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,insurance,loan&lt;br&gt;
        /// </summary>
        /// <value>The name of the merchant.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,insurance,loan&lt;br&gt;</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; private set; }

        /// <summary>
        /// Returns false as Name should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeName()
        {
            return false;
        }
        /// <summary>
        /// Identifier of the merchant.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,insurance,loan&lt;br&gt;
        /// </summary>
        /// <value>Identifier of the merchant.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,insurance,loan&lt;br&gt;</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// The logoURL of the merchant.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,loan&lt;br&gt;
        /// </summary>
        /// <value>The logoURL of the merchant.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank,creditCard,investment,loan&lt;br&gt;</value>
        [DataMember(Name = "logoURL", EmitDefaultValue = false)]
        public string LogoURL { get; private set; }

        /// <summary>
        /// Returns false as LogoURL should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLogoURL()
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
            sb.Append("class Merchant {\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  CategoryLabel: ").Append(CategoryLabel).Append("\n");
            sb.Append("  Coordinates: ").Append(Coordinates).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  LogoURL: ").Append(LogoURL).Append("\n");
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
            return this.Equals(input as Merchant);
        }

        /// <summary>
        /// Returns true if Merchant instances are equal
        /// </summary>
        /// <param name="input">Instance of Merchant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Merchant input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Website == input.Website ||
                    (this.Website != null &&
                    this.Website.Equals(input.Website))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Contact == input.Contact ||
                    (this.Contact != null &&
                    this.Contact.Equals(input.Contact))
                ) && 
                (
                    this.CategoryLabel == input.CategoryLabel ||
                    this.CategoryLabel != null &&
                    input.CategoryLabel != null &&
                    this.CategoryLabel.SequenceEqual(input.CategoryLabel)
                ) && 
                (
                    this.Coordinates == input.Coordinates ||
                    (this.Coordinates != null &&
                    this.Coordinates.Equals(input.Coordinates))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Source == input.Source ||
                    this.Source.Equals(input.Source)
                ) && 
                (
                    this.LogoURL == input.LogoURL ||
                    (this.LogoURL != null &&
                    this.LogoURL.Equals(input.LogoURL))
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
                if (this.Website != null)
                {
                    hashCode = (hashCode * 59) + this.Website.GetHashCode();
                }
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.Contact != null)
                {
                    hashCode = (hashCode * 59) + this.Contact.GetHashCode();
                }
                if (this.CategoryLabel != null)
                {
                    hashCode = (hashCode * 59) + this.CategoryLabel.GetHashCode();
                }
                if (this.Coordinates != null)
                {
                    hashCode = (hashCode * 59) + this.Coordinates.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Source.GetHashCode();
                if (this.LogoURL != null)
                {
                    hashCode = (hashCode * 59) + this.LogoURL.GetHashCode();
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
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
    /// ProviderAccountRequest
    /// </summary>
    [DataContract(Name = "ProviderAccountRequest")]
    public partial class ProviderAccountRequest : IEquatable<ProviderAccountRequest>, IValidatableObject
    {
        /// <summary>
        /// Defines AggregationSource
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AggregationSourceEnum
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
        /// Gets or Sets AggregationSource
        /// </summary>
        [DataMember(Name = "aggregationSource", EmitDefaultValue = false)]
        public AggregationSourceEnum? AggregationSource { get; set; }
        /// <summary>
        /// Defines DatasetName
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DatasetNameEnum
        {
            /// <summary>
            /// Enum BASICAGGDATA for value: BASIC_AGG_DATA
            /// </summary>
            [EnumMember(Value = "BASIC_AGG_DATA")]
            BASICAGGDATA = 1,

            /// <summary>
            /// Enum ADVANCEAGGDATA for value: ADVANCE_AGG_DATA
            /// </summary>
            [EnumMember(Value = "ADVANCE_AGG_DATA")]
            ADVANCEAGGDATA = 2,

            /// <summary>
            /// Enum ACCTPROFILE for value: ACCT_PROFILE
            /// </summary>
            [EnumMember(Value = "ACCT_PROFILE")]
            ACCTPROFILE = 3,

            /// <summary>
            /// Enum DOCUMENT for value: DOCUMENT
            /// </summary>
            [EnumMember(Value = "DOCUMENT")]
            DOCUMENT = 4

        }



        /// <summary>
        /// Gets or Sets DatasetName
        /// </summary>
        [DataMember(Name = "datasetName", EmitDefaultValue = false)]
        public List<DatasetNameEnum> DatasetName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderAccountRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProviderAccountRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderAccountRequest" /> class.
        /// </summary>
        /// <param name="consentId">Consent Id generated for the request through POST Consent.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;POST Provider Account&lt;/li&gt;&lt;li&gt;PUT Provider Account&lt;/li&gt;&lt;/ul&gt;.</param>
        /// <param name="preferences">preferences.</param>
        /// <param name="aggregationSource">aggregationSource.</param>
        /// <param name="field">field (required).</param>
        /// <param name="datasetName">datasetName.</param>
        /// <param name="dataset">dataset.</param>
        public ProviderAccountRequest(long consentId = default(long), ProviderAccountPreferences preferences = default(ProviderAccountPreferences), AggregationSourceEnum? aggregationSource = default(AggregationSourceEnum?), List<Field> field = default(List<Field>), List<DatasetNameEnum> datasetName = default(List<DatasetNameEnum>), List<ProvidersDataset> dataset = default(List<ProvidersDataset>))
        {
            // to ensure "field" is required (not null)
            if (field == null)
            {
                throw new ArgumentNullException("field is a required property for ProviderAccountRequest and cannot be null");
            }
            this.Field = field;
            this.ConsentId = consentId;
            this.Preferences = preferences;
            this.AggregationSource = aggregationSource;
            this.DatasetName = datasetName;
            this.Dataset = dataset;
        }

        /// <summary>
        /// Consent Id generated for the request through POST Consent.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;POST Provider Account&lt;/li&gt;&lt;li&gt;PUT Provider Account&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <value>Consent Id generated for the request through POST Consent.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;POST Provider Account&lt;/li&gt;&lt;li&gt;PUT Provider Account&lt;/li&gt;&lt;/ul&gt;</value>
        [DataMember(Name = "consentId", EmitDefaultValue = false)]
        public long ConsentId { get; set; }

        /// <summary>
        /// Gets or Sets Preferences
        /// </summary>
        [DataMember(Name = "preferences", EmitDefaultValue = false)]
        public ProviderAccountPreferences Preferences { get; set; }

        /// <summary>
        /// Gets or Sets Field
        /// </summary>
        [DataMember(Name = "field", IsRequired = true, EmitDefaultValue = true)]
        public List<Field> Field { get; set; }

        /// <summary>
        /// Gets or Sets Dataset
        /// </summary>
        [DataMember(Name = "dataset", EmitDefaultValue = false)]
        public List<ProvidersDataset> Dataset { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProviderAccountRequest {\n");
            sb.Append("  ConsentId: ").Append(ConsentId).Append("\n");
            sb.Append("  Preferences: ").Append(Preferences).Append("\n");
            sb.Append("  AggregationSource: ").Append(AggregationSource).Append("\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  DatasetName: ").Append(DatasetName).Append("\n");
            sb.Append("  Dataset: ").Append(Dataset).Append("\n");
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
            return this.Equals(input as ProviderAccountRequest);
        }

        /// <summary>
        /// Returns true if ProviderAccountRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ProviderAccountRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProviderAccountRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ConsentId == input.ConsentId ||
                    this.ConsentId.Equals(input.ConsentId)
                ) && 
                (
                    this.Preferences == input.Preferences ||
                    (this.Preferences != null &&
                    this.Preferences.Equals(input.Preferences))
                ) && 
                (
                    this.AggregationSource == input.AggregationSource ||
                    this.AggregationSource.Equals(input.AggregationSource)
                ) && 
                (
                    this.Field == input.Field ||
                    this.Field != null &&
                    input.Field != null &&
                    this.Field.SequenceEqual(input.Field)
                ) && 
                (
                    this.DatasetName == input.DatasetName ||
                    this.DatasetName.SequenceEqual(input.DatasetName)
                ) && 
                (
                    this.Dataset == input.Dataset ||
                    this.Dataset != null &&
                    input.Dataset != null &&
                    this.Dataset.SequenceEqual(input.Dataset)
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
                hashCode = (hashCode * 59) + this.ConsentId.GetHashCode();
                if (this.Preferences != null)
                {
                    hashCode = (hashCode * 59) + this.Preferences.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AggregationSource.GetHashCode();
                if (this.Field != null)
                {
                    hashCode = (hashCode * 59) + this.Field.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DatasetName.GetHashCode();
                if (this.Dataset != null)
                {
                    hashCode = (hashCode * 59) + this.Dataset.GetHashCode();
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

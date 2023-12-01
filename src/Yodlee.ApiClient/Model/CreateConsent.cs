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
    /// CreateConsent
    /// </summary>
    [DataContract(Name = "CreateConsent")]
    public partial class CreateConsent : IEquatable<CreateConsent>, IValidatableObject
    {
        /// <summary>
        /// Data Access Frequency explains the number of times that this consent can be used.&lt;br&gt; Otherwise called as consent frequency type.
        /// </summary>
        /// <value>Data Access Frequency explains the number of times that this consent can be used.&lt;br&gt; Otherwise called as consent frequency type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DataAccessFrequencyEnum
        {
            /// <summary>
            /// Enum ONETIME for value: ONE_TIME
            /// </summary>
            [EnumMember(Value = "ONE_TIME")]
            ONETIME = 1,

            /// <summary>
            /// Enum RECURRING for value: RECURRING
            /// </summary>
            [EnumMember(Value = "RECURRING")]
            RECURRING = 2

        }


        /// <summary>
        /// Data Access Frequency explains the number of times that this consent can be used.&lt;br&gt; Otherwise called as consent frequency type.
        /// </summary>
        /// <value>Data Access Frequency explains the number of times that this consent can be used.&lt;br&gt; Otherwise called as consent frequency type.</value>
        [DataMember(Name = "dataAccessFrequency", EmitDefaultValue = false)]
        public DataAccessFrequencyEnum? DataAccessFrequency { get; set; }
        /// <summary>
        /// Status of the consent.
        /// </summary>
        /// <value>Status of the consent.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ConsentStatusEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            [EnumMember(Value = "ACTIVE")]
            ACTIVE = 1,

            /// <summary>
            /// Enum CONSENTGENERATED for value: CONSENT_GENERATED
            /// </summary>
            [EnumMember(Value = "CONSENT_GENERATED")]
            CONSENTGENERATED = 2,

            /// <summary>
            /// Enum CONSENTACCEPTED for value: CONSENT_ACCEPTED
            /// </summary>
            [EnumMember(Value = "CONSENT_ACCEPTED")]
            CONSENTACCEPTED = 3,

            /// <summary>
            /// Enum CONSENTAUTHORIZED for value: CONSENT_AUTHORIZED
            /// </summary>
            [EnumMember(Value = "CONSENT_AUTHORIZED")]
            CONSENTAUTHORIZED = 4,

            /// <summary>
            /// Enum CONSENTMISMATCH for value: CONSENT_MISMATCH
            /// </summary>
            [EnumMember(Value = "CONSENT_MISMATCH")]
            CONSENTMISMATCH = 5,

            /// <summary>
            /// Enum PENDING for value: PENDING
            /// </summary>
            [EnumMember(Value = "PENDING")]
            PENDING = 6,

            /// <summary>
            /// Enum EXPIRED for value: EXPIRED
            /// </summary>
            [EnumMember(Value = "EXPIRED")]
            EXPIRED = 7,

            /// <summary>
            /// Enum REVOKED for value: REVOKED
            /// </summary>
            [EnumMember(Value = "REVOKED")]
            REVOKED = 8,

            /// <summary>
            /// Enum CONSENTREPEALED for value: CONSENT_REPEALED
            /// </summary>
            [EnumMember(Value = "CONSENT_REPEALED")]
            CONSENTREPEALED = 9

        }


        /// <summary>
        /// Status of the consent.
        /// </summary>
        /// <value>Status of the consent.</value>
        [DataMember(Name = "consentStatus", IsRequired = true, EmitDefaultValue = true)]
        public ConsentStatusEnum ConsentStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConsent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateConsent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConsent" /> class.
        /// </summary>
        /// <param name="dataAccessFrequency">Data Access Frequency explains the number of times that this consent can be used.&lt;br&gt; Otherwise called as consent frequency type..</param>
        /// <param name="otspADRName">Name of the Accredited Data Recipient/Organization.</param>
        /// <param name="expirationDateTime">Consent expiry datetime. (required).</param>
        /// <param name="preferences">Preferences describes options about the additional usage of data or purge data (required).</param>
        /// <param name="otspADR">Unique/Accredition Id of the ADR.</param>
        /// <param name="clientADR">Client Name of the ADR (required).</param>
        /// <param name="renewal">renewal.</param>
        /// <param name="clientTrustedAdvisor">describes information of client trusted advisor (required).</param>
        /// <param name="revokeDateTime">Consent revoke datetime. (required).</param>
        /// <param name="providerConsentId">Provider consent id.</param>
        /// <param name="revokeDate">Consent revoke date. (required).</param>
        /// <param name="title">Title for the consent form. (required).</param>
        /// <param name="applicationDisplayName">Application display name. (required).</param>
        /// <param name="titleBody">Description for the title. (required).</param>
        /// <param name="consentId">Consent Id generated through POST Consent. (required).</param>
        /// <param name="startDateTime">Consent start datetime. (required).</param>
        /// <param name="customDisplayData">customDisplayData.</param>
        /// <param name="thirdPartyADR">ThirdPartyADR describes details of additional parties which are accredited data recipients under organization.</param>
        /// <param name="providerId">Provider Id for which the consent needs to be generated. (required).</param>
        /// <param name="consentStatus">Status of the consent. (required).</param>
        /// <param name="scope">Scope describes about the consent permissions and their purpose. (required).</param>
        /// <param name="links">GET consent preferences API details (required).</param>
        /// <param name="startDate">Consent start date. (required).</param>
        /// <param name="expirationDate">Consent expiry date. (required).</param>
        public CreateConsent(DataAccessFrequencyEnum? dataAccessFrequency = default(DataAccessFrequencyEnum?), string otspADRName = default(string), string expirationDateTime = default(string), List<Preferences> preferences = default(List<Preferences>), string otspADR = default(string), string clientADR = default(string), Renewal renewal = default(Renewal), List<ClientTrustedAdvisor> clientTrustedAdvisor = default(List<ClientTrustedAdvisor>), string revokeDateTime = default(string), string providerConsentId = default(string), string revokeDate = default(string), string title = default(string), string applicationDisplayName = default(string), string titleBody = default(string), long consentId = default(long), string startDateTime = default(string), CustomDisplayData customDisplayData = default(CustomDisplayData), List<ThirdPartyADR> thirdPartyADR = default(List<ThirdPartyADR>), long providerId = default(long), ConsentStatusEnum consentStatus = default(ConsentStatusEnum), List<Scope> scope = default(List<Scope>), List<Links> links = default(List<Links>), string startDate = default(string), string expirationDate = default(string))
        {
            // to ensure "expirationDateTime" is required (not null)
            if (expirationDateTime == null)
            {
                throw new ArgumentNullException("expirationDateTime is a required property for CreateConsent and cannot be null");
            }
            this.ExpirationDateTime = expirationDateTime;
            // to ensure "preferences" is required (not null)
            if (preferences == null)
            {
                throw new ArgumentNullException("preferences is a required property for CreateConsent and cannot be null");
            }
            this.Preferences = preferences;
            // to ensure "clientADR" is required (not null)
            if (clientADR == null)
            {
                throw new ArgumentNullException("clientADR is a required property for CreateConsent and cannot be null");
            }
            this.ClientADR = clientADR;
            // to ensure "clientTrustedAdvisor" is required (not null)
            if (clientTrustedAdvisor == null)
            {
                throw new ArgumentNullException("clientTrustedAdvisor is a required property for CreateConsent and cannot be null");
            }
            this.ClientTrustedAdvisor = clientTrustedAdvisor;
            // to ensure "revokeDateTime" is required (not null)
            if (revokeDateTime == null)
            {
                throw new ArgumentNullException("revokeDateTime is a required property for CreateConsent and cannot be null");
            }
            this.RevokeDateTime = revokeDateTime;
            // to ensure "revokeDate" is required (not null)
            if (revokeDate == null)
            {
                throw new ArgumentNullException("revokeDate is a required property for CreateConsent and cannot be null");
            }
            this.RevokeDate = revokeDate;
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for CreateConsent and cannot be null");
            }
            this.Title = title;
            // to ensure "applicationDisplayName" is required (not null)
            if (applicationDisplayName == null)
            {
                throw new ArgumentNullException("applicationDisplayName is a required property for CreateConsent and cannot be null");
            }
            this.ApplicationDisplayName = applicationDisplayName;
            // to ensure "titleBody" is required (not null)
            if (titleBody == null)
            {
                throw new ArgumentNullException("titleBody is a required property for CreateConsent and cannot be null");
            }
            this.TitleBody = titleBody;
            this.ConsentId = consentId;
            // to ensure "startDateTime" is required (not null)
            if (startDateTime == null)
            {
                throw new ArgumentNullException("startDateTime is a required property for CreateConsent and cannot be null");
            }
            this.StartDateTime = startDateTime;
            this.ProviderId = providerId;
            this.ConsentStatus = consentStatus;
            // to ensure "scope" is required (not null)
            if (scope == null)
            {
                throw new ArgumentNullException("scope is a required property for CreateConsent and cannot be null");
            }
            this.Scope = scope;
            // to ensure "links" is required (not null)
            if (links == null)
            {
                throw new ArgumentNullException("links is a required property for CreateConsent and cannot be null");
            }
            this.Links = links;
            // to ensure "startDate" is required (not null)
            if (startDate == null)
            {
                throw new ArgumentNullException("startDate is a required property for CreateConsent and cannot be null");
            }
            this.StartDate = startDate;
            // to ensure "expirationDate" is required (not null)
            if (expirationDate == null)
            {
                throw new ArgumentNullException("expirationDate is a required property for CreateConsent and cannot be null");
            }
            this.ExpirationDate = expirationDate;
            this.DataAccessFrequency = dataAccessFrequency;
            this.OtspADRName = otspADRName;
            this.OtspADR = otspADR;
            this.Renewal = renewal;
            this.ProviderConsentId = providerConsentId;
            this.CustomDisplayData = customDisplayData;
            this.ThirdPartyADR = thirdPartyADR;
        }

        /// <summary>
        /// Name of the Accredited Data Recipient/Organization
        /// </summary>
        /// <value>Name of the Accredited Data Recipient/Organization</value>
        [DataMember(Name = "otspADRName", EmitDefaultValue = false)]
        public string OtspADRName { get; set; }

        /// <summary>
        /// Consent expiry datetime.
        /// </summary>
        /// <value>Consent expiry datetime.</value>
        [DataMember(Name = "expirationDateTime", IsRequired = true, EmitDefaultValue = true)]
        public string ExpirationDateTime { get; set; }

        /// <summary>
        /// Preferences describes options about the additional usage of data or purge data
        /// </summary>
        /// <value>Preferences describes options about the additional usage of data or purge data</value>
        [DataMember(Name = "preferences", IsRequired = true, EmitDefaultValue = true)]
        public List<Preferences> Preferences { get; set; }

        /// <summary>
        /// Unique/Accredition Id of the ADR
        /// </summary>
        /// <value>Unique/Accredition Id of the ADR</value>
        [DataMember(Name = "otspADR", EmitDefaultValue = false)]
        public string OtspADR { get; set; }

        /// <summary>
        /// Client Name of the ADR
        /// </summary>
        /// <value>Client Name of the ADR</value>
        [DataMember(Name = "clientADR", IsRequired = true, EmitDefaultValue = true)]
        public string ClientADR { get; set; }

        /// <summary>
        /// Gets or Sets Renewal
        /// </summary>
        [DataMember(Name = "renewal", EmitDefaultValue = false)]
        public Renewal Renewal { get; set; }

        /// <summary>
        /// describes information of client trusted advisor
        /// </summary>
        /// <value>describes information of client trusted advisor</value>
        [DataMember(Name = "clientTrustedAdvisor", IsRequired = true, EmitDefaultValue = true)]
        public List<ClientTrustedAdvisor> ClientTrustedAdvisor { get; set; }

        /// <summary>
        /// Consent revoke datetime.
        /// </summary>
        /// <value>Consent revoke datetime.</value>
        [DataMember(Name = "revokeDateTime", IsRequired = true, EmitDefaultValue = true)]
        public string RevokeDateTime { get; set; }

        /// <summary>
        /// Provider consent id
        /// </summary>
        /// <value>Provider consent id</value>
        [DataMember(Name = "providerConsentId", EmitDefaultValue = false)]
        public string ProviderConsentId { get; set; }

        /// <summary>
        /// Consent revoke date.
        /// </summary>
        /// <value>Consent revoke date.</value>
        [DataMember(Name = "revokeDate", IsRequired = true, EmitDefaultValue = true)]
        public string RevokeDate { get; set; }

        /// <summary>
        /// Title for the consent form.
        /// </summary>
        /// <value>Title for the consent form.</value>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Application display name.
        /// </summary>
        /// <value>Application display name.</value>
        [DataMember(Name = "applicationDisplayName", IsRequired = true, EmitDefaultValue = true)]
        public string ApplicationDisplayName { get; set; }

        /// <summary>
        /// Description for the title.
        /// </summary>
        /// <value>Description for the title.</value>
        [DataMember(Name = "titleBody", IsRequired = true, EmitDefaultValue = true)]
        public string TitleBody { get; set; }

        /// <summary>
        /// Consent Id generated through POST Consent.
        /// </summary>
        /// <value>Consent Id generated through POST Consent.</value>
        [DataMember(Name = "consentId", IsRequired = true, EmitDefaultValue = true)]
        public long ConsentId { get; set; }

        /// <summary>
        /// Consent start datetime.
        /// </summary>
        /// <value>Consent start datetime.</value>
        [DataMember(Name = "startDateTime", IsRequired = true, EmitDefaultValue = true)]
        public string StartDateTime { get; set; }

        /// <summary>
        /// Gets or Sets CustomDisplayData
        /// </summary>
        [DataMember(Name = "customDisplayData", EmitDefaultValue = false)]
        public CustomDisplayData CustomDisplayData { get; set; }

        /// <summary>
        /// ThirdPartyADR describes details of additional parties which are accredited data recipients under organization
        /// </summary>
        /// <value>ThirdPartyADR describes details of additional parties which are accredited data recipients under organization</value>
        [DataMember(Name = "thirdPartyADR", EmitDefaultValue = false)]
        public List<ThirdPartyADR> ThirdPartyADR { get; set; }

        /// <summary>
        /// Provider Id for which the consent needs to be generated.
        /// </summary>
        /// <value>Provider Id for which the consent needs to be generated.</value>
        [DataMember(Name = "providerId", IsRequired = true, EmitDefaultValue = true)]
        public long ProviderId { get; set; }

        /// <summary>
        /// Scope describes about the consent permissions and their purpose.
        /// </summary>
        /// <value>Scope describes about the consent permissions and their purpose.</value>
        [DataMember(Name = "scope", IsRequired = true, EmitDefaultValue = true)]
        public List<Scope> Scope { get; set; }

        /// <summary>
        /// GET consent preferences API details
        /// </summary>
        /// <value>GET consent preferences API details</value>
        [DataMember(Name = "links", IsRequired = true, EmitDefaultValue = true)]
        public List<Links> Links { get; set; }

        /// <summary>
        /// Consent start date.
        /// </summary>
        /// <value>Consent start date.</value>
        [DataMember(Name = "startDate", IsRequired = true, EmitDefaultValue = true)]
        public string StartDate { get; set; }

        /// <summary>
        /// Consent expiry date.
        /// </summary>
        /// <value>Consent expiry date.</value>
        [DataMember(Name = "expirationDate", IsRequired = true, EmitDefaultValue = true)]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateConsent {\n");
            sb.Append("  DataAccessFrequency: ").Append(DataAccessFrequency).Append("\n");
            sb.Append("  OtspADRName: ").Append(OtspADRName).Append("\n");
            sb.Append("  ExpirationDateTime: ").Append(ExpirationDateTime).Append("\n");
            sb.Append("  Preferences: ").Append(Preferences).Append("\n");
            sb.Append("  OtspADR: ").Append(OtspADR).Append("\n");
            sb.Append("  ClientADR: ").Append(ClientADR).Append("\n");
            sb.Append("  Renewal: ").Append(Renewal).Append("\n");
            sb.Append("  ClientTrustedAdvisor: ").Append(ClientTrustedAdvisor).Append("\n");
            sb.Append("  RevokeDateTime: ").Append(RevokeDateTime).Append("\n");
            sb.Append("  ProviderConsentId: ").Append(ProviderConsentId).Append("\n");
            sb.Append("  RevokeDate: ").Append(RevokeDate).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  ApplicationDisplayName: ").Append(ApplicationDisplayName).Append("\n");
            sb.Append("  TitleBody: ").Append(TitleBody).Append("\n");
            sb.Append("  ConsentId: ").Append(ConsentId).Append("\n");
            sb.Append("  StartDateTime: ").Append(StartDateTime).Append("\n");
            sb.Append("  CustomDisplayData: ").Append(CustomDisplayData).Append("\n");
            sb.Append("  ThirdPartyADR: ").Append(ThirdPartyADR).Append("\n");
            sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
            sb.Append("  ConsentStatus: ").Append(ConsentStatus).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
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
            return this.Equals(input as CreateConsent);
        }

        /// <summary>
        /// Returns true if CreateConsent instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateConsent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateConsent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DataAccessFrequency == input.DataAccessFrequency ||
                    this.DataAccessFrequency.Equals(input.DataAccessFrequency)
                ) && 
                (
                    this.OtspADRName == input.OtspADRName ||
                    (this.OtspADRName != null &&
                    this.OtspADRName.Equals(input.OtspADRName))
                ) && 
                (
                    this.ExpirationDateTime == input.ExpirationDateTime ||
                    (this.ExpirationDateTime != null &&
                    this.ExpirationDateTime.Equals(input.ExpirationDateTime))
                ) && 
                (
                    this.Preferences == input.Preferences ||
                    this.Preferences != null &&
                    input.Preferences != null &&
                    this.Preferences.SequenceEqual(input.Preferences)
                ) && 
                (
                    this.OtspADR == input.OtspADR ||
                    (this.OtspADR != null &&
                    this.OtspADR.Equals(input.OtspADR))
                ) && 
                (
                    this.ClientADR == input.ClientADR ||
                    (this.ClientADR != null &&
                    this.ClientADR.Equals(input.ClientADR))
                ) && 
                (
                    this.Renewal == input.Renewal ||
                    (this.Renewal != null &&
                    this.Renewal.Equals(input.Renewal))
                ) && 
                (
                    this.ClientTrustedAdvisor == input.ClientTrustedAdvisor ||
                    this.ClientTrustedAdvisor != null &&
                    input.ClientTrustedAdvisor != null &&
                    this.ClientTrustedAdvisor.SequenceEqual(input.ClientTrustedAdvisor)
                ) && 
                (
                    this.RevokeDateTime == input.RevokeDateTime ||
                    (this.RevokeDateTime != null &&
                    this.RevokeDateTime.Equals(input.RevokeDateTime))
                ) && 
                (
                    this.ProviderConsentId == input.ProviderConsentId ||
                    (this.ProviderConsentId != null &&
                    this.ProviderConsentId.Equals(input.ProviderConsentId))
                ) && 
                (
                    this.RevokeDate == input.RevokeDate ||
                    (this.RevokeDate != null &&
                    this.RevokeDate.Equals(input.RevokeDate))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.ApplicationDisplayName == input.ApplicationDisplayName ||
                    (this.ApplicationDisplayName != null &&
                    this.ApplicationDisplayName.Equals(input.ApplicationDisplayName))
                ) && 
                (
                    this.TitleBody == input.TitleBody ||
                    (this.TitleBody != null &&
                    this.TitleBody.Equals(input.TitleBody))
                ) && 
                (
                    this.ConsentId == input.ConsentId ||
                    this.ConsentId.Equals(input.ConsentId)
                ) && 
                (
                    this.StartDateTime == input.StartDateTime ||
                    (this.StartDateTime != null &&
                    this.StartDateTime.Equals(input.StartDateTime))
                ) && 
                (
                    this.CustomDisplayData == input.CustomDisplayData ||
                    (this.CustomDisplayData != null &&
                    this.CustomDisplayData.Equals(input.CustomDisplayData))
                ) && 
                (
                    this.ThirdPartyADR == input.ThirdPartyADR ||
                    this.ThirdPartyADR != null &&
                    input.ThirdPartyADR != null &&
                    this.ThirdPartyADR.SequenceEqual(input.ThirdPartyADR)
                ) && 
                (
                    this.ProviderId == input.ProviderId ||
                    this.ProviderId.Equals(input.ProviderId)
                ) && 
                (
                    this.ConsentStatus == input.ConsentStatus ||
                    this.ConsentStatus.Equals(input.ConsentStatus)
                ) && 
                (
                    this.Scope == input.Scope ||
                    this.Scope != null &&
                    input.Scope != null &&
                    this.Scope.SequenceEqual(input.Scope)
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.ExpirationDate == input.ExpirationDate ||
                    (this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(input.ExpirationDate))
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
                hashCode = (hashCode * 59) + this.DataAccessFrequency.GetHashCode();
                if (this.OtspADRName != null)
                {
                    hashCode = (hashCode * 59) + this.OtspADRName.GetHashCode();
                }
                if (this.ExpirationDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.ExpirationDateTime.GetHashCode();
                }
                if (this.Preferences != null)
                {
                    hashCode = (hashCode * 59) + this.Preferences.GetHashCode();
                }
                if (this.OtspADR != null)
                {
                    hashCode = (hashCode * 59) + this.OtspADR.GetHashCode();
                }
                if (this.ClientADR != null)
                {
                    hashCode = (hashCode * 59) + this.ClientADR.GetHashCode();
                }
                if (this.Renewal != null)
                {
                    hashCode = (hashCode * 59) + this.Renewal.GetHashCode();
                }
                if (this.ClientTrustedAdvisor != null)
                {
                    hashCode = (hashCode * 59) + this.ClientTrustedAdvisor.GetHashCode();
                }
                if (this.RevokeDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.RevokeDateTime.GetHashCode();
                }
                if (this.ProviderConsentId != null)
                {
                    hashCode = (hashCode * 59) + this.ProviderConsentId.GetHashCode();
                }
                if (this.RevokeDate != null)
                {
                    hashCode = (hashCode * 59) + this.RevokeDate.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.ApplicationDisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.ApplicationDisplayName.GetHashCode();
                }
                if (this.TitleBody != null)
                {
                    hashCode = (hashCode * 59) + this.TitleBody.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ConsentId.GetHashCode();
                if (this.StartDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartDateTime.GetHashCode();
                }
                if (this.CustomDisplayData != null)
                {
                    hashCode = (hashCode * 59) + this.CustomDisplayData.GetHashCode();
                }
                if (this.ThirdPartyADR != null)
                {
                    hashCode = (hashCode * 59) + this.ThirdPartyADR.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ProviderId.GetHashCode();
                hashCode = (hashCode * 59) + this.ConsentStatus.GetHashCode();
                if (this.Scope != null)
                {
                    hashCode = (hashCode * 59) + this.Scope.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.ExpirationDate != null)
                {
                    hashCode = (hashCode * 59) + this.ExpirationDate.GetHashCode();
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

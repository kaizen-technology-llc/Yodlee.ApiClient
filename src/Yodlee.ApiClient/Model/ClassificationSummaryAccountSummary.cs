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
    /// ClassificationSummaryAccountSummary
    /// </summary>
    [DataContract(Name = "ClassificationSummaryAccountSummary")]
    public partial class ClassificationSummaryAccountSummary : IEquatable<ClassificationSummaryAccountSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationSummaryAccountSummary" /> class.
        /// </summary>
        /// <param name="transactionSummary">transactionSummary.</param>
        /// <param name="availableBalance">availableBalance.</param>
        public ClassificationSummaryAccountSummary(ClassificationSummaryTransactionSummary transactionSummary = default(ClassificationSummaryTransactionSummary), Money availableBalance = default(Money))
        {
            this.TransactionSummary = transactionSummary;
            this.AvailableBalance = availableBalance;
        }

        /// <summary>
        /// The primary key of the account resource and the unique identifier for the account.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank
        /// </summary>
        /// <value>The primary key of the account resource and the unique identifier for the account.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank</value>
        [DataMember(Name = "accountId", EmitDefaultValue = false)]
        public long AccountId { get; private set; }

        /// <summary>
        /// Returns false as AccountId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAccountId()
        {
            return false;
        }
        /// <summary>
        /// The date-time the account information was last retrieved from the provider site and updated in the Yodlee system
        /// </summary>
        /// <value>The date-time the account information was last retrieved from the provider site and updated in the Yodlee system</value>
        [DataMember(Name = "lastUpdated", EmitDefaultValue = false)]
        public string LastUpdated { get; private set; }

        /// <summary>
        /// Returns false as LastUpdated should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastUpdated()
        {
            return false;
        }
        /// <summary>
        /// The name of the provider site
        /// </summary>
        /// <value>The name of the provider site</value>
        [DataMember(Name = "site", EmitDefaultValue = false)]
        public string Site { get; private set; }

        /// <summary>
        /// Returns false as Site should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSite()
        {
            return false;
        }
        /// <summary>
        /// The account name as it appears at the site
        /// </summary>
        /// <value>The account name as it appears at the site</value>
        [DataMember(Name = "accountName", EmitDefaultValue = false)]
        public string AccountName { get; private set; }

        /// <summary>
        /// Returns false as AccountName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAccountName()
        {
            return false;
        }
        /// <summary>
        /// The type of account that is aggregated such as savings, checking, etc. The account type is derived based on the attributes of the account.
        /// </summary>
        /// <value>The type of account that is aggregated such as savings, checking, etc. The account type is derived based on the attributes of the account.</value>
        [DataMember(Name = "accountType", EmitDefaultValue = false)]
        public string AccountType { get; private set; }

        /// <summary>
        /// Returns false as AccountType should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAccountType()
        {
            return false;
        }
        /// <summary>
        /// The date on which the user opened the account at the provider site
        /// </summary>
        /// <value>The date on which the user opened the account at the provider site</value>
        [DataMember(Name = "accountOpenDate", EmitDefaultValue = false)]
        public string AccountOpenDate { get; private set; }

        /// <summary>
        /// Returns false as AccountOpenDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAccountOpenDate()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets TransactionSummary
        /// </summary>
        [DataMember(Name = "transactionSummary", EmitDefaultValue = false)]
        public ClassificationSummaryTransactionSummary TransactionSummary { get; set; }

        /// <summary>
        /// Gets or Sets AvailableBalance
        /// </summary>
        [DataMember(Name = "availableBalance", EmitDefaultValue = false)]
        public Money AvailableBalance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClassificationSummaryAccountSummary {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
            sb.Append("  Site: ").Append(Site).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  AccountOpenDate: ").Append(AccountOpenDate).Append("\n");
            sb.Append("  TransactionSummary: ").Append(TransactionSummary).Append("\n");
            sb.Append("  AvailableBalance: ").Append(AvailableBalance).Append("\n");
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
            return this.Equals(input as ClassificationSummaryAccountSummary);
        }

        /// <summary>
        /// Returns true if ClassificationSummaryAccountSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of ClassificationSummaryAccountSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClassificationSummaryAccountSummary input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountId == input.AccountId ||
                    this.AccountId.Equals(input.AccountId)
                ) && 
                (
                    this.LastUpdated == input.LastUpdated ||
                    (this.LastUpdated != null &&
                    this.LastUpdated.Equals(input.LastUpdated))
                ) && 
                (
                    this.Site == input.Site ||
                    (this.Site != null &&
                    this.Site.Equals(input.Site))
                ) && 
                (
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
                ) && 
                (
                    this.AccountType == input.AccountType ||
                    (this.AccountType != null &&
                    this.AccountType.Equals(input.AccountType))
                ) && 
                (
                    this.AccountOpenDate == input.AccountOpenDate ||
                    (this.AccountOpenDate != null &&
                    this.AccountOpenDate.Equals(input.AccountOpenDate))
                ) && 
                (
                    this.TransactionSummary == input.TransactionSummary ||
                    (this.TransactionSummary != null &&
                    this.TransactionSummary.Equals(input.TransactionSummary))
                ) && 
                (
                    this.AvailableBalance == input.AvailableBalance ||
                    (this.AvailableBalance != null &&
                    this.AvailableBalance.Equals(input.AvailableBalance))
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
                hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                if (this.LastUpdated != null)
                {
                    hashCode = (hashCode * 59) + this.LastUpdated.GetHashCode();
                }
                if (this.Site != null)
                {
                    hashCode = (hashCode * 59) + this.Site.GetHashCode();
                }
                if (this.AccountName != null)
                {
                    hashCode = (hashCode * 59) + this.AccountName.GetHashCode();
                }
                if (this.AccountType != null)
                {
                    hashCode = (hashCode * 59) + this.AccountType.GetHashCode();
                }
                if (this.AccountOpenDate != null)
                {
                    hashCode = (hashCode * 59) + this.AccountOpenDate.GetHashCode();
                }
                if (this.TransactionSummary != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionSummary.GetHashCode();
                }
                if (this.AvailableBalance != null)
                {
                    hashCode = (hashCode * 59) + this.AvailableBalance.GetHashCode();
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

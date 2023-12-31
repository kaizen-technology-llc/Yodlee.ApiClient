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
    /// DataExtractsUserData
    /// </summary>
    [DataContract(Name = "DataExtractsUserData")]
    public partial class DataExtractsUserData : IEquatable<DataExtractsUserData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataExtractsUserData" /> class.
        /// </summary>
        /// <param name="user">user.</param>
        public DataExtractsUserData(DataExtractsUser user = default(DataExtractsUser))
        {
            this.User = user;
        }

        /// <summary>
        /// Gets or Sets Holding
        /// </summary>
        [DataMember(Name = "holding", EmitDefaultValue = false)]
        public List<DataExtractsHolding> Holding { get; private set; }

        /// <summary>
        /// Returns false as Holding should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeHolding()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets TotalTransactionsCount
        /// </summary>
        [DataMember(Name = "totalTransactionsCount", EmitDefaultValue = false)]
        public long TotalTransactionsCount { get; private set; }

        /// <summary>
        /// Returns false as TotalTransactionsCount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTotalTransactionsCount()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", EmitDefaultValue = false)]
        public DataExtractsUser User { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name = "account", EmitDefaultValue = false)]
        public List<DataExtractsAccount> Account { get; private set; }

        /// <summary>
        /// Returns false as Account should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAccount()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Transaction
        /// </summary>
        [DataMember(Name = "transaction", EmitDefaultValue = false)]
        public List<DataExtractsTransaction> Transaction { get; private set; }

        /// <summary>
        /// Returns false as Transaction should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTransaction()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets ProviderAccount
        /// </summary>
        [DataMember(Name = "providerAccount", EmitDefaultValue = false)]
        public List<DataExtractsProviderAccount> ProviderAccount { get; private set; }

        /// <summary>
        /// Returns false as ProviderAccount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeProviderAccount()
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
            sb.Append("class DataExtractsUserData {\n");
            sb.Append("  Holding: ").Append(Holding).Append("\n");
            sb.Append("  TotalTransactionsCount: ").Append(TotalTransactionsCount).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
            sb.Append("  ProviderAccount: ").Append(ProviderAccount).Append("\n");
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
            return this.Equals(input as DataExtractsUserData);
        }

        /// <summary>
        /// Returns true if DataExtractsUserData instances are equal
        /// </summary>
        /// <param name="input">Instance of DataExtractsUserData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataExtractsUserData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Holding == input.Holding ||
                    this.Holding != null &&
                    input.Holding != null &&
                    this.Holding.SequenceEqual(input.Holding)
                ) && 
                (
                    this.TotalTransactionsCount == input.TotalTransactionsCount ||
                    this.TotalTransactionsCount.Equals(input.TotalTransactionsCount)
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.Account == input.Account ||
                    this.Account != null &&
                    input.Account != null &&
                    this.Account.SequenceEqual(input.Account)
                ) && 
                (
                    this.Transaction == input.Transaction ||
                    this.Transaction != null &&
                    input.Transaction != null &&
                    this.Transaction.SequenceEqual(input.Transaction)
                ) && 
                (
                    this.ProviderAccount == input.ProviderAccount ||
                    this.ProviderAccount != null &&
                    input.ProviderAccount != null &&
                    this.ProviderAccount.SequenceEqual(input.ProviderAccount)
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
                if (this.Holding != null)
                {
                    hashCode = (hashCode * 59) + this.Holding.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalTransactionsCount.GetHashCode();
                if (this.User != null)
                {
                    hashCode = (hashCode * 59) + this.User.GetHashCode();
                }
                if (this.Account != null)
                {
                    hashCode = (hashCode * 59) + this.Account.GetHashCode();
                }
                if (this.Transaction != null)
                {
                    hashCode = (hashCode * 59) + this.Transaction.GetHashCode();
                }
                if (this.ProviderAccount != null)
                {
                    hashCode = (hashCode * 59) + this.ProviderAccount.GetHashCode();
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

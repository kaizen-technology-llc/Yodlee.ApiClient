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
    /// ClassificationSummaryTransactionSummary
    /// </summary>
    [DataContract(Name = "ClassificationSummaryTransactionSummary")]
    public partial class ClassificationSummaryTransactionSummary : IEquatable<ClassificationSummaryTransactionSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationSummaryTransactionSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ClassificationSummaryTransactionSummary()
        {
        }

        /// <summary>
        /// The date from which the transactions are considered for evaluating the attributes (Date of the oldest transaction for the accountId)
        /// </summary>
        /// <value>The date from which the transactions are considered for evaluating the attributes (Date of the oldest transaction for the accountId)</value>
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
        /// Indicates whether the account has any card-related payments based on an implicit logic
        /// </summary>
        /// <value>Indicates whether the account has any card-related payments based on an implicit logic</value>
        [DataMember(Name = "cardPayments", EmitDefaultValue = true)]
        public bool CardPayments { get; private set; }

        /// <summary>
        /// Returns false as CardPayments should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCardPayments()
        {
            return false;
        }
        /// <summary>
        /// Indicates whether the account is a primary account based on an implicit logic
        /// </summary>
        /// <value>Indicates whether the account is a primary account based on an implicit logic</value>
        [DataMember(Name = "isPrimaryAccount", EmitDefaultValue = true)]
        public bool IsPrimaryAccount { get; private set; }

        /// <summary>
        /// Returns false as IsPrimaryAccount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsPrimaryAccount()
        {
            return false;
        }
        /// <summary>
        /// Indicates whether the account has any loan payments based on an implicit logic
        /// </summary>
        /// <value>Indicates whether the account has any loan payments based on an implicit logic</value>
        [DataMember(Name = "loanPayments", EmitDefaultValue = true)]
        public bool LoanPayments { get; private set; }

        /// <summary>
        /// Returns false as LoanPayments should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLoanPayments()
        {
            return false;
        }
        /// <summary>
        /// The date until which the transactions are considered for evaluating the attributes (Date of the latest transaction for the accountId)
        /// </summary>
        /// <value>The date until which the transactions are considered for evaluating the attributes (Date of the latest transaction for the accountId)</value>
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
        /// Indicates whether the account has any bill payments based on an implicit logic
        /// </summary>
        /// <value>Indicates whether the account has any bill payments based on an implicit logic</value>
        [DataMember(Name = "billPayments", EmitDefaultValue = true)]
        public bool BillPayments { get; private set; }

        /// <summary>
        /// Returns false as BillPayments should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBillPayments()
        {
            return false;
        }
        /// <summary>
        /// Indicates whether the account has any mortgage payments based on an implicit logic
        /// </summary>
        /// <value>Indicates whether the account has any mortgage payments based on an implicit logic</value>
        [DataMember(Name = "mortgagePayments", EmitDefaultValue = true)]
        public bool MortgagePayments { get; private set; }

        /// <summary>
        /// Returns false as MortgagePayments should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMortgagePayments()
        {
            return false;
        }
        /// <summary>
        /// Indicates whether the account has salary credits based on an implicit logic
        /// </summary>
        /// <value>Indicates whether the account has salary credits based on an implicit logic</value>
        [DataMember(Name = "salaryCredits", EmitDefaultValue = true)]
        public bool SalaryCredits { get; private set; }

        /// <summary>
        /// Returns false as SalaryCredits should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSalaryCredits()
        {
            return false;
        }
        /// <summary>
        /// Indicates whether the account is an active account based on an implicit logic
        /// </summary>
        /// <value>Indicates whether the account is an active account based on an implicit logic</value>
        [DataMember(Name = "isActiveAccount", EmitDefaultValue = true)]
        public bool IsActiveAccount { get; private set; }

        /// <summary>
        /// Returns false as IsActiveAccount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsActiveAccount()
        {
            return false;
        }
        /// <summary>
        /// An array that lists the details about the latest 3 transactions that occurred in the user&#39;s account
        /// </summary>
        /// <value>An array that lists the details about the latest 3 transactions that occurred in the user&#39;s account</value>
        [DataMember(Name = "latestTransactions", EmitDefaultValue = false)]
        public List<ClassificationSummaryTransaction> LatestTransactions { get; private set; }

        /// <summary>
        /// Returns false as LatestTransactions should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLatestTransactions()
        {
            return false;
        }
        /// <summary>
        /// Indicates whether the account has any income credits based on an implicit logic
        /// </summary>
        /// <value>Indicates whether the account has any income credits based on an implicit logic</value>
        [DataMember(Name = "incomeCredits", EmitDefaultValue = true)]
        public bool IncomeCredits { get; private set; }

        /// <summary>
        /// Returns false as IncomeCredits should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIncomeCredits()
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
            sb.Append("class ClassificationSummaryTransactionSummary {\n");
            sb.Append("  FromDate: ").Append(FromDate).Append("\n");
            sb.Append("  CardPayments: ").Append(CardPayments).Append("\n");
            sb.Append("  IsPrimaryAccount: ").Append(IsPrimaryAccount).Append("\n");
            sb.Append("  LoanPayments: ").Append(LoanPayments).Append("\n");
            sb.Append("  ToDate: ").Append(ToDate).Append("\n");
            sb.Append("  BillPayments: ").Append(BillPayments).Append("\n");
            sb.Append("  MortgagePayments: ").Append(MortgagePayments).Append("\n");
            sb.Append("  SalaryCredits: ").Append(SalaryCredits).Append("\n");
            sb.Append("  IsActiveAccount: ").Append(IsActiveAccount).Append("\n");
            sb.Append("  LatestTransactions: ").Append(LatestTransactions).Append("\n");
            sb.Append("  IncomeCredits: ").Append(IncomeCredits).Append("\n");
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
            return this.Equals(input as ClassificationSummaryTransactionSummary);
        }

        /// <summary>
        /// Returns true if ClassificationSummaryTransactionSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of ClassificationSummaryTransactionSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClassificationSummaryTransactionSummary input)
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
                    this.CardPayments == input.CardPayments ||
                    this.CardPayments.Equals(input.CardPayments)
                ) && 
                (
                    this.IsPrimaryAccount == input.IsPrimaryAccount ||
                    this.IsPrimaryAccount.Equals(input.IsPrimaryAccount)
                ) && 
                (
                    this.LoanPayments == input.LoanPayments ||
                    this.LoanPayments.Equals(input.LoanPayments)
                ) && 
                (
                    this.ToDate == input.ToDate ||
                    (this.ToDate != null &&
                    this.ToDate.Equals(input.ToDate))
                ) && 
                (
                    this.BillPayments == input.BillPayments ||
                    this.BillPayments.Equals(input.BillPayments)
                ) && 
                (
                    this.MortgagePayments == input.MortgagePayments ||
                    this.MortgagePayments.Equals(input.MortgagePayments)
                ) && 
                (
                    this.SalaryCredits == input.SalaryCredits ||
                    this.SalaryCredits.Equals(input.SalaryCredits)
                ) && 
                (
                    this.IsActiveAccount == input.IsActiveAccount ||
                    this.IsActiveAccount.Equals(input.IsActiveAccount)
                ) && 
                (
                    this.LatestTransactions == input.LatestTransactions ||
                    this.LatestTransactions != null &&
                    input.LatestTransactions != null &&
                    this.LatestTransactions.SequenceEqual(input.LatestTransactions)
                ) && 
                (
                    this.IncomeCredits == input.IncomeCredits ||
                    this.IncomeCredits.Equals(input.IncomeCredits)
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
                hashCode = (hashCode * 59) + this.CardPayments.GetHashCode();
                hashCode = (hashCode * 59) + this.IsPrimaryAccount.GetHashCode();
                hashCode = (hashCode * 59) + this.LoanPayments.GetHashCode();
                if (this.ToDate != null)
                {
                    hashCode = (hashCode * 59) + this.ToDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.BillPayments.GetHashCode();
                hashCode = (hashCode * 59) + this.MortgagePayments.GetHashCode();
                hashCode = (hashCode * 59) + this.SalaryCredits.GetHashCode();
                hashCode = (hashCode * 59) + this.IsActiveAccount.GetHashCode();
                if (this.LatestTransactions != null)
                {
                    hashCode = (hashCode * 59) + this.LatestTransactions.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IncomeCredits.GetHashCode();
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

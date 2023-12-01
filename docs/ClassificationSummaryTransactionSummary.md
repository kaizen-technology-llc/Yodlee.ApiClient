# Yodlee.ApiClient.Model.ClassificationSummaryTransactionSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FromDate** | **string** | The date from which the transactions are considered for evaluating the attributes (Date of the oldest transaction for the accountId) | [optional] [readonly] 
**CardPayments** | **bool** | Indicates whether the account has any card-related payments based on an implicit logic | [optional] [readonly] 
**IsPrimaryAccount** | **bool** | Indicates whether the account is a primary account based on an implicit logic | [optional] [readonly] 
**LoanPayments** | **bool** | Indicates whether the account has any loan payments based on an implicit logic | [optional] [readonly] 
**ToDate** | **string** | The date until which the transactions are considered for evaluating the attributes (Date of the latest transaction for the accountId) | [optional] [readonly] 
**BillPayments** | **bool** | Indicates whether the account has any bill payments based on an implicit logic | [optional] [readonly] 
**MortgagePayments** | **bool** | Indicates whether the account has any mortgage payments based on an implicit logic | [optional] [readonly] 
**SalaryCredits** | **bool** | Indicates whether the account has salary credits based on an implicit logic | [optional] [readonly] 
**IsActiveAccount** | **bool** | Indicates whether the account is an active account based on an implicit logic | [optional] [readonly] 
**LatestTransactions** | [**List&lt;ClassificationSummaryTransaction&gt;**](ClassificationSummaryTransaction.md) | An array that lists the details about the latest 3 transactions that occurred in the user&#39;s account | [optional] [readonly] 
**IncomeCredits** | **bool** | Indicates whether the account has any income credits based on an implicit logic | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


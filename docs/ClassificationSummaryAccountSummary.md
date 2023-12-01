# Yodlee.ApiClient.Model.ClassificationSummaryAccountSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **long** | The primary key of the account resource and the unique identifier for the account.&lt;br&gt;&lt;br&gt;&lt;b&gt;Aggregated / Manual&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank | [optional] [readonly] 
**LastUpdated** | **string** | The date-time the account information was last retrieved from the provider site and updated in the Yodlee system | [optional] [readonly] 
**Site** | **string** | The name of the provider site | [optional] [readonly] 
**AccountName** | **string** | The account name as it appears at the site | [optional] [readonly] 
**AccountType** | **string** | The type of account that is aggregated such as savings, checking, etc. The account type is derived based on the attributes of the account. | [optional] [readonly] 
**AccountOpenDate** | **string** | The date on which the user opened the account at the provider site | [optional] [readonly] 
**TransactionSummary** | [**ClassificationSummaryTransactionSummary**](ClassificationSummaryTransactionSummary.md) |  | [optional] 
**AvailableBalance** | [**Money**](Money.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


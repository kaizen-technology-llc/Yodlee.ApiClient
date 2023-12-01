# Yodlee.ApiClient.Model.DerivedCategorySummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreditTotal** | [**Money**](Money.md) |  | [optional] 
**Details** | [**List&lt;DerivedCategorySummaryDetails&gt;**](DerivedCategorySummaryDetails.md) | Credit and debit summary per date.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, bank, investment&lt;br&gt; | [optional] [readonly] 
**Links** | [**DerivedTransactionsLinks**](DerivedTransactionsLinks.md) |  | [optional] 
**CategoryName** | **string** | The name of the category.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, bank, investment&lt;br&gt; | [optional] [readonly] 
**CategoryId** | **long** | Id of the category. This information is provided by transactions/categories service.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, bank, investment&lt;br&gt; | [optional] [readonly] 
**DebitTotal** | [**Money**](Money.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# Yodlee.ApiClient.Model.DerivedTransactionsSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CategoryType** | **string** | Type of categories provided by transactions/categories service.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, bank, investment&lt;br&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt; | [optional] [readonly] 
**CategorySummary** | [**List&lt;DerivedCategorySummary&gt;**](DerivedCategorySummary.md) | Summary of transaction amouts at category level.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, bank, investment&lt;br&gt; | [optional] [readonly] 
**CreditTotal** | [**Money**](Money.md) |  | [optional] 
**Links** | [**DerivedTransactionsLinks**](DerivedTransactionsLinks.md) |  | [optional] 
**DebitTotal** | [**Money**](Money.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


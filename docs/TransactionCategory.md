# Yodlee.ApiClient.Model.TransactionCategory

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HighLevelCategoryName** | **string** | The name of the high level category. A group of similar transaction categories are clubbed together to form a high-level category.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt; | [optional] [readonly] 
**DefaultHighLevelCategoryName** | **string** | A attribute which will always hold the first value(initial name) of Yodlee defined highLevelCategoryName attribute.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt; | [optional] [readonly] 
**HighLevelCategoryId** | **long** | The unique identifier of the high level category.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt; | [optional] [readonly] 
**DetailCategory** | [**List&lt;DetailCategory&gt;**](DetailCategory.md) | Entity that provides detail category attributes&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt; | [optional] [readonly] 
**Id** | **long** | Unique identifier of the category.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt; | [optional] [readonly] 
**Source** | **string** | Source used to identify whether the transaction category is user defined category or system created category.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt; | [optional] [readonly] 
**Category** | **string** | The name of the category.&lt;br&gt;&lt;b&gt;Note&lt;/b&gt;: Transaction categorization is one of the core features offered by Yodlee and the categories are assigned to the transactions by the system. Transactions can be clubbed together by the category that is assigned to them.  &lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt; | [optional] [readonly] 
**Classification** | **string** | Category Classification.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt; | [optional] [readonly] 
**Type** | **string** | Transaction categories and high-level categories are further mapped to five transaction category types. Customers, based on their needs can either use the transaction categories, the high-level categories, or the transaction category types. &lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt; | [optional] [readonly] 
**DefaultCategoryName** | **string** | A attribute which will always hold the first value(initial name) of Yodlee defined category attribute.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt; | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


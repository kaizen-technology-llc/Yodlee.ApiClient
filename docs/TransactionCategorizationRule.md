# Yodlee.ApiClient.Model.TransactionCategorizationRule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RuleClauses** | [**List&lt;RuleClause&gt;**](RuleClause.md) | Details of rules. &lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt; | [optional] [readonly] 
**UserDefinedRuleId** | **long** | Unique identifier generated for every rule the user creates.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt; | [optional] [readonly] 
**CategoryLevelId** | **int** | The level of the category for which the rule is created.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, insurance, loan&lt;br&gt; | [optional] [readonly] 
**TransactionCategorisationId** | **long** | Category id that is assigned to the transaction when the transaction matches the rule clause. This is the id field of the transaction category resource.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt; | [optional] [readonly] 
**MemId** | **long** | Unique identifier of the user.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt; | [optional] [readonly] 
**RulePriority** | **int** | The order in which the rules get executed on transactions.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt; | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


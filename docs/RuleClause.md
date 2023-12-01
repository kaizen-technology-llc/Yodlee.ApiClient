# Yodlee.ApiClient.Model.RuleClause

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Field** | **string** | Field for which the clause is created.&lt;br&gt;&lt;br&gt;&lt;br&gt;&lt;b&gt;Valid Values&lt;/b&gt;:amount,description&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt; | [optional] [readonly] 
**UserDefinedRuleId** | **long** | Unique identifier generated for every rule the user creates.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt; | [optional] [readonly] 
**FieldValue** | **string** | The value would be the amount value in case of amount based rule clause or the string value in case of description based rule clause.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt; | [optional] [readonly] 
**Operation** | **string** | Operation for which the clause is created.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt; | [optional] [readonly] 
**RuleClauseId** | **long** | Unique identifier generated for the rule clause.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, investment, insurance, loan&lt;br&gt; | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


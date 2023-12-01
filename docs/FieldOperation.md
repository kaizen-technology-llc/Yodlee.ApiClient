# Yodlee.ApiClient.Model.FieldOperation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Field** | **string** | Field for which the clause is created.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, creditCard, investment, insurance, loan&lt;br&gt;&lt;b&gt;Applicable Values&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;amount&lt;/li&gt;&lt;li&gt;description&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt; | [optional] 
**Operation** | **string** | Operation for which the clause is created.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, creditCard, investment, insurance, loan&lt;br&gt;&lt;b&gt;Applicable values (depends on the value of field)&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;field is &lt;b&gt;description&lt;/b&gt; -&gt; operation can be&lt;ol&gt;&lt;li&gt;stringEquals&lt;/li&gt;&lt;li&gt;stringContains&lt;/li&gt;&lt;/ol&gt;&lt;/li&gt;&lt;li&gt;field is &lt;b&gt;amount&lt;/b&gt; -&gt; operation can be&lt;ol&gt;&lt;li&gt;numberEquals&lt;/li&gt;&lt;li&gt;numberLessThan&lt;/li&gt;&lt;li&gt;numberLessThanEquals&lt;/li&gt;&lt;li&gt;numberGreaterThan&lt;/li&gt;&lt;li&gt;numberGreaterThanEquals&lt;/li&gt;&lt;/ol&gt;&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt; | [optional] 
**Value** | **Object** | The value would be the amount value in case of amount based rule clause or the string value in case of description based rule clause.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, creditCard, investment, insurance, loan&lt;br&gt;&lt;b&gt;Applicable Values&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;field is &lt;b&gt;description&lt;/b&gt; -&gt; value should be &lt;b&gt;min of 3 and max of 50 characters&lt;/b&gt;&lt;/li&gt;&lt;li&gt;field is &lt;b&gt;amount&lt;/b&gt; -&gt; value should be &lt;b&gt; min value of 0 and a max value of 99999999999.99&lt;/b&gt;&lt;/li&gt;&lt;/ul&gt; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


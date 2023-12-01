# Yodlee.ApiClient.Model.Description

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Security** | **string** | The description will provide the actual name of the security.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: investment&lt;br&gt; | [optional] [readonly] 
**Original** | **string** | Original transaction description as it appears at the FI site.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, insurance, loan&lt;br&gt; | [optional] [readonly] 
**Simple** | **string** | The transaction description that appears at the FI site may not be self-explanatory, i.e., the source, purpose of the transaction may not be evident. Yodlee attempts to simplify and make the transaction meaningful to the consumer, and this simplified transaction description is provided in the simple description field.Note: The simple description field is available only in the United States, Canada, United Kingdom, and India.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: creditCard, insurance, loan&lt;br&gt; | [optional] [readonly] 
**Consumer** | **string** | The description of the transaction as defined by the consumer. The consumer can define or provide more details of the transaction in this field.&lt;br&gt;&lt;br&gt; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


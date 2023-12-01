# Yodlee.ApiClient.Model.PaymentProfile

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Identifier** | [**PaymentIdentifier**](PaymentIdentifier.md) |  | [optional] 
**Address** | [**List&lt;AccountAddress&gt;**](AccountAddress.md) | The address of the lender to which the monthly payments or the loan payoff amount should be paid. &lt;br&gt;&lt;b&gt;Additional Details:&lt;/b&gt;The address field applies only to the student loan account type.&lt;br&gt;&lt;b&gt;Account Type&lt;/b&gt;: Aggregated&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: loan&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;br&gt;&lt;ul&gt;&lt;li&gt;GET accounts&lt;/li&gt;&lt;li&gt;GET accounts/{accountId}&lt;/li&gt;&lt;/ul&gt; | [optional] 
**PaymentBankTransferCode** | [**PaymentBankTransferCode**](PaymentBankTransferCode.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


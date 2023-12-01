# Yodlee.ApiClient.Model.DerivedNetworth

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Date** | **string** | The date as of when the networth information is provided.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, creditcard, investment, insurance, realEstate, loan&lt;br&gt; | [optional] [readonly] 
**Liability** | [**Money**](Money.md) |  | [optional] 
**HistoricalBalances** | [**List&lt;DerivedNetworthHistoricalBalance&gt;**](DerivedNetworthHistoricalBalance.md) | Balances of the accounts over the period of time.&lt;br&gt;&lt;br&gt;&lt;b&gt;Applicable containers&lt;/b&gt;: bank, creditcard, investment, insurance, realEstate, loan&lt;br&gt; | [optional] [readonly] 
**Networth** | [**Money**](Money.md) |  | [optional] 
**Asset** | [**Money**](Money.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


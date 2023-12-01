# Yodlee.ApiClient.Model.CreateConsentRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProviderId** | **long** | Unique identifier for the provider site.(e.g., financial institution sites, biller sites, lender sites, etc.).&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;POST Consent&lt;/li&gt;&lt;/ul&gt; | [optional] 
**Dataset** | [**List&lt;ProvidersDataset&gt;**](ProvidersDataset.md) | The name of the dataset attribute supported by the provider.If no dataset value is provided, the datasets that are configured for the customer will be considered.The configured dataset can be overridden by providing the dataset as an input.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;POST Consent&lt;/li&gt;&lt;/ul&gt; | [optional] 
**ApplicationName** | **string** | The name of the application.If no applicationName is provided in the input, the default applicationName will be considered&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;POST Consent&lt;/li&gt;&lt;/ul&gt; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


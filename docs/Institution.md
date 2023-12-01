# Yodlee.ApiClient.Model.Institution

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LanguageISOCode** | **string** | The language in which the provider details are provided. For example, a site supports two languages English and French. English being the primary language, the provider response will be provided in French depending on the user&#39;s locale. The language follows the two letter ISO code.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET institutions&lt;/li&gt;&lt;/ul&gt; | [optional] [readonly] 
**Favicon** | **string** | Favicon link of the provider.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET institutions&lt;/li&gt;&lt;/ul&gt; | [optional] [readonly] 
**CountryISOCode** | **string** | Country to which the provider belongs.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET institutions&lt;/li&gt;&lt;/ul&gt; | [optional] [readonly] 
**IsAddedByUser** | **string** | Indicates that the site has been added by the user at least once.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET institutions&lt;/li&gt;&lt;/ul&gt; | [optional] [readonly] 
**PRIORITY** | **string** | Indicates the priority for which the service is invoked.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET institutions&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt; | [optional] [readonly] 
**PrimaryLanguageISOCode** | **string** | The primary language of the site.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET institutions&lt;/li&gt;&lt;/ul&gt; | [optional] [readonly] 
**BaseUrl** | **string** | The base URL of the provider&#39;s site.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET institutions&lt;/li&gt;&lt;/ul&gt; | [optional] [readonly] 
**LoginUrl** | **string** | The login URL of the provider&#39;s site.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET institutions&lt;/li&gt;&lt;/ul&gt; | [optional] [readonly] 
**ProviderId** | **List&lt;long&gt;** | providerId&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET institutions&lt;/li&gt;&lt;/ul&gt; | [optional] [readonly] 
**Name** | **string** | The name of a provider site.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET institutions&lt;/li&gt;&lt;/ul&gt; | [optional] [readonly] 
**Logo** | **string** | The logo link of the provider institution. The link will return the logo in the PNG format.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET institutions&lt;/li&gt;&lt;/ul&gt; | [optional] [readonly] 
**Id** | **long** | Unique identifier for the provider site.(e.g., financial institution sites, biller sites, lender sites, etc.).&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET institutions&lt;/li&gt;&lt;/ul&gt; | [optional] [readonly] 
**LastModified** | **string** | Determines when the provider information was updated by Yodlee. If the customer caches the data, the cache is recommended to be refreshed based on this field.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET institutions&lt;/li&gt;&lt;/ul&gt; | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


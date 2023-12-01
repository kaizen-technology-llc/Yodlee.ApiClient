# Yodlee.ApiClient.Model.Consent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DataAccessFrequency** | **string** | Data Access Frequency explains the number of times that this consent can be used.&lt;br&gt; Otherwise called as consent frequency type. | [optional] 
**ExpirationDateTime** | **string** | Consent expiry datetime. | 
**OtspADR** | **string** | Unique/Accredition Id of the ADR | [optional] 
**ClientTrustedAdvisor** | [**List&lt;ClientTrustedAdvisor&gt;**](ClientTrustedAdvisor.md) | describes information of client trusted advisor | 
**ProviderConsentId** | **string** | Provider consent id | [optional] 
**RevokeDate** | **string** | Consent revoke date. | 
**Title** | **string** | Title for the consent form. | 
**ApplicationDisplayName** | **string** | Application display name. | 
**ConsentId** | **long** | Consent Id generated through POST Consent. | 
**ProviderId** | **long** | Provider Id for which the consent needs to be generated. | 
**ConsentStatus** | **string** | Status of the consent. | 
**Scope** | [**List&lt;Scope&gt;**](Scope.md) | Scope describes about the consent permissions and their purpose. | 
**UserDataTreatment** | [**UserDataTreatment**](UserDataTreatment.md) |  | [optional] 
**Links** | [**List&lt;Links&gt;**](Links.md) | GET consent preferences API details | 
**ExpirationDate** | **string** | Consent expiry date. | 
**OtspADRName** | **string** | Name of the Accredited Data Recipient/Organization | [optional] 
**Preferences** | [**List&lt;Preferences&gt;**](Preferences.md) | Preferences describes options about the additional usage of data or purge data | 
**ClientADR** | **string** | Client Name of the ADR | 
**Renewal** | [**Renewal**](Renewal.md) |  | [optional] 
**RevokeDateTime** | **string** | Consent revoke datetime. | 
**TitleBody** | **string** | Description for the title. | 
**StartDateTime** | **string** | Consent start datetime. | 
**ThirdPartyADR** | [**List&lt;ThirdPartyADR&gt;**](ThirdPartyADR.md) | ThirdPartyADR describes details of additional parties which are accredited data recipients under organization | [optional] 
**ProviderAccountId** | **long** | Unique identifier for the provider account resource. &lt;br&gt;This is created during account addition.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providerAccounts&lt;/li&gt;&lt;/ul&gt; | [optional] [readonly] 
**StartDate** | **string** | Consent start date. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


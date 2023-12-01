# Yodlee.ApiClient.Model.CreateConsent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DataAccessFrequency** | **string** | Data Access Frequency explains the number of times that this consent can be used.&lt;br&gt; Otherwise called as consent frequency type. | [optional] 
**OtspADRName** | **string** | Name of the Accredited Data Recipient/Organization | [optional] 
**ExpirationDateTime** | **string** | Consent expiry datetime. | 
**Preferences** | [**List&lt;Preferences&gt;**](Preferences.md) | Preferences describes options about the additional usage of data or purge data | 
**OtspADR** | **string** | Unique/Accredition Id of the ADR | [optional] 
**ClientADR** | **string** | Client Name of the ADR | 
**Renewal** | [**Renewal**](Renewal.md) |  | [optional] 
**ClientTrustedAdvisor** | [**List&lt;ClientTrustedAdvisor&gt;**](ClientTrustedAdvisor.md) | describes information of client trusted advisor | 
**RevokeDateTime** | **string** | Consent revoke datetime. | 
**ProviderConsentId** | **string** | Provider consent id | [optional] 
**RevokeDate** | **string** | Consent revoke date. | 
**Title** | **string** | Title for the consent form. | 
**ApplicationDisplayName** | **string** | Application display name. | 
**TitleBody** | **string** | Description for the title. | 
**ConsentId** | **long** | Consent Id generated through POST Consent. | 
**StartDateTime** | **string** | Consent start datetime. | 
**CustomDisplayData** | [**CustomDisplayData**](CustomDisplayData.md) |  | [optional] 
**ThirdPartyADR** | [**List&lt;ThirdPartyADR&gt;**](ThirdPartyADR.md) | ThirdPartyADR describes details of additional parties which are accredited data recipients under organization | [optional] 
**ProviderId** | **long** | Provider Id for which the consent needs to be generated. | 
**ConsentStatus** | **string** | Status of the consent. | 
**Scope** | [**List&lt;Scope&gt;**](Scope.md) | Scope describes about the consent permissions and their purpose. | 
**Links** | [**List&lt;Links&gt;**](Links.md) | GET consent preferences API details | 
**StartDate** | **string** | Consent start date. | 
**ExpirationDate** | **string** | Consent expiry date. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# Yodlee.ApiClient.Model.VerificationStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **long** | Unique identifier for the account.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;POST verification&lt;/li&gt;&lt;li&gt;GET verification&lt;/li&gt;&lt;li&gt;PUT verification&lt;/li&gt;&lt;/ul&gt; | [optional] 
**Reason** | **string** | The reason the account verification failed.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;POST verification&lt;/li&gt;&lt;li&gt;GET verification&lt;/li&gt;&lt;li&gt;PUT verification&lt;/li&gt;&lt;/ul&gt; | [optional] [readonly] 
**_VerificationStatus** | **string** | The status of the account verification.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;POST verification&lt;/li&gt;&lt;li&gt;GET verification&lt;/li&gt;&lt;li&gt;PUT verification&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;&lt;b&gt;Applicable Values&lt;/b&gt; | [optional] [readonly] 
**ProviderAccountId** | **long** | Unique identifier for the provider account.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;POST verification&lt;/li&gt;&lt;li&gt;GET verification&lt;/li&gt;&lt;li&gt;PUT verification&lt;/li&gt;&lt;/ul&gt; | [optional] 
**VerificationType** | **string** | The account verification type.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;POST verification&lt;/li&gt;&lt;li&gt;GET verification&lt;/li&gt;&lt;li&gt;PUT verification&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;&lt;b&gt;Applicable Values&lt;/b&gt; | [optional] 
**Account** | [**VerificationAccount**](VerificationAccount.md) |  | [optional] 
**RemainingAttempts** | **long** |  | [optional] [readonly] 
**VerificationDate** | **string** | The date of the account verification.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;POST verification&lt;/li&gt;&lt;li&gt;GET verification&lt;/li&gt;&lt;li&gt;PUT verification&lt;/li&gt;&lt;/ul&gt; | [optional] [readonly] 
**VerificationId** | **long** | Unique identifier for the verification request.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;POST verification&lt;/li&gt;&lt;li&gt;GET verification&lt;/li&gt;&lt;li&gt;PUT verification&lt;/li&gt;&lt;/ul&gt; | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


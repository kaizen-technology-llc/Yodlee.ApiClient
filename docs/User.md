# Yodlee.ApiClient.Model.User

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Preferences** | [**UserResponsePreferences**](UserResponsePreferences.md) |  | [optional] 
**Session** | [**UserSession**](UserSession.md) |  | [optional] 
**LoginName** | **string** | The login name of the user used for authentication.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;POST user/register&lt;/li&gt;&lt;li&gt;GET user&lt;/li&gt;&lt;/ul&gt; | [optional] [readonly] 
**Name** | [**Name**](Name.md) |  | [optional] 
**Id** | **long** | The unique identifier of a consumer/user in Yodlee system for whom the API services would be accessed for.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;POST user/samlLogin&lt;/li&gt;&lt;li&gt;POST user/register&lt;/li&gt;&lt;li&gt;GET user&lt;/li&gt;&lt;/ul&gt; | [optional] [readonly] 
**RoleType** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


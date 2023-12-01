# Yodlee.ApiClient.Model.LoginForm

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MfaInfoTitle** | **string** | The title for the MFA information demanded from the user.This is the title displayed in the provider site.This field is applicable for MFA form types only. &lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providerAccounts/{providerAccountId}&lt;/li&gt;&lt;/ul&gt; | [optional] [readonly] 
**Help** | **string** | The help that can be displayed to the customer in the login form.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providerAccounts/{providerAccountId}&lt;/li&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;/ul&gt; | [optional] [readonly] 
**ForgetPasswordURL** | **string** | The forget password URL of the provider site.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providerAccounts/{providerAccountId}&lt;/li&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;/ul&gt; | [optional] 
**FormType** | **string** | The type of the forms for which the user information is required.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providerAccounts/{providerAccountId}&lt;/li&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Applicable Values&lt;/b&gt;&lt;br&gt; | [optional] 
**MfaInfoText** | **string** | The text displayed in the provider site while requesting the user&#39;s MFA information. This field is applicable for MFA form types only. &lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providerAccounts/{providerAccountId}&lt;/li&gt;&lt;/ul&gt; | [optional] [readonly] 
**LoginHelp** | **string** | The help that can be displayed to the customer in the login form.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providerAccounts/{providerAccountId}&lt;/li&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;/ul&gt; | [optional] [readonly] 
**MfaTimeout** | **long** | The amount of time before which the user is expected to provide MFA information. This field is applicable for MFA form types only. This would be an useful information that could be displayed to the users. &lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providerAccounts/{providerAccountId}&lt;/li&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;/ul&gt; | [optional] [readonly] 
**Id** | **long** | The identifier of the login form.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providerAccounts/{providerAccountId}&lt;/li&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;/ul&gt; | [optional] 
**Row** | [**List&lt;Row&gt;**](Row.md) | This indicates one row in the form. The row will have one label. But it may have single or multiple fields.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET providerAccounts/{providerAccountId}&lt;/li&gt;&lt;li&gt;GET providers/{providerId}&lt;/li&gt;&lt;/ul&gt; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


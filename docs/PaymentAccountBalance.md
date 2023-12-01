# Yodlee.ApiClient.Model.PaymentAccountBalance

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountStatus** | **string** | The status of the account that is updated by the user through an application or an API.&lt;/li&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;ACTIVE:&lt;/b&gt; All the added aggregated accounts status will be made \&quot;ACTIVE\&quot; by default.&lt;/li&gt;&lt;li&gt;&lt;b&gt;TO_BE_CLOSED:&lt;/b&gt; If the aggregated accounts are not found or closed in the data provider site, Yodlee system marks the status as TO_BE_CLOSED.&lt;/li&gt;&lt;li&gt;&lt;b&gt;INACTIVE:&lt;/b&gt; Users can update the status as INACTIVE to stop updating and to stop considering the account in other services.&lt;/li&gt;&lt;li&gt;&lt;b&gt;CLOSED:&lt;/b&gt; Users can update the status as CLOSED, if the account is closed with the provider.&lt;/li&gt;&lt;/ul&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET /partner/paymentProcessor/account&lt;/li&gt;&lt;li&gt;GET /partner/paymentProcessor/account/balance&lt;/li&gt;&lt;li&gt;GET /partner/paymentProcessor/account/holder&lt;/li&gt;&lt;/ul&gt; | [optional] [readonly] 
**LastUpdated** | **string** | The date time the account information was last retrieved from the provider site and updated in the Yodlee system.&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET /partner/paymentProcessor/account&lt;/li&gt;&lt;li&gt;GET /partner/paymentProcessor/account/balance&lt;/li&gt;&lt;li&gt;GET /partner/paymentProcessor/account/holder&lt;/li&gt;&lt;/ul&gt; | [optional] [readonly] 
**AccountName** | **string** | The account name as it appears at the site.&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET /partner/paymentProcessor/account&lt;/li&gt;&lt;li&gt;GET /partner/paymentProcessor/account/balance&lt;/li&gt;&lt;li&gt;GET /partner/paymentProcessor/account/holder&lt;/li&gt;&lt;/ul&gt; | [optional] [readonly] 
**AccountType** | **string** | The type of account that is aggregated, i.e., savings, checking, charge, etc. The account type is derived based on the attributes of the account. &lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET /partner/paymentProcessor/account&lt;/li&gt;&lt;li&gt;GET /partner/paymentProcessor/account/balance&lt;/li&gt;&lt;li&gt;GET /partner/paymentProcessor/account/holder&lt;/li&gt;&lt;/ul&gt; | [optional] [readonly] 
**CurrentBalance** | [**Money**](Money.md) |  | [optional] 
**Id** | **long** | The primary key of the account resource and the unique identifier for the account.&lt;br&gt;&lt;br&gt;&lt;b&gt;Endpoints&lt;/b&gt;:&lt;ul&gt;&lt;li&gt;GET /partner/paymentProcessor/account&lt;/li&gt;&lt;li&gt;GET /partner/paymentProcessor/account/balance&lt;/li&gt;&lt;li&gt;GET /partner/paymentProcessor/account/holder&lt;/li&gt;&lt;/ul&gt; | [optional] [readonly] 
**AvailableBalance** | [**Money**](Money.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


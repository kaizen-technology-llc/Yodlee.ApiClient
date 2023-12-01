# Yodlee.ApiClient.Api.ProviderAccountsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteProviderAccount**](ProviderAccountsApi.md#deleteprovideraccount) | **DELETE** /providerAccounts/{providerAccountId} | Delete Provider Account |
| [**EditCredentialsOrRefreshProviderAccount**](ProviderAccountsApi.md#editcredentialsorrefreshprovideraccount) | **PUT** /providerAccounts | Update Account |
| [**GetAllProviderAccounts**](ProviderAccountsApi.md#getallprovideraccounts) | **GET** /providerAccounts | Get Provider Accounts |
| [**GetProviderAccount**](ProviderAccountsApi.md#getprovideraccount) | **GET** /providerAccounts/{providerAccountId} | Get Provider Account Details |
| [**GetProviderAccountProfiles**](ProviderAccountsApi.md#getprovideraccountprofiles) | **GET** /providerAccounts/profile | Get User Profile Details |
| [**LinkProviderAccount**](ProviderAccountsApi.md#linkprovideraccount) | **POST** /providerAccounts | Add Account |
| [**UpdatePreferences**](ProviderAccountsApi.md#updatepreferences) | **PUT** /providerAccounts/{providerAccountId}/preferences | Update Preferences |

<a name="deleteprovideraccount"></a>
# **DeleteProviderAccount**
> void DeleteProviderAccount (long providerAccountId)

Delete Provider Account

The delete provider account service is used to delete a provider account from the Yodlee system. This service also deletes the accounts that are created in the Yodlee system for that provider account. <br>This service does not return a response. The HTTP response code is 204 (Success with no content).<br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class DeleteProviderAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ProviderAccountsApi(config);
            var providerAccountId = 789L;  // long | providerAccountId

            try
            {
                // Delete Provider Account
                apiInstance.DeleteProviderAccount(providerAccountId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProviderAccountsApi.DeleteProviderAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteProviderAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Provider Account
    apiInstance.DeleteProviderAccountWithHttpInfo(providerAccountId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProviderAccountsApi.DeleteProviderAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **providerAccountId** | **long** | providerAccountId |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y800 : Invalid value for providerAccountId&lt;br&gt;Y868 : No action is allowed, as the data is being migrated to the Open Banking provider&lt;br&gt; |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editcredentialsorrefreshprovideraccount"></a>
# **EditCredentialsOrRefreshProviderAccount**
> UpdatedProviderAccountResponse EditCredentialsOrRefreshProviderAccount (string providerAccountIds, ProviderAccountRequest providerAccountRequest = null)

Update Account

<b>Credential-based Implementation Notes:</b> <br>The update account API is used to:  &bull; Retrieve the latest information for accounts that belong to one providerAccount from the provider site. You must allow at least 15 min between requests. <br> &bull; Update account credentials when the user has changed the authentication information at the provider site. <br> &bull; Post MFA information for the MFA-enabled provider accounts during add and update accounts. <br> &bull; Retrieve the latest information of all the eligible accounts that belong to the user. <br><br><b>Edit Credentials - Notes: </b> <br> &bull; If credentials have to be updated in the Yodlee system, one of the following should be provided: <br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&#9702; LoginForm <br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&#9702; Field array <br> &bull; LoginForm or the field array, can be obtained from the GET providerAccounts/{providerAccountId}?include=credentials API response. <br> &bull; The credentials provided by the user should be embedded in the loginForm or field array object before you pass to this API. <br><b>Posting MFA Info - Notes: </b> <br>1. You might receive the MFA request details to be presented to the end user in the GET providerAccounts/{providerAccount} API during polling or through REFRESH webhooks notificaiton. <br>2. After receiving the inputs from your user: <br>&nbsp;&nbsp;&nbsp;&nbsp;a.Embed the MFA information provided by the user in the loginForm or field array object.<br>&nbsp;&nbsp;&nbsp;&nbsp;b.Pass one of the following objects as input to this API:<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&bull; LoginForm<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&bull; Field array<br/><br><b>Points to consider:</b><br>&bull; Data to be retrieved from the provider site can be overridden using datasetName or dataset. If you do pass datasetName, all the datasets that are implicitly configured for <br>the dataset will be retrieved. This action is allowed for edit credentials and single provider account refresh flows only. <br>&bull; Encrypt the credentials and MFA information using the public key.<br>&bull; While testing the PKI feature in sandbox environment, encrypt the password credentials and answers to the MFA questions using the encryption tool.<br/><br><b>- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -</b><br><b>Open Banking (OB)-based Authentication - Notes:</b><br>The update account API is used to:<br>&bull; Retrieve the latest information for accounts from the provider site.<br>&bull; Update the renewed consent for an existing provider account.<br>&bull; Retrieve the latest information for all the eligible accounts that belong to the user.<br/><br>Yodlee recommendations: <br/>&bull; Create the field entity with the authParameters provided in the get provider details API.<br>&bull; Populate the field entity with the values received from the OB site and pass it to this API.<br/><br><b>- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -</b><br><b>Update All Eligible Accounts - Notes: </b><br>&bull; This API will trigger a refresh for all the eligible provider accounts(both OB and credential-based accounts).<br>&bull; This API will not refresh closed, inactive, or UAR accounts, or accounts with refreshes in-progress or recently refreshed non-OB accounts.<br>&bull; No parameters should be passed to this API to trigger this action.<br>&bull; Do not call this API often. Our recommendation is to call this only at the time the user logs in to your app because it can hamper other API calls performance. <br>&bull; The response only contains information for accounts that were refreshed. If no accounts are eligible for refresh, no response is returned.<br/><br><b>- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -</b><br><b>What follows are common to both OB and credential-based authentication implementations:  </b><br>&bull; Check the status of the providerAccount before invoking this API. Do not call this API to trigger any action on a providerAccount when an action is already in progress for the providerAccount. <br>&bull; If the customer has subscribed to the REFRESH event notification and invoked this API, relevant notifications will be sent to the customer.<br>&bull; A dataset may depend on another dataset for retrieval, so the response will include the requested and dependent datasets.<br>&bull; Check all the dataset additional statuses returned in the response because the provider account status is drawn from the dataset additional statuses.<br>&bull; Updating preferences using this API will trigger refreshes.<br>&bull; Pass linkedProviderAccountId in the input to link a user's credential-based providerAccount with the OB providerAccount or viceversa. Ensure that the both the providerAccounts belong to the same institution. <br>&bull; The content type has to be passed as application/json for the body parameter.<br><b>- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -</b><br><b>Note:</b>Only for the REDSYS/PSD2 UK OB integration, passing the state parameter is mandatory during the add or update account process. The state parameter key can be found in the authParameter attribute of the get provider or get provider details API response. The value for the state parameter is present in the Authorization URL. Append the callback URL to the state parameter while adding or updating an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class EditCredentialsOrRefreshProviderAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ProviderAccountsApi(config);
            var providerAccountIds = "providerAccountIds_example";  // string | comma separated providerAccountIds
            var providerAccountRequest = new ProviderAccountRequest(); // ProviderAccountRequest | loginForm or field entity (optional) 

            try
            {
                // Update Account
                UpdatedProviderAccountResponse result = apiInstance.EditCredentialsOrRefreshProviderAccount(providerAccountIds, providerAccountRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProviderAccountsApi.EditCredentialsOrRefreshProviderAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EditCredentialsOrRefreshProviderAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Account
    ApiResponse<UpdatedProviderAccountResponse> response = apiInstance.EditCredentialsOrRefreshProviderAccountWithHttpInfo(providerAccountIds, providerAccountRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProviderAccountsApi.EditCredentialsOrRefreshProviderAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **providerAccountIds** | **string** | comma separated providerAccountIds |  |
| **providerAccountRequest** | [**ProviderAccountRequest**](ProviderAccountRequest.md) | loginForm or field entity | [optional]  |

### Return type

[**UpdatedProviderAccountResponse**](UpdatedProviderAccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y805 : Multiple providerAccountId not supported for updating credentials&lt;br&gt;Y800 : Invalid value for credentialsParam&lt;br&gt;Y400 : id and value in credentialsParam are mandatory&lt;br&gt;Y806 : Invalid input&lt;br&gt;Y823 : Credentials are not applicable for real estate aggregated / manual accounts&lt;br&gt;Y868 : No action is allowed, as the data is being migrated to the Open Banking provider&lt;br&gt; |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallprovideraccounts"></a>
# **GetAllProviderAccounts**
> ProviderAccountResponse GetAllProviderAccounts (string include = null, string providerIds = null)

Get Provider Accounts

The get provider accounts service is used to return all the provider accounts added by the user. <br>This includes the failed and successfully added provider accounts.<br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetAllProviderAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ProviderAccountsApi(config);
            var include = "include_example";  // string | include (optional) 
            var providerIds = "providerIds_example";  // string | Comma separated providerIds. (optional) 

            try
            {
                // Get Provider Accounts
                ProviderAccountResponse result = apiInstance.GetAllProviderAccounts(include, providerIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProviderAccountsApi.GetAllProviderAccounts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllProviderAccountsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Provider Accounts
    ApiResponse<ProviderAccountResponse> response = apiInstance.GetAllProviderAccountsWithHttpInfo(include, providerIds);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProviderAccountsApi.GetAllProviderAccountsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **include** | **string** | include | [optional]  |
| **providerIds** | **string** | Comma separated providerIds. | [optional]  |

### Return type

[**ProviderAccountResponse**](ProviderAccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprovideraccount"></a>
# **GetProviderAccount**
> ProviderAccountDetailResponse GetProviderAccount (long providerAccountId, string include = null, string requestId = null)

Get Provider Account Details

The get provider account details service is used to learn the status of adding accounts and updating accounts.<br>This service has to be called continuously to know the progress level of the triggered process. This service also provides the MFA information requested by the provider site.<br>When <i>include = credentials</i>, questions is passed as input, the service returns the credentials (non-password values) and questions stored in the Yodlee system for that provider account. <br><br><b>Note:</b> <li>The password and answer fields are not returned in the response.</li>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetProviderAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ProviderAccountsApi(config);
            var providerAccountId = 789L;  // long | providerAccountId
            var include = "include_example";  // string | include credentials,questions (optional) 
            var requestId = "requestId_example";  // string | The unique identifier for the request that returns contextual data (optional) 

            try
            {
                // Get Provider Account Details
                ProviderAccountDetailResponse result = apiInstance.GetProviderAccount(providerAccountId, include, requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProviderAccountsApi.GetProviderAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProviderAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Provider Account Details
    ApiResponse<ProviderAccountDetailResponse> response = apiInstance.GetProviderAccountWithHttpInfo(providerAccountId, include, requestId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProviderAccountsApi.GetProviderAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **providerAccountId** | **long** | providerAccountId |  |
| **include** | **string** | include credentials,questions | [optional]  |
| **requestId** | **string** | The unique identifier for the request that returns contextual data | [optional]  |

### Return type

[**ProviderAccountDetailResponse**](ProviderAccountDetailResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y800 : Invalid value for providerAccountId&lt;br&gt;Y816 : questions can only be requested for questionAndAnswer Supported Sites |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprovideraccountprofiles"></a>
# **GetProviderAccountProfiles**
> ProviderAccountUserProfileResponse GetProviderAccountProfiles (string providerAccountId = null)

Get User Profile Details

<b>Refer GET /verification/holderProfile</b><br>The get provider accounts profile service is used to return the user profile details that are associated to the provider account. <br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetProviderAccountProfilesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ProviderAccountsApi(config);
            var providerAccountId = "providerAccountId_example";  // string | Comma separated providerAccountIds. (optional) 

            try
            {
                // Get User Profile Details
                ProviderAccountUserProfileResponse result = apiInstance.GetProviderAccountProfiles(providerAccountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProviderAccountsApi.GetProviderAccountProfiles: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProviderAccountProfilesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get User Profile Details
    ApiResponse<ProviderAccountUserProfileResponse> response = apiInstance.GetProviderAccountProfilesWithHttpInfo(providerAccountId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProviderAccountsApi.GetProviderAccountProfilesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **providerAccountId** | **string** | Comma separated providerAccountIds. | [optional]  |

### Return type

[**ProviderAccountUserProfileResponse**](ProviderAccountUserProfileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="linkprovideraccount"></a>
# **LinkProviderAccount**
> AddedProviderAccountResponse LinkProviderAccount (long providerId, ProviderAccountRequest providerAccountRequest)

Add Account

The add account service is used to link the user's account with the provider site in the Yodlee system. Providers that require multifactor authentication or open banking are also supported by this service. The response includes the Yodlee generated ID (providerAccountId) of the account along with the refresh information.<br><br>Open Banking Implementation Notes: <br>To link the user's account of the Open Banking provider site in the Yodlee system, pass the field entity that contains:<br>1. id - From the authParameters provided in the get provider details service<br>2. value - From the redirect URL of the Open Banking site<br><br>Credential-based Implementation Notes: <br>1. The loginForm or the field array are the objects under the provider object, obtained from the <a href=\"https://developer.yodlee.com/apidocs/index.php#!/providers/getSiteDetail\">get provider details</a> service response.<br>2. The credentials provided by the user should be embedded in the loginForm or field array object.<br>3. While testing the <a href=\"https://developer.yodlee.com/KnowledgeBase/How_to_use_PKI\">PKI feature</a>, encrypt the credentials using the <a href=\"https://developer.yodlee.com/apidocs/utility/encrypt.html\">encryption utility</a>.<br>4. The data to be retrieved from the provider site can be passed using datasetName or dataset. If datasetName is passed, all the attributes that are implicitly configured for the dataset will be retrieved.<br>5. If the customer has not subscribed to the REFRESH event webhooks notification for accounts that require multifactor authentication (MFA), the get providerAccount service has to be called continuously till the login form (supported types are token, question & answer, and captcha) is returned in the response.<br>6. The <a href=\"https://developer.yodlee.com/apidocs/index.php#!/providerAccounts/updateAccount\">update account</a> service should be called to post the MFA information to continue adding the account.<br><br>Generic Implementation Notes:<br>1. Refer to the <a href=\"https://developer.yodlee.com/Yodlee_API/docs/v1_1/API_Flow\">add account</a> flow chart for implementation.<br>2. The get provider account details has <a href=\"https://developer.yodlee.com/Yodlee_API/docs/v1_1/Webhooks\">webhooks support</a>. If the customer has subscribed to the REFRESH event notification and has invoked this service to add an account, relevant notifications will be sent to the callback URL.<br>3. If you had not subscribed for notifications, the <a href=\"https://developer.yodlee.com/apidocs/index.php#!/providerAccounts/getRefreshForProviderAccount\">get provider account </a> details service has to be polled continuously till the account addition status is FAILED or PARTIAL_SUCCESS or SUCCESS. <br>4. A dataset may depend on another dataset for retrieval, so the response will include the requested datasets and the dependent datasets.<br>   It is necessary to check all the dataset additional statuses returned in the response, as the provider account status is drawn from the dataset additional statuses.<br>5. Pass linkedProviderAccountId in the input to link a user's credential-based providerAccount with the open banking providerAccount. Ensure that the credential-based providerAccount belongs to the same institution. <br>6. The content type has to be passed as application/json in the body parameter. <br>7. Only for the REDSYS/PSD2 UK OB integration, passing the state parameter is mandatory during the add or update account process. The state parameter key can be found in the authParameter attribute of the get provider or get provider details API response. The value for the state parameter is present in the Authorization URL. Append the callback URL to the state parameter while adding or updating an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class LinkProviderAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ProviderAccountsApi(config);
            var providerId = 789L;  // long | providerId
            var providerAccountRequest = new ProviderAccountRequest(); // ProviderAccountRequest | loginForm or field entity

            try
            {
                // Add Account
                AddedProviderAccountResponse result = apiInstance.LinkProviderAccount(providerId, providerAccountRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProviderAccountsApi.LinkProviderAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LinkProviderAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Account
    ApiResponse<AddedProviderAccountResponse> response = apiInstance.LinkProviderAccountWithHttpInfo(providerId, providerAccountRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProviderAccountsApi.LinkProviderAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **providerId** | **long** | providerId |  |
| **providerAccountRequest** | [**ProviderAccountRequest**](ProviderAccountRequest.md) | loginForm or field entity |  |

### Return type

[**AddedProviderAccountResponse**](AddedProviderAccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y803 : providerId is mandatory&lt;br&gt;Y803 : Invalid value for credentialsParam&lt;br&gt;Y400 : id and value in credentialsParam are mandatory&lt;br&gt;Y901 : Service not supported |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepreferences"></a>
# **UpdatePreferences**
> void UpdatePreferences (long providerAccountId, ProviderAccountPreferencesRequest preferences)

Update Preferences

This endpoint is used to update preferences like data extracts and auto refreshes without triggering refresh for the providerAccount.<br>Setting isDataExtractsEnabled to false will not trigger data extracts notification and dataExtracts/events will not reflect any data change that is happening for the providerAccount.<br>Modified data will not be provided in the dataExtracts/userData endpoint.<br>Setting isAutoRefreshEnabled to false will not trigger auto refreshes for the provider account.<br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class UpdatePreferencesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ProviderAccountsApi(config);
            var providerAccountId = 789L;  // long | providerAccountId
            var preferences = new ProviderAccountPreferencesRequest(); // ProviderAccountPreferencesRequest | preferences

            try
            {
                // Update Preferences
                apiInstance.UpdatePreferences(providerAccountId, preferences);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProviderAccountsApi.UpdatePreferences: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdatePreferencesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Preferences
    apiInstance.UpdatePreferencesWithHttpInfo(providerAccountId, preferences);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProviderAccountsApi.UpdatePreferencesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **providerAccountId** | **long** | providerAccountId |  |
| **preferences** | [**ProviderAccountPreferencesRequest**](ProviderAccountPreferencesRequest.md) | preferences |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Y800 : Invalid value for preferences&lt;br&gt;Y800 : Invalid value for preferences.isDataExtractsEnabled&lt;br&gt;Y800 : Invalid value for preferences.isAutoRefreshEnabled&lt;br&gt;Y807 : Resource not found&lt;br&gt;Y830 : Data extracts feature has to be enabled to set preferences.isDataExtractsEnabled as true&lt;br&gt;Y830 : Auto refresh feature has to be enabled to set preferences.isAutoRefreshEnabled as true&lt;br&gt;Y868 : No action is allowed, as the data is being migrated to the Open Banking provider&lt;br&gt; |  -  |
| **401** | Unauthorized |  -  |
| **204** | OK |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


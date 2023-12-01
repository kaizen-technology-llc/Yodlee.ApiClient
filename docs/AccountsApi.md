# Yodlee.ApiClient.Api.AccountsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateManualAccount**](AccountsApi.md#createmanualaccount) | **POST** /accounts | Add Manual Account |
| [**DeleteAccount**](AccountsApi.md#deleteaccount) | **DELETE** /accounts/{accountId} | Delete Account |
| [**EvaluateAddress**](AccountsApi.md#evaluateaddress) | **POST** /accounts/evaluateAddress | Evaluate Address |
| [**GetAccount**](AccountsApi.md#getaccount) | **GET** /accounts/{accountId} | Get Account Details |
| [**GetAllAccounts**](AccountsApi.md#getallaccounts) | **GET** /accounts | Get Accounts |
| [**GetAssociatedAccounts**](AccountsApi.md#getassociatedaccounts) | **GET** /accounts/associatedAccounts/{providerAccountId} | Associated Accounts |
| [**GetHistoricalBalances**](AccountsApi.md#gethistoricalbalances) | **GET** /accounts/historicalBalances | Get Historical Balances |
| [**GetLatestBalances**](AccountsApi.md#getlatestbalances) | **GET** /accounts/latestBalances | Get Latest Balances |
| [**MigrateAccounts**](AccountsApi.md#migrateaccounts) | **PUT** /accounts/migrateAccounts/{providerAccountId} | Migrate Accounts |
| [**UpdateAccount**](AccountsApi.md#updateaccount) | **PUT** /accounts/{accountId} | Update Account |

<a name="createmanualaccount"></a>
# **CreateManualAccount**
> CreatedAccountResponse CreateManualAccount (CreateAccountRequest accountParam)

Add Manual Account

The add account service is used to add manual accounts.<br>The response of add account service includes the account name , account number and Yodlee generated account id.<br>All manual accounts added will be included as part of networth calculation by default.<br>Add manual account support is available for bank, card, investment, insurance and loan container only.<br><br><b>Note:</b><ul> <li>A real estate account addition is only supported for SYSTEM and MANUAL valuation type.</li></ul>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class CreateManualAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AccountsApi(config);
            var accountParam = new CreateAccountRequest(); // CreateAccountRequest | accountParam

            try
            {
                // Add Manual Account
                CreatedAccountResponse result = apiInstance.CreateManualAccount(accountParam);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.CreateManualAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateManualAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Manual Account
    ApiResponse<CreatedAccountResponse> response = apiInstance.CreateManualAccountWithHttpInfo(accountParam);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountsApi.CreateManualAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountParam** | [**CreateAccountRequest**](CreateAccountRequest.md) | accountParam |  |

### Return type

[**CreatedAccountResponse**](CreatedAccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y800 : Invalid value for accountParam&lt;br&gt;Y811 : Real Estate Property value already exists&lt;br&gt;Y862 : The provided address is invalid, or the valuation is not available&lt;br&gt;Y869 : Multiple matches found. Provide the complete address or call the POST /accounts/evaluateAddress API to retrieve the list of matched addresses&lt;br&gt; |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteaccount"></a>
# **DeleteAccount**
> void DeleteAccount (long accountId)

Delete Account

The delete account service allows an account to be deleted.<br>This service does not return a response. The HTTP response code is 204 (Success with no content).<br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class DeleteAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AccountsApi(config);
            var accountId = 789L;  // long | accountId

            try
            {
                // Delete Account
                apiInstance.DeleteAccount(accountId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.DeleteAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Account
    apiInstance.DeleteAccountWithHttpInfo(accountId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountsApi.DeleteAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **long** | accountId |  |

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
| **400** | Y800 : Invalid value for accountId&lt;br&gt;Y806 : Invalid input&lt;br&gt;Y807 : Resource not found&lt;br&gt;Y868 : No action is allowed, as the data is being migrated to the Open Banking provider&lt;br&gt; |  -  |
| **401** | Unauthorized |  -  |
| **204** | OK |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="evaluateaddress"></a>
# **EvaluateAddress**
> EvaluateAddressResponse EvaluateAddress (EvaluateAddressRequest addressParam)

Evaluate Address

Use this service to validate the address before adding the real estate account.<br>If the address is valid, the service will return the complete address information.<br>The response will contain multiple addresses if the user-provided input matches with multiple entries in the vendor database.<br>In the case of multiple matches, the user can select the appropriate address from the list and then invoke the add account service with the complete address.<br><br><b>Note:</b> <ul><li>Yodlee recommends to use this service before adding the real estate account to avoid failures.</li></ul>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class EvaluateAddressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AccountsApi(config);
            var addressParam = new EvaluateAddressRequest(); // EvaluateAddressRequest | addressParam

            try
            {
                // Evaluate Address
                EvaluateAddressResponse result = apiInstance.EvaluateAddress(addressParam);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.EvaluateAddress: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EvaluateAddressWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Evaluate Address
    ApiResponse<EvaluateAddressResponse> response = apiInstance.EvaluateAddressWithHttpInfo(addressParam);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountsApi.EvaluateAddressWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addressParam** | [**EvaluateAddressRequest**](EvaluateAddressRequest.md) | addressParam |  |

### Return type

[**EvaluateAddressResponse**](EvaluateAddressResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y806 : Invalid input&lt;br&gt;Y800 : Invalid value for zip&lt;br&gt;Y812 : Required field/value - address missing in the request&lt;br&gt;Y812 : Required field/value - street missing in the request&lt;br&gt;Y812 : Required field/value - state &amp; city / zip missing in the request |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccount"></a>
# **GetAccount**
> AccountResponse GetAccount (long accountId, string include = null)

Get Account Details

The get account details service provides detailed information of an account.<br><br><b>Note:</b><li> fullAccountNumber is deprecated and is replaced with fullAccountNumberList in include parameter and response.</li>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AccountsApi(config);
            var accountId = 789L;  // long | accountId
            var include = "include_example";  // string | profile, holder, fullAccountNumber, fullAccountNumberList, paymentProfile, autoRefresh<br><b>Note:</b>fullAccountNumber is deprecated and is replaced with fullAccountNumberList in include parameter and response. (optional) 

            try
            {
                // Get Account Details
                AccountResponse result = apiInstance.GetAccount(accountId, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.GetAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Account Details
    ApiResponse<AccountResponse> response = apiInstance.GetAccountWithHttpInfo(accountId, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountsApi.GetAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **long** | accountId |  |
| **include** | **string** | profile, holder, fullAccountNumber, fullAccountNumberList, paymentProfile, autoRefresh&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt;fullAccountNumber is deprecated and is replaced with fullAccountNumberList in include parameter and response. | [optional]  |

### Return type

[**AccountResponse**](AccountResponse.md)

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

<a name="getallaccounts"></a>
# **GetAllAccounts**
> AccountResponse GetAllAccounts (string accountId = null, string container = null, string include = null, string providerAccountId = null, string requestId = null, string status = null)

Get Accounts

The get accounts service provides information about accounts added by the user.<br>By default, this service returns information for active and to be closed accounts.<br>If requestId is provided, the accounts that are updated in the context of the requestId will be provided in the response.<br><br><b>Note:</b><br><ul><li>fullAccountNumber is deprecated and is replaced with fullAccountNumberList in include parameter and response.</li><li>fullAccountNumberList, PII (Personal Identifiable Information) and holder details are not available by default, as it is a premium feature that needs security approval. This will not be available for testing in Sandbox environment.</li></ul>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetAllAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AccountsApi(config);
            var accountId = "accountId_example";  // string | Comma separated accountIds. (optional) 
            var container = "container_example";  // string | bank/creditCard/investment/insurance/loan/reward/realEstate/otherAssets/otherLiabilities (optional) 
            var include = "include_example";  // string | profile, holder, fullAccountNumber, fullAccountNumberList, paymentProfile, autoRefresh<br><b>Note:</b><br><li>fullAccountNumber is deprecated and is replaced with fullAccountNumberList in include parameter and response.</li><br><li>profile is deprecated, and to retrieve the profile information, call the GET /verification/holderProfile API instead.</li> (optional) 
            var providerAccountId = "providerAccountId_example";  // string | Comma separated providerAccountIds. (optional) 
            var requestId = "requestId_example";  // string | The unique identifier that returns contextual data (optional) 
            var status = "status_example";  // string | ACTIVE,INACTIVE,TO_BE_CLOSED,CLOSED (optional) 

            try
            {
                // Get Accounts
                AccountResponse result = apiInstance.GetAllAccounts(accountId, container, include, providerAccountId, requestId, status);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.GetAllAccounts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllAccountsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Accounts
    ApiResponse<AccountResponse> response = apiInstance.GetAllAccountsWithHttpInfo(accountId, container, include, providerAccountId, requestId, status);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountsApi.GetAllAccountsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Comma separated accountIds. | [optional]  |
| **container** | **string** | bank/creditCard/investment/insurance/loan/reward/realEstate/otherAssets/otherLiabilities | [optional]  |
| **include** | **string** | profile, holder, fullAccountNumber, fullAccountNumberList, paymentProfile, autoRefresh&lt;br&gt;&lt;b&gt;Note:&lt;/b&gt;&lt;br&gt;&lt;li&gt;fullAccountNumber is deprecated and is replaced with fullAccountNumberList in include parameter and response.&lt;/li&gt;&lt;br&gt;&lt;li&gt;profile is deprecated, and to retrieve the profile information, call the GET /verification/holderProfile API instead.&lt;/li&gt; | [optional]  |
| **providerAccountId** | **string** | Comma separated providerAccountIds. | [optional]  |
| **requestId** | **string** | The unique identifier that returns contextual data | [optional]  |
| **status** | **string** | ACTIVE,INACTIVE,TO_BE_CLOSED,CLOSED | [optional]  |

### Return type

[**AccountResponse**](AccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y800 : Invalid value for status&lt;br&gt;Y800 : Invalid value for container&lt;br&gt;Y800 : Invalid value for providerAccountId&lt;br&gt;Y824 : The maximum number of accountIds permitted is 100 |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getassociatedaccounts"></a>
# **GetAssociatedAccounts**
> AssociatedAccountsResponse GetAssociatedAccounts (long providerAccountId)

Associated Accounts

Yodlee classifies providers into credential-based aggregation and Open Banking (OB) providers.<br>This service is associated with the OB aggregation flow. As part of the OB solution, financial institutions may merge their subsidiaries and provide data as a single OB provider.<br>Before the OB solution, this data was aggregated with different provider IDs.<br>This service accepts the providerAccountId and returns all accounts of the associated providerAccounts that belong to the subsidiary of the financial institution.<br>This data should be displayed to the user to let them select the accounts that they wish to provide consent to share account data.<br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetAssociatedAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AccountsApi(config);
            var providerAccountId = 789L;  // long | providerAccountId

            try
            {
                // Associated Accounts
                AssociatedAccountsResponse result = apiInstance.GetAssociatedAccounts(providerAccountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.GetAssociatedAccounts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAssociatedAccountsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Associated Accounts
    ApiResponse<AssociatedAccountsResponse> response = apiInstance.GetAssociatedAccountsWithHttpInfo(providerAccountId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountsApi.GetAssociatedAccountsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **providerAccountId** | **long** | providerAccountId |  |

### Return type

[**AssociatedAccountsResponse**](AssociatedAccountsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y800 : Invalid value for providerAccountId&lt;br&gt; |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethistoricalbalances"></a>
# **GetHistoricalBalances**
> AccountHistoricalBalancesResponse GetHistoricalBalances (string accountId = null, string fromDate = null, bool? includeCF = null, string interval = null, int? skip = null, string toDate = null, int? top = null)

Get Historical Balances

The historical balances service is used to retrieve the historical balances for an account or a user.<br>Historical balances are daily (D), weekly (W), and monthly (M). <br>The interval input should be passed as D, W, and M to retrieve the desired historical balances. The default interval is daily (D). <br>When no account id is provided, historical balances of the accounts that are active, to be closed, and closed are provided in the response. <br>If the fromDate and toDate are not passed, the last 90 days of data will be provided. <br>The fromDate and toDate should be passed in the YYYY-MM-DD format. <br>The date field in the response denotes the date for which the balance is requested.<br>includeCF needs to be sent as true if the customer wants to return carried forward balances for a date when the data is not available. <br>asofDate field in the response denotes the date as of which the balance was updated for that account.<br>When there is no balance available for a requested date and if includeCF is sent as true, the previous date for which the balance is available is provided in the response. <br>When there is no previous balance available, no data will be sent. <br>By default, pagination is available for the historicalBalances entity in this API. The skip and top parameters are used for pagination. In the skip and top parameters, pass the number of records to be skipped and retrieved, respectively. The response header provides the links to retrieve the next and previous set of historical balances.<br> The API will only retrieve a maximum 500 records by default when values for skip and top parameters are not provided.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetHistoricalBalancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AccountsApi(config);
            var accountId = "accountId_example";  // string | accountId (optional) 
            var fromDate = "fromDate_example";  // string | from date for balance retrieval (YYYY-MM-DD) (optional) 
            var includeCF = true;  // bool? | Consider carry forward logic for missing balances (optional) 
            var interval = "interval_example";  // string | D-daily, W-weekly or M-monthly (optional) 
            var skip = 56;  // int? | skip (Min 0) (optional) 
            var toDate = "toDate_example";  // string | toDate for balance retrieval (YYYY-MM-DD) (optional) 
            var top = 56;  // int? | top (Max 500) (optional) 

            try
            {
                // Get Historical Balances
                AccountHistoricalBalancesResponse result = apiInstance.GetHistoricalBalances(accountId, fromDate, includeCF, interval, skip, toDate, top);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.GetHistoricalBalances: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetHistoricalBalancesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Historical Balances
    ApiResponse<AccountHistoricalBalancesResponse> response = apiInstance.GetHistoricalBalancesWithHttpInfo(accountId, fromDate, includeCF, interval, skip, toDate, top);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountsApi.GetHistoricalBalancesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | accountId | [optional]  |
| **fromDate** | **string** | from date for balance retrieval (YYYY-MM-DD) | [optional]  |
| **includeCF** | **bool?** | Consider carry forward logic for missing balances | [optional]  |
| **interval** | **string** | D-daily, W-weekly or M-monthly | [optional]  |
| **skip** | **int?** | skip (Min 0) | [optional]  |
| **toDate** | **string** | toDate for balance retrieval (YYYY-MM-DD) | [optional]  |
| **top** | **int?** | top (Max 500) | [optional]  |

### Return type

[**AccountHistoricalBalancesResponse**](AccountHistoricalBalancesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y800 : Invalid value for accountId&lt;br&gt;Y800 : Invalid value for fromDate&lt;br&gt;Y800 : Invalid value for toDate&lt;br&gt;Y809 : Invalid date range&lt;br&gt;Y800 : Invalid value for interval&lt;br&gt;Y802 : Future date not allowed |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlatestbalances"></a>
# **GetLatestBalances**
> AccountBalanceResponse GetLatestBalances (string accountId, string providerAccountId)

Get Latest Balances

The latest balances service provides the latest account balance by initiating a new balance refresh request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetLatestBalancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AccountsApi(config);
            var accountId = "accountId_example";  // string | Comma separated accountIds.
            var providerAccountId = "providerAccountId_example";  // string | providerAccountId.

            try
            {
                // Get Latest Balances
                AccountBalanceResponse result = apiInstance.GetLatestBalances(accountId, providerAccountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.GetLatestBalances: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLatestBalancesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Latest Balances
    ApiResponse<AccountBalanceResponse> response = apiInstance.GetLatestBalancesWithHttpInfo(accountId, providerAccountId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountsApi.GetLatestBalancesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Comma separated accountIds. |  |
| **providerAccountId** | **string** | providerAccountId. |  |

### Return type

[**AccountBalanceResponse**](AccountBalanceResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y800 : Invalid value for providerAccountId&lt;br&gt;Y800 : Invalid value for accountId &lt;br&gt;Y800 : Invalid value for accountId. Only ACTIVE accountId are supported &lt;br&gt;Y901 : Service not supported&lt;br&gt;Y803 : providerAccountId required &lt;br&gt;Y805 : Multiple providerAccountId not supported &lt;br&gt;Y803 : accountId required &lt;br&gt;Y820 : The accountId is not supported for container other than bank, investment&lt;br&gt;Y824 : The maximum number of accountIds permitted is 10&lt;br&gt;Y800 : Invalid value for accountId. All accountIds should belong to the same providerAccountId |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="migrateaccounts"></a>
# **MigrateAccounts**
> AccountMigrationResponse MigrateAccounts (long providerAccountId)

Migrate Accounts

This service is associated with the open banking (OB) flow.<br>Before invoking this service, display all the associated accounts to the user by calling the GET /associatedAccounts API.<br>The migrate accounts API treats the user's consent acceptance to initiate account migration. Invoking this service indicates that the user has given the consent to access the associated account information from the financial institution.<br>If an existing provider supports bank, card, and loan accounts, and chose only to provide bank and card through OB APIs, a new providerAccountId for OB will be created.<br>The bank and card account information will be moved to the new providerAccountId. The loan account will be retained in the existing provider account.<br>This service returns the OB providerId and the OB providerAccountId. Note that, as part of this process, there is a possibility of one or more providerAccounts getting merged.<br>The update or delete actions will not be allowed for the providerAccounts involved in the migration process until the user completes the authorization on the OB provider.<br>The oauthMigrationEligibilityStatus attribute in the GET /accounts API response indicates the accounts included in the migration process.<br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class MigrateAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AccountsApi(config);
            var providerAccountId = 789L;  // long | providerAccountId

            try
            {
                // Migrate Accounts
                AccountMigrationResponse result = apiInstance.MigrateAccounts(providerAccountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.MigrateAccounts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MigrateAccountsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Migrate Accounts
    ApiResponse<AccountMigrationResponse> response = apiInstance.MigrateAccountsWithHttpInfo(providerAccountId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountsApi.MigrateAccountsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **providerAccountId** | **long** | providerAccountId |  |

### Return type

[**AccountMigrationResponse**](AccountMigrationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y800 : Invalid value for providerAccountId&lt;br&gt; |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateaccount"></a>
# **UpdateAccount**
> void UpdateAccount (long accountId, UpdateAccountRequest accountRequest)

Update Account

The update account service is used to update manual and aggregated accounts.<br>The HTTP response code is 204 (Success without content).<br>Update manual account support is available for bank, card, investment, insurance, loan, otherAssets, otherLiabilities and realEstate containers only.<br><br><b>Note:</b><li> A real estate account update is only supported for SYSTEM and MANUAL valuation type.</li> <li> A real estate account can be linked to a loan account by passing accountId of a loan account in linkedAccountIds .</li> <li> Attribute <b>isEbillEnrolled</b> is deprecated as it is applicable for bill accounts only.</li>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class UpdateAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AccountsApi(config);
            var accountId = 789L;  // long | accountId
            var accountRequest = new UpdateAccountRequest(); // UpdateAccountRequest | accountRequest

            try
            {
                // Update Account
                apiInstance.UpdateAccount(accountId, accountRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.UpdateAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Account
    apiInstance.UpdateAccountWithHttpInfo(accountId, accountRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountsApi.UpdateAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **long** | accountId |  |
| **accountRequest** | [**UpdateAccountRequest**](UpdateAccountRequest.md) | accountRequest |  |

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
| **400** | Y800 : Invalid value for accountId&lt;br&gt;Y800 : Invalid value for updateParam&lt;br&gt;Y862 : The provided address is invalid, or the valuation is not available&lt;br&gt;Y868 : No action is allowed, as the data is being migrated to the Open Banking provider&lt;br&gt;Y869 : Multiple matches found. Provide the complete address or call the POST /accounts/evaluateAddress API to retrieve the list of matched addresses&lt;br&gt; |  -  |
| **401** | Unauthorized |  -  |
| **204** | OK |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


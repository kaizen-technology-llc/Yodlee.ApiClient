# Yodlee.ApiClient.Api.PaymentProcessorApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetVerifiedAccount**](PaymentProcessorApi.md#getverifiedaccount) | **GET** /partner/paymentProcessor/account | Get Account Details |
| [**GetVerifiedAccountBalance**](PaymentProcessorApi.md#getverifiedaccountbalance) | **GET** /partner/paymentProcessor/account/balance | Get Account Balance |
| [**GetVerifiedAccountHolder**](PaymentProcessorApi.md#getverifiedaccountholder) | **GET** /partner/paymentProcessor/account/holder | Get Account Holder Details |

<a name="getverifiedaccount"></a>
# **GetVerifiedAccount**
> PaymentAccountResponse GetVerifiedAccount (string processorToken)

Get Account Details

The get account details service retrieves account information such as account name, type, status, balance, account number and transfer code (for example, routing number of the bank account in the US) of the verified account associated with the <code>processorToken</code>. The <code>lastUpdated</code> field indicates when the account information was last updated. We recommend using this service when looking for details related to the financial account, for instance, the full account number and bank transfer code for initiating a payment.<br><br><b>Note: </b>Remember to include the <code>Authorization</code> header.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetVerifiedAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PaymentProcessorApi(config);
            var processorToken = "processorToken_example";  // string | Token shared by customer to access financial account information.

            try
            {
                // Get Account Details
                PaymentAccountResponse result = apiInstance.GetVerifiedAccount(processorToken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentProcessorApi.GetVerifiedAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVerifiedAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Account Details
    ApiResponse<PaymentAccountResponse> response = apiInstance.GetVerifiedAccountWithHttpInfo(processorToken);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentProcessorApi.GetVerifiedAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **processorToken** | **string** | Token shared by customer to access financial account information. |  |

### Return type

[**PaymentAccountResponse**](PaymentAccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y007 : Authorization header missing&lt;br&gt;Y008 : Invalid token in authorization header&lt;br&gt;Y800 : Invalid value for processorToken&lt;br&gt;Y016 : processorToken header missing |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getverifiedaccountbalance"></a>
# **GetVerifiedAccountBalance**
> PaymentAccountBalanceResponse GetVerifiedAccountBalance (string processorToken)

Get Account Balance

The get account balance service retrieves the account balance information of the verified account associated with the <code>processorToken</code>. The response returns additional account information including account names, type and status, along with the account balance information. <br>This service forces an update of the account balances. While other services also return the account balances, this service attempts to refresh the account balances in real-time rather than return a cached value. Refer to the <code>lastUpdated</code> field to determine when the account balances were refreshed. We recommend using this service when looking for the latest balance for the account.<br>While posting a debit against an account, it is generally advisable to check the available balance field to verify the availability of sufficient funds. This service returns both available and current balances: <ul><li><b>Available Balance</b> is the amount in the account that is available for spending. The value is aggregated from the FI. For checking accounts with overdrafts, the available balance amount may include the overdraft amount if the FI adds the overdraft balance to the available balance.</li><li><b>Current Balance</b> is the total amount of money in the account, aggregated from the FI.</li></ul><br><b>Note: </b>Remember to include the <code>Authorization</code> header.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetVerifiedAccountBalanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PaymentProcessorApi(config);
            var processorToken = "processorToken_example";  // string | Token shared by customer to access financial account information.

            try
            {
                // Get Account Balance
                PaymentAccountBalanceResponse result = apiInstance.GetVerifiedAccountBalance(processorToken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentProcessorApi.GetVerifiedAccountBalance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVerifiedAccountBalanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Account Balance
    ApiResponse<PaymentAccountBalanceResponse> response = apiInstance.GetVerifiedAccountBalanceWithHttpInfo(processorToken);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentProcessorApi.GetVerifiedAccountBalanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **processorToken** | **string** | Token shared by customer to access financial account information. |  |

### Return type

[**PaymentAccountBalanceResponse**](PaymentAccountBalanceResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y007 : Authorization header missing&lt;br&gt;Y008 : Invalid token in authorization header&lt;br&gt;Y800 : Invalid value for processorToken&lt;br&gt;Y016 : processorToken header missing |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getverifiedaccountholder"></a>
# **GetVerifiedAccountHolder**
> PaymentAccountHolderResponse GetVerifiedAccountHolder (string processorToken)

Get Account Holder Details

The get account holder details service retrieves the account holder information such as name, email, phone number, address, etc. of the verified financial account associated with the <code>processorToken</code>. The <code>lastUpdated</code> field indicates when the account information was last updated. We recommend using this service when looking for information related to the account holder(s), for instance, to confirm the account holder's name. <br><br><b>Note: </b>Remember to include the <code>Authorization</code> header.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetVerifiedAccountHolderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PaymentProcessorApi(config);
            var processorToken = "processorToken_example";  // string | Token shared by customer to access financial account information.

            try
            {
                // Get Account Holder Details
                PaymentAccountHolderResponse result = apiInstance.GetVerifiedAccountHolder(processorToken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentProcessorApi.GetVerifiedAccountHolder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVerifiedAccountHolderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Account Holder Details
    ApiResponse<PaymentAccountHolderResponse> response = apiInstance.GetVerifiedAccountHolderWithHttpInfo(processorToken);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentProcessorApi.GetVerifiedAccountHolderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **processorToken** | **string** | Token shared by customer to access financial account information. |  |

### Return type

[**PaymentAccountHolderResponse**](PaymentAccountHolderResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y007 : Authorization header missing&lt;br&gt;Y008 : Invalid token in authorization header&lt;br&gt;Y800 : Invalid value for processorToken&lt;br&gt;Y016 : processorToken header missing |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


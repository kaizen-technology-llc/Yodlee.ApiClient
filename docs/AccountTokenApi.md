# Yodlee.ApiClient.Api.AccountTokenApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GeneratePaymentProcessorToken**](AccountTokenApi.md#generatepaymentprocessortoken) | **POST** /paymentProcessor/token | Create Account Token |
| [**RevokePaymentProcessorToken**](AccountTokenApi.md#revokepaymentprocessortoken) | **DELETE** /paymentProcessor/token | Delete Account Token |

<a name="generatepaymentprocessortoken"></a>
# **GeneratePaymentProcessorToken**
> PaymentProcessorTokenResponse GeneratePaymentProcessorToken (PaymentProcessorTokenRequest tokenRequest)

Create Account Token

The create account token service allows you to create a secure <code>processorToken</code> for a user's verified financial account. This <code>processorToken</code> can then be shared with one of our payment processor partners.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GeneratePaymentProcessorTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AccountTokenApi(config);
            var tokenRequest = new PaymentProcessorTokenRequest(); // PaymentProcessorTokenRequest | account information

            try
            {
                // Create Account Token
                PaymentProcessorTokenResponse result = apiInstance.GeneratePaymentProcessorToken(tokenRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountTokenApi.GeneratePaymentProcessorToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GeneratePaymentProcessorTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Account Token
    ApiResponse<PaymentProcessorTokenResponse> response = apiInstance.GeneratePaymentProcessorTokenWithHttpInfo(tokenRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountTokenApi.GeneratePaymentProcessorTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tokenRequest** | [**PaymentProcessorTokenRequest**](PaymentProcessorTokenRequest.md) | account information |  |

### Return type

[**PaymentProcessorTokenResponse**](PaymentProcessorTokenResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y007 : Authorization header missing&lt;br&gt;Y008 : Invalid token in authorization header&lt;br&gt;Y833 : Invalid values(s) for accountId&lt;br&gt;Y800 : Invalid value for processor&lt;br&gt;Y813 : accountId should be provided&lt;br&gt;Y813 : processor should be provided |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="revokepaymentprocessortoken"></a>
# **RevokePaymentProcessorToken**
> void RevokePaymentProcessorToken (string processorToken)

Delete Account Token

The delete account token service allows you to revoke a previously generated <code>processorToken</code>. It is recommended to use this service when you want to disallow further access to the user's financial account, for instance when a user removes their account from your application.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class RevokePaymentProcessorTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AccountTokenApi(config);
            var processorToken = "processorToken_example";  // string | The token that you want to delete.

            try
            {
                // Delete Account Token
                apiInstance.RevokePaymentProcessorToken(processorToken);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountTokenApi.RevokePaymentProcessorToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RevokePaymentProcessorTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Account Token
    apiInstance.RevokePaymentProcessorTokenWithHttpInfo(processorToken);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountTokenApi.RevokePaymentProcessorTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **processorToken** | **string** | The token that you want to delete. |  |

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
| **400** | Y007 : Authorization header missing&lt;br&gt;Y008 : Invalid token in authorization header&lt;br&gt;Y016 : processorToken header missing |  -  |
| **401** | Unauthorized |  -  |
| **204** | No Content |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


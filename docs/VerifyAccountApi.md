# Yodlee.ApiClient.Api.VerifyAccountApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InitiateAccountVerification**](VerifyAccountApi.md#initiateaccountverification) | **POST** /verifyAccount/{providerAccountId} | Verify Accounts Using Transactions |

<a name="initiateaccountverification"></a>
# **InitiateAccountVerification**
> VerifyAccountResponse InitiateAccountVerification (string providerAccountId, VerifyAccountRequest verificationParam)

Verify Accounts Using Transactions

The verify account service is used to verify the account's ownership by  matching the transaction details with the accounts aggregated for the user.<br><ul><li>If a match is identified, the service returns details of all the accounts along with the matched transaction's details.<li>If no transaction match is found, an empty response will be returned.<li>A maximum of 5 transactionCriteria can be passed in a request.<li>The baseType, date, and amount parameters should mandatorily be passed.<li>The optional dateVariance parameter cannot be more than 7 days. For example, +7, -4, or +/-2.<li>Pass the container or accountId parameters for better performance.<li>This service supports the localization feature and accepts locale as a header parameter.</li></ul>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class InitiateAccountVerificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new VerifyAccountApi(config);
            var providerAccountId = "providerAccountId_example";  // string | providerAccountId
            var verificationParam = new VerifyAccountRequest(); // VerifyAccountRequest | verificationParam

            try
            {
                // Verify Accounts Using Transactions
                VerifyAccountResponse result = apiInstance.InitiateAccountVerification(providerAccountId, verificationParam);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VerifyAccountApi.InitiateAccountVerification: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InitiateAccountVerificationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Verify Accounts Using Transactions
    ApiResponse<VerifyAccountResponse> response = apiInstance.InitiateAccountVerificationWithHttpInfo(providerAccountId, verificationParam);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VerifyAccountApi.InitiateAccountVerificationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **providerAccountId** | **string** | providerAccountId |  |
| **verificationParam** | [**VerifyAccountRequest**](VerifyAccountRequest.md) | verificationParam |  |

### Return type

[**VerifyAccountResponse**](VerifyAccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y800 : Invalid value for container&lt;br&gt;Y800 : Invalid value for accountId&lt;br&gt;Y800 : Invalid value for amount&lt;br&gt;Y800 : Invalid value for dateVariance&lt;br&gt;Y801 : Invalid length for keyword&lt;br&gt;Y804 : Permitted values of dateVariance between 1 - 7&lt;br&gt;Y806 : Invalid input&lt;br&gt;Y807 : Resource not found&lt;br&gt;Y809 : Invalid date range&lt;br&gt;Y812 : Required field/value - transactionCriteria missing in the input&lt;br&gt;Y812 : Required field/value - amount missing in the transactionCriteria&lt;br&gt;Y812 : Required field/value - amount date in the transactionCriteria&lt;br&gt;Y812 : Required field/value - baseType missing in the transactionCriteria&lt;br&gt;Y823 : Transaction not applicable for container &lt;br&gt;Y824 : The maximum number of transactionCriteria permitted is 5&lt;br&gt;Y857 : Transactions are not refreshed in the past 24 hours&lt;br&gt;Y858 : Only active accounts can be verified&lt;br&gt;Y901 : Service not supported&lt;br&gt; |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


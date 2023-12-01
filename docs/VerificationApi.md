# Yodlee.ApiClient.Api.VerificationApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetClassificationSummary**](VerificationApi.md#getclassificationsummary) | **GET** /verification/classification/summary | Get Classification Summary |
| [**GetHolderProfile**](VerificationApi.md#getholderprofile) | **GET** /verification/holderProfile | Get Holder Profile |
| [**GetVerificationStatus**](VerificationApi.md#getverificationstatus) | **GET** /verification | Get Verification Status |
| [**GetVerifiedAccounts**](VerificationApi.md#getverifiedaccounts) | **GET** /verification/verifiedAccounts | Get Verified Accounts |
| [**InitiateMatchingOrChallengeDepositeVerification**](VerificationApi.md#initiatematchingorchallengedepositeverification) | **POST** /verification | Initiaite Challenge Deposit |
| [**VerifyChallengeDeposit**](VerificationApi.md#verifychallengedeposit) | **PUT** /verification | Verify Challenge Deposit |

<a name="getclassificationsummary"></a>
# **GetClassificationSummary**
> ClassificationSummaryResponse GetClassificationSummary (string accountId)

Get Classification Summary

The get classification summary API service returns attributes that provide account-level and transaction-level summary for a user's account.<br><br>As a prerequisite, the Account Verification customers should have Transactions enabled to fetch a response. The API can be invoked only for an account verified by the user following the get verified accounts API call. If the prerequisite is not satisfied, an appropriate error will be returned on invoking the API.<br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetClassificationSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new VerificationApi(config);
            var accountId = "accountId_example";  // string | accountId

            try
            {
                // Get Classification Summary
                ClassificationSummaryResponse result = apiInstance.GetClassificationSummary(accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VerificationApi.GetClassificationSummary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetClassificationSummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Classification Summary
    ApiResponse<ClassificationSummaryResponse> response = apiInstance.GetClassificationSummaryWithHttpInfo(accountId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VerificationApi.GetClassificationSummaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | accountId |  |

### Return type

[**ClassificationSummaryResponse**](ClassificationSummaryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y847 : resource cannot be requested, as feature not enabled&lt;br&gt;Y812 : Required field/value - accountId missing in the request&lt;br&gt;Y800 : Invalid value for accountId. Only ACTIVE and verified bank account ID belonging to the user is allowed.&lt;br&gt;Y805 : Multiple accountId not supported&lt;br&gt; |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getholderprofile"></a>
# **GetHolderProfile**
> HolderProfileResponse GetHolderProfile (string providerAccountId, string accountId = null)

Get Holder Profile

The Holder Profile API service allows retrieving the user's profile details (i.e., PII data such as name, email, phone number, and address) that are available at the provider account and each account level. The API accepts the providerAccountId and retrieves the profile information available under it and all the details available under each of the associated accounts.  <br><br>This service can only be invoked by Yodlee API v1.1, FastLink 3, and FastLink 4 customers. <br><br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetHolderProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new VerificationApi(config);
            var providerAccountId = "providerAccountId_example";  // string | providerAccountId.
            var accountId = "accountId_example";  // string | accountId (optional) 

            try
            {
                // Get Holder Profile
                HolderProfileResponse result = apiInstance.GetHolderProfile(providerAccountId, accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VerificationApi.GetHolderProfile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetHolderProfileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Holder Profile
    ApiResponse<HolderProfileResponse> response = apiInstance.GetHolderProfileWithHttpInfo(providerAccountId, accountId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VerificationApi.GetHolderProfileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **providerAccountId** | **string** | providerAccountId. |  |
| **accountId** | **string** | accountId | [optional]  |

### Return type

[**HolderProfileResponse**](HolderProfileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y901 : Service not supported&lt;br&gt;Y800 : Invalid value for providerAccountId&lt;br&gt;Y800 : Invalid value for accountId. Only ACTIVE accountIds are supported&lt;br&gt;Y800 : Invalid value for accountId. All accountIds should belong to the same providerAccountId&lt;br&gt;Y803 : providerAccountId required&lt;br&gt;Y805 : Multiple providerAccountId not supported&lt;br&gt;Y820 : The accountId is not supported for containers other than bank and investment&lt;br&gt;can only be invoked after the verification process is completed&lt;br&gt;Y824 : The maximum number of accountIds permitted is 10&lt;br&gt;Y878 : Profile data is not yet requested for this account |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getverificationstatus"></a>
# **GetVerificationStatus**
> VerificationStatusResponse GetVerificationStatus (string accountId = null, string providerAccountId = null, string verificationType = null)

Get Verification Status

The get verification status service is used to retrieve the verification status of all accounts for which the MS or CDV process has been initiated.<br>For the MS process, the account details object returns the aggregated information of the verified accounts. For the CDV process, the account details object returns the user provided account information.<br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetVerificationStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new VerificationApi(config);
            var accountId = "accountId_example";  // string | Comma separated accountId (optional) 
            var providerAccountId = "providerAccountId_example";  // string | Comma separated providerAccountId (optional) 
            var verificationType = "verificationType_example";  // string | verificationType (optional) 

            try
            {
                // Get Verification Status
                VerificationStatusResponse result = apiInstance.GetVerificationStatus(accountId, providerAccountId, verificationType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VerificationApi.GetVerificationStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVerificationStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Verification Status
    ApiResponse<VerificationStatusResponse> response = apiInstance.GetVerificationStatusWithHttpInfo(accountId, providerAccountId, verificationType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VerificationApi.GetVerificationStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Comma separated accountId | [optional]  |
| **providerAccountId** | **string** | Comma separated providerAccountId | [optional]  |
| **verificationType** | **string** | verificationType | [optional]  |

### Return type

[**VerificationStatusResponse**](VerificationStatusResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y901 : Service not supported&lt;br&gt;Y813 : Either of accountId or providerAccountId should be provided&lt;br&gt;Y800 : Invalid value for accountId&lt;br&gt;Y800 : Invalid value for verification.verificationType&lt;br&gt;Y800 : Invalid value for providerAccountId&lt;br&gt;Y835 : Account(s) not eligible for Matching verification&lt;br&gt;Y836 : No verification initiated |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getverifiedaccounts"></a>
# **GetVerifiedAccounts**
> VerifiedAccountResponse GetVerifiedAccounts (string providerAccountId, string accountId = null, string isSelected = null, string verificationStatus = null)

Get Verified Accounts

The Verified Accounts API v1.1 provides information about the bank and investment accounts that the user  has selected for verification, during the Account Verification flow on FastLink 4. By default, the API only returns information of the accounts that were selected and have been successfully verified. <br><br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetVerifiedAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new VerificationApi(config);
            var providerAccountId = "providerAccountId_example";  // string | providerAccountId.
            var accountId = "accountId_example";  // string | Comma separated accountIds. (optional) 
            var isSelected = "isSelected_example";  // string | Comma separated isSelected. Allowed values are true, false <br><b>Note:</b> If no value is passed, the implicit default value is true. (optional) 
            var verificationStatus = "verificationStatus_example";  // string | Comma separated verificationStatus. Allowed values are SUCCESS, FAILED <br><b>Note:</b> If no value is passed, the implicit default value is SUCCESS. (optional) 

            try
            {
                // Get Verified Accounts
                VerifiedAccountResponse result = apiInstance.GetVerifiedAccounts(providerAccountId, accountId, isSelected, verificationStatus);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VerificationApi.GetVerifiedAccounts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVerifiedAccountsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Verified Accounts
    ApiResponse<VerifiedAccountResponse> response = apiInstance.GetVerifiedAccountsWithHttpInfo(providerAccountId, accountId, isSelected, verificationStatus);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VerificationApi.GetVerifiedAccountsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **providerAccountId** | **string** | providerAccountId. |  |
| **accountId** | **string** | Comma separated accountIds. | [optional]  |
| **isSelected** | **string** | Comma separated isSelected. Allowed values are true, false &lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; If no value is passed, the implicit default value is true. | [optional]  |
| **verificationStatus** | **string** | Comma separated verificationStatus. Allowed values are SUCCESS, FAILED &lt;br&gt;&lt;b&gt;Note:&lt;/b&gt; If no value is passed, the implicit default value is SUCCESS. | [optional]  |

### Return type

[**VerifiedAccountResponse**](VerifiedAccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y813 : providerAccountId should be provided&lt;br&gt;Y800 : Invalid value for providerAccountId&lt;br&gt;Y800 : Invalid value for verificationStatus&lt;br&gt;Y800 : Invalid value for isSelected&lt;br&gt;Y800 : Invalid value for accountId&lt;br&gt;Y807 : Resource not found&lt;br&gt;Y871 : The verification process for the request is still in progress. This API can only be invoked after the verification process is completed&lt;br&gt;Y824 : The maximum number of accountIds permitted is 10 |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="initiatematchingorchallengedepositeverification"></a>
# **InitiateMatchingOrChallengeDepositeVerification**
> VerificationResponse InitiateMatchingOrChallengeDepositeVerification (VerificationRequest verificationParam)

Initiaite Challenge Deposit

The post verification service is used to initiate the matching service (MS) and the challenge deposit account verification (CDV) process to verify account ownership.<br>The MS and CDV process can verify ownership of only bank accounts (i.e., checking and savings).<br>The MS verification can be initiated only for an already aggregated account or a providerAccount.<br>The prerequisite for the MS verification process is to request the ACCT_PROFILE dataset with the HOLDER_NAME attribute.<br>In the MS verification process, a string-match of the account holder name with the registered user name is performed instantaneously. You can contact the Yodlee CustomerCare to configure the full name or only the last name match.<br>Once the CDV process is initiated Yodlee will post the microtransaction (i.e., credit and debit) in the user's account. The CDV process takes 2 to 3 days to complete as it requires the user to provide the microtransaction details.<br>The CDV process is currently supported only in the United States.<br>The verificationId in the response can be used to track the verification request.<br><br><b>Notes:</b><li>This endpoint cannot be used to test the CDV functionality in the developer sandbox or test environment. You will need a money transmitter license to implement the CDV functionality and also require the Yodlee Professional Services team's assistance to set up a dedicated environment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class InitiateMatchingOrChallengeDepositeVerificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new VerificationApi(config);
            var verificationParam = new VerificationRequest(); // VerificationRequest | verification information

            try
            {
                // Initiaite Challenge Deposit
                VerificationResponse result = apiInstance.InitiateMatchingOrChallengeDepositeVerification(verificationParam);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VerificationApi.InitiateMatchingOrChallengeDepositeVerification: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InitiateMatchingOrChallengeDepositeVerificationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Initiaite Challenge Deposit
    ApiResponse<VerificationResponse> response = apiInstance.InitiateMatchingOrChallengeDepositeVerificationWithHttpInfo(verificationParam);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VerificationApi.InitiateMatchingOrChallengeDepositeVerificationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **verificationParam** | [**VerificationRequest**](VerificationRequest.md) | verification information |  |

### Return type

[**VerificationResponse**](VerificationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y901 : Service not supported&lt;br&gt;Y812 : Required field/value - verification.verificationType missing in the verificationParam&lt;br&gt;Y812 : Required field/value - accountNumber missing in the verificationParam&lt;br&gt;Y812 : Required field/value - accountType missing in the verificationParam&lt;br&gt;Y812 : Required field/value - bankTransferCode missing in the verificationParam&lt;br&gt;Y812 : Required field/value - bankTransferCode.id missing in the verificationParam&lt;br&gt;Y812 : Required field/value - bankTransferCode.type missing in the verificationParam&lt;br&gt;Y800 : Invalid value for verification.verificationType&lt;br&gt;Y800 : Invalid value for verificationParam&lt;br&gt;Y800 : Invalid value for bankTransferCode.type&lt;br&gt;Y800 : Invalid value for bankTransferCode.id&lt;br&gt;Y800 : Invalid value for accountType&lt;br&gt;Y800 : Invalid value for accountId&lt;br&gt;Y813 : Account details should be provided&lt;br&gt;Y801 : Invalid length for accountNumber&lt;br&gt;Y835 : Account(s) not eligible for Challenge Deposit verification&lt;br&gt;Y806 : Invalid Input&lt;br&gt;Y840 : Verification has been initiated already&lt;br&gt;Y837 : Account has been verified already&lt;br&gt;Y800 : Invalid value for userClassification |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="verifychallengedeposit"></a>
# **VerifyChallengeDeposit**
> VerificationResponse VerifyChallengeDeposit (UpdateVerificationRequest verificationParam)

Verify Challenge Deposit

The put verification service is used to complete the challenge deposit verification (CDV) process.<br>This service is used only by the customer of CDV flow.<br>In the CDV process, the user-provided microtransaction details (i.e., credit and debit) is matched against the microtransactions posted by Yodlee. For a successful verification of the account's ownership both the microtransaction details should match.<br>The CDV process is currently supported only in the United States.<br><br><b>Notes:</b><ul><li>This endpoint cannot be used to test the CDV functionality in the developer sandbox or test environment. You will need a money transmitter license to implement the CDV functionality and also require the Yodlee Professional Services team's assistance to set up a dedicated environment.</li></ul>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class VerifyChallengeDepositExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new VerificationApi(config);
            var verificationParam = new UpdateVerificationRequest(); // UpdateVerificationRequest | verification information

            try
            {
                // Verify Challenge Deposit
                VerificationResponse result = apiInstance.VerifyChallengeDeposit(verificationParam);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VerificationApi.VerifyChallengeDeposit: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VerifyChallengeDepositWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Verify Challenge Deposit
    ApiResponse<VerificationResponse> response = apiInstance.VerifyChallengeDepositWithHttpInfo(verificationParam);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VerificationApi.VerifyChallengeDepositWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **verificationParam** | [**UpdateVerificationRequest**](UpdateVerificationRequest.md) | verification information |  |

### Return type

[**VerificationResponse**](VerificationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y901 : Service not supported&lt;br&gt;Y812 : Required field/value - verification.verificationType missing in the verificationParam&lt;br&gt;Y812 : Required field/value - amount.amount missing in the verificationParam&lt;br&gt;Y812 : Required field/value - baseType missing in the verificationParam&lt;br&gt;Y812 : Required field/value - currency missing in the verificationParam&lt;br&gt;Y812 : Required field/value - providerAccountId missing in the verificationParam&lt;br&gt;Y812 : Required field/value - accountId missing in the verificationParam&lt;br&gt;Y800 : Invalid value for verificationParam&lt;br&gt;Y800 : Invalid value for verification.verificationType&lt;br&gt;Y800 : Invalid value for baseType&lt;br&gt;Y800 : Invalid value for providerAccountId&lt;br&gt;Y800 : Invalid value for accountId&lt;br&gt;Y813 : Transaction should be provided&lt;br&gt;Y801 : Invalid length for accountNumber&lt;br&gt;Y801 : Invalid length for amount&lt;br&gt;Y835 : Account(s) not eligible for Challenge Deposit verification&lt;br&gt;Y806 : Invalid Input&lt;br&gt;Y840 : Verification has been initiated already&lt;br&gt;Y837 : Account has been verified already&lt;br&gt;Y838 : The currency code provided does not match with the currency of the transaction executed on the target account&lt;br&gt;Y846 : The number of financial transactions made on the target account does not match with the number of transactions entered by the user.&lt;br&gt;Y842 : Number of retries exceeded the maximum Challenge Deposit verification limit&lt;br&gt;Y844 : Financial Instructions were not executed successfully on the target account&lt;br&gt;Y845 : Verification time expired. Please try initiating challenge deposit again&lt;br&gt;Y868 : No action is allowed, as the data is being migrated to the Open Banking provider&lt;br&gt; |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


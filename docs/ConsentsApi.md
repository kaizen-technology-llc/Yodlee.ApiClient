# Yodlee.ApiClient.Api.ConsentsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateConsent**](ConsentsApi.md#createconsent) | **POST** /consents | Post Consent |
| [**GetConsentDetails**](ConsentsApi.md#getconsentdetails) | **GET** /consents/{consentId} | Get Authorization Details |
| [**GetConsentPreferences**](ConsentsApi.md#getconsentpreferences) | **GET** /consents/preferences | Get Consents Preferences |
| [**GetConsents**](ConsentsApi.md#getconsents) | **GET** /consents | Get Consents |
| [**RenewConsent**](ConsentsApi.md#renewconsent) | **PUT** /consents/{consentId}/renewal | Renew Consent |
| [**UpdateConsent**](ConsentsApi.md#updateconsent) | **PUT** /consents/{consentId} | Put Consent |

<a name="createconsent"></a>
# **CreateConsent**
> CreatedConsentResponse CreateConsent (CreateConsentRequest consentRequest)

Post Consent

The generate consent service is used to generate all the consent information and permissions associated to a provider. <br/>The scope provided in the response is based on the providerId and the datasets provided in the input. <br/>If no dataset value is provided, the datasets that are configured for the customer will be considered. <br/>The configured dataset can be overridden by providing the dataset as an input. <br/>If no applicationName is provided in the input, the default applicationName will be considered. <b>Note:</b>This service supports the localization feature and accepts locale as a header parameter.<br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class CreateConsentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ConsentsApi(config);
            var consentRequest = new CreateConsentRequest(); // CreateConsentRequest | Unique identifier for the provider site(mandatory), the name of the application,  <br/>the flag responsible to include html content in the response, <br/>when passed as true and the name of the dataset attribute supported by the provider.

            try
            {
                // Post Consent
                CreatedConsentResponse result = apiInstance.CreateConsent(consentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConsentsApi.CreateConsent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateConsentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Post Consent
    ApiResponse<CreatedConsentResponse> response = apiInstance.CreateConsentWithHttpInfo(consentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConsentsApi.CreateConsentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **consentRequest** | [**CreateConsentRequest**](CreateConsentRequest.md) | Unique identifier for the provider site(mandatory), the name of the application,  &lt;br/&gt;the flag responsible to include html content in the response, &lt;br/&gt;when passed as true and the name of the dataset attribute supported by the provider. |  |

### Return type

[**CreatedConsentResponse**](CreatedConsentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y800 : Invalid value for providerId &lt;br/&gt;Y807 : Resource not found &lt;br/&gt;Y800 : Invalid value for consentParam &lt;br/&gt;Y901 : Service not supported &lt;br/&gt;Y800 : Invalid value for applicationName &lt;br/&gt; |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconsentdetails"></a>
# **GetConsentDetails**
> UpdatedConsentResponse GetConsentDetails (long consentId)

Get Authorization Details

The get authorization URL for consent service provides the authorization URL for the renew consent flow, within the consent dashboard.<b>Note:</b>This service supports the localization feature and accepts locale as a header parameter.<br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetConsentDetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ConsentsApi(config);
            var consentId = 789L;  // long | Consent Id generated through POST Consent.

            try
            {
                // Get Authorization Details
                UpdatedConsentResponse result = apiInstance.GetConsentDetails(consentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConsentsApi.GetConsentDetails: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetConsentDetailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Authorization Details
    ApiResponse<UpdatedConsentResponse> response = apiInstance.GetConsentDetailsWithHttpInfo(consentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConsentsApi.GetConsentDetailsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **consentId** | **long** | Consent Id generated through POST Consent. |  |

### Return type

[**UpdatedConsentResponse**](UpdatedConsentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y800 : Invalid value for consentId &lt;br/&gt; |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconsentpreferences"></a>
# **GetConsentPreferences**
> ConsentPreferencesResponse GetConsentPreferences (string consentId)

Get Consents Preferences

This API service provides user's preferences for the consent

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetConsentPreferencesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ConsentsApi(config);
            var consentId = "consentId_example";  // string | consentId

            try
            {
                // Get Consents Preferences
                ConsentPreferencesResponse result = apiInstance.GetConsentPreferences(consentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConsentsApi.GetConsentPreferences: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetConsentPreferencesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Consents Preferences
    ApiResponse<ConsentPreferencesResponse> response = apiInstance.GetConsentPreferencesWithHttpInfo(consentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConsentsApi.GetConsentPreferencesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **consentId** | **string** | consentId |  |

### Return type

[**ConsentPreferencesResponse**](ConsentPreferencesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y800 : Invalid value for consentId &lt;br/&gt;Y812 :Required field/value - consentId missing in the request &lt;br/&gt; |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconsents"></a>
# **GetConsents**
> ConsentResponse GetConsents (string consentIds = null, string include = null, string providerAccountIds = null)

Get Consents

The get consent service is used to retrieve all the consents submitted to Yodlee. <br>The service can be used to build a manage consent interface or a consent dashboard to implement the renew and revoke consent flows.<br><b>Note:</b>This service supports the localization feature and accepts locale as a header parameter.<br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetConsentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ConsentsApi(config);
            var consentIds = "consentIds_example";  // string | Consent Id generated through POST Consent. (optional) 
            var include = "include_example";  // string | The flag responsible to include renew details like sharing duration and reauthorization required (optional) 
            var providerAccountIds = "providerAccountIds_example";  // string | Unique identifier for the provider account resource. This is created during account addition. (optional) 

            try
            {
                // Get Consents
                ConsentResponse result = apiInstance.GetConsents(consentIds, include, providerAccountIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConsentsApi.GetConsents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetConsentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Consents
    ApiResponse<ConsentResponse> response = apiInstance.GetConsentsWithHttpInfo(consentIds, include, providerAccountIds);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConsentsApi.GetConsentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **consentIds** | **string** | Consent Id generated through POST Consent. | [optional]  |
| **include** | **string** | The flag responsible to include renew details like sharing duration and reauthorization required | [optional]  |
| **providerAccountIds** | **string** | Unique identifier for the provider account resource. This is created during account addition. | [optional]  |

### Return type

[**ConsentResponse**](ConsentResponse.md)

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

<a name="renewconsent"></a>
# **RenewConsent**
> RenewConsentResponse RenewConsent (long consentId, RenewConsentRequest renewConsentRequest = null)

Renew Consent

The consent renewal service is used to renew the consent by validating the consent state. This API supports both UK and AU Open Banking. </br><b>Renewing an UK Open Banking consent:</b><br><li>Before the grace period of 90 days: The consent will be renewed using the third-party provider (TPP) renewal process that Yodlee does, and no consent reauthorisation is required.The API response will contain the complete renewed consent object.</li><li>After the grace period of 90 days: The API will provide an authorisation URL to redirect the user to the financial institution site to complete the consent reauthorization process.<br><b>Renewing an AU Open Banking consent:</b><br><b>consent duration days preference required consentParam</b><br><li>Invoke this API, and in the API response, an authorisation URL will be provided to redirect the user to the financial institution site to complete the consent reauthorisation process.</li><br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class RenewConsentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ConsentsApi(config);
            var consentId = 789L;  // long | Consent Id to be renewed.
            var renewConsentRequest = new RenewConsentRequest(); // RenewConsentRequest | renewal entity from consent details service. (optional) 

            try
            {
                // Renew Consent
                RenewConsentResponse result = apiInstance.RenewConsent(consentId, renewConsentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConsentsApi.RenewConsent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RenewConsentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Renew Consent
    ApiResponse<RenewConsentResponse> response = apiInstance.RenewConsentWithHttpInfo(consentId, renewConsentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConsentsApi.RenewConsentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **consentId** | **long** | Consent Id to be renewed. |  |
| **renewConsentRequest** | [**RenewConsentRequest**](RenewConsentRequest.md) | renewal entity from consent details service. | [optional]  |

### Return type

[**RenewConsentResponse**](RenewConsentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y800 : Invalid value for consentId &lt;br/&gt;Y800 : Invalid value for consentParam &lt;br/&gt;Y802 : The consent duration days is outside of the range selected during onboarding, hence consentDurationDays not allowed&lt;br/&gt;Y803 : consent duration days preference required consentParam &lt;br/&gt;Y812 : Required field/value - scopeId missing in the consentParam &lt;br/&gt; |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateconsent"></a>
# **UpdateConsent**
> UpdatedConsentResponse UpdateConsent (long consentId, UpdateConsentRequest consentRequest)

Put Consent

The update consent service is used to capture the user acceptance of the consent presented to him or her. <br/>This service returns the authorization-redirect URL that should be used to display to the user, the bank's authentication interface.<b>Note:</b>This service supports the localization feature and accepts locale as a header parameter.<br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class UpdateConsentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ConsentsApi(config);
            var consentId = 789L;  // long | Consent Id generated through POST Consent.
            var consentRequest = new UpdateConsentRequest(); // UpdateConsentRequest | Applicable Open Banking data cluster values.

            try
            {
                // Put Consent
                UpdatedConsentResponse result = apiInstance.UpdateConsent(consentId, consentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConsentsApi.UpdateConsent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateConsentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Put Consent
    ApiResponse<UpdatedConsentResponse> response = apiInstance.UpdateConsentWithHttpInfo(consentId, consentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConsentsApi.UpdateConsentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **consentId** | **long** | Consent Id generated through POST Consent. |  |
| **consentRequest** | [**UpdateConsentRequest**](UpdateConsentRequest.md) | Applicable Open Banking data cluster values. |  |

### Return type

[**UpdatedConsentResponse**](UpdatedConsentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y800 : Invalid value for consentId &lt;br/&gt;Y800 : Invalid value for consentParam &lt;br/&gt;Y802 : The consent duration days is outside of the range selected during onboarding, hence consentDurationDays not allowed&lt;br&gt;Y803 : consent duration days preference required consentParam &lt;br/&gt;Y812 : Required field/value - scopeId missing in the consentParam &lt;br/&gt; |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


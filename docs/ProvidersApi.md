# Yodlee.ApiClient.Api.ProvidersApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAllProviders**](ProvidersApi.md#getallproviders) | **GET** /providers | Get Providers |
| [**GetProvider**](ProvidersApi.md#getprovider) | **GET** /providers/{providerId} | Get Provider Details |
| [**GetProvidersCount**](ProvidersApi.md#getproviderscount) | **GET** /providers/count | Get Providers Count |

<a name="getallproviders"></a>
# **GetAllProviders**
> ProviderResponse GetAllProviders (string capability = null, string datasetfilter = null, string fullAccountNumberFields = null, long? institutionId = null, string name = null, string priority = null, string providerId = null, int? skip = null, int? top = null)

Get Providers

The get provider service is used to get all the providers that are enabled, search a provider service by name or routing number and get popular sites of a region. <br>Searching for a provider using a routing number is applicable only to the USA and Canada regions.<br>The valid values for priority are: <br>   1. cobrand: Returns providers enabled for the cobrand (Default priority)<br>   2. popular: Returns providers popular among users of the customer<br><br>Only the datasets, attributes, and containers that are enabled for the customer will be returned in the response.<br>Input for the dataset$filter should adhere to the following expression:<br><dataset.name>[<attribute.name>.container[<container> OR <container>] OR <attribute.name>.container[<container>]] <br>OR <dataset.name>[<attribute.name> OR <attribute.name>]<br><b>dataset$filter value examples:</b><br>ACCT_PROFILE[FULL_ACCT_NUMBER.container[bank OR investment OR creditCard]]<br>ACCT_PROFILE[FULL_ACCT_NUMBER.container[bank]]<br>BASIC_AGG_DATA[ACCOUNT_DETAILS.container[bank OR investment] OR HOLDINGS.container[bank]] OR ACCT_PROFILE[FULL_ACCT_NUMBER.container[bank]]<br>BASIC_AGG_DATA<br>BASIC_AGG_DATA OR ACCT_PROFILE<br>BASIC_AGG_DATA [ ACCOUNT_DETAILS OR HOLDINGS ]<br>BASIC_AGG_DATA [ ACCOUNT_DETAILS] OR DOCUMENT <br>BASIC_AGG_DATA [ BASIC_ACCOUNT_INFO OR ACCOUNT_DETAILS ] <br><br>The fullAcountNumberFields is specified to filter the providers that have paymentAccountNumber or unmaskedAccountNumber support in the FULL_ACCT_NUMBER dataset attribute.<br><b>Examples for usage of fullAccountNumberFields </b><br>dataset$filter=ACCT_PROFILE[ FULL_ACCT_NUMBER.container [ bank ]] &amp; fullAccountNumberFields=paymentAccountNumber<br>dataset$filter=ACCT_PROFILE[ FULL_ACCT_NUMBER.container [ bank ]] &amp; fullAccountNumberFields=unmaskedAccountNumber<br>dataset$filter=ACCT_PROFILE[ FULL_ACCT_NUMBER.container [ bank ]] &amp; fullAccountNumberFields=unmaskedAccountNumber,paymentAccountNumber<br><br>The skip and top parameters are used for pagination. In the skip and top parameters, pass the number of records to be skipped and retrieved, respectively.<br>The response header provides the links to retrieve the next and previous set of transactions.<br><br><b>Note:</b> <ol><li>In a product flow involving user interaction, Yodlee recommends invoking this service with filters.<li>Without filters, the service may perform slowly as it takes a few minutes to return data in the response.<li>The AuthParameter appears in the response only in case of token-based aggregation sites.<li>The pagination feature only applies when the priority parameter is set as cobrand. If no values are provided in the skip and top parameters, the API will only return the first 500 records.<li>This service supports the localization feature and accepts locale as a header parameter.<li>The capability has been deprecated in query parameter and response.</li></ol>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetAllProvidersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ProvidersApi(config);
            var capability = "capability_example";  // string | CHALLENGE_DEPOSIT_VERIFICATION - capability search is deprecated (optional) 
            var datasetfilter = "datasetfilter_example";  // string | Expression to filter the providers by dataset(s) or dataset attribute(s). The default value will be the dataset or dataset attributes configured as default for the customer. (optional) 
            var fullAccountNumberFields = "fullAccountNumberFields_example";  // string | Specify to filter the providers with values paymentAccountNumber,unmaskedAccountNumber. (optional) 
            var institutionId = 789L;  // long? | Institution Id for Single site selection (optional) 
            var name = "name_example";  // string | Name in minimum 1 character or routing number. (optional) 
            var priority = "priority_example";  // string | Search priority (optional) 
            var providerId = "providerId_example";  // string | Max 5 Comma seperated Provider Ids (optional) 
            var skip = 56;  // int? | skip (Min 0) - This is not applicable along with 'name' parameter. (optional) 
            var top = 56;  // int? | top (Max 500) - This is not applicable along with 'name' parameter. (optional) 

            try
            {
                // Get Providers
                ProviderResponse result = apiInstance.GetAllProviders(capability, datasetfilter, fullAccountNumberFields, institutionId, name, priority, providerId, skip, top);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvidersApi.GetAllProviders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllProvidersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Providers
    ApiResponse<ProviderResponse> response = apiInstance.GetAllProvidersWithHttpInfo(capability, datasetfilter, fullAccountNumberFields, institutionId, name, priority, providerId, skip, top);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProvidersApi.GetAllProvidersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **capability** | **string** | CHALLENGE_DEPOSIT_VERIFICATION - capability search is deprecated | [optional]  |
| **datasetfilter** | **string** | Expression to filter the providers by dataset(s) or dataset attribute(s). The default value will be the dataset or dataset attributes configured as default for the customer. | [optional]  |
| **fullAccountNumberFields** | **string** | Specify to filter the providers with values paymentAccountNumber,unmaskedAccountNumber. | [optional]  |
| **institutionId** | **long?** | Institution Id for Single site selection | [optional]  |
| **name** | **string** | Name in minimum 1 character or routing number. | [optional]  |
| **priority** | **string** | Search priority | [optional]  |
| **providerId** | **string** | Max 5 Comma seperated Provider Ids | [optional]  |
| **skip** | **int?** | skip (Min 0) - This is not applicable along with &#39;name&#39; parameter. | [optional]  |
| **top** | **int?** | top (Max 500) - This is not applicable along with &#39;name&#39; parameter. | [optional]  |

### Return type

[**ProviderResponse**](ProviderResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y800 : Invalid value for priority&lt;br&gt;Y800 : Invalid value for providerName&lt;br&gt;Y801 : Invalid length for a site search. The search string must have atleast 1 character&lt;br&gt;Y800 : Invalid value for skip&lt;br&gt;Y804 : Permitted values of top between 1 - 500&lt;br&gt;Y821 : Dataset not supported&lt;br&gt;Y820 : The additionalDataSet is not supported for Get provider API |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprovider"></a>
# **GetProvider**
> ProviderDetailResponse GetProvider (long providerId)

Get Provider Details

The get provider detail service is used to get detailed information including the login form for a provider.<br>The response is a provider object that includes information such as name of the provider, <br>provider's base URL, a list of containers supported by the provider, the login form details of the provider, etc.<br>Only enabled datasets, attributes and containers gets returned in the response.<br><br><b>Note:</b><li>This service supports the localization feature and accepts locale as a header parameter.<li>The capability has been deprecated in the response.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetProviderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ProvidersApi(config);
            var providerId = 789L;  // long | providerId

            try
            {
                // Get Provider Details
                ProviderDetailResponse result = apiInstance.GetProvider(providerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvidersApi.GetProvider: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProviderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Provider Details
    ApiResponse<ProviderDetailResponse> response = apiInstance.GetProviderWithHttpInfo(providerId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProvidersApi.GetProviderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **providerId** | **long** | providerId |  |

### Return type

[**ProviderDetailResponse**](ProviderDetailResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y800 : Invalid value for providerId |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproviderscount"></a>
# **GetProvidersCount**
> ProvidersCountResponse GetProvidersCount (string capability = null, string datasetfilter = null, string fullAccountNumberFields = null, string name = null, string priority = null)

Get Providers Count

The count service provides the total number of providers that get returned in the GET /providers depending on the input parameters passed.<br>If you are implementing pagination for providers, call this endpoint before calling GET /providers to know the number of providers that are returned for the input parameters passed.<br>The functionality of the input parameters remains the same as that of the GET /providers endpoint<br><br><b>Note:</b> <li>The capability has been deprecated in the query parameter.</li>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetProvidersCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ProvidersApi(config);
            var capability = "capability_example";  // string | CHALLENGE_DEPOSIT_VERIFICATION - capability search is deprecated (optional) 
            var datasetfilter = "datasetfilter_example";  // string | Expression to filter the providers by dataset(s) or dataset attribute(s). The default value will be the dataset or dataset attributes configured as default for the customer. (optional) 
            var fullAccountNumberFields = "fullAccountNumberFields_example";  // string | Specify to filter the providers with values paymentAccountNumber,unmaskedAccountNumber. (optional) 
            var name = "name_example";  // string | Name in minimum 1 character or routing number. (optional) 
            var priority = "priority_example";  // string | Search priority (optional) 

            try
            {
                // Get Providers Count
                ProvidersCountResponse result = apiInstance.GetProvidersCount(capability, datasetfilter, fullAccountNumberFields, name, priority);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvidersApi.GetProvidersCount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProvidersCountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Providers Count
    ApiResponse<ProvidersCountResponse> response = apiInstance.GetProvidersCountWithHttpInfo(capability, datasetfilter, fullAccountNumberFields, name, priority);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProvidersApi.GetProvidersCountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **capability** | **string** | CHALLENGE_DEPOSIT_VERIFICATION - capability search is deprecated | [optional]  |
| **datasetfilter** | **string** | Expression to filter the providers by dataset(s) or dataset attribute(s). The default value will be the dataset or dataset attributes configured as default for the customer. | [optional]  |
| **fullAccountNumberFields** | **string** | Specify to filter the providers with values paymentAccountNumber,unmaskedAccountNumber. | [optional]  |
| **name** | **string** | Name in minimum 1 character or routing number. | [optional]  |
| **priority** | **string** | Search priority | [optional]  |

### Return type

[**ProvidersCountResponse**](ProvidersCountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y800 : Invalid value for priority&lt;br&gt;Y800 : Invalid value for providerName&lt;br&gt;Y801 : Invalid length for a site search. The search string must have at least 1 character&lt;br&gt;Y800 : Invalid value for skip&lt;br&gt;Y804 : Permitted values of top between 1 - 500&lt;br&gt;Y821 : Dataset not supported&lt;br&gt;Y820 : The additionalDataSet is not supported for Get provider API |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# Yodlee.ApiClient.Api.HoldingsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAssetClassificationList**](HoldingsApi.md#getassetclassificationlist) | **GET** /holdings/assetClassificationList | Get Asset Classification List |
| [**GetHoldingTypeList**](HoldingsApi.md#getholdingtypelist) | **GET** /holdings/holdingTypeList | Get Holding Type List |
| [**GetHoldings**](HoldingsApi.md#getholdings) | **GET** /holdings | Get Holdings |
| [**GetSecurities**](HoldingsApi.md#getsecurities) | **GET** /holdings/securities | Get Security Details |

<a name="getassetclassificationlist"></a>
# **GetAssetClassificationList**
> HoldingAssetClassificationListResponse GetAssetClassificationList ()

Get Asset Classification List

The get asset classifications list service is used to get the supported asset classifications. <br>The response includes different classification types like assetClass, country, sector, style, etc. and the values corresponding to each type.<br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetAssetClassificationListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new HoldingsApi(config);

            try
            {
                // Get Asset Classification List
                HoldingAssetClassificationListResponse result = apiInstance.GetAssetClassificationList();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HoldingsApi.GetAssetClassificationList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAssetClassificationListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Asset Classification List
    ApiResponse<HoldingAssetClassificationListResponse> response = apiInstance.GetAssetClassificationListWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HoldingsApi.GetAssetClassificationListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**HoldingAssetClassificationListResponse**](HoldingAssetClassificationListResponse.md)

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

<a name="getholdingtypelist"></a>
# **GetHoldingTypeList**
> HoldingTypeListResponse GetHoldingTypeList ()

Get Holding Type List

The get holding types list service is used to get the supported holding types.<br>The response includes different holding types such as future, moneyMarketFund, stock, etc. and it returns the supported holding types <br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetHoldingTypeListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new HoldingsApi(config);

            try
            {
                // Get Holding Type List
                HoldingTypeListResponse result = apiInstance.GetHoldingTypeList();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HoldingsApi.GetHoldingTypeList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetHoldingTypeListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Holding Type List
    ApiResponse<HoldingTypeListResponse> response = apiInstance.GetHoldingTypeListWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HoldingsApi.GetHoldingTypeListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**HoldingTypeListResponse**](HoldingTypeListResponse.md)

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

<a name="getholdings"></a>
# **GetHoldings**
> HoldingResponse GetHoldings (string accountId = null, string assetClassificationClassificationType = null, string classificationValue = null, string include = null, string providerAccountId = null)

Get Holdings

The get holdings service is used to get the list of holdings of a user.<br>Supported holding types can be employeeStockOption, moneyMarketFund, bond, etc. and is obtained using get holding type list service. <br>Asset classifications for the holdings need to be requested through the \"include\" parameter.<br>Asset classification information for holdings are not available by default, as it is a premium feature.<br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetHoldingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new HoldingsApi(config);
            var accountId = "accountId_example";  // string | Comma separated accountId (optional) 
            var assetClassificationClassificationType = "assetClassificationClassificationType_example";  // string | e.g. Country, Sector, etc. (optional) 
            var classificationValue = "classificationValue_example";  // string | e.g. US (optional) 
            var include = "include_example";  // string | assetClassification (optional) 
            var providerAccountId = "providerAccountId_example";  // string | providerAccountId (optional) 

            try
            {
                // Get Holdings
                HoldingResponse result = apiInstance.GetHoldings(accountId, assetClassificationClassificationType, classificationValue, include, providerAccountId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HoldingsApi.GetHoldings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetHoldingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Holdings
    ApiResponse<HoldingResponse> response = apiInstance.GetHoldingsWithHttpInfo(accountId, assetClassificationClassificationType, classificationValue, include, providerAccountId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HoldingsApi.GetHoldingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Comma separated accountId | [optional]  |
| **assetClassificationClassificationType** | **string** | e.g. Country, Sector, etc. | [optional]  |
| **classificationValue** | **string** | e.g. US | [optional]  |
| **include** | **string** | assetClassification | [optional]  |
| **providerAccountId** | **string** | providerAccountId | [optional]  |

### Return type

[**HoldingResponse**](HoldingResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y800 : Invalid value for accountId&lt;br&gt;Y800 : Invalid value for providerAccountId&lt;br&gt;Y800 : Invalid value for include&lt;br&gt;Y800 : Invalid value for classificationType&lt;br&gt;Y800 : Invalid value for classificationValue&lt;br&gt;Y800 : Invalid value for include&lt;br&gt;Y400 : classificationType mismatch&lt;br&gt;Y400 : classificationValue mismatch&lt;br&gt;Y824 : The maximum number of accountIds permitted is 100 |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsecurities"></a>
# **GetSecurities**
> HoldingSecuritiesResponse GetSecurities (string holdingId = null)

Get Security Details

The get security details service is used to get all the security information for the holdings<br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetSecuritiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new HoldingsApi(config);
            var holdingId = "holdingId_example";  // string | Comma separated holdingId (optional) 

            try
            {
                // Get Security Details
                HoldingSecuritiesResponse result = apiInstance.GetSecurities(holdingId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HoldingsApi.GetSecurities: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSecuritiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Security Details
    ApiResponse<HoldingSecuritiesResponse> response = apiInstance.GetSecuritiesWithHttpInfo(holdingId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HoldingsApi.GetSecuritiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **holdingId** | **string** | Comma separated holdingId | [optional]  |

### Return type

[**HoldingSecuritiesResponse**](HoldingSecuritiesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y800 : Invalid value for holdingId&lt;br&gt;Y824 : The maximum number of holdingIds permitted is 100 |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


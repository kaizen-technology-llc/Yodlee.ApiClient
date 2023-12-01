# Yodlee.ApiClient.Api.DerivedApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetHoldingSummary**](DerivedApi.md#getholdingsummary) | **GET** /derived/holdingSummary | Get Holding Summary |
| [**GetNetworth**](DerivedApi.md#getnetworth) | **GET** /derived/networth | Get Networth Summary |
| [**GetTransactionSummary**](DerivedApi.md#gettransactionsummary) | **GET** /derived/transactionSummary | Get Transaction Summary |

<a name="getholdingsummary"></a>
# **GetHoldingSummary**
> DerivedHoldingSummaryResponse GetHoldingSummary (string accountIds = null, string classificationType = null, string include = null)

Get Holding Summary

The get holding summary service is used to get the summary of asset classifications for the user.<br>By default, accounts with status as ACTIVE and TO BE CLOSED will be considered.<br>If the include parameter value is passed as details then a summary with holdings and account information is returned.<br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetHoldingSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DerivedApi(config);
            var accountIds = "accountIds_example";  // string | Comma separated accountIds (optional) 
            var classificationType = "classificationType_example";  // string | e.g. Country, Sector, etc. (optional) 
            var include = "include_example";  // string | details (optional) 

            try
            {
                // Get Holding Summary
                DerivedHoldingSummaryResponse result = apiInstance.GetHoldingSummary(accountIds, classificationType, include);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DerivedApi.GetHoldingSummary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetHoldingSummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Holding Summary
    ApiResponse<DerivedHoldingSummaryResponse> response = apiInstance.GetHoldingSummaryWithHttpInfo(accountIds, classificationType, include);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DerivedApi.GetHoldingSummaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountIds** | **string** | Comma separated accountIds | [optional]  |
| **classificationType** | **string** | e.g. Country, Sector, etc. | [optional]  |
| **include** | **string** | details | [optional]  |

### Return type

[**DerivedHoldingSummaryResponse**](DerivedHoldingSummaryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y800 : Invalid value for classificationType&lt;br&gt;Y814 : Exchange rate not available for currency&lt;br&gt;Y824 : The maximum number of accountIds permitted is 100&lt;br&gt; |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnetworth"></a>
# **GetNetworth**
> DerivedNetworthResponse GetNetworth (string accountIds = null, string container = null, string fromDate = null, string include = null, string interval = null, int? skip = null, string toDate = null, int? top = null)

Get Networth Summary

The get networth service is used to get the networth for the user.<br>If the include parameter value is passed as details then networth with historical balances is returned. <br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetNetworthExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DerivedApi(config);
            var accountIds = "accountIds_example";  // string | comma separated accountIds (optional) 
            var container = "container_example";  // string | bank/creditCard/investment/insurance/loan/realEstate/otherAssets/otherLiabilities (optional) 
            var fromDate = "fromDate_example";  // string | from date for balance retrieval (YYYY-MM-DD) (optional) 
            var include = "include_example";  // string | details (optional) 
            var interval = "interval_example";  // string | D-daily, W-weekly or M-monthly (optional) 
            var skip = 56;  // int? | skip (Min 0) (optional) 
            var toDate = "toDate_example";  // string | toDate for balance retrieval (YYYY-MM-DD) (optional) 
            var top = 56;  // int? | top (Max 500) (optional) 

            try
            {
                // Get Networth Summary
                DerivedNetworthResponse result = apiInstance.GetNetworth(accountIds, container, fromDate, include, interval, skip, toDate, top);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DerivedApi.GetNetworth: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetNetworthWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Networth Summary
    ApiResponse<DerivedNetworthResponse> response = apiInstance.GetNetworthWithHttpInfo(accountIds, container, fromDate, include, interval, skip, toDate, top);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DerivedApi.GetNetworthWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountIds** | **string** | comma separated accountIds | [optional]  |
| **container** | **string** | bank/creditCard/investment/insurance/loan/realEstate/otherAssets/otherLiabilities | [optional]  |
| **fromDate** | **string** | from date for balance retrieval (YYYY-MM-DD) | [optional]  |
| **include** | **string** | details | [optional]  |
| **interval** | **string** | D-daily, W-weekly or M-monthly | [optional]  |
| **skip** | **int?** | skip (Min 0) | [optional]  |
| **toDate** | **string** | toDate for balance retrieval (YYYY-MM-DD) | [optional]  |
| **top** | **int?** | top (Max 500) | [optional]  |

### Return type

[**DerivedNetworthResponse**](DerivedNetworthResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y800 : Invalid value for accountIds&lt;br&gt;Y800 : Invalid value for fromDate&lt;br&gt;Y800 : Invalid value for toDate&lt;br&gt;Y809 : Invalid date range&lt;br&gt;Y800 : Invalid value for interval&lt;br&gt;Y802 : Future date not allowed&lt;br&gt;Y814 : Exchange rate not available for currency&lt;br&gt;Y800 : Invalid value for container |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransactionsummary"></a>
# **GetTransactionSummary**
> DerivedTransactionSummaryResponse GetTransactionSummary (string groupBy, string accountId = null, string categoryId = null, string categoryType = null, string fromDate = null, string include = null, bool? includeUserCategory = null, string interval = null, string toDate = null)

Get Transaction Summary

The transaction summary service provides the summary values of transactions for the given date range by category type, high-level categories, or system-defined categories.<br><br>Yodlee has the transaction data stored for a day, month, year and week per category as per the availability of user's data. If the include parameter value is passed as details, then summary details will be returned depending on the interval passed-monthly is the default.<br><br><b>Notes:</b><ol> <li> Details can be requested for only one system-defined category<li>Passing categoryType is mandatory except when the groupBy value is CATEGORY_TYPE<li>Dates will not be respected for monthly, yearly, and weekly details<li>When monthly details are requested, only the fromDate and toDate month will be respected<li>When yearly details are requested, only the fromDate and toDate year will be respected<li>For weekly data points, details will be provided for every Sunday date available within the fromDate and toDate<li>This service supports the localization feature and accepts locale as a header parameter</li></ol>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetTransactionSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DerivedApi(config);
            var groupBy = "groupBy_example";  // string | CATEGORY_TYPE, HIGH_LEVEL_CATEGORY or CATEGORY
            var accountId = "accountId_example";  // string | comma separated account Ids (optional) 
            var categoryId = "categoryId_example";  // string | comma separated categoryIds (optional) 
            var categoryType = "categoryType_example";  // string | INCOME, EXPENSE, TRANSFER, UNCATEGORIZE or DEFERRED_COMPENSATION (optional) 
            var fromDate = "fromDate_example";  // string | YYYY-MM-DD format (optional) 
            var include = "include_example";  // string | details (optional) 
            var includeUserCategory = true;  // bool? | TRUE/FALSE (optional) 
            var interval = "interval_example";  // string | D-daily, W-weekly, M-mothly or Y-yearly (optional) 
            var toDate = "toDate_example";  // string | YYYY-MM-DD format (optional) 

            try
            {
                // Get Transaction Summary
                DerivedTransactionSummaryResponse result = apiInstance.GetTransactionSummary(groupBy, accountId, categoryId, categoryType, fromDate, include, includeUserCategory, interval, toDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DerivedApi.GetTransactionSummary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTransactionSummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Transaction Summary
    ApiResponse<DerivedTransactionSummaryResponse> response = apiInstance.GetTransactionSummaryWithHttpInfo(groupBy, accountId, categoryId, categoryType, fromDate, include, includeUserCategory, interval, toDate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DerivedApi.GetTransactionSummaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupBy** | **string** | CATEGORY_TYPE, HIGH_LEVEL_CATEGORY or CATEGORY |  |
| **accountId** | **string** | comma separated account Ids | [optional]  |
| **categoryId** | **string** | comma separated categoryIds | [optional]  |
| **categoryType** | **string** | INCOME, EXPENSE, TRANSFER, UNCATEGORIZE or DEFERRED_COMPENSATION | [optional]  |
| **fromDate** | **string** | YYYY-MM-DD format | [optional]  |
| **include** | **string** | details | [optional]  |
| **includeUserCategory** | **bool?** | TRUE/FALSE | [optional]  |
| **interval** | **string** | D-daily, W-weekly, M-mothly or Y-yearly | [optional]  |
| **toDate** | **string** | YYYY-MM-DD format | [optional]  |

### Return type

[**DerivedTransactionSummaryResponse**](DerivedTransactionSummaryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y010 : Invalid session&lt;br&gt;Y800 : Invalid value for accountId&lt;br&gt;Y800 : Invalid value for groupBy&lt;br&gt;Y803 : groupBy required&lt;br&gt;Y803 : categoryType required&lt;br&gt;Y800 : Invalid value for categoryId&lt;br&gt;Y800 : Invalid value for fromDate&lt;br&gt;Y800 : Invalid value for toDate&lt;br&gt;Y800 : Invalid value for fromDate or toDate&lt;br&gt;Y814 : Exchange rate not available for currency&lt;br&gt;Y815 : Cannot apply filter on categoryId if groupBy value is CATEGORY_TYPE&lt;br&gt;Y816 : User-defined category details can only be requested for one system categoryId with groupBy&#x3D;&#39;CATEGORY&#39;&lt;br&gt;Y824 : The maximum number of accountIds permitted is 100&lt;br&gt;Y824 : The maximum number of categoryIds permitted is 100&lt;br&gt;Y824 : The maximum number of categoryTypes permitted is 100 |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


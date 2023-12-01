# Yodlee.ApiClient.Api.DataExtractsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetDataExtractsEvents**](DataExtractsApi.md#getdataextractsevents) | **GET** /dataExtracts/events | Get Events |
| [**GetDataExtractsUserData**](DataExtractsApi.md#getdataextractsuserdata) | **GET** /dataExtracts/userData | Get userData |

<a name="getdataextractsevents"></a>
# **GetDataExtractsEvents**
> DataExtractsEventResponse GetDataExtractsEvents (string eventName, string fromDate, string toDate)

Get Events

The get extracts events service is used to learn about occurrences of data extract related events. This service currently supports only the DATA_UPDATES event.<br>Passing the event name as DATA_UPDATES provides information about users for whom data has been modified in the system for the specified time range. To learn more, please refer to the <a href=\"https://developer.yodlee.com/docs/api/1.1/DataExtracts\">dataExtracts</a> page.<br>You can retrieve data in increments of no more than 60 minutes over the period of the last 7 days from today's date.<br>This service is only invoked with either admin access token or a cobrand session.<br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetDataExtractsEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataExtractsApi(config);
            var eventName = "eventName_example";  // string | Event Name
            var fromDate = "fromDate_example";  // string | From DateTime (YYYY-MM-DDThh:mm:ssZ)
            var toDate = "toDate_example";  // string | To DateTime (YYYY-MM-DDThh:mm:ssZ)

            try
            {
                // Get Events
                DataExtractsEventResponse result = apiInstance.GetDataExtractsEvents(eventName, fromDate, toDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataExtractsApi.GetDataExtractsEvents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDataExtractsEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Events
    ApiResponse<DataExtractsEventResponse> response = apiInstance.GetDataExtractsEventsWithHttpInfo(eventName, fromDate, toDate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataExtractsApi.GetDataExtractsEventsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eventName** | **string** | Event Name |  |
| **fromDate** | **string** | From DateTime (YYYY-MM-DDThh:mm:ssZ) |  |
| **toDate** | **string** | To DateTime (YYYY-MM-DDThh:mm:ssZ) |  |

### Return type

[**DataExtractsEventResponse**](DataExtractsEventResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y800 : Invalid value for fromDate.fromDate cannot be greater than current time&lt;br&gt;Y800 : Invalid value for toDate.toDate cannot be greater than current time&lt;br&gt;Y800 : Invalid value for fromDate or toDate.fromDate and toDate cannot be older than 7 days&lt;br&gt;Y800 : Invalid value for fromDate.fromDate cannot be greater than toDate. |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdataextractsuserdata"></a>
# **GetDataExtractsUserData**
> DataExtractsUserDataResponse GetDataExtractsUserData (string fromDate, string loginName, string toDate)

Get userData

The get user data service is used to get a user's modified data for a particular period of time for accounts, transactions, holdings, and provider account information.<br>The time difference between fromDate and toDate fields cannot be more than 60 minutes.<br>By default, pagination is available for the transaction entity in this API. In the first response, the API will retrieve 500 transactions along with other data. The response header will provide a link to retrieve the next set of transactions.<br>In the response body of the first API response, totalTransactionsCount indicates the total number of transactions the API will retrieve for the user.<br>This service is only invoked with either admin access token or a cobrand session.<br/>Refer to <a href=\"https://developer.yodlee.com/docs/api/1.1/DataExtracts\">dataExtracts</a> page for more information.<br><br><b>Note:</b><li>This service supports the localization feature and accepts locale as a header parameter.</li>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetDataExtractsUserDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DataExtractsApi(config);
            var fromDate = "fromDate_example";  // string | From DateTime (YYYY-MM-DDThh:mm:ssZ)
            var loginName = "loginName_example";  // string | Login Name
            var toDate = "toDate_example";  // string | To DateTime (YYYY-MM-DDThh:mm:ssZ)

            try
            {
                // Get userData
                DataExtractsUserDataResponse result = apiInstance.GetDataExtractsUserData(fromDate, loginName, toDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataExtractsApi.GetDataExtractsUserData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDataExtractsUserDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get userData
    ApiResponse<DataExtractsUserDataResponse> response = apiInstance.GetDataExtractsUserDataWithHttpInfo(fromDate, loginName, toDate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataExtractsApi.GetDataExtractsUserDataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fromDate** | **string** | From DateTime (YYYY-MM-DDThh:mm:ssZ) |  |
| **loginName** | **string** | Login Name |  |
| **toDate** | **string** | To DateTime (YYYY-MM-DDThh:mm:ssZ) |  |

### Return type

[**DataExtractsUserDataResponse**](DataExtractsUserDataResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y800 : Invalid value for eventName&lt;br&gt;Y821 : Data update event not supported&lt;br&gt;Y800 : Invalid value for fromDate.fromDate cannot be greater than current time&lt;br&gt;Y800 : Invalid value for toDate.toDate cannot be greater than current time&lt;br&gt;.Y800 : Invalid value for fromDate or toDate.fromDate and toDate cannot be older than 7 days&lt;br&gt;Y800 : Invalid value for fromDate.fromDate can not be greater than toDate&lt;br&gt;Y800 : Invalid value for loginName |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


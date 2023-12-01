# Yodlee.ApiClient.Api.StatementsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetStatements**](StatementsApi.md#getstatements) | **GET** /statements | Get Statements |

<a name="getstatements"></a>
# **GetStatements**
> StatementResponse GetStatements (string accountId = null, string container = null, string fromDate = null, string isLatest = null, string status = null)

Get Statements

The statements service is used to get the list of statement related information. <br>By default, all the latest statements of active and to be closed accounts are retrieved for the user. <br>Certain sites do not have both a statement date and a due date. When a fromDate is passed as an input, all the statements that have the due date on or after the passed date are retrieved. <br>For sites that do not have the due date, statements that have the statement date on or after the passed date are retrieved. <br>The default value of \"isLatest\" is true. To retrieve historical statements isLatest needs to be set to false.<br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetStatementsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new StatementsApi(config);
            var accountId = "accountId_example";  // string | accountId (optional) 
            var container = "container_example";  // string | creditCard/loan/insurance (optional) 
            var fromDate = "fromDate_example";  // string | from date for statement retrieval (YYYY-MM-DD) (optional) 
            var isLatest = "isLatest_example";  // string | isLatest (true/false) (optional) 
            var status = "status_example";  // string | ACTIVE,TO_BE_CLOSED,CLOSED (optional) 

            try
            {
                // Get Statements
                StatementResponse result = apiInstance.GetStatements(accountId, container, fromDate, isLatest, status);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatementsApi.GetStatements: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStatementsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Statements
    ApiResponse<StatementResponse> response = apiInstance.GetStatementsWithHttpInfo(accountId, container, fromDate, isLatest, status);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StatementsApi.GetStatementsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | accountId | [optional]  |
| **container** | **string** | creditCard/loan/insurance | [optional]  |
| **fromDate** | **string** | from date for statement retrieval (YYYY-MM-DD) | [optional]  |
| **isLatest** | **string** | isLatest (true/false) | [optional]  |
| **status** | **string** | ACTIVE,TO_BE_CLOSED,CLOSED | [optional]  |

### Return type

[**StatementResponse**](StatementResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y800 : Invalid value for accountId&lt;br&gt;Y800 : Invalid value for status&lt;br&gt;Y805 : Multiple containers not supported&lt;br&gt;Y800 : Invalid value for container&lt;br&gt;Y800 : Invalid value for isLatest&lt;br&gt;Y800 : Invalid value for fromDate&lt;br&gt; |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


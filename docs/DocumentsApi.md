# Yodlee.ApiClient.Api.DocumentsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteDocument**](DocumentsApi.md#deletedocument) | **DELETE** /documents/{documentId} | Delete Document |
| [**DownloadDocument**](DocumentsApi.md#downloaddocument) | **GET** /documents/{documentId} | Download a Document |
| [**GetDocuments**](DocumentsApi.md#getdocuments) | **GET** /documents | Get Documents |

<a name="deletedocument"></a>
# **DeleteDocument**
> void DeleteDocument (string documentId)

Delete Document

The delete document service allows the consumer to delete a document. The deleted document will not be returned in the get documents API. The HTTP response code is 204 (success without content).<br>Documents can be deleted only if the document related dataset attributes are subscribed.<br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class DeleteDocumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DocumentsApi(config);
            var documentId = "documentId_example";  // string | documentId

            try
            {
                // Delete Document
                apiInstance.DeleteDocument(documentId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DocumentsApi.DeleteDocument: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteDocumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Document
    apiInstance.DeleteDocumentWithHttpInfo(documentId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DocumentsApi.DeleteDocumentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **documentId** | **string** | documentId |  |

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
| **400** | Y800 : Invalid value for documentId&lt;br&gt;Y868 : No action is allowed, as the data is being migrated to the Open Banking provider&lt;br&gt; |  -  |
| **401** | Unauthorized |  -  |
| **204** | OK |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="downloaddocument"></a>
# **DownloadDocument**
> DocumentDownloadResponse DownloadDocument (string documentId)

Download a Document

The get document details service allows consumers to download a document. The document is provided in base64.<br>This API is a premium service which requires subscription in advance to use.  Please contact Yodlee Client Services for more information. <br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class DownloadDocumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DocumentsApi(config);
            var documentId = "documentId_example";  // string | documentId

            try
            {
                // Download a Document
                DocumentDownloadResponse result = apiInstance.DownloadDocument(documentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DocumentsApi.DownloadDocument: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DownloadDocumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download a Document
    ApiResponse<DocumentDownloadResponse> response = apiInstance.DownloadDocumentWithHttpInfo(documentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DocumentsApi.DownloadDocumentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **documentId** | **string** | documentId |  |

### Return type

[**DocumentDownloadResponse**](DocumentDownloadResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y800 : Invalid value for documentId |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocuments"></a>
# **GetDocuments**
> DocumentResponse GetDocuments (string keyword = null, string accountId = null, string docType = null, string fromDate = null, string toDate = null)

Get Documents

The get documents service allows customers to search or retrieve metadata related to documents. <br>The API returns the document as per the input parameters passed. If no date range is provided then all downloaded documents will be retrieved. Details of deleted documents or documents associated to closed providerAccount will not be returned. <br>This API is a premium service which requires subscription in advance to use.  Please contact Yodlee Client Services for more information. <br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetDocumentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DocumentsApi(config);
            var keyword = "keyword_example";  // string | The string used to search a document by its name. (optional) 
            var accountId = "accountId_example";  // string | The unique identifier of an account. Retrieve documents for a given accountId. (optional) 
            var docType = "docType_example";  // string | Accepts only one of the following valid document types: STMT, TAX, and EBILL. (optional) 
            var fromDate = "fromDate_example";  // string | The date from which documents have to be retrieved. (optional) 
            var toDate = "toDate_example";  // string | The date to which documents have to be retrieved. (optional) 

            try
            {
                // Get Documents
                DocumentResponse result = apiInstance.GetDocuments(keyword, accountId, docType, fromDate, toDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DocumentsApi.GetDocuments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDocumentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Documents
    ApiResponse<DocumentResponse> response = apiInstance.GetDocumentsWithHttpInfo(keyword, accountId, docType, fromDate, toDate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DocumentsApi.GetDocumentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **keyword** | **string** | The string used to search a document by its name. | [optional]  |
| **accountId** | **string** | The unique identifier of an account. Retrieve documents for a given accountId. | [optional]  |
| **docType** | **string** | Accepts only one of the following valid document types: STMT, TAX, and EBILL. | [optional]  |
| **fromDate** | **string** | The date from which documents have to be retrieved. | [optional]  |
| **toDate** | **string** | The date to which documents have to be retrieved. | [optional]  |

### Return type

[**DocumentResponse**](DocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y800 : Invalid value for accountId&lt;br&gt;Y800 : Invalid value for fromDate&lt;br&gt;Y800 : Invalid value for toDate&lt;br&gt;Y800 : Invalid value for docType |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


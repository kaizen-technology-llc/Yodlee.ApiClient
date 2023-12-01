# Yodlee.ApiClient.Api.InstitutionsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetInstitutions**](InstitutionsApi.md#getinstitutions) | **GET** /institutions | Get institutions |

<a name="getinstitutions"></a>
# **GetInstitutions**
> InstitutionResponse GetInstitutions (string datasetfilter = null, string name = null, string priority = null, long? providerId = null, int? skip = null, int? top = null)

Get institutions

Yodlee classifies providers into credential-based aggregation and Open Banking (OB) providers. The get institutions service helps in identifying credential and related OB sites in a financial institution. The service searches for an institution regardless of the authentication types associated with the providers. Using the get institutions service, retrieve institutions enabled for the customer, search an institution by its name or routing number, and retrieve the popular institutions for a region. Searching for an institution using a routing number applies only to the USA and Canada regions.<br> The valid values for the priority parameter are: <br/> 1. all: Returns all the institutions enabled for the customer (the default value for the priority parameter).<br/> 2. search: Returns institutions matching the name provided by the user. The name parameter is mandatory if the priority parameter is set as search.<br/> 3. popular: Returns institutions that are popular among the customer's users.<br/> Only the datasets, attributes, and containers that are enabled for the customer will be returned in the response.<br/>Input for the dataset$filter should adhere to the following expression:<dataset.name>[<attribute.name>.container[<container> OR <container>] OR <attribute.name>.container[<container>]] <br>OR <dataset.name>[<attribute.name> OR <attribute.name>]<br><b>dataset$filter value examples:</b><br>ACCT_PROFILE[FULL_ACCT_NUMBER.container[bank OR investment OR creditCard]]<br>ACCT_PROFILE[FULL_ACCT_NUMBER.container[bank]]<br>BASIC_AGG_DATA[ACCOUNT_DETAILS.container[bank OR investment] OR HOLDINGS.container[bank]] OR ACCT_PROFILE[FULL_ACCT_NUMBER.container[bank]]<br>BASIC_AGG_DATA<br>BASIC_AGG_DATA OR ACCT_PROFILE<br>BASIC_AGG_DATA [ ACCOUNT_DETAILS OR HOLDINGS ]<br>BASIC_AGG_DATA [ ACCOUNT_DETAILS] OR DOCUMENT <br>BASIC_AGG_DATA [ BASIC_ACCOUNT_INFO OR ACCOUNT_DETAILS ] <br><br>The skip and top parameters are used for pagination. In the skip and top parameters, pass the number of records to be skipped and retrieved, respectively.<br>The response header provides the links to retrieve the next and previous set of transactions.<br><br><b>Note:</b> <br><br/> 1. If no value is set for the priority parameter, all the institutions enabled for the customer will be returned.<br/> 2. In a product flow involving user interaction, Yodlee recommends invoking this service with filters.<br/> Without filters, the service may perform slowly as it takes a few minutes to return data in the response.<br/> 3. The response includes comma separated provider IDs that are associated with the institution.<br/> 4. This service supports the localization feature and accepts locale as a header parameter.<br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetInstitutionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new InstitutionsApi(config);
            var datasetfilter = "datasetfilter_example";  // string | Expression to filter the providers by dataset(s) or dataset attribute(s). The default value will be the dataset or dataset attributes configured as default for the customer. (optional) 
            var name = "name_example";  // string | Name in minimum 1 character or routing number. (optional) 
            var priority = "priority_example";  // string | Search priority (optional) 
            var providerId = 789L;  // long? | providerId (optional) 
            var skip = 56;  // int? | skip (Min 0) - This is not applicable along with 'name' parameter. (optional) 
            var top = 56;  // int? | top (Max 500) - This is not applicable along with 'name' parameter. (optional) 

            try
            {
                // Get institutions
                InstitutionResponse result = apiInstance.GetInstitutions(datasetfilter, name, priority, providerId, skip, top);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstitutionsApi.GetInstitutions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInstitutionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get institutions
    ApiResponse<InstitutionResponse> response = apiInstance.GetInstitutionsWithHttpInfo(datasetfilter, name, priority, providerId, skip, top);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstitutionsApi.GetInstitutionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **datasetfilter** | **string** | Expression to filter the providers by dataset(s) or dataset attribute(s). The default value will be the dataset or dataset attributes configured as default for the customer. | [optional]  |
| **name** | **string** | Name in minimum 1 character or routing number. | [optional]  |
| **priority** | **string** | Search priority | [optional]  |
| **providerId** | **long?** | providerId | [optional]  |
| **skip** | **int?** | skip (Min 0) - This is not applicable along with &#39;name&#39; parameter. | [optional]  |
| **top** | **int?** | top (Max 500) - This is not applicable along with &#39;name&#39; parameter. | [optional]  |

### Return type

[**InstitutionResponse**](InstitutionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y800 : Invalid value for priority&lt;br&gt;Y800 : Invalid value for skip&lt;br&gt;Y804 : Permitted values of top between 1 - 500&lt;br&gt;Y821 : Dataset not supported&lt;br&gt; |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


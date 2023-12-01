# Yodlee.ApiClient.Api.TransactionsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateOrRunTransactionCategorizationRules**](TransactionsApi.md#createorruntransactioncategorizationrules) | **POST** /transactions/categories/rules | Create or Run Transaction Categorization Rule |
| [**CreateTransactionCategory**](TransactionsApi.md#createtransactioncategory) | **POST** /transactions/categories | Create Category |
| [**DeleteTransactionCategorizationRule**](TransactionsApi.md#deletetransactioncategorizationrule) | **DELETE** /transactions/categories/rules/{ruleId} | Delete Transaction Categorization Rule |
| [**DeleteTransactionCategory**](TransactionsApi.md#deletetransactioncategory) | **DELETE** /transactions/categories/{categoryId} | Delete Category |
| [**GetTransactionCategories**](TransactionsApi.md#gettransactioncategories) | **GET** /transactions/categories | Get Transaction Category List |
| [**GetTransactionCategorizationRules**](TransactionsApi.md#gettransactioncategorizationrules) | **GET** /transactions/categories/txnRules | Get Transaction Categorization Rules |
| [**GetTransactionCategorizationRulesDeprecated**](TransactionsApi.md#gettransactioncategorizationrulesdeprecated) | **GET** /transactions/categories/rules | Get Transaction Categorization Rules |
| [**GetTransactions**](TransactionsApi.md#gettransactions) | **GET** /transactions | Get Transactions |
| [**GetTransactionsCount**](TransactionsApi.md#gettransactionscount) | **GET** /transactions/count | Get Transactions Count |
| [**RunTransactionCategorizationRule**](TransactionsApi.md#runtransactioncategorizationrule) | **POST** /transactions/categories/rules/{ruleId} | Run Transaction Categorization Rule |
| [**UpdateTransaction**](TransactionsApi.md#updatetransaction) | **PUT** /transactions/{transactionId} | Update Transaction |
| [**UpdateTransactionCategorizationRule**](TransactionsApi.md#updatetransactioncategorizationrule) | **PUT** /transactions/categories/rules/{ruleId} | Update Transaction Categorization Rule |
| [**UpdateTransactionCategory**](TransactionsApi.md#updatetransactioncategory) | **PUT** /transactions/categories | Update Category |

<a name="createorruntransactioncategorizationrules"></a>
# **CreateOrRunTransactionCategorizationRules**
> void CreateOrRunTransactionCategorizationRules (string action = null, string ruleParam = null)

Create or Run Transaction Categorization Rule

The Create or Run Transaction Categorization Rule endpoint is used to: <br>Create transaction categorization rules for both system and user-defined categories.<br>Run all the transaction categorization rules to categorize transactions by calling the endpoint with action=run as the query parameter. <br><br>The input body parameters to create transaction categorization rules follow:<br>     categoryId - This field is mandatory and numeric<br>     priority - This field is optional and numeric. Priority decides the order in which the rule gets applied on transactions.<br>     ruleClause - This field is mandatory and should contain at least one rule<br>     field - The value can be description or amount<br><br>       If the field value is description then,<br>         1. operation - value can be stringEquals or stringContains<br>         2. value - value should be min of 3 and max of 50 characters<br><br>       If the field value is amount then, <br>         1. operation - value can be numberEquals, numberLessThan, numberLessThanEquals, numberGreaterThan or numberGreaterThanEquals<br>         2. value - min value 0 and a max value of 99999999999.99 is allowed<br>The HTTP response code is 201 (Created Successfully).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class CreateOrRunTransactionCategorizationRulesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TransactionsApi(config);
            var action = "action_example";  // string | To run rules, pass action=run. Only value run is supported (optional) 
            var ruleParam = "ruleParam_example";  // string | rules(JSON format) to categorize the transactions (optional) 

            try
            {
                // Create or Run Transaction Categorization Rule
                apiInstance.CreateOrRunTransactionCategorizationRules(action, ruleParam);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.CreateOrRunTransactionCategorizationRules: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateOrRunTransactionCategorizationRulesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create or Run Transaction Categorization Rule
    apiInstance.CreateOrRunTransactionCategorizationRulesWithHttpInfo(action, ruleParam);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.CreateOrRunTransactionCategorizationRulesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **action** | **string** | To run rules, pass action&#x3D;run. Only value run is supported | [optional]  |
| **ruleParam** | **string** | rules(JSON format) to categorize the transactions | [optional]  |

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
| **201** | Created Successfully |  -  |
| **400** | Y806 : Invalid input&lt;br&gt;Y400 : Rule already exists. Rule should be unique in terms of combination of description and amount |  -  |
| **401** | Unauthorized |  -  |
| **204** | No Content |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createtransactioncategory"></a>
# **CreateTransactionCategory**
> void CreateTransactionCategory (TransactionCategoryRequest transactionCategoryRequest)

Create Category

The create transaction categories service is used to create user-defined categories for a system-defined category.<br>The parentCategoryId is the system-defined category id.This can be retrieved using get transaction categories service.<br>The categoryName can accept minimum of 1, maximum of 50 alphanumeric or special characters.<br>The HTTP response code is 201 (Created successfully).<br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class CreateTransactionCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TransactionsApi(config);
            var transactionCategoryRequest = new TransactionCategoryRequest(); // TransactionCategoryRequest | User Transaction Category in JSON format

            try
            {
                // Create Category
                apiInstance.CreateTransactionCategory(transactionCategoryRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.CreateTransactionCategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTransactionCategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Category
    apiInstance.CreateTransactionCategoryWithHttpInfo(transactionCategoryRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.CreateTransactionCategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transactionCategoryRequest** | [**TransactionCategoryRequest**](TransactionCategoryRequest.md) | User Transaction Category in JSON format |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created Successfully |  -  |
| **400** | Y800 : Invalid value for categoryParam&lt;br&gt;Y800 : Invalid value for source&lt;br&gt;Y801 : Invalid length for categoryName. Min 1 and max 50 is required&lt;br&gt;Y803 : parentCategoryId required&lt;br&gt;Y811 : categoryName value already exists |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetransactioncategorizationrule"></a>
# **DeleteTransactionCategorizationRule**
> void DeleteTransactionCategorizationRule (long ruleId)

Delete Transaction Categorization Rule

The delete transaction categorization rule service is used to delete the given user-defined transaction categorization rule for both system-defined category as well as user-defined category.<br>This will delete all the corresponding rule clauses associated with the rule.<br>The HTTP response code is 204 (Success without content).<br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class DeleteTransactionCategorizationRuleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TransactionsApi(config);
            var ruleId = 789L;  // long | ruleId

            try
            {
                // Delete Transaction Categorization Rule
                apiInstance.DeleteTransactionCategorizationRule(ruleId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.DeleteTransactionCategorizationRule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTransactionCategorizationRuleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Transaction Categorization Rule
    apiInstance.DeleteTransactionCategorizationRuleWithHttpInfo(ruleId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.DeleteTransactionCategorizationRuleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ruleId** | **long** | ruleId |  |

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
| **400** | Y800 : Invalid value for ruleId |  -  |
| **401** | Unauthorized |  -  |
| **204** | Deleted Successfully |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetransactioncategory"></a>
# **DeleteTransactionCategory**
> void DeleteTransactionCategory (long categoryId)

Delete Category

The delete transaction categories service is used to delete the given user-defined category.<br>The HTTP response code is 204 (Success without content).<br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class DeleteTransactionCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TransactionsApi(config);
            var categoryId = 789L;  // long | categoryId

            try
            {
                // Delete Category
                apiInstance.DeleteTransactionCategory(categoryId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.DeleteTransactionCategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTransactionCategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Category
    apiInstance.DeleteTransactionCategoryWithHttpInfo(categoryId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.DeleteTransactionCategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **categoryId** | **long** | categoryId |  |

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
| **400** | Y800 : Invalid value for categoryId |  -  |
| **401** | Unauthorized |  -  |
| **204** | Deleted Successfully |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransactioncategories"></a>
# **GetTransactionCategories**
> TransactionCategoryResponse GetTransactionCategories ()

Get Transaction Category List

The categories service returns the list of available transaction categories.<br>High level category is returned in the response only if it is opted by the customer.<br>When invoked by passing the cobrand session or admin access token, this service returns the supported transaction categories at the cobrand level. <br>When invoked by passing the cobrand session and the user session or user access token, this service returns the transaction categories <br>along with user-defined categories.<br>Double quotes in the user-defined category name will be prefixed by backslashes (&#92;) in the response, <br>e.g. Toys \"R\" Us.<br/>Source and id are the primary attributes of the category entity.<br><br><b>Note:</b><li>This service supports the localization feature and accepts locale as a header parameter.</li>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetTransactionCategoriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TransactionsApi(config);

            try
            {
                // Get Transaction Category List
                TransactionCategoryResponse result = apiInstance.GetTransactionCategories();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.GetTransactionCategories: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTransactionCategoriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Transaction Category List
    ApiResponse<TransactionCategoryResponse> response = apiInstance.GetTransactionCategoriesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.GetTransactionCategoriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**TransactionCategoryResponse**](TransactionCategoryResponse.md)

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

<a name="gettransactioncategorizationrules"></a>
# **GetTransactionCategorizationRules**
> TransactionCategorizationRuleResponse GetTransactionCategorizationRules ()

Get Transaction Categorization Rules

The get transaction categorization rule service is used to get all the categorization rules.<br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetTransactionCategorizationRulesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TransactionsApi(config);

            try
            {
                // Get Transaction Categorization Rules
                TransactionCategorizationRuleResponse result = apiInstance.GetTransactionCategorizationRules();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.GetTransactionCategorizationRules: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTransactionCategorizationRulesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Transaction Categorization Rules
    ApiResponse<TransactionCategorizationRuleResponse> response = apiInstance.GetTransactionCategorizationRulesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.GetTransactionCategorizationRulesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**TransactionCategorizationRuleResponse**](TransactionCategorizationRuleResponse.md)

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

<a name="gettransactioncategorizationrulesdeprecated"></a>
# **GetTransactionCategorizationRulesDeprecated**
> List&lt;TransactionCategorizationRule&gt; GetTransactionCategorizationRulesDeprecated ()

Get Transaction Categorization Rules

The get transaction categorization rule service is used to get all the categorization rules.<br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetTransactionCategorizationRulesDeprecatedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TransactionsApi(config);

            try
            {
                // Get Transaction Categorization Rules
                List<TransactionCategorizationRule> result = apiInstance.GetTransactionCategorizationRulesDeprecated();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.GetTransactionCategorizationRulesDeprecated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTransactionCategorizationRulesDeprecatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Transaction Categorization Rules
    ApiResponse<List<TransactionCategorizationRule>> response = apiInstance.GetTransactionCategorizationRulesDeprecatedWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.GetTransactionCategorizationRulesDeprecatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;TransactionCategorizationRule&gt;**](TransactionCategorizationRule.md)

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

<a name="gettransactions"></a>
# **GetTransactions**
> TransactionResponse GetTransactions (string accountId = null, string baseType = null, string categoryId = null, string categoryType = null, string container = null, string detailCategoryId = null, string fromDate = null, string highLevelCategoryId = null, string keyword = null, int? skip = null, string toDate = null, int? top = null, string type = null)

Get Transactions

The Transaction service is used to get a list of transactions for a user.<br>By default, this service returns the last 30 days of transactions from today's date.<br>The keyword parameter performs a contains search on the original, consumer, and simple description attributes, replace the special characters #, &, and + with percent-encoding values %23, %26, and %2B respectively. Eg: for -Debit# , pass the input as -Debit%23.<br>Values for categoryId parameter can be fetched from get transaction category list service.<br> The categoryId is used to filter transactions based on system-defined category as well as user-defined category.<br>User-defined categoryIds should be provided in the filter with the prefix ''U''. E.g. U10002<br>The skip and top parameters are used for pagination. In the skip and top parameters pass the number of records to be skipped and retrieved, respectively. The response header provides the links to retrieve the next and previous set of transactions.<br>Double quotes in the merchant name will be prefixed by backslashes (&#92;) in the response, e.g. Toys \"R\" Us. <br>sourceId is a unique ID that the provider site has assigned to the transaction. The source ID is only available for the pre-populated accounts. Pre-populated accounts are the accounts that the FI customers shares with Yodlee, so that the user does not have to add or aggregate those accounts.<br><br><b>Note</b><ul><li><a href=\"https://developer.yodlee.com/docs/api/1.1/Transaction_Data_Enrichment\">TDE</a> is made available for bank and card accounts. The address field in the response is available only when the TDE key is turned on.</li><li>The pagination feature is available by default. If no values are passed in the skip and top parameters, the API will only return the first 500 transactions.</li><li>This service supports the localization feature and accepts locale as a header parameter.</li></ul>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TransactionsApi(config);
            var accountId = "accountId_example";  // string | Comma separated accountIds (optional) 
            var baseType = "baseType_example";  // string | DEBIT/CREDIT (optional) 
            var categoryId = "categoryId_example";  // string | Comma separated categoryIds (optional) 
            var categoryType = "categoryType_example";  // string | Transaction Category Type(UNCATEGORIZE, INCOME, TRANSFER, EXPENSE or DEFERRED_COMPENSATION) (optional) 
            var container = "container_example";  // string | bank/creditCard/investment/insurance/loan (optional) 
            var detailCategoryId = "detailCategoryId_example";  // string | Comma separated detailCategoryIds (optional) 
            var fromDate = "fromDate_example";  // string | Transaction from date(YYYY-MM-DD) (optional) 
            var highLevelCategoryId = "highLevelCategoryId_example";  // string | Comma separated highLevelCategoryIds (optional) 
            var keyword = "keyword_example";  // string | Transaction search text (optional) 
            var skip = 56;  // int? | skip (Min 0) (optional) 
            var toDate = "toDate_example";  // string | Transaction end date (YYYY-MM-DD) (optional) 
            var top = 56;  // int? | top (Max 500) (optional) 
            var type = "type_example";  // string | Transaction Type(SELL,SWEEP, etc.) for bank/creditCard/investment (optional) 

            try
            {
                // Get Transactions
                TransactionResponse result = apiInstance.GetTransactions(accountId, baseType, categoryId, categoryType, container, detailCategoryId, fromDate, highLevelCategoryId, keyword, skip, toDate, top, type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.GetTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Transactions
    ApiResponse<TransactionResponse> response = apiInstance.GetTransactionsWithHttpInfo(accountId, baseType, categoryId, categoryType, container, detailCategoryId, fromDate, highLevelCategoryId, keyword, skip, toDate, top, type);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.GetTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Comma separated accountIds | [optional]  |
| **baseType** | **string** | DEBIT/CREDIT | [optional]  |
| **categoryId** | **string** | Comma separated categoryIds | [optional]  |
| **categoryType** | **string** | Transaction Category Type(UNCATEGORIZE, INCOME, TRANSFER, EXPENSE or DEFERRED_COMPENSATION) | [optional]  |
| **container** | **string** | bank/creditCard/investment/insurance/loan | [optional]  |
| **detailCategoryId** | **string** | Comma separated detailCategoryIds | [optional]  |
| **fromDate** | **string** | Transaction from date(YYYY-MM-DD) | [optional]  |
| **highLevelCategoryId** | **string** | Comma separated highLevelCategoryIds | [optional]  |
| **keyword** | **string** | Transaction search text | [optional]  |
| **skip** | **int?** | skip (Min 0) | [optional]  |
| **toDate** | **string** | Transaction end date (YYYY-MM-DD) | [optional]  |
| **top** | **int?** | top (Max 500) | [optional]  |
| **type** | **string** | Transaction Type(SELL,SWEEP, etc.) for bank/creditCard/investment | [optional]  |

### Return type

[**TransactionResponse**](TransactionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y800 : Invalid value for baseType&lt;br&gt;Y800 : Invalid value for fromDate&lt;br&gt;Y800 : Invalid value for category&lt;br&gt;Y800 : Invalid value for toDate&lt;br&gt;Y800 : Invalid value for container&lt;br&gt;Y809 : Invalid date range&lt;br&gt;Y804 : Permitted values of top between 1 - 500&lt;br&gt;Y805 : Multiple containers not supported&lt;br&gt;Y800 : Invalid value for transaction type&lt;br&gt;Y824 : The maximum number of accountIds permitted is 100&lt;br&gt;Y824 : The maximum number of categoryIds permitted is 100&lt;br&gt;Y824 : The maximum number of highLevelCategoryIds permitted is 100&lt;br&gt;Y848 : detailCategoryId cannot be provided as input, as the detailedCategory feature is not enabled&lt;br&gt;Y823 : detailCategoryId is not for applicable containers other than bank and card&lt;br&gt;Y824 : The maximum number of detailCategoryIds permitted is 100&lt;br&gt;Y800 : Invalid value for detailCategoryId |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransactionscount"></a>
# **GetTransactionsCount**
> TransactionCountResponse GetTransactionsCount (string accountId = null, string baseType = null, string categoryId = null, string categoryType = null, string container = null, string detailCategoryId = null, string fromDate = null, string highLevelCategoryId = null, string keyword = null, string toDate = null, string type = null)

Get Transactions Count

The count service provides the total number of transactions for a specific user depending on the input parameters passed.<br>If you are implementing pagination for transactions, call this endpoint before calling GET /transactions to know the number of transactions that are returned for the input parameters passed.<br>The functionality of the input parameters remains the same as that of the GET /transactions endpoint.<br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetTransactionsCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TransactionsApi(config);
            var accountId = "accountId_example";  // string | Comma separated accountIds  (optional) 
            var baseType = "baseType_example";  // string | DEBIT/CREDIT (optional) 
            var categoryId = "categoryId_example";  // string | Comma separated categoryIds (optional) 
            var categoryType = "categoryType_example";  // string | Transaction Category Type(UNCATEGORIZE, INCOME, TRANSFER, EXPENSE or DEFERRED_COMPENSATION) (optional) 
            var container = "container_example";  // string | bank/creditCard/investment/insurance/loan (optional) 
            var detailCategoryId = "detailCategoryId_example";  // string | Comma separated detailCategoryIds (optional) 
            var fromDate = "fromDate_example";  // string | Transaction from date(YYYY-MM-DD) (optional) 
            var highLevelCategoryId = "highLevelCategoryId_example";  // string | Comma separated highLevelCategoryIds (optional) 
            var keyword = "keyword_example";  // string | Transaction search text  (optional) 
            var toDate = "toDate_example";  // string | Transaction end date (YYYY-MM-DD) (optional) 
            var type = "type_example";  // string | Transaction Type(SELL,SWEEP, etc.) (optional) 

            try
            {
                // Get Transactions Count
                TransactionCountResponse result = apiInstance.GetTransactionsCount(accountId, baseType, categoryId, categoryType, container, detailCategoryId, fromDate, highLevelCategoryId, keyword, toDate, type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.GetTransactionsCount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTransactionsCountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Transactions Count
    ApiResponse<TransactionCountResponse> response = apiInstance.GetTransactionsCountWithHttpInfo(accountId, baseType, categoryId, categoryType, container, detailCategoryId, fromDate, highLevelCategoryId, keyword, toDate, type);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.GetTransactionsCountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountId** | **string** | Comma separated accountIds  | [optional]  |
| **baseType** | **string** | DEBIT/CREDIT | [optional]  |
| **categoryId** | **string** | Comma separated categoryIds | [optional]  |
| **categoryType** | **string** | Transaction Category Type(UNCATEGORIZE, INCOME, TRANSFER, EXPENSE or DEFERRED_COMPENSATION) | [optional]  |
| **container** | **string** | bank/creditCard/investment/insurance/loan | [optional]  |
| **detailCategoryId** | **string** | Comma separated detailCategoryIds | [optional]  |
| **fromDate** | **string** | Transaction from date(YYYY-MM-DD) | [optional]  |
| **highLevelCategoryId** | **string** | Comma separated highLevelCategoryIds | [optional]  |
| **keyword** | **string** | Transaction search text  | [optional]  |
| **toDate** | **string** | Transaction end date (YYYY-MM-DD) | [optional]  |
| **type** | **string** | Transaction Type(SELL,SWEEP, etc.) | [optional]  |

### Return type

[**TransactionCountResponse**](TransactionCountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y800 : Invalid value for detailCategoryId&lt;br&gt;Y848 : detailCategoryId cannot be provided as input, as the detailedCategory feature is not enabled&lt;br&gt;Y823 : detailCategoryId is not applicable for containers other than bank and card&lt;br&gt;Y824 : The maximum number of detailCategoryIds permitted is 100&lt;br&gt; |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="runtransactioncategorizationrule"></a>
# **RunTransactionCategorizationRule**
> void RunTransactionCategorizationRule (string action, long ruleId)

Run Transaction Categorization Rule

The run transaction categorization rule service is used to run a rule on transactions, to categorize the transactions.<br>The HTTP response code is 204 (Success with no content).<br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class RunTransactionCategorizationRuleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TransactionsApi(config);
            var action = "run";  // string |  (default to run)
            var ruleId = 789L;  // long | Unique id of the categorization rule

            try
            {
                // Run Transaction Categorization Rule
                apiInstance.RunTransactionCategorizationRule(action, ruleId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.RunTransactionCategorizationRule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RunTransactionCategorizationRuleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Run Transaction Categorization Rule
    apiInstance.RunTransactionCategorizationRuleWithHttpInfo(action, ruleId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.RunTransactionCategorizationRuleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **action** | **string** |  | [default to run] |
| **ruleId** | **long** | Unique id of the categorization rule |  |

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
| **400** | Y800 : Invalid value for ruleId&lt;br&gt;Y400 : Categorization already in progress |  -  |
| **401** | Unauthorized |  -  |
| **204** | Run Successfully |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetransaction"></a>
# **UpdateTransaction**
> void UpdateTransaction (long transactionId, TransactionRequest transactionRequest)

Update Transaction

The update transaction service is used to update the category,consumer description, memo, isPhysical, merchantType, detailCategory for a transaction.<br>The HTTP response code is 204 (Success without content).<br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class UpdateTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TransactionsApi(config);
            var transactionId = 789L;  // long | transactionId
            var transactionRequest = new TransactionRequest(); // TransactionRequest | transactionRequest

            try
            {
                // Update Transaction
                apiInstance.UpdateTransaction(transactionId, transactionRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.UpdateTransaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Transaction
    apiInstance.UpdateTransactionWithHttpInfo(transactionId, transactionRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.UpdateTransactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transactionId** | **long** | transactionId |  |
| **transactionRequest** | [**TransactionRequest**](TransactionRequest.md) | transactionRequest |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Y812 : Required field -container missing in the transactionParam parameter input&lt;br&gt;Y800 : Invalid value for transactionId&lt;br&gt;Y800 : Invalid value for merchantType&lt;br&gt;Y800 : Invalid value for detailCategoryId&lt;br&gt;Y800 : Invalid value for categoryId&lt;br&gt;Y868 : No action is allowed, as the data is being migrated to the Open Banking provider&lt;br&gt; |  -  |
| **401** | Unauthorized |  -  |
| **204** | Updated Successfully |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetransactioncategorizationrule"></a>
# **UpdateTransactionCategorizationRule**
> void UpdateTransactionCategorizationRule (long ruleId, TransactionCategorizationRuleRequest transactionCategoriesRuleRequest)

Update Transaction Categorization Rule

The update transaction categorization rule service is used to update a categorization rule for both system-defined category as well as user-defined category.<br>ruleParam JSON input should be as explained in the create transaction categorization rule service.<br>The HTTP response code is 204 (Success without content).<br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class UpdateTransactionCategorizationRuleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TransactionsApi(config);
            var ruleId = 789L;  // long | ruleId
            var transactionCategoriesRuleRequest = new TransactionCategorizationRuleRequest(); // TransactionCategorizationRuleRequest | transactionCategoriesRuleRequest

            try
            {
                // Update Transaction Categorization Rule
                apiInstance.UpdateTransactionCategorizationRule(ruleId, transactionCategoriesRuleRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.UpdateTransactionCategorizationRule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTransactionCategorizationRuleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Transaction Categorization Rule
    apiInstance.UpdateTransactionCategorizationRuleWithHttpInfo(ruleId, transactionCategoriesRuleRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.UpdateTransactionCategorizationRuleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ruleId** | **long** | ruleId |  |
| **transactionCategoriesRuleRequest** | [**TransactionCategorizationRuleRequest**](TransactionCategorizationRuleRequest.md) | transactionCategoriesRuleRequest |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Y800 : Invalid value for ruleId&lt;br&gt;Y806 : Invalid input |  -  |
| **401** | Unauthorized |  -  |
| **204** | Updated Successfully |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetransactioncategory"></a>
# **UpdateTransactionCategory**
> void UpdateTransactionCategory (UpdateCategoryRequest updateCategoryRequest)

Update Category

The update transaction categories service is used to update the transaction category name<br>for a high level category, a system-defined category and a user-defined category.<br>The renamed category can be set back to the original name by passing an empty string for categoryName.<br>The categoryName can accept minimum of 1, maximum of 50 alphanumeric or special characters.<br>The HTTP response code is 204 (Success without content).<br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class UpdateTransactionCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TransactionsApi(config);
            var updateCategoryRequest = new UpdateCategoryRequest(); // UpdateCategoryRequest | updateCategoryRequest

            try
            {
                // Update Category
                apiInstance.UpdateTransactionCategory(updateCategoryRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.UpdateTransactionCategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTransactionCategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Category
    apiInstance.UpdateTransactionCategoryWithHttpInfo(updateCategoryRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.UpdateTransactionCategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateCategoryRequest** | [**UpdateCategoryRequest**](UpdateCategoryRequest.md) | updateCategoryRequest |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Y800 : Invalid value for categoryParam&lt;br&gt;Y800 : Invalid value for source&lt;br&gt;Y801 : Invalid length for categoryName. Min 1 and max 50 is required&lt;br&gt;Y803 : id required&lt;br&gt;Y811 : categoryName value already exists |  -  |
| **401** | Unauthorized |  -  |
| **204** | Updated Successfully |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


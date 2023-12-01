# Yodlee.ApiClient.Api.ConfigsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateSubscriptionNotificationEvent**](ConfigsApi.md#createsubscriptionnotificationevent) | **POST** /configs/notifications/events/{eventName} | Subscribe For Notification Event |
| [**DeleteSubscribedNotificationEvent**](ConfigsApi.md#deletesubscribednotificationevent) | **DELETE** /configs/notifications/events/{eventName} | Delete Notification Subscription |
| [**GetPublicEncryptionKey**](ConfigsApi.md#getpublicencryptionkey) | **GET** /configs/publicKey | Get Public Key |
| [**GetSubscribedNotificationEvents**](ConfigsApi.md#getsubscribednotificationevents) | **GET** /configs/notifications/events | Get Subscribed Notification Events |
| [**UpdateSubscribedNotificationEvent**](ConfigsApi.md#updatesubscribednotificationevent) | **PUT** /configs/notifications/events/{eventName} | Update Notification Subscription |

<a name="createsubscriptionnotificationevent"></a>
# **CreateSubscriptionNotificationEvent**
> void CreateSubscriptionNotificationEvent (string eventName, CreateConfigsNotificationEventRequest eventRequest)

Subscribe For Notification Event

The subscribe events service is used to subscribe to an event for receiving notifications.<br>The callback URL, where the notification will be posted should be provided to this service.<br>If the callback URL is invalid or inaccessible, the subscription will be unsuccessful, and an error will be thrown.<br>Customers can subscribe to REFRESH,DATA_UPDATES,AUTO_REFRESH_UPDATES,LATEST_BALANCE_UPDATES and CREDIT_ACCELERATOR_REPORT_UPDATES event.<br><br><b>Notes:</b><li>This service is not available in developer sandbox/test environment and will be made available for testing in your dedicated environment, once the contract is signed.<li>The content type has to be passed as application/json for the body parameter.</li>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class CreateSubscriptionNotificationEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ConfigsApi(config);
            var eventName = "REFRESH";  // string | Name of the webhook subscription event
            var eventRequest = new CreateConfigsNotificationEventRequest(); // CreateConfigsNotificationEventRequest | eventRequest

            try
            {
                // Subscribe For Notification Event
                apiInstance.CreateSubscriptionNotificationEvent(eventName, eventRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigsApi.CreateSubscriptionNotificationEvent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSubscriptionNotificationEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Subscribe For Notification Event
    apiInstance.CreateSubscriptionNotificationEventWithHttpInfo(eventName, eventRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigsApi.CreateSubscriptionNotificationEventWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eventName** | **string** | Name of the webhook subscription event |  |
| **eventRequest** | [**CreateConfigsNotificationEventRequest**](CreateConfigsNotificationEventRequest.md) | eventRequest |  |

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
| **201** | OK |  -  |
| **400** | Y803 : eventName required&lt;br&gt;Y803 : callbackUrl required&lt;br&gt;Y800 : Invalid value for callbackUrl&lt;br&gt;Y901 : Service not supported&lt;br&gt; |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesubscribednotificationevent"></a>
# **DeleteSubscribedNotificationEvent**
> void DeleteSubscribedNotificationEvent (string eventName)

Delete Notification Subscription

The delete events service is used to unsubscribe from an events service.<br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class DeleteSubscribedNotificationEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ConfigsApi(config);
            var eventName = "REFRESH";  // string | Name of the webhook subscription event

            try
            {
                // Delete Notification Subscription
                apiInstance.DeleteSubscribedNotificationEvent(eventName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigsApi.DeleteSubscribedNotificationEvent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSubscribedNotificationEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Notification Subscription
    apiInstance.DeleteSubscribedNotificationEventWithHttpInfo(eventName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigsApi.DeleteSubscribedNotificationEventWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eventName** | **string** | Name of the webhook subscription event |  |

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
| **400** | Y803 : eventName required |  -  |
| **401** | Unauthorized |  -  |
| **204** | OK |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpublicencryptionkey"></a>
# **GetPublicEncryptionKey**
> ConfigsPublicKeyResponse GetPublicEncryptionKey ()

Get Public Key

The get public key service provides the public key that should be used to encrypt user credentials while invoking POST /providerAccounts and PUT /providerAccounts endpoints.<br>This service will only work if the PKI (public key infrastructure) feature is enabled for the customer.<br><br><b>Note:</b><li> The key in the response is a string in PEM format.</li><li>This endpoint is not available in the Sandbox environment and it is useful only if the PKI feature is enabled.</li>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetPublicEncryptionKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ConfigsApi(config);

            try
            {
                // Get Public Key
                ConfigsPublicKeyResponse result = apiInstance.GetPublicEncryptionKey();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigsApi.GetPublicEncryptionKey: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPublicEncryptionKeyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Public Key
    ApiResponse<ConfigsPublicKeyResponse> response = apiInstance.GetPublicEncryptionKeyWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigsApi.GetPublicEncryptionKeyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ConfigsPublicKeyResponse**](ConfigsPublicKeyResponse.md)

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

<a name="getsubscribednotificationevents"></a>
# **GetSubscribedNotificationEvents**
> ConfigsNotificationResponse GetSubscribedNotificationEvents (string eventName = null)

Get Subscribed Notification Events

The get events service provides the list of events for which consumers subscribed to receive notifications. <br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetSubscribedNotificationEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ConfigsApi(config);
            var eventName = "REFRESH";  // string | Name of the webhook subscription event (optional) 

            try
            {
                // Get Subscribed Notification Events
                ConfigsNotificationResponse result = apiInstance.GetSubscribedNotificationEvents(eventName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigsApi.GetSubscribedNotificationEvents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSubscribedNotificationEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Subscribed Notification Events
    ApiResponse<ConfigsNotificationResponse> response = apiInstance.GetSubscribedNotificationEventsWithHttpInfo(eventName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigsApi.GetSubscribedNotificationEventsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eventName** | **string** | Name of the webhook subscription event | [optional]  |

### Return type

[**ConfigsNotificationResponse**](ConfigsNotificationResponse.md)

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

<a name="updatesubscribednotificationevent"></a>
# **UpdateSubscribedNotificationEvent**
> void UpdateSubscribedNotificationEvent (string eventName, UpdateConfigsNotificationEventRequest eventRequest)

Update Notification Subscription

The update events service is used to update the callback URL.<br>If the callback URL is invalid or inaccessible, the subscription will be unsuccessful, and an error will be thrown.<br><br><b>Note:</b> <li>The content type has to be passed as application/json for the body parameter. <br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class UpdateSubscribedNotificationEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ConfigsApi(config);
            var eventName = "REFRESH";  // string | Name of the webhook subscription event
            var eventRequest = new UpdateConfigsNotificationEventRequest(); // UpdateConfigsNotificationEventRequest | eventRequest

            try
            {
                // Update Notification Subscription
                apiInstance.UpdateSubscribedNotificationEvent(eventName, eventRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigsApi.UpdateSubscribedNotificationEvent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSubscribedNotificationEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Notification Subscription
    apiInstance.UpdateSubscribedNotificationEventWithHttpInfo(eventName, eventRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigsApi.UpdateSubscribedNotificationEventWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eventName** | **string** | Name of the webhook subscription event |  |
| **eventRequest** | [**UpdateConfigsNotificationEventRequest**](UpdateConfigsNotificationEventRequest.md) | eventRequest |  |

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
| **400** | Y803 : eventName required&lt;br&gt;Y803 : callbackUrl required&lt;br&gt;Y800 : Invalid value for callbackUrl |  -  |
| **401** | Unauthorized |  -  |
| **204** | OK |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


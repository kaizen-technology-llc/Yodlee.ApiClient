# Yodlee.ApiClient.Api.CobrandApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CobrandLogin**](CobrandApi.md#cobrandlogin) | **POST** /cobrand/login | Cobrand Login |
| [**CobrandLogout**](CobrandApi.md#cobrandlogout) | **POST** /cobrand/logout | Cobrand Logout |
| [**CreateSubscriptionEvent**](CobrandApi.md#createsubscriptionevent) | **POST** /cobrand/config/notifications/events/{eventName} | Subscribe Event |
| [**DeleteSubscribedEvent**](CobrandApi.md#deletesubscribedevent) | **DELETE** /cobrand/config/notifications/events/{eventName} | Delete Subscription |
| [**GetPublicKey**](CobrandApi.md#getpublickey) | **GET** /cobrand/publicKey | Get Public Key |
| [**GetSubscribedEvents**](CobrandApi.md#getsubscribedevents) | **GET** /cobrand/config/notifications/events | Get Subscribed Events |
| [**UpdateSubscribedEvent**](CobrandApi.md#updatesubscribedevent) | **PUT** /cobrand/config/notifications/events/{eventName} | Update Subscription |

<a name="cobrandlogin"></a>
# **CobrandLogin**
> CobrandLoginResponse CobrandLogin (CobrandLoginRequest cobrandLoginRequest)

Cobrand Login

The cobrand login service authenticates a cobrand.<br>Cobrand session in the response includes the cobrand session token (cobSession) <br>which is used in subsequent API calls like registering or signing in the user. <br>The idle timeout for a cobrand session is 2 hours and the absolute timeout is 24 hours. This service can be <br>invoked to create a new cobrand session token. <br><b>Note:</b> This endpoint is deprecated for customers using the API Key-based authentication and is applicable only to customers who use the SAML-based authentication.<br>The content type has to be passed as application/json for the body parameter. <br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class CobrandLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CobrandApi(config);
            var cobrandLoginRequest = new CobrandLoginRequest(); // CobrandLoginRequest | cobrandLoginRequest

            try
            {
                // Cobrand Login
                CobrandLoginResponse result = apiInstance.CobrandLogin(cobrandLoginRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CobrandApi.CobrandLogin: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CobrandLoginWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cobrand Login
    ApiResponse<CobrandLoginResponse> response = apiInstance.CobrandLoginWithHttpInfo(cobrandLoginRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CobrandApi.CobrandLoginWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cobrandLoginRequest** | [**CobrandLoginRequest**](CobrandLoginRequest.md) | cobrandLoginRequest |  |

### Return type

[**CobrandLoginResponse**](CobrandLoginResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Y800 : Invalid value for cobrandParam |  -  |
| **401** | Y003 : Account is locked, contact Yodlee customer care&lt;br&gt;Y001 : User name and password required |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cobrandlogout"></a>
# **CobrandLogout**
> void CobrandLogout ()

Cobrand Logout

The cobrand logout service is used to log out the cobrand.<br>This service does not return a response. The HTTP response code is 204 (Success with no content).<br><b>Note:</b> This endpoint is deprecated for customers using the API Key-based authentication and is applicable only to customers who use the SAML-based authentication.<br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class CobrandLogoutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CobrandApi(config);

            try
            {
                // Cobrand Logout
                apiInstance.CobrandLogout();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CobrandApi.CobrandLogout: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CobrandLogoutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cobrand Logout
    apiInstance.CobrandLogoutWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CobrandApi.CobrandLogoutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthorized |  -  |
| **204** | Logout successful |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createsubscriptionevent"></a>
# **CreateSubscriptionEvent**
> void CreateSubscriptionEvent (string eventName, CreateCobrandNotificationEventRequest eventRequest)

Subscribe Event

<b>Refer POST /configs/notifications/events/{eventName}.</b><br>The subscribe events service is used to subscribe to an event for receiving notifications.<br>The callback URL, where the notification will be posted should be provided to this service.<br>If the callback URL is invalid or inaccessible, the subscription will be unsuccessful, and an error will be thrown.<br>Customers can subscribe to REFRESH,DATA_UPDATES and AUTO_REFRESH_UPDATES event.<br><br><b>Notes</b>:<br>This service is not available in developer sandbox/test environment and will be made available for testing in your dedicated environment, once the contract is signed.<br>The content type has to be passed as application/json for the body parameter.<br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class CreateSubscriptionEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CobrandApi(config);
            var eventName = "REFRESH";  // string | eventName
            var eventRequest = new CreateCobrandNotificationEventRequest(); // CreateCobrandNotificationEventRequest | eventRequest

            try
            {
                // Subscribe Event
                apiInstance.CreateSubscriptionEvent(eventName, eventRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CobrandApi.CreateSubscriptionEvent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSubscriptionEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Subscribe Event
    apiInstance.CreateSubscriptionEventWithHttpInfo(eventName, eventRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CobrandApi.CreateSubscriptionEventWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eventName** | **string** | eventName |  |
| **eventRequest** | [**CreateCobrandNotificationEventRequest**](CreateCobrandNotificationEventRequest.md) | eventRequest |  |

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
| **400** | Y803 : eventName required&lt;br&gt;Y803 : callbackUrl required&lt;br&gt;Y800 : Invalid value for callbackUrl |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesubscribedevent"></a>
# **DeleteSubscribedEvent**
> void DeleteSubscribedEvent (string eventName)

Delete Subscription

<b>Refer DELETE /configs/notifications/events/{eventName}.</b><br>The delete events service is used to unsubscribe from an events service.<br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class DeleteSubscribedEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CobrandApi(config);
            var eventName = "REFRESH";  // string | eventName

            try
            {
                // Delete Subscription
                apiInstance.DeleteSubscribedEvent(eventName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CobrandApi.DeleteSubscribedEvent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSubscribedEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Subscription
    apiInstance.DeleteSubscribedEventWithHttpInfo(eventName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CobrandApi.DeleteSubscribedEventWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eventName** | **string** | eventName |  |

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

<a name="getpublickey"></a>
# **GetPublicKey**
> CobrandPublicKeyResponse GetPublicKey ()

Get Public Key

<b>Refer GET /configs/publicKey.</b><br>The get public key service provides the customer the public key that should be used to encrypt the user credentials before sending it to Yodlee.<br>This endpoint is useful only for PKI enabled.<br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetPublicKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CobrandApi(config);

            try
            {
                // Get Public Key
                CobrandPublicKeyResponse result = apiInstance.GetPublicKey();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CobrandApi.GetPublicKey: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPublicKeyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Public Key
    ApiResponse<CobrandPublicKeyResponse> response = apiInstance.GetPublicKeyWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CobrandApi.GetPublicKeyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**CobrandPublicKeyResponse**](CobrandPublicKeyResponse.md)

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

<a name="getsubscribedevents"></a>
# **GetSubscribedEvents**
> CobrandNotificationResponse GetSubscribedEvents (string eventName = null)

Get Subscribed Events

<b>Refer GET /configs/notifications/events.</b><br>The get events service provides the list of events for which consumers subscribed <br>to receive notifications. <br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class GetSubscribedEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CobrandApi(config);
            var eventName = "REFRESH";  // string | eventName (optional) 

            try
            {
                // Get Subscribed Events
                CobrandNotificationResponse result = apiInstance.GetSubscribedEvents(eventName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CobrandApi.GetSubscribedEvents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSubscribedEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Subscribed Events
    ApiResponse<CobrandNotificationResponse> response = apiInstance.GetSubscribedEventsWithHttpInfo(eventName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CobrandApi.GetSubscribedEventsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eventName** | **string** | eventName | [optional]  |

### Return type

[**CobrandNotificationResponse**](CobrandNotificationResponse.md)

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

<a name="updatesubscribedevent"></a>
# **UpdateSubscribedEvent**
> void UpdateSubscribedEvent (string eventName, UpdateCobrandNotificationEventRequest eventRequest)

Update Subscription

<b>Refer PUT /configs/notifications/events/{eventName}.</b><br>The update events service is used to update the callback URL.<br>If the callback URL is invalid or inaccessible, the subscription will be unsuccessful, and an error will be thrown.<br><b>Note:</b> The content type has to be passed as application/json for the body parameter. <br>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Yodlee.ApiClient.Api;
using Yodlee.ApiClient.Client;
using Yodlee.ApiClient.Model;

namespace Example
{
    public class UpdateSubscribedEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CobrandApi(config);
            var eventName = "REFRESH";  // string | eventName
            var eventRequest = new UpdateCobrandNotificationEventRequest(); // UpdateCobrandNotificationEventRequest | eventRequest

            try
            {
                // Update Subscription
                apiInstance.UpdateSubscribedEvent(eventName, eventRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CobrandApi.UpdateSubscribedEvent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSubscribedEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Subscription
    apiInstance.UpdateSubscribedEventWithHttpInfo(eventName, eventRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CobrandApi.UpdateSubscribedEventWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eventName** | **string** | eventName |  |
| **eventRequest** | [**UpdateCobrandNotificationEventRequest**](UpdateCobrandNotificationEventRequest.md) | eventRequest |  |

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


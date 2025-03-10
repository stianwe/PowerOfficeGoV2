# PowerOfficeGoV2.Api.DeliveryTermsApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeliveryTermsIdDelete**](DeliveryTermsApi.md#deliverytermsiddelete) | **DELETE** /DeliveryTerms/{id} | Delete a delivery term from the client sales settings. (Auth roles: CommonServices_Full) |
| [**DeliveryTermsIdPatch**](DeliveryTermsApi.md#deliverytermsidpatch) | **PATCH** /DeliveryTerms/{id} | Make changes to a delivery term in the client sales settings. (Auth roles: CommonServices_Full) |
| [**DeliveryTermsPost**](DeliveryTermsApi.md#deliverytermspost) | **POST** /DeliveryTerms | Create a new delivery term in the client sales settings. (Auth roles: CommonServices_Full) |
| [**GetDeliveryTermById**](DeliveryTermsApi.md#getdeliverytermbyid) | **GET** /DeliveryTerms/{id} | Gets the specific delivery term by id. (Auth roles: CommonServices,CommonServices_Full) |
| [**GetDeliveryTerms**](DeliveryTermsApi.md#getdeliveryterms) | **GET** /DeliveryTerms | List the delivery terms from the client sales settings. (Auth roles: CommonServices,CommonServices_Full) |

<a id="deliverytermsiddelete"></a>
# **DeliveryTermsIdDelete**
> void DeliveryTermsIdDelete (long id)

Delete a delivery term from the client sales settings. (Auth roles: CommonServices_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class DeliveryTermsIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new DeliveryTermsApi(config);
            var id = 789L;  // long | The id of the delivery term.

            try
            {
                // Delete a delivery term from the client sales settings. (Auth roles: CommonServices_Full)
                apiInstance.DeliveryTermsIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeliveryTermsApi.DeliveryTermsIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeliveryTermsIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a delivery term from the client sales settings. (Auth roles: CommonServices_Full)
    apiInstance.DeliveryTermsIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeliveryTermsApi.DeliveryTermsIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | The id of the delivery term. |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Given when resource was successfully deleted |  -  |
| **404** | Given when the resource was not found |  -  |
| **409** | Given when resource is in use and cannot be deleted |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deliverytermsidpatch"></a>
# **DeliveryTermsIdPatch**
> DeliveryTermDto DeliveryTermsIdPatch (long id, List<Operation> operation = null)

Make changes to a delivery term in the client sales settings. (Auth roles: CommonServices_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class DeliveryTermsIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new DeliveryTermsApi(config);
            var id = 789L;  // long | The id of the delivery term.
            var operation = new List<Operation>(); // List<Operation> | JSON Patch structure for updating a Delivery Term.              See DeliveryTermPatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 (optional) 

            try
            {
                // Make changes to a delivery term in the client sales settings. (Auth roles: CommonServices_Full)
                DeliveryTermDto result = apiInstance.DeliveryTermsIdPatch(id, operation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeliveryTermsApi.DeliveryTermsIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeliveryTermsIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Make changes to a delivery term in the client sales settings. (Auth roles: CommonServices_Full)
    ApiResponse<DeliveryTermDto> response = apiInstance.DeliveryTermsIdPatchWithHttpInfo(id, operation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeliveryTermsApi.DeliveryTermsIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | The id of the delivery term. |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) | JSON Patch structure for updating a Delivery Term.              See DeliveryTermPatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 | [optional]  |

### Return type

[**DeliveryTermDto**](DeliveryTermDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Given when resource was successfully updated |  -  |
| **400** | Given when request was badly formatted |  -  |
| **404** | Given when the resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deliverytermspost"></a>
# **DeliveryTermsPost**
> DeliveryTermDto DeliveryTermsPost (DeliveryTermPostDto deliveryTermPostDto = null)

Create a new delivery term in the client sales settings. (Auth roles: CommonServices_Full)

The default set of delivery terms provided in Go are incoterms, but any custom string can be created and used on sales orders created in Go.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class DeliveryTermsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new DeliveryTermsApi(config);
            var deliveryTermPostDto = new DeliveryTermPostDto(); // DeliveryTermPostDto | Properties to create. Name Required. (optional) 

            try
            {
                // Create a new delivery term in the client sales settings. (Auth roles: CommonServices_Full)
                DeliveryTermDto result = apiInstance.DeliveryTermsPost(deliveryTermPostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeliveryTermsApi.DeliveryTermsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeliveryTermsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new delivery term in the client sales settings. (Auth roles: CommonServices_Full)
    ApiResponse<DeliveryTermDto> response = apiInstance.DeliveryTermsPostWithHttpInfo(deliveryTermPostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeliveryTermsApi.DeliveryTermsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deliveryTermPostDto** | [**DeliveryTermPostDto**](DeliveryTermPostDto.md) | Properties to create. Name Required. | [optional]  |

### Return type

[**DeliveryTermDto**](DeliveryTermDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Given when resource was successfully created |  -  |
| **400** | Given when request was badly formatted |  -  |
| **404** | Given when resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getdeliverytermbyid"></a>
# **GetDeliveryTermById**
> DeliveryTermDto GetDeliveryTermById (long id)

Gets the specific delivery term by id. (Auth roles: CommonServices,CommonServices_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetDeliveryTermByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new DeliveryTermsApi(config);
            var id = 12345;  // long | The id of the delivery term.

            try
            {
                // Gets the specific delivery term by id. (Auth roles: CommonServices,CommonServices_Full)
                DeliveryTermDto result = apiInstance.GetDeliveryTermById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeliveryTermsApi.GetDeliveryTermById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDeliveryTermByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the specific delivery term by id. (Auth roles: CommonServices,CommonServices_Full)
    ApiResponse<DeliveryTermDto> response = apiInstance.GetDeliveryTermByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeliveryTermsApi.GetDeliveryTermByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | The id of the delivery term. |  |

### Return type

[**DeliveryTermDto**](DeliveryTermDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Given when resource returned successfully |  -  |
| **404** | Given when resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getdeliveryterms"></a>
# **GetDeliveryTerms**
> List&lt;DeliveryTermDto&gt; GetDeliveryTerms (ResourceParameters resourceParameter = null)

List the delivery terms from the client sales settings. (Auth roles: CommonServices,CommonServices_Full)

The default set of delivery terms provided in Go are incoterms, but any custom string can be created and used on sales orders created in Go.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetDeliveryTermsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new DeliveryTermsApi(config);
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // List the delivery terms from the client sales settings. (Auth roles: CommonServices,CommonServices_Full)
                List<DeliveryTermDto> result = apiInstance.GetDeliveryTerms(resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeliveryTermsApi.GetDeliveryTerms: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDeliveryTermsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List the delivery terms from the client sales settings. (Auth roles: CommonServices,CommonServices_Full)
    ApiResponse<List<DeliveryTermDto>> response = apiInstance.GetDeliveryTermsWithHttpInfo(resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeliveryTermsApi.GetDeliveryTermsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;DeliveryTermDto&gt;**](DeliveryTermDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Given when resource returned successfully |  -  |
| **204** | Given when there is no content to return (response body is empty) |  -  |
| **400** | Given when request was badly formatted |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


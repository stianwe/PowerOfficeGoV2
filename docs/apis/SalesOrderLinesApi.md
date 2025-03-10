# PowerOfficeGoV2.Api.SalesOrderLinesApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetSalesOrderLineById**](SalesOrderLinesApi.md#getsalesorderlinebyid) | **GET** /SalesOrders/{id}/Lines/{lineId} | Gets the specific sales order line by id. (Auth roles: SalesOrders,SalesOrders_Full) |
| [**SalesOrdersIdLinesGet**](SalesOrderLinesApi.md#salesordersidlinesget) | **GET** /SalesOrders/{id}/Lines |  (Auth roles: SalesOrders,SalesOrders_Full) |
| [**SalesOrdersIdLinesLineIdDelete**](SalesOrderLinesApi.md#salesordersidlineslineiddelete) | **DELETE** /SalesOrders/{id}/Lines/{lineId} | Delete a sales order line with a given id. (Auth roles: SalesOrders_Full) |
| [**SalesOrdersIdLinesLineIdPatch**](SalesOrderLinesApi.md#salesordersidlineslineidpatch) | **PATCH** /SalesOrders/{id}/Lines/{lineId} | Change an existing sales order line with a given id. (Auth roles: SalesOrders_Full) |
| [**SalesOrdersIdLinesPost**](SalesOrderLinesApi.md#salesordersidlinespost) | **POST** /SalesOrders/{id}/Lines | Create a new sales order line. (Auth roles: SalesOrders_Full) |

<a id="getsalesorderlinebyid"></a>
# **GetSalesOrderLineById**
> SalesOrderLineDto GetSalesOrderLineById (Guid id, Guid lineId)

Gets the specific sales order line by id. (Auth roles: SalesOrders,SalesOrders_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetSalesOrderLineByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new SalesOrderLinesApi(config);
            var id = 38ecfc1a-bf51-448f-99a8-a61bc5771109;  // Guid | The id of the sales order.
            var lineId = 38ecfc1a-bf51-448f-99a8-a61bc5771109;  // Guid | The id of the sales order line.

            try
            {
                // Gets the specific sales order line by id. (Auth roles: SalesOrders,SalesOrders_Full)
                SalesOrderLineDto result = apiInstance.GetSalesOrderLineById(id, lineId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrderLinesApi.GetSalesOrderLineById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSalesOrderLineByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the specific sales order line by id. (Auth roles: SalesOrders,SalesOrders_Full)
    ApiResponse<SalesOrderLineDto> response = apiInstance.GetSalesOrderLineByIdWithHttpInfo(id, lineId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrderLinesApi.GetSalesOrderLineByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The id of the sales order. |  |
| **lineId** | **Guid** | The id of the sales order line. |  |

### Return type

[**SalesOrderLineDto**](SalesOrderLineDto.md)

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

<a id="salesordersidlinesget"></a>
# **SalesOrdersIdLinesGet**
> List&lt;SalesOrderLineDto&gt; SalesOrdersIdLinesGet (Guid id, ResourceParameters resourceParameter = null)

 (Auth roles: SalesOrders,SalesOrders_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class SalesOrdersIdLinesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new SalesOrderLinesApi(config);
            var id = 38ecfc1a-bf51-448f-99a8-a61bc5771109;  // Guid | The id of the sales order.
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                //  (Auth roles: SalesOrders,SalesOrders_Full)
                List<SalesOrderLineDto> result = apiInstance.SalesOrdersIdLinesGet(id, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrderLinesApi.SalesOrdersIdLinesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SalesOrdersIdLinesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    //  (Auth roles: SalesOrders,SalesOrders_Full)
    ApiResponse<List<SalesOrderLineDto>> response = apiInstance.SalesOrdersIdLinesGetWithHttpInfo(id, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrderLinesApi.SalesOrdersIdLinesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The id of the sales order. |  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;SalesOrderLineDto&gt;**](SalesOrderLineDto.md)

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
| **400** | Given when request is badly formatted |  -  |
| **404** | Given when resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="salesordersidlineslineiddelete"></a>
# **SalesOrdersIdLinesLineIdDelete**
> void SalesOrdersIdLinesLineIdDelete (Guid id, Guid lineId)

Delete a sales order line with a given id. (Auth roles: SalesOrders_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class SalesOrdersIdLinesLineIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new SalesOrderLinesApi(config);
            var id = 38ecfc1a-bf51-448f-99a8-a61bc5771109;  // Guid | The id of the sales order.
            var lineId = 27bedb1c-ef51-128f-99a8-a61bc5771109;  // Guid | The id of the sales order line to delete.

            try
            {
                // Delete a sales order line with a given id. (Auth roles: SalesOrders_Full)
                apiInstance.SalesOrdersIdLinesLineIdDelete(id, lineId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrderLinesApi.SalesOrdersIdLinesLineIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SalesOrdersIdLinesLineIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a sales order line with a given id. (Auth roles: SalesOrders_Full)
    apiInstance.SalesOrdersIdLinesLineIdDeleteWithHttpInfo(id, lineId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrderLinesApi.SalesOrdersIdLinesLineIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The id of the sales order. |  |
| **lineId** | **Guid** | The id of the sales order line to delete. |  |

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
| **200** | Given when sales order is deleted |  -  |
| **404** | Given when resource was not found |  -  |
| **409** | Given when resource is in use and cannot be deleted |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="salesordersidlineslineidpatch"></a>
# **SalesOrdersIdLinesLineIdPatch**
> SalesOrderLineDto SalesOrdersIdLinesLineIdPatch (Guid id, Guid lineId, List<Operation> operation = null)

Change an existing sales order line with a given id. (Auth roles: SalesOrders_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class SalesOrdersIdLinesLineIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new SalesOrderLinesApi(config);
            var id = 38ecfc1a-bf51-448f-99a8-a61bc5771109;  // Guid | The id of the sales order.
            var lineId = 41dbec1a-bf51-448f-99a8-a61bc5771109;  // Guid | The id of the sales order line.
            var operation = new List<Operation>(); // List<Operation> | JSON Patch structure for updating an Sales Order line. See SalesOrderLinePatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 (optional) 

            try
            {
                // Change an existing sales order line with a given id. (Auth roles: SalesOrders_Full)
                SalesOrderLineDto result = apiInstance.SalesOrdersIdLinesLineIdPatch(id, lineId, operation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrderLinesApi.SalesOrdersIdLinesLineIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SalesOrdersIdLinesLineIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change an existing sales order line with a given id. (Auth roles: SalesOrders_Full)
    ApiResponse<SalesOrderLineDto> response = apiInstance.SalesOrdersIdLinesLineIdPatchWithHttpInfo(id, lineId, operation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrderLinesApi.SalesOrdersIdLinesLineIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The id of the sales order. |  |
| **lineId** | **Guid** | The id of the sales order line. |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) | JSON Patch structure for updating an Sales Order line. See SalesOrderLinePatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 | [optional]  |

### Return type

[**SalesOrderLineDto**](SalesOrderLineDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Given when resource was successfully updated. |  -  |
| **400** | Given when request is badly formatted |  -  |
| **404** | Given when resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="salesordersidlinespost"></a>
# **SalesOrdersIdLinesPost**
> SalesOrderLineDto SalesOrdersIdLinesPost (Guid id, SalesOrderLinePostDto salesOrderLinePostDto = null)

Create a new sales order line. (Auth roles: SalesOrders_Full)

If successful, the new entity will be returned with an id which is unique and can be used to reference the created object in relevant requests.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class SalesOrdersIdLinesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new SalesOrderLinesApi(config);
            var id = 38ecfc1a-bf51-448f-99a8-a61bc5771109;  // Guid | The id of the sales order.
            var salesOrderLinePostDto = new SalesOrderLinePostDto(); // SalesOrderLinePostDto |  (optional) 

            try
            {
                // Create a new sales order line. (Auth roles: SalesOrders_Full)
                SalesOrderLineDto result = apiInstance.SalesOrdersIdLinesPost(id, salesOrderLinePostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrderLinesApi.SalesOrdersIdLinesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SalesOrdersIdLinesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new sales order line. (Auth roles: SalesOrders_Full)
    ApiResponse<SalesOrderLineDto> response = apiInstance.SalesOrdersIdLinesPostWithHttpInfo(id, salesOrderLinePostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrderLinesApi.SalesOrdersIdLinesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The id of the sales order. |  |
| **salesOrderLinePostDto** | [**SalesOrderLinePostDto**](SalesOrderLinePostDto.md) |  | [optional]  |

### Return type

[**SalesOrderLineDto**](SalesOrderLineDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Given when resource was successfully created. |  -  |
| **400** | Given when request is badly formatted. |  -  |
| **404** | Given when resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


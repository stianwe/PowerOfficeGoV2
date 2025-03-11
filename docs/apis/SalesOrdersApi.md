# PowerOfficeGoV2.Api.SalesOrdersApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetSalesOrderById**](SalesOrdersApi.md#getsalesorderbyid) | **GET** /SalesOrders/{id} | Gets the specific sales order by id. (Auth roles: SalesOrders,SalesOrders_Full) |
| [**SalesOrdersGet**](SalesOrdersApi.md#salesordersget) | **GET** /SalesOrders | Gets the orders from the client. (Auth roles: SalesOrders,SalesOrders_Full) |
| [**SalesOrdersIdDelete**](SalesOrdersApi.md#salesordersiddelete) | **DELETE** /SalesOrders/{id} | Delete an sales order entity with a given id. (Auth roles: SalesOrders_Full) |
| [**SalesOrdersIdPatch**](SalesOrdersApi.md#salesordersidpatch) | **PATCH** /SalesOrders/{id} | Change an existing sales order with a given id. (Auth roles: SalesOrders_Full) |

<a id="getsalesorderbyid"></a>
# **GetSalesOrderById**
> SalesOrderDto GetSalesOrderById (Guid id, bool showInherited = null)

Gets the specific sales order by id. (Auth roles: SalesOrders,SalesOrders_Full)

The returned object are a lightweight version of an sales order, not containing any line details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetSalesOrderByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new SalesOrdersApi(config);
            var id = 38ecfc1a-bf51-448f-99a8-a61bc5771109;  // Guid | The id of the sales order.
            var showInherited = true;  // bool | Choose whether to display the properties as in Go GUI - with inherited values, or as the actual values set on the sales order. (optional) 

            try
            {
                // Gets the specific sales order by id. (Auth roles: SalesOrders,SalesOrders_Full)
                SalesOrderDto result = apiInstance.GetSalesOrderById(id, showInherited);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrdersApi.GetSalesOrderById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSalesOrderByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the specific sales order by id. (Auth roles: SalesOrders,SalesOrders_Full)
    ApiResponse<SalesOrderDto> response = apiInstance.GetSalesOrderByIdWithHttpInfo(id, showInherited);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrdersApi.GetSalesOrderByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The id of the sales order. |  |
| **showInherited** | **bool** | Choose whether to display the properties as in Go GUI - with inherited values, or as the actual values set on the sales order. | [optional]  |

### Return type

[**SalesOrderDto**](SalesOrderDto.md)

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

<a id="salesordersget"></a>
# **SalesOrdersGet**
> List&lt;SalesOrderDto&gt; SalesOrdersGet (string customerNos = null, string departmentCodes = null, bool includeSubProject = null, DateTimeOffset lastChangedDateTimeOffsetGreaterThan = null, bool onlyCreatedByCurrentIntegration = null, OrderStatus orderStatus = null, string projectCodes = null, bool showInherited = null, ResourceParameters resourceParameter = null)

Gets the orders from the client. (Auth roles: SalesOrders,SalesOrders_Full)

Orders can be in either draft or confirmed state, but neither are sent and posted invoices yet (they are considered outgoing invoice drafts).  The returned objects are a lightweight version of an sales order, not containing any line details.  Multiple filtering options.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class SalesOrdersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new SalesOrdersApi(config);
            var customerNos = 10000-15999, 12500, 13000-;  // string | Filter by customer numbers. Separate by comma [,] to filter on multiple customer numbers. A range of numbers can be specified using dash/hyphen [-]. For example \"10000-15999, 12500, 13000-\" will result in invoice drafts from customers with numbers from and including 10000 to 15999, 12500, 13000 and all above will be returned. If null or whitespace, the filter is not used. (optional) 
            var departmentCodes = 1, 3, 4;  // string | Filter by department codes. Note that this selects orders with department set in the header of the order. The order lines might specify other departments or no department. Separate by comma [,] to filter on multiple codes. If -1, then all orders without department codes are returned. If null or whitespace, the filter is not used. (optional) 
            var includeSubProject = true;  // bool | Include sub-project(s) for the currently filtered project(s). If projectCodes is null or whitespace, all (sub)projects are included (regardless of this variable). (optional) 
            var lastChangedDateTimeOffsetGreaterThan = 2021-09-25 08:03:00.1234567 -00:00;  // DateTimeOffset | Filter orders with last changed timestamp greater than the provided timestamp. Can be used as one way of getting changes in orders or getting new orders. Timestamp not inclusive. (optional) 
            var onlyCreatedByCurrentIntegration = true;  // bool | Filter on invoices that the current integration has created. Can be used to reduce the number of invoices, if only the invoices that the (currently) querying integration created are relevant. (optional) 
            var orderStatus = Draft;  // OrderStatus | Filter by order status. (optional) 
            var projectCodes = 10, 20, 30.1;  // string | Filter by project codes. Separate by comma [,] to filter on multiple codes. If -1, then all orders without project codes are returned. If null or whitespace, all orders with or without project codes are returned (filter is not used). (optional) 
            var showInherited = true;  // bool | Choose whether to display the properties as in Go GUI - with inherited values, or as the actual values set on the sales order. (optional) 
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Gets the orders from the client. (Auth roles: SalesOrders,SalesOrders_Full)
                List<SalesOrderDto> result = apiInstance.SalesOrdersGet(customerNos, departmentCodes, includeSubProject, lastChangedDateTimeOffsetGreaterThan, onlyCreatedByCurrentIntegration, orderStatus, projectCodes, showInherited, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrdersApi.SalesOrdersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SalesOrdersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the orders from the client. (Auth roles: SalesOrders,SalesOrders_Full)
    ApiResponse<List<SalesOrderDto>> response = apiInstance.SalesOrdersGetWithHttpInfo(customerNos, departmentCodes, includeSubProject, lastChangedDateTimeOffsetGreaterThan, onlyCreatedByCurrentIntegration, orderStatus, projectCodes, showInherited, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrdersApi.SalesOrdersGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **customerNos** | **string** | Filter by customer numbers. Separate by comma [,] to filter on multiple customer numbers. A range of numbers can be specified using dash/hyphen [-]. For example \&quot;10000-15999, 12500, 13000-\&quot; will result in invoice drafts from customers with numbers from and including 10000 to 15999, 12500, 13000 and all above will be returned. If null or whitespace, the filter is not used. | [optional]  |
| **departmentCodes** | **string** | Filter by department codes. Note that this selects orders with department set in the header of the order. The order lines might specify other departments or no department. Separate by comma [,] to filter on multiple codes. If -1, then all orders without department codes are returned. If null or whitespace, the filter is not used. | [optional]  |
| **includeSubProject** | **bool** | Include sub-project(s) for the currently filtered project(s). If projectCodes is null or whitespace, all (sub)projects are included (regardless of this variable). | [optional]  |
| **lastChangedDateTimeOffsetGreaterThan** | **DateTimeOffset** | Filter orders with last changed timestamp greater than the provided timestamp. Can be used as one way of getting changes in orders or getting new orders. Timestamp not inclusive. | [optional]  |
| **onlyCreatedByCurrentIntegration** | **bool** | Filter on invoices that the current integration has created. Can be used to reduce the number of invoices, if only the invoices that the (currently) querying integration created are relevant. | [optional]  |
| **orderStatus** | **OrderStatus** | Filter by order status. | [optional]  |
| **projectCodes** | **string** | Filter by project codes. Separate by comma [,] to filter on multiple codes. If -1, then all orders without project codes are returned. If null or whitespace, all orders with or without project codes are returned (filter is not used). | [optional]  |
| **showInherited** | **bool** | Choose whether to display the properties as in Go GUI - with inherited values, or as the actual values set on the sales order. | [optional]  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;SalesOrderDto&gt;**](SalesOrderDto.md)

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

<a id="salesordersiddelete"></a>
# **SalesOrdersIdDelete**
> void SalesOrdersIdDelete (Guid id)

Delete an sales order entity with a given id. (Auth roles: SalesOrders_Full)

Deletes all sales order information, including header and lines.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class SalesOrdersIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new SalesOrdersApi(config);
            var id = 38ecfc1a-bf51-448f-99a8-a61bc5771109;  // Guid | The id of the sales order to delete.

            try
            {
                // Delete an sales order entity with a given id. (Auth roles: SalesOrders_Full)
                apiInstance.SalesOrdersIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrdersApi.SalesOrdersIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SalesOrdersIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an sales order entity with a given id. (Auth roles: SalesOrders_Full)
    apiInstance.SalesOrdersIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrdersApi.SalesOrdersIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The id of the sales order to delete. |  |

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

<a id="salesordersidpatch"></a>
# **SalesOrdersIdPatch**
> SalesOrderDto SalesOrdersIdPatch (Guid id, List<Operation> operation = null)

Change an existing sales order with a given id. (Auth roles: SalesOrders_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class SalesOrdersIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new SalesOrdersApi(config);
            var id = 38ecfc1a-bf51-448f-99a8-a61bc5771109;  // Guid | The id of the sales order.
            var operation = new List<Operation>(); // List<Operation> | JSON Patch structure for updating an Sales Order. See SalesOrderPatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 (optional) 

            try
            {
                // Change an existing sales order with a given id. (Auth roles: SalesOrders_Full)
                SalesOrderDto result = apiInstance.SalesOrdersIdPatch(id, operation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrdersApi.SalesOrdersIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SalesOrdersIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change an existing sales order with a given id. (Auth roles: SalesOrders_Full)
    ApiResponse<SalesOrderDto> response = apiInstance.SalesOrdersIdPatchWithHttpInfo(id, operation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrdersApi.SalesOrdersIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The id of the sales order. |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) | JSON Patch structure for updating an Sales Order. See SalesOrderPatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 | [optional]  |

### Return type

[**SalesOrderDto**](SalesOrderDto.md)

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


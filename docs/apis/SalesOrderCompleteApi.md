# PowerOfficeGoV2.Api.SalesOrderCompleteApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetCompleteSalesOrderById**](SalesOrderCompleteApi.md#getcompletesalesorderbyid) | **GET** /SalesOrders/{id}/Complete | Gets the specific (complete) sales order by id.  The returned object are a complete version of an sales order, including line details. (Auth roles: SalesOrders,SalesOrders_Full) |
| [**SalesOrdersCompletePost**](SalesOrderCompleteApi.md#salesorderscompletepost) | **POST** /SalesOrders/Complete | Create a new sales order entity complete with lines. (Auth roles: SalesOrders_Full) |

<a id="getcompletesalesorderbyid"></a>
# **GetCompleteSalesOrderById**
> SalesOrderCompleteDto GetCompleteSalesOrderById (Guid id, bool showInherited = null)

Gets the specific (complete) sales order by id.  The returned object are a complete version of an sales order, including line details. (Auth roles: SalesOrders,SalesOrders_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetCompleteSalesOrderByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new SalesOrderCompleteApi(config);
            var id = 38ecfc1a-bf51-448f-99a8-a61bc5771109;  // Guid | The id of the sales order.
            var showInherited = true;  // bool | Choose whether to display the properties as in Go GUI - with inherited values, or as the actual values set on the sales order.              When the sales order is sent and is converted to invoice, the inherited values will be used. Defaults to false. (optional) 

            try
            {
                // Gets the specific (complete) sales order by id.  The returned object are a complete version of an sales order, including line details. (Auth roles: SalesOrders,SalesOrders_Full)
                SalesOrderCompleteDto result = apiInstance.GetCompleteSalesOrderById(id, showInherited);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrderCompleteApi.GetCompleteSalesOrderById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCompleteSalesOrderByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the specific (complete) sales order by id.  The returned object are a complete version of an sales order, including line details. (Auth roles: SalesOrders,SalesOrders_Full)
    ApiResponse<SalesOrderCompleteDto> response = apiInstance.GetCompleteSalesOrderByIdWithHttpInfo(id, showInherited);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrderCompleteApi.GetCompleteSalesOrderByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The id of the sales order. |  |
| **showInherited** | **bool** | Choose whether to display the properties as in Go GUI - with inherited values, or as the actual values set on the sales order.              When the sales order is sent and is converted to invoice, the inherited values will be used. Defaults to false. | [optional]  |

### Return type

[**SalesOrderCompleteDto**](SalesOrderCompleteDto.md)

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

<a id="salesorderscompletepost"></a>
# **SalesOrdersCompletePost**
> SalesOrderCompleteDto SalesOrdersCompletePost (SalesOrderCompletePostDto salesOrderCompletePostDto = null)

Create a new sales order entity complete with lines. (Auth roles: SalesOrders_Full)

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
    public class SalesOrdersCompletePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new SalesOrderCompleteApi(config);
            var salesOrderCompletePostDto = new SalesOrderCompletePostDto(); // SalesOrderCompletePostDto |  (optional) 

            try
            {
                // Create a new sales order entity complete with lines. (Auth roles: SalesOrders_Full)
                SalesOrderCompleteDto result = apiInstance.SalesOrdersCompletePost(salesOrderCompletePostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrderCompleteApi.SalesOrdersCompletePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SalesOrdersCompletePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new sales order entity complete with lines. (Auth roles: SalesOrders_Full)
    ApiResponse<SalesOrderCompleteDto> response = apiInstance.SalesOrdersCompletePostWithHttpInfo(salesOrderCompletePostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrderCompleteApi.SalesOrdersCompletePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrderCompletePostDto** | [**SalesOrderCompletePostDto**](SalesOrderCompletePostDto.md) |  | [optional]  |

### Return type

[**SalesOrderCompleteDto**](SalesOrderCompleteDto.md)

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


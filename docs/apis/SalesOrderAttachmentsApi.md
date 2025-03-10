# PowerOfficeGoV2.Api.SalesOrderAttachmentsApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetInvoiceAttachmentById**](SalesOrderAttachmentsApi.md#getinvoiceattachmentbyid) | **GET** /SalesOrders/{salesOrderId}/attachments/{id} | Fetch an attachment (file) from a sales order by its identifier. (Auth roles: SalesOrderAttachment, SalesOrderAttachment_Full) |
| [**SalesOrdersSalesOrderIdAttachmentsGet**](SalesOrderAttachmentsApi.md#salesorderssalesorderidattachmentsget) | **GET** /SalesOrders/{salesOrderId}/attachments | Lists the details of all attachments from a sales order. (Auth roles: SalesOrderAttachment,SalesOrderAttachment_Full) |
| [**SalesOrdersSalesOrderIdAttachmentsIdDelete**](SalesOrderAttachmentsApi.md#salesorderssalesorderidattachmentsiddelete) | **DELETE** /SalesOrders/{salesOrderId}/attachments/{id} | Deletes an existing attachment from a sales order by its identifier (Auth roles: SalesOrderAttachment_Full) |
| [**SalesOrdersSalesOrderIdAttachmentsPost**](SalesOrderAttachmentsApi.md#salesorderssalesorderidattachmentspost) | **POST** /SalesOrders/{salesOrderId}/attachments | Add a attachment to an existing sales order. (Auth roles: SalesOrderAttachment_Full) |

<a id="getinvoiceattachmentbyid"></a>
# **GetInvoiceAttachmentById**
> void GetInvoiceAttachmentById (Guid salesOrderId, long id)

Fetch an attachment (file) from a sales order by its identifier. (Auth roles: SalesOrderAttachment, SalesOrderAttachment_Full)

Use this method to fetch a attachment file.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetInvoiceAttachmentByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new SalesOrderAttachmentsApi(config);
            var salesOrderId = 38ecfc1a-bf51-448f-99a8-a61bc5771109;  // Guid | The sales order identifier
            var id = 12345;  // long | The sales order attachment identifier

            try
            {
                // Fetch an attachment (file) from a sales order by its identifier. (Auth roles: SalesOrderAttachment, SalesOrderAttachment_Full)
                apiInstance.GetInvoiceAttachmentById(salesOrderId, id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrderAttachmentsApi.GetInvoiceAttachmentById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInvoiceAttachmentByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetch an attachment (file) from a sales order by its identifier. (Auth roles: SalesOrderAttachment, SalesOrderAttachment_Full)
    apiInstance.GetInvoiceAttachmentByIdWithHttpInfo(salesOrderId, id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrderAttachmentsApi.GetInvoiceAttachmentByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrderId** | **Guid** | The sales order identifier |  |
| **id** | **long** | The sales order attachment identifier |  |

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
| **200** | Given when resource returned successfully |  -  |
| **404** | Given when resource was not found |  -  |
| **400** | Given when an error fetching the file occurs |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="salesorderssalesorderidattachmentsget"></a>
# **SalesOrdersSalesOrderIdAttachmentsGet**
> List&lt;SalesOrderAttachmentDto&gt; SalesOrdersSalesOrderIdAttachmentsGet (Guid salesOrderId, ResourceParameters resourceParameter = null)

Lists the details of all attachments from a sales order. (Auth roles: SalesOrderAttachment,SalesOrderAttachment_Full)

To reduce the payload, the returned list do not contain the file. To retrieve the files, this must be done by getting each attachment by its identifier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class SalesOrdersSalesOrderIdAttachmentsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new SalesOrderAttachmentsApi(config);
            var salesOrderId = 38ecfc1a-bf51-448f-99a8-a61bc5771109;  // Guid | The sales order identifier
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Lists the details of all attachments from a sales order. (Auth roles: SalesOrderAttachment,SalesOrderAttachment_Full)
                List<SalesOrderAttachmentDto> result = apiInstance.SalesOrdersSalesOrderIdAttachmentsGet(salesOrderId, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrderAttachmentsApi.SalesOrdersSalesOrderIdAttachmentsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SalesOrdersSalesOrderIdAttachmentsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Lists the details of all attachments from a sales order. (Auth roles: SalesOrderAttachment,SalesOrderAttachment_Full)
    ApiResponse<List<SalesOrderAttachmentDto>> response = apiInstance.SalesOrdersSalesOrderIdAttachmentsGetWithHttpInfo(salesOrderId, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrderAttachmentsApi.SalesOrdersSalesOrderIdAttachmentsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrderId** | **Guid** | The sales order identifier |  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;SalesOrderAttachmentDto&gt;**](SalesOrderAttachmentDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Given when resource returned successfully |  -  |
| **204** | Given when no content is returned |  -  |
| **400** | Given when request is badly formatted |  -  |
| **404** | Given when resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="salesorderssalesorderidattachmentsiddelete"></a>
# **SalesOrdersSalesOrderIdAttachmentsIdDelete**
> void SalesOrdersSalesOrderIdAttachmentsIdDelete (Guid salesOrderId, long id)

Deletes an existing attachment from a sales order by its identifier (Auth roles: SalesOrderAttachment_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class SalesOrdersSalesOrderIdAttachmentsIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new SalesOrderAttachmentsApi(config);
            var salesOrderId = 38ecfc1a-bf51-448f-99a8-a61bc5771109;  // Guid | The sales order identifier
            var id = 12345;  // long | The sales order attachment identifier

            try
            {
                // Deletes an existing attachment from a sales order by its identifier (Auth roles: SalesOrderAttachment_Full)
                apiInstance.SalesOrdersSalesOrderIdAttachmentsIdDelete(salesOrderId, id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrderAttachmentsApi.SalesOrdersSalesOrderIdAttachmentsIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SalesOrdersSalesOrderIdAttachmentsIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an existing attachment from a sales order by its identifier (Auth roles: SalesOrderAttachment_Full)
    apiInstance.SalesOrdersSalesOrderIdAttachmentsIdDeleteWithHttpInfo(salesOrderId, id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrderAttachmentsApi.SalesOrdersSalesOrderIdAttachmentsIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrderId** | **Guid** | The sales order identifier |  |
| **id** | **long** | The sales order attachment identifier |  |

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
| **200** | Given when resource deleted successfully |  -  |
| **404** | Given when resource was not found |  -  |
| **409** | Given when resource could not be deleted |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="salesorderssalesorderidattachmentspost"></a>
# **SalesOrdersSalesOrderIdAttachmentsPost**
> SalesOrderAttachmentDto SalesOrdersSalesOrderIdAttachmentsPost (Guid salesOrderId, System.IO.Stream file = null)

Add a attachment to an existing sales order. (Auth roles: SalesOrderAttachment_Full)

Create and add a new attachment to an existing sales order entity on the client.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class SalesOrdersSalesOrderIdAttachmentsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new SalesOrderAttachmentsApi(config);
            var salesOrderId = 38ecfc1a-bf51-448f-99a8-a61bc5771109;  // Guid | The sales order identifier
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 

            try
            {
                // Add a attachment to an existing sales order. (Auth roles: SalesOrderAttachment_Full)
                SalesOrderAttachmentDto result = apiInstance.SalesOrdersSalesOrderIdAttachmentsPost(salesOrderId, file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrderAttachmentsApi.SalesOrdersSalesOrderIdAttachmentsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SalesOrdersSalesOrderIdAttachmentsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a attachment to an existing sales order. (Auth roles: SalesOrderAttachment_Full)
    ApiResponse<SalesOrderAttachmentDto> response = apiInstance.SalesOrdersSalesOrderIdAttachmentsPostWithHttpInfo(salesOrderId, file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrderAttachmentsApi.SalesOrdersSalesOrderIdAttachmentsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salesOrderId** | **Guid** | The sales order identifier |  |
| **file** | **System.IO.Stream****System.IO.Stream** |  | [optional]  |

### Return type

[**SalesOrderAttachmentDto**](SalesOrderAttachmentDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Given when a resource was created successfully |  -  |
| **400** | Given when request is badly formatted |  -  |
| **404** | Given when resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


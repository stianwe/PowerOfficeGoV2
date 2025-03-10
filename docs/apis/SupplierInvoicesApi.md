# PowerOfficeGoV2.Api.SupplierInvoicesApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetSupplierInvoiceById**](SupplierInvoicesApi.md#getsupplierinvoicebyid) | **GET** /JournalEntryVouchers/SupplierInvoices/{id} | Returns a supplier invoice by id. (Auth roles: JournalEntryVoucher,JournalEntryVoucher_Full) |
| [**JournalEntryVouchersSupplierInvoicesIdPatch**](SupplierInvoicesApi.md#journalentryvoucherssupplierinvoicesidpatch) | **PATCH** /JournalEntryVouchers/SupplierInvoices/{id} | Update supplier invoice header. (Auth roles: JournalEntryVoucher_Full) |
| [**JournalEntryVouchersSupplierInvoicesIdVoucherLinesLineIdDelete**](SupplierInvoicesApi.md#journalentryvoucherssupplierinvoicesidvoucherlineslineiddelete) | **DELETE** /JournalEntryVouchers/SupplierInvoices/{id}/VoucherLines/{lineId} | Delete a supplier voucher line from a supplier invoice. (Auth roles: JournalEntryVoucher_Full) |
| [**JournalEntryVouchersSupplierInvoicesIdVoucherLinesLineIdPatch**](SupplierInvoicesApi.md#journalentryvoucherssupplierinvoicesidvoucherlineslineidpatch) | **PATCH** /JournalEntryVouchers/SupplierInvoices/{id}/VoucherLines/{lineId} | Update a supplier voucher line on a supplier invoice. (Auth roles: JournalEntryVoucher_Full) |
| [**JournalEntryVouchersSupplierInvoicesIdVoucherLinesPost**](SupplierInvoicesApi.md#journalentryvoucherssupplierinvoicesidvoucherlinespost) | **POST** /JournalEntryVouchers/SupplierInvoices/{id}/VoucherLines | Add a new supplier voucher line on a supplier invoice. (Auth roles: JournalEntryVoucher_Full) |
| [**JournalEntryVouchersSupplierInvoicesPost**](SupplierInvoicesApi.md#journalentryvoucherssupplierinvoicespost) | **POST** /JournalEntryVouchers/SupplierInvoices | Create a supplier invoice. (Auth roles: JournalEntryVoucher_Full) |

<a id="getsupplierinvoicebyid"></a>
# **GetSupplierInvoiceById**
> SupplierInvoiceJournalEntryVoucherDto GetSupplierInvoiceById (Guid id)

Returns a supplier invoice by id. (Auth roles: JournalEntryVoucher,JournalEntryVoucher_Full)

The integration only has access to vouchers that it has created or is the current approver of.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetSupplierInvoiceByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new SupplierInvoicesApi(config);
            var id = d77e1400-d1cb-44e3-853c-bf64d8953af3;  // Guid | The identifier of a supplier invoice.

            try
            {
                // Returns a supplier invoice by id. (Auth roles: JournalEntryVoucher,JournalEntryVoucher_Full)
                SupplierInvoiceJournalEntryVoucherDto result = apiInstance.GetSupplierInvoiceById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SupplierInvoicesApi.GetSupplierInvoiceById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSupplierInvoiceByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns a supplier invoice by id. (Auth roles: JournalEntryVoucher,JournalEntryVoucher_Full)
    ApiResponse<SupplierInvoiceJournalEntryVoucherDto> response = apiInstance.GetSupplierInvoiceByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SupplierInvoicesApi.GetSupplierInvoiceByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The identifier of a supplier invoice. |  |

### Return type

[**SupplierInvoiceJournalEntryVoucherDto**](SupplierInvoiceJournalEntryVoucherDto.md)

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

<a id="journalentryvoucherssupplierinvoicesidpatch"></a>
# **JournalEntryVouchersSupplierInvoicesIdPatch**
> SupplierInvoiceJournalEntryVoucherDto JournalEntryVouchersSupplierInvoicesIdPatch (Guid id, List<Operation> operation = null)

Update supplier invoice header. (Auth roles: JournalEntryVoucher_Full)

The integration only has access to vouchers that it has created or is the current approver of.              If the voucher is currently under approval by a different approver, the integration will not be able to update the voucher.              Supplier invoice lines must be updated using a separate endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class JournalEntryVouchersSupplierInvoicesIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new SupplierInvoicesApi(config);
            var id = d77e1400-d1cb-44e3-853c-bf64d8953af3;  // Guid | The identifier of a supplier invoice.
            var operation = new List<Operation>(); // List<Operation> | JSON Patch structure for updating an Supplier Invoice. See SupplierInvoiceJournalEntryVoucherPatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 (optional) 

            try
            {
                // Update supplier invoice header. (Auth roles: JournalEntryVoucher_Full)
                SupplierInvoiceJournalEntryVoucherDto result = apiInstance.JournalEntryVouchersSupplierInvoicesIdPatch(id, operation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SupplierInvoicesApi.JournalEntryVouchersSupplierInvoicesIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the JournalEntryVouchersSupplierInvoicesIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update supplier invoice header. (Auth roles: JournalEntryVoucher_Full)
    ApiResponse<SupplierInvoiceJournalEntryVoucherDto> response = apiInstance.JournalEntryVouchersSupplierInvoicesIdPatchWithHttpInfo(id, operation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SupplierInvoicesApi.JournalEntryVouchersSupplierInvoicesIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The identifier of a supplier invoice. |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) | JSON Patch structure for updating an Supplier Invoice. See SupplierInvoiceJournalEntryVoucherPatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 | [optional]  |

### Return type

[**SupplierInvoiceJournalEntryVoucherDto**](SupplierInvoiceJournalEntryVoucherDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Given when a resource was updated successfully |  -  |
| **400** | Given when request is badly formatted |  -  |
| **404** | Given when resource was not found |  -  |
| **409** | Given when resource conflict occur |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="journalentryvoucherssupplierinvoicesidvoucherlineslineiddelete"></a>
# **JournalEntryVouchersSupplierInvoicesIdVoucherLinesLineIdDelete**
> void JournalEntryVouchersSupplierInvoicesIdVoucherLinesLineIdDelete (Guid id, long lineId)

Delete a supplier voucher line from a supplier invoice. (Auth roles: JournalEntryVoucher_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class JournalEntryVouchersSupplierInvoicesIdVoucherLinesLineIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new SupplierInvoicesApi(config);
            var id = 2f228d21-8659-4c4f-8460-978ee24681a4;  // Guid | The identifier of the supplier invoice.
            var lineId = 60001;  // long | The identifier of the supplier invoice line.

            try
            {
                // Delete a supplier voucher line from a supplier invoice. (Auth roles: JournalEntryVoucher_Full)
                apiInstance.JournalEntryVouchersSupplierInvoicesIdVoucherLinesLineIdDelete(id, lineId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SupplierInvoicesApi.JournalEntryVouchersSupplierInvoicesIdVoucherLinesLineIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the JournalEntryVouchersSupplierInvoicesIdVoucherLinesLineIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a supplier voucher line from a supplier invoice. (Auth roles: JournalEntryVoucher_Full)
    apiInstance.JournalEntryVouchersSupplierInvoicesIdVoucherLinesLineIdDeleteWithHttpInfo(id, lineId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SupplierInvoicesApi.JournalEntryVouchersSupplierInvoicesIdVoucherLinesLineIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The identifier of the supplier invoice. |  |
| **lineId** | **long** | The identifier of the supplier invoice line. |  |

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
| **200** | Given when a resource was deleted successfully |  -  |
| **404** | Given when resource was not found |  -  |
| **409** | Given when resource conflict occur |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="journalentryvoucherssupplierinvoicesidvoucherlineslineidpatch"></a>
# **JournalEntryVouchersSupplierInvoicesIdVoucherLinesLineIdPatch**
> SupplierVoucherLineDto JournalEntryVouchersSupplierInvoicesIdVoucherLinesLineIdPatch (Guid id, long lineId, List<Operation> operation = null)

Update a supplier voucher line on a supplier invoice. (Auth roles: JournalEntryVoucher_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class JournalEntryVouchersSupplierInvoicesIdVoucherLinesLineIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new SupplierInvoicesApi(config);
            var id = 2f228d21-8659-4c4f-8460-978ee24681a4;  // Guid | The identifier of the supplier invoice.
            var lineId = 60001;  // long | The identifier of the supplier voucher line.
            var operation = new List<Operation>(); // List<Operation> | JSON Patch structure for updating a supplier voucher line. See SupplierVoucherLinePatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 (optional) 

            try
            {
                // Update a supplier voucher line on a supplier invoice. (Auth roles: JournalEntryVoucher_Full)
                SupplierVoucherLineDto result = apiInstance.JournalEntryVouchersSupplierInvoicesIdVoucherLinesLineIdPatch(id, lineId, operation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SupplierInvoicesApi.JournalEntryVouchersSupplierInvoicesIdVoucherLinesLineIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the JournalEntryVouchersSupplierInvoicesIdVoucherLinesLineIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a supplier voucher line on a supplier invoice. (Auth roles: JournalEntryVoucher_Full)
    ApiResponse<SupplierVoucherLineDto> response = apiInstance.JournalEntryVouchersSupplierInvoicesIdVoucherLinesLineIdPatchWithHttpInfo(id, lineId, operation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SupplierInvoicesApi.JournalEntryVouchersSupplierInvoicesIdVoucherLinesLineIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The identifier of the supplier invoice. |  |
| **lineId** | **long** | The identifier of the supplier voucher line. |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) | JSON Patch structure for updating a supplier voucher line. See SupplierVoucherLinePatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 | [optional]  |

### Return type

[**SupplierVoucherLineDto**](SupplierVoucherLineDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Given when a resource was updated successfully |  -  |
| **400** | Given when request is badly formatted |  -  |
| **404** | Given when resource was not found |  -  |
| **409** | Given when resource is in conflict |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="journalentryvoucherssupplierinvoicesidvoucherlinespost"></a>
# **JournalEntryVouchersSupplierInvoicesIdVoucherLinesPost**
> SupplierInvoiceJournalEntryVoucherDto JournalEntryVouchersSupplierInvoicesIdVoucherLinesPost (Guid id, SupplierVoucherLinePostDto supplierVoucherLinePostDto = null)

Add a new supplier voucher line on a supplier invoice. (Auth roles: JournalEntryVoucher_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class JournalEntryVouchersSupplierInvoicesIdVoucherLinesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new SupplierInvoicesApi(config);
            var id = d77e1400-d1cb-44e3-853c-bf64d8953af3;  // Guid | The identifier of a supplier invoice.
            var supplierVoucherLinePostDto = new SupplierVoucherLinePostDto(); // SupplierVoucherLinePostDto | A supplier voucher line post dto. (optional) 

            try
            {
                // Add a new supplier voucher line on a supplier invoice. (Auth roles: JournalEntryVoucher_Full)
                SupplierInvoiceJournalEntryVoucherDto result = apiInstance.JournalEntryVouchersSupplierInvoicesIdVoucherLinesPost(id, supplierVoucherLinePostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SupplierInvoicesApi.JournalEntryVouchersSupplierInvoicesIdVoucherLinesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the JournalEntryVouchersSupplierInvoicesIdVoucherLinesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a new supplier voucher line on a supplier invoice. (Auth roles: JournalEntryVoucher_Full)
    ApiResponse<SupplierInvoiceJournalEntryVoucherDto> response = apiInstance.JournalEntryVouchersSupplierInvoicesIdVoucherLinesPostWithHttpInfo(id, supplierVoucherLinePostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SupplierInvoicesApi.JournalEntryVouchersSupplierInvoicesIdVoucherLinesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The identifier of a supplier invoice. |  |
| **supplierVoucherLinePostDto** | [**SupplierVoucherLinePostDto**](SupplierVoucherLinePostDto.md) | A supplier voucher line post dto. | [optional]  |

### Return type

[**SupplierInvoiceJournalEntryVoucherDto**](SupplierInvoiceJournalEntryVoucherDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
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

<a id="journalentryvoucherssupplierinvoicespost"></a>
# **JournalEntryVouchersSupplierInvoicesPost**
> SupplierInvoiceJournalEntryVoucherDto JournalEntryVouchersSupplierInvoicesPost (SupplierInvoiceJournalEntryVoucherPostDto supplierInvoiceJournalEntryVoucherPostDto = null)

Create a supplier invoice. (Auth roles: JournalEntryVoucher_Full)

Use the voucher page endpoint to add a page to the supplier invoice.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class JournalEntryVouchersSupplierInvoicesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new SupplierInvoicesApi(config);
            var supplierInvoiceJournalEntryVoucherPostDto = new SupplierInvoiceJournalEntryVoucherPostDto(); // SupplierInvoiceJournalEntryVoucherPostDto |  (optional) 

            try
            {
                // Create a supplier invoice. (Auth roles: JournalEntryVoucher_Full)
                SupplierInvoiceJournalEntryVoucherDto result = apiInstance.JournalEntryVouchersSupplierInvoicesPost(supplierInvoiceJournalEntryVoucherPostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SupplierInvoicesApi.JournalEntryVouchersSupplierInvoicesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the JournalEntryVouchersSupplierInvoicesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a supplier invoice. (Auth roles: JournalEntryVoucher_Full)
    ApiResponse<SupplierInvoiceJournalEntryVoucherDto> response = apiInstance.JournalEntryVouchersSupplierInvoicesPostWithHttpInfo(supplierInvoiceJournalEntryVoucherPostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SupplierInvoicesApi.JournalEntryVouchersSupplierInvoicesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **supplierInvoiceJournalEntryVoucherPostDto** | [**SupplierInvoiceJournalEntryVoucherPostDto**](SupplierInvoiceJournalEntryVoucherPostDto.md) |  | [optional]  |

### Return type

[**SupplierInvoiceJournalEntryVoucherDto**](SupplierInvoiceJournalEntryVoucherDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
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


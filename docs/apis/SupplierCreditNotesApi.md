# PowerOfficeGoV2.Api.SupplierCreditNotesApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetSupplierCreditNoteById**](SupplierCreditNotesApi.md#getsuppliercreditnotebyid) | **GET** /JournalEntryVouchers/SupplierCreditNotes/{id} | Gets the specific journal entry supplier credit note by id. (Auth roles: JournalEntryVoucher,JournalEntryVoucher_Full) |
| [**JournalEntryVouchersSupplierCreditNotesIdPatch**](SupplierCreditNotesApi.md#journalentryvoucherssuppliercreditnotesidpatch) | **PATCH** /JournalEntryVouchers/SupplierCreditNotes/{id} | Change an existing journal entry supplier credit note (Auth roles: JournalEntryVoucher_Full) |
| [**JournalEntryVouchersSupplierCreditNotesIdVoucherLinesLineIdDelete**](SupplierCreditNotesApi.md#journalentryvoucherssuppliercreditnotesidvoucherlineslineiddelete) | **DELETE** /JournalEntryVouchers/SupplierCreditNotes/{id}/VoucherLines/{lineId} | Delete a supplier voucher line from a supplier voucher. (Auth roles: JournalEntryVoucher_Full) |
| [**JournalEntryVouchersSupplierCreditNotesIdVoucherLinesLineIdPatch**](SupplierCreditNotesApi.md#journalentryvoucherssuppliercreditnotesidvoucherlineslineidpatch) | **PATCH** /JournalEntryVouchers/SupplierCreditNotes/{id}/VoucherLines/{lineId} | Update a supplier voucher line on a supplier credit note. (Auth roles: JournalEntryVoucher_Full) |
| [**JournalEntryVouchersSupplierCreditNotesIdVoucherLinesPost**](SupplierCreditNotesApi.md#journalentryvoucherssuppliercreditnotesidvoucherlinespost) | **POST** /JournalEntryVouchers/SupplierCreditNotes/{id}/VoucherLines | Add a new supplier voucher line on a supplier credit note. (Auth roles: JournalEntryVoucher_Full) |
| [**JournalEntryVouchersSupplierCreditNotesPost**](SupplierCreditNotesApi.md#journalentryvoucherssuppliercreditnotespost) | **POST** /JournalEntryVouchers/SupplierCreditNotes | Create a new journal entry supplier credit note. (Auth roles: JournalEntryVoucher_Full) |

<a id="getsuppliercreditnotebyid"></a>
# **GetSupplierCreditNoteById**
> SupplierCreditNoteJournalEntryVoucherDto GetSupplierCreditNoteById (Guid id)

Gets the specific journal entry supplier credit note by id. (Auth roles: JournalEntryVoucher,JournalEntryVoucher_Full)

Gets the specific journal entry supplier credit note by id.              Note that when querying journal entry voucher details, a response will only be produced for vouchers the integration have created using POST operations with journal entry voucher endpoints.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetSupplierCreditNoteByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new SupplierCreditNotesApi(config);
            var id = d77e1400-d1cb-44e3-853c-bf64d8953af3;  // Guid | The identifier of a supplier credit note.

            try
            {
                // Gets the specific journal entry supplier credit note by id. (Auth roles: JournalEntryVoucher,JournalEntryVoucher_Full)
                SupplierCreditNoteJournalEntryVoucherDto result = apiInstance.GetSupplierCreditNoteById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SupplierCreditNotesApi.GetSupplierCreditNoteById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSupplierCreditNoteByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the specific journal entry supplier credit note by id. (Auth roles: JournalEntryVoucher,JournalEntryVoucher_Full)
    ApiResponse<SupplierCreditNoteJournalEntryVoucherDto> response = apiInstance.GetSupplierCreditNoteByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SupplierCreditNotesApi.GetSupplierCreditNoteByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The identifier of a supplier credit note. |  |

### Return type

[**SupplierCreditNoteJournalEntryVoucherDto**](SupplierCreditNoteJournalEntryVoucherDto.md)

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

<a id="journalentryvoucherssuppliercreditnotesidpatch"></a>
# **JournalEntryVouchersSupplierCreditNotesIdPatch**
> SupplierCreditNoteJournalEntryVoucherDto JournalEntryVouchersSupplierCreditNotesIdPatch (Guid id, List<Operation> operation = null)

Change an existing journal entry supplier credit note (Auth roles: JournalEntryVoucher_Full)

Change an existing journal entry supplier credit note. Changes cannot be made if the voucher is poster or sent to the approval workflow.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class JournalEntryVouchersSupplierCreditNotesIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new SupplierCreditNotesApi(config);
            var id = 38ecfc1a-bf51-448f-99a8-a61bc5771109;  // Guid | The identifier of the journal entry supplier credit note
            var operation = new List<Operation>(); // List<Operation> | JSON Patch structure for updating an Supplier Credit Note. See SupplierCreditNoteJournalEntryVoucherPatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 (optional) 

            try
            {
                // Change an existing journal entry supplier credit note (Auth roles: JournalEntryVoucher_Full)
                SupplierCreditNoteJournalEntryVoucherDto result = apiInstance.JournalEntryVouchersSupplierCreditNotesIdPatch(id, operation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SupplierCreditNotesApi.JournalEntryVouchersSupplierCreditNotesIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the JournalEntryVouchersSupplierCreditNotesIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change an existing journal entry supplier credit note (Auth roles: JournalEntryVoucher_Full)
    ApiResponse<SupplierCreditNoteJournalEntryVoucherDto> response = apiInstance.JournalEntryVouchersSupplierCreditNotesIdPatchWithHttpInfo(id, operation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SupplierCreditNotesApi.JournalEntryVouchersSupplierCreditNotesIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The identifier of the journal entry supplier credit note |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) | JSON Patch structure for updating an Supplier Credit Note. See SupplierCreditNoteJournalEntryVoucherPatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 | [optional]  |

### Return type

[**SupplierCreditNoteJournalEntryVoucherDto**](SupplierCreditNoteJournalEntryVoucherDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Given when resource returned successfully |  -  |
| **400** | Given when request is badly formatted |  -  |
| **404** | Given when resource was not found |  -  |
| **409** | Given when resource could not be deleted |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="journalentryvoucherssuppliercreditnotesidvoucherlineslineiddelete"></a>
# **JournalEntryVouchersSupplierCreditNotesIdVoucherLinesLineIdDelete**
> void JournalEntryVouchersSupplierCreditNotesIdVoucherLinesLineIdDelete (Guid id, long lineId)

Delete a supplier voucher line from a supplier voucher. (Auth roles: JournalEntryVoucher_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class JournalEntryVouchersSupplierCreditNotesIdVoucherLinesLineIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new SupplierCreditNotesApi(config);
            var id = 2f228d21-8659-4c4f-8460-978ee24681a4;  // Guid | The identifier of the supplier credit note.
            var lineId = 60001;  // long | The identifier of the supplier voucher line.

            try
            {
                // Delete a supplier voucher line from a supplier voucher. (Auth roles: JournalEntryVoucher_Full)
                apiInstance.JournalEntryVouchersSupplierCreditNotesIdVoucherLinesLineIdDelete(id, lineId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SupplierCreditNotesApi.JournalEntryVouchersSupplierCreditNotesIdVoucherLinesLineIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the JournalEntryVouchersSupplierCreditNotesIdVoucherLinesLineIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a supplier voucher line from a supplier voucher. (Auth roles: JournalEntryVoucher_Full)
    apiInstance.JournalEntryVouchersSupplierCreditNotesIdVoucherLinesLineIdDeleteWithHttpInfo(id, lineId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SupplierCreditNotesApi.JournalEntryVouchersSupplierCreditNotesIdVoucherLinesLineIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The identifier of the supplier credit note. |  |
| **lineId** | **long** | The identifier of the supplier voucher line. |  |

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
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="journalentryvoucherssuppliercreditnotesidvoucherlineslineidpatch"></a>
# **JournalEntryVouchersSupplierCreditNotesIdVoucherLinesLineIdPatch**
> SupplierVoucherLineDto JournalEntryVouchersSupplierCreditNotesIdVoucherLinesLineIdPatch (Guid id, long lineId, List<Operation> operation = null)

Update a supplier voucher line on a supplier credit note. (Auth roles: JournalEntryVoucher_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class JournalEntryVouchersSupplierCreditNotesIdVoucherLinesLineIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new SupplierCreditNotesApi(config);
            var id = 2f228d21-8659-4c4f-8460-978ee24681a4;  // Guid | The identifier of the supplier credit note.
            var lineId = 60001;  // long | The identifier of the supplier voucher line.
            var operation = new List<Operation>(); // List<Operation> | JSON Patch structure for updating a supplier voucher line. See SupplierVoucherLinePatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 (optional) 

            try
            {
                // Update a supplier voucher line on a supplier credit note. (Auth roles: JournalEntryVoucher_Full)
                SupplierVoucherLineDto result = apiInstance.JournalEntryVouchersSupplierCreditNotesIdVoucherLinesLineIdPatch(id, lineId, operation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SupplierCreditNotesApi.JournalEntryVouchersSupplierCreditNotesIdVoucherLinesLineIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the JournalEntryVouchersSupplierCreditNotesIdVoucherLinesLineIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a supplier voucher line on a supplier credit note. (Auth roles: JournalEntryVoucher_Full)
    ApiResponse<SupplierVoucherLineDto> response = apiInstance.JournalEntryVouchersSupplierCreditNotesIdVoucherLinesLineIdPatchWithHttpInfo(id, lineId, operation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SupplierCreditNotesApi.JournalEntryVouchersSupplierCreditNotesIdVoucherLinesLineIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The identifier of the supplier credit note. |  |
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

<a id="journalentryvoucherssuppliercreditnotesidvoucherlinespost"></a>
# **JournalEntryVouchersSupplierCreditNotesIdVoucherLinesPost**
> SupplierCreditNoteJournalEntryVoucherDto JournalEntryVouchersSupplierCreditNotesIdVoucherLinesPost (Guid id, SupplierVoucherLinePostDto supplierVoucherLinePostDto = null)

Add a new supplier voucher line on a supplier credit note. (Auth roles: JournalEntryVoucher_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class JournalEntryVouchersSupplierCreditNotesIdVoucherLinesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new SupplierCreditNotesApi(config);
            var id = d77e1400-d1cb-44e3-853c-bf64d8953af3;  // Guid | The identifier of a supplier credit note.
            var supplierVoucherLinePostDto = new SupplierVoucherLinePostDto(); // SupplierVoucherLinePostDto | A supplier voucher line post dto. (optional) 

            try
            {
                // Add a new supplier voucher line on a supplier credit note. (Auth roles: JournalEntryVoucher_Full)
                SupplierCreditNoteJournalEntryVoucherDto result = apiInstance.JournalEntryVouchersSupplierCreditNotesIdVoucherLinesPost(id, supplierVoucherLinePostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SupplierCreditNotesApi.JournalEntryVouchersSupplierCreditNotesIdVoucherLinesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the JournalEntryVouchersSupplierCreditNotesIdVoucherLinesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a new supplier voucher line on a supplier credit note. (Auth roles: JournalEntryVoucher_Full)
    ApiResponse<SupplierCreditNoteJournalEntryVoucherDto> response = apiInstance.JournalEntryVouchersSupplierCreditNotesIdVoucherLinesPostWithHttpInfo(id, supplierVoucherLinePostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SupplierCreditNotesApi.JournalEntryVouchersSupplierCreditNotesIdVoucherLinesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The identifier of a supplier credit note. |  |
| **supplierVoucherLinePostDto** | [**SupplierVoucherLinePostDto**](SupplierVoucherLinePostDto.md) | A supplier voucher line post dto. | [optional]  |

### Return type

[**SupplierCreditNoteJournalEntryVoucherDto**](SupplierCreditNoteJournalEntryVoucherDto.md)

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

<a id="journalentryvoucherssuppliercreditnotespost"></a>
# **JournalEntryVouchersSupplierCreditNotesPost**
> SupplierCreditNoteJournalEntryVoucherDto JournalEntryVouchersSupplierCreditNotesPost (SupplierCreditNoteJournalEntryVoucherPostDto supplierCreditNoteJournalEntryVoucherPostDto = null)

Create a new journal entry supplier credit note. (Auth roles: JournalEntryVoucher_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class JournalEntryVouchersSupplierCreditNotesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new SupplierCreditNotesApi(config);
            var supplierCreditNoteJournalEntryVoucherPostDto = new SupplierCreditNoteJournalEntryVoucherPostDto(); // SupplierCreditNoteJournalEntryVoucherPostDto |  (optional) 

            try
            {
                // Create a new journal entry supplier credit note. (Auth roles: JournalEntryVoucher_Full)
                SupplierCreditNoteJournalEntryVoucherDto result = apiInstance.JournalEntryVouchersSupplierCreditNotesPost(supplierCreditNoteJournalEntryVoucherPostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SupplierCreditNotesApi.JournalEntryVouchersSupplierCreditNotesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the JournalEntryVouchersSupplierCreditNotesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new journal entry supplier credit note. (Auth roles: JournalEntryVoucher_Full)
    ApiResponse<SupplierCreditNoteJournalEntryVoucherDto> response = apiInstance.JournalEntryVouchersSupplierCreditNotesPostWithHttpInfo(supplierCreditNoteJournalEntryVoucherPostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SupplierCreditNotesApi.JournalEntryVouchersSupplierCreditNotesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **supplierCreditNoteJournalEntryVoucherPostDto** | [**SupplierCreditNoteJournalEntryVoucherPostDto**](SupplierCreditNoteJournalEntryVoucherPostDto.md) |  | [optional]  |

### Return type

[**SupplierCreditNoteJournalEntryVoucherDto**](SupplierCreditNoteJournalEntryVoucherDto.md)

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


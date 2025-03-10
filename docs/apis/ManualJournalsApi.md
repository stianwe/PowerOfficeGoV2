# PowerOfficeGoV2.Api.ManualJournalsApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetManualJournalById**](ManualJournalsApi.md#getmanualjournalbyid) | **GET** /JournalEntryVouchers/ManualJournals/{id} | Get a manual voucher by id. (Auth roles: JournalEntryVoucher,JournalEntryVoucher_Full) |
| [**JournalEntryVouchersManualJournalsIdPatch**](ManualJournalsApi.md#journalentryvouchersmanualjournalsidpatch) | **PATCH** /JournalEntryVouchers/ManualJournals/{id} | Update manual journal entry voucher header. (Auth roles: JournalEntryVoucher_Full) |
| [**JournalEntryVouchersManualJournalsIdVoucherLinesLineIdDelete**](ManualJournalsApi.md#journalentryvouchersmanualjournalsidvoucherlineslineiddelete) | **DELETE** /JournalEntryVouchers/ManualJournals/{id}/VoucherLines/{lineId} | Delete a ManualJournalEntryVoucherLine from a ManualJournalEntryVoucher. (Auth roles: JournalEntryVoucher_Full) |
| [**JournalEntryVouchersManualJournalsIdVoucherLinesLineIdPatch**](ManualJournalsApi.md#journalentryvouchersmanualjournalsidvoucherlineslineidpatch) | **PATCH** /JournalEntryVouchers/ManualJournals/{id}/VoucherLines/{lineId} | Update a manual journal entry voucher line. (Auth roles: JournalEntryVoucher_Full) |
| [**JournalEntryVouchersManualJournalsIdVoucherLinesPost**](ManualJournalsApi.md#journalentryvouchersmanualjournalsidvoucherlinespost) | **POST** /JournalEntryVouchers/ManualJournals/{id}/VoucherLines | Add a line to a manual voucher. (Auth roles: JournalEntryVoucher_Full) |
| [**JournalEntryVouchersManualJournalsPost**](ManualJournalsApi.md#journalentryvouchersmanualjournalspost) | **POST** /JournalEntryVouchers/ManualJournals | Create a manual journal entry. (Auth roles: JournalEntryVoucher_Full) |

<a id="getmanualjournalbyid"></a>
# **GetManualJournalById**
> ManualJournalEntryVoucherDto GetManualJournalById (Guid id)

Get a manual voucher by id. (Auth roles: JournalEntryVoucher,JournalEntryVoucher_Full)

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
    public class GetManualJournalByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ManualJournalsApi(config);
            var id = d77e1400-d1cb-44e3-853c-bf64d8953af3;  // Guid | The identifier of a manual journal entry voucher.

            try
            {
                // Get a manual voucher by id. (Auth roles: JournalEntryVoucher,JournalEntryVoucher_Full)
                ManualJournalEntryVoucherDto result = apiInstance.GetManualJournalById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManualJournalsApi.GetManualJournalById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetManualJournalByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a manual voucher by id. (Auth roles: JournalEntryVoucher,JournalEntryVoucher_Full)
    ApiResponse<ManualJournalEntryVoucherDto> response = apiInstance.GetManualJournalByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManualJournalsApi.GetManualJournalByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The identifier of a manual journal entry voucher. |  |

### Return type

[**ManualJournalEntryVoucherDto**](ManualJournalEntryVoucherDto.md)

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

<a id="journalentryvouchersmanualjournalsidpatch"></a>
# **JournalEntryVouchersManualJournalsIdPatch**
> ManualJournalEntryVoucherDto JournalEntryVouchersManualJournalsIdPatch (Guid id, List<Operation> operation = null)

Update manual journal entry voucher header. (Auth roles: JournalEntryVoucher_Full)

The integration only has access to vouchers that it has created or is the current approver of.              If the voucher is currently under approval by a different approver, the integration will not be able to update the voucher.              Manual journal entry voucher lines must be updated using a separate endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class JournalEntryVouchersManualJournalsIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ManualJournalsApi(config);
            var id = d77e1400-d1cb-44e3-853c-bf64d8953af3;  // Guid | The identifier of a manual journal entry.
            var operation = new List<Operation>(); // List<Operation> | JSON Patch structure for updating a ManualJournalEntryVoucher. See ManualJournalEntryVoucherPatchDto schema for all available properties.              For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 (optional) 

            try
            {
                // Update manual journal entry voucher header. (Auth roles: JournalEntryVoucher_Full)
                ManualJournalEntryVoucherDto result = apiInstance.JournalEntryVouchersManualJournalsIdPatch(id, operation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManualJournalsApi.JournalEntryVouchersManualJournalsIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the JournalEntryVouchersManualJournalsIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update manual journal entry voucher header. (Auth roles: JournalEntryVoucher_Full)
    ApiResponse<ManualJournalEntryVoucherDto> response = apiInstance.JournalEntryVouchersManualJournalsIdPatchWithHttpInfo(id, operation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManualJournalsApi.JournalEntryVouchersManualJournalsIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The identifier of a manual journal entry. |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) | JSON Patch structure for updating a ManualJournalEntryVoucher. See ManualJournalEntryVoucherPatchDto schema for all available properties.              For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 | [optional]  |

### Return type

[**ManualJournalEntryVoucherDto**](ManualJournalEntryVoucherDto.md)

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

<a id="journalentryvouchersmanualjournalsidvoucherlineslineiddelete"></a>
# **JournalEntryVouchersManualJournalsIdVoucherLinesLineIdDelete**
> void JournalEntryVouchersManualJournalsIdVoucherLinesLineIdDelete (Guid id, long lineId)

Delete a ManualJournalEntryVoucherLine from a ManualJournalEntryVoucher. (Auth roles: JournalEntryVoucher_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class JournalEntryVouchersManualJournalsIdVoucherLinesLineIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ManualJournalsApi(config);
            var id = 2f228d21-8659-4c4f-8460-978ee24681a4;  // Guid | The identifier of the ManualJournalEntryVoucher.
            var lineId = 60001;  // long | The identifier of the ManualJournalEntryVoucherLine.

            try
            {
                // Delete a ManualJournalEntryVoucherLine from a ManualJournalEntryVoucher. (Auth roles: JournalEntryVoucher_Full)
                apiInstance.JournalEntryVouchersManualJournalsIdVoucherLinesLineIdDelete(id, lineId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManualJournalsApi.JournalEntryVouchersManualJournalsIdVoucherLinesLineIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the JournalEntryVouchersManualJournalsIdVoucherLinesLineIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a ManualJournalEntryVoucherLine from a ManualJournalEntryVoucher. (Auth roles: JournalEntryVoucher_Full)
    apiInstance.JournalEntryVouchersManualJournalsIdVoucherLinesLineIdDeleteWithHttpInfo(id, lineId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManualJournalsApi.JournalEntryVouchersManualJournalsIdVoucherLinesLineIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The identifier of the ManualJournalEntryVoucher. |  |
| **lineId** | **long** | The identifier of the ManualJournalEntryVoucherLine. |  |

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

<a id="journalentryvouchersmanualjournalsidvoucherlineslineidpatch"></a>
# **JournalEntryVouchersManualJournalsIdVoucherLinesLineIdPatch**
> ManualJournalEntryVoucherLineDto JournalEntryVouchersManualJournalsIdVoucherLinesLineIdPatch (Guid id, long lineId, List<Operation> operation = null)

Update a manual journal entry voucher line. (Auth roles: JournalEntryVoucher_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class JournalEntryVouchersManualJournalsIdVoucherLinesLineIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ManualJournalsApi(config);
            var id = 2f228d21-8659-4c4f-8460-978ee24681a4;  // Guid | The identifier of the manual voucher.
            var lineId = 60001;  // long | The identifier of the manual journal entry voucher line.
            var operation = new List<Operation>(); // List<Operation> | JSON Patch structure for updating a manual journal entry voucher line. (optional) 

            try
            {
                // Update a manual journal entry voucher line. (Auth roles: JournalEntryVoucher_Full)
                ManualJournalEntryVoucherLineDto result = apiInstance.JournalEntryVouchersManualJournalsIdVoucherLinesLineIdPatch(id, lineId, operation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManualJournalsApi.JournalEntryVouchersManualJournalsIdVoucherLinesLineIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the JournalEntryVouchersManualJournalsIdVoucherLinesLineIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a manual journal entry voucher line. (Auth roles: JournalEntryVoucher_Full)
    ApiResponse<ManualJournalEntryVoucherLineDto> response = apiInstance.JournalEntryVouchersManualJournalsIdVoucherLinesLineIdPatchWithHttpInfo(id, lineId, operation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManualJournalsApi.JournalEntryVouchersManualJournalsIdVoucherLinesLineIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The identifier of the manual voucher. |  |
| **lineId** | **long** | The identifier of the manual journal entry voucher line. |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) | JSON Patch structure for updating a manual journal entry voucher line. | [optional]  |

### Return type

[**ManualJournalEntryVoucherLineDto**](ManualJournalEntryVoucherLineDto.md)

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

<a id="journalentryvouchersmanualjournalsidvoucherlinespost"></a>
# **JournalEntryVouchersManualJournalsIdVoucherLinesPost**
> ManualJournalEntryVoucherDto JournalEntryVouchersManualJournalsIdVoucherLinesPost (Guid id, ManualJournalEntryVoucherLinePostDto manualJournalEntryVoucherLinePostDto = null)

Add a line to a manual voucher. (Auth roles: JournalEntryVoucher_Full)

Returns the entire manual voucher with all lines, including the new one. The newest line can be identified by its created date.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class JournalEntryVouchersManualJournalsIdVoucherLinesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ManualJournalsApi(config);
            var id = "id_example";  // Guid | 
            var manualJournalEntryVoucherLinePostDto = new ManualJournalEntryVoucherLinePostDto(); // ManualJournalEntryVoucherLinePostDto |  (optional) 

            try
            {
                // Add a line to a manual voucher. (Auth roles: JournalEntryVoucher_Full)
                ManualJournalEntryVoucherDto result = apiInstance.JournalEntryVouchersManualJournalsIdVoucherLinesPost(id, manualJournalEntryVoucherLinePostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManualJournalsApi.JournalEntryVouchersManualJournalsIdVoucherLinesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the JournalEntryVouchersManualJournalsIdVoucherLinesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a line to a manual voucher. (Auth roles: JournalEntryVoucher_Full)
    ApiResponse<ManualJournalEntryVoucherDto> response = apiInstance.JournalEntryVouchersManualJournalsIdVoucherLinesPostWithHttpInfo(id, manualJournalEntryVoucherLinePostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManualJournalsApi.JournalEntryVouchersManualJournalsIdVoucherLinesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **manualJournalEntryVoucherLinePostDto** | [**ManualJournalEntryVoucherLinePostDto**](ManualJournalEntryVoucherLinePostDto.md) |  | [optional]  |

### Return type

[**ManualJournalEntryVoucherDto**](ManualJournalEntryVoucherDto.md)

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

<a id="journalentryvouchersmanualjournalspost"></a>
# **JournalEntryVouchersManualJournalsPost**
> ManualJournalEntryVoucherDto JournalEntryVouchersManualJournalsPost (ManualJournalEntryVoucherPostDto manualJournalEntryVoucherPostDto = null)

Create a manual journal entry. (Auth roles: JournalEntryVoucher_Full)

Use the voucher page endpoint to add a page to the manual journal entry voucher.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class JournalEntryVouchersManualJournalsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ManualJournalsApi(config);
            var manualJournalEntryVoucherPostDto = new ManualJournalEntryVoucherPostDto(); // ManualJournalEntryVoucherPostDto |  (optional) 

            try
            {
                // Create a manual journal entry. (Auth roles: JournalEntryVoucher_Full)
                ManualJournalEntryVoucherDto result = apiInstance.JournalEntryVouchersManualJournalsPost(manualJournalEntryVoucherPostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManualJournalsApi.JournalEntryVouchersManualJournalsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the JournalEntryVouchersManualJournalsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a manual journal entry. (Auth roles: JournalEntryVoucher_Full)
    ApiResponse<ManualJournalEntryVoucherDto> response = apiInstance.JournalEntryVouchersManualJournalsPostWithHttpInfo(manualJournalEntryVoucherPostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManualJournalsApi.JournalEntryVouchersManualJournalsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **manualJournalEntryVoucherPostDto** | [**ManualJournalEntryVoucherPostDto**](ManualJournalEntryVoucherPostDto.md) |  | [optional]  |

### Return type

[**ManualJournalEntryVoucherDto**](ManualJournalEntryVoucherDto.md)

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


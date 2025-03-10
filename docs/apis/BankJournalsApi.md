# PowerOfficeGoV2.Api.BankJournalsApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetBankJournalById**](BankJournalsApi.md#getbankjournalbyid) | **GET** /JournalEntryVouchers/BankJournals/{id} | Get a BankJournalEntryVoucher by id. (Auth roles: JournalEntryVoucher,JournalEntryVoucher_Full) |
| [**JournalEntryVouchersBankJournalsIdPatch**](BankJournalsApi.md#journalentryvouchersbankjournalsidpatch) | **PATCH** /JournalEntryVouchers/BankJournals/{id} | Update BankJournalEntryVoucher header. (Auth roles: JournalEntryVoucher_Full) |
| [**JournalEntryVouchersBankJournalsIdVoucherLinesLineIdDelete**](BankJournalsApi.md#journalentryvouchersbankjournalsidvoucherlineslineiddelete) | **DELETE** /JournalEntryVouchers/BankJournals/{id}/VoucherLines/{lineId} | Delete a BankJournalEntryVoucherLine from a BankJournalEntryVoucher. (Auth roles: JournalEntryVoucher_Full) |
| [**JournalEntryVouchersBankJournalsIdVoucherLinesLineIdPatch**](BankJournalsApi.md#journalentryvouchersbankjournalsidvoucherlineslineidpatch) | **PATCH** /JournalEntryVouchers/BankJournals/{id}/VoucherLines/{lineId} | Update a BankJournalEntryVoucherLine. (Auth roles: JournalEntryVoucher_Full) |
| [**JournalEntryVouchersBankJournalsIdVoucherLinesPost**](BankJournalsApi.md#journalentryvouchersbankjournalsidvoucherlinespost) | **POST** /JournalEntryVouchers/BankJournals/{id}/VoucherLines | Add a line to a BankJournalEntryVoucher. (Auth roles: JournalEntryVoucher_Full) |
| [**JournalEntryVouchersBankJournalsPost**](BankJournalsApi.md#journalentryvouchersbankjournalspost) | **POST** /JournalEntryVouchers/BankJournals | Create a BankJournalEntryVoucher. (Auth roles: JournalEntryVoucher_Full) |

<a id="getbankjournalbyid"></a>
# **GetBankJournalById**
> BankJournalEntryVoucherDto GetBankJournalById (Guid id)

Get a BankJournalEntryVoucher by id. (Auth roles: JournalEntryVoucher,JournalEntryVoucher_Full)

The integration only has access to journals and vouchers that it has created or is the current approver of.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetBankJournalByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new BankJournalsApi(config);
            var id = d77e1400-d1cb-44e3-853c-bf64d8953af3;  // Guid | The identifier of a BankJournalEntryVoucher.

            try
            {
                // Get a BankJournalEntryVoucher by id. (Auth roles: JournalEntryVoucher,JournalEntryVoucher_Full)
                BankJournalEntryVoucherDto result = apiInstance.GetBankJournalById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BankJournalsApi.GetBankJournalById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBankJournalByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a BankJournalEntryVoucher by id. (Auth roles: JournalEntryVoucher,JournalEntryVoucher_Full)
    ApiResponse<BankJournalEntryVoucherDto> response = apiInstance.GetBankJournalByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BankJournalsApi.GetBankJournalByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The identifier of a BankJournalEntryVoucher. |  |

### Return type

[**BankJournalEntryVoucherDto**](BankJournalEntryVoucherDto.md)

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

<a id="journalentryvouchersbankjournalsidpatch"></a>
# **JournalEntryVouchersBankJournalsIdPatch**
> BankJournalEntryVoucherDto JournalEntryVouchersBankJournalsIdPatch (Guid id, List<Operation> operation = null)

Update BankJournalEntryVoucher header. (Auth roles: JournalEntryVoucher_Full)

The integration only has access to journals and vouchers that it has created or is the current approver of.              If the voucher is currently under approval by a different approver, the integration will not be able to update the voucher.              BankJournalEntryVoucherLines must be updated using a separate endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class JournalEntryVouchersBankJournalsIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new BankJournalsApi(config);
            var id = d77e1400-d1cb-44e3-853c-bf64d8953af3;  // Guid | The identifier of a bank journal entry.
            var operation = new List<Operation>(); // List<Operation> | JSON Patch structure for updating a BankJournalEntryVoucher. See BankJournalEntryVoucherPatchDto schema for all available properties.              For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 (optional) 

            try
            {
                // Update BankJournalEntryVoucher header. (Auth roles: JournalEntryVoucher_Full)
                BankJournalEntryVoucherDto result = apiInstance.JournalEntryVouchersBankJournalsIdPatch(id, operation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BankJournalsApi.JournalEntryVouchersBankJournalsIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the JournalEntryVouchersBankJournalsIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update BankJournalEntryVoucher header. (Auth roles: JournalEntryVoucher_Full)
    ApiResponse<BankJournalEntryVoucherDto> response = apiInstance.JournalEntryVouchersBankJournalsIdPatchWithHttpInfo(id, operation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BankJournalsApi.JournalEntryVouchersBankJournalsIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The identifier of a bank journal entry. |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) | JSON Patch structure for updating a BankJournalEntryVoucher. See BankJournalEntryVoucherPatchDto schema for all available properties.              For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 | [optional]  |

### Return type

[**BankJournalEntryVoucherDto**](BankJournalEntryVoucherDto.md)

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

<a id="journalentryvouchersbankjournalsidvoucherlineslineiddelete"></a>
# **JournalEntryVouchersBankJournalsIdVoucherLinesLineIdDelete**
> void JournalEntryVouchersBankJournalsIdVoucherLinesLineIdDelete (Guid id, long lineId)

Delete a BankJournalEntryVoucherLine from a BankJournalEntryVoucher. (Auth roles: JournalEntryVoucher_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class JournalEntryVouchersBankJournalsIdVoucherLinesLineIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new BankJournalsApi(config);
            var id = 2f228d21-8659-4c4f-8460-978ee24681a4;  // Guid | The identifier of the BankJournalEntryVoucher.
            var lineId = 60001;  // long | The identifier of the BankJournalEntryVoucherLine.

            try
            {
                // Delete a BankJournalEntryVoucherLine from a BankJournalEntryVoucher. (Auth roles: JournalEntryVoucher_Full)
                apiInstance.JournalEntryVouchersBankJournalsIdVoucherLinesLineIdDelete(id, lineId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BankJournalsApi.JournalEntryVouchersBankJournalsIdVoucherLinesLineIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the JournalEntryVouchersBankJournalsIdVoucherLinesLineIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a BankJournalEntryVoucherLine from a BankJournalEntryVoucher. (Auth roles: JournalEntryVoucher_Full)
    apiInstance.JournalEntryVouchersBankJournalsIdVoucherLinesLineIdDeleteWithHttpInfo(id, lineId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BankJournalsApi.JournalEntryVouchersBankJournalsIdVoucherLinesLineIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The identifier of the BankJournalEntryVoucher. |  |
| **lineId** | **long** | The identifier of the BankJournalEntryVoucherLine. |  |

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

<a id="journalentryvouchersbankjournalsidvoucherlineslineidpatch"></a>
# **JournalEntryVouchersBankJournalsIdVoucherLinesLineIdPatch**
> BankJournalEntryVoucherLineDto JournalEntryVouchersBankJournalsIdVoucherLinesLineIdPatch (Guid id, long lineId, List<Operation> operation = null)

Update a BankJournalEntryVoucherLine. (Auth roles: JournalEntryVoucher_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class JournalEntryVouchersBankJournalsIdVoucherLinesLineIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new BankJournalsApi(config);
            var id = 2f228d21-8659-4c4f-8460-978ee24681a4;  // Guid | The identifier of the BankJournalEntryVoucher.
            var lineId = 60001;  // long | The identifier of the BankJournalEntryVoucherLine.
            var operation = new List<Operation>(); // List<Operation> | JSON Patch structure for updating a BankJournalEntryVoucherLine. (optional) 

            try
            {
                // Update a BankJournalEntryVoucherLine. (Auth roles: JournalEntryVoucher_Full)
                BankJournalEntryVoucherLineDto result = apiInstance.JournalEntryVouchersBankJournalsIdVoucherLinesLineIdPatch(id, lineId, operation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BankJournalsApi.JournalEntryVouchersBankJournalsIdVoucherLinesLineIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the JournalEntryVouchersBankJournalsIdVoucherLinesLineIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a BankJournalEntryVoucherLine. (Auth roles: JournalEntryVoucher_Full)
    ApiResponse<BankJournalEntryVoucherLineDto> response = apiInstance.JournalEntryVouchersBankJournalsIdVoucherLinesLineIdPatchWithHttpInfo(id, lineId, operation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BankJournalsApi.JournalEntryVouchersBankJournalsIdVoucherLinesLineIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The identifier of the BankJournalEntryVoucher. |  |
| **lineId** | **long** | The identifier of the BankJournalEntryVoucherLine. |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) | JSON Patch structure for updating a BankJournalEntryVoucherLine. | [optional]  |

### Return type

[**BankJournalEntryVoucherLineDto**](BankJournalEntryVoucherLineDto.md)

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

<a id="journalentryvouchersbankjournalsidvoucherlinespost"></a>
# **JournalEntryVouchersBankJournalsIdVoucherLinesPost**
> BankJournalEntryVoucherDto JournalEntryVouchersBankJournalsIdVoucherLinesPost (Guid id, BankJournalEntryVoucherLinePostDto bankJournalEntryVoucherLinePostDto = null)

Add a line to a BankJournalEntryVoucher. (Auth roles: JournalEntryVoucher_Full)

Returns the entire BankJournalEntryVoucher with all lines, including the new one. The newest line can be identified by its created date.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class JournalEntryVouchersBankJournalsIdVoucherLinesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new BankJournalsApi(config);
            var id = "id_example";  // Guid | 
            var bankJournalEntryVoucherLinePostDto = new BankJournalEntryVoucherLinePostDto(); // BankJournalEntryVoucherLinePostDto |  (optional) 

            try
            {
                // Add a line to a BankJournalEntryVoucher. (Auth roles: JournalEntryVoucher_Full)
                BankJournalEntryVoucherDto result = apiInstance.JournalEntryVouchersBankJournalsIdVoucherLinesPost(id, bankJournalEntryVoucherLinePostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BankJournalsApi.JournalEntryVouchersBankJournalsIdVoucherLinesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the JournalEntryVouchersBankJournalsIdVoucherLinesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a line to a BankJournalEntryVoucher. (Auth roles: JournalEntryVoucher_Full)
    ApiResponse<BankJournalEntryVoucherDto> response = apiInstance.JournalEntryVouchersBankJournalsIdVoucherLinesPostWithHttpInfo(id, bankJournalEntryVoucherLinePostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BankJournalsApi.JournalEntryVouchersBankJournalsIdVoucherLinesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **bankJournalEntryVoucherLinePostDto** | [**BankJournalEntryVoucherLinePostDto**](BankJournalEntryVoucherLinePostDto.md) |  | [optional]  |

### Return type

[**BankJournalEntryVoucherDto**](BankJournalEntryVoucherDto.md)

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

<a id="journalentryvouchersbankjournalspost"></a>
# **JournalEntryVouchersBankJournalsPost**
> BankJournalEntryVoucherDto JournalEntryVouchersBankJournalsPost (BankJournalEntryVoucherPostDto bankJournalEntryVoucherPostDto = null)

Create a BankJournalEntryVoucher. (Auth roles: JournalEntryVoucher_Full)

Use the voucher page endpoint to add a page to the BankJournalEntryVoucher.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class JournalEntryVouchersBankJournalsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new BankJournalsApi(config);
            var bankJournalEntryVoucherPostDto = new BankJournalEntryVoucherPostDto(); // BankJournalEntryVoucherPostDto |  (optional) 

            try
            {
                // Create a BankJournalEntryVoucher. (Auth roles: JournalEntryVoucher_Full)
                BankJournalEntryVoucherDto result = apiInstance.JournalEntryVouchersBankJournalsPost(bankJournalEntryVoucherPostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BankJournalsApi.JournalEntryVouchersBankJournalsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the JournalEntryVouchersBankJournalsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a BankJournalEntryVoucher. (Auth roles: JournalEntryVoucher_Full)
    ApiResponse<BankJournalEntryVoucherDto> response = apiInstance.JournalEntryVouchersBankJournalsPostWithHttpInfo(bankJournalEntryVoucherPostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BankJournalsApi.JournalEntryVouchersBankJournalsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bankJournalEntryVoucherPostDto** | [**BankJournalEntryVoucherPostDto**](BankJournalEntryVoucherPostDto.md) |  | [optional]  |

### Return type

[**BankJournalEntryVoucherDto**](BankJournalEntryVoucherDto.md)

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


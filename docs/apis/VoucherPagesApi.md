# PowerOfficeGoV2.Api.VoucherPagesApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**JournalEntryVouchersIdVoucherPagesPageIdDelete**](VoucherPagesApi.md#journalentryvouchersidvoucherpagespageiddelete) | **DELETE** /JournalEntryVouchers/{id}/VoucherPages/{pageId} | Delete a voucher page from a journal entry voucher draft. (Auth roles: JournalEntryVoucher_Full) |
| [**JournalEntryVouchersIdVoucherPagesPageIdGet**](VoucherPagesApi.md#journalentryvouchersidvoucherpagespageidget) | **GET** /JournalEntryVouchers/{id}/VoucherPages/{pageId} | Gets a voucher page image by id (Auth roles: JournalEntryVoucher, JournalEntryVoucher_Full) |
| [**JournalEntryVouchersIdVoucherPagesPost**](VoucherPagesApi.md#journalentryvouchersidvoucherpagespost) | **POST** /JournalEntryVouchers/{id}/VoucherPages | Add a page to a voucher. (Auth roles: JournalEntryVoucher_Full) |

<a id="journalentryvouchersidvoucherpagespageiddelete"></a>
# **JournalEntryVouchersIdVoucherPagesPageIdDelete**
> void JournalEntryVouchersIdVoucherPagesPageIdDelete (Guid id, long pageId)

Delete a voucher page from a journal entry voucher draft. (Auth roles: JournalEntryVoucher_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class JournalEntryVouchersIdVoucherPagesPageIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new VoucherPagesApi(config);
            var id = 2f228d21-8659-4c4f-8460-978ee24681a4;  // Guid | The identifier of the voucher.
            var pageId = 12003;  // long | The ID of the voucher page to delete.

            try
            {
                // Delete a voucher page from a journal entry voucher draft. (Auth roles: JournalEntryVoucher_Full)
                apiInstance.JournalEntryVouchersIdVoucherPagesPageIdDelete(id, pageId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VoucherPagesApi.JournalEntryVouchersIdVoucherPagesPageIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the JournalEntryVouchersIdVoucherPagesPageIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a voucher page from a journal entry voucher draft. (Auth roles: JournalEntryVoucher_Full)
    apiInstance.JournalEntryVouchersIdVoucherPagesPageIdDeleteWithHttpInfo(id, pageId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VoucherPagesApi.JournalEntryVouchersIdVoucherPagesPageIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The identifier of the voucher. |  |
| **pageId** | **long** | The ID of the voucher page to delete. |  |

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
| **409** | Given when resource could not be deleted |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="journalentryvouchersidvoucherpagespageidget"></a>
# **JournalEntryVouchersIdVoucherPagesPageIdGet**
> void JournalEntryVouchersIdVoucherPagesPageIdGet (Guid id, long pageId)

Gets a voucher page image by id (Auth roles: JournalEntryVoucher, JournalEntryVoucher_Full)

You can only access vouchers and voucher pages you have created or is an approver of.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class JournalEntryVouchersIdVoucherPagesPageIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new VoucherPagesApi(config);
            var id = 2f228d21-8659-4c4f-8460-978ee24681a4;  // Guid | The identifier of the voucher.
            var pageId = 11001;  // long | The id of a voucher page. Page ids can be found by querying the voucher endpoint first.

            try
            {
                // Gets a voucher page image by id (Auth roles: JournalEntryVoucher, JournalEntryVoucher_Full)
                apiInstance.JournalEntryVouchersIdVoucherPagesPageIdGet(id, pageId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VoucherPagesApi.JournalEntryVouchersIdVoucherPagesPageIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the JournalEntryVouchersIdVoucherPagesPageIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a voucher page image by id (Auth roles: JournalEntryVoucher, JournalEntryVoucher_Full)
    apiInstance.JournalEntryVouchersIdVoucherPagesPageIdGetWithHttpInfo(id, pageId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VoucherPagesApi.JournalEntryVouchersIdVoucherPagesPageIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The identifier of the voucher. |  |
| **pageId** | **long** | The id of a voucher page. Page ids can be found by querying the voucher endpoint first. |  |

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
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="journalentryvouchersidvoucherpagespost"></a>
# **JournalEntryVouchersIdVoucherPagesPost**
> void JournalEntryVouchersIdVoucherPagesPost (Guid id, System.IO.Stream file = null)

Add a page to a voucher. (Auth roles: JournalEntryVoucher_Full)

You can only access vouchers and voucher pages you have created or is an approver of.              Posted vouchers or vouchers in approval at a different users can not be updated by the current integration or user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class JournalEntryVouchersIdVoucherPagesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new VoucherPagesApi(config);
            var id = 2f228d21-8659-4c4f-8460-978ee24681a4;  // Guid | The identifier of the voucher.
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 

            try
            {
                // Add a page to a voucher. (Auth roles: JournalEntryVoucher_Full)
                apiInstance.JournalEntryVouchersIdVoucherPagesPost(id, file);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VoucherPagesApi.JournalEntryVouchersIdVoucherPagesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the JournalEntryVouchersIdVoucherPagesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a page to a voucher. (Auth roles: JournalEntryVoucher_Full)
    apiInstance.JournalEntryVouchersIdVoucherPagesPostWithHttpInfo(id, file);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VoucherPagesApi.JournalEntryVouchersIdVoucherPagesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The identifier of the voucher. |  |
| **file** | **System.IO.Stream****System.IO.Stream** |  | [optional]  |

### Return type

void (empty response body)

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
| **409** | Given when resource conflict occur |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


# PowerOfficeGoV2.Api.JournalEntryVouchersApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**JournalEntryVouchersGet**](JournalEntryVouchersApi.md#journalentryvouchersget) | **GET** /JournalEntryVouchers | List the journal entry vouchers on the client, returning lightweight journal entry voucher objects and their type. (Auth roles: JournalEntryVoucher,JournalEntryVoucher_Full) |
| [**JournalEntryVouchersIdDelete**](JournalEntryVouchersApi.md#journalentryvouchersiddelete) | **DELETE** /JournalEntryVouchers/{id} | Delete a voucher, the accompanying lines and pages. (Auth roles: JournalEntryVoucher_Full) |
| [**JournalEntryVouchersIdEhfGet**](JournalEntryVouchersApi.md#journalentryvouchersidehfget) | **GET** /JournalEntryVouchers/{id}/ehf | Retrieve the EHF-file from a voucher draft, if the voucher draft was created by EHF (Auth roles: JournalEntryVoucher, JournalEntryVoucher_Full) |
| [**JournalEntryVouchersIdSubmitForApprovalPost**](JournalEntryVouchersApi.md#journalentryvouchersidsubmitforapprovalpost) | **POST** /JournalEntryVouchers/{id}/submitForApproval | Submit a voucher for approval. (Auth roles: JournalEntryVoucher_Full) |

<a id="journalentryvouchersget"></a>
# **JournalEntryVouchersGet**
> List&lt;JournalEntryVoucherListItem&gt; JournalEntryVouchersGet (DateTimeOffset createdDateTimeOffsetGreaterThan = null, DateTimeOffset lastChangedDateTimeOffsetGreaterThan = null, bool inApprovalWorkflow = null, bool isPosted = null, ResourceParameters resourceParameter = null)

List the journal entry vouchers on the client, returning lightweight journal entry voucher objects and their type. (Auth roles: JournalEntryVoucher,JournalEntryVoucher_Full)

To get the details, get the voucher by its identifier using the endpoint relevant for the voucher type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class JournalEntryVouchersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new JournalEntryVouchersApi(config);
            var createdDateTimeOffsetGreaterThan = 2023-11-29T14:00:00.1234567Z;  // DateTimeOffset | Filter vouchers with created timestamp greater than the provided timestamp. Timestamp not inclusive. (optional) 
            var lastChangedDateTimeOffsetGreaterThan = 2023-11-29T14:00:00.1234567Z;  // DateTimeOffset | Filter vouchers with last changed timestamp greater than the provided timestamp. Timestamp not inclusive. (optional) 
            var inApprovalWorkflow = true;  // bool | Filter by the approval state. (optional) 
            var isPosted = false;  // bool | Filter by the posted state. (optional) 
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // List the journal entry vouchers on the client, returning lightweight journal entry voucher objects and their type. (Auth roles: JournalEntryVoucher,JournalEntryVoucher_Full)
                List<JournalEntryVoucherListItem> result = apiInstance.JournalEntryVouchersGet(createdDateTimeOffsetGreaterThan, lastChangedDateTimeOffsetGreaterThan, inApprovalWorkflow, isPosted, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JournalEntryVouchersApi.JournalEntryVouchersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the JournalEntryVouchersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List the journal entry vouchers on the client, returning lightweight journal entry voucher objects and their type. (Auth roles: JournalEntryVoucher,JournalEntryVoucher_Full)
    ApiResponse<List<JournalEntryVoucherListItem>> response = apiInstance.JournalEntryVouchersGetWithHttpInfo(createdDateTimeOffsetGreaterThan, lastChangedDateTimeOffsetGreaterThan, inApprovalWorkflow, isPosted, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JournalEntryVouchersApi.JournalEntryVouchersGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createdDateTimeOffsetGreaterThan** | **DateTimeOffset** | Filter vouchers with created timestamp greater than the provided timestamp. Timestamp not inclusive. | [optional]  |
| **lastChangedDateTimeOffsetGreaterThan** | **DateTimeOffset** | Filter vouchers with last changed timestamp greater than the provided timestamp. Timestamp not inclusive. | [optional]  |
| **inApprovalWorkflow** | **bool** | Filter by the approval state. | [optional]  |
| **isPosted** | **bool** | Filter by the posted state. | [optional]  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;JournalEntryVoucherListItem&gt;**](JournalEntryVoucherListItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Given when resource returned successfully |  -  |
| **204** | Given when there is no content to return |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="journalentryvouchersiddelete"></a>
# **JournalEntryVouchersIdDelete**
> void JournalEntryVouchersIdDelete (Guid id)

Delete a voucher, the accompanying lines and pages. (Auth roles: JournalEntryVoucher_Full)

Delete operations can only be done if the voucher is unposted and not in an approval workflow state.              The integration only has access to vouchers that it has created or is the current approver of.              This endpoint is common for all voucher services, and used regardless of voucher type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class JournalEntryVouchersIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new JournalEntryVouchersApi(config);
            var id = d77e1400-d1cb-44e3-853c-bf64d8953af3;  // Guid | The identifier of a journal entry voucher.

            try
            {
                // Delete a voucher, the accompanying lines and pages. (Auth roles: JournalEntryVoucher_Full)
                apiInstance.JournalEntryVouchersIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JournalEntryVouchersApi.JournalEntryVouchersIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the JournalEntryVouchersIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a voucher, the accompanying lines and pages. (Auth roles: JournalEntryVoucher_Full)
    apiInstance.JournalEntryVouchersIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JournalEntryVouchersApi.JournalEntryVouchersIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The identifier of a journal entry voucher. |  |

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

<a id="journalentryvouchersidehfget"></a>
# **JournalEntryVouchersIdEhfGet**
> void JournalEntryVouchersIdEhfGet (Guid id)

Retrieve the EHF-file from a voucher draft, if the voucher draft was created by EHF (Auth roles: JournalEntryVoucher, JournalEntryVoucher_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class JournalEntryVouchersIdEhfGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new JournalEntryVouchersApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Retrieve the EHF-file from a voucher draft, if the voucher draft was created by EHF (Auth roles: JournalEntryVoucher, JournalEntryVoucher_Full)
                apiInstance.JournalEntryVouchersIdEhfGet(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JournalEntryVouchersApi.JournalEntryVouchersIdEhfGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the JournalEntryVouchersIdEhfGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve the EHF-file from a voucher draft, if the voucher draft was created by EHF (Auth roles: JournalEntryVoucher, JournalEntryVoucher_Full)
    apiInstance.JournalEntryVouchersIdEhfGetWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JournalEntryVouchersApi.JournalEntryVouchersIdEhfGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

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
| **200** | Given when a resource was returned successfully |  -  |
| **404** | Given when resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="journalentryvouchersidsubmitforapprovalpost"></a>
# **JournalEntryVouchersIdSubmitForApprovalPost**
> VoucherApprovalStatusResponseDto JournalEntryVouchersIdSubmitForApprovalPost (Guid id, SubmitForApprovalPostDto submitForApprovalPostDto = null)

Submit a voucher for approval. (Auth roles: JournalEntryVoucher_Full)

Attempt to submit the journal entry voucher with the given id for approval.              Will only work if the client is configured with standard approver or the supplier of a supplier voucher is set with an approver.              If the voucher pass the validation rules in Go, it will be added in the approval workflow set in Go.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class JournalEntryVouchersIdSubmitForApprovalPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new JournalEntryVouchersApi(config);
            var id = 39608e1b-ab04-4040-9609-f523b2ba4624;  // Guid | Identifier of the vouhcer
            var submitForApprovalPostDto = new SubmitForApprovalPostDto(); // SubmitForApprovalPostDto |  (optional) 

            try
            {
                // Submit a voucher for approval. (Auth roles: JournalEntryVoucher_Full)
                VoucherApprovalStatusResponseDto result = apiInstance.JournalEntryVouchersIdSubmitForApprovalPost(id, submitForApprovalPostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JournalEntryVouchersApi.JournalEntryVouchersIdSubmitForApprovalPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the JournalEntryVouchersIdSubmitForApprovalPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Submit a voucher for approval. (Auth roles: JournalEntryVoucher_Full)
    ApiResponse<VoucherApprovalStatusResponseDto> response = apiInstance.JournalEntryVouchersIdSubmitForApprovalPostWithHttpInfo(id, submitForApprovalPostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JournalEntryVouchersApi.JournalEntryVouchersIdSubmitForApprovalPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Identifier of the vouhcer |  |
| **submitForApprovalPostDto** | [**SubmitForApprovalPostDto**](SubmitForApprovalPostDto.md) |  | [optional]  |

### Return type

[**VoucherApprovalStatusResponseDto**](VoucherApprovalStatusResponseDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Given when the resource was successfully submitted for approval |  -  |
| **400** | Bad Request |  -  |
| **409** | Given when the resource could not be submitted for approval |  -  |
| **404** | Given when request was invalid |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


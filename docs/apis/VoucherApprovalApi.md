# PowerOfficeGoV2.Api.VoucherApprovalApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**VoucherApprovalGet**](VoucherApprovalApi.md#voucherapprovalget) | **GET** /VoucherApproval | List the vouchers that are sent to the integration for approval. The voucher details can be retrieved using the JournalEntryVoucher with the corresponding voucher types. (Auth roles: VoucherApproval_Full) |
| [**VoucherApprovalVoucherIdPost**](VoucherApprovalApi.md#voucherapprovalvoucheridpost) | **POST** /VoucherApproval/{voucherId} | Approve, reject or return a voucher update back to the client. (Auth roles: VoucherApproval_Full) |

<a id="voucherapprovalget"></a>
# **VoucherApprovalGet**
> List&lt;VoucherForApprovalDto&gt; VoucherApprovalGet (ResourceParameters resourceParameter = null, DateTimeOffset availableFromDateTimeOffsetGreaterThan = null)

List the vouchers that are sent to the integration for approval. The voucher details can be retrieved using the JournalEntryVoucher with the corresponding voucher types. (Auth roles: VoucherApproval_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class VoucherApprovalGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new VoucherApprovalApi(config);
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 
            var availableFromDateTimeOffsetGreaterThan = 2021-09-25 08:03:00.1234567 -00:00;  // DateTimeOffset | Filter vouchers based on when it became available with timestamp greater than the provided timestamp. Can be used as one way of getting changes in new vouchers available sins last called.  Timestamp not inclusive.                Vouchers sent to the integration for approval may be removed from the list by the system, indicating they are no longer available for approval. Utilizing the availableFromDateTimeOffset  parameter allows for retrieving new vouchers since the last call. However, it does not provide visibility into vouchers that have been removed from the list. (optional) 

            try
            {
                // List the vouchers that are sent to the integration for approval. The voucher details can be retrieved using the JournalEntryVoucher with the corresponding voucher types. (Auth roles: VoucherApproval_Full)
                List<VoucherForApprovalDto> result = apiInstance.VoucherApprovalGet(resourceParameter, availableFromDateTimeOffsetGreaterThan);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VoucherApprovalApi.VoucherApprovalGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VoucherApprovalGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List the vouchers that are sent to the integration for approval. The voucher details can be retrieved using the JournalEntryVoucher with the corresponding voucher types. (Auth roles: VoucherApproval_Full)
    ApiResponse<List<VoucherForApprovalDto>> response = apiInstance.VoucherApprovalGetWithHttpInfo(resourceParameter, availableFromDateTimeOffsetGreaterThan);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VoucherApprovalApi.VoucherApprovalGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |
| **availableFromDateTimeOffsetGreaterThan** | **DateTimeOffset** | Filter vouchers based on when it became available with timestamp greater than the provided timestamp. Can be used as one way of getting changes in new vouchers available sins last called.  Timestamp not inclusive.                Vouchers sent to the integration for approval may be removed from the list by the system, indicating they are no longer available for approval. Utilizing the availableFromDateTimeOffset  parameter allows for retrieving new vouchers since the last call. However, it does not provide visibility into vouchers that have been removed from the list. | [optional]  |

### Return type

[**List&lt;VoucherForApprovalDto&gt;**](VoucherForApprovalDto.md)

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

<a id="voucherapprovalvoucheridpost"></a>
# **VoucherApprovalVoucherIdPost**
> VoucherApprovalStatusResponseDto VoucherApprovalVoucherIdPost (Guid voucherId, VoucherApprovalPostDto voucherApprovalPostDto = null)

Approve, reject or return a voucher update back to the client. (Auth roles: VoucherApproval_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class VoucherApprovalVoucherIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new VoucherApprovalApi(config);
            var voucherId = "voucherId_example";  // Guid | 
            var voucherApprovalPostDto = new VoucherApprovalPostDto(); // VoucherApprovalPostDto |  (optional) 

            try
            {
                // Approve, reject or return a voucher update back to the client. (Auth roles: VoucherApproval_Full)
                VoucherApprovalStatusResponseDto result = apiInstance.VoucherApprovalVoucherIdPost(voucherId, voucherApprovalPostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VoucherApprovalApi.VoucherApprovalVoucherIdPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VoucherApprovalVoucherIdPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Approve, reject or return a voucher update back to the client. (Auth roles: VoucherApproval_Full)
    ApiResponse<VoucherApprovalStatusResponseDto> response = apiInstance.VoucherApprovalVoucherIdPostWithHttpInfo(voucherId, voucherApprovalPostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VoucherApprovalApi.VoucherApprovalVoucherIdPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **voucherId** | **Guid** |  |  |
| **voucherApprovalPostDto** | [**VoucherApprovalPostDto**](VoucherApprovalPostDto.md) |  | [optional]  |

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
| **200** | Given when voucher was successfully approved or rejected. |  -  |
| **400** | Given when request is badly formatted. |  -  |
| **404** | Given when voucher to be approved was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


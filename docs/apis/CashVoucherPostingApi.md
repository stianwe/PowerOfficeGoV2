# PowerOfficeGoV2.Api.CashVoucherPostingApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetCashVoucherById**](CashVoucherPostingApi.md#getcashvoucherbyid) | **GET** /Vouchers/CashJournals/{id} | Gets the specific cash voucher by id. (Auth roles: CashVoucher_Full) |
| [**VouchersCashJournalsPost**](CashVoucherPostingApi.md#voucherscashjournalspost) | **POST** /Vouchers/CashJournals | Directly post a new Cash voucher to the general ledger. (Auth roles: CashVoucher_Full) |

<a id="getcashvoucherbyid"></a>
# **GetCashVoucherById**
> CashVoucherDto GetCashVoucherById (Guid id)

Gets the specific cash voucher by id. (Auth roles: CashVoucher_Full)

Note that when querying Cash vouchers, a response will only be produced for vouchers the integration  have created using POST operations with the cash voucher endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetCashVoucherByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new CashVoucherPostingApi(config);
            var id = 38ecfc1a-bf51-448f-99a8-a61bc5771109;  // Guid | The id of the cash voucher.

            try
            {
                // Gets the specific cash voucher by id. (Auth roles: CashVoucher_Full)
                CashVoucherDto result = apiInstance.GetCashVoucherById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CashVoucherPostingApi.GetCashVoucherById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCashVoucherByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the specific cash voucher by id. (Auth roles: CashVoucher_Full)
    ApiResponse<CashVoucherDto> response = apiInstance.GetCashVoucherByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CashVoucherPostingApi.GetCashVoucherByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The id of the cash voucher. |  |

### Return type

[**CashVoucherDto**](CashVoucherDto.md)

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

<a id="voucherscashjournalspost"></a>
# **VouchersCashJournalsPost**
> CashVoucherDto VouchersCashJournalsPost (CashVoucherPostDto cashVoucherPostDto = null)

Directly post a new Cash voucher to the general ledger. (Auth roles: CashVoucher_Full)

Directly post a new Cash voucher to the general ledger of the client. Cash vouchers are typically used in  relation to payment transactions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class VouchersCashJournalsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new CashVoucherPostingApi(config);
            var cashVoucherPostDto = new CashVoucherPostDto(); // CashVoucherPostDto |  (optional) 

            try
            {
                // Directly post a new Cash voucher to the general ledger. (Auth roles: CashVoucher_Full)
                CashVoucherDto result = apiInstance.VouchersCashJournalsPost(cashVoucherPostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CashVoucherPostingApi.VouchersCashJournalsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VouchersCashJournalsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Directly post a new Cash voucher to the general ledger. (Auth roles: CashVoucher_Full)
    ApiResponse<CashVoucherDto> response = apiInstance.VouchersCashJournalsPostWithHttpInfo(cashVoucherPostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CashVoucherPostingApi.VouchersCashJournalsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cashVoucherPostDto** | [**CashVoucherPostDto**](CashVoucherPostDto.md) |  | [optional]  |

### Return type

[**CashVoucherDto**](CashVoucherDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Given when resource was created successfully |  -  |
| **400** | Given when request is badly formatted |  -  |
| **404** | Given when resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


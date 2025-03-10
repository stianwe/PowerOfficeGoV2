# PowerOfficeGoV2.Api.ManualVoucherPostingApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetManualVoucherById**](ManualVoucherPostingApi.md#getmanualvoucherbyid) | **GET** /Vouchers/ManualJournals/{id} | Gets the specific manual voucher by id. (Auth roles: ManualVoucher_Full) |
| [**VouchersManualJournalsPost**](ManualVoucherPostingApi.md#vouchersmanualjournalspost) | **POST** /Vouchers/ManualJournals | Directly post a new manual voucher to the general ledger of the client. (Auth roles: ManualVoucher_Full) |

<a id="getmanualvoucherbyid"></a>
# **GetManualVoucherById**
> ManualVoucherDto GetManualVoucherById (Guid id)

Gets the specific manual voucher by id. (Auth roles: ManualVoucher_Full)

Gets the specific manual voucher by id. Note that when querying manual vouchers, a response will only  be produced for vouchers the integration have created using POST operations with the manual voucher  endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetManualVoucherByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ManualVoucherPostingApi(config);
            var id = 38ecfc1a-bf51-448f-99a8-a61bc5771109;  // Guid | The id of the manual voucher.

            try
            {
                // Gets the specific manual voucher by id. (Auth roles: ManualVoucher_Full)
                ManualVoucherDto result = apiInstance.GetManualVoucherById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManualVoucherPostingApi.GetManualVoucherById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetManualVoucherByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the specific manual voucher by id. (Auth roles: ManualVoucher_Full)
    ApiResponse<ManualVoucherDto> response = apiInstance.GetManualVoucherByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManualVoucherPostingApi.GetManualVoucherByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The id of the manual voucher. |  |

### Return type

[**ManualVoucherDto**](ManualVoucherDto.md)

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

<a id="vouchersmanualjournalspost"></a>
# **VouchersManualJournalsPost**
> ManualVoucherDto VouchersManualJournalsPost (ManualVoucherPostDto manualVoucherPostDto = null)

Directly post a new manual voucher to the general ledger of the client. (Auth roles: ManualVoucher_Full)

Directly post a new manual voucher to the general ledger of the client. Manual vouchers contain general  voucher fields and features, and are often used if no other specific voucher types apply to the use case  of the transactions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class VouchersManualJournalsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ManualVoucherPostingApi(config);
            var manualVoucherPostDto = new ManualVoucherPostDto(); // ManualVoucherPostDto |  (optional) 

            try
            {
                // Directly post a new manual voucher to the general ledger of the client. (Auth roles: ManualVoucher_Full)
                ManualVoucherDto result = apiInstance.VouchersManualJournalsPost(manualVoucherPostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManualVoucherPostingApi.VouchersManualJournalsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VouchersManualJournalsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Directly post a new manual voucher to the general ledger of the client. (Auth roles: ManualVoucher_Full)
    ApiResponse<ManualVoucherDto> response = apiInstance.VouchersManualJournalsPostWithHttpInfo(manualVoucherPostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManualVoucherPostingApi.VouchersManualJournalsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **manualVoucherPostDto** | [**ManualVoucherPostDto**](ManualVoucherPostDto.md) |  | [optional]  |

### Return type

[**ManualVoucherDto**](ManualVoucherDto.md)

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


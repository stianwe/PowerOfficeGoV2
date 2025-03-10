# PowerOfficeGoV2.Api.ReverseVoucherPostingApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PostVoucherReversal**](ReverseVoucherPostingApi.md#postvoucherreversal) | **POST** /Vouchers/Reverse/{id} | Request a reversal of a given voucher. (Auth roles: YearEndVoucher_Full) |

<a id="postvoucherreversal"></a>
# **PostVoucherReversal**
> void PostVoucherReversal (Guid id)

Request a reversal of a given voucher. (Auth roles: YearEndVoucher_Full)

Request a reversal of a given voucher. Can only be used for vouchers the integration created using the POST  /voucher endpoints. When requested, Go will automatically create a new reversal voucher that nullify the  original transactions. Reversing a voucher that has an invoice number or an external import reference, will  enable the values of these properties to be reused on a new corrected voucher.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class PostVoucherReversalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ReverseVoucherPostingApi(config);
            var id = 38ecfc1a-bf51-448f-99a8-a61bc5771109;  // Guid | The unique identifier of the voucher to be reversed.

            try
            {
                // Request a reversal of a given voucher. (Auth roles: YearEndVoucher_Full)
                apiInstance.PostVoucherReversal(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReverseVoucherPostingApi.PostVoucherReversal: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostVoucherReversalWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Request a reversal of a given voucher. (Auth roles: YearEndVoucher_Full)
    apiInstance.PostVoucherReversalWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReverseVoucherPostingApi.PostVoucherReversalWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The unique identifier of the voucher to be reversed. |  |

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
| **202** | Accepted |  -  |
| **400** | Given when request is badly formatted |  -  |
| **404** | Given when resource was not found |  -  |
| **200** | The voucher reverse was successfully |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


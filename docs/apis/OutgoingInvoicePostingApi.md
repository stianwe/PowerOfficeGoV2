# PowerOfficeGoV2.Api.OutgoingInvoicePostingApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetOutgoingInvoiceVoucherById**](OutgoingInvoicePostingApi.md#getoutgoinginvoicevoucherbyid) | **GET** /Vouchers/OutgoingInvoiceJournals/{id} | Gets the specific Outgoing invoice voucher by id. (Auth roles: OutgoingInvoiceVoucher_Full) |

<a id="getoutgoinginvoicevoucherbyid"></a>
# **GetOutgoingInvoiceVoucherById**
> OutgoingInvoiceVoucherDto GetOutgoingInvoiceVoucherById (Guid id)

Gets the specific Outgoing invoice voucher by id. (Auth roles: OutgoingInvoiceVoucher_Full)

Gets the specific outgoing invoice voucher by id. Note that when querying outgoing invoice vouchers,  a response will only be produced for vouchers the integration have created using POST operations with the  outgoing invoice voucher endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetOutgoingInvoiceVoucherByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new OutgoingInvoicePostingApi(config);
            var id = 38ecfc1a-bf51-448f-99a8-a61bc5771109;  // Guid | The id of the outgoing invoice voucher.

            try
            {
                // Gets the specific Outgoing invoice voucher by id. (Auth roles: OutgoingInvoiceVoucher_Full)
                OutgoingInvoiceVoucherDto result = apiInstance.GetOutgoingInvoiceVoucherById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OutgoingInvoicePostingApi.GetOutgoingInvoiceVoucherById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOutgoingInvoiceVoucherByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the specific Outgoing invoice voucher by id. (Auth roles: OutgoingInvoiceVoucher_Full)
    ApiResponse<OutgoingInvoiceVoucherDto> response = apiInstance.GetOutgoingInvoiceVoucherByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OutgoingInvoicePostingApi.GetOutgoingInvoiceVoucherByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The id of the outgoing invoice voucher. |  |

### Return type

[**OutgoingInvoiceVoucherDto**](OutgoingInvoiceVoucherDto.md)

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


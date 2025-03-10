# PowerOfficeGoV2.Api.BankVoucherPostingApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetBankVoucherById**](BankVoucherPostingApi.md#getbankvoucherbyid) | **GET** /Vouchers/BankJournals/{id} | Gets the specific bank voucher by id. (Auth roles: BankVoucher_Full) |
| [**VouchersBankJournalsPost**](BankVoucherPostingApi.md#vouchersbankjournalspost) | **POST** /Vouchers/BankJournals | Directly post a new Bank voucher to the general ledger. (Auth roles: BankVoucher_Full) |

<a id="getbankvoucherbyid"></a>
# **GetBankVoucherById**
> BankVoucherDto GetBankVoucherById (Guid id)

Gets the specific bank voucher by id. (Auth roles: BankVoucher_Full)

Note that when querying Bank vouchers, a response will only be produced for vouchers the integration  have created using POST operations with the bank voucher endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetBankVoucherByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new BankVoucherPostingApi(config);
            var id = 38ecfc1a-bf51-448f-99a8-a61bc5771109;  // Guid | The id of the bank voucher.

            try
            {
                // Gets the specific bank voucher by id. (Auth roles: BankVoucher_Full)
                BankVoucherDto result = apiInstance.GetBankVoucherById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BankVoucherPostingApi.GetBankVoucherById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBankVoucherByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the specific bank voucher by id. (Auth roles: BankVoucher_Full)
    ApiResponse<BankVoucherDto> response = apiInstance.GetBankVoucherByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BankVoucherPostingApi.GetBankVoucherByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The id of the bank voucher. |  |

### Return type

[**BankVoucherDto**](BankVoucherDto.md)

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

<a id="vouchersbankjournalspost"></a>
# **VouchersBankJournalsPost**
> BankVoucherDto VouchersBankJournalsPost (BankVoucherPostDto bankVoucherPostDto = null)

Directly post a new Bank voucher to the general ledger. (Auth roles: BankVoucher_Full)

Directly post a new Bank voucher to the general ledger of the client. Bank vouchers are typically used in  relation to payment transactions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class VouchersBankJournalsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new BankVoucherPostingApi(config);
            var bankVoucherPostDto = new BankVoucherPostDto(); // BankVoucherPostDto |  (optional) 

            try
            {
                // Directly post a new Bank voucher to the general ledger. (Auth roles: BankVoucher_Full)
                BankVoucherDto result = apiInstance.VouchersBankJournalsPost(bankVoucherPostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BankVoucherPostingApi.VouchersBankJournalsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VouchersBankJournalsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Directly post a new Bank voucher to the general ledger. (Auth roles: BankVoucher_Full)
    ApiResponse<BankVoucherDto> response = apiInstance.VouchersBankJournalsPostWithHttpInfo(bankVoucherPostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BankVoucherPostingApi.VouchersBankJournalsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bankVoucherPostDto** | [**BankVoucherPostDto**](BankVoucherPostDto.md) |  | [optional]  |

### Return type

[**BankVoucherDto**](BankVoucherDto.md)

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


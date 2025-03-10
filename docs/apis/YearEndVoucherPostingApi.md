# PowerOfficeGoV2.Api.YearEndVoucherPostingApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetYearEndVoucherById**](YearEndVoucherPostingApi.md#getyearendvoucherbyid) | **GET** /Vouchers/YearEndJournals/{id} | Gets the specific year end voucher by id. (Auth roles: YearEndVoucher_Full) |
| [**VouchersYearEndJournalsPost**](YearEndVoucherPostingApi.md#vouchersyearendjournalspost) | **POST** /Vouchers/YearEndJournals | Directly post a new year end vocuher to the general ledger of the client. (Auth roles: YearEndVoucher_Full) |

<a id="getyearendvoucherbyid"></a>
# **GetYearEndVoucherById**
> YearEndVoucherDto GetYearEndVoucherById (Guid id)

Gets the specific year end voucher by id. (Auth roles: YearEndVoucher_Full)

Gets the specific year end voucher by id. Note that when querying year end vouchers, a response will only be  produced for vouchers the integration have created using POST operations with the year end voucher endpoint

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetYearEndVoucherByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new YearEndVoucherPostingApi(config);
            var id = 38ecfc1a-bf51-448f-99a8-a61bc5771109;  // Guid | The id of the year end voucher.

            try
            {
                // Gets the specific year end voucher by id. (Auth roles: YearEndVoucher_Full)
                YearEndVoucherDto result = apiInstance.GetYearEndVoucherById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling YearEndVoucherPostingApi.GetYearEndVoucherById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetYearEndVoucherByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the specific year end voucher by id. (Auth roles: YearEndVoucher_Full)
    ApiResponse<YearEndVoucherDto> response = apiInstance.GetYearEndVoucherByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling YearEndVoucherPostingApi.GetYearEndVoucherByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The id of the year end voucher. |  |

### Return type

[**YearEndVoucherDto**](YearEndVoucherDto.md)

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
| **400** | Given when request is badly formatted |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="vouchersyearendjournalspost"></a>
# **VouchersYearEndJournalsPost**
> YearEndVoucherDto VouchersYearEndJournalsPost (YearEndVoucherPostDto yearEndVoucherPostDto = null)

Directly post a new year end vocuher to the general ledger of the client. (Auth roles: YearEndVoucher_Full)

Directly post a new year end voucher to the general ledger of the client. Year end vouchers are used for  the year end closing transactions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class VouchersYearEndJournalsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new YearEndVoucherPostingApi(config);
            var yearEndVoucherPostDto = new YearEndVoucherPostDto(); // YearEndVoucherPostDto |  (optional) 

            try
            {
                // Directly post a new year end vocuher to the general ledger of the client. (Auth roles: YearEndVoucher_Full)
                YearEndVoucherDto result = apiInstance.VouchersYearEndJournalsPost(yearEndVoucherPostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling YearEndVoucherPostingApi.VouchersYearEndJournalsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VouchersYearEndJournalsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Directly post a new year end vocuher to the general ledger of the client. (Auth roles: YearEndVoucher_Full)
    ApiResponse<YearEndVoucherDto> response = apiInstance.VouchersYearEndJournalsPostWithHttpInfo(yearEndVoucherPostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling YearEndVoucherPostingApi.VouchersYearEndJournalsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **yearEndVoucherPostDto** | [**YearEndVoucherPostDto**](YearEndVoucherPostDto.md) |  | [optional]  |

### Return type

[**YearEndVoucherDto**](YearEndVoucherDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Given when resource was created successfully |  -  |
| **404** | Given when an input resources id was not found |  -  |
| **400** | Given when request is badly formatted |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


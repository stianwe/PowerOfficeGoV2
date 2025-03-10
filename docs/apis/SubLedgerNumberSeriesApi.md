# PowerOfficeGoV2.Api.SubLedgerNumberSeriesApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SubLedgerNumberSeriesGet**](SubLedgerNumberSeriesApi.md#subledgernumberseriesget) | **GET** /SubLedgerNumberSeries | Gets the sub-ledger number series set on the client (Auth roles: CommonServices,CommonServices_Full) |
| [**SubLedgerNumberSeriesIdGet**](SubLedgerNumberSeriesApi.md#subledgernumberseriesidget) | **GET** /SubLedgerNumberSeries/{id} | Get a SubLedgerNumberSeries by ID. (Auth roles: CommonServices,CommonServices_Full) |

<a id="subledgernumberseriesget"></a>
# **SubLedgerNumberSeriesGet**
> List&lt;SubLedgerNumberSeriesDto&gt; SubLedgerNumberSeriesGet (string generalLedgerAccountNos = null, bool isDefault = null, string subLedgerNumberSeriesType = null, ResourceParameters resourceParameter = null)

Gets the sub-ledger number series set on the client (Auth roles: CommonServices,CommonServices_Full)

Gets the sub-ledger number series set on the client. Sub-ledgers are sub-accounts of a general ledger account, used  for entries related to either customers, suppliers or employees.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class SubLedgerNumberSeriesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new SubLedgerNumberSeriesApi(config);
            var generalLedgerAccountNos = 1500-3100;  // string | Gets the underlying general ledger account code of this subledger series. Subledger transactions in Go will be posted using the subledger number, but the overall accounting effect will be on this underlying account. More information of accounts can be retrieved using the GeneralLedgerAccount service. (optional) 
            var isDefault = true;  // bool | Filter series based on the isDefault property. Blank means no filter. (optional) 
            var subLedgerNumberSeriesType = Customer, Employee, Supplier;  // string | Filter by SubledgerNumberSeriesType                Note: The SubLedgerNumberSeriesType filter is case sensitive. (optional) 
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Gets the sub-ledger number series set on the client (Auth roles: CommonServices,CommonServices_Full)
                List<SubLedgerNumberSeriesDto> result = apiInstance.SubLedgerNumberSeriesGet(generalLedgerAccountNos, isDefault, subLedgerNumberSeriesType, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubLedgerNumberSeriesApi.SubLedgerNumberSeriesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubLedgerNumberSeriesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the sub-ledger number series set on the client (Auth roles: CommonServices,CommonServices_Full)
    ApiResponse<List<SubLedgerNumberSeriesDto>> response = apiInstance.SubLedgerNumberSeriesGetWithHttpInfo(generalLedgerAccountNos, isDefault, subLedgerNumberSeriesType, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubLedgerNumberSeriesApi.SubLedgerNumberSeriesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **generalLedgerAccountNos** | **string** | Gets the underlying general ledger account code of this subledger series. Subledger transactions in Go will be posted using the subledger number, but the overall accounting effect will be on this underlying account. More information of accounts can be retrieved using the GeneralLedgerAccount service. | [optional]  |
| **isDefault** | **bool** | Filter series based on the isDefault property. Blank means no filter. | [optional]  |
| **subLedgerNumberSeriesType** | **string** | Filter by SubledgerNumberSeriesType                Note: The SubLedgerNumberSeriesType filter is case sensitive. | [optional]  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;SubLedgerNumberSeriesDto&gt;**](SubLedgerNumberSeriesDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Given when resource returned successfully |  -  |
| **204** | Given when no content is returned |  -  |
| **400** | Given when request is badly formatted |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="subledgernumberseriesidget"></a>
# **SubLedgerNumberSeriesIdGet**
> void SubLedgerNumberSeriesIdGet (Guid id)

Get a SubLedgerNumberSeries by ID. (Auth roles: CommonServices,CommonServices_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class SubLedgerNumberSeriesIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new SubLedgerNumberSeriesApi(config);
            var id = 1b8eec31-1f4f-434e-a73f-556eeea873e9;  // Guid | 

            try
            {
                // Get a SubLedgerNumberSeries by ID. (Auth roles: CommonServices,CommonServices_Full)
                apiInstance.SubLedgerNumberSeriesIdGet(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubLedgerNumberSeriesApi.SubLedgerNumberSeriesIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubLedgerNumberSeriesIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a SubLedgerNumberSeries by ID. (Auth roles: CommonServices,CommonServices_Full)
    apiInstance.SubLedgerNumberSeriesIdGetWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubLedgerNumberSeriesApi.SubLedgerNumberSeriesIdGetWithHttpInfo: " + e.Message);
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
| **200** | Given when resource returned successfully |  -  |
| **404** | Given when resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


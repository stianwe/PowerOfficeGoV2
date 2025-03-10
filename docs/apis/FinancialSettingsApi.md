# PowerOfficeGoV2.Api.FinancialSettingsApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetFinancialSettings**](FinancialSettingsApi.md#getfinancialsettings) | **GET** /FinancialSettings | Gets the financial settings on the client, and conversion date. (Auth roles: CommonServices,CommonServices_Full) |

<a id="getfinancialsettings"></a>
# **GetFinancialSettings**
> FinancialSettingsDto GetFinancialSettings ()

Gets the financial settings on the client, and conversion date. (Auth roles: CommonServices,CommonServices_Full)

Changes in agio (gains) and disagio (loss) accounts does not update the LastChangedDateTimeOffset property in FinancialSettings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetFinancialSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new FinancialSettingsApi(config);

            try
            {
                // Gets the financial settings on the client, and conversion date. (Auth roles: CommonServices,CommonServices_Full)
                FinancialSettingsDto result = apiInstance.GetFinancialSettings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FinancialSettingsApi.GetFinancialSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFinancialSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the financial settings on the client, and conversion date. (Auth roles: CommonServices,CommonServices_Full)
    ApiResponse<FinancialSettingsDto> response = apiInstance.GetFinancialSettingsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FinancialSettingsApi.GetFinancialSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**FinancialSettingsDto**](FinancialSettingsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Given when resource was successfully returned. |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


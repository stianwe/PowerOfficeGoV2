# PowerOfficeGoV2.Api.PayrollSettingsApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PayrollSettingsGet**](PayrollSettingsApi.md#payrollsettingsget) | **GET** /PayrollSettings | Get payroll settings for the client. (Auth roles: PayrollSettings,PayrollSettings_Full) |
| [**PayrollSettingsPensionSchemesGet**](PayrollSettingsApi.md#payrollsettingspensionschemesget) | **GET** /PayrollSettings/PensionSchemes | Get the pension schemes set in the payroll settings for the client. (Auth roles: PayrollSettings,PayrollSettings_Full) |

<a id="payrollsettingsget"></a>
# **PayrollSettingsGet**
> PayrollSettingsDto PayrollSettingsGet ()

Get payroll settings for the client. (Auth roles: PayrollSettings,PayrollSettings_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class PayrollSettingsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new PayrollSettingsApi(config);

            try
            {
                // Get payroll settings for the client. (Auth roles: PayrollSettings,PayrollSettings_Full)
                PayrollSettingsDto result = apiInstance.PayrollSettingsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PayrollSettingsApi.PayrollSettingsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PayrollSettingsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get payroll settings for the client. (Auth roles: PayrollSettings,PayrollSettings_Full)
    ApiResponse<PayrollSettingsDto> response = apiInstance.PayrollSettingsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PayrollSettingsApi.PayrollSettingsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**PayrollSettingsDto**](PayrollSettingsDto.md)

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

<a id="payrollsettingspensionschemesget"></a>
# **PayrollSettingsPensionSchemesGet**
> List&lt;PensionSchemeDto&gt; PayrollSettingsPensionSchemesGet (ResourceParameters resourceParameter = null)

Get the pension schemes set in the payroll settings for the client. (Auth roles: PayrollSettings,PayrollSettings_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class PayrollSettingsPensionSchemesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new PayrollSettingsApi(config);
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Get the pension schemes set in the payroll settings for the client. (Auth roles: PayrollSettings,PayrollSettings_Full)
                List<PensionSchemeDto> result = apiInstance.PayrollSettingsPensionSchemesGet(resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PayrollSettingsApi.PayrollSettingsPensionSchemesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PayrollSettingsPensionSchemesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the pension schemes set in the payroll settings for the client. (Auth roles: PayrollSettings,PayrollSettings_Full)
    ApiResponse<List<PensionSchemeDto>> response = apiInstance.PayrollSettingsPensionSchemesGetWithHttpInfo(resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PayrollSettingsApi.PayrollSettingsPensionSchemesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;PensionSchemeDto&gt;**](PensionSchemeDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Given when resource returned successfully |  -  |
| **204** | Given when there is no content to return (response body is empty) |  -  |
| **400** | Given when request is badly formatted |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


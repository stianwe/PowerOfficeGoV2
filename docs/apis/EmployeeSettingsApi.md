# PowerOfficeGoV2.Api.EmployeeSettingsApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EmployeesEmployeeIdPayrollSettingsPatch**](EmployeeSettingsApi.md#employeesemployeeidpayrollsettingspatch) | **PATCH** /Employees/{employeeId}/PayrollSettings | Change payroll settings for an employee with a given id. (Auth roles: EmployeePayrollSettings_Full) |
| [**EmployeesEmployeeIdPensionSettingsPatch**](EmployeeSettingsApi.md#employeesemployeeidpensionsettingspatch) | **PATCH** /Employees/{employeeId}/PensionSettings | Change pension settings for an employee with a given id. (Auth roles: EmployeePensionSettings_Full) |
| [**GetEmployeePayrollSettings**](EmployeeSettingsApi.md#getemployeepayrollsettings) | **GET** /Employees/{employeeId}/PayrollSettings | Gets the payroll settings for a given employee.  These settings will default inherit from the general payroll settings, if not overridden on the employee. (Auth roles: EmployeePayrollSettings,EmployeePayrollSettings_Full) |
| [**GetEmployeePensionSettings**](EmployeeSettingsApi.md#getemployeepensionsettings) | **GET** /Employees/{employeeId}/PensionSettings | Gets the pension settings for a given employee.  These settings will default inherit from the general payroll settings, if not overridden on the employee. (Auth roles: EmployeePensionSettings,EmployeePensionSettings_Full) |

<a id="employeesemployeeidpayrollsettingspatch"></a>
# **EmployeesEmployeeIdPayrollSettingsPatch**
> EmployeePayrollSettingsDto EmployeesEmployeeIdPayrollSettingsPatch (long employeeId, List<Operation> operation = null)

Change payroll settings for an employee with a given id. (Auth roles: EmployeePayrollSettings_Full)

Note that in order to use this endpoint you need to have the special privilege \"EmployeePayrollSettings\".

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class EmployeesEmployeeIdPayrollSettingsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmployeeSettingsApi(config);
            var employeeId = 12345;  // long | The id of the employee.
            var operation = new List<Operation>(); // List<Operation> | JSON Patch structure for updating employee payroll settings. See EmployeePayrollSettingsPatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 (optional) 

            try
            {
                // Change payroll settings for an employee with a given id. (Auth roles: EmployeePayrollSettings_Full)
                EmployeePayrollSettingsDto result = apiInstance.EmployeesEmployeeIdPayrollSettingsPatch(employeeId, operation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmployeeSettingsApi.EmployeesEmployeeIdPayrollSettingsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmployeesEmployeeIdPayrollSettingsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change payroll settings for an employee with a given id. (Auth roles: EmployeePayrollSettings_Full)
    ApiResponse<EmployeePayrollSettingsDto> response = apiInstance.EmployeesEmployeeIdPayrollSettingsPatchWithHttpInfo(employeeId, operation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmployeeSettingsApi.EmployeesEmployeeIdPayrollSettingsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employeeId** | **long** | The id of the employee. |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) | JSON Patch structure for updating employee payroll settings. See EmployeePayrollSettingsPatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 | [optional]  |

### Return type

[**EmployeePayrollSettingsDto**](EmployeePayrollSettingsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Given when resource was successfully updated. |  -  |
| **400** | Given when request is badly formatted |  -  |
| **404** | Given when resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="employeesemployeeidpensionsettingspatch"></a>
# **EmployeesEmployeeIdPensionSettingsPatch**
> EmployeePensionSettingsDto EmployeesEmployeeIdPensionSettingsPatch (long employeeId, List<Operation> operation = null)

Change pension settings for an employee with a given id. (Auth roles: EmployeePensionSettings_Full)

Note that in order to use this endpoint you need to have the special privilege \"EmployeePensionSettings\".

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class EmployeesEmployeeIdPensionSettingsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmployeeSettingsApi(config);
            var employeeId = 12345;  // long | The id of the employee.
            var operation = new List<Operation>(); // List<Operation> | JSON Patch structure for updating employee pension settings. See EmployeePensionSettingsPatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 (optional) 

            try
            {
                // Change pension settings for an employee with a given id. (Auth roles: EmployeePensionSettings_Full)
                EmployeePensionSettingsDto result = apiInstance.EmployeesEmployeeIdPensionSettingsPatch(employeeId, operation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmployeeSettingsApi.EmployeesEmployeeIdPensionSettingsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmployeesEmployeeIdPensionSettingsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change pension settings for an employee with a given id. (Auth roles: EmployeePensionSettings_Full)
    ApiResponse<EmployeePensionSettingsDto> response = apiInstance.EmployeesEmployeeIdPensionSettingsPatchWithHttpInfo(employeeId, operation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmployeeSettingsApi.EmployeesEmployeeIdPensionSettingsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employeeId** | **long** | The id of the employee. |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) | JSON Patch structure for updating employee pension settings. See EmployeePensionSettingsPatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 | [optional]  |

### Return type

[**EmployeePensionSettingsDto**](EmployeePensionSettingsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Given when resource was successfully updated. |  -  |
| **400** | Given when request is badly formatted |  -  |
| **404** | Given when resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getemployeepayrollsettings"></a>
# **GetEmployeePayrollSettings**
> EmployeePayrollSettingsDto GetEmployeePayrollSettings (long employeeId)

Gets the payroll settings for a given employee.  These settings will default inherit from the general payroll settings, if not overridden on the employee. (Auth roles: EmployeePayrollSettings,EmployeePayrollSettings_Full)

Note that in order to use this endpoint you need to have the special privilege \"EmployeePayrollSettings\".

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetEmployeePayrollSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmployeeSettingsApi(config);
            var employeeId = 12345;  // long | The id of the employee.

            try
            {
                // Gets the payroll settings for a given employee.  These settings will default inherit from the general payroll settings, if not overridden on the employee. (Auth roles: EmployeePayrollSettings,EmployeePayrollSettings_Full)
                EmployeePayrollSettingsDto result = apiInstance.GetEmployeePayrollSettings(employeeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmployeeSettingsApi.GetEmployeePayrollSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEmployeePayrollSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the payroll settings for a given employee.  These settings will default inherit from the general payroll settings, if not overridden on the employee. (Auth roles: EmployeePayrollSettings,EmployeePayrollSettings_Full)
    ApiResponse<EmployeePayrollSettingsDto> response = apiInstance.GetEmployeePayrollSettingsWithHttpInfo(employeeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmployeeSettingsApi.GetEmployeePayrollSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employeeId** | **long** | The id of the employee. |  |

### Return type

[**EmployeePayrollSettingsDto**](EmployeePayrollSettingsDto.md)

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

<a id="getemployeepensionsettings"></a>
# **GetEmployeePensionSettings**
> EmployeePensionSettingsDto GetEmployeePensionSettings (long employeeId)

Gets the pension settings for a given employee.  These settings will default inherit from the general payroll settings, if not overridden on the employee. (Auth roles: EmployeePensionSettings,EmployeePensionSettings_Full)

Note that in order to use this endpoint you need to have the special privilege \"EmployeePensionSettings\".

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetEmployeePensionSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmployeeSettingsApi(config);
            var employeeId = 12345;  // long | The id of the employee.

            try
            {
                // Gets the pension settings for a given employee.  These settings will default inherit from the general payroll settings, if not overridden on the employee. (Auth roles: EmployeePensionSettings,EmployeePensionSettings_Full)
                EmployeePensionSettingsDto result = apiInstance.GetEmployeePensionSettings(employeeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmployeeSettingsApi.GetEmployeePensionSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEmployeePensionSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the pension settings for a given employee.  These settings will default inherit from the general payroll settings, if not overridden on the employee. (Auth roles: EmployeePensionSettings,EmployeePensionSettings_Full)
    ApiResponse<EmployeePensionSettingsDto> response = apiInstance.GetEmployeePensionSettingsWithHttpInfo(employeeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmployeeSettingsApi.GetEmployeePensionSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employeeId** | **long** | The id of the employee. |  |

### Return type

[**EmployeePensionSettingsDto**](EmployeePensionSettingsDto.md)

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


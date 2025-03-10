# PowerOfficeGoV2.Api.EmployeeHourlyRatesApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EmployeesEmployeeIdHourlyRatesGet**](EmployeeHourlyRatesApi.md#employeesemployeeidhourlyratesget) | **GET** /Employees/{employeeId}/HourlyRates | Gets all hourly rates registered on the employee. (Auth roles: EmployeeHourlyRates,EmployeeHourlyRates_Full) |
| [**EmployeesEmployeeIdHourlyRatesHourlyRateIdDelete**](EmployeeHourlyRatesApi.md#employeesemployeeidhourlyrateshourlyrateiddelete) | **DELETE** /Employees/{employeeId}/HourlyRates/{hourlyRateId} | Delete a specific set of hourly rates on a given employee. (Auth roles: EmployeeHourlyRates_Full) |
| [**EmployeesEmployeeIdHourlyRatesHourlyRateIdPatch**](EmployeeHourlyRatesApi.md#employeesemployeeidhourlyrateshourlyrateidpatch) | **PATCH** /Employees/{employeeId}/HourlyRates/{hourlyRateId} | Change an existing hourly rate entry on an employee with a given (hourlRate) Id. (Auth roles: EmployeeHourlyRates_Full) |
| [**EmployeesEmployeeIdHourlyRatesPost**](EmployeeHourlyRatesApi.md#employeesemployeeidhourlyratespost) | **POST** /Employees/{employeeId}/HourlyRates | Create one new hourly rate entity. (Auth roles: EmployeeHourlyRates_Full) |
| [**GetHourlyRateById**](EmployeeHourlyRatesApi.md#gethourlyratebyid) | **GET** /Employees/{employeeId}/HourlyRates/{hourlyRateId} | Gets a specific hourly rate on a given employee. (Auth roles: EmployeeHourlyRates,EmployeeHourlyRates_Full) |

<a id="employeesemployeeidhourlyratesget"></a>
# **EmployeesEmployeeIdHourlyRatesGet**
> List&lt;EmployeeHourlyRateDto&gt; EmployeesEmployeeIdHourlyRatesGet (long employeeId, bool validNow = null, ResourceParameters resourceParameter = null)

Gets all hourly rates registered on the employee. (Auth roles: EmployeeHourlyRates,EmployeeHourlyRates_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class EmployeesEmployeeIdHourlyRatesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmployeeHourlyRatesApi(config);
            var employeeId = 12345;  // long | The id of the employee.
            var validNow = true;  // bool | Sets a parameter filtering the hourly rates that are active and in effect at the time of the query (if set true). If false, the complete collection of hourly rates will be returned, including past rates and future sets (if any). (optional) 
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Gets all hourly rates registered on the employee. (Auth roles: EmployeeHourlyRates,EmployeeHourlyRates_Full)
                List<EmployeeHourlyRateDto> result = apiInstance.EmployeesEmployeeIdHourlyRatesGet(employeeId, validNow, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmployeeHourlyRatesApi.EmployeesEmployeeIdHourlyRatesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmployeesEmployeeIdHourlyRatesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets all hourly rates registered on the employee. (Auth roles: EmployeeHourlyRates,EmployeeHourlyRates_Full)
    ApiResponse<List<EmployeeHourlyRateDto>> response = apiInstance.EmployeesEmployeeIdHourlyRatesGetWithHttpInfo(employeeId, validNow, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmployeeHourlyRatesApi.EmployeesEmployeeIdHourlyRatesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employeeId** | **long** | The id of the employee. |  |
| **validNow** | **bool** | Sets a parameter filtering the hourly rates that are active and in effect at the time of the query (if set true). If false, the complete collection of hourly rates will be returned, including past rates and future sets (if any). | [optional]  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;EmployeeHourlyRateDto&gt;**](EmployeeHourlyRateDto.md)

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
| **404** | Given when resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="employeesemployeeidhourlyrateshourlyrateiddelete"></a>
# **EmployeesEmployeeIdHourlyRatesHourlyRateIdDelete**
> void EmployeesEmployeeIdHourlyRatesHourlyRateIdDelete (long employeeId, long hourlyRateId)

Delete a specific set of hourly rates on a given employee. (Auth roles: EmployeeHourlyRates_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class EmployeesEmployeeIdHourlyRatesHourlyRateIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmployeeHourlyRatesApi(config);
            var employeeId = 12345;  // long | The id of the employee the hourly rate belongs to.
            var hourlyRateId = 123;  // long | The id of the hourly rate to delete.

            try
            {
                // Delete a specific set of hourly rates on a given employee. (Auth roles: EmployeeHourlyRates_Full)
                apiInstance.EmployeesEmployeeIdHourlyRatesHourlyRateIdDelete(employeeId, hourlyRateId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmployeeHourlyRatesApi.EmployeesEmployeeIdHourlyRatesHourlyRateIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmployeesEmployeeIdHourlyRatesHourlyRateIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a specific set of hourly rates on a given employee. (Auth roles: EmployeeHourlyRates_Full)
    apiInstance.EmployeesEmployeeIdHourlyRatesHourlyRateIdDeleteWithHttpInfo(employeeId, hourlyRateId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmployeeHourlyRatesApi.EmployeesEmployeeIdHourlyRatesHourlyRateIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employeeId** | **long** | The id of the employee the hourly rate belongs to. |  |
| **hourlyRateId** | **long** | The id of the hourly rate to delete. |  |

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
| **200** | Given when hourly rate is deleted |  -  |
| **404** | Given when resource was not found |  -  |
| **409** | Given when resource is in use and cannot be deleted |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="employeesemployeeidhourlyrateshourlyrateidpatch"></a>
# **EmployeesEmployeeIdHourlyRatesHourlyRateIdPatch**
> EmployeeHourlyRateDto EmployeesEmployeeIdHourlyRatesHourlyRateIdPatch (long employeeId, long hourlyRateId, List<Operation> operation = null)

Change an existing hourly rate entry on an employee with a given (hourlRate) Id. (Auth roles: EmployeeHourlyRates_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class EmployeesEmployeeIdHourlyRatesHourlyRateIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmployeeHourlyRatesApi(config);
            var employeeId = 12345;  // long | The id of the employee.
            var hourlyRateId = 123;  // long | The id of the hourly rate to update.
            var operation = new List<Operation>(); // List<Operation> | JSON Patch structure for updating an hourly rate. See EmployeeHourlyRatesPatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 (optional) 

            try
            {
                // Change an existing hourly rate entry on an employee with a given (hourlRate) Id. (Auth roles: EmployeeHourlyRates_Full)
                EmployeeHourlyRateDto result = apiInstance.EmployeesEmployeeIdHourlyRatesHourlyRateIdPatch(employeeId, hourlyRateId, operation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmployeeHourlyRatesApi.EmployeesEmployeeIdHourlyRatesHourlyRateIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmployeesEmployeeIdHourlyRatesHourlyRateIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change an existing hourly rate entry on an employee with a given (hourlRate) Id. (Auth roles: EmployeeHourlyRates_Full)
    ApiResponse<EmployeeHourlyRateDto> response = apiInstance.EmployeesEmployeeIdHourlyRatesHourlyRateIdPatchWithHttpInfo(employeeId, hourlyRateId, operation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmployeeHourlyRatesApi.EmployeesEmployeeIdHourlyRatesHourlyRateIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employeeId** | **long** | The id of the employee. |  |
| **hourlyRateId** | **long** | The id of the hourly rate to update. |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) | JSON Patch structure for updating an hourly rate. See EmployeeHourlyRatesPatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 | [optional]  |

### Return type

[**EmployeeHourlyRateDto**](EmployeeHourlyRateDto.md)

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

<a id="employeesemployeeidhourlyratespost"></a>
# **EmployeesEmployeeIdHourlyRatesPost**
> EmployeeHourlyRateDto EmployeesEmployeeIdHourlyRatesPost (long employeeId, EmployeeHourlyRatePostDto employeeHourlyRatePostDto = null)

Create one new hourly rate entity. (Auth roles: EmployeeHourlyRates_Full)

If successful, the new entity will be returned with an id which is unique and can be used to reference the created object in relevant requests.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class EmployeesEmployeeIdHourlyRatesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmployeeHourlyRatesApi(config);
            var employeeId = 12345;  // long | The id of the employee.
            var employeeHourlyRatePostDto = new EmployeeHourlyRatePostDto(); // EmployeeHourlyRatePostDto | A employee hourly rate post dto (optional) 

            try
            {
                // Create one new hourly rate entity. (Auth roles: EmployeeHourlyRates_Full)
                EmployeeHourlyRateDto result = apiInstance.EmployeesEmployeeIdHourlyRatesPost(employeeId, employeeHourlyRatePostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmployeeHourlyRatesApi.EmployeesEmployeeIdHourlyRatesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmployeesEmployeeIdHourlyRatesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create one new hourly rate entity. (Auth roles: EmployeeHourlyRates_Full)
    ApiResponse<EmployeeHourlyRateDto> response = apiInstance.EmployeesEmployeeIdHourlyRatesPostWithHttpInfo(employeeId, employeeHourlyRatePostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmployeeHourlyRatesApi.EmployeesEmployeeIdHourlyRatesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employeeId** | **long** | The id of the employee. |  |
| **employeeHourlyRatePostDto** | [**EmployeeHourlyRatePostDto**](EmployeeHourlyRatePostDto.md) | A employee hourly rate post dto | [optional]  |

### Return type

[**EmployeeHourlyRateDto**](EmployeeHourlyRateDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Given when resource was successfully created. |  -  |
| **400** | Given when request is badly formatted. |  -  |
| **404** | Given when resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="gethourlyratebyid"></a>
# **GetHourlyRateById**
> EmployeeHourlyRateDto GetHourlyRateById (long employeeId, long hourlyRateId)

Gets a specific hourly rate on a given employee. (Auth roles: EmployeeHourlyRates,EmployeeHourlyRates_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetHourlyRateByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmployeeHourlyRatesApi(config);
            var employeeId = 12345;  // long | The id of the employee.
            var hourlyRateId = 123;  // long | The id of the hourly rate.

            try
            {
                // Gets a specific hourly rate on a given employee. (Auth roles: EmployeeHourlyRates,EmployeeHourlyRates_Full)
                EmployeeHourlyRateDto result = apiInstance.GetHourlyRateById(employeeId, hourlyRateId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmployeeHourlyRatesApi.GetHourlyRateById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetHourlyRateByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a specific hourly rate on a given employee. (Auth roles: EmployeeHourlyRates,EmployeeHourlyRates_Full)
    ApiResponse<EmployeeHourlyRateDto> response = apiInstance.GetHourlyRateByIdWithHttpInfo(employeeId, hourlyRateId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmployeeHourlyRatesApi.GetHourlyRateByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employeeId** | **long** | The id of the employee. |  |
| **hourlyRateId** | **long** | The id of the hourly rate. |  |

### Return type

[**EmployeeHourlyRateDto**](EmployeeHourlyRateDto.md)

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


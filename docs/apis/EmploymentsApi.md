# PowerOfficeGoV2.Api.EmploymentsApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EmployeesEmployeeIdEmploymentsEmploymentIdDelete**](EmploymentsApi.md#employeesemployeeidemploymentsemploymentiddelete) | **DELETE** /Employees/{employeeId}/Employments/{employmentId} | Delete a specific employment on a given employee. (Auth roles: Employment_Full) |
| [**EmployeesEmployeeIdEmploymentsEmploymentIdPatch**](EmploymentsApi.md#employeesemployeeidemploymentsemploymentidpatch) | **PATCH** /Employees/{employeeId}/Employments/{employmentId} | Change an existing employment with a given id. (Auth roles: Employment_Full) |
| [**EmployeesEmployeeIdEmploymentsGet**](EmploymentsApi.md#employeesemployeeidemploymentsget) | **GET** /Employees/{employeeId}/Employments | Get employments (employment relationships) on the employee. (Auth roles: Employment,Employment_Full) |
| [**EmployeesEmployeeIdEmploymentsPost**](EmploymentsApi.md#employeesemployeeidemploymentspost) | **POST** /Employees/{employeeId}/Employments | Create a new employment. (Auth roles: Employment_Full) |
| [**EmployeesEmploymentsGet**](EmploymentsApi.md#employeesemploymentsget) | **GET** /Employees/Employments | Get all employments for all employees registered on the client. (Auth roles: Employment,Employment_Full) |
| [**GetEmploymentById**](EmploymentsApi.md#getemploymentbyid) | **GET** /Employees/{employeeId}/Employments/{employmentId} | Gets a specific employment on a given employee. (Auth roles: Employment,Employment_Full) |

<a id="employeesemployeeidemploymentsemploymentiddelete"></a>
# **EmployeesEmployeeIdEmploymentsEmploymentIdDelete**
> void EmployeesEmployeeIdEmploymentsEmploymentIdDelete (long employeeId, long employmentId)

Delete a specific employment on a given employee. (Auth roles: Employment_Full)

Note that an employment cannot be deleted if it has been reported (a-melding).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class EmployeesEmployeeIdEmploymentsEmploymentIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmploymentsApi(config);
            var employeeId = 12345;  // long | The id of the employee.
            var employmentId = 98765;  // long | The id of the employment to delete.

            try
            {
                // Delete a specific employment on a given employee. (Auth roles: Employment_Full)
                apiInstance.EmployeesEmployeeIdEmploymentsEmploymentIdDelete(employeeId, employmentId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentsApi.EmployeesEmployeeIdEmploymentsEmploymentIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmployeesEmployeeIdEmploymentsEmploymentIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a specific employment on a given employee. (Auth roles: Employment_Full)
    apiInstance.EmployeesEmployeeIdEmploymentsEmploymentIdDeleteWithHttpInfo(employeeId, employmentId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmploymentsApi.EmployeesEmployeeIdEmploymentsEmploymentIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employeeId** | **long** | The id of the employee. |  |
| **employmentId** | **long** | The id of the employment to delete. |  |

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
| **200** | Given when salary line is deleted |  -  |
| **404** | Given when resource was not found |  -  |
| **409** | Given when resource is in use and cannot be deleted |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="employeesemployeeidemploymentsemploymentidpatch"></a>
# **EmployeesEmployeeIdEmploymentsEmploymentIdPatch**
> EmploymentDto EmployeesEmployeeIdEmploymentsEmploymentIdPatch (long employeeId, long employmentId, List<Operation> operation = null)

Change an existing employment with a given id. (Auth roles: Employment_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class EmployeesEmployeeIdEmploymentsEmploymentIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmploymentsApi(config);
            var employeeId = 12345;  // long | The id of the employee.
            var employmentId = 98765;  // long | The id of the employment.
            var operation = new List<Operation>(); // List<Operation> | JSON Patch structure for updating an employment. See EmploymentPatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 (optional) 

            try
            {
                // Change an existing employment with a given id. (Auth roles: Employment_Full)
                EmploymentDto result = apiInstance.EmployeesEmployeeIdEmploymentsEmploymentIdPatch(employeeId, employmentId, operation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentsApi.EmployeesEmployeeIdEmploymentsEmploymentIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmployeesEmployeeIdEmploymentsEmploymentIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change an existing employment with a given id. (Auth roles: Employment_Full)
    ApiResponse<EmploymentDto> response = apiInstance.EmployeesEmployeeIdEmploymentsEmploymentIdPatchWithHttpInfo(employeeId, employmentId, operation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmploymentsApi.EmployeesEmployeeIdEmploymentsEmploymentIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employeeId** | **long** | The id of the employee. |  |
| **employmentId** | **long** | The id of the employment. |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) | JSON Patch structure for updating an employment. See EmploymentPatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 | [optional]  |

### Return type

[**EmploymentDto**](EmploymentDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Given when resource was successfully updated |  -  |
| **400** | Given when request is badly formatted |  -  |
| **404** | Given when resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="employeesemployeeidemploymentsget"></a>
# **EmployeesEmployeeIdEmploymentsGet**
> List&lt;EmploymentDto&gt; EmployeesEmployeeIdEmploymentsGet (long employeeId, ResourceParameters resourceParameter = null)

Get employments (employment relationships) on the employee. (Auth roles: Employment,Employment_Full)

Will only contain line count for salary-, fixed salary-, leave-, layout- and percentage of full time employment lines.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class EmployeesEmployeeIdEmploymentsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmploymentsApi(config);
            var employeeId = 12345;  // long | The id of the employee.
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Get employments (employment relationships) on the employee. (Auth roles: Employment,Employment_Full)
                List<EmploymentDto> result = apiInstance.EmployeesEmployeeIdEmploymentsGet(employeeId, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentsApi.EmployeesEmployeeIdEmploymentsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmployeesEmployeeIdEmploymentsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get employments (employment relationships) on the employee. (Auth roles: Employment,Employment_Full)
    ApiResponse<List<EmploymentDto>> response = apiInstance.EmployeesEmployeeIdEmploymentsGetWithHttpInfo(employeeId, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmploymentsApi.EmployeesEmployeeIdEmploymentsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employeeId** | **long** | The id of the employee. |  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;EmploymentDto&gt;**](EmploymentDto.md)

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

<a id="employeesemployeeidemploymentspost"></a>
# **EmployeesEmployeeIdEmploymentsPost**
> EmploymentDto EmployeesEmployeeIdEmploymentsPost (long employeeId, EmploymentPostDto employmentPostDto = null)

Create a new employment. (Auth roles: Employment_Full)

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
    public class EmployeesEmployeeIdEmploymentsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmploymentsApi(config);
            var employeeId = 12345;  // long | The id of the employee.
            var employmentPostDto = new EmploymentPostDto(); // EmploymentPostDto |  (optional) 

            try
            {
                // Create a new employment. (Auth roles: Employment_Full)
                EmploymentDto result = apiInstance.EmployeesEmployeeIdEmploymentsPost(employeeId, employmentPostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentsApi.EmployeesEmployeeIdEmploymentsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmployeesEmployeeIdEmploymentsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new employment. (Auth roles: Employment_Full)
    ApiResponse<EmploymentDto> response = apiInstance.EmployeesEmployeeIdEmploymentsPostWithHttpInfo(employeeId, employmentPostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmploymentsApi.EmployeesEmployeeIdEmploymentsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employeeId** | **long** | The id of the employee. |  |
| **employmentPostDto** | [**EmploymentPostDto**](EmploymentPostDto.md) |  | [optional]  |

### Return type

[**EmploymentDto**](EmploymentDto.md)

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

<a id="employeesemploymentsget"></a>
# **EmployeesEmploymentsGet**
> List&lt;EmploymentLightDto&gt; EmployeesEmploymentsGet (bool activeEmployments = null, string employmentForm = null, DateTime lastChangedDateTimeOffsetGreaterThan = null, ResourceParameters resourceParameter = null)

Get all employments for all employees registered on the client. (Auth roles: Employment,Employment_Full)

Returns a lightweight (slimmed down) version of the employment entity.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class EmployeesEmploymentsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmploymentsApi(config);
            var activeEmployments = true;  // bool | Filter employments based on active status.  An employment is considered active if no endDate is set, or if the endDate set is at a future date.  The filter do not consider the EndedAndReported property, as a future endDate and reason might be reported on an employment still active until the end date.  True to only get employments with active status, false to only get employments with inactive status. If empty the filter is not used. (optional) 
            var employmentForm = Temporary;  // string | Filter by employment form. If null or whitespace, the filter is not used. (optional) 
            var lastChangedDateTimeOffsetGreaterThan = 2021-09-25 08:03:00.1234567 -00:00;  // DateTime | Filter by the last changed timestamp property.  This filtering will return all employments with a last changed timestamp greater than the timestamp provided.  Can be used when polling for new entries or when changes has occured.  Note that the last changed property is unaffected by changes in sub entities of an employment (salary, leave, fixed salary lines and other \"lists\")  Date not inclusive. (optional) 
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Get all employments for all employees registered on the client. (Auth roles: Employment,Employment_Full)
                List<EmploymentLightDto> result = apiInstance.EmployeesEmploymentsGet(activeEmployments, employmentForm, lastChangedDateTimeOffsetGreaterThan, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentsApi.EmployeesEmploymentsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmployeesEmploymentsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all employments for all employees registered on the client. (Auth roles: Employment,Employment_Full)
    ApiResponse<List<EmploymentLightDto>> response = apiInstance.EmployeesEmploymentsGetWithHttpInfo(activeEmployments, employmentForm, lastChangedDateTimeOffsetGreaterThan, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmploymentsApi.EmployeesEmploymentsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **activeEmployments** | **bool** | Filter employments based on active status.  An employment is considered active if no endDate is set, or if the endDate set is at a future date.  The filter do not consider the EndedAndReported property, as a future endDate and reason might be reported on an employment still active until the end date.  True to only get employments with active status, false to only get employments with inactive status. If empty the filter is not used. | [optional]  |
| **employmentForm** | **string** | Filter by employment form. If null or whitespace, the filter is not used. | [optional]  |
| **lastChangedDateTimeOffsetGreaterThan** | **DateTime** | Filter by the last changed timestamp property.  This filtering will return all employments with a last changed timestamp greater than the timestamp provided.  Can be used when polling for new entries or when changes has occured.  Note that the last changed property is unaffected by changes in sub entities of an employment (salary, leave, fixed salary lines and other \&quot;lists\&quot;)  Date not inclusive. | [optional]  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;EmploymentLightDto&gt;**](EmploymentLightDto.md)

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

<a id="getemploymentbyid"></a>
# **GetEmploymentById**
> EmploymentDto GetEmploymentById (long employeeId, long employmentId)

Gets a specific employment on a given employee. (Auth roles: Employment,Employment_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetEmploymentByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmploymentsApi(config);
            var employeeId = 12345;  // long | The id of the employee.
            var employmentId = 98765;  // long | The id of the employment.

            try
            {
                // Gets a specific employment on a given employee. (Auth roles: Employment,Employment_Full)
                EmploymentDto result = apiInstance.GetEmploymentById(employeeId, employmentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentsApi.GetEmploymentById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEmploymentByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a specific employment on a given employee. (Auth roles: Employment,Employment_Full)
    ApiResponse<EmploymentDto> response = apiInstance.GetEmploymentByIdWithHttpInfo(employeeId, employmentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmploymentsApi.GetEmploymentByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employeeId** | **long** | The id of the employee. |  |
| **employmentId** | **long** | The id of the employment. |  |

### Return type

[**EmploymentDto**](EmploymentDto.md)

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


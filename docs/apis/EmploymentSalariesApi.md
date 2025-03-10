# PowerOfficeGoV2.Api.EmploymentSalariesApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EmployeesEmploymentsEmploymentIdSalariesGet**](EmploymentSalariesApi.md#employeesemploymentsemploymentidsalariesget) | **GET** /Employees/Employments/{employmentId}/Salaries | Get salary lines for the given employment (employment relationships) on an employee. (Auth roles: EmploymentSalary,EmploymentSalary_Full) |
| [**EmployeesEmploymentsEmploymentIdSalariesPost**](EmploymentSalariesApi.md#employeesemploymentsemploymentidsalariespost) | **POST** /Employees/Employments/{employmentId}/Salaries | Create a new salary (line) on a given employment. (Auth roles: EmploymentSalary_Full) |
| [**EmployeesEmploymentsEmploymentIdSalariesSalaryIdDelete**](EmploymentSalariesApi.md#employeesemploymentsemploymentidsalariessalaryiddelete) | **DELETE** /Employees/Employments/{employmentId}/Salaries/{salaryId} | Delete a specific salary (line) on a given employment. (Auth roles: EmploymentSalary_Full) |
| [**EmployeesEmploymentsEmploymentIdSalariesSalaryIdPatch**](EmploymentSalariesApi.md#employeesemploymentsemploymentidsalariessalaryidpatch) | **PATCH** /Employees/Employments/{employmentId}/Salaries/{salaryId} | Change an existing salary (line) on a given employment. (Auth roles: EmploymentSalary_Full) |
| [**GetSalaryById**](EmploymentSalariesApi.md#getsalarybyid) | **GET** /Employees/Employments/{employmentId}/Salaries/{salaryId} | Gets a specific salary (line) on a given employment. (Auth roles: EmploymentSalary,EmploymentSalary_Full) |

<a id="employeesemploymentsemploymentidsalariesget"></a>
# **EmployeesEmploymentsEmploymentIdSalariesGet**
> List&lt;EmploymentSalaryDto&gt; EmployeesEmploymentsEmploymentIdSalariesGet (long employmentId, ResourceParameters resourceParameter = null)

Get salary lines for the given employment (employment relationships) on an employee. (Auth roles: EmploymentSalary,EmploymentSalary_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class EmployeesEmploymentsEmploymentIdSalariesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmploymentSalariesApi(config);
            var employmentId = 12345;  // long | The id of the employment.
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Get salary lines for the given employment (employment relationships) on an employee. (Auth roles: EmploymentSalary,EmploymentSalary_Full)
                List<EmploymentSalaryDto> result = apiInstance.EmployeesEmploymentsEmploymentIdSalariesGet(employmentId, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentSalariesApi.EmployeesEmploymentsEmploymentIdSalariesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmployeesEmploymentsEmploymentIdSalariesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get salary lines for the given employment (employment relationships) on an employee. (Auth roles: EmploymentSalary,EmploymentSalary_Full)
    ApiResponse<List<EmploymentSalaryDto>> response = apiInstance.EmployeesEmploymentsEmploymentIdSalariesGetWithHttpInfo(employmentId, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmploymentSalariesApi.EmployeesEmploymentsEmploymentIdSalariesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employmentId** | **long** | The id of the employment. |  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;EmploymentSalaryDto&gt;**](EmploymentSalaryDto.md)

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

<a id="employeesemploymentsemploymentidsalariespost"></a>
# **EmployeesEmploymentsEmploymentIdSalariesPost**
> EmploymentSalaryDto EmployeesEmploymentsEmploymentIdSalariesPost (long employmentId, EmploymentSalaryPostDto employmentSalaryPostDto = null)

Create a new salary (line) on a given employment. (Auth roles: EmploymentSalary_Full)

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
    public class EmployeesEmploymentsEmploymentIdSalariesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmploymentSalariesApi(config);
            var employmentId = 98765;  // long | The id of the employment.
            var employmentSalaryPostDto = new EmploymentSalaryPostDto(); // EmploymentSalaryPostDto |  (optional) 

            try
            {
                // Create a new salary (line) on a given employment. (Auth roles: EmploymentSalary_Full)
                EmploymentSalaryDto result = apiInstance.EmployeesEmploymentsEmploymentIdSalariesPost(employmentId, employmentSalaryPostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentSalariesApi.EmployeesEmploymentsEmploymentIdSalariesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmployeesEmploymentsEmploymentIdSalariesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new salary (line) on a given employment. (Auth roles: EmploymentSalary_Full)
    ApiResponse<EmploymentSalaryDto> response = apiInstance.EmployeesEmploymentsEmploymentIdSalariesPostWithHttpInfo(employmentId, employmentSalaryPostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmploymentSalariesApi.EmployeesEmploymentsEmploymentIdSalariesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employmentId** | **long** | The id of the employment. |  |
| **employmentSalaryPostDto** | [**EmploymentSalaryPostDto**](EmploymentSalaryPostDto.md) |  | [optional]  |

### Return type

[**EmploymentSalaryDto**](EmploymentSalaryDto.md)

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

<a id="employeesemploymentsemploymentidsalariessalaryiddelete"></a>
# **EmployeesEmploymentsEmploymentIdSalariesSalaryIdDelete**
> void EmployeesEmploymentsEmploymentIdSalariesSalaryIdDelete (long employmentId, long salaryId)

Delete a specific salary (line) on a given employment. (Auth roles: EmploymentSalary_Full)

Note that there must be at least one salary line on an employment, so if the last salary line is attempted to be deleted you will get a 409 Conflict response.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class EmployeesEmploymentsEmploymentIdSalariesSalaryIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmploymentSalariesApi(config);
            var employmentId = 98765;  // long | The id of the employment.
            var salaryId = 12345;  // long | The id of the salary (line).

            try
            {
                // Delete a specific salary (line) on a given employment. (Auth roles: EmploymentSalary_Full)
                apiInstance.EmployeesEmploymentsEmploymentIdSalariesSalaryIdDelete(employmentId, salaryId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentSalariesApi.EmployeesEmploymentsEmploymentIdSalariesSalaryIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmployeesEmploymentsEmploymentIdSalariesSalaryIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a specific salary (line) on a given employment. (Auth roles: EmploymentSalary_Full)
    apiInstance.EmployeesEmploymentsEmploymentIdSalariesSalaryIdDeleteWithHttpInfo(employmentId, salaryId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmploymentSalariesApi.EmployeesEmploymentsEmploymentIdSalariesSalaryIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employmentId** | **long** | The id of the employment. |  |
| **salaryId** | **long** | The id of the salary (line). |  |

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

<a id="employeesemploymentsemploymentidsalariessalaryidpatch"></a>
# **EmployeesEmploymentsEmploymentIdSalariesSalaryIdPatch**
> EmploymentSalaryDto EmployeesEmploymentsEmploymentIdSalariesSalaryIdPatch (long employmentId, long salaryId, List<Operation> operation = null)

Change an existing salary (line) on a given employment. (Auth roles: EmploymentSalary_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class EmployeesEmploymentsEmploymentIdSalariesSalaryIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmploymentSalariesApi(config);
            var employmentId = 98765;  // long | The id of the employment.
            var salaryId = 12345;  // long | The id of the salary (line).
            var operation = new List<Operation>(); // List<Operation> | JSON Patch structure for updating a salary (line). See EmploymentSalaryPatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 (optional) 

            try
            {
                // Change an existing salary (line) on a given employment. (Auth roles: EmploymentSalary_Full)
                EmploymentSalaryDto result = apiInstance.EmployeesEmploymentsEmploymentIdSalariesSalaryIdPatch(employmentId, salaryId, operation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentSalariesApi.EmployeesEmploymentsEmploymentIdSalariesSalaryIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmployeesEmploymentsEmploymentIdSalariesSalaryIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change an existing salary (line) on a given employment. (Auth roles: EmploymentSalary_Full)
    ApiResponse<EmploymentSalaryDto> response = apiInstance.EmployeesEmploymentsEmploymentIdSalariesSalaryIdPatchWithHttpInfo(employmentId, salaryId, operation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmploymentSalariesApi.EmployeesEmploymentsEmploymentIdSalariesSalaryIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employmentId** | **long** | The id of the employment. |  |
| **salaryId** | **long** | The id of the salary (line). |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) | JSON Patch structure for updating a salary (line). See EmploymentSalaryPatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 | [optional]  |

### Return type

[**EmploymentSalaryDto**](EmploymentSalaryDto.md)

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

<a id="getsalarybyid"></a>
# **GetSalaryById**
> EmploymentSalaryDto GetSalaryById (long employmentId, long salaryId)

Gets a specific salary (line) on a given employment. (Auth roles: EmploymentSalary,EmploymentSalary_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetSalaryByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmploymentSalariesApi(config);
            var employmentId = 98765;  // long | The id of the employment.
            var salaryId = 12345;  // long | The id of the salary (line).

            try
            {
                // Gets a specific salary (line) on a given employment. (Auth roles: EmploymentSalary,EmploymentSalary_Full)
                EmploymentSalaryDto result = apiInstance.GetSalaryById(employmentId, salaryId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentSalariesApi.GetSalaryById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSalaryByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a specific salary (line) on a given employment. (Auth roles: EmploymentSalary,EmploymentSalary_Full)
    ApiResponse<EmploymentSalaryDto> response = apiInstance.GetSalaryByIdWithHttpInfo(employmentId, salaryId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmploymentSalariesApi.GetSalaryByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employmentId** | **long** | The id of the employment. |  |
| **salaryId** | **long** | The id of the salary (line). |  |

### Return type

[**EmploymentSalaryDto**](EmploymentSalaryDto.md)

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


# PowerOfficeGoV2.Api.EmploymentFixedSalariesApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EmployeesEmploymentsEmploymentIdFixedSalariesFixedSalaryIdDelete**](EmploymentFixedSalariesApi.md#employeesemploymentsemploymentidfixedsalariesfixedsalaryiddelete) | **DELETE** /Employees/Employments/{employmentId}/FixedSalaries/{fixedSalaryId} | Delete a specific fixed salary (line) on a given employment. (Auth roles: EmploymentFixedSalary_Full) |
| [**EmployeesEmploymentsEmploymentIdFixedSalariesFixedSalaryIdPatch**](EmploymentFixedSalariesApi.md#employeesemploymentsemploymentidfixedsalariesfixedsalaryidpatch) | **PATCH** /Employees/Employments/{employmentId}/FixedSalaries/{fixedSalaryId} | Change an existing fixed salary (line) on a given employment. (Auth roles: EmploymentFixedSalary_Full) |
| [**EmployeesEmploymentsEmploymentIdFixedSalariesGet**](EmploymentFixedSalariesApi.md#employeesemploymentsemploymentidfixedsalariesget) | **GET** /Employees/Employments/{employmentId}/FixedSalaries | Get fixed salary lines for the given employment (employment relationships) on an employee. (Auth roles: EmploymentFixedSalary,EmploymentFixedSalary_Full) |
| [**EmployeesEmploymentsEmploymentIdFixedSalariesPost**](EmploymentFixedSalariesApi.md#employeesemploymentsemploymentidfixedsalariespost) | **POST** /Employees/Employments/{employmentId}/FixedSalaries | Create a new fixed salary (line) on a given employment. (Auth roles: EmploymentFixedSalary_Full) |
| [**GetFixedSalaryById**](EmploymentFixedSalariesApi.md#getfixedsalarybyid) | **GET** /Employees/Employments/{employmentId}/FixedSalaries/{fixedSalaryId} | Gets a specific fixed salary (line) on a given employment. (Auth roles: EmploymentFixedSalary,EmploymentFixedSalary_Full) |

<a id="employeesemploymentsemploymentidfixedsalariesfixedsalaryiddelete"></a>
# **EmployeesEmploymentsEmploymentIdFixedSalariesFixedSalaryIdDelete**
> void EmployeesEmploymentsEmploymentIdFixedSalariesFixedSalaryIdDelete (long employmentId, Guid fixedSalaryId)

Delete a specific fixed salary (line) on a given employment. (Auth roles: EmploymentFixedSalary_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class EmployeesEmploymentsEmploymentIdFixedSalariesFixedSalaryIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmploymentFixedSalariesApi(config);
            var employmentId = 98765;  // long | The id of the employment.
            var fixedSalaryId = f575b4b0-55be-4b56-b01f-44b204df82c5;  // Guid | The id of the fixed salary (line).

            try
            {
                // Delete a specific fixed salary (line) on a given employment. (Auth roles: EmploymentFixedSalary_Full)
                apiInstance.EmployeesEmploymentsEmploymentIdFixedSalariesFixedSalaryIdDelete(employmentId, fixedSalaryId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentFixedSalariesApi.EmployeesEmploymentsEmploymentIdFixedSalariesFixedSalaryIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmployeesEmploymentsEmploymentIdFixedSalariesFixedSalaryIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a specific fixed salary (line) on a given employment. (Auth roles: EmploymentFixedSalary_Full)
    apiInstance.EmployeesEmploymentsEmploymentIdFixedSalariesFixedSalaryIdDeleteWithHttpInfo(employmentId, fixedSalaryId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmploymentFixedSalariesApi.EmployeesEmploymentsEmploymentIdFixedSalariesFixedSalaryIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employmentId** | **long** | The id of the employment. |  |
| **fixedSalaryId** | **Guid** | The id of the fixed salary (line). |  |

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
| **200** | Given when fixed salary line is deleted |  -  |
| **404** | Given when resource was not found |  -  |
| **409** | Given when resource cannot be deleted |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="employeesemploymentsemploymentidfixedsalariesfixedsalaryidpatch"></a>
# **EmployeesEmploymentsEmploymentIdFixedSalariesFixedSalaryIdPatch**
> EmploymentFixedSalaryDto EmployeesEmploymentsEmploymentIdFixedSalariesFixedSalaryIdPatch (long employmentId, Guid fixedSalaryId, List<Operation> operation = null)

Change an existing fixed salary (line) on a given employment. (Auth roles: EmploymentFixedSalary_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class EmployeesEmploymentsEmploymentIdFixedSalariesFixedSalaryIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmploymentFixedSalariesApi(config);
            var employmentId = 98765;  // long | The id of the employment.
            var fixedSalaryId = f575b4b0-55be-4b56-b01f-44b204df82c5;  // Guid | The id of the fixed salary (line).
            var operation = new List<Operation>(); // List<Operation> | JSON Patch structure for updating a fixed salary (line). See EmploymentFixedSalaryPatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 (optional) 

            try
            {
                // Change an existing fixed salary (line) on a given employment. (Auth roles: EmploymentFixedSalary_Full)
                EmploymentFixedSalaryDto result = apiInstance.EmployeesEmploymentsEmploymentIdFixedSalariesFixedSalaryIdPatch(employmentId, fixedSalaryId, operation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentFixedSalariesApi.EmployeesEmploymentsEmploymentIdFixedSalariesFixedSalaryIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmployeesEmploymentsEmploymentIdFixedSalariesFixedSalaryIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change an existing fixed salary (line) on a given employment. (Auth roles: EmploymentFixedSalary_Full)
    ApiResponse<EmploymentFixedSalaryDto> response = apiInstance.EmployeesEmploymentsEmploymentIdFixedSalariesFixedSalaryIdPatchWithHttpInfo(employmentId, fixedSalaryId, operation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmploymentFixedSalariesApi.EmployeesEmploymentsEmploymentIdFixedSalariesFixedSalaryIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employmentId** | **long** | The id of the employment. |  |
| **fixedSalaryId** | **Guid** | The id of the fixed salary (line). |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) | JSON Patch structure for updating a fixed salary (line). See EmploymentFixedSalaryPatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 | [optional]  |

### Return type

[**EmploymentFixedSalaryDto**](EmploymentFixedSalaryDto.md)

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

<a id="employeesemploymentsemploymentidfixedsalariesget"></a>
# **EmployeesEmploymentsEmploymentIdFixedSalariesGet**
> List&lt;EmploymentFixedSalaryDto&gt; EmployeesEmploymentsEmploymentIdFixedSalariesGet (long employmentId, ResourceParameters resourceParameter = null)

Get fixed salary lines for the given employment (employment relationships) on an employee. (Auth roles: EmploymentFixedSalary,EmploymentFixedSalary_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class EmployeesEmploymentsEmploymentIdFixedSalariesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmploymentFixedSalariesApi(config);
            var employmentId = 12345;  // long | The id of the employment.
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Get fixed salary lines for the given employment (employment relationships) on an employee. (Auth roles: EmploymentFixedSalary,EmploymentFixedSalary_Full)
                List<EmploymentFixedSalaryDto> result = apiInstance.EmployeesEmploymentsEmploymentIdFixedSalariesGet(employmentId, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentFixedSalariesApi.EmployeesEmploymentsEmploymentIdFixedSalariesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmployeesEmploymentsEmploymentIdFixedSalariesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get fixed salary lines for the given employment (employment relationships) on an employee. (Auth roles: EmploymentFixedSalary,EmploymentFixedSalary_Full)
    ApiResponse<List<EmploymentFixedSalaryDto>> response = apiInstance.EmployeesEmploymentsEmploymentIdFixedSalariesGetWithHttpInfo(employmentId, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmploymentFixedSalariesApi.EmployeesEmploymentsEmploymentIdFixedSalariesGetWithHttpInfo: " + e.Message);
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

[**List&lt;EmploymentFixedSalaryDto&gt;**](EmploymentFixedSalaryDto.md)

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

<a id="employeesemploymentsemploymentidfixedsalariespost"></a>
# **EmployeesEmploymentsEmploymentIdFixedSalariesPost**
> EmploymentFixedSalaryDto EmployeesEmploymentsEmploymentIdFixedSalariesPost (long employmentId, EmploymentFixedSalaryPostDto employmentFixedSalaryPostDto = null)

Create a new fixed salary (line) on a given employment. (Auth roles: EmploymentFixedSalary_Full)

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
    public class EmployeesEmploymentsEmploymentIdFixedSalariesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmploymentFixedSalariesApi(config);
            var employmentId = 98765;  // long | The id of the employment.
            var employmentFixedSalaryPostDto = new EmploymentFixedSalaryPostDto(); // EmploymentFixedSalaryPostDto |  (optional) 

            try
            {
                // Create a new fixed salary (line) on a given employment. (Auth roles: EmploymentFixedSalary_Full)
                EmploymentFixedSalaryDto result = apiInstance.EmployeesEmploymentsEmploymentIdFixedSalariesPost(employmentId, employmentFixedSalaryPostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentFixedSalariesApi.EmployeesEmploymentsEmploymentIdFixedSalariesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmployeesEmploymentsEmploymentIdFixedSalariesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new fixed salary (line) on a given employment. (Auth roles: EmploymentFixedSalary_Full)
    ApiResponse<EmploymentFixedSalaryDto> response = apiInstance.EmployeesEmploymentsEmploymentIdFixedSalariesPostWithHttpInfo(employmentId, employmentFixedSalaryPostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmploymentFixedSalariesApi.EmployeesEmploymentsEmploymentIdFixedSalariesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employmentId** | **long** | The id of the employment. |  |
| **employmentFixedSalaryPostDto** | [**EmploymentFixedSalaryPostDto**](EmploymentFixedSalaryPostDto.md) |  | [optional]  |

### Return type

[**EmploymentFixedSalaryDto**](EmploymentFixedSalaryDto.md)

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

<a id="getfixedsalarybyid"></a>
# **GetFixedSalaryById**
> EmploymentFixedSalaryDto GetFixedSalaryById (long employmentId, Guid fixedSalaryId)

Gets a specific fixed salary (line) on a given employment. (Auth roles: EmploymentFixedSalary,EmploymentFixedSalary_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetFixedSalaryByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmploymentFixedSalariesApi(config);
            var employmentId = 98765;  // long | The id of the employment.
            var fixedSalaryId = f575b4b0-55be-4b56-b01f-44b204df82c5;  // Guid | The id of the fixed salary (line).

            try
            {
                // Gets a specific fixed salary (line) on a given employment. (Auth roles: EmploymentFixedSalary,EmploymentFixedSalary_Full)
                EmploymentFixedSalaryDto result = apiInstance.GetFixedSalaryById(employmentId, fixedSalaryId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentFixedSalariesApi.GetFixedSalaryById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFixedSalaryByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a specific fixed salary (line) on a given employment. (Auth roles: EmploymentFixedSalary,EmploymentFixedSalary_Full)
    ApiResponse<EmploymentFixedSalaryDto> response = apiInstance.GetFixedSalaryByIdWithHttpInfo(employmentId, fixedSalaryId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmploymentFixedSalariesApi.GetFixedSalaryByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employmentId** | **long** | The id of the employment. |  |
| **fixedSalaryId** | **Guid** | The id of the fixed salary (line). |  |

### Return type

[**EmploymentFixedSalaryDto**](EmploymentFixedSalaryDto.md)

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


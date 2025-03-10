# PowerOfficeGoV2.Api.EmploymentLeavesApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EmployeesEmploymentsEmploymentIdLeavesGet**](EmploymentLeavesApi.md#employeesemploymentsemploymentidleavesget) | **GET** /Employees/Employments/{employmentId}/Leaves | Get leave lines for the given employment (employment relationships) on an employee. (Auth roles: EmploymentLeave,EmploymentLeave_Full) |
| [**EmployeesEmploymentsEmploymentIdLeavesLeaveIdDelete**](EmploymentLeavesApi.md#employeesemploymentsemploymentidleavesleaveiddelete) | **DELETE** /Employees/Employments/{employmentId}/Leaves/{leaveId} | Delete a specific leave (line) on a given employment. (Auth roles: EmploymentLeave_Full) |
| [**EmployeesEmploymentsEmploymentIdLeavesLeaveIdPatch**](EmploymentLeavesApi.md#employeesemploymentsemploymentidleavesleaveidpatch) | **PATCH** /Employees/Employments/{employmentId}/Leaves/{leaveId} | Change an existing leave (line) on a given employment. (Auth roles: EmploymentLeave_Full) |
| [**EmployeesEmploymentsEmploymentIdLeavesPost**](EmploymentLeavesApi.md#employeesemploymentsemploymentidleavespost) | **POST** /Employees/Employments/{employmentId}/Leaves | Create a new leave (line) on a given employment. (Auth roles: EmploymentLeave_Full) |
| [**GetLeaveById**](EmploymentLeavesApi.md#getleavebyid) | **GET** /Employees/Employments/{employmentId}/Leaves/{leaveId} | Gets a specific leave (line) on a given employment. (Auth roles: EmploymentLeave,EmploymentLeave_Full) |

<a id="employeesemploymentsemploymentidleavesget"></a>
# **EmployeesEmploymentsEmploymentIdLeavesGet**
> List&lt;EmploymentLeaveDto&gt; EmployeesEmploymentsEmploymentIdLeavesGet (long employmentId, ResourceParameters resourceParameter = null)

Get leave lines for the given employment (employment relationships) on an employee. (Auth roles: EmploymentLeave,EmploymentLeave_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class EmployeesEmploymentsEmploymentIdLeavesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmploymentLeavesApi(config);
            var employmentId = 12345;  // long | The id of the employment.
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Get leave lines for the given employment (employment relationships) on an employee. (Auth roles: EmploymentLeave,EmploymentLeave_Full)
                List<EmploymentLeaveDto> result = apiInstance.EmployeesEmploymentsEmploymentIdLeavesGet(employmentId, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentLeavesApi.EmployeesEmploymentsEmploymentIdLeavesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmployeesEmploymentsEmploymentIdLeavesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get leave lines for the given employment (employment relationships) on an employee. (Auth roles: EmploymentLeave,EmploymentLeave_Full)
    ApiResponse<List<EmploymentLeaveDto>> response = apiInstance.EmployeesEmploymentsEmploymentIdLeavesGetWithHttpInfo(employmentId, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmploymentLeavesApi.EmployeesEmploymentsEmploymentIdLeavesGetWithHttpInfo: " + e.Message);
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

[**List&lt;EmploymentLeaveDto&gt;**](EmploymentLeaveDto.md)

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

<a id="employeesemploymentsemploymentidleavesleaveiddelete"></a>
# **EmployeesEmploymentsEmploymentIdLeavesLeaveIdDelete**
> void EmployeesEmploymentsEmploymentIdLeavesLeaveIdDelete (long employmentId, Guid leaveId)

Delete a specific leave (line) on a given employment. (Auth roles: EmploymentLeave_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class EmployeesEmploymentsEmploymentIdLeavesLeaveIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmploymentLeavesApi(config);
            var employmentId = 98765;  // long | The id of the employment.
            var leaveId = f575b4b0-55be-4b56-b01f-44b204df82c5;  // Guid | The id of the leave (line).

            try
            {
                // Delete a specific leave (line) on a given employment. (Auth roles: EmploymentLeave_Full)
                apiInstance.EmployeesEmploymentsEmploymentIdLeavesLeaveIdDelete(employmentId, leaveId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentLeavesApi.EmployeesEmploymentsEmploymentIdLeavesLeaveIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmployeesEmploymentsEmploymentIdLeavesLeaveIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a specific leave (line) on a given employment. (Auth roles: EmploymentLeave_Full)
    apiInstance.EmployeesEmploymentsEmploymentIdLeavesLeaveIdDeleteWithHttpInfo(employmentId, leaveId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmploymentLeavesApi.EmployeesEmploymentsEmploymentIdLeavesLeaveIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employmentId** | **long** | The id of the employment. |  |
| **leaveId** | **Guid** | The id of the leave (line). |  |

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
| **200** | Given when leave line is deleted |  -  |
| **404** | Given when resource was not found |  -  |
| **409** | Given when resource cannot be deleted |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="employeesemploymentsemploymentidleavesleaveidpatch"></a>
# **EmployeesEmploymentsEmploymentIdLeavesLeaveIdPatch**
> EmploymentLeaveDto EmployeesEmploymentsEmploymentIdLeavesLeaveIdPatch (long employmentId, Guid leaveId, List<Operation> operation = null)

Change an existing leave (line) on a given employment. (Auth roles: EmploymentLeave_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class EmployeesEmploymentsEmploymentIdLeavesLeaveIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmploymentLeavesApi(config);
            var employmentId = 98765;  // long | The id of the employment.
            var leaveId = f575b4b0-55be-4b56-b01f-44b204df82c5;  // Guid | The id of the leave (line).
            var operation = new List<Operation>(); // List<Operation> | JSON Patch structure for updating a leave (line). See EmploymentLeavePatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 (optional) 

            try
            {
                // Change an existing leave (line) on a given employment. (Auth roles: EmploymentLeave_Full)
                EmploymentLeaveDto result = apiInstance.EmployeesEmploymentsEmploymentIdLeavesLeaveIdPatch(employmentId, leaveId, operation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentLeavesApi.EmployeesEmploymentsEmploymentIdLeavesLeaveIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmployeesEmploymentsEmploymentIdLeavesLeaveIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change an existing leave (line) on a given employment. (Auth roles: EmploymentLeave_Full)
    ApiResponse<EmploymentLeaveDto> response = apiInstance.EmployeesEmploymentsEmploymentIdLeavesLeaveIdPatchWithHttpInfo(employmentId, leaveId, operation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmploymentLeavesApi.EmployeesEmploymentsEmploymentIdLeavesLeaveIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employmentId** | **long** | The id of the employment. |  |
| **leaveId** | **Guid** | The id of the leave (line). |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) | JSON Patch structure for updating a leave (line). See EmploymentLeavePatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 | [optional]  |

### Return type

[**EmploymentLeaveDto**](EmploymentLeaveDto.md)

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

<a id="employeesemploymentsemploymentidleavespost"></a>
# **EmployeesEmploymentsEmploymentIdLeavesPost**
> EmploymentLeaveDto EmployeesEmploymentsEmploymentIdLeavesPost (long employmentId, EmploymentLeavePostDto employmentLeavePostDto = null)

Create a new leave (line) on a given employment. (Auth roles: EmploymentLeave_Full)

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
    public class EmployeesEmploymentsEmploymentIdLeavesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmploymentLeavesApi(config);
            var employmentId = 98765;  // long | The id of the employment.
            var employmentLeavePostDto = new EmploymentLeavePostDto(); // EmploymentLeavePostDto |  (optional) 

            try
            {
                // Create a new leave (line) on a given employment. (Auth roles: EmploymentLeave_Full)
                EmploymentLeaveDto result = apiInstance.EmployeesEmploymentsEmploymentIdLeavesPost(employmentId, employmentLeavePostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentLeavesApi.EmployeesEmploymentsEmploymentIdLeavesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmployeesEmploymentsEmploymentIdLeavesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new leave (line) on a given employment. (Auth roles: EmploymentLeave_Full)
    ApiResponse<EmploymentLeaveDto> response = apiInstance.EmployeesEmploymentsEmploymentIdLeavesPostWithHttpInfo(employmentId, employmentLeavePostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmploymentLeavesApi.EmployeesEmploymentsEmploymentIdLeavesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employmentId** | **long** | The id of the employment. |  |
| **employmentLeavePostDto** | [**EmploymentLeavePostDto**](EmploymentLeavePostDto.md) |  | [optional]  |

### Return type

[**EmploymentLeaveDto**](EmploymentLeaveDto.md)

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

<a id="getleavebyid"></a>
# **GetLeaveById**
> EmploymentLeaveDto GetLeaveById (long employmentId, Guid leaveId)

Gets a specific leave (line) on a given employment. (Auth roles: EmploymentLeave,EmploymentLeave_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetLeaveByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmploymentLeavesApi(config);
            var employmentId = 98765;  // long | The id of the employment.
            var leaveId = f575b4b0-55be-4b56-b01f-44b204df82c5;  // Guid | The id of the leave (line).

            try
            {
                // Gets a specific leave (line) on a given employment. (Auth roles: EmploymentLeave,EmploymentLeave_Full)
                EmploymentLeaveDto result = apiInstance.GetLeaveById(employmentId, leaveId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentLeavesApi.GetLeaveById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLeaveByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a specific leave (line) on a given employment. (Auth roles: EmploymentLeave,EmploymentLeave_Full)
    ApiResponse<EmploymentLeaveDto> response = apiInstance.GetLeaveByIdWithHttpInfo(employmentId, leaveId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmploymentLeavesApi.GetLeaveByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employmentId** | **long** | The id of the employment. |  |
| **leaveId** | **Guid** | The id of the leave (line). |  |

### Return type

[**EmploymentLeaveDto**](EmploymentLeaveDto.md)

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


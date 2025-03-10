# PowerOfficeGoV2.Api.EmploymentFtePercentagesApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EmployeesEmploymentsEmploymentIdFtePercentagesFtePercentageIdDelete**](EmploymentFtePercentagesApi.md#employeesemploymentsemploymentidftepercentagesftepercentageiddelete) | **DELETE** /Employees/Employments/{employmentId}/FtePercentages/{ftePercentageId} | Delete a specific full-time equivalent (FTE) percentage (line) on a given employment. (Auth roles: EmploymentFtePercentage_Full) |
| [**EmployeesEmploymentsEmploymentIdFtePercentagesFtePercentageIdPatch**](EmploymentFtePercentagesApi.md#employeesemploymentsemploymentidftepercentagesftepercentageidpatch) | **PATCH** /Employees/Employments/{employmentId}/FtePercentages/{ftePercentageId} | Change an existing full-time equivalent (FTE) percentage (line) on a given employment. (Auth roles: EmploymentFtePercentage_Full) |
| [**EmployeesEmploymentsEmploymentIdFtePercentagesGet**](EmploymentFtePercentagesApi.md#employeesemploymentsemploymentidftepercentagesget) | **GET** /Employees/Employments/{employmentId}/FtePercentages | Get full-time equivalent (FTE) percentage lines for the given employment (employment relationships) on an employee. (Auth roles: EmploymentFtePercentage,EmploymentFtePercentage_Full) |
| [**EmployeesEmploymentsEmploymentIdFtePercentagesPost**](EmploymentFtePercentagesApi.md#employeesemploymentsemploymentidftepercentagespost) | **POST** /Employees/Employments/{employmentId}/FtePercentages | Create a new full-time equivalent (FTE) percentage (line) on a given employment. (Auth roles: EmploymentFtePercentage_Full) |
| [**GetFtePercentageById**](EmploymentFtePercentagesApi.md#getftepercentagebyid) | **GET** /Employees/Employments/{employmentId}/FtePercentages/{ftePercentageId} | Gets a specific full-time equivalent (FTE) percentage (line) on a given employment. (Auth roles: EmploymentFtePercentage,EmploymentFtePercentage_Full) |

<a id="employeesemploymentsemploymentidftepercentagesftepercentageiddelete"></a>
# **EmployeesEmploymentsEmploymentIdFtePercentagesFtePercentageIdDelete**
> void EmployeesEmploymentsEmploymentIdFtePercentagesFtePercentageIdDelete (long employmentId, long ftePercentageId)

Delete a specific full-time equivalent (FTE) percentage (line) on a given employment. (Auth roles: EmploymentFtePercentage_Full)

Note that there must be at least one full-time equivalent (FTE) percentage line on an employment, so if the last FTE percentage line is attempted to be deleted you will get a 409 Conflict response.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class EmployeesEmploymentsEmploymentIdFtePercentagesFtePercentageIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmploymentFtePercentagesApi(config);
            var employmentId = 98765;  // long | The id of the employment.
            var ftePercentageId = 12345;  // long | The id of the full-time equivalent (FTE) percentage (line).

            try
            {
                // Delete a specific full-time equivalent (FTE) percentage (line) on a given employment. (Auth roles: EmploymentFtePercentage_Full)
                apiInstance.EmployeesEmploymentsEmploymentIdFtePercentagesFtePercentageIdDelete(employmentId, ftePercentageId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentFtePercentagesApi.EmployeesEmploymentsEmploymentIdFtePercentagesFtePercentageIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmployeesEmploymentsEmploymentIdFtePercentagesFtePercentageIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a specific full-time equivalent (FTE) percentage (line) on a given employment. (Auth roles: EmploymentFtePercentage_Full)
    apiInstance.EmployeesEmploymentsEmploymentIdFtePercentagesFtePercentageIdDeleteWithHttpInfo(employmentId, ftePercentageId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmploymentFtePercentagesApi.EmployeesEmploymentsEmploymentIdFtePercentagesFtePercentageIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employmentId** | **long** | The id of the employment. |  |
| **ftePercentageId** | **long** | The id of the full-time equivalent (FTE) percentage (line). |  |

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
| **200** | Given when FTE percentage line is deleted |  -  |
| **404** | Given when resource was not found |  -  |
| **409** | Given when resource is in use and cannot be deleted |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="employeesemploymentsemploymentidftepercentagesftepercentageidpatch"></a>
# **EmployeesEmploymentsEmploymentIdFtePercentagesFtePercentageIdPatch**
> EmploymentFtePercentageDto EmployeesEmploymentsEmploymentIdFtePercentagesFtePercentageIdPatch (long employmentId, long ftePercentageId, List<Operation> operation = null)

Change an existing full-time equivalent (FTE) percentage (line) on a given employment. (Auth roles: EmploymentFtePercentage_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class EmployeesEmploymentsEmploymentIdFtePercentagesFtePercentageIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmploymentFtePercentagesApi(config);
            var employmentId = 98765;  // long | The id of the employment.
            var ftePercentageId = 12345;  // long | The id of the full-time equivalent (FTE) percentage (line).
            var operation = new List<Operation>(); // List<Operation> | JSON Patch structure for updating a full-time equivalent (FTE) percentage (line). See EmploymentFtePercentagePatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 (optional) 

            try
            {
                // Change an existing full-time equivalent (FTE) percentage (line) on a given employment. (Auth roles: EmploymentFtePercentage_Full)
                EmploymentFtePercentageDto result = apiInstance.EmployeesEmploymentsEmploymentIdFtePercentagesFtePercentageIdPatch(employmentId, ftePercentageId, operation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentFtePercentagesApi.EmployeesEmploymentsEmploymentIdFtePercentagesFtePercentageIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmployeesEmploymentsEmploymentIdFtePercentagesFtePercentageIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change an existing full-time equivalent (FTE) percentage (line) on a given employment. (Auth roles: EmploymentFtePercentage_Full)
    ApiResponse<EmploymentFtePercentageDto> response = apiInstance.EmployeesEmploymentsEmploymentIdFtePercentagesFtePercentageIdPatchWithHttpInfo(employmentId, ftePercentageId, operation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmploymentFtePercentagesApi.EmployeesEmploymentsEmploymentIdFtePercentagesFtePercentageIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employmentId** | **long** | The id of the employment. |  |
| **ftePercentageId** | **long** | The id of the full-time equivalent (FTE) percentage (line). |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) | JSON Patch structure for updating a full-time equivalent (FTE) percentage (line). See EmploymentFtePercentagePatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 | [optional]  |

### Return type

[**EmploymentFtePercentageDto**](EmploymentFtePercentageDto.md)

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

<a id="employeesemploymentsemploymentidftepercentagesget"></a>
# **EmployeesEmploymentsEmploymentIdFtePercentagesGet**
> List&lt;EmploymentFtePercentageDto&gt; EmployeesEmploymentsEmploymentIdFtePercentagesGet (long employmentId, ResourceParameters resourceParameter = null)

Get full-time equivalent (FTE) percentage lines for the given employment (employment relationships) on an employee. (Auth roles: EmploymentFtePercentage,EmploymentFtePercentage_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class EmployeesEmploymentsEmploymentIdFtePercentagesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmploymentFtePercentagesApi(config);
            var employmentId = 12345;  // long | The id of the employment.
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Get full-time equivalent (FTE) percentage lines for the given employment (employment relationships) on an employee. (Auth roles: EmploymentFtePercentage,EmploymentFtePercentage_Full)
                List<EmploymentFtePercentageDto> result = apiInstance.EmployeesEmploymentsEmploymentIdFtePercentagesGet(employmentId, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentFtePercentagesApi.EmployeesEmploymentsEmploymentIdFtePercentagesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmployeesEmploymentsEmploymentIdFtePercentagesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get full-time equivalent (FTE) percentage lines for the given employment (employment relationships) on an employee. (Auth roles: EmploymentFtePercentage,EmploymentFtePercentage_Full)
    ApiResponse<List<EmploymentFtePercentageDto>> response = apiInstance.EmployeesEmploymentsEmploymentIdFtePercentagesGetWithHttpInfo(employmentId, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmploymentFtePercentagesApi.EmployeesEmploymentsEmploymentIdFtePercentagesGetWithHttpInfo: " + e.Message);
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

[**List&lt;EmploymentFtePercentageDto&gt;**](EmploymentFtePercentageDto.md)

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

<a id="employeesemploymentsemploymentidftepercentagespost"></a>
# **EmployeesEmploymentsEmploymentIdFtePercentagesPost**
> EmploymentFtePercentageDto EmployeesEmploymentsEmploymentIdFtePercentagesPost (long employmentId, EmploymentFtePercentagePostDto employmentFtePercentagePostDto = null)

Create a new full-time equivalent (FTE) percentage (line) on a given employment. (Auth roles: EmploymentFtePercentage_Full)

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
    public class EmployeesEmploymentsEmploymentIdFtePercentagesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmploymentFtePercentagesApi(config);
            var employmentId = 98765;  // long | The id of the employment.
            var employmentFtePercentagePostDto = new EmploymentFtePercentagePostDto(); // EmploymentFtePercentagePostDto |  (optional) 

            try
            {
                // Create a new full-time equivalent (FTE) percentage (line) on a given employment. (Auth roles: EmploymentFtePercentage_Full)
                EmploymentFtePercentageDto result = apiInstance.EmployeesEmploymentsEmploymentIdFtePercentagesPost(employmentId, employmentFtePercentagePostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentFtePercentagesApi.EmployeesEmploymentsEmploymentIdFtePercentagesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmployeesEmploymentsEmploymentIdFtePercentagesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new full-time equivalent (FTE) percentage (line) on a given employment. (Auth roles: EmploymentFtePercentage_Full)
    ApiResponse<EmploymentFtePercentageDto> response = apiInstance.EmployeesEmploymentsEmploymentIdFtePercentagesPostWithHttpInfo(employmentId, employmentFtePercentagePostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmploymentFtePercentagesApi.EmployeesEmploymentsEmploymentIdFtePercentagesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employmentId** | **long** | The id of the employment. |  |
| **employmentFtePercentagePostDto** | [**EmploymentFtePercentagePostDto**](EmploymentFtePercentagePostDto.md) |  | [optional]  |

### Return type

[**EmploymentFtePercentageDto**](EmploymentFtePercentageDto.md)

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

<a id="getftepercentagebyid"></a>
# **GetFtePercentageById**
> EmploymentFtePercentageDto GetFtePercentageById (long employmentId, long ftePercentageId)

Gets a specific full-time equivalent (FTE) percentage (line) on a given employment. (Auth roles: EmploymentFtePercentage,EmploymentFtePercentage_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetFtePercentageByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmploymentFtePercentagesApi(config);
            var employmentId = 98765;  // long | The id of the employment.
            var ftePercentageId = 12345;  // long | The id of the full-time equivalent (FTE) percentage (line).

            try
            {
                // Gets a specific full-time equivalent (FTE) percentage (line) on a given employment. (Auth roles: EmploymentFtePercentage,EmploymentFtePercentage_Full)
                EmploymentFtePercentageDto result = apiInstance.GetFtePercentageById(employmentId, ftePercentageId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentFtePercentagesApi.GetFtePercentageById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFtePercentageByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a specific full-time equivalent (FTE) percentage (line) on a given employment. (Auth roles: EmploymentFtePercentage,EmploymentFtePercentage_Full)
    ApiResponse<EmploymentFtePercentageDto> response = apiInstance.GetFtePercentageByIdWithHttpInfo(employmentId, ftePercentageId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmploymentFtePercentagesApi.GetFtePercentageByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employmentId** | **long** | The id of the employment. |  |
| **ftePercentageId** | **long** | The id of the full-time equivalent (FTE) percentage (line). |  |

### Return type

[**EmploymentFtePercentageDto**](EmploymentFtePercentageDto.md)

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


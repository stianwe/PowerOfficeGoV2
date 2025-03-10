# PowerOfficeGoV2.Api.EmploymentLayoffsApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EmployeesEmploymentsEmploymentIdLayoffsGet**](EmploymentLayoffsApi.md#employeesemploymentsemploymentidlayoffsget) | **GET** /Employees/Employments/{employmentId}/Layoffs | Get layoff lines for the given employment (employment relationships) on an employee. (Auth roles: EmploymentLayoff,EmploymentLayoff_Full) |
| [**EmployeesEmploymentsEmploymentIdLayoffsLayoffIdDelete**](EmploymentLayoffsApi.md#employeesemploymentsemploymentidlayoffslayoffiddelete) | **DELETE** /Employees/Employments/{employmentId}/Layoffs/{layoffId} | Delete a specific layoff (line) on a given employment. (Auth roles: EmploymentLayoff_Full) |
| [**EmployeesEmploymentsEmploymentIdLayoffsLayoffIdPatch**](EmploymentLayoffsApi.md#employeesemploymentsemploymentidlayoffslayoffidpatch) | **PATCH** /Employees/Employments/{employmentId}/Layoffs/{layoffId} | Change an existing layoff (line) on a given employment. (Auth roles: EmploymentLayoff_Full) |
| [**EmployeesEmploymentsEmploymentIdLayoffsPost**](EmploymentLayoffsApi.md#employeesemploymentsemploymentidlayoffspost) | **POST** /Employees/Employments/{employmentId}/Layoffs | Create a new layoff (line) on a given employment. (Auth roles: EmploymentLayoff_Full) |
| [**GetLayoffById**](EmploymentLayoffsApi.md#getlayoffbyid) | **GET** /Employees/Employments/{employmentId}/Layoffs/{layoffId} | Gets a specific layoff (line) on a given employment. (Auth roles: EmploymentLayoff,EmploymentLayoff_Full) |

<a id="employeesemploymentsemploymentidlayoffsget"></a>
# **EmployeesEmploymentsEmploymentIdLayoffsGet**
> List&lt;EmploymentLayoffDto&gt; EmployeesEmploymentsEmploymentIdLayoffsGet (long employmentId, ResourceParameters resourceParameter = null)

Get layoff lines for the given employment (employment relationships) on an employee. (Auth roles: EmploymentLayoff,EmploymentLayoff_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class EmployeesEmploymentsEmploymentIdLayoffsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmploymentLayoffsApi(config);
            var employmentId = 12345;  // long | The id of the employment.
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Get layoff lines for the given employment (employment relationships) on an employee. (Auth roles: EmploymentLayoff,EmploymentLayoff_Full)
                List<EmploymentLayoffDto> result = apiInstance.EmployeesEmploymentsEmploymentIdLayoffsGet(employmentId, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentLayoffsApi.EmployeesEmploymentsEmploymentIdLayoffsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmployeesEmploymentsEmploymentIdLayoffsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get layoff lines for the given employment (employment relationships) on an employee. (Auth roles: EmploymentLayoff,EmploymentLayoff_Full)
    ApiResponse<List<EmploymentLayoffDto>> response = apiInstance.EmployeesEmploymentsEmploymentIdLayoffsGetWithHttpInfo(employmentId, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmploymentLayoffsApi.EmployeesEmploymentsEmploymentIdLayoffsGetWithHttpInfo: " + e.Message);
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

[**List&lt;EmploymentLayoffDto&gt;**](EmploymentLayoffDto.md)

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

<a id="employeesemploymentsemploymentidlayoffslayoffiddelete"></a>
# **EmployeesEmploymentsEmploymentIdLayoffsLayoffIdDelete**
> void EmployeesEmploymentsEmploymentIdLayoffsLayoffIdDelete (long employmentId, Guid layoffId)

Delete a specific layoff (line) on a given employment. (Auth roles: EmploymentLayoff_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class EmployeesEmploymentsEmploymentIdLayoffsLayoffIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmploymentLayoffsApi(config);
            var employmentId = 98765;  // long | The id of the employment.
            var layoffId = f575b4b0-55be-4b56-b01f-44b204df82c5;  // Guid | The id of the layoff (line).

            try
            {
                // Delete a specific layoff (line) on a given employment. (Auth roles: EmploymentLayoff_Full)
                apiInstance.EmployeesEmploymentsEmploymentIdLayoffsLayoffIdDelete(employmentId, layoffId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentLayoffsApi.EmployeesEmploymentsEmploymentIdLayoffsLayoffIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmployeesEmploymentsEmploymentIdLayoffsLayoffIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a specific layoff (line) on a given employment. (Auth roles: EmploymentLayoff_Full)
    apiInstance.EmployeesEmploymentsEmploymentIdLayoffsLayoffIdDeleteWithHttpInfo(employmentId, layoffId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmploymentLayoffsApi.EmployeesEmploymentsEmploymentIdLayoffsLayoffIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employmentId** | **long** | The id of the employment. |  |
| **layoffId** | **Guid** | The id of the layoff (line). |  |

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
| **200** | Given when layoff line is deleted |  -  |
| **404** | Given when resource was not found |  -  |
| **409** | Given when resource cannot be deleted |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="employeesemploymentsemploymentidlayoffslayoffidpatch"></a>
# **EmployeesEmploymentsEmploymentIdLayoffsLayoffIdPatch**
> EmploymentLayoffDto EmployeesEmploymentsEmploymentIdLayoffsLayoffIdPatch (long employmentId, Guid layoffId, List<Operation> operation = null)

Change an existing layoff (line) on a given employment. (Auth roles: EmploymentLayoff_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class EmployeesEmploymentsEmploymentIdLayoffsLayoffIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmploymentLayoffsApi(config);
            var employmentId = 98765;  // long | The id of the employment.
            var layoffId = f575b4b0-55be-4b56-b01f-44b204df82c5;  // Guid | The id of the layoff (line).
            var operation = new List<Operation>(); // List<Operation> | JSON Patch structure for updating a layoff (line). See EmploymentLayoffPatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 (optional) 

            try
            {
                // Change an existing layoff (line) on a given employment. (Auth roles: EmploymentLayoff_Full)
                EmploymentLayoffDto result = apiInstance.EmployeesEmploymentsEmploymentIdLayoffsLayoffIdPatch(employmentId, layoffId, operation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentLayoffsApi.EmployeesEmploymentsEmploymentIdLayoffsLayoffIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmployeesEmploymentsEmploymentIdLayoffsLayoffIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change an existing layoff (line) on a given employment. (Auth roles: EmploymentLayoff_Full)
    ApiResponse<EmploymentLayoffDto> response = apiInstance.EmployeesEmploymentsEmploymentIdLayoffsLayoffIdPatchWithHttpInfo(employmentId, layoffId, operation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmploymentLayoffsApi.EmployeesEmploymentsEmploymentIdLayoffsLayoffIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employmentId** | **long** | The id of the employment. |  |
| **layoffId** | **Guid** | The id of the layoff (line). |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) | JSON Patch structure for updating a layoff (line). See EmploymentLayoffPatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 | [optional]  |

### Return type

[**EmploymentLayoffDto**](EmploymentLayoffDto.md)

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

<a id="employeesemploymentsemploymentidlayoffspost"></a>
# **EmployeesEmploymentsEmploymentIdLayoffsPost**
> EmploymentLayoffDto EmployeesEmploymentsEmploymentIdLayoffsPost (long employmentId, EmploymentLayoffPostDto employmentLayoffPostDto = null)

Create a new layoff (line) on a given employment. (Auth roles: EmploymentLayoff_Full)

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
    public class EmployeesEmploymentsEmploymentIdLayoffsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmploymentLayoffsApi(config);
            var employmentId = 98765;  // long | The id of the employment.
            var employmentLayoffPostDto = new EmploymentLayoffPostDto(); // EmploymentLayoffPostDto |  (optional) 

            try
            {
                // Create a new layoff (line) on a given employment. (Auth roles: EmploymentLayoff_Full)
                EmploymentLayoffDto result = apiInstance.EmployeesEmploymentsEmploymentIdLayoffsPost(employmentId, employmentLayoffPostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentLayoffsApi.EmployeesEmploymentsEmploymentIdLayoffsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmployeesEmploymentsEmploymentIdLayoffsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new layoff (line) on a given employment. (Auth roles: EmploymentLayoff_Full)
    ApiResponse<EmploymentLayoffDto> response = apiInstance.EmployeesEmploymentsEmploymentIdLayoffsPostWithHttpInfo(employmentId, employmentLayoffPostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmploymentLayoffsApi.EmployeesEmploymentsEmploymentIdLayoffsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employmentId** | **long** | The id of the employment. |  |
| **employmentLayoffPostDto** | [**EmploymentLayoffPostDto**](EmploymentLayoffPostDto.md) |  | [optional]  |

### Return type

[**EmploymentLayoffDto**](EmploymentLayoffDto.md)

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

<a id="getlayoffbyid"></a>
# **GetLayoffById**
> EmploymentLayoffDto GetLayoffById (long employmentId, Guid layoffId)

Gets a specific layoff (line) on a given employment. (Auth roles: EmploymentLayoff,EmploymentLayoff_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetLayoffByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmploymentLayoffsApi(config);
            var employmentId = 98765;  // long | The id of the employment.
            var layoffId = f575b4b0-55be-4b56-b01f-44b204df82c5;  // Guid | The id of the layoff (line).

            try
            {
                // Gets a specific layoff (line) on a given employment. (Auth roles: EmploymentLayoff,EmploymentLayoff_Full)
                EmploymentLayoffDto result = apiInstance.GetLayoffById(employmentId, layoffId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentLayoffsApi.GetLayoffById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLayoffByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a specific layoff (line) on a given employment. (Auth roles: EmploymentLayoff,EmploymentLayoff_Full)
    ApiResponse<EmploymentLayoffDto> response = apiInstance.GetLayoffByIdWithHttpInfo(employmentId, layoffId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmploymentLayoffsApi.GetLayoffByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employmentId** | **long** | The id of the employment. |  |
| **layoffId** | **Guid** | The id of the layoff (line). |  |

### Return type

[**EmploymentLayoffDto**](EmploymentLayoffDto.md)

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


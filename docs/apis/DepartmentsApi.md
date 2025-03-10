# PowerOfficeGoV2.Api.DepartmentsApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DepartmentsIdDelete**](DepartmentsApi.md#departmentsiddelete) | **DELETE** /Departments/{id} | Delete an existing department. (Auth roles: Department_Full) |
| [**DepartmentsIdPatch**](DepartmentsApi.md#departmentsidpatch) | **PATCH** /Departments/{id} | Update an existing department. (Auth roles: Department_Full) |
| [**DepartmentsPost**](DepartmentsApi.md#departmentspost) | **POST** /Departments | Create a new department. (Auth roles: Department_Full) |
| [**GetDepartmentById**](DepartmentsApi.md#getdepartmentbyid) | **GET** /Departments/{id} | Get department by ID (Auth roles: Department,Department_Full) |
| [**GetDepartments**](DepartmentsApi.md#getdepartments) | **GET** /Departments | Departments can be divisions of an organization. The usages may also be that of a dimension separating specific  areas of activity for reporting purposes. (Auth roles: Department,Department_Full) |

<a id="departmentsiddelete"></a>
# **DepartmentsIdDelete**
> void DepartmentsIdDelete (long id)

Delete an existing department. (Auth roles: Department_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class DepartmentsIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new DepartmentsApi(config);
            var id = 789L;  // long | Id of the department to delete.

            try
            {
                // Delete an existing department. (Auth roles: Department_Full)
                apiInstance.DepartmentsIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DepartmentsApi.DepartmentsIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DepartmentsIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an existing department. (Auth roles: Department_Full)
    apiInstance.DepartmentsIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DepartmentsApi.DepartmentsIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Id of the department to delete. |  |

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
| **200** | Given when department is deleted |  -  |
| **404** | Given when resource was not found |  -  |
| **409** | Given when resource is in use and cannot be deleted |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="departmentsidpatch"></a>
# **DepartmentsIdPatch**
> void DepartmentsIdPatch (long id, List<Operation> operation = null)

Update an existing department. (Auth roles: Department_Full)

You must provide the ID of the department to update as part of the url.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class DepartmentsIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new DepartmentsApi(config);
            var id = 10001;  // long | Id of the department to update
            var operation = new List<Operation>(); // List<Operation> | JSON Patch structure for updating a Department. See DepartmentPatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 (optional) 

            try
            {
                // Update an existing department. (Auth roles: Department_Full)
                apiInstance.DepartmentsIdPatch(id, operation);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DepartmentsApi.DepartmentsIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DepartmentsIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an existing department. (Auth roles: Department_Full)
    apiInstance.DepartmentsIdPatchWithHttpInfo(id, operation);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DepartmentsApi.DepartmentsIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Id of the department to update |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) | JSON Patch structure for updating a Department. See DepartmentPatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Given when resource was successfully updated. |  -  |
| **400** | Given when request is badly formatted. |  -  |
| **404** | Given when resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="departmentspost"></a>
# **DepartmentsPost**
> DepartmentDto DepartmentsPost (DepartmentPostDto departmentPostDto = null)

Create a new department. (Auth roles: Department_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class DepartmentsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new DepartmentsApi(config);
            var departmentPostDto = new DepartmentPostDto(); // DepartmentPostDto |  (optional) 

            try
            {
                // Create a new department. (Auth roles: Department_Full)
                DepartmentDto result = apiInstance.DepartmentsPost(departmentPostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DepartmentsApi.DepartmentsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DepartmentsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new department. (Auth roles: Department_Full)
    ApiResponse<DepartmentDto> response = apiInstance.DepartmentsPostWithHttpInfo(departmentPostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DepartmentsApi.DepartmentsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **departmentPostDto** | [**DepartmentPostDto**](DepartmentPostDto.md) |  | [optional]  |

### Return type

[**DepartmentDto**](DepartmentDto.md)

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

<a id="getdepartmentbyid"></a>
# **GetDepartmentById**
> void GetDepartmentById (long id)

Get department by ID (Auth roles: Department,Department_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetDepartmentByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new DepartmentsApi(config);
            var id = 123;  // long | The ID of the department.

            try
            {
                // Get department by ID (Auth roles: Department,Department_Full)
                apiInstance.GetDepartmentById(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DepartmentsApi.GetDepartmentById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDepartmentByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get department by ID (Auth roles: Department,Department_Full)
    apiInstance.GetDepartmentByIdWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DepartmentsApi.GetDepartmentByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | The ID of the department. |  |

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
| **200** | Given when resource returned successfully |  -  |
| **404** | Given when resource is not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getdepartments"></a>
# **GetDepartments**
> List&lt;DepartmentDto&gt; GetDepartments (string codes = null, DateTime createdDateTimeOffsetGreaterThan = null, Guid createdFromImportJournalId = null, bool isActive = null, DateTime lastChangedDateTimeOffsetGreaterThan = null, long managerEmployeeNo = null, string name = null, ResourceParameters resourceParameter = null)

Departments can be divisions of an organization. The usages may also be that of a dimension separating specific  areas of activity for reporting purposes. (Auth roles: Department,Department_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetDepartmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new DepartmentsApi(config);
            var codes = 10, 20;  // string | Filter by department codes. SearchString should be in the form of \"1, ABC, 10B\" (codes separated by comma). If filterString is null or whitespace, query is returned as is. (optional) 
            var createdDateTimeOffsetGreaterThan = 2021-09-25 08:03:00.1234567 -00:00;  // DateTime | Find departments created after this timestamp. (optional) 
            var createdFromImportJournalId = f575b4b0-55be-4b56-b01f-44b204df82c5;  // Guid | Find departments created by importJournal with ID. (optional) 
            var isActive = true;  // bool | Filter by isActive. (optional) 
            var lastChangedDateTimeOffsetGreaterThan = 2021-09-25 08:03:00.1234567 -00:00;  // DateTime | Find departments that have been changed after this timestamp. (optional) 
            var managerEmployeeNo = 123;  // long | Filter by department manager via their employee number. (optional) 
            var name = Sales;  // string | Filter by department name. (optional) 
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Departments can be divisions of an organization. The usages may also be that of a dimension separating specific  areas of activity for reporting purposes. (Auth roles: Department,Department_Full)
                List<DepartmentDto> result = apiInstance.GetDepartments(codes, createdDateTimeOffsetGreaterThan, createdFromImportJournalId, isActive, lastChangedDateTimeOffsetGreaterThan, managerEmployeeNo, name, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DepartmentsApi.GetDepartments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDepartmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Departments can be divisions of an organization. The usages may also be that of a dimension separating specific  areas of activity for reporting purposes. (Auth roles: Department,Department_Full)
    ApiResponse<List<DepartmentDto>> response = apiInstance.GetDepartmentsWithHttpInfo(codes, createdDateTimeOffsetGreaterThan, createdFromImportJournalId, isActive, lastChangedDateTimeOffsetGreaterThan, managerEmployeeNo, name, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DepartmentsApi.GetDepartmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **codes** | **string** | Filter by department codes. SearchString should be in the form of \&quot;1, ABC, 10B\&quot; (codes separated by comma). If filterString is null or whitespace, query is returned as is. | [optional]  |
| **createdDateTimeOffsetGreaterThan** | **DateTime** | Find departments created after this timestamp. | [optional]  |
| **createdFromImportJournalId** | **Guid** | Find departments created by importJournal with ID. | [optional]  |
| **isActive** | **bool** | Filter by isActive. | [optional]  |
| **lastChangedDateTimeOffsetGreaterThan** | **DateTime** | Find departments that have been changed after this timestamp. | [optional]  |
| **managerEmployeeNo** | **long** | Filter by department manager via their employee number. | [optional]  |
| **name** | **string** | Filter by department name. | [optional]  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;DepartmentDto&gt;**](DepartmentDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Given when resource returned successfully |  -  |
| **204** | Given when no content is returned |  -  |
| **400** | Given when request is badly formatted |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


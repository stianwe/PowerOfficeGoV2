# PowerOfficeGoV2.Api.ProjectsApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetProjectById**](ProjectsApi.md#getprojectbyid) | **GET** /Projects/{id} | Get an existing project by it&#39;s id. (Auth roles: Project,Project_Full) |
| [**GetProjects**](ProjectsApi.md#getprojects) | **GET** /Projects | Gets the projects available on the client. Multiple filtering options. (Auth roles: Project,Project_Full) |
| [**ProjectsIdDelete**](ProjectsApi.md#projectsiddelete) | **DELETE** /Projects/{id} | Delete a project entity with a given id. (Auth roles: Project_Full) |
| [**ProjectsIdPatch**](ProjectsApi.md#projectsidpatch) | **PATCH** /Projects/{id} | Make changes to an existing project. (Auth roles: Project_Full) |
| [**ProjectsPost**](ProjectsApi.md#projectspost) | **POST** /Projects | Create a new project entity on the client. (Auth roles: Project_Full) |

<a id="getprojectbyid"></a>
# **GetProjectById**
> ProjectDto GetProjectById (long id)

Get an existing project by it's id. (Auth roles: Project,Project_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetProjectByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ProjectsApi(config);
            var id = 12345;  // long | The id of the project

            try
            {
                // Get an existing project by it's id. (Auth roles: Project,Project_Full)
                ProjectDto result = apiInstance.GetProjectById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectsApi.GetProjectById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProjectByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an existing project by it's id. (Auth roles: Project,Project_Full)
    ApiResponse<ProjectDto> response = apiInstance.GetProjectByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectsApi.GetProjectByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | The id of the project |  |

### Return type

[**ProjectDto**](ProjectDto.md)

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

<a id="getprojects"></a>
# **GetProjects**
> List&lt;ProjectDto&gt; GetProjects (DateTimeOffset createdDateTimeOffsetGreaterThan = null, string customerNos = null, string departmentCodes = null, bool excludeArchivedProject = null, bool includeSubProjects = null, DateTimeOffset lastChangedDateTimeOffsetGreaterThan = null, string name = null, ProjectBillingMethod projectBillingMethod = null, string projectCodes = null, string projectManagerEmployeeNos = null, ProjectStatusType status = null, ResourceParameters resourceParameter = null)

Gets the projects available on the client. Multiple filtering options. (Auth roles: Project,Project_Full)

A project may be a standalone project or a subproject.  Subprojects will have the code notation code of main project.code of subproject.  Example: A project with code 10 have a subproject with code 2 in the user interface.  The code of the subprojcet when retrieved from the API will be 10.2 (and because of this, \".\" (dot) is reserved and cannot be used in project codes)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetProjectsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ProjectsApi(config);
            var createdDateTimeOffsetGreaterThan = 2021-09-25 08:03:00.1234567 -00:00;  // DateTimeOffset | Filter on the created timestamp property. This filtering will return all projects with a created timestamp greater than the timestamp provided. Can be used when polling for new project from Go. Date not inclusive. (optional) 
            var customerNos = 10000-11000, 12000, 13000-;  // string | Filter by customer numbers. A project may only be assigned to one customer, and this search-string will return all projects related to the specified customer numbers provided.                  Note that sub-projects will inherit the main projects' customer, unless specified otherwise on the sub-project.                  If inherited, the sub-project customer number will return null, so it is preferable to use the filter includeSubProject in conjunction with this customer number filtering.                  Separate by comma [,] to filter on multiple customer numbers. A range of numbers can be specified using dash/hyphen [-]. For example \"10000-11000, 12000, 13000-\" will result in customers with numbers from and including 10000 to 11000, 12000, 13000 and all above will be returned. If null or whitespace, the filter is not used. (optional) 
            var departmentCodes = 1, 2, 3;  // string | Filter projects on department codes. Separate by comma to filter on multiple codes.                  If blank, all projects with or without department codes are returned (no filter). Note that subprojects will inherit the main project department, unless specified otherwise on the subproject.                  If inherited, the subproject department code will return null, so it is preferable to use the filter includeSubProject in conjunction with this department code filtering (optional) 
            var excludeArchivedProject = false;  // bool | Option to exclude archivedprojects. Default is false, meaning that all projects are returned if not set. (optional) 
            var includeSubProjects = true;  // bool | Include Sub-project(s) for specified projectCodes. If projectCodes is null, all (sub)projects are included (regardless of this variable). If projectCodes is set to subproject(s), this variable have no effect for those projects. (optional) 
            var lastChangedDateTimeOffsetGreaterThan = 2021-09-25 08:03:00.1234567 +00:00;  // DateTimeOffset | Filter projects on the last changed timestamp property. This filtering will return all projects with a last changed timestamp greater than the timestamp provided. Date not inclusive. (optional) 
            var name = Sales;  // string | Filter by the name of projects. Will return projects that contains the searchstring. (optional) 
            var projectBillingMethod = 1;  // ProjectBillingMethod | Filter by project billing method. (optional) 
            var projectCodes = 1, ABC, 10B;  // string | Filter by project codes. SearchString should be in the form of \"1, ABC, 10B\" (codes separated by comma). If filterString is null or whitespace, query is returned as is. (optional) 
            var projectManagerEmployeeNos = 1-5, 8, 25-;  // string | Filter by project managers via their employee numbers. SearchString should be in the form of \"1-5, 8, 25-\" where values from 1 to 15, 8 and all over 25 (inclusive) will be selected. If filterString is null or whitespace, query is returned as is. (optional) 
            var status = (ProjectStatusType) "Tentative";  // ProjectStatusType | Filter by project status. (optional) 
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Gets the projects available on the client. Multiple filtering options. (Auth roles: Project,Project_Full)
                List<ProjectDto> result = apiInstance.GetProjects(createdDateTimeOffsetGreaterThan, customerNos, departmentCodes, excludeArchivedProject, includeSubProjects, lastChangedDateTimeOffsetGreaterThan, name, projectBillingMethod, projectCodes, projectManagerEmployeeNos, status, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectsApi.GetProjects: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProjectsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the projects available on the client. Multiple filtering options. (Auth roles: Project,Project_Full)
    ApiResponse<List<ProjectDto>> response = apiInstance.GetProjectsWithHttpInfo(createdDateTimeOffsetGreaterThan, customerNos, departmentCodes, excludeArchivedProject, includeSubProjects, lastChangedDateTimeOffsetGreaterThan, name, projectBillingMethod, projectCodes, projectManagerEmployeeNos, status, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectsApi.GetProjectsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createdDateTimeOffsetGreaterThan** | **DateTimeOffset** | Filter on the created timestamp property. This filtering will return all projects with a created timestamp greater than the timestamp provided. Can be used when polling for new project from Go. Date not inclusive. | [optional]  |
| **customerNos** | **string** | Filter by customer numbers. A project may only be assigned to one customer, and this search-string will return all projects related to the specified customer numbers provided.                  Note that sub-projects will inherit the main projects&#39; customer, unless specified otherwise on the sub-project.                  If inherited, the sub-project customer number will return null, so it is preferable to use the filter includeSubProject in conjunction with this customer number filtering.                  Separate by comma [,] to filter on multiple customer numbers. A range of numbers can be specified using dash/hyphen [-]. For example \&quot;10000-11000, 12000, 13000-\&quot; will result in customers with numbers from and including 10000 to 11000, 12000, 13000 and all above will be returned. If null or whitespace, the filter is not used. | [optional]  |
| **departmentCodes** | **string** | Filter projects on department codes. Separate by comma to filter on multiple codes.                  If blank, all projects with or without department codes are returned (no filter). Note that subprojects will inherit the main project department, unless specified otherwise on the subproject.                  If inherited, the subproject department code will return null, so it is preferable to use the filter includeSubProject in conjunction with this department code filtering | [optional]  |
| **excludeArchivedProject** | **bool** | Option to exclude archivedprojects. Default is false, meaning that all projects are returned if not set. | [optional]  |
| **includeSubProjects** | **bool** | Include Sub-project(s) for specified projectCodes. If projectCodes is null, all (sub)projects are included (regardless of this variable). If projectCodes is set to subproject(s), this variable have no effect for those projects. | [optional]  |
| **lastChangedDateTimeOffsetGreaterThan** | **DateTimeOffset** | Filter projects on the last changed timestamp property. This filtering will return all projects with a last changed timestamp greater than the timestamp provided. Date not inclusive. | [optional]  |
| **name** | **string** | Filter by the name of projects. Will return projects that contains the searchstring. | [optional]  |
| **projectBillingMethod** | **ProjectBillingMethod** | Filter by project billing method. | [optional]  |
| **projectCodes** | **string** | Filter by project codes. SearchString should be in the form of \&quot;1, ABC, 10B\&quot; (codes separated by comma). If filterString is null or whitespace, query is returned as is. | [optional]  |
| **projectManagerEmployeeNos** | **string** | Filter by project managers via their employee numbers. SearchString should be in the form of \&quot;1-5, 8, 25-\&quot; where values from 1 to 15, 8 and all over 25 (inclusive) will be selected. If filterString is null or whitespace, query is returned as is. | [optional]  |
| **status** | **ProjectStatusType** | Filter by project status. | [optional]  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;ProjectDto&gt;**](ProjectDto.md)

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

<a id="projectsiddelete"></a>
# **ProjectsIdDelete**
> void ProjectsIdDelete (long id)

Delete a project entity with a given id. (Auth roles: Project_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class ProjectsIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ProjectsApi(config);
            var id = 12345;  // long | The id of the department to delete.

            try
            {
                // Delete a project entity with a given id. (Auth roles: Project_Full)
                apiInstance.ProjectsIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProjectsIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a project entity with a given id. (Auth roles: Project_Full)
    apiInstance.ProjectsIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectsApi.ProjectsIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | The id of the department to delete. |  |

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
| **200** | Given when project is deleted |  -  |
| **404** | Given when resource was not found |  -  |
| **409** | Given when resource is in use and cannot be deleted |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="projectsidpatch"></a>
# **ProjectsIdPatch**
> void ProjectsIdPatch (long id, List<Operation> operation = null)

Make changes to an existing project. (Auth roles: Project_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class ProjectsIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ProjectsApi(config);
            var id = 12345;  // long | The id of the project
            var operation = new List<Operation>(); // List<Operation> | JSON Patch structure for updating a Project. See ProjectPatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 (optional) 

            try
            {
                // Make changes to an existing project. (Auth roles: Project_Full)
                apiInstance.ProjectsIdPatch(id, operation);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProjectsIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Make changes to an existing project. (Auth roles: Project_Full)
    apiInstance.ProjectsIdPatchWithHttpInfo(id, operation);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectsApi.ProjectsIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | The id of the project |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) | JSON Patch structure for updating a Project. See ProjectPatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 | [optional]  |

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

<a id="projectspost"></a>
# **ProjectsPost**
> ProjectDto ProjectsPost (ProjectPostDto projectPostDto = null)

Create a new project entity on the client. (Auth roles: Project_Full)

Create a new project entity on the client. To create a subproject, the parentProjectCode property must be set ass well and equal to the main project that the subproject will be a part of.  The response from the POST will return the notation code of main project.code of subproject as the code of the created subproject.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class ProjectsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ProjectsApi(config);
            var projectPostDto = new ProjectPostDto(); // ProjectPostDto |  (optional) 

            try
            {
                // Create a new project entity on the client. (Auth roles: Project_Full)
                ProjectDto result = apiInstance.ProjectsPost(projectPostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProjectsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new project entity on the client. (Auth roles: Project_Full)
    ApiResponse<ProjectDto> response = apiInstance.ProjectsPostWithHttpInfo(projectPostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProjectsApi.ProjectsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectPostDto** | [**ProjectPostDto**](ProjectPostDto.md) |  | [optional]  |

### Return type

[**ProjectDto**](ProjectDto.md)

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


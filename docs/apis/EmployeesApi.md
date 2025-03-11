# PowerOfficeGoV2.Api.EmployeesApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EmployeesEmployeeIdBankAccountsPatch**](EmployeesApi.md#employeesemployeeidbankaccountspatch) | **PATCH** /Employees/{employeeId}/BankAccounts | Change payout bank accounts for an employee with a given id. (Auth roles: EmployeeBankAccounts_Full) |
| [**EmployeesEmployeeIdDelete**](EmployeesApi.md#employeesemployeeiddelete) | **DELETE** /Employees/{employeeId} | Delete an employee entity with a given id. (Auth roles: Employee_Full) |
| [**EmployeesEmployeeIdPatch**](EmployeesApi.md#employeesemployeeidpatch) | **PATCH** /Employees/{employeeId} | Change an existing employee with a given id. (Auth roles: Employee_Full) |
| [**EmployeesGet**](EmployeesApi.md#employeesget) | **GET** /Employees | Gets the employees available on the client. Multiple filtering options. (Auth roles: Employee,Employee_Full) |
| [**EmployeesPost**](EmployeesApi.md#employeespost) | **POST** /Employees | Create one new employee entity. (Auth roles: Employee_Full) |
| [**GetEmployeeById**](EmployeesApi.md#getemployeebyid) | **GET** /Employees/{employeeId} | Gets the specific employee by id. (Auth roles: Employee,Employee_Full) |

<a id="employeesemployeeidbankaccountspatch"></a>
# **EmployeesEmployeeIdBankAccountsPatch**
> EmployeeDto EmployeesEmployeeIdBankAccountsPatch (long employeeId, List<Operation> operation = null)

Change payout bank accounts for an employee with a given id. (Auth roles: EmployeeBankAccounts_Full)

Note that in order to use this endpoint you need to have the special privilege \"EmployeeBankAccounts\".

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class EmployeesEmployeeIdBankAccountsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmployeesApi(config);
            var employeeId = 12345;  // long | The id of the employee.
            var operation = new List<Operation>(); // List<Operation> | JSON Patch structure for updating employee bank accounts. See EmployeeBankAccountsPatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 (optional) 

            try
            {
                // Change payout bank accounts for an employee with a given id. (Auth roles: EmployeeBankAccounts_Full)
                EmployeeDto result = apiInstance.EmployeesEmployeeIdBankAccountsPatch(employeeId, operation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmployeesApi.EmployeesEmployeeIdBankAccountsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmployeesEmployeeIdBankAccountsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change payout bank accounts for an employee with a given id. (Auth roles: EmployeeBankAccounts_Full)
    ApiResponse<EmployeeDto> response = apiInstance.EmployeesEmployeeIdBankAccountsPatchWithHttpInfo(employeeId, operation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmployeesApi.EmployeesEmployeeIdBankAccountsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employeeId** | **long** | The id of the employee. |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) | JSON Patch structure for updating employee bank accounts. See EmployeeBankAccountsPatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 | [optional]  |

### Return type

[**EmployeeDto**](EmployeeDto.md)

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

<a id="employeesemployeeiddelete"></a>
# **EmployeesEmployeeIdDelete**
> void EmployeesEmployeeIdDelete (long employeeId)

Delete an employee entity with a given id. (Auth roles: Employee_Full)

If the employee have links to transactions or other entities, or if the contact is an active customer/supplier, this operation cannot be performed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class EmployeesEmployeeIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmployeesApi(config);
            var employeeId = 12345;  // long | The id of the employee to delete.

            try
            {
                // Delete an employee entity with a given id. (Auth roles: Employee_Full)
                apiInstance.EmployeesEmployeeIdDelete(employeeId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmployeesApi.EmployeesEmployeeIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmployeesEmployeeIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an employee entity with a given id. (Auth roles: Employee_Full)
    apiInstance.EmployeesEmployeeIdDeleteWithHttpInfo(employeeId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmployeesApi.EmployeesEmployeeIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employeeId** | **long** | The id of the employee to delete. |  |

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
| **200** | Given when employee is deleted |  -  |
| **404** | Given when resource was not found |  -  |
| **409** | Given when resource is in use and cannot be deleted |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="employeesemployeeidpatch"></a>
# **EmployeesEmployeeIdPatch**
> EmployeeDto EmployeesEmployeeIdPatch (long employeeId, List<Operation> operation = null)

Change an existing employee with a given id. (Auth roles: Employee_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class EmployeesEmployeeIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmployeesApi(config);
            var employeeId = 12345;  // long | The id of the employee.
            var operation = new List<Operation>(); // List<Operation> | JSON Patch structure for updating an Employee. See EmployeePatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 (optional) 

            try
            {
                // Change an existing employee with a given id. (Auth roles: Employee_Full)
                EmployeeDto result = apiInstance.EmployeesEmployeeIdPatch(employeeId, operation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmployeesApi.EmployeesEmployeeIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmployeesEmployeeIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change an existing employee with a given id. (Auth roles: Employee_Full)
    ApiResponse<EmployeeDto> response = apiInstance.EmployeesEmployeeIdPatchWithHttpInfo(employeeId, operation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmployeesApi.EmployeesEmployeeIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employeeId** | **long** | The id of the employee. |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) | JSON Patch structure for updating an Employee. See EmployeePatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 | [optional]  |

### Return type

[**EmployeeDto**](EmployeeDto.md)

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

<a id="employeesget"></a>
# **EmployeesGet**
> List&lt;EmployeeDto&gt; EmployeesGet (string contactGroupIds = null, DateTimeOffset employeeCreatedDateTimeOffsetGreaterThan = null, string employeeNos = null, string externalImportReference = null, string externalNos = null, DateTimeOffset lastChangedDateTimeOffsetGreaterThan = null, ResourceParameters resourceParameter = null)

Gets the employees available on the client. Multiple filtering options. (Auth roles: Employee,Employee_Full)

The employee object is a contact entity, meaning the id might be shared with a customer and/or a supplier if the contact is registered as both an employee and customer/supplier in Go.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class EmployeesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmployeesApi(config);
            var contactGroupIds = 41345, 21445, 65457;  // string | Filter by contact group IDs. Separate by comma [,] to filter on multiple contact group IDs. If null or whitespace, the filter is not used. (optional) 
            var employeeCreatedDateTimeOffsetGreaterThan = 2021-09-25 08:03:00.1234567 -00:00;  // DateTimeOffset | Filter by the employee created timestamp. This filtering will return all employees with a created timestamp greater than the timestamp provided. Can be used when polling for new entries. Date not inclusive. (optional) 
            var employeeNos = 1, 100-200, 500-;  // string | Filter by employee numbers. Separate by comma [,] to filter on multiple employee numbers. A range of numbers can be specified using dash/hyphen [-]. For example \"1, 100-200, 500-\" will result in employees with number 1, from and including 100 to 200, 500 and all above will be returned. If null or whitespace, the filter is not used. (optional) 
            var externalImportReference = 123ABC;  // string | Filter by external import reference. If null or whitespace, the filter is not used. (optional) 
            var externalNos = 30000, 14153-19534, 150000-;  // string | Filter by employee external numbers. Separate by comma [,] to filter on multiple employee external numbers. A range of numbers can be specified using dash/hyphen [-]. For example \"30000, 14153-19534, 150000-\" will result in employees with external number 30000, from and including 14153 to 19534, 150000 and all above will be returned. If null or whitespace, the filter is not used. (optional) 
            var lastChangedDateTimeOffsetGreaterThan = 2021-09-25 08:03:00.1234567 -00:00;  // DateTimeOffset | Filter by the last changed timestamp. This filtering will return all employees with a last changed timestamp greater than the timestamp provided. Can be used when polling for new entries. If used, changed employees should replace what was previously stored in the external system. Date not inclusive. (optional) 
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Gets the employees available on the client. Multiple filtering options. (Auth roles: Employee,Employee_Full)
                List<EmployeeDto> result = apiInstance.EmployeesGet(contactGroupIds, employeeCreatedDateTimeOffsetGreaterThan, employeeNos, externalImportReference, externalNos, lastChangedDateTimeOffsetGreaterThan, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmployeesApi.EmployeesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmployeesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the employees available on the client. Multiple filtering options. (Auth roles: Employee,Employee_Full)
    ApiResponse<List<EmployeeDto>> response = apiInstance.EmployeesGetWithHttpInfo(contactGroupIds, employeeCreatedDateTimeOffsetGreaterThan, employeeNos, externalImportReference, externalNos, lastChangedDateTimeOffsetGreaterThan, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmployeesApi.EmployeesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contactGroupIds** | **string** | Filter by contact group IDs. Separate by comma [,] to filter on multiple contact group IDs. If null or whitespace, the filter is not used. | [optional]  |
| **employeeCreatedDateTimeOffsetGreaterThan** | **DateTimeOffset** | Filter by the employee created timestamp. This filtering will return all employees with a created timestamp greater than the timestamp provided. Can be used when polling for new entries. Date not inclusive. | [optional]  |
| **employeeNos** | **string** | Filter by employee numbers. Separate by comma [,] to filter on multiple employee numbers. A range of numbers can be specified using dash/hyphen [-]. For example \&quot;1, 100-200, 500-\&quot; will result in employees with number 1, from and including 100 to 200, 500 and all above will be returned. If null or whitespace, the filter is not used. | [optional]  |
| **externalImportReference** | **string** | Filter by external import reference. If null or whitespace, the filter is not used. | [optional]  |
| **externalNos** | **string** | Filter by employee external numbers. Separate by comma [,] to filter on multiple employee external numbers. A range of numbers can be specified using dash/hyphen [-]. For example \&quot;30000, 14153-19534, 150000-\&quot; will result in employees with external number 30000, from and including 14153 to 19534, 150000 and all above will be returned. If null or whitespace, the filter is not used. | [optional]  |
| **lastChangedDateTimeOffsetGreaterThan** | **DateTimeOffset** | Filter by the last changed timestamp. This filtering will return all employees with a last changed timestamp greater than the timestamp provided. Can be used when polling for new entries. If used, changed employees should replace what was previously stored in the external system. Date not inclusive. | [optional]  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;EmployeeDto&gt;**](EmployeeDto.md)

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

<a id="employeespost"></a>
# **EmployeesPost**
> EmployeeDto EmployeesPost (EmployeePostDto employeePostDto = null)

Create one new employee entity. (Auth roles: Employee_Full)

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
    public class EmployeesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmployeesApi(config);
            var employeePostDto = new EmployeePostDto(); // EmployeePostDto |  (optional) 

            try
            {
                // Create one new employee entity. (Auth roles: Employee_Full)
                EmployeeDto result = apiInstance.EmployeesPost(employeePostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmployeesApi.EmployeesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmployeesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create one new employee entity. (Auth roles: Employee_Full)
    ApiResponse<EmployeeDto> response = apiInstance.EmployeesPostWithHttpInfo(employeePostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmployeesApi.EmployeesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employeePostDto** | [**EmployeePostDto**](EmployeePostDto.md) |  | [optional]  |

### Return type

[**EmployeeDto**](EmployeeDto.md)

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

<a id="getemployeebyid"></a>
# **GetEmployeeById**
> EmployeeDto GetEmployeeById (long employeeId)

Gets the specific employee by id. (Auth roles: Employee,Employee_Full)

The employee object is a contact entity, meaning the id might be shared with a customer and/or a supplier if the contact is registered as both an employee and customer/supplier in Go.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetEmployeeByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EmployeesApi(config);
            var employeeId = 12345;  // long | The id of the employee.

            try
            {
                // Gets the specific employee by id. (Auth roles: Employee,Employee_Full)
                EmployeeDto result = apiInstance.GetEmployeeById(employeeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmployeesApi.GetEmployeeById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEmployeeByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the specific employee by id. (Auth roles: Employee,Employee_Full)
    ApiResponse<EmployeeDto> response = apiInstance.GetEmployeeByIdWithHttpInfo(employeeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmployeesApi.GetEmployeeByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employeeId** | **long** | The id of the employee. |  |

### Return type

[**EmployeeDto**](EmployeeDto.md)

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


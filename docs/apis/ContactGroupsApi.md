# PowerOfficeGoV2.Api.ContactGroupsApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ContactGroupsGet**](ContactGroupsApi.md#contactgroupsget) | **GET** /ContactGroups | Get contact groups. (Auth roles: ContactGroup,ContactGroup_Full) |
| [**ContactGroupsIdDelete**](ContactGroupsApi.md#contactgroupsiddelete) | **DELETE** /ContactGroups/{id} | Deletes a contact group by ID. (Auth roles: ContactGroup_Full) |
| [**ContactGroupsIdPatch**](ContactGroupsApi.md#contactgroupsidpatch) | **PATCH** /ContactGroups/{id} | Update a contact group. (Auth roles: ContactGroup_Full) |
| [**ContactGroupsPost**](ContactGroupsApi.md#contactgroupspost) | **POST** /ContactGroups | Create a new contact group. (Auth roles: ContactGroup_Full) |
| [**GetContactGroupById**](ContactGroupsApi.md#getcontactgroupbyid) | **GET** /ContactGroups/{id} | Get a contact group by id. (Auth roles: ContactGroup,ContactGroup_Full) |

<a id="contactgroupsget"></a>
# **ContactGroupsGet**
> List&lt;ContactGroupDto&gt; ContactGroupsGet (DateTimeOffset createdDateTimeOffsetGreaterThan = null, DateTimeOffset lastChangedDateTimeOffsetGreaterThan = null, string names = null, ResourceParameters resourceParameter = null)

Get contact groups. (Auth roles: ContactGroup,ContactGroup_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class ContactGroupsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ContactGroupsApi(config);
            var createdDateTimeOffsetGreaterThan = 2023-09-2 09:39:00.1234567Z;  // DateTimeOffset | Filter by the contact group created timestamp property. This filtering will return all contact groups with a created timestamp greater than the timestamp provided. Can be used when polling for new entries from Go. Timestamp not inclusive. (optional) 
            var lastChangedDateTimeOffsetGreaterThan = 2023-09-2 09:39:00.1234567Z;  // DateTimeOffset | Filter by the contact group last changed timestamp property. This filtering will return all contact groups with a last changed timestamp greater than the timestamp provided. Can be used when polling for new and/or changed entries from Go. Timestamp not inclusive. (optional) 
            var names = Customer, Employees, Suppliers;  // string | Filter by contact group names. SearchString should be separated by comma. If filterString is null or whitespace, query is returned as is. (optional) 
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Get contact groups. (Auth roles: ContactGroup,ContactGroup_Full)
                List<ContactGroupDto> result = apiInstance.ContactGroupsGet(createdDateTimeOffsetGreaterThan, lastChangedDateTimeOffsetGreaterThan, names, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactGroupsApi.ContactGroupsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContactGroupsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get contact groups. (Auth roles: ContactGroup,ContactGroup_Full)
    ApiResponse<List<ContactGroupDto>> response = apiInstance.ContactGroupsGetWithHttpInfo(createdDateTimeOffsetGreaterThan, lastChangedDateTimeOffsetGreaterThan, names, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactGroupsApi.ContactGroupsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createdDateTimeOffsetGreaterThan** | **DateTimeOffset** | Filter by the contact group created timestamp property. This filtering will return all contact groups with a created timestamp greater than the timestamp provided. Can be used when polling for new entries from Go. Timestamp not inclusive. | [optional]  |
| **lastChangedDateTimeOffsetGreaterThan** | **DateTimeOffset** | Filter by the contact group last changed timestamp property. This filtering will return all contact groups with a last changed timestamp greater than the timestamp provided. Can be used when polling for new and/or changed entries from Go. Timestamp not inclusive. | [optional]  |
| **names** | **string** | Filter by contact group names. SearchString should be separated by comma. If filterString is null or whitespace, query is returned as is. | [optional]  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;ContactGroupDto&gt;**](ContactGroupDto.md)

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
| **404** | Given when resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="contactgroupsiddelete"></a>
# **ContactGroupsIdDelete**
> void ContactGroupsIdDelete (long id)

Deletes a contact group by ID. (Auth roles: ContactGroup_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class ContactGroupsIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ContactGroupsApi(config);
            var id = 1234;  // long | 

            try
            {
                // Deletes a contact group by ID. (Auth roles: ContactGroup_Full)
                apiInstance.ContactGroupsIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactGroupsApi.ContactGroupsIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContactGroupsIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a contact group by ID. (Auth roles: ContactGroup_Full)
    apiInstance.ContactGroupsIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactGroupsApi.ContactGroupsIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** |  |  |

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
| **200** | Given when contact group is deleted |  -  |
| **404** | Given when resource was not found |  -  |
| **409** | Given when resource is in use and cannot be deleted |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="contactgroupsidpatch"></a>
# **ContactGroupsIdPatch**
> ContactGroupDto ContactGroupsIdPatch (long id, List<Operation> operation = null)

Update a contact group. (Auth roles: ContactGroup_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class ContactGroupsIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ContactGroupsApi(config);
            var id = 789L;  // long | 
            var operation = new List<Operation>(); // List<Operation> |  (optional) 

            try
            {
                // Update a contact group. (Auth roles: ContactGroup_Full)
                ContactGroupDto result = apiInstance.ContactGroupsIdPatch(id, operation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactGroupsApi.ContactGroupsIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContactGroupsIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a contact group. (Auth roles: ContactGroup_Full)
    ApiResponse<ContactGroupDto> response = apiInstance.ContactGroupsIdPatchWithHttpInfo(id, operation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactGroupsApi.ContactGroupsIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** |  |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) |  | [optional]  |

### Return type

[**ContactGroupDto**](ContactGroupDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Given when resource returned successfully |  -  |
| **400** | Given when request is badly formatted |  -  |
| **404** | Given when resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="contactgroupspost"></a>
# **ContactGroupsPost**
> ContactGroupDto ContactGroupsPost (ContactGroupPostDto contactGroupPostDto = null)

Create a new contact group. (Auth roles: ContactGroup_Full)

Contact groups can be assigned on contact entities (customers/employees/suppliers), and are primarily used for filtering purposes (filtering of contacts).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class ContactGroupsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ContactGroupsApi(config);
            var contactGroupPostDto = new ContactGroupPostDto(); // ContactGroupPostDto | Name is required. (optional) 

            try
            {
                // Create a new contact group. (Auth roles: ContactGroup_Full)
                ContactGroupDto result = apiInstance.ContactGroupsPost(contactGroupPostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactGroupsApi.ContactGroupsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContactGroupsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new contact group. (Auth roles: ContactGroup_Full)
    ApiResponse<ContactGroupDto> response = apiInstance.ContactGroupsPostWithHttpInfo(contactGroupPostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactGroupsApi.ContactGroupsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contactGroupPostDto** | [**ContactGroupPostDto**](ContactGroupPostDto.md) | Name is required. | [optional]  |

### Return type

[**ContactGroupDto**](ContactGroupDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Given when resource was successfully created. |  -  |
| **400** | Given when request is badly formatted |  -  |
| **404** | Given when resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getcontactgroupbyid"></a>
# **GetContactGroupById**
> ContactGroupDto GetContactGroupById (long id)

Get a contact group by id. (Auth roles: ContactGroup,ContactGroup_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetContactGroupByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ContactGroupsApi(config);
            var id = 1234;  // long | Id of contact group.

            try
            {
                // Get a contact group by id. (Auth roles: ContactGroup,ContactGroup_Full)
                ContactGroupDto result = apiInstance.GetContactGroupById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactGroupsApi.GetContactGroupById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContactGroupByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a contact group by id. (Auth roles: ContactGroup,ContactGroup_Full)
    ApiResponse<ContactGroupDto> response = apiInstance.GetContactGroupByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactGroupsApi.GetContactGroupByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Id of contact group. |  |

### Return type

[**ContactGroupDto**](ContactGroupDto.md)

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


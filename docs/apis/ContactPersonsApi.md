# PowerOfficeGoV2.Api.ContactPersonsApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ContactPersonsContactIdIdDelete**](ContactPersonsApi.md#contactpersonscontactididdelete) | **DELETE** /ContactPersons/{contactId}/{id} | Deletes a contact person by ID. (Auth roles: ContactPerson_Full, Customer_Full, Supplier_Full) |
| [**ContactPersonsContactIdIdPatch**](ContactPersonsApi.md#contactpersonscontactididpatch) | **PATCH** /ContactPersons/{contactId}/{id} | Update a contact person. (Auth roles: ContactPerson_Full, Customer_Full, Supplier_Full) |
| [**ContactPersonsContactIdPost**](ContactPersonsApi.md#contactpersonscontactidpost) | **POST** /ContactPersons/{contactId} | Create a contact person. (Auth roles: ContactPerson_Full, Customer_Full, Supplier_Full) |
| [**ContactPersonsGet**](ContactPersonsApi.md#contactpersonsget) | **GET** /ContactPersons | Gets the contact persons associated with a given contact. (Auth roles: ContactPerson, ContactPerson_Full, Customer, Customer_Full, Supplier, Supplier_Full) |
| [**GetContactPersonById**](ContactPersonsApi.md#getcontactpersonbyid) | **GET** /ContactPersons/{contactId}/{id} | Get a contact person by id. (Auth roles: ContactPerson, ContactPerson_Full, Customer, Customer_Full, Supplier, Supplier_Full) |

<a id="contactpersonscontactididdelete"></a>
# **ContactPersonsContactIdIdDelete**
> void ContactPersonsContactIdIdDelete (long contactId, long id)

Deletes a contact person by ID. (Auth roles: ContactPerson_Full, Customer_Full, Supplier_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class ContactPersonsContactIdIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ContactPersonsApi(config);
            var contactId = 789L;  // long | Id of contact (customer or supplier)
            var id = 1234;  // long | Id of contact person

            try
            {
                // Deletes a contact person by ID. (Auth roles: ContactPerson_Full, Customer_Full, Supplier_Full)
                apiInstance.ContactPersonsContactIdIdDelete(contactId, id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactPersonsApi.ContactPersonsContactIdIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContactPersonsContactIdIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a contact person by ID. (Auth roles: ContactPerson_Full, Customer_Full, Supplier_Full)
    apiInstance.ContactPersonsContactIdIdDeleteWithHttpInfo(contactId, id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactPersonsApi.ContactPersonsContactIdIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contactId** | **long** | Id of contact (customer or supplier) |  |
| **id** | **long** | Id of contact person |  |

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

<a id="contactpersonscontactididpatch"></a>
# **ContactPersonsContactIdIdPatch**
> ContactPersonDto ContactPersonsContactIdIdPatch (long contactId, long id, List<Operation> operation = null)

Update a contact person. (Auth roles: ContactPerson_Full, Customer_Full, Supplier_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class ContactPersonsContactIdIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ContactPersonsApi(config);
            var contactId = 789L;  // long | Id of the contact the ContactPerson belongs to
            var id = 789L;  // long | Id of the ContactPerson
            var operation = new List<Operation>(); // List<Operation> | JsonPatchDocument (optional) 

            try
            {
                // Update a contact person. (Auth roles: ContactPerson_Full, Customer_Full, Supplier_Full)
                ContactPersonDto result = apiInstance.ContactPersonsContactIdIdPatch(contactId, id, operation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactPersonsApi.ContactPersonsContactIdIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContactPersonsContactIdIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a contact person. (Auth roles: ContactPerson_Full, Customer_Full, Supplier_Full)
    ApiResponse<ContactPersonDto> response = apiInstance.ContactPersonsContactIdIdPatchWithHttpInfo(contactId, id, operation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactPersonsApi.ContactPersonsContactIdIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contactId** | **long** | Id of the contact the ContactPerson belongs to |  |
| **id** | **long** | Id of the ContactPerson |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) | JsonPatchDocument | [optional]  |

### Return type

[**ContactPersonDto**](ContactPersonDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Given when a resource was successfully returned |  -  |
| **400** | Given when request is badly formatted |  -  |
| **404** | Given when resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="contactpersonscontactidpost"></a>
# **ContactPersonsContactIdPost**
> ContactPersonDto ContactPersonsContactIdPost (long contactId, ContactPersonPostDto contactPersonPostDto = null)

Create a contact person. (Auth roles: ContactPerson_Full, Customer_Full, Supplier_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class ContactPersonsContactIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ContactPersonsApi(config);
            var contactId = 12345;  // long | Id of the contact (Customer or Supplier)
            var contactPersonPostDto = new ContactPersonPostDto(); // ContactPersonPostDto | A contact person post dto (optional) 

            try
            {
                // Create a contact person. (Auth roles: ContactPerson_Full, Customer_Full, Supplier_Full)
                ContactPersonDto result = apiInstance.ContactPersonsContactIdPost(contactId, contactPersonPostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactPersonsApi.ContactPersonsContactIdPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContactPersonsContactIdPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a contact person. (Auth roles: ContactPerson_Full, Customer_Full, Supplier_Full)
    ApiResponse<ContactPersonDto> response = apiInstance.ContactPersonsContactIdPostWithHttpInfo(contactId, contactPersonPostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactPersonsApi.ContactPersonsContactIdPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contactId** | **long** | Id of the contact (Customer or Supplier) |  |
| **contactPersonPostDto** | [**ContactPersonPostDto**](ContactPersonPostDto.md) | A contact person post dto | [optional]  |

### Return type

[**ContactPersonDto**](ContactPersonDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Given when a resource was created successfully |  -  |
| **400** | Given when request is badly formatted |  -  |
| **404** | Given when resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="contactpersonsget"></a>
# **ContactPersonsGet**
> List&lt;ContactPersonDto&gt; ContactPersonsGet (string contactIds = null, DateTimeOffset createdDateTimeOffsetGreaterThan = null, string externalCodes = null, DateTimeOffset lastChangedDateTimeOffsetGreaterThan = null, ResourceParameters resourceParameter = null)

Gets the contact persons associated with a given contact. (Auth roles: ContactPerson, ContactPerson_Full, Customer, Customer_Full, Supplier, Supplier_Full)

Gets the contact persons associated with a given contact (customer/supplier identifier).              Contact persons are not available for employee contacts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class ContactPersonsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ContactPersonsApi(config);
            var contactIds = 12345, 62142, 11235;  // string | Filter by contact IDs. Separate by comma to filter on multiple contact IDs. If filterString is null or whitespace, query is returned as is. (optional) 
            var createdDateTimeOffsetGreaterThan = 2023-10-19T11:05:00.1234567Z;  // DateTimeOffset | Filter by the contact person created timestamp property.              This filtering will return all contact persons with a created timestamp greater than the timestamp provided.              Can be used when polling for new entries from Go. Timestamp not inclusive. (optional) 
            var externalCodes = A69, B420, C1337;  // string | Filter by contact person external codes. SearchString should be separated by comma.              If filterString is null or whitespace, query is returned as is. (optional) 
            var lastChangedDateTimeOffsetGreaterThan = 2023-10-19T11:05:00.1234567Z;  // DateTimeOffset | Filter by the contact person last changed timestamp property.              This filtering will return all contact persons with a last changed timestamp greater than the timestamp provided.Can be used when polling for new and/or changed entries from Go.              Timestamp not inclusive. (optional) 
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Gets the contact persons associated with a given contact. (Auth roles: ContactPerson, ContactPerson_Full, Customer, Customer_Full, Supplier, Supplier_Full)
                List<ContactPersonDto> result = apiInstance.ContactPersonsGet(contactIds, createdDateTimeOffsetGreaterThan, externalCodes, lastChangedDateTimeOffsetGreaterThan, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactPersonsApi.ContactPersonsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContactPersonsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the contact persons associated with a given contact. (Auth roles: ContactPerson, ContactPerson_Full, Customer, Customer_Full, Supplier, Supplier_Full)
    ApiResponse<List<ContactPersonDto>> response = apiInstance.ContactPersonsGetWithHttpInfo(contactIds, createdDateTimeOffsetGreaterThan, externalCodes, lastChangedDateTimeOffsetGreaterThan, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactPersonsApi.ContactPersonsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contactIds** | **string** | Filter by contact IDs. Separate by comma to filter on multiple contact IDs. If filterString is null or whitespace, query is returned as is. | [optional]  |
| **createdDateTimeOffsetGreaterThan** | **DateTimeOffset** | Filter by the contact person created timestamp property.              This filtering will return all contact persons with a created timestamp greater than the timestamp provided.              Can be used when polling for new entries from Go. Timestamp not inclusive. | [optional]  |
| **externalCodes** | **string** | Filter by contact person external codes. SearchString should be separated by comma.              If filterString is null or whitespace, query is returned as is. | [optional]  |
| **lastChangedDateTimeOffsetGreaterThan** | **DateTimeOffset** | Filter by the contact person last changed timestamp property.              This filtering will return all contact persons with a last changed timestamp greater than the timestamp provided.Can be used when polling for new and/or changed entries from Go.              Timestamp not inclusive. | [optional]  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;ContactPersonDto&gt;**](ContactPersonDto.md)

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

<a id="getcontactpersonbyid"></a>
# **GetContactPersonById**
> ContactPersonDto GetContactPersonById (long contactId, long id)

Get a contact person by id. (Auth roles: ContactPerson, ContactPerson_Full, Customer, Customer_Full, Supplier, Supplier_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetContactPersonByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ContactPersonsApi(config);
            var contactId = 789L;  // long | Id of the contact (Customer or Supplier)
            var id = 789L;  // long | Id of the contact person

            try
            {
                // Get a contact person by id. (Auth roles: ContactPerson, ContactPerson_Full, Customer, Customer_Full, Supplier, Supplier_Full)
                ContactPersonDto result = apiInstance.GetContactPersonById(contactId, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactPersonsApi.GetContactPersonById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContactPersonByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a contact person by id. (Auth roles: ContactPerson, ContactPerson_Full, Customer, Customer_Full, Supplier, Supplier_Full)
    ApiResponse<ContactPersonDto> response = apiInstance.GetContactPersonByIdWithHttpInfo(contactId, id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactPersonsApi.GetContactPersonByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contactId** | **long** | Id of the contact (Customer or Supplier) |  |
| **id** | **long** | Id of the contact person |  |

### Return type

[**ContactPersonDto**](ContactPersonDto.md)

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


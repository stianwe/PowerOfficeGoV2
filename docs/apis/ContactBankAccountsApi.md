# PowerOfficeGoV2.Api.ContactBankAccountsApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ContactBankAccountsContactIdIdDelete**](ContactBankAccountsApi.md#contactbankaccountscontactididdelete) | **DELETE** /ContactBankAccounts/{contactId}/{id} | Delete an existing bank account on a contact (customer/employee/supplier) with a given id. (Auth roles: ContactBankAccount, ContactBankAccount_Full, Customer_Full, Supplier_Full, Employee_Full) |
| [**ContactBankAccountsContactIdIdPatch**](ContactBankAccountsApi.md#contactbankaccountscontactididpatch) | **PATCH** /ContactBankAccounts/{contactId}/{id} | Update an existing bank account on a contact (customer/employee/supplier) with a given id. (Auth roles: ContactBankAccount, ContactBankAccount_Full, Customer_Full, Supplier_Full, Employee_Full) |
| [**ContactBankAccountsContactIdPost**](ContactBankAccountsApi.md#contactbankaccountscontactidpost) | **POST** /ContactBankAccounts/{contactId} | Add new bank account on a contact (customer/employee/supplier) with a given id. (Auth roles: ContactBankAccount_Full, Customer_Full, Supplier_Full, Employee_Full) |
| [**ContactBankAccountsGet**](ContactBankAccountsApi.md#contactbankaccountsget) | **GET** /ContactBankAccounts | Gets the bank accounts set on the client contacts (customer/employee/supplier). (Auth roles: ContactBankAccount, ContactBankAccount_Full, Customer, Customer_Full, Supplier, Supplier_Full, Employee, Employee_Full) |
| [**GetContactBankAccountsById**](ContactBankAccountsApi.md#getcontactbankaccountsbyid) | **GET** /ContactBankAccounts/{contactId}/{id} | Get a contact bank account given contact id and bank account id (customer/employee/supplier). (Auth roles: ContactBankAccount, ContactBankAccount_Full, Customer, Customer_Full, Supplier, Supplier_Full, Employee, Employee_Full) |

<a id="contactbankaccountscontactididdelete"></a>
# **ContactBankAccountsContactIdIdDelete**
> void ContactBankAccountsContactIdIdDelete (long contactId, long id)

Delete an existing bank account on a contact (customer/employee/supplier) with a given id. (Auth roles: ContactBankAccount, ContactBankAccount_Full, Customer_Full, Supplier_Full, Employee_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class ContactBankAccountsContactIdIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ContactBankAccountsApi(config);
            var contactId = 789L;  // long | The id of the contact
            var id = 789L;  // long | The id of the contact bank account

            try
            {
                // Delete an existing bank account on a contact (customer/employee/supplier) with a given id. (Auth roles: ContactBankAccount, ContactBankAccount_Full, Customer_Full, Supplier_Full, Employee_Full)
                apiInstance.ContactBankAccountsContactIdIdDelete(contactId, id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactBankAccountsApi.ContactBankAccountsContactIdIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContactBankAccountsContactIdIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an existing bank account on a contact (customer/employee/supplier) with a given id. (Auth roles: ContactBankAccount, ContactBankAccount_Full, Customer_Full, Supplier_Full, Employee_Full)
    apiInstance.ContactBankAccountsContactIdIdDeleteWithHttpInfo(contactId, id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactBankAccountsApi.ContactBankAccountsContactIdIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contactId** | **long** | The id of the contact |  |
| **id** | **long** | The id of the contact bank account |  |

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
| **404** | Given when resource was not found |  -  |
| **409** | Given when resource is in use and cannot be deleted |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="contactbankaccountscontactididpatch"></a>
# **ContactBankAccountsContactIdIdPatch**
> ContactBankAccountDto ContactBankAccountsContactIdIdPatch (long contactId, long id, List<Operation> operation = null)

Update an existing bank account on a contact (customer/employee/supplier) with a given id. (Auth roles: ContactBankAccount, ContactBankAccount_Full, Customer_Full, Supplier_Full, Employee_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class ContactBankAccountsContactIdIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ContactBankAccountsApi(config);
            var contactId = 789L;  // long | 
            var id = 789L;  // long | 
            var operation = new List<Operation>(); // List<Operation> |  (optional) 

            try
            {
                // Update an existing bank account on a contact (customer/employee/supplier) with a given id. (Auth roles: ContactBankAccount, ContactBankAccount_Full, Customer_Full, Supplier_Full, Employee_Full)
                ContactBankAccountDto result = apiInstance.ContactBankAccountsContactIdIdPatch(contactId, id, operation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactBankAccountsApi.ContactBankAccountsContactIdIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContactBankAccountsContactIdIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an existing bank account on a contact (customer/employee/supplier) with a given id. (Auth roles: ContactBankAccount, ContactBankAccount_Full, Customer_Full, Supplier_Full, Employee_Full)
    ApiResponse<ContactBankAccountDto> response = apiInstance.ContactBankAccountsContactIdIdPatchWithHttpInfo(contactId, id, operation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactBankAccountsApi.ContactBankAccountsContactIdIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contactId** | **long** |  |  |
| **id** | **long** |  |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) |  | [optional]  |

### Return type

[**ContactBankAccountDto**](ContactBankAccountDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Given when a resource was successfully updated |  -  |
| **400** | Given when request is badly formatted |  -  |
| **404** | Given when resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="contactbankaccountscontactidpost"></a>
# **ContactBankAccountsContactIdPost**
> ContactBankAccountDto ContactBankAccountsContactIdPost (long contactId, ContactBankAccountPostDto contactBankAccountPostDto = null)

Add new bank account on a contact (customer/employee/supplier) with a given id. (Auth roles: ContactBankAccount_Full, Customer_Full, Supplier_Full, Employee_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class ContactBankAccountsContactIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ContactBankAccountsApi(config);
            var contactId = 12345;  // long | 
            var contactBankAccountPostDto = new ContactBankAccountPostDto(); // ContactBankAccountPostDto |  (optional) 

            try
            {
                // Add new bank account on a contact (customer/employee/supplier) with a given id. (Auth roles: ContactBankAccount_Full, Customer_Full, Supplier_Full, Employee_Full)
                ContactBankAccountDto result = apiInstance.ContactBankAccountsContactIdPost(contactId, contactBankAccountPostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactBankAccountsApi.ContactBankAccountsContactIdPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContactBankAccountsContactIdPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add new bank account on a contact (customer/employee/supplier) with a given id. (Auth roles: ContactBankAccount_Full, Customer_Full, Supplier_Full, Employee_Full)
    ApiResponse<ContactBankAccountDto> response = apiInstance.ContactBankAccountsContactIdPostWithHttpInfo(contactId, contactBankAccountPostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactBankAccountsApi.ContactBankAccountsContactIdPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contactId** | **long** |  |  |
| **contactBankAccountPostDto** | [**ContactBankAccountPostDto**](ContactBankAccountPostDto.md) |  | [optional]  |

### Return type

[**ContactBankAccountDto**](ContactBankAccountDto.md)

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

<a id="contactbankaccountsget"></a>
# **ContactBankAccountsGet**
> List&lt;ContactBankAccountDto&gt; ContactBankAccountsGet (string bankAccountNumbers = null, string contactIds = null, DateTimeOffset createdDateTimeOffsetGreaterThan = null, DateTimeOffset lastChangedDateTimeOffsetGreaterThan = null, ResourceParameters resourceParameter = null)

Gets the bank accounts set on the client contacts (customer/employee/supplier). (Auth roles: ContactBankAccount, ContactBankAccount_Full, Customer, Customer_Full, Supplier, Supplier_Full, Employee, Employee_Full)

Queries can be done independent of the contact objects, but the response is coupled with the contact access privileges. Multiple filtering options.              Bank accounts set on contacts are used for payments and information purposes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class ContactBankAccountsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ContactBankAccountsApi(config);
            var bankAccountNumbers = 12345678901, 98765432101;  // string | Filter by bank account numbers. Separate by comma to filter on multiple bank accounts. If filterString is null or whitespace, query is returned as is. (optional) 
            var contactIds = 12345, 67890;  // string | Filter contact bank accounts by the contact id's. Separate by comma to filter on multiple id's. If filterString is null or whitespace, the query will lookup all the contacts the integration has access and privileges for. (optional) 
            var createdDateTimeOffsetGreaterThan = 2023-11-29T14:00:00.1234567Z;  // DateTimeOffset | Filter by the contact bank account created timestamp property.                  This filtering will return all bank accounts with a created timestamp greater than the timestamp provided.                  Can be used when polling for new entries from Go. Timestamp not inclusive. (optional) 
            var lastChangedDateTimeOffsetGreaterThan = 2023-11-29T14:00:00.1234567Z;  // DateTimeOffset | Filter by the contact bank account last changed timestamp property.                  This filtering will return all bank accounts with a last changed timestamp greater than the timestamp provided.                  Can be used when polling for new and/or changed entries from Go. Timestamp not inclusive. (optional) 
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Gets the bank accounts set on the client contacts (customer/employee/supplier). (Auth roles: ContactBankAccount, ContactBankAccount_Full, Customer, Customer_Full, Supplier, Supplier_Full, Employee, Employee_Full)
                List<ContactBankAccountDto> result = apiInstance.ContactBankAccountsGet(bankAccountNumbers, contactIds, createdDateTimeOffsetGreaterThan, lastChangedDateTimeOffsetGreaterThan, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactBankAccountsApi.ContactBankAccountsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContactBankAccountsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the bank accounts set on the client contacts (customer/employee/supplier). (Auth roles: ContactBankAccount, ContactBankAccount_Full, Customer, Customer_Full, Supplier, Supplier_Full, Employee, Employee_Full)
    ApiResponse<List<ContactBankAccountDto>> response = apiInstance.ContactBankAccountsGetWithHttpInfo(bankAccountNumbers, contactIds, createdDateTimeOffsetGreaterThan, lastChangedDateTimeOffsetGreaterThan, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactBankAccountsApi.ContactBankAccountsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bankAccountNumbers** | **string** | Filter by bank account numbers. Separate by comma to filter on multiple bank accounts. If filterString is null or whitespace, query is returned as is. | [optional]  |
| **contactIds** | **string** | Filter contact bank accounts by the contact id&#39;s. Separate by comma to filter on multiple id&#39;s. If filterString is null or whitespace, the query will lookup all the contacts the integration has access and privileges for. | [optional]  |
| **createdDateTimeOffsetGreaterThan** | **DateTimeOffset** | Filter by the contact bank account created timestamp property.                  This filtering will return all bank accounts with a created timestamp greater than the timestamp provided.                  Can be used when polling for new entries from Go. Timestamp not inclusive. | [optional]  |
| **lastChangedDateTimeOffsetGreaterThan** | **DateTimeOffset** | Filter by the contact bank account last changed timestamp property.                  This filtering will return all bank accounts with a last changed timestamp greater than the timestamp provided.                  Can be used when polling for new and/or changed entries from Go. Timestamp not inclusive. | [optional]  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;ContactBankAccountDto&gt;**](ContactBankAccountDto.md)

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

<a id="getcontactbankaccountsbyid"></a>
# **GetContactBankAccountsById**
> ContactBankAccountDto GetContactBankAccountsById (long contactId, long id)

Get a contact bank account given contact id and bank account id (customer/employee/supplier). (Auth roles: ContactBankAccount, ContactBankAccount_Full, Customer, Customer_Full, Supplier, Supplier_Full, Employee, Employee_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetContactBankAccountsByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ContactBankAccountsApi(config);
            var contactId = 12345;  // long | The id of the contact
            var id = 23456;  // long | The id of the bank account

            try
            {
                // Get a contact bank account given contact id and bank account id (customer/employee/supplier). (Auth roles: ContactBankAccount, ContactBankAccount_Full, Customer, Customer_Full, Supplier, Supplier_Full, Employee, Employee_Full)
                ContactBankAccountDto result = apiInstance.GetContactBankAccountsById(contactId, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactBankAccountsApi.GetContactBankAccountsById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContactBankAccountsByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a contact bank account given contact id and bank account id (customer/employee/supplier). (Auth roles: ContactBankAccount, ContactBankAccount_Full, Customer, Customer_Full, Supplier, Supplier_Full, Employee, Employee_Full)
    ApiResponse<ContactBankAccountDto> response = apiInstance.GetContactBankAccountsByIdWithHttpInfo(contactId, id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactBankAccountsApi.GetContactBankAccountsByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contactId** | **long** | The id of the contact |  |
| **id** | **long** | The id of the bank account |  |

### Return type

[**ContactBankAccountDto**](ContactBankAccountDto.md)

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


# PowerOfficeGoV2.Api.ContactDeliveryAddressesApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ContactDeliveryAddressesContactIdIdDelete**](ContactDeliveryAddressesApi.md#contactdeliveryaddressescontactididdelete) | **DELETE** /ContactDeliveryAddresses/{contactId}/{id} | Deletes a delivery address by id for a given contact (Auth roles: ContactDeliveryAddress_Full, Customer_Full, Supplier_Full, Employee_Full) |
| [**ContactDeliveryAddressesContactIdIdPatch**](ContactDeliveryAddressesApi.md#contactdeliveryaddressescontactididpatch) | **PATCH** /ContactDeliveryAddresses/{contactId}/{id} | Change an existing delivery addresses for a given contact (customer/employee/supplier identifier). (Auth roles: ContactDeliveryAddress_Full, Customer_Full, Supplier_Full, Employee_Full) |
| [**ContactDeliveryAddressesContactIdPost**](ContactDeliveryAddressesApi.md#contactdeliveryaddressescontactidpost) | **POST** /ContactDeliveryAddresses/{contactId} | Creates a delivery address for a given contact (customer/employee/supplier). (Auth roles: ContactDeliveryAddress_Full, Customer_Full, Supplier_Full, Employee_Full) |
| [**ContactDeliveryAddressesGet**](ContactDeliveryAddressesApi.md#contactdeliveryaddressesget) | **GET** /ContactDeliveryAddresses | Gets the delivery addresses for a given contact (Auth roles: ContactDeliveryAddress, ContactDeliveryAddress_Full, Customer, Customer_Full, Supplier, Supplier_Full, Employee, Employee_Full) |
| [**GetContactDeliveryAddressById**](ContactDeliveryAddressesApi.md#getcontactdeliveryaddressbyid) | **GET** /ContactDeliveryAddresses/{contactId}/{id} | Gets a delivery address by id for a given contact (Auth roles: ContactDeliveryAddress, ContactDeliveryAddress_Full, Customer, Customer_Full, Supplier, Supplier_Full, Employee, Employee_Full) |

<a id="contactdeliveryaddressescontactididdelete"></a>
# **ContactDeliveryAddressesContactIdIdDelete**
> void ContactDeliveryAddressesContactIdIdDelete (long contactId, long id)

Deletes a delivery address by id for a given contact (Auth roles: ContactDeliveryAddress_Full, Customer_Full, Supplier_Full, Employee_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class ContactDeliveryAddressesContactIdIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ContactDeliveryAddressesApi(config);
            var contactId = 789L;  // long | Id of the contact
            var id = 789L;  // long | Id of the contact delivery address

            try
            {
                // Deletes a delivery address by id for a given contact (Auth roles: ContactDeliveryAddress_Full, Customer_Full, Supplier_Full, Employee_Full)
                apiInstance.ContactDeliveryAddressesContactIdIdDelete(contactId, id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactDeliveryAddressesApi.ContactDeliveryAddressesContactIdIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContactDeliveryAddressesContactIdIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a delivery address by id for a given contact (Auth roles: ContactDeliveryAddress_Full, Customer_Full, Supplier_Full, Employee_Full)
    apiInstance.ContactDeliveryAddressesContactIdIdDeleteWithHttpInfo(contactId, id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactDeliveryAddressesApi.ContactDeliveryAddressesContactIdIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contactId** | **long** | Id of the contact |  |
| **id** | **long** | Id of the contact delivery address |  |

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
| **200** | Given when resource is deleted successfully |  -  |
| **404** | Given when resource was not found |  -  |
| **409** | Given when resource is in use and cannot be deleted |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="contactdeliveryaddressescontactididpatch"></a>
# **ContactDeliveryAddressesContactIdIdPatch**
> ContactDeliveryAddressDto ContactDeliveryAddressesContactIdIdPatch (long contactId, long id, List<Operation> operation = null)

Change an existing delivery addresses for a given contact (customer/employee/supplier identifier). (Auth roles: ContactDeliveryAddress_Full, Customer_Full, Supplier_Full, Employee_Full)

CountryCode will default to \"NO\" if provided as null or empty string.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class ContactDeliveryAddressesContactIdIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ContactDeliveryAddressesApi(config);
            var contactId = 789L;  // long | Id of the contact
            var id = 789L;  // long | Id of the contact delivery address
            var operation = new List<Operation>(); // List<Operation> | Json patch document (optional) 

            try
            {
                // Change an existing delivery addresses for a given contact (customer/employee/supplier identifier). (Auth roles: ContactDeliveryAddress_Full, Customer_Full, Supplier_Full, Employee_Full)
                ContactDeliveryAddressDto result = apiInstance.ContactDeliveryAddressesContactIdIdPatch(contactId, id, operation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactDeliveryAddressesApi.ContactDeliveryAddressesContactIdIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContactDeliveryAddressesContactIdIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change an existing delivery addresses for a given contact (customer/employee/supplier identifier). (Auth roles: ContactDeliveryAddress_Full, Customer_Full, Supplier_Full, Employee_Full)
    ApiResponse<ContactDeliveryAddressDto> response = apiInstance.ContactDeliveryAddressesContactIdIdPatchWithHttpInfo(contactId, id, operation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactDeliveryAddressesApi.ContactDeliveryAddressesContactIdIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contactId** | **long** | Id of the contact |  |
| **id** | **long** | Id of the contact delivery address |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) | Json patch document | [optional]  |

### Return type

[**ContactDeliveryAddressDto**](ContactDeliveryAddressDto.md)

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

<a id="contactdeliveryaddressescontactidpost"></a>
# **ContactDeliveryAddressesContactIdPost**
> ContactDeliveryAddressDto ContactDeliveryAddressesContactIdPost (long contactId, ContactDeliveryAddressPostDto contactDeliveryAddressPostDto = null)

Creates a delivery address for a given contact (customer/employee/supplier). (Auth roles: ContactDeliveryAddress_Full, Customer_Full, Supplier_Full, Employee_Full)

CountryCode must be a valid ISO 3166-1 alfa-2 code if provided. If not CountryCode is provided, it will default to \"NO\".

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class ContactDeliveryAddressesContactIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ContactDeliveryAddressesApi(config);
            var contactId = 789L;  // long | Id of the contact
            var contactDeliveryAddressPostDto = new ContactDeliveryAddressPostDto(); // ContactDeliveryAddressPostDto | A contact delivery address post dto (optional) 

            try
            {
                // Creates a delivery address for a given contact (customer/employee/supplier). (Auth roles: ContactDeliveryAddress_Full, Customer_Full, Supplier_Full, Employee_Full)
                ContactDeliveryAddressDto result = apiInstance.ContactDeliveryAddressesContactIdPost(contactId, contactDeliveryAddressPostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactDeliveryAddressesApi.ContactDeliveryAddressesContactIdPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContactDeliveryAddressesContactIdPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a delivery address for a given contact (customer/employee/supplier). (Auth roles: ContactDeliveryAddress_Full, Customer_Full, Supplier_Full, Employee_Full)
    ApiResponse<ContactDeliveryAddressDto> response = apiInstance.ContactDeliveryAddressesContactIdPostWithHttpInfo(contactId, contactDeliveryAddressPostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactDeliveryAddressesApi.ContactDeliveryAddressesContactIdPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contactId** | **long** | Id of the contact |  |
| **contactDeliveryAddressPostDto** | [**ContactDeliveryAddressPostDto**](ContactDeliveryAddressPostDto.md) | A contact delivery address post dto | [optional]  |

### Return type

[**ContactDeliveryAddressDto**](ContactDeliveryAddressDto.md)

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

<a id="contactdeliveryaddressesget"></a>
# **ContactDeliveryAddressesGet**
> List&lt;ContactDeliveryAddressDto&gt; ContactDeliveryAddressesGet (string contactIds = null, DateTimeOffset createdDateTimeOffsetGreaterThan = null, string externalCodes = null, DateTimeOffset lastChangedDateTimeOffsetGreaterThan = null, ResourceParameters resourceParameter = null)

Gets the delivery addresses for a given contact (Auth roles: ContactDeliveryAddress, ContactDeliveryAddress_Full, Customer, Customer_Full, Supplier, Supplier_Full, Employee, Employee_Full)

Gets the delivery addresses for a given contact (customer/employee/supplier identifier).  The common use case of an delivery address is to set it on sales orders for customers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class ContactDeliveryAddressesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ContactDeliveryAddressesApi(config);
            var contactIds = 12345, 62142, 11235;  // string | Filter by contact IDs. Separate by comma to filter on multiple contact IDs. If filterString is null or whitespace, query is returned as is. (optional) 
            var createdDateTimeOffsetGreaterThan = 2023-10-19T11:05:00.1234567Z;  // DateTimeOffset | Filter by the contact delivery address' created timestamp property.                  This filtering will return all addresses with a created timestamp greater than the timestamp provided.                  Can be used when polling for new entries from Go. Timestamp not inclusive. (optional) 
            var externalCodes = 10A, 3B, 69Z;  // string | Filter by contact delivery address external codes.  Separate by comma to filter on multiple external codes. If filterString is null or whitespace, query is returned as is. Case insensitive, ie. ABC == abc. (optional) 
            var lastChangedDateTimeOffsetGreaterThan = 2023-10-19T11:05:00.1234567Z;  // DateTimeOffset | Filter by the contact delivery address' last changed timestamp property.                  This filtering will return all contact delivery addresses with a last changed timestamp greater than the timestamp provided.                  Can be used when polling for new and/or changed entries from Go. Timestamp not inclusive. (optional) 
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Gets the delivery addresses for a given contact (Auth roles: ContactDeliveryAddress, ContactDeliveryAddress_Full, Customer, Customer_Full, Supplier, Supplier_Full, Employee, Employee_Full)
                List<ContactDeliveryAddressDto> result = apiInstance.ContactDeliveryAddressesGet(contactIds, createdDateTimeOffsetGreaterThan, externalCodes, lastChangedDateTimeOffsetGreaterThan, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactDeliveryAddressesApi.ContactDeliveryAddressesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContactDeliveryAddressesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the delivery addresses for a given contact (Auth roles: ContactDeliveryAddress, ContactDeliveryAddress_Full, Customer, Customer_Full, Supplier, Supplier_Full, Employee, Employee_Full)
    ApiResponse<List<ContactDeliveryAddressDto>> response = apiInstance.ContactDeliveryAddressesGetWithHttpInfo(contactIds, createdDateTimeOffsetGreaterThan, externalCodes, lastChangedDateTimeOffsetGreaterThan, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactDeliveryAddressesApi.ContactDeliveryAddressesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contactIds** | **string** | Filter by contact IDs. Separate by comma to filter on multiple contact IDs. If filterString is null or whitespace, query is returned as is. | [optional]  |
| **createdDateTimeOffsetGreaterThan** | **DateTimeOffset** | Filter by the contact delivery address&#39; created timestamp property.                  This filtering will return all addresses with a created timestamp greater than the timestamp provided.                  Can be used when polling for new entries from Go. Timestamp not inclusive. | [optional]  |
| **externalCodes** | **string** | Filter by contact delivery address external codes.  Separate by comma to filter on multiple external codes. If filterString is null or whitespace, query is returned as is. Case insensitive, ie. ABC &#x3D;&#x3D; abc. | [optional]  |
| **lastChangedDateTimeOffsetGreaterThan** | **DateTimeOffset** | Filter by the contact delivery address&#39; last changed timestamp property.                  This filtering will return all contact delivery addresses with a last changed timestamp greater than the timestamp provided.                  Can be used when polling for new and/or changed entries from Go. Timestamp not inclusive. | [optional]  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;ContactDeliveryAddressDto&gt;**](ContactDeliveryAddressDto.md)

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

<a id="getcontactdeliveryaddressbyid"></a>
# **GetContactDeliveryAddressById**
> ContactDeliveryAddressDto GetContactDeliveryAddressById (long contactId, long id)

Gets a delivery address by id for a given contact (Auth roles: ContactDeliveryAddress, ContactDeliveryAddress_Full, Customer, Customer_Full, Supplier, Supplier_Full, Employee, Employee_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetContactDeliveryAddressByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ContactDeliveryAddressesApi(config);
            var contactId = 789L;  // long | The id of the contact
            var id = 789L;  // long | The id of a delivery address

            try
            {
                // Gets a delivery address by id for a given contact (Auth roles: ContactDeliveryAddress, ContactDeliveryAddress_Full, Customer, Customer_Full, Supplier, Supplier_Full, Employee, Employee_Full)
                ContactDeliveryAddressDto result = apiInstance.GetContactDeliveryAddressById(contactId, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContactDeliveryAddressesApi.GetContactDeliveryAddressById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContactDeliveryAddressByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a delivery address by id for a given contact (Auth roles: ContactDeliveryAddress, ContactDeliveryAddress_Full, Customer, Customer_Full, Supplier, Supplier_Full, Employee, Employee_Full)
    ApiResponse<ContactDeliveryAddressDto> response = apiInstance.GetContactDeliveryAddressByIdWithHttpInfo(contactId, id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContactDeliveryAddressesApi.GetContactDeliveryAddressByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contactId** | **long** | The id of the contact |  |
| **id** | **long** | The id of a delivery address |  |

### Return type

[**ContactDeliveryAddressDto**](ContactDeliveryAddressDto.md)

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


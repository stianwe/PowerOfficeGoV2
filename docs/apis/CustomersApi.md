# PowerOfficeGoV2.Api.CustomersApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CustomersGet**](CustomersApi.md#customersget) | **GET** /Customers | Gets the customers available on the client. Multiple filtering options. (Auth roles: Customer,Customer_Full) |
| [**CustomersIdDelete**](CustomersApi.md#customersiddelete) | **DELETE** /Customers/{id} | Delete a customer entity with a given id. (Auth roles: Customer_Full) |
| [**CustomersIdPatch**](CustomersApi.md#customersidpatch) | **PATCH** /Customers/{id} | Change an existing customer with a given id. (Auth roles: Customer_Full) |
| [**CustomersPost**](CustomersApi.md#customerspost) | **POST** /Customers | Create one new customer entity. (Auth roles: Customer_Full) |
| [**GetCustomerById**](CustomersApi.md#getcustomerbyid) | **GET** /Customers/{id} | Gets the specific customer by id. (Auth roles: Customer,Customer_Full) |

<a id="customersget"></a>
# **CustomersGet**
> List&lt;CustomerDto&gt; CustomersGet (string contactGroupIds = null, DateTimeOffset customerCreatedDateTimeOffsetGreaterThan = null, string customerNos = null, string externalImportReference = null, string externalNos = null, DateTimeOffset lastChangedDateTimeOffsetGreaterThan = null, ResourceParameters resourceParameter = null)

Gets the customers available on the client. Multiple filtering options. (Auth roles: Customer,Customer_Full)

The customer object is a contact entity, meaning the id might be shared with a supplier and/or an employee if the contact is registered as both a customer and supplier/employee in Go.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class CustomersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new CustomersApi(config);
            var contactGroupIds = 41345, 21445, 65457;  // string | Filter by contact group IDs. Separate by comma [,] to filter on multiple contact group IDs. If null or whitespace, all customers with or without contact group IDs are returned (filter is not used). (optional) 
            var customerCreatedDateTimeOffsetGreaterThan = 2021-09-25 08:03:00.1234567 -00:00;  // DateTimeOffset | Filter by the customer created timestamp property. This filtering will return all customers with a created timestamp greater than the timestamp provided. Can be used when polling for new entries from Go. Timestamp not inclusive. (optional) 
            var customerNos = 10000-11000, 12000, 13000-;  // string | Filter by customer numbers. Separate by comma [,] to filter on multiple customer numbers. A range of numbers can be specified using dash/hyphen [-]. For example \"10000-11000, 12000, 13000-\" will result in customers with numbers from and including 10000 to 11000, 12000, 13000 and all above will be returned. If null or whitespace, the filter is not used. (optional) 
            var externalImportReference = 123ABC;  // string | Filter by external import reference. If null or whitespace, the filter is not used. (optional) 
            var externalNos = 30000, 14153-19534, 150000-;  // string | Filter by customer external numbers. SearchString should be in the form of \"30000, 14153-19534, 150000-\" where values for 30000, between (inclusive) 14153-19534 and all over 150000 (inclusive) will be retrieved. If filterString is null or whitespace, query is returned as is. (optional) 
            var lastChangedDateTimeOffsetGreaterThan = 2021-09-25 08:03:00.1234567 -00:00;  // DateTimeOffset | Filter by the last changed timestamp property. This filtering will return all customers with a last changed timestamp greater than the timestamp provided. Can be used when polling for new entries. If used, changed customers should replace what was previously stored in the external system. Date not inclusive. (optional) 
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Gets the customers available on the client. Multiple filtering options. (Auth roles: Customer,Customer_Full)
                List<CustomerDto> result = apiInstance.CustomersGet(contactGroupIds, customerCreatedDateTimeOffsetGreaterThan, customerNos, externalImportReference, externalNos, lastChangedDateTimeOffsetGreaterThan, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.CustomersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CustomersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the customers available on the client. Multiple filtering options. (Auth roles: Customer,Customer_Full)
    ApiResponse<List<CustomerDto>> response = apiInstance.CustomersGetWithHttpInfo(contactGroupIds, customerCreatedDateTimeOffsetGreaterThan, customerNos, externalImportReference, externalNos, lastChangedDateTimeOffsetGreaterThan, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomersApi.CustomersGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contactGroupIds** | **string** | Filter by contact group IDs. Separate by comma [,] to filter on multiple contact group IDs. If null or whitespace, all customers with or without contact group IDs are returned (filter is not used). | [optional]  |
| **customerCreatedDateTimeOffsetGreaterThan** | **DateTimeOffset** | Filter by the customer created timestamp property. This filtering will return all customers with a created timestamp greater than the timestamp provided. Can be used when polling for new entries from Go. Timestamp not inclusive. | [optional]  |
| **customerNos** | **string** | Filter by customer numbers. Separate by comma [,] to filter on multiple customer numbers. A range of numbers can be specified using dash/hyphen [-]. For example \&quot;10000-11000, 12000, 13000-\&quot; will result in customers with numbers from and including 10000 to 11000, 12000, 13000 and all above will be returned. If null or whitespace, the filter is not used. | [optional]  |
| **externalImportReference** | **string** | Filter by external import reference. If null or whitespace, the filter is not used. | [optional]  |
| **externalNos** | **string** | Filter by customer external numbers. SearchString should be in the form of \&quot;30000, 14153-19534, 150000-\&quot; where values for 30000, between (inclusive) 14153-19534 and all over 150000 (inclusive) will be retrieved. If filterString is null or whitespace, query is returned as is. | [optional]  |
| **lastChangedDateTimeOffsetGreaterThan** | **DateTimeOffset** | Filter by the last changed timestamp property. This filtering will return all customers with a last changed timestamp greater than the timestamp provided. Can be used when polling for new entries. If used, changed customers should replace what was previously stored in the external system. Date not inclusive. | [optional]  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;CustomerDto&gt;**](CustomerDto.md)

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

<a id="customersiddelete"></a>
# **CustomersIdDelete**
> void CustomersIdDelete (long id)

Delete a customer entity with a given id. (Auth roles: Customer_Full)

If the customer have links to transactions or other entities, or if the contact is an active supplier/employee, this operation cannot be performed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class CustomersIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new CustomersApi(config);
            var id = 12345;  // long | The id of the customer to delete.

            try
            {
                // Delete a customer entity with a given id. (Auth roles: Customer_Full)
                apiInstance.CustomersIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.CustomersIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CustomersIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a customer entity with a given id. (Auth roles: Customer_Full)
    apiInstance.CustomersIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomersApi.CustomersIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | The id of the customer to delete. |  |

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
| **200** | Given when customer is deleted |  -  |
| **404** | Given when resource was not found |  -  |
| **409** | Given when resource is in use and cannot be deleted |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="customersidpatch"></a>
# **CustomersIdPatch**
> CustomerDto CustomersIdPatch (long id, List<Operation> operation = null)

Change an existing customer with a given id. (Auth roles: Customer_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class CustomersIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new CustomersApi(config);
            var id = 12345;  // long | The id of the customer.
            var operation = new List<Operation>(); // List<Operation> | JSON Patch structure for updating a Customer. See CustomerPatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 (optional) 

            try
            {
                // Change an existing customer with a given id. (Auth roles: Customer_Full)
                CustomerDto result = apiInstance.CustomersIdPatch(id, operation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.CustomersIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CustomersIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change an existing customer with a given id. (Auth roles: Customer_Full)
    ApiResponse<CustomerDto> response = apiInstance.CustomersIdPatchWithHttpInfo(id, operation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomersApi.CustomersIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | The id of the customer. |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) | JSON Patch structure for updating a Customer. See CustomerPatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 | [optional]  |

### Return type

[**CustomerDto**](CustomerDto.md)

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

<a id="customerspost"></a>
# **CustomersPost**
> CustomerDto CustomersPost (CustomerPostDto customerPostDto = null)

Create one new customer entity. (Auth roles: Customer_Full)

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
    public class CustomersPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new CustomersApi(config);
            var customerPostDto = new CustomerPostDto(); // CustomerPostDto |  (optional) 

            try
            {
                // Create one new customer entity. (Auth roles: Customer_Full)
                CustomerDto result = apiInstance.CustomersPost(customerPostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.CustomersPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CustomersPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create one new customer entity. (Auth roles: Customer_Full)
    ApiResponse<CustomerDto> response = apiInstance.CustomersPostWithHttpInfo(customerPostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomersApi.CustomersPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **customerPostDto** | [**CustomerPostDto**](CustomerPostDto.md) |  | [optional]  |

### Return type

[**CustomerDto**](CustomerDto.md)

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

<a id="getcustomerbyid"></a>
# **GetCustomerById**
> CustomerDto GetCustomerById (long id)

Gets the specific customer by id. (Auth roles: Customer,Customer_Full)

The customer object is a contact entity, meaning the id might be shared with a supplier and/or an employee if the contact is registered as both a customer and supplier/employee in Go.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetCustomerByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new CustomersApi(config);
            var id = 12345;  // long | The id of the customer.

            try
            {
                // Gets the specific customer by id. (Auth roles: Customer,Customer_Full)
                CustomerDto result = apiInstance.GetCustomerById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomersApi.GetCustomerById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCustomerByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the specific customer by id. (Auth roles: Customer,Customer_Full)
    ApiResponse<CustomerDto> response = apiInstance.GetCustomerByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomersApi.GetCustomerByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | The id of the customer. |  |

### Return type

[**CustomerDto**](CustomerDto.md)

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


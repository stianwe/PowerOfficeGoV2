# PowerOfficeGoV2.Api.SuppliersApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetSupplierById**](SuppliersApi.md#getsupplierbyid) | **GET** /Suppliers/{id} | Gets the specific supplier by id. (Auth roles: Supplier,Supplier_Full) |
| [**SuppliersGet**](SuppliersApi.md#suppliersget) | **GET** /Suppliers | Gets the suppliers available on the client. Multiple filtering options. (Auth roles: Supplier,Supplier_Full) |
| [**SuppliersIdDelete**](SuppliersApi.md#suppliersiddelete) | **DELETE** /Suppliers/{id} | Delete a supplier entity with a given id. (Auth roles: Supplier_Full) |
| [**SuppliersIdPatch**](SuppliersApi.md#suppliersidpatch) | **PATCH** /Suppliers/{id} | Change an existing supplier with a given id. (Auth roles: Supplier_Full) |
| [**SuppliersPost**](SuppliersApi.md#supplierspost) | **POST** /Suppliers | Create one new supplier entity. (Auth roles: Supplier_Full) |

<a id="getsupplierbyid"></a>
# **GetSupplierById**
> SupplierDto GetSupplierById (long id)

Gets the specific supplier by id. (Auth roles: Supplier,Supplier_Full)

The supplier object is a contact entity, meaning the id might be shared with a customer and/or an employee if the contact is registered as both a supplier and customer/employee in Go.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetSupplierByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new SuppliersApi(config);
            var id = 12345;  // long | The id of the supplier.

            try
            {
                // Gets the specific supplier by id. (Auth roles: Supplier,Supplier_Full)
                SupplierDto result = apiInstance.GetSupplierById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SuppliersApi.GetSupplierById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSupplierByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the specific supplier by id. (Auth roles: Supplier,Supplier_Full)
    ApiResponse<SupplierDto> response = apiInstance.GetSupplierByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SuppliersApi.GetSupplierByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | The id of the supplier. |  |

### Return type

[**SupplierDto**](SupplierDto.md)

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

<a id="suppliersget"></a>
# **SuppliersGet**
> List&lt;SupplierDto&gt; SuppliersGet (string contactGroupIds = null, string externalImportReference = null, string externalNos = null, DateTimeOffset lastChangedDateTimeOffsetGreaterThan = null, DateTimeOffset supplierCreatedDateTimeOffsetGreaterThan = null, string supplierNos = null, ResourceParameters resourceParameter = null)

Gets the suppliers available on the client. Multiple filtering options. (Auth roles: Supplier,Supplier_Full)

The supplier object is a contact entity, meaning the id might be shared with a customer and/or an employee if the contact is registered as both a supplier and customer/employee in Go.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class SuppliersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new SuppliersApi(config);
            var contactGroupIds = 41345, 21445, 65457;  // string | Filter by contact group IDs. Separate by comma to filter on multiple contact group IDs. If filterString is null or whitespace, query is returned as is. (optional) 
            var externalImportReference = 123ABC;  // string | Filter by external import reference. If filterString is null or whitespace, query is returned as is. (optional) 
            var externalNos = 30000, 14153-19534, 150000-;  // string | Filter by supplier external numbers. SearchString should be in the form of \"30000, 14153-19534, 150000-\" where values for 30000, between (inclusive) 14153-19534 and all over 150000 (inclusive) will be retrieved. If filterString is null or whitespace, query is returned as is. (optional) 
            var lastChangedDateTimeOffsetGreaterThan = 2021-09-25 08:03:00.1234567 -00:00;  // DateTimeOffset | Filter by the last changed timestamp property. This filtering will return all suppliers with a last changed timestamp greater than the timestamp provided. Can be used when polling for new entries. If used, changed suppliers should replace what was previously stored in the external system. Date not inclusive. (optional) 
            var supplierCreatedDateTimeOffsetGreaterThan = 2021-09-25 08:03:00.1234567 -00:00;  // DateTimeOffset | Filter by the supplier created timestamp property. This filtering will return all suppliers with a created timestamp greater than the timestamp provided. Can be used when polling for new entries from Go. Date not inclusive. (optional) 
            var supplierNos = 20000, 20100-20200, 20500-;  // string | Filter by supplier numbers. SearchString should be in the form of \"20000, 20100-20200, 20500-\" where values for 20000, between (inclusive) 20100-20200 and all over 20500 (inclusive) will be retrieved. If filterString is null or whitespace, query is returned as is. (optional) 
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Gets the suppliers available on the client. Multiple filtering options. (Auth roles: Supplier,Supplier_Full)
                List<SupplierDto> result = apiInstance.SuppliersGet(contactGroupIds, externalImportReference, externalNos, lastChangedDateTimeOffsetGreaterThan, supplierCreatedDateTimeOffsetGreaterThan, supplierNos, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SuppliersApi.SuppliersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SuppliersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the suppliers available on the client. Multiple filtering options. (Auth roles: Supplier,Supplier_Full)
    ApiResponse<List<SupplierDto>> response = apiInstance.SuppliersGetWithHttpInfo(contactGroupIds, externalImportReference, externalNos, lastChangedDateTimeOffsetGreaterThan, supplierCreatedDateTimeOffsetGreaterThan, supplierNos, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SuppliersApi.SuppliersGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contactGroupIds** | **string** | Filter by contact group IDs. Separate by comma to filter on multiple contact group IDs. If filterString is null or whitespace, query is returned as is. | [optional]  |
| **externalImportReference** | **string** | Filter by external import reference. If filterString is null or whitespace, query is returned as is. | [optional]  |
| **externalNos** | **string** | Filter by supplier external numbers. SearchString should be in the form of \&quot;30000, 14153-19534, 150000-\&quot; where values for 30000, between (inclusive) 14153-19534 and all over 150000 (inclusive) will be retrieved. If filterString is null or whitespace, query is returned as is. | [optional]  |
| **lastChangedDateTimeOffsetGreaterThan** | **DateTimeOffset** | Filter by the last changed timestamp property. This filtering will return all suppliers with a last changed timestamp greater than the timestamp provided. Can be used when polling for new entries. If used, changed suppliers should replace what was previously stored in the external system. Date not inclusive. | [optional]  |
| **supplierCreatedDateTimeOffsetGreaterThan** | **DateTimeOffset** | Filter by the supplier created timestamp property. This filtering will return all suppliers with a created timestamp greater than the timestamp provided. Can be used when polling for new entries from Go. Date not inclusive. | [optional]  |
| **supplierNos** | **string** | Filter by supplier numbers. SearchString should be in the form of \&quot;20000, 20100-20200, 20500-\&quot; where values for 20000, between (inclusive) 20100-20200 and all over 20500 (inclusive) will be retrieved. If filterString is null or whitespace, query is returned as is. | [optional]  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;SupplierDto&gt;**](SupplierDto.md)

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

<a id="suppliersiddelete"></a>
# **SuppliersIdDelete**
> void SuppliersIdDelete (long id)

Delete a supplier entity with a given id. (Auth roles: Supplier_Full)

If the supplier have links to transactions or other entities, or if the contact is an active customer/employee, this operation cannot be performed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class SuppliersIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new SuppliersApi(config);
            var id = 12345;  // long | The id of the supplier to delete.

            try
            {
                // Delete a supplier entity with a given id. (Auth roles: Supplier_Full)
                apiInstance.SuppliersIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SuppliersApi.SuppliersIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SuppliersIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a supplier entity with a given id. (Auth roles: Supplier_Full)
    apiInstance.SuppliersIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SuppliersApi.SuppliersIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | The id of the supplier to delete. |  |

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
| **200** | Given when supplier is deleted |  -  |
| **404** | Given when resource was not found |  -  |
| **409** | Given when resource is in use and cannot be deleted |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="suppliersidpatch"></a>
# **SuppliersIdPatch**
> SupplierDto SuppliersIdPatch (long id, List<Operation> operation = null)

Change an existing supplier with a given id. (Auth roles: Supplier_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class SuppliersIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new SuppliersApi(config);
            var id = 12345;  // long | The id of the supplier.
            var operation = new List<Operation>(); // List<Operation> | JSON Patch structure for updating a Supplier. See SupplierPatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 (optional) 

            try
            {
                // Change an existing supplier with a given id. (Auth roles: Supplier_Full)
                SupplierDto result = apiInstance.SuppliersIdPatch(id, operation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SuppliersApi.SuppliersIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SuppliersIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change an existing supplier with a given id. (Auth roles: Supplier_Full)
    ApiResponse<SupplierDto> response = apiInstance.SuppliersIdPatchWithHttpInfo(id, operation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SuppliersApi.SuppliersIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | The id of the supplier. |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) | JSON Patch structure for updating a Supplier. See SupplierPatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 | [optional]  |

### Return type

[**SupplierDto**](SupplierDto.md)

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

<a id="supplierspost"></a>
# **SuppliersPost**
> SupplierDto SuppliersPost (SupplierPostDto supplierPostDto = null)

Create one new supplier entity. (Auth roles: Supplier_Full)

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
    public class SuppliersPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new SuppliersApi(config);
            var supplierPostDto = new SupplierPostDto(); // SupplierPostDto |  (optional) 

            try
            {
                // Create one new supplier entity. (Auth roles: Supplier_Full)
                SupplierDto result = apiInstance.SuppliersPost(supplierPostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SuppliersApi.SuppliersPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SuppliersPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create one new supplier entity. (Auth roles: Supplier_Full)
    ApiResponse<SupplierDto> response = apiInstance.SuppliersPostWithHttpInfo(supplierPostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SuppliersApi.SuppliersPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **supplierPostDto** | [**SupplierPostDto**](SupplierPostDto.md) |  | [optional]  |

### Return type

[**SupplierDto**](SupplierDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Given when resource was successfully created |  -  |
| **400** | Given when request is badly formatted |  -  |
| **404** | Given when resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


# PowerOfficeGoV2.Api.ProductGroupsApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetProductGroupById**](ProductGroupsApi.md#getproductgroupbyid) | **GET** /ProductGroups/{id} | Get a product group by its id. (Auth roles: Product,Product_Full) |
| [**ProductGroupsGet**](ProductGroupsApi.md#productgroupsget) | **GET** /ProductGroups | Get product groups from the client. (Auth roles: Product,Product_Full) |
| [**ProductGroupsIdDelete**](ProductGroupsApi.md#productgroupsiddelete) | **DELETE** /ProductGroups/{id} | Deletes a product group by ID. (Auth roles: Product_Full) |
| [**ProductGroupsIdPatch**](ProductGroupsApi.md#productgroupsidpatch) | **PATCH** /ProductGroups/{id} | Update an existing product group. (Auth roles: Product_Full) |
| [**ProductGroupsPost**](ProductGroupsApi.md#productgroupspost) | **POST** /ProductGroups | Create a new product group. (Auth roles: Product_Full) |

<a id="getproductgroupbyid"></a>
# **GetProductGroupById**
> ProductGroupDto GetProductGroupById (long id)

Get a product group by its id. (Auth roles: Product,Product_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetProductGroupByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ProductGroupsApi(config);
            var id = 1234;  // long | The id of a product group.

            try
            {
                // Get a product group by its id. (Auth roles: Product,Product_Full)
                ProductGroupDto result = apiInstance.GetProductGroupById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductGroupsApi.GetProductGroupById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProductGroupByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a product group by its id. (Auth roles: Product,Product_Full)
    ApiResponse<ProductGroupDto> response = apiInstance.GetProductGroupByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductGroupsApi.GetProductGroupByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | The id of a product group. |  |

### Return type

[**ProductGroupDto**](ProductGroupDto.md)

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

<a id="productgroupsget"></a>
# **ProductGroupsGet**
> List&lt;ProductGroupDto&gt; ProductGroupsGet (string codes = null, DateTimeOffset createdDateTimeOffsetGreaterThan = null, bool isArchived = null, DateTimeOffset lastChangedDateTimeOffsetGreaterThan = null, string names = null, ProductType type = null, ResourceParameters resourceParameter = null)

Get product groups from the client. (Auth roles: Product,Product_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class ProductGroupsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ProductGroupsApi(config);
            var codes = "codes_example";  // string | Filter by product group codes. SearchString should be in the form of \"1, ABC, 10B\" (codes separated by comma). If filterString is null or whitespace, query is returned as is. (optional) 
            var createdDateTimeOffsetGreaterThan = 2023-09-07 08:46:00.1234567;  // DateTimeOffset | Find product groups created after this timestamp. (optional) 
            var isArchived = false;  // bool | Gets a value indicating whether the product group is archived (set inactive). Archived product groups will be unavailable for usage in the GUI. (optional) 
            var lastChangedDateTimeOffsetGreaterThan = 2023-09-07 08:46:00.1234567;  // DateTimeOffset | Find product groups that have been changed after this timestamp. (optional) 
            var names = 10, B1, A42;  // string | Filter by product group names. SearchString should be in the form of \"1, ABC, 10B\" (codes separated by comma). If filterString is null or whitespace, query is returned as is. (optional) 
            var type = (ProductType) "Product";  // ProductType | Filter product groups by product type. Available values: Product, Service (optional) 
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Get product groups from the client. (Auth roles: Product,Product_Full)
                List<ProductGroupDto> result = apiInstance.ProductGroupsGet(codes, createdDateTimeOffsetGreaterThan, isArchived, lastChangedDateTimeOffsetGreaterThan, names, type, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductGroupsApi.ProductGroupsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductGroupsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get product groups from the client. (Auth roles: Product,Product_Full)
    ApiResponse<List<ProductGroupDto>> response = apiInstance.ProductGroupsGetWithHttpInfo(codes, createdDateTimeOffsetGreaterThan, isArchived, lastChangedDateTimeOffsetGreaterThan, names, type, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductGroupsApi.ProductGroupsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **codes** | **string** | Filter by product group codes. SearchString should be in the form of \&quot;1, ABC, 10B\&quot; (codes separated by comma). If filterString is null or whitespace, query is returned as is. | [optional]  |
| **createdDateTimeOffsetGreaterThan** | **DateTimeOffset** | Find product groups created after this timestamp. | [optional]  |
| **isArchived** | **bool** | Gets a value indicating whether the product group is archived (set inactive). Archived product groups will be unavailable for usage in the GUI. | [optional]  |
| **lastChangedDateTimeOffsetGreaterThan** | **DateTimeOffset** | Find product groups that have been changed after this timestamp. | [optional]  |
| **names** | **string** | Filter by product group names. SearchString should be in the form of \&quot;1, ABC, 10B\&quot; (codes separated by comma). If filterString is null or whitespace, query is returned as is. | [optional]  |
| **type** | **ProductType** | Filter product groups by product type. Available values: Product, Service | [optional]  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;ProductGroupDto&gt;**](ProductGroupDto.md)

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

<a id="productgroupsiddelete"></a>
# **ProductGroupsIdDelete**
> void ProductGroupsIdDelete (long id)

Deletes a product group by ID. (Auth roles: Product_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class ProductGroupsIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ProductGroupsApi(config);
            var id = 12345;  // long | The id of the product group to delete.

            try
            {
                // Deletes a product group by ID. (Auth roles: Product_Full)
                apiInstance.ProductGroupsIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductGroupsApi.ProductGroupsIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductGroupsIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a product group by ID. (Auth roles: Product_Full)
    apiInstance.ProductGroupsIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductGroupsApi.ProductGroupsIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | The id of the product group to delete. |  |

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
| **200** | Given when product group is deleted |  -  |
| **404** | Given when resource was not found |  -  |
| **409** | Given when resource is in use and cannot be deleted |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="productgroupsidpatch"></a>
# **ProductGroupsIdPatch**
> ProductGroupDto ProductGroupsIdPatch (long id, List<Operation> operation = null)

Update an existing product group. (Auth roles: Product_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class ProductGroupsIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ProductGroupsApi(config);
            var id = 1337;  // long | 
            var operation = new List<Operation>(); // List<Operation> |  (optional) 

            try
            {
                // Update an existing product group. (Auth roles: Product_Full)
                ProductGroupDto result = apiInstance.ProductGroupsIdPatch(id, operation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductGroupsApi.ProductGroupsIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductGroupsIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an existing product group. (Auth roles: Product_Full)
    ApiResponse<ProductGroupDto> response = apiInstance.ProductGroupsIdPatchWithHttpInfo(id, operation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductGroupsApi.ProductGroupsIdPatchWithHttpInfo: " + e.Message);
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

[**ProductGroupDto**](ProductGroupDto.md)

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

<a id="productgroupspost"></a>
# **ProductGroupsPost**
> ProductGroupDto ProductGroupsPost (ProductGroupPostDto productGroupPostDto = null)

Create a new product group. (Auth roles: Product_Full)

The primary use of product groups are to assign products to the groups that can inherit similar properties from the group, and/or reporting purposes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class ProductGroupsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ProductGroupsApi(config);
            var productGroupPostDto = new ProductGroupPostDto(); // ProductGroupPostDto |  (optional) 

            try
            {
                // Create a new product group. (Auth roles: Product_Full)
                ProductGroupDto result = apiInstance.ProductGroupsPost(productGroupPostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductGroupsApi.ProductGroupsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductGroupsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new product group. (Auth roles: Product_Full)
    ApiResponse<ProductGroupDto> response = apiInstance.ProductGroupsPostWithHttpInfo(productGroupPostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductGroupsApi.ProductGroupsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productGroupPostDto** | [**ProductGroupPostDto**](ProductGroupPostDto.md) |  | [optional]  |

### Return type

[**ProductGroupDto**](ProductGroupDto.md)

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


# PowerOfficeGoV2.Api.ProductsApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetProductById**](ProductsApi.md#getproductbyid) | **GET** /Products/{id} | Get a product by its ID. (Auth roles: Product,Product_Full) |
| [**GetProducts**](ProductsApi.md#getproducts) | **GET** /Products | Get the products from the client. (Auth roles: Product,Product_Full) |
| [**ProductsIdDelete**](ProductsApi.md#productsiddelete) | **DELETE** /Products/{id} | Deletes a product by ID. (Auth roles: Product_Full) |
| [**ProductsIdPatch**](ProductsApi.md#productsidpatch) | **PATCH** /Products/{id} | Updates a product by ID. (Auth roles: Product_Full) |
| [**ProductsPost**](ProductsApi.md#productspost) | **POST** /Products | Creates a new product. (Auth roles: Product_Full) |

<a id="getproductbyid"></a>
# **GetProductById**
> ProductDto GetProductById (long id)

Get a product by its ID. (Auth roles: Product,Product_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetProductByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ProductsApi(config);
            var id = 1234;  // long | The id of a product

            try
            {
                // Get a product by its ID. (Auth roles: Product,Product_Full)
                ProductDto result = apiInstance.GetProductById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.GetProductById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProductByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a product by its ID. (Auth roles: Product,Product_Full)
    ApiResponse<ProductDto> response = apiInstance.GetProductByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductsApi.GetProductByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | The id of a product |  |

### Return type

[**ProductDto**](ProductDto.md)

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

<a id="getproducts"></a>
# **GetProducts**
> List&lt;ProductDto&gt; GetProducts (string codes = null, DateTime createdDateTimeOffsetGreaterThan = null, bool isArchived = null, DateTime lastChangedDateTimeOffsetGreaterThan = null, DateTime stockOnHandLastChangedDatetimeOffsetGreaterThan = null, string names = null, string productGroupCodes = null, ProductType type = null, ResourceParameters resourceParameter = null)

Get the products from the client. (Auth roles: Product,Product_Full)

The primary use of products are to set products on sales order lines, but the products can also be used as a general dimension og other transactions, for reporting purposes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetProductsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ProductsApi(config);
            var codes = 1, ABC, 10B;  // string | Filter by product group codes. Search string should be in the form of \"1, ABC, 10B\" (codes separated by comma). If filter string is null or whitespace, query is returned as is. (optional) 
            var createdDateTimeOffsetGreaterThan = 2023-07-03 14:28:00.1234567Z;  // DateTime | Find product groups created after this timestamp. (optional) 
            var isArchived = false;  // bool | Gets a value indicating whether the product is archived (set inactive). Archived products will be unavailable for usage in the GUI. (optional) 
            var lastChangedDateTimeOffsetGreaterThan = 2023-07-03 14:28:00.1234567Z;  // DateTime | Find products that have been changed after this timestamp. (optional) 
            var stockOnHandLastChangedDatetimeOffsetGreaterThan = 2023-07-03 14:28:00.1234567Z;  // DateTime | Find products that have stock on hand changed after this timestamp. (optional) 
            var names = iphone, galaxy, pixel;  // string | Filter by product name. Filter should be a comma separated string. (optional) 
            var productGroupCodes = 12315, 12345;  // string | Filter by product group codes. Search string should be in the form of \"12315, 12345, 22134\" (codes separated by comma). If filter string is null or whitespace, query is returned as is. (optional) 
            var type = service;  // ProductType | Filter products by type. Available values: Product, Service (optional) 
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Get the products from the client. (Auth roles: Product,Product_Full)
                List<ProductDto> result = apiInstance.GetProducts(codes, createdDateTimeOffsetGreaterThan, isArchived, lastChangedDateTimeOffsetGreaterThan, stockOnHandLastChangedDatetimeOffsetGreaterThan, names, productGroupCodes, type, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.GetProducts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProductsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the products from the client. (Auth roles: Product,Product_Full)
    ApiResponse<List<ProductDto>> response = apiInstance.GetProductsWithHttpInfo(codes, createdDateTimeOffsetGreaterThan, isArchived, lastChangedDateTimeOffsetGreaterThan, stockOnHandLastChangedDatetimeOffsetGreaterThan, names, productGroupCodes, type, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductsApi.GetProductsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **codes** | **string** | Filter by product group codes. Search string should be in the form of \&quot;1, ABC, 10B\&quot; (codes separated by comma). If filter string is null or whitespace, query is returned as is. | [optional]  |
| **createdDateTimeOffsetGreaterThan** | **DateTime** | Find product groups created after this timestamp. | [optional]  |
| **isArchived** | **bool** | Gets a value indicating whether the product is archived (set inactive). Archived products will be unavailable for usage in the GUI. | [optional]  |
| **lastChangedDateTimeOffsetGreaterThan** | **DateTime** | Find products that have been changed after this timestamp. | [optional]  |
| **stockOnHandLastChangedDatetimeOffsetGreaterThan** | **DateTime** | Find products that have stock on hand changed after this timestamp. | [optional]  |
| **names** | **string** | Filter by product name. Filter should be a comma separated string. | [optional]  |
| **productGroupCodes** | **string** | Filter by product group codes. Search string should be in the form of \&quot;12315, 12345, 22134\&quot; (codes separated by comma). If filter string is null or whitespace, query is returned as is. | [optional]  |
| **type** | **ProductType** | Filter products by type. Available values: Product, Service | [optional]  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;ProductDto&gt;**](ProductDto.md)

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

<a id="productsiddelete"></a>
# **ProductsIdDelete**
> void ProductsIdDelete (long id)

Deletes a product by ID. (Auth roles: Product_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class ProductsIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ProductsApi(config);
            var id = 12345;  // long | The id of the product to delete.

            try
            {
                // Deletes a product by ID. (Auth roles: Product_Full)
                apiInstance.ProductsIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.ProductsIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductsIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a product by ID. (Auth roles: Product_Full)
    apiInstance.ProductsIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductsApi.ProductsIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | The id of the product to delete. |  |

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
| **200** | Given when product is deleted |  -  |
| **404** | Given when resource was not found |  -  |
| **409** | Given when resource is in use and cannot be deleted |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="productsidpatch"></a>
# **ProductsIdPatch**
> ProductDto ProductsIdPatch (long id, List<Operation> operation = null)

Updates a product by ID. (Auth roles: Product_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class ProductsIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ProductsApi(config);
            var id = 789L;  // long | 
            var operation = new List<Operation>(); // List<Operation> |  (optional) 

            try
            {
                // Updates a product by ID. (Auth roles: Product_Full)
                ProductDto result = apiInstance.ProductsIdPatch(id, operation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.ProductsIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductsIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a product by ID. (Auth roles: Product_Full)
    ApiResponse<ProductDto> response = apiInstance.ProductsIdPatchWithHttpInfo(id, operation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductsApi.ProductsIdPatchWithHttpInfo: " + e.Message);
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

[**ProductDto**](ProductDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Given when product is updated |  -  |
| **400** | Given when request is badly formatted |  -  |
| **404** | Given when resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="productspost"></a>
# **ProductsPost**
> ProductDto ProductsPost (ProductPostDto productPostDto = null)

Creates a new product. (Auth roles: Product_Full)

The primary use of products are to set products on sales order lines, but the products can also be used as a general dimension og other transactions, for reporting purposes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class ProductsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ProductsApi(config);
            var productPostDto = new ProductPostDto(); // ProductPostDto |  (optional) 

            try
            {
                // Creates a new product. (Auth roles: Product_Full)
                ProductDto result = apiInstance.ProductsPost(productPostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.ProductsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new product. (Auth roles: Product_Full)
    ApiResponse<ProductDto> response = apiInstance.ProductsPostWithHttpInfo(productPostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductsApi.ProductsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productPostDto** | [**ProductPostDto**](ProductPostDto.md) |  | [optional]  |

### Return type

[**ProductDto**](ProductDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Given when resource returned successfully |  -  |
| **400** | Given when request is badly formatted |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


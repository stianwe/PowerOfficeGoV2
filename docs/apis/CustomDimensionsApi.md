# PowerOfficeGoV2.Api.CustomDimensionsApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CustomDimensionsIdDelete**](CustomDimensionsApi.md#customdimensionsiddelete) | **DELETE** /CustomDimensions/{id} | Delete a custom dimension. (Auth roles: CustomDimension_Full) |
| [**CustomDimensionsIdPatch**](CustomDimensionsApi.md#customdimensionsidpatch) | **PATCH** /CustomDimensions/{id} | Change an existing custom dimension with a given id. (Auth roles: CustomDimension_Full) |
| [**CustomDimensionsPost**](CustomDimensionsApi.md#customdimensionspost) | **POST** /CustomDimensions | Creates a new custom dimension within the given ordinal. (Auth roles: CustomDimension_Full) |
| [**GetCustomDimension**](CustomDimensionsApi.md#getcustomdimension) | **GET** /CustomDimensions | Gets the custom dimensions on the client. (Auth roles: CustomDimension,CustomDimension_Full) |
| [**GetCustomDimensionById**](CustomDimensionsApi.md#getcustomdimensionbyid) | **GET** /CustomDimensions/{id} | Gets a custom dimension by id. (Auth roles: CustomDimension,CustomDimension_Full) |

<a id="customdimensionsiddelete"></a>
# **CustomDimensionsIdDelete**
> void CustomDimensionsIdDelete (long id)

Delete a custom dimension. (Auth roles: CustomDimension_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class CustomDimensionsIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new CustomDimensionsApi(config);
            var id = 789L;  // long | The ID of the custom dimension.

            try
            {
                // Delete a custom dimension. (Auth roles: CustomDimension_Full)
                apiInstance.CustomDimensionsIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomDimensionsApi.CustomDimensionsIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CustomDimensionsIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a custom dimension. (Auth roles: CustomDimension_Full)
    apiInstance.CustomDimensionsIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomDimensionsApi.CustomDimensionsIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | The ID of the custom dimension. |  |

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
| **200** | Given when resource was successfully deleted |  -  |
| **404** | Given when the resource was not found |  -  |
| **409** | Given when resource is in use and cannot be deleted |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="customdimensionsidpatch"></a>
# **CustomDimensionsIdPatch**
> CustomDimensionDto CustomDimensionsIdPatch (long id, List<Operation> operation = null)

Change an existing custom dimension with a given id. (Auth roles: CustomDimension_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class CustomDimensionsIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new CustomDimensionsApi(config);
            var id = 789L;  // long | Id of the custom dimension to be updated.
            var operation = new List<Operation>(); // List<Operation> | A JsonPatchDocument with the update information. (optional) 

            try
            {
                // Change an existing custom dimension with a given id. (Auth roles: CustomDimension_Full)
                CustomDimensionDto result = apiInstance.CustomDimensionsIdPatch(id, operation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomDimensionsApi.CustomDimensionsIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CustomDimensionsIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change an existing custom dimension with a given id. (Auth roles: CustomDimension_Full)
    ApiResponse<CustomDimensionDto> response = apiInstance.CustomDimensionsIdPatchWithHttpInfo(id, operation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomDimensionsApi.CustomDimensionsIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Id of the custom dimension to be updated. |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) | A JsonPatchDocument with the update information. | [optional]  |

### Return type

[**CustomDimensionDto**](CustomDimensionDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Given when resource was successfully updated |  -  |
| **400** | Given when request was badly formatted |  -  |
| **404** | Given when resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="customdimensionspost"></a>
# **CustomDimensionsPost**
> CustomDimensionDto CustomDimensionsPost (CustomDimensionPostDto customDimensionPostDto = null)

Creates a new custom dimension within the given ordinal. (Auth roles: CustomDimension_Full)

Name and Ordinal required.  The ordinal define whether the object instance is created within the dim1, dim2 or dim3 set.  Code must be unique within an ordinal. If code is not provided, it will be automatically assigned by Go.  IsActive defaults to true, if not provided.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class CustomDimensionsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new CustomDimensionsApi(config);
            var customDimensionPostDto = new CustomDimensionPostDto(); // CustomDimensionPostDto |  (optional) 

            try
            {
                // Creates a new custom dimension within the given ordinal. (Auth roles: CustomDimension_Full)
                CustomDimensionDto result = apiInstance.CustomDimensionsPost(customDimensionPostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomDimensionsApi.CustomDimensionsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CustomDimensionsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new custom dimension within the given ordinal. (Auth roles: CustomDimension_Full)
    ApiResponse<CustomDimensionDto> response = apiInstance.CustomDimensionsPostWithHttpInfo(customDimensionPostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomDimensionsApi.CustomDimensionsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **customDimensionPostDto** | [**CustomDimensionPostDto**](CustomDimensionPostDto.md) |  | [optional]  |

### Return type

[**CustomDimensionDto**](CustomDimensionDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Given when resource was created successfully |  -  |
| **400** | Given when request is badly formatted |  -  |
| **404** | Given when resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getcustomdimension"></a>
# **GetCustomDimension**
> List&lt;CustomDimensionDto&gt; GetCustomDimension (string codes = null, DateTime createdDateTimeOffsetGreaterThan = null, string ordinal = null, string externalImportReference = null, DateTime lastChangedDateTimeOffsetGreaterThan = null, ResourceParameters resourceParameter = null)

Gets the custom dimensions on the client. (Auth roles: CustomDimension,CustomDimension_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetCustomDimensionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new CustomDimensionsApi(config);
            var codes = 1, ABC, 10B;  // string | Filter by custom dimension codes. Search string should be in the form of 1, ABC, 10B (codes separated by comma).                  If filter string is null or whitespace, query is returned as is. Note that the codes are not unique across dim1-dim3,                  meaning that you might potentially get 3 objects returned if the code you filter on are used on all custom dimensions.                  Filter on the dimension ordinal to return values for only one of the custom dimensions. (optional) 
            var createdDateTimeOffsetGreaterThan = 2021-09-25 08:03:00;  // DateTime | Filter on the created date property.                  This filtering will return all custom dimensions with a created date greater than the timestamp provided.                  Can be used when polling for new custom dimensions from Go. Blank means no filter. Date not inclusive, and in UTC time. (optional) 
            var ordinal = 1;  // string | Filter on the custom dimension ordinal (i.e. 1=dim1, 2=dim2 or 3=dim3), returning only values within the specific custom dimension ordinal. (optional) 
            var externalImportReference = ABC123, DEF456;  // string | Filter by external import references. Search string should be in the form of 1, ABC, 10B (codes separated by comma). (optional) 
            var lastChangedDateTimeOffsetGreaterThan = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Filter on the last change date property.                  This filtering will return all custom dimension objects with a last changed date greater than the timestamp provided.                  Can be used when polling for new or changed custom dimension objects from Go. Blank means no filter. Date not inclusive, and in UTC time. (optional) 
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Gets the custom dimensions on the client. (Auth roles: CustomDimension,CustomDimension_Full)
                List<CustomDimensionDto> result = apiInstance.GetCustomDimension(codes, createdDateTimeOffsetGreaterThan, ordinal, externalImportReference, lastChangedDateTimeOffsetGreaterThan, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomDimensionsApi.GetCustomDimension: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCustomDimensionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the custom dimensions on the client. (Auth roles: CustomDimension,CustomDimension_Full)
    ApiResponse<List<CustomDimensionDto>> response = apiInstance.GetCustomDimensionWithHttpInfo(codes, createdDateTimeOffsetGreaterThan, ordinal, externalImportReference, lastChangedDateTimeOffsetGreaterThan, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomDimensionsApi.GetCustomDimensionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **codes** | **string** | Filter by custom dimension codes. Search string should be in the form of 1, ABC, 10B (codes separated by comma).                  If filter string is null or whitespace, query is returned as is. Note that the codes are not unique across dim1-dim3,                  meaning that you might potentially get 3 objects returned if the code you filter on are used on all custom dimensions.                  Filter on the dimension ordinal to return values for only one of the custom dimensions. | [optional]  |
| **createdDateTimeOffsetGreaterThan** | **DateTime** | Filter on the created date property.                  This filtering will return all custom dimensions with a created date greater than the timestamp provided.                  Can be used when polling for new custom dimensions from Go. Blank means no filter. Date not inclusive, and in UTC time. | [optional]  |
| **ordinal** | **string** | Filter on the custom dimension ordinal (i.e. 1&#x3D;dim1, 2&#x3D;dim2 or 3&#x3D;dim3), returning only values within the specific custom dimension ordinal. | [optional]  |
| **externalImportReference** | **string** | Filter by external import references. Search string should be in the form of 1, ABC, 10B (codes separated by comma). | [optional]  |
| **lastChangedDateTimeOffsetGreaterThan** | **DateTime** | Filter on the last change date property.                  This filtering will return all custom dimension objects with a last changed date greater than the timestamp provided.                  Can be used when polling for new or changed custom dimension objects from Go. Blank means no filter. Date not inclusive, and in UTC time. | [optional]  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;CustomDimensionDto&gt;**](CustomDimensionDto.md)

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

<a id="getcustomdimensionbyid"></a>
# **GetCustomDimensionById**
> CustomDimensionDto GetCustomDimensionById (long id)

Gets a custom dimension by id. (Auth roles: CustomDimension,CustomDimension_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetCustomDimensionByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new CustomDimensionsApi(config);
            var id = 789L;  // long | The ID of a custom dimension.

            try
            {
                // Gets a custom dimension by id. (Auth roles: CustomDimension,CustomDimension_Full)
                CustomDimensionDto result = apiInstance.GetCustomDimensionById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomDimensionsApi.GetCustomDimensionById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCustomDimensionByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a custom dimension by id. (Auth roles: CustomDimension,CustomDimension_Full)
    ApiResponse<CustomDimensionDto> response = apiInstance.GetCustomDimensionByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomDimensionsApi.GetCustomDimensionByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | The ID of a custom dimension. |  |

### Return type

[**CustomDimensionDto**](CustomDimensionDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
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


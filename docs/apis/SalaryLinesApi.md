# PowerOfficeGoV2.Api.SalaryLinesApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetSalaryLineById**](SalaryLinesApi.md#getsalarylinebyid) | **GET** /SalaryLines/{id} | Get a specific salary line by id. (Auth roles: SalaryLine,SalaryLine_Full) |
| [**SalaryLinesGet**](SalaryLinesApi.md#salarylinesget) | **GET** /SalaryLines | Get salary lines from the client. (Auth roles: SalaryLine,SalaryLine_Full) |
| [**SalaryLinesIdDelete**](SalaryLinesApi.md#salarylinesiddelete) | **DELETE** /SalaryLines/{id} | Delete a salary line with a given id. (Auth roles: SalaryLine_Full) |
| [**SalaryLinesIdPatch**](SalaryLinesApi.md#salarylinesidpatch) | **PATCH** /SalaryLines/{id} | Change an existing salary line with a given id. (Auth roles: SalaryLine_Full) |
| [**SalaryLinesPost**](SalaryLinesApi.md#salarylinespost) | **POST** /SalaryLines | Create a new salary line. (Auth roles: SalaryLine_Full) |

<a id="getsalarylinebyid"></a>
# **GetSalaryLineById**
> SalaryLineDto GetSalaryLineById (long id)

Get a specific salary line by id. (Auth roles: SalaryLine,SalaryLine_Full)

Will only return the salary line if the integration created the salary line.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetSalaryLineByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new SalaryLinesApi(config);
            var id = 12345;  // long | The id of the salary line.

            try
            {
                // Get a specific salary line by id. (Auth roles: SalaryLine,SalaryLine_Full)
                SalaryLineDto result = apiInstance.GetSalaryLineById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalaryLinesApi.GetSalaryLineById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSalaryLineByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a specific salary line by id. (Auth roles: SalaryLine,SalaryLine_Full)
    ApiResponse<SalaryLineDto> response = apiInstance.GetSalaryLineByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalaryLinesApi.GetSalaryLineByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | The id of the salary line. |  |

### Return type

[**SalaryLineDto**](SalaryLineDto.md)

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

<a id="salarylinesget"></a>
# **SalaryLinesGet**
> List&lt;SalaryLineDto&gt; SalaryLinesGet (ResourceParameters resourceParameter = null)

Get salary lines from the client. (Auth roles: SalaryLine,SalaryLine_Full)

Will only return salary lines that the integration has created.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class SalaryLinesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new SalaryLinesApi(config);
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Get salary lines from the client. (Auth roles: SalaryLine,SalaryLine_Full)
                List<SalaryLineDto> result = apiInstance.SalaryLinesGet(resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalaryLinesApi.SalaryLinesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SalaryLinesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get salary lines from the client. (Auth roles: SalaryLine,SalaryLine_Full)
    ApiResponse<List<SalaryLineDto>> response = apiInstance.SalaryLinesGetWithHttpInfo(resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalaryLinesApi.SalaryLinesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;SalaryLineDto&gt;**](SalaryLineDto.md)

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
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="salarylinesiddelete"></a>
# **SalaryLinesIdDelete**
> void SalaryLinesIdDelete (long id)

Delete a salary line with a given id. (Auth roles: SalaryLine_Full)

Can only be done if the integration created the salary line, and the line is not locked (isLocked must be false).  Will (hard) delete the salary line from the client.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class SalaryLinesIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new SalaryLinesApi(config);
            var id = 12345;  // long | The id of the salary line to delete.

            try
            {
                // Delete a salary line with a given id. (Auth roles: SalaryLine_Full)
                apiInstance.SalaryLinesIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalaryLinesApi.SalaryLinesIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SalaryLinesIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a salary line with a given id. (Auth roles: SalaryLine_Full)
    apiInstance.SalaryLinesIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalaryLinesApi.SalaryLinesIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | The id of the salary line to delete. |  |

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
| **200** | Given when salary line is deleted |  -  |
| **404** | Given when resource was not found |  -  |
| **409** | Given when resource is in use and cannot be deleted |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="salarylinesidpatch"></a>
# **SalaryLinesIdPatch**
> SalaryLineDto SalaryLinesIdPatch (long id, List<Operation> operation = null)

Change an existing salary line with a given id. (Auth roles: SalaryLine_Full)

Only salary lines that the integration has created can be changed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class SalaryLinesIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new SalaryLinesApi(config);
            var id = 12345;  // long | The id of the salary line.
            var operation = new List<Operation>(); // List<Operation> | JSON Patch structure for updating a salary line. See SalaryLinePatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 (optional) 

            try
            {
                // Change an existing salary line with a given id. (Auth roles: SalaryLine_Full)
                SalaryLineDto result = apiInstance.SalaryLinesIdPatch(id, operation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalaryLinesApi.SalaryLinesIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SalaryLinesIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change an existing salary line with a given id. (Auth roles: SalaryLine_Full)
    ApiResponse<SalaryLineDto> response = apiInstance.SalaryLinesIdPatchWithHttpInfo(id, operation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalaryLinesApi.SalaryLinesIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | The id of the salary line. |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) | JSON Patch structure for updating a salary line. See SalaryLinePatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 | [optional]  |

### Return type

[**SalaryLineDto**](SalaryLineDto.md)

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

<a id="salarylinespost"></a>
# **SalaryLinesPost**
> SalaryLineDto SalaryLinesPost (SalaryLinePostDto salaryLinePostDto = null)

Create a new salary line. (Auth roles: SalaryLine_Full)

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
    public class SalaryLinesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new SalaryLinesApi(config);
            var salaryLinePostDto = new SalaryLinePostDto(); // SalaryLinePostDto |  (optional) 

            try
            {
                // Create a new salary line. (Auth roles: SalaryLine_Full)
                SalaryLineDto result = apiInstance.SalaryLinesPost(salaryLinePostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalaryLinesApi.SalaryLinesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SalaryLinesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new salary line. (Auth roles: SalaryLine_Full)
    ApiResponse<SalaryLineDto> response = apiInstance.SalaryLinesPostWithHttpInfo(salaryLinePostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalaryLinesApi.SalaryLinesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **salaryLinePostDto** | [**SalaryLinePostDto**](SalaryLinePostDto.md) |  | [optional]  |

### Return type

[**SalaryLineDto**](SalaryLineDto.md)

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


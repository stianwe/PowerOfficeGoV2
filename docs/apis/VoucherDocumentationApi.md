# PowerOfficeGoV2.Api.VoucherDocumentationApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddVoucherDocumentation**](VoucherDocumentationApi.md#addvoucherdocumentation) | **PUT** /VoucherDocumentation | Replace the documentation on a posted voucher (Auth roles: VoucherDocumentation_Full) |
| [**GetVoucherDocumentation**](VoucherDocumentationApi.md#getvoucherdocumentation) | **GET** /VoucherDocumentation/Download | Get voucher documentation files as single zip file. (Auth roles: VoucherDocumentation,VoucherDocumentation_Full) |
| [**VoucherDocumentationGet**](VoucherDocumentationApi.md#voucherdocumentationget) | **GET** /VoucherDocumentation | Get voucher documentation list. (Auth roles: VoucherDocumentation,VoucherDocumentation_Full) |

<a id="addvoucherdocumentation"></a>
# **AddVoucherDocumentation**
> void AddVoucherDocumentation (Guid id, System.IO.Stream file = null)

Replace the documentation on a posted voucher (Auth roles: VoucherDocumentation_Full)

The voucher must have been imported by the API to be able to insert documentation with this service.  It is only possible to import PDF file. The max file size is 30Mb.  It is possible to import several times. The last import will replace the previous import.  Replacements can only be done by the same integration that imported the previous file.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class AddVoucherDocumentationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new VoucherDocumentationApi(config);
            var id = "id_example";  // Guid | Identifier of the voucher the documentation should be attached to.
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 

            try
            {
                // Replace the documentation on a posted voucher (Auth roles: VoucherDocumentation_Full)
                apiInstance.AddVoucherDocumentation(id, file);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VoucherDocumentationApi.AddVoucherDocumentation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddVoucherDocumentationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Replace the documentation on a posted voucher (Auth roles: VoucherDocumentation_Full)
    apiInstance.AddVoucherDocumentationWithHttpInfo(id, file);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VoucherDocumentationApi.AddVoucherDocumentationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Identifier of the voucher the documentation should be attached to. |  |
| **file** | **System.IO.Stream****System.IO.Stream** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |
| **204** | No Content |  -  |
| **400** | Bad Request |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getvoucherdocumentation"></a>
# **GetVoucherDocumentation**
> void GetVoucherDocumentation (Guid id, VoucherDocumentationType documentationType = null)

Get voucher documentation files as single zip file. (Auth roles: VoucherDocumentation,VoucherDocumentation_Full)

The available VoucherDocumentationType is listed in the GET VoucherDocumentation endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetVoucherDocumentationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new VoucherDocumentationApi(config);
            var id = f1e93414-0495-4121-b69f-4ddc99e67ce1;  // Guid | Voucher identifier
            var documentationType = Images;  // VoucherDocumentationType | The type of documentation. (optional) 

            try
            {
                // Get voucher documentation files as single zip file. (Auth roles: VoucherDocumentation,VoucherDocumentation_Full)
                apiInstance.GetVoucherDocumentation(id, documentationType);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VoucherDocumentationApi.GetVoucherDocumentation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVoucherDocumentationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get voucher documentation files as single zip file. (Auth roles: VoucherDocumentation,VoucherDocumentation_Full)
    apiInstance.GetVoucherDocumentationWithHttpInfo(id, documentationType);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VoucherDocumentationApi.GetVoucherDocumentationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Voucher identifier |  |
| **documentationType** | **VoucherDocumentationType** | The type of documentation. | [optional]  |

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
| **204** | Given when there is no content to return (response body is empty) |  -  |
| **400** | Given when request is badly formatted |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="voucherdocumentationget"></a>
# **VoucherDocumentationGet**
> List&lt;VoucherDocumentationDto&gt; VoucherDocumentationGet (Guid id = null, long voucherNo = null, ResourceParameters resourceParameter = null)

Get voucher documentation list. (Auth roles: VoucherDocumentation,VoucherDocumentation_Full)

Get a list of vouchers and the available filetypes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class VoucherDocumentationGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new VoucherDocumentationApi(config);
            var id = "id_example";  // Guid | Voucher identifier (optional) 
            var voucherNo = 789L;  // long | Voucher number (optional) 
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Get voucher documentation list. (Auth roles: VoucherDocumentation,VoucherDocumentation_Full)
                List<VoucherDocumentationDto> result = apiInstance.VoucherDocumentationGet(id, voucherNo, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VoucherDocumentationApi.VoucherDocumentationGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VoucherDocumentationGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get voucher documentation list. (Auth roles: VoucherDocumentation,VoucherDocumentation_Full)
    ApiResponse<List<VoucherDocumentationDto>> response = apiInstance.VoucherDocumentationGetWithHttpInfo(id, voucherNo, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VoucherDocumentationApi.VoucherDocumentationGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Voucher identifier | [optional]  |
| **voucherNo** | **long** | Voucher number | [optional]  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;VoucherDocumentationDto&gt;**](VoucherDocumentationDto.md)

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


# PowerOfficeGoV2.Api.CustomDimensionSettingsApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CustomDimensionSettingsGet**](CustomDimensionSettingsApi.md#customdimensionsettingsget) | **GET** /CustomDimensionSettings | Gets the custom dimensions settings from the client (Auth roles: CustomDimension,CustomDimension_Full) |

<a id="customdimensionsettingsget"></a>
# **CustomDimensionSettingsGet**
> List&lt;CustomDimensionSettingsDto&gt; CustomDimensionSettingsGet ()

Gets the custom dimensions settings from the client (Auth roles: CustomDimension,CustomDimension_Full)

Gets the custom dimension settings on the client, providing the ordinal name and active state of the dim1-dim3 from the client.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class CustomDimensionSettingsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new CustomDimensionSettingsApi(config);

            try
            {
                // Gets the custom dimensions settings from the client (Auth roles: CustomDimension,CustomDimension_Full)
                List<CustomDimensionSettingsDto> result = apiInstance.CustomDimensionSettingsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomDimensionSettingsApi.CustomDimensionSettingsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CustomDimensionSettingsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the custom dimensions settings from the client (Auth roles: CustomDimension,CustomDimension_Full)
    ApiResponse<List<CustomDimensionSettingsDto>> response = apiInstance.CustomDimensionSettingsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomDimensionSettingsApi.CustomDimensionSettingsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;CustomDimensionSettingsDto&gt;**](CustomDimensionSettingsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Given when resource returned successfully |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


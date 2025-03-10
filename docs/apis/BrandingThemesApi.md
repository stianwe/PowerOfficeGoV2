# PowerOfficeGoV2.Api.BrandingThemesApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BrandingThemesGet**](BrandingThemesApi.md#brandingthemesget) | **GET** /BrandingThemes | List the branding themes available on the client. (Auth roles: CommonServices,CommonServices_Full) |
| [**GetBrandingThemeById**](BrandingThemesApi.md#getbrandingthemebyid) | **GET** /BrandingThemes/{id} | Gets the specified branding theme by its id. (Auth roles: CommonServices,CommonServices_Full) |

<a id="brandingthemesget"></a>
# **BrandingThemesGet**
> List&lt;BrandingThemeDto&gt; BrandingThemesGet (ResourceParameters resourceParameter = null)

List the branding themes available on the client. (Auth roles: CommonServices,CommonServices_Full)

Get the branding themes available on the client.  Go provides a default set of branding themes on new clients, but any custom branding theme can be created and used on customers, projects and sales orders created in Go.  Branding themes hold a set of templates for various documents, such as invoices, reminders, quotes etc.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class BrandingThemesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new BrandingThemesApi(config);
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // List the branding themes available on the client. (Auth roles: CommonServices,CommonServices_Full)
                List<BrandingThemeDto> result = apiInstance.BrandingThemesGet(resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandingThemesApi.BrandingThemesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BrandingThemesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List the branding themes available on the client. (Auth roles: CommonServices,CommonServices_Full)
    ApiResponse<List<BrandingThemeDto>> response = apiInstance.BrandingThemesGetWithHttpInfo(resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BrandingThemesApi.BrandingThemesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;BrandingThemeDto&gt;**](BrandingThemeDto.md)

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

<a id="getbrandingthemebyid"></a>
# **GetBrandingThemeById**
> BrandingThemeDto GetBrandingThemeById (long id)

Gets the specified branding theme by its id. (Auth roles: CommonServices,CommonServices_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetBrandingThemeByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new BrandingThemesApi(config);
            var id = 12345;  // long | The id of the branding theme.

            try
            {
                // Gets the specified branding theme by its id. (Auth roles: CommonServices,CommonServices_Full)
                BrandingThemeDto result = apiInstance.GetBrandingThemeById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BrandingThemesApi.GetBrandingThemeById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBrandingThemeByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the specified branding theme by its id. (Auth roles: CommonServices,CommonServices_Full)
    ApiResponse<BrandingThemeDto> response = apiInstance.GetBrandingThemeByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BrandingThemesApi.GetBrandingThemeByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | The id of the branding theme. |  |

### Return type

[**BrandingThemeDto**](BrandingThemeDto.md)

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


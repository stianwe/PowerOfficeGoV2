# PowerOfficeGoV2.Api.VatCodesApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**VatCodesGet**](VatCodesApi.md#vatcodesget) | **GET** /VatCodes | Gets the vat codes on the client. (Auth roles: CommonServices,CommonServices_Full) |

<a id="vatcodesget"></a>
# **VatCodesGet**
> List&lt;VatCodeDto&gt; VatCodesGet (bool includeExpired = null, bool isActive = null, ResourceParameters resourceParameter = null)

Gets the vat codes on the client. (Auth roles: CommonServices,CommonServices_Full)

Gets the SAF-T vat codes and any custom codes set on the client.  Custom codes will have a prefix with the letter 'C', and will be based on the SAF-T codes, but used if the client have mixed vat conditions, for instance.  Compensation codes has a prefix with the letter 'K'.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class VatCodesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new VatCodesApi(config);
            var includeExpired = true;  // bool | Include expired VAT codes. Expired codes has a ValidTo date and can still be used for accounting events in the validFrom - validTo timeframe as long as it is active. (optional) 
            var isActive = false;  // bool | Returns both active and inactive codes as default. True returns active codes, False returns only inactive codes. (optional) 
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Gets the vat codes on the client. (Auth roles: CommonServices,CommonServices_Full)
                List<VatCodeDto> result = apiInstance.VatCodesGet(includeExpired, isActive, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VatCodesApi.VatCodesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VatCodesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the vat codes on the client. (Auth roles: CommonServices,CommonServices_Full)
    ApiResponse<List<VatCodeDto>> response = apiInstance.VatCodesGetWithHttpInfo(includeExpired, isActive, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VatCodesApi.VatCodesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **includeExpired** | **bool** | Include expired VAT codes. Expired codes has a ValidTo date and can still be used for accounting events in the validFrom - validTo timeframe as long as it is active. | [optional]  |
| **isActive** | **bool** | Returns both active and inactive codes as default. True returns active codes, False returns only inactive codes. | [optional]  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;VatCodeDto&gt;**](VatCodeDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Given when resource returned successfully. |  -  |
| **204** | Given when request returns an empty response. |  -  |
| **400** | Given when request is badly formatted. |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


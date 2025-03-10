# PowerOfficeGoV2.Api.CurrenciesApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CurrenciesGet**](CurrenciesApi.md#currenciesget) | **GET** /Currencies | Gets the currencies set on the client. (Auth roles: CommonServices,CommonServices_Full) |

<a id="currenciesget"></a>
# **CurrenciesGet**
> List&lt;CurrencyDto&gt; CurrenciesGet (string currencyCode = null, bool isActive = null, ResourceParameters resourceParameter = null)

Gets the currencies set on the client. (Auth roles: CommonServices,CommonServices_Full)

Gets a list of all currencies available in Go.  The currencies in active use on the client has the property IsActive = true.  Active currencies can be used in GUI operations in Go, but does not affect which currencies that can be used when  posting transactions using the APIs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class CurrenciesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new CurrenciesApi(config);
            var currencyCode = NOK;  // string | Filter by currency code. (optional) 
            var isActive = true;  // bool | Filter by isActive parameter.. (optional) 
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Gets the currencies set on the client. (Auth roles: CommonServices,CommonServices_Full)
                List<CurrencyDto> result = apiInstance.CurrenciesGet(currencyCode, isActive, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CurrenciesApi.CurrenciesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CurrenciesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the currencies set on the client. (Auth roles: CommonServices,CommonServices_Full)
    ApiResponse<List<CurrencyDto>> response = apiInstance.CurrenciesGetWithHttpInfo(currencyCode, isActive, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CurrenciesApi.CurrenciesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **currencyCode** | **string** | Filter by currency code. | [optional]  |
| **isActive** | **bool** | Filter by isActive parameter.. | [optional]  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;CurrencyDto&gt;**](CurrencyDto.md)

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


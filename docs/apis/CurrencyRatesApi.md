# PowerOfficeGoV2.Api.CurrencyRatesApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CurrencyRatesGet**](CurrencyRatesApi.md#currencyratesget) | **GET** /CurrencyRates | Get currency rate. (Auth roles: CommonServices,CommonServices_Full) |

<a id="currencyratesget"></a>
# **CurrencyRatesGet**
> CurrencyRateDto CurrencyRatesGet (string fromCurrency, string toCurrency, DateTimeOffset asOnDate)

Get currency rate. (Auth roles: CommonServices,CommonServices_Full)

Get a currency exchange rate between two currencies for a given date.  Currency rate for a future date is not available, and will return the newest available rate.  The rates are updated daily around 1600 CET.  Rates originate from European Central Bank [https://data.ecb.europa.eu/currency-converter]

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class CurrencyRatesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new CurrencyRatesApi(config);
            var fromCurrency = "fromCurrency_example";  // string | 
            var toCurrency = "toCurrency_example";  // string | 
            var asOnDate = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset | 

            try
            {
                // Get currency rate. (Auth roles: CommonServices,CommonServices_Full)
                CurrencyRateDto result = apiInstance.CurrencyRatesGet(fromCurrency, toCurrency, asOnDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CurrencyRatesApi.CurrencyRatesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CurrencyRatesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get currency rate. (Auth roles: CommonServices,CommonServices_Full)
    ApiResponse<CurrencyRateDto> response = apiInstance.CurrencyRatesGetWithHttpInfo(fromCurrency, toCurrency, asOnDate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CurrencyRatesApi.CurrencyRatesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fromCurrency** | **string** |  |  |
| **toCurrency** | **string** |  |  |
| **asOnDate** | **DateTimeOffset** |  |  |

### Return type

[**CurrencyRateDto**](CurrencyRateDto.md)

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
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


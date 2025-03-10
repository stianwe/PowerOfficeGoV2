# PowerOfficeGoV2.Api.EnterprisesApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EnterprisesGet**](EnterprisesApi.md#enterprisesget) | **GET** /Enterprises | Get the enterprises registered for the client. Enterprises are primarily used for payroll reporting in Go.  A company may have more than one enterprise if the company have operations in different industries. (Auth roles: Enterprises,Enterprises_Full) |

<a id="enterprisesget"></a>
# **EnterprisesGet**
> List&lt;EnterpriseDto&gt; EnterprisesGet (string enterpriseNos = null, DateTime createdDateTimeOffsetGreaterThan = null, DateTime lastChangedDateTimeOffsetGreaterThan = null, ResourceParameters resourceParameter = null)

Get the enterprises registered for the client. Enterprises are primarily used for payroll reporting in Go.  A company may have more than one enterprise if the company have operations in different industries. (Auth roles: Enterprises,Enterprises_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class EnterprisesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EnterprisesApi(config);
            var enterpriseNos = 980858073, 980858074;  // string | Filter by enterprise number. Search string should be separated by comma. If filter string is null or whitespace, query is returned as is. (optional) 
            var createdDateTimeOffsetGreaterThan = 2024-08-26T11:05:00.1234567Z;  // DateTime | Filter by the enterprise created timestamp property. This filtering will return all enterprises with a created timestamp greater than the timestamp provided. Can be used when polling for new entries from Go. Timestamp not inclusive. (optional) 
            var lastChangedDateTimeOffsetGreaterThan = 2023-08-27T10:14:00.1234567Z;  // DateTime | Filter by the enterprise last changed timestamp property. This filtering will return all enterprises with a last changed timestamp greater than the timestamp provided. Timestamp not inclusive. (optional) 
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Get the enterprises registered for the client. Enterprises are primarily used for payroll reporting in Go.  A company may have more than one enterprise if the company have operations in different industries. (Auth roles: Enterprises,Enterprises_Full)
                List<EnterpriseDto> result = apiInstance.EnterprisesGet(enterpriseNos, createdDateTimeOffsetGreaterThan, lastChangedDateTimeOffsetGreaterThan, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EnterprisesApi.EnterprisesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EnterprisesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the enterprises registered for the client. Enterprises are primarily used for payroll reporting in Go.  A company may have more than one enterprise if the company have operations in different industries. (Auth roles: Enterprises,Enterprises_Full)
    ApiResponse<List<EnterpriseDto>> response = apiInstance.EnterprisesGetWithHttpInfo(enterpriseNos, createdDateTimeOffsetGreaterThan, lastChangedDateTimeOffsetGreaterThan, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EnterprisesApi.EnterprisesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **enterpriseNos** | **string** | Filter by enterprise number. Search string should be separated by comma. If filter string is null or whitespace, query is returned as is. | [optional]  |
| **createdDateTimeOffsetGreaterThan** | **DateTime** | Filter by the enterprise created timestamp property. This filtering will return all enterprises with a created timestamp greater than the timestamp provided. Can be used when polling for new entries from Go. Timestamp not inclusive. | [optional]  |
| **lastChangedDateTimeOffsetGreaterThan** | **DateTime** | Filter by the enterprise last changed timestamp property. This filtering will return all enterprises with a last changed timestamp greater than the timestamp provided. Timestamp not inclusive. | [optional]  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;EnterpriseDto&gt;**](EnterpriseDto.md)

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
| **404** | Given when resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


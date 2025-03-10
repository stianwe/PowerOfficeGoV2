# PowerOfficeGoV2.Api.AssignmentsApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AssignmentsGet**](AssignmentsApi.md#assignmentsget) | **GET** /Assignments | List the quality assignments from the client, returning lightweight objects. (Auth roles: QualityAssignmentLight,QualityAssignmentLight_Full) |
| [**AssignmentsIdGet**](AssignmentsApi.md#assignmentsidget) | **GET** /Assignments/{id} | Get the general information from a given quality assignment (Auth roles: QualityAssignmentGeneral,QualityAssignmentGeneral_Full, QualityAssignmentLight,QualityAssignmentLight_Full) |

<a id="assignmentsget"></a>
# **AssignmentsGet**
> List&lt;AssignmentLightWeightDto&gt; AssignmentsGet (string status = null, string customerSubLedgerAccountIds = null, string managerSubLedgerAccountIds = null, ResourceParameters resourceParameter = null)

List the quality assignments from the client, returning lightweight objects. (Auth roles: QualityAssignmentLight,QualityAssignmentLight_Full)

Archived assignments are not returned by default.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class AssignmentsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new AssignmentsApi(config);
            var status = draft;  // string | Filter by assignment status (draft, active or archived). Archived assignments are not returned unless the filter with argument \"archived\" is applied. (optional) 
            var customerSubLedgerAccountIds = 12345,12357;  // string | Filter by customer sub ledger account id's. Separate by comma [,] to filter on multiple customer id's. (optional) 
            var managerSubLedgerAccountIds = 12345,12357;  // string | Filter by the identifier of the assignment manager. Separate by comma [,] to filter on multiple customer id's. (optional) 
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // List the quality assignments from the client, returning lightweight objects. (Auth roles: QualityAssignmentLight,QualityAssignmentLight_Full)
                List<AssignmentLightWeightDto> result = apiInstance.AssignmentsGet(status, customerSubLedgerAccountIds, managerSubLedgerAccountIds, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssignmentsApi.AssignmentsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssignmentsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List the quality assignments from the client, returning lightweight objects. (Auth roles: QualityAssignmentLight,QualityAssignmentLight_Full)
    ApiResponse<List<AssignmentLightWeightDto>> response = apiInstance.AssignmentsGetWithHttpInfo(status, customerSubLedgerAccountIds, managerSubLedgerAccountIds, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssignmentsApi.AssignmentsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **status** | **string** | Filter by assignment status (draft, active or archived). Archived assignments are not returned unless the filter with argument \&quot;archived\&quot; is applied. | [optional]  |
| **customerSubLedgerAccountIds** | **string** | Filter by customer sub ledger account id&#39;s. Separate by comma [,] to filter on multiple customer id&#39;s. | [optional]  |
| **managerSubLedgerAccountIds** | **string** | Filter by the identifier of the assignment manager. Separate by comma [,] to filter on multiple customer id&#39;s. | [optional]  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;AssignmentLightWeightDto&gt;**](AssignmentLightWeightDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Given when resource returned successfully |  -  |
| **204** | Given when no content was returned |  -  |
| **400** | Bad Request |  -  |
| **404** | Given when resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="assignmentsidget"></a>
# **AssignmentsIdGet**
> AssignmentGeneralDto AssignmentsIdGet (long id)

Get the general information from a given quality assignment (Auth roles: QualityAssignmentGeneral,QualityAssignmentGeneral_Full, QualityAssignmentLight,QualityAssignmentLight_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class AssignmentsIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new AssignmentsApi(config);
            var id = 123456;  // long | Identifier of the assignment

            try
            {
                // Get the general information from a given quality assignment (Auth roles: QualityAssignmentGeneral,QualityAssignmentGeneral_Full, QualityAssignmentLight,QualityAssignmentLight_Full)
                AssignmentGeneralDto result = apiInstance.AssignmentsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssignmentsApi.AssignmentsIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssignmentsIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the general information from a given quality assignment (Auth roles: QualityAssignmentGeneral,QualityAssignmentGeneral_Full, QualityAssignmentLight,QualityAssignmentLight_Full)
    ApiResponse<AssignmentGeneralDto> response = apiInstance.AssignmentsIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssignmentsApi.AssignmentsIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Identifier of the assignment |  |

### Return type

[**AssignmentGeneralDto**](AssignmentGeneralDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Given when resource returned successfully |  -  |
| **400** | Bad Request |  -  |
| **404** | Given when resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


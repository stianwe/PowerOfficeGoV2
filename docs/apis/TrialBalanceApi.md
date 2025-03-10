# PowerOfficeGoV2.Api.TrialBalanceApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**TrialBalanceGet**](TrialBalanceApi.md#trialbalanceget) | **GET** /TrialBalance | Gets the trial balance at a specific date (inclusive). Multiple filtering options (Auth roles: TrialBalance,TrialBalance_Full) |

<a id="trialbalanceget"></a>
# **TrialBalanceGet**
> List&lt;TrialBalanceLineDto&gt; TrialBalanceGet (DateOnly date, string accountNos = null, string agricultureDepartments = null, string departmentCodes = null, bool hideAccountsWithZeroBalance = null, bool includeSubProject = null, string productCode = null, string projectCode = null, ResourceParameters resourceParameter = null)

Gets the trial balance at a specific date (inclusive). Multiple filtering options (Auth roles: TrialBalance,TrialBalance_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class TrialBalanceGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new TrialBalanceApi(config);
            var date = 2021-01-01;  // DateOnly | The specific date (inclusive) to get trial balance for. Note that (date time) offsets (if provided) is not taken into account, only date is used.
            var accountNos = 1000-1999, 2500, 3000-;  // string | Filter by account numbers. Separate by comma [,] to filter on multiple account numbers. A range of numbers can be specified using dash/hyphen [-]. For example \"1000-1999, 2500, 3000-\" will result in transactions with account numbers from and including 1000 to 1999, 2500, 3000 and all above will be returned. If null or whitespace, the filter is not used. (optional) 
            var agricultureDepartments = Finance;  // string | Filter by agriculture departments. Separate by comma [,] to filter on multiple names. If null or whitespace, all transactions with or without agriculture departments are returned (filter is not used). (optional) 
            var departmentCodes = 1, 3, 4;  // string | Filter by department codes. Separate by comma [,] to filter on multiple codes. If -1, then all transactions without department codes are returned. If null or whitespace, all transactions with or without department codes are returned (filter is not used). (optional) 
            var hideAccountsWithZeroBalance = false;  // bool | Hide all accounts that have balance = 0. (optional) 
            var includeSubProject = true;  // bool | Include sub-project(s) for the currently filtered project(s). If projectCodes is null or whitespace, all (sub)projects are included (regardless of this variable). (optional) 
            var productCode = Coffee Beans;  // string | Filter by product code. If null or whitespace, the filter is not used. (optional) 
            var projectCode = Kitchen;  // string | Filter by project code. If -1, then all transactions without project codes are returned. If null or whitespace, all transactions with or without project codes are returned (filter is not used). (optional) 
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Gets the trial balance at a specific date (inclusive). Multiple filtering options (Auth roles: TrialBalance,TrialBalance_Full)
                List<TrialBalanceLineDto> result = apiInstance.TrialBalanceGet(date, accountNos, agricultureDepartments, departmentCodes, hideAccountsWithZeroBalance, includeSubProject, productCode, projectCode, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TrialBalanceApi.TrialBalanceGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TrialBalanceGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the trial balance at a specific date (inclusive). Multiple filtering options (Auth roles: TrialBalance,TrialBalance_Full)
    ApiResponse<List<TrialBalanceLineDto>> response = apiInstance.TrialBalanceGetWithHttpInfo(date, accountNos, agricultureDepartments, departmentCodes, hideAccountsWithZeroBalance, includeSubProject, productCode, projectCode, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TrialBalanceApi.TrialBalanceGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **date** | **DateOnly** | The specific date (inclusive) to get trial balance for. Note that (date time) offsets (if provided) is not taken into account, only date is used. |  |
| **accountNos** | **string** | Filter by account numbers. Separate by comma [,] to filter on multiple account numbers. A range of numbers can be specified using dash/hyphen [-]. For example \&quot;1000-1999, 2500, 3000-\&quot; will result in transactions with account numbers from and including 1000 to 1999, 2500, 3000 and all above will be returned. If null or whitespace, the filter is not used. | [optional]  |
| **agricultureDepartments** | **string** | Filter by agriculture departments. Separate by comma [,] to filter on multiple names. If null or whitespace, all transactions with or without agriculture departments are returned (filter is not used). | [optional]  |
| **departmentCodes** | **string** | Filter by department codes. Separate by comma [,] to filter on multiple codes. If -1, then all transactions without department codes are returned. If null or whitespace, all transactions with or without department codes are returned (filter is not used). | [optional]  |
| **hideAccountsWithZeroBalance** | **bool** | Hide all accounts that have balance &#x3D; 0. | [optional]  |
| **includeSubProject** | **bool** | Include sub-project(s) for the currently filtered project(s). If projectCodes is null or whitespace, all (sub)projects are included (regardless of this variable). | [optional]  |
| **productCode** | **string** | Filter by product code. If null or whitespace, the filter is not used. | [optional]  |
| **projectCode** | **string** | Filter by project code. If -1, then all transactions without project codes are returned. If null or whitespace, all transactions with or without project codes are returned (filter is not used). | [optional]  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;TrialBalanceLineDto&gt;**](TrialBalanceLineDto.md)

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
| **404** | Given when resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


# PowerOfficeGoV2.Api.ClientBankAccountApproversApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ClientBankAccountsBankApproversGet**](ClientBankAccountApproversApi.md#clientbankaccountsbankapproversget) | **GET** /ClientBankAccounts/BankApprovers | List all bank approvers. (Auth roles: ClientBankAccount,ClientBankAccount_Full) |
| [**ClientBankAccountsBankApproversIdPatch**](ClientBankAccountApproversApi.md#clientbankaccountsbankapproversidpatch) | **PATCH** /ClientBankAccounts/BankApprovers/{id} | Make changes to a specific bank approver. (Auth roles: ClientBankAccount_Full) |
| [**ClientBankAccountsBankApproversPost**](ClientBankAccountApproversApi.md#clientbankaccountsbankapproverspost) | **POST** /ClientBankAccounts/BankApprovers | Create a new bank approver. (Auth roles: ClientBankAccount_Full) |
| [**GetBankApproverById**](ClientBankAccountApproversApi.md#getbankapproverbyid) | **GET** /ClientBankAccounts/BankApprovers/{id} | Get a specific bank approver by Id. (Auth roles: ClientBankAccount,ClientBankAccount_Full) |

<a id="clientbankaccountsbankapproversget"></a>
# **ClientBankAccountsBankApproversGet**
> List&lt;BankApproverDto&gt; ClientBankAccountsBankApproversGet (string bankAccountNumbers = null, string userIds = null, ResourceParameters resourceParameter = null)

List all bank approvers. (Auth roles: ClientBankAccount,ClientBankAccount_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class ClientBankAccountsBankApproversGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ClientBankAccountApproversApi(config);
            var bankAccountNumbers = 36361508151, 46054249748, 86051053542;  // string | Filter by bank account numbers. Separate by comma [,] to filter on multiple bank accounts. If null or whitespace, all bank accounts are returned (filter is not used). (optional) 
            var userIds = 21afcc3b-aff4-612c-15a2-f21fc1474163, 7a2cba1a-fa3f-c26a-65a2-c17cf6474621;  // string | Filter by user ids. Separate by comma [,] to filter on multiple users. If null or whitespace, all users are returned (filter is not used). (optional) 
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // List all bank approvers. (Auth roles: ClientBankAccount,ClientBankAccount_Full)
                List<BankApproverDto> result = apiInstance.ClientBankAccountsBankApproversGet(bankAccountNumbers, userIds, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientBankAccountApproversApi.ClientBankAccountsBankApproversGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClientBankAccountsBankApproversGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all bank approvers. (Auth roles: ClientBankAccount,ClientBankAccount_Full)
    ApiResponse<List<BankApproverDto>> response = apiInstance.ClientBankAccountsBankApproversGetWithHttpInfo(bankAccountNumbers, userIds, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientBankAccountApproversApi.ClientBankAccountsBankApproversGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bankAccountNumbers** | **string** | Filter by bank account numbers. Separate by comma [,] to filter on multiple bank accounts. If null or whitespace, all bank accounts are returned (filter is not used). | [optional]  |
| **userIds** | **string** | Filter by user ids. Separate by comma [,] to filter on multiple users. If null or whitespace, all users are returned (filter is not used). | [optional]  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;BankApproverDto&gt;**](BankApproverDto.md)

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

<a id="clientbankaccountsbankapproversidpatch"></a>
# **ClientBankAccountsBankApproversIdPatch**
> BankApproverDto ClientBankAccountsBankApproversIdPatch (long id, List<Operation> operation = null)

Make changes to a specific bank approver. (Auth roles: ClientBankAccount_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class ClientBankAccountsBankApproversIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ClientBankAccountApproversApi(config);
            var id = 12345;  // long | The id of the bank approver.
            var operation = new List<Operation>(); // List<Operation> | JSON Patch structure for updating an approver. See BankApproverPatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 (optional) 

            try
            {
                // Make changes to a specific bank approver. (Auth roles: ClientBankAccount_Full)
                BankApproverDto result = apiInstance.ClientBankAccountsBankApproversIdPatch(id, operation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientBankAccountApproversApi.ClientBankAccountsBankApproversIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClientBankAccountsBankApproversIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Make changes to a specific bank approver. (Auth roles: ClientBankAccount_Full)
    ApiResponse<BankApproverDto> response = apiInstance.ClientBankAccountsBankApproversIdPatchWithHttpInfo(id, operation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientBankAccountApproversApi.ClientBankAccountsBankApproversIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | The id of the bank approver. |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) | JSON Patch structure for updating an approver. See BankApproverPatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 | [optional]  |

### Return type

[**BankApproverDto**](BankApproverDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Given when resource was successfully updated. |  -  |
| **400** | Given when request is badly formatted |  -  |
| **404** | Given when resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="clientbankaccountsbankapproverspost"></a>
# **ClientBankAccountsBankApproversPost**
> BankApproverDto ClientBankAccountsBankApproversPost (BankApproverPostDto bankApproverPostDto = null)

Create a new bank approver. (Auth roles: ClientBankAccount_Full)

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
    public class ClientBankAccountsBankApproversPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ClientBankAccountApproversApi(config);
            var bankApproverPostDto = new BankApproverPostDto(); // BankApproverPostDto | Bank approver post dto (optional) 

            try
            {
                // Create a new bank approver. (Auth roles: ClientBankAccount_Full)
                BankApproverDto result = apiInstance.ClientBankAccountsBankApproversPost(bankApproverPostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientBankAccountApproversApi.ClientBankAccountsBankApproversPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClientBankAccountsBankApproversPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new bank approver. (Auth roles: ClientBankAccount_Full)
    ApiResponse<BankApproverDto> response = apiInstance.ClientBankAccountsBankApproversPostWithHttpInfo(bankApproverPostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientBankAccountApproversApi.ClientBankAccountsBankApproversPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bankApproverPostDto** | [**BankApproverPostDto**](BankApproverPostDto.md) | Bank approver post dto | [optional]  |

### Return type

[**BankApproverDto**](BankApproverDto.md)

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

<a id="getbankapproverbyid"></a>
# **GetBankApproverById**
> BankApproverDto GetBankApproverById (long id)

Get a specific bank approver by Id. (Auth roles: ClientBankAccount,ClientBankAccount_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetBankApproverByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ClientBankAccountApproversApi(config);
            var id = 12345;  // long | The id of the bank approver.

            try
            {
                // Get a specific bank approver by Id. (Auth roles: ClientBankAccount,ClientBankAccount_Full)
                BankApproverDto result = apiInstance.GetBankApproverById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientBankAccountApproversApi.GetBankApproverById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBankApproverByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a specific bank approver by Id. (Auth roles: ClientBankAccount,ClientBankAccount_Full)
    ApiResponse<BankApproverDto> response = apiInstance.GetBankApproverByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientBankAccountApproversApi.GetBankApproverByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | The id of the bank approver. |  |

### Return type

[**BankApproverDto**](BankApproverDto.md)

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
| **404** | Given when resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


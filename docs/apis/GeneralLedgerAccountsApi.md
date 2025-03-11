# PowerOfficeGoV2.Api.GeneralLedgerAccountsApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GeneralLedgerAccountsIdDelete**](GeneralLedgerAccountsApi.md#generalledgeraccountsiddelete) | **DELETE** /GeneralLedgerAccounts/{id} | Deletes a General Ledger Account with a given id. (Auth roles: GeneralLedgerAccount_Full) |
| [**GeneralLedgerAccountsIdPatch**](GeneralLedgerAccountsApi.md#generalledgeraccountsidpatch) | **PATCH** /GeneralLedgerAccounts/{id} | Update an existing general ledger account. (Auth roles: GeneralLedgerAccount_Full) |
| [**GeneralLedgerAccountsPost**](GeneralLedgerAccountsApi.md#generalledgeraccountspost) | **POST** /GeneralLedgerAccounts | Create a new general ledger account with setting. (Auth roles: GeneralLedgerAccount_Full) |
| [**GetGeneralLedgerAccountById**](GeneralLedgerAccountsApi.md#getgeneralledgeraccountbyid) | **GET** /GeneralLedgerAccounts/{id} | Get a GeneralLedgerAccount by ID (Auth roles: GeneralLedgerAccount,GeneralLedgerAccount_Full) |
| [**GetGeneralLedgerAccounts**](GeneralLedgerAccountsApi.md#getgeneralledgeraccounts) | **GET** /GeneralLedgerAccounts | Get a list of general ledger accounts. (Auth roles: GeneralLedgerAccount,GeneralLedgerAccount_Full) |

<a id="generalledgeraccountsiddelete"></a>
# **GeneralLedgerAccountsIdDelete**
> void GeneralLedgerAccountsIdDelete (long id)

Deletes a General Ledger Account with a given id. (Auth roles: GeneralLedgerAccount_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GeneralLedgerAccountsIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new GeneralLedgerAccountsApi(config);
            var id = 789L;  // long | 

            try
            {
                // Deletes a General Ledger Account with a given id. (Auth roles: GeneralLedgerAccount_Full)
                apiInstance.GeneralLedgerAccountsIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeneralLedgerAccountsApi.GeneralLedgerAccountsIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GeneralLedgerAccountsIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a General Ledger Account with a given id. (Auth roles: GeneralLedgerAccount_Full)
    apiInstance.GeneralLedgerAccountsIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GeneralLedgerAccountsApi.GeneralLedgerAccountsIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** |  |  |

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
| **200** | Given when employee is deleted |  -  |
| **404** | Given when resource was not found |  -  |
| **409** | Given when resource is in use and cannot be deleted |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="generalledgeraccountsidpatch"></a>
# **GeneralLedgerAccountsIdPatch**
> GeneralLedgerAccountDto GeneralLedgerAccountsIdPatch (long id, List<Operation> operation = null)

Update an existing general ledger account. (Auth roles: GeneralLedgerAccount_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GeneralLedgerAccountsIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new GeneralLedgerAccountsApi(config);
            var id = 789L;  // long | The id of the general ledger account.
            var operation = new List<Operation>(); // List<Operation> | JSON Patch structure for updating a General Ledger Account. See GeneralLedgerAccountPatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 (optional) 

            try
            {
                // Update an existing general ledger account. (Auth roles: GeneralLedgerAccount_Full)
                GeneralLedgerAccountDto result = apiInstance.GeneralLedgerAccountsIdPatch(id, operation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeneralLedgerAccountsApi.GeneralLedgerAccountsIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GeneralLedgerAccountsIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an existing general ledger account. (Auth roles: GeneralLedgerAccount_Full)
    ApiResponse<GeneralLedgerAccountDto> response = apiInstance.GeneralLedgerAccountsIdPatchWithHttpInfo(id, operation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GeneralLedgerAccountsApi.GeneralLedgerAccountsIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | The id of the general ledger account. |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) | JSON Patch structure for updating a General Ledger Account. See GeneralLedgerAccountPatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 | [optional]  |

### Return type

[**GeneralLedgerAccountDto**](GeneralLedgerAccountDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Given when resource was successfully updated |  -  |
| **400** | Given when request is badly formatted |  -  |
| **404** | Given when resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="generalledgeraccountspost"></a>
# **GeneralLedgerAccountsPost**
> GeneralLedgerAccountDto GeneralLedgerAccountsPost (GeneralLedgerAccountPostDto generalLedgerAccountPostDto = null)

Create a new general ledger account with setting. (Auth roles: GeneralLedgerAccount_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GeneralLedgerAccountsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new GeneralLedgerAccountsApi(config);
            var generalLedgerAccountPostDto = new GeneralLedgerAccountPostDto(); // GeneralLedgerAccountPostDto |  (optional) 

            try
            {
                // Create a new general ledger account with setting. (Auth roles: GeneralLedgerAccount_Full)
                GeneralLedgerAccountDto result = apiInstance.GeneralLedgerAccountsPost(generalLedgerAccountPostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeneralLedgerAccountsApi.GeneralLedgerAccountsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GeneralLedgerAccountsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new general ledger account with setting. (Auth roles: GeneralLedgerAccount_Full)
    ApiResponse<GeneralLedgerAccountDto> response = apiInstance.GeneralLedgerAccountsPostWithHttpInfo(generalLedgerAccountPostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GeneralLedgerAccountsApi.GeneralLedgerAccountsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **generalLedgerAccountPostDto** | [**GeneralLedgerAccountPostDto**](GeneralLedgerAccountPostDto.md) |  | [optional]  |

### Return type

[**GeneralLedgerAccountDto**](GeneralLedgerAccountDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Given when resource was successfully created |  -  |
| **400** | Given when request is badly formatted |  -  |
| **404** | Given when resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getgeneralledgeraccountbyid"></a>
# **GetGeneralLedgerAccountById**
> GeneralLedgerAccountDto GetGeneralLedgerAccountById (long id)

Get a GeneralLedgerAccount by ID (Auth roles: GeneralLedgerAccount,GeneralLedgerAccount_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetGeneralLedgerAccountByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new GeneralLedgerAccountsApi(config);
            var id = 1337;  // long | 

            try
            {
                // Get a GeneralLedgerAccount by ID (Auth roles: GeneralLedgerAccount,GeneralLedgerAccount_Full)
                GeneralLedgerAccountDto result = apiInstance.GetGeneralLedgerAccountById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeneralLedgerAccountsApi.GetGeneralLedgerAccountById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGeneralLedgerAccountByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a GeneralLedgerAccount by ID (Auth roles: GeneralLedgerAccount,GeneralLedgerAccount_Full)
    ApiResponse<GeneralLedgerAccountDto> response = apiInstance.GetGeneralLedgerAccountByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GeneralLedgerAccountsApi.GetGeneralLedgerAccountByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** |  |  |

### Return type

[**GeneralLedgerAccountDto**](GeneralLedgerAccountDto.md)

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

<a id="getgeneralledgeraccounts"></a>
# **GetGeneralLedgerAccounts**
> List&lt;GeneralLedgerAccountDto&gt; GetGeneralLedgerAccounts (string accountNos = null, string agricultureDepartments = null, DateTimeOffset lastChangedDateTimeOffsetGreaterThan = null, ResourceParameters resourceParameter = null)

Get a list of general ledger accounts. (Auth roles: GeneralLedgerAccount,GeneralLedgerAccount_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetGeneralLedgerAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new GeneralLedgerAccountsApi(config);
            var accountNos = 1000-1999, 2500, 3000-;  // string | Filter by account numbers. Separate by comma [,] to filter on multiple account numbers. A range of numbers can be specified using dash/hyphen [-]. For example \"1000-1999, 2500, 3000-\" will result in accounts with account numbers from and including 1000 to 1999, 2500, 3000 and all above will be returned. If null or whitespace, the filter is not used. (optional) 
            var agricultureDepartments = farming, private, otherIndustries;  // string | Filter by agriculture departments. Separate by comma [,] to filter on multiple agriculture departments. (optional) 
            var lastChangedDateTimeOffsetGreaterThan = 2021-09-25 08:03:00.1234567 -00:00;  // DateTimeOffset | Filter by last changed timestamp. (optional) 
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Get a list of general ledger accounts. (Auth roles: GeneralLedgerAccount,GeneralLedgerAccount_Full)
                List<GeneralLedgerAccountDto> result = apiInstance.GetGeneralLedgerAccounts(accountNos, agricultureDepartments, lastChangedDateTimeOffsetGreaterThan, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeneralLedgerAccountsApi.GetGeneralLedgerAccounts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGeneralLedgerAccountsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of general ledger accounts. (Auth roles: GeneralLedgerAccount,GeneralLedgerAccount_Full)
    ApiResponse<List<GeneralLedgerAccountDto>> response = apiInstance.GetGeneralLedgerAccountsWithHttpInfo(accountNos, agricultureDepartments, lastChangedDateTimeOffsetGreaterThan, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GeneralLedgerAccountsApi.GetGeneralLedgerAccountsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **accountNos** | **string** | Filter by account numbers. Separate by comma [,] to filter on multiple account numbers. A range of numbers can be specified using dash/hyphen [-]. For example \&quot;1000-1999, 2500, 3000-\&quot; will result in accounts with account numbers from and including 1000 to 1999, 2500, 3000 and all above will be returned. If null or whitespace, the filter is not used. | [optional]  |
| **agricultureDepartments** | **string** | Filter by agriculture departments. Separate by comma [,] to filter on multiple agriculture departments. | [optional]  |
| **lastChangedDateTimeOffsetGreaterThan** | **DateTimeOffset** | Filter by last changed timestamp. | [optional]  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;GeneralLedgerAccountDto&gt;**](GeneralLedgerAccountDto.md)

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


# PowerOfficeGoV2.Api.ClientBankAccountsApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ClientBankAccountsGet**](ClientBankAccountsApi.md#clientbankaccountsget) | **GET** /ClientBankAccounts | Gets the bank accounts registered on the client. (Auth roles: ClientBankAccount,ClientBankAccount_Full) |
| [**ClientBankAccountsIdPatch**](ClientBankAccountsApi.md#clientbankaccountsidpatch) | **PATCH** /ClientBankAccounts/{id} | Update a bank account on the client (Auth roles: ClientBankAccount_Full) |
| [**ClientBankAccountsPost**](ClientBankAccountsApi.md#clientbankaccountspost) | **POST** /ClientBankAccounts | Create a new client bank account (Auth roles: ClientBankAccount_Full) |
| [**GetClientBankAccountById**](ClientBankAccountsApi.md#getclientbankaccountbyid) | **GET** /ClientBankAccounts/{id} | Get a client bank account by id (Auth roles: ClientBankAccount,ClientBankAccount_Full) |

<a id="clientbankaccountsget"></a>
# **ClientBankAccountsGet**
> List&lt;ClientBankAccountDto&gt; ClientBankAccountsGet (string bankAccountNumbers = null, DateTime createdDateTimeOffsetGreaterThan = null, DateTime lastChangedDateTimeOffsetGreaterThan = null, ResourceParameters resourceParameter = null)

Gets the bank accounts registered on the client. (Auth roles: ClientBankAccount,ClientBankAccount_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class ClientBankAccountsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ClientBankAccountsApi(config);
            var bankAccountNumbers = 67774073962, 83529195381;  // string | Filter by client bank account number. Search string should be separated by comma. If filter string is null or whitespace, query is returned as is. (optional) 
            var createdDateTimeOffsetGreaterThan = 2023-10-19T11:05:00.1234567Z;  // DateTime | Filter by the client bank account created timestamp property. This filtering will return all client bank accounts with a created timestamp greater than the timestamp provided. Can be used when polling for new entries from Go. Timestamp not inclusive. (optional) 
            var lastChangedDateTimeOffsetGreaterThan = 2023-10-19T11:05:00.1234567Z;  // DateTime | Filter by the client bank account last changed timestamp property. This filtering will return all client bank accounts with a last changed timestamp greater than the timestamp provided. Timestamp not inclusive. (optional) 
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Gets the bank accounts registered on the client. (Auth roles: ClientBankAccount,ClientBankAccount_Full)
                List<ClientBankAccountDto> result = apiInstance.ClientBankAccountsGet(bankAccountNumbers, createdDateTimeOffsetGreaterThan, lastChangedDateTimeOffsetGreaterThan, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientBankAccountsApi.ClientBankAccountsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClientBankAccountsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the bank accounts registered on the client. (Auth roles: ClientBankAccount,ClientBankAccount_Full)
    ApiResponse<List<ClientBankAccountDto>> response = apiInstance.ClientBankAccountsGetWithHttpInfo(bankAccountNumbers, createdDateTimeOffsetGreaterThan, lastChangedDateTimeOffsetGreaterThan, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientBankAccountsApi.ClientBankAccountsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bankAccountNumbers** | **string** | Filter by client bank account number. Search string should be separated by comma. If filter string is null or whitespace, query is returned as is. | [optional]  |
| **createdDateTimeOffsetGreaterThan** | **DateTime** | Filter by the client bank account created timestamp property. This filtering will return all client bank accounts with a created timestamp greater than the timestamp provided. Can be used when polling for new entries from Go. Timestamp not inclusive. | [optional]  |
| **lastChangedDateTimeOffsetGreaterThan** | **DateTime** | Filter by the client bank account last changed timestamp property. This filtering will return all client bank accounts with a last changed timestamp greater than the timestamp provided. Timestamp not inclusive. | [optional]  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;ClientBankAccountDto&gt;**](ClientBankAccountDto.md)

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

<a id="clientbankaccountsidpatch"></a>
# **ClientBankAccountsIdPatch**
> ClientBankAccountDto ClientBankAccountsIdPatch (long id, List<Operation> operation = null)

Update a bank account on the client (Auth roles: ClientBankAccount_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class ClientBankAccountsIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ClientBankAccountsApi(config);
            var id = 789L;  // long | The identifier of a client bank account.
            var operation = new List<Operation>(); // List<Operation> | JSON Patch structure for updating a ClientBankAccount. See ClientBankAccountPatchDto schema for all available properties.              For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 (optional) 

            try
            {
                // Update a bank account on the client (Auth roles: ClientBankAccount_Full)
                ClientBankAccountDto result = apiInstance.ClientBankAccountsIdPatch(id, operation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientBankAccountsApi.ClientBankAccountsIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClientBankAccountsIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a bank account on the client (Auth roles: ClientBankAccount_Full)
    ApiResponse<ClientBankAccountDto> response = apiInstance.ClientBankAccountsIdPatchWithHttpInfo(id, operation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientBankAccountsApi.ClientBankAccountsIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | The identifier of a client bank account. |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) | JSON Patch structure for updating a ClientBankAccount. See ClientBankAccountPatchDto schema for all available properties.              For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 | [optional]  |

### Return type

[**ClientBankAccountDto**](ClientBankAccountDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Given when a resource was updated successfully |  -  |
| **400** | Given when request is badly formatted |  -  |
| **404** | Given when resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="clientbankaccountspost"></a>
# **ClientBankAccountsPost**
> ClientBankAccountDto ClientBankAccountsPost (ClientBankAccountPostDto clientBankAccountPostDto = null)

Create a new client bank account (Auth roles: ClientBankAccount_Full)

Bank account numbers are unique across all clients.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class ClientBankAccountsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ClientBankAccountsApi(config);
            var clientBankAccountPostDto = new ClientBankAccountPostDto(); // ClientBankAccountPostDto | A client bank account post dto (optional) 

            try
            {
                // Create a new client bank account (Auth roles: ClientBankAccount_Full)
                ClientBankAccountDto result = apiInstance.ClientBankAccountsPost(clientBankAccountPostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientBankAccountsApi.ClientBankAccountsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClientBankAccountsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new client bank account (Auth roles: ClientBankAccount_Full)
    ApiResponse<ClientBankAccountDto> response = apiInstance.ClientBankAccountsPostWithHttpInfo(clientBankAccountPostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientBankAccountsApi.ClientBankAccountsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientBankAccountPostDto** | [**ClientBankAccountPostDto**](ClientBankAccountPostDto.md) | A client bank account post dto | [optional]  |

### Return type

[**ClientBankAccountDto**](ClientBankAccountDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Given when a resource was created successfully |  -  |
| **400** | Given when request is badly formatted |  -  |
| **404** | Given when resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getclientbankaccountbyid"></a>
# **GetClientBankAccountById**
> ClientBankAccountDto GetClientBankAccountById (long id)

Get a client bank account by id (Auth roles: ClientBankAccount,ClientBankAccount_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetClientBankAccountByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ClientBankAccountsApi(config);
            var id = 12345;  // long | The identifier of a client bank account.

            try
            {
                // Get a client bank account by id (Auth roles: ClientBankAccount,ClientBankAccount_Full)
                ClientBankAccountDto result = apiInstance.GetClientBankAccountById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientBankAccountsApi.GetClientBankAccountById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetClientBankAccountByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a client bank account by id (Auth roles: ClientBankAccount,ClientBankAccount_Full)
    ApiResponse<ClientBankAccountDto> response = apiInstance.GetClientBankAccountByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientBankAccountsApi.GetClientBankAccountByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | The identifier of a client bank account. |  |

### Return type

[**ClientBankAccountDto**](ClientBankAccountDto.md)

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


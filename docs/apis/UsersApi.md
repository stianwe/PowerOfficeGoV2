# PowerOfficeGoV2.Api.UsersApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ClientAdminClientIdUsersAddPartnerUserPost**](UsersApi.md#clientadminclientidusersaddpartneruserpost) | **POST** /ClientAdmin/{clientId}/Users/AddPartnerUser | Add an existing partner user to a client. (Auth roles: ClientAdmin_Full) |
| [**ClientAdminClientIdUsersGet**](UsersApi.md#clientadminclientidusersget) | **GET** /ClientAdmin/{clientId}/Users | Gets the users of the given client.  Note: Only clients that belong to the partner are available. (Auth roles: ClientAdmin,ClientAdmin_Full) |
| [**ClientAdminClientIdUsersInvitePost**](UsersApi.md#clientadminclientidusersinvitepost) | **POST** /ClientAdmin/{clientId}/Users/Invite | Invite a user to a client. (Auth roles: ClientAdmin_Full) |
| [**ClientAdminClientIdUsersUserIdPatch**](UsersApi.md#clientadminclientidusersuseridpatch) | **PATCH** /ClientAdmin/{clientId}/Users/{userId} | Change an existing user on a client with a given (user) Id. (Auth roles: ClientAdmin_Full) |
| [**GetUserById**](UsersApi.md#getuserbyid) | **GET** /ClientAdmin/{clientId}/Users/{userId} | Gets a specific user on a given client.  Note: Only clients that belong to the partner are available. (Auth roles: ClientAdmin,ClientAdmin_Full) |

<a id="clientadminclientidusersaddpartneruserpost"></a>
# **ClientAdminClientIdUsersAddPartnerUserPost**
> UserDto ClientAdminClientIdUsersAddPartnerUserPost (Guid clientId, AddPartnerUserPostDto addPartnerUserPostDto = null)

Add an existing partner user to a client. (Auth roles: ClientAdmin_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class ClientAdminClientIdUsersAddPartnerUserPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new UsersApi(config);
            var clientId = "clientId_example";  // Guid | 
            var addPartnerUserPostDto = new AddPartnerUserPostDto(); // AddPartnerUserPostDto |  (optional) 

            try
            {
                // Add an existing partner user to a client. (Auth roles: ClientAdmin_Full)
                UserDto result = apiInstance.ClientAdminClientIdUsersAddPartnerUserPost(clientId, addPartnerUserPostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ClientAdminClientIdUsersAddPartnerUserPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClientAdminClientIdUsersAddPartnerUserPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add an existing partner user to a client. (Auth roles: ClientAdmin_Full)
    ApiResponse<UserDto> response = apiInstance.ClientAdminClientIdUsersAddPartnerUserPostWithHttpInfo(clientId, addPartnerUserPostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.ClientAdminClientIdUsersAddPartnerUserPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **Guid** |  |  |
| **addPartnerUserPostDto** | [**AddPartnerUserPostDto**](AddPartnerUserPostDto.md) |  | [optional]  |

### Return type

[**UserDto**](UserDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
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

<a id="clientadminclientidusersget"></a>
# **ClientAdminClientIdUsersGet**
> List&lt;UserDto&gt; ClientAdminClientIdUsersGet (Guid clientId, ResourceParameters resourceParameter = null)

Gets the users of the given client.  Note: Only clients that belong to the partner are available. (Auth roles: ClientAdmin,ClientAdmin_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class ClientAdminClientIdUsersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new UsersApi(config);
            var clientId = 38ecfc1a-bf51-448f-99a8-a61bc5771109;  // Guid | The id of the client to get users from.
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Gets the users of the given client.  Note: Only clients that belong to the partner are available. (Auth roles: ClientAdmin,ClientAdmin_Full)
                List<UserDto> result = apiInstance.ClientAdminClientIdUsersGet(clientId, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ClientAdminClientIdUsersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClientAdminClientIdUsersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the users of the given client.  Note: Only clients that belong to the partner are available. (Auth roles: ClientAdmin,ClientAdmin_Full)
    ApiResponse<List<UserDto>> response = apiInstance.ClientAdminClientIdUsersGetWithHttpInfo(clientId, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.ClientAdminClientIdUsersGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **Guid** | The id of the client to get users from. |  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;UserDto&gt;**](UserDto.md)

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
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="clientadminclientidusersinvitepost"></a>
# **ClientAdminClientIdUsersInvitePost**
> UserDto ClientAdminClientIdUsersInvitePost (Guid clientId, InviteUserPostDto inviteUserPostDto = null)

Invite a user to a client. (Auth roles: ClientAdmin_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class ClientAdminClientIdUsersInvitePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new UsersApi(config);
            var clientId = "clientId_example";  // Guid | 
            var inviteUserPostDto = new InviteUserPostDto(); // InviteUserPostDto |  (optional) 

            try
            {
                // Invite a user to a client. (Auth roles: ClientAdmin_Full)
                UserDto result = apiInstance.ClientAdminClientIdUsersInvitePost(clientId, inviteUserPostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ClientAdminClientIdUsersInvitePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClientAdminClientIdUsersInvitePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Invite a user to a client. (Auth roles: ClientAdmin_Full)
    ApiResponse<UserDto> response = apiInstance.ClientAdminClientIdUsersInvitePostWithHttpInfo(clientId, inviteUserPostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.ClientAdminClientIdUsersInvitePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **Guid** |  |  |
| **inviteUserPostDto** | [**InviteUserPostDto**](InviteUserPostDto.md) |  | [optional]  |

### Return type

[**UserDto**](UserDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
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

<a id="clientadminclientidusersuseridpatch"></a>
# **ClientAdminClientIdUsersUserIdPatch**
> UserDto ClientAdminClientIdUsersUserIdPatch (Guid clientId, Guid userId, List<Operation> operation = null)

Change an existing user on a client with a given (user) Id. (Auth roles: ClientAdmin_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class ClientAdminClientIdUsersUserIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new UsersApi(config);
            var clientId = 38ecfc1a-bf51-448f-99a8-a61bc5771109;  // Guid | The id of the client.
            var userId = 21afcc3b-aff4-612c-15a2-f21fc1474163;  // Guid | The id of the user to update.
            var operation = new List<Operation>(); // List<Operation> | JSON Patch structure for updating a user. See UserPatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 (optional) 

            try
            {
                // Change an existing user on a client with a given (user) Id. (Auth roles: ClientAdmin_Full)
                UserDto result = apiInstance.ClientAdminClientIdUsersUserIdPatch(clientId, userId, operation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ClientAdminClientIdUsersUserIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClientAdminClientIdUsersUserIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change an existing user on a client with a given (user) Id. (Auth roles: ClientAdmin_Full)
    ApiResponse<UserDto> response = apiInstance.ClientAdminClientIdUsersUserIdPatchWithHttpInfo(clientId, userId, operation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.ClientAdminClientIdUsersUserIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **Guid** | The id of the client. |  |
| **userId** | **Guid** | The id of the user to update. |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) | JSON Patch structure for updating a user. See UserPatchDto schema for all available properties. For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 | [optional]  |

### Return type

[**UserDto**](UserDto.md)

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

<a id="getuserbyid"></a>
# **GetUserById**
> UserDto GetUserById (Guid clientId, Guid userId)

Gets a specific user on a given client.  Note: Only clients that belong to the partner are available. (Auth roles: ClientAdmin,ClientAdmin_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetUserByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new UsersApi(config);
            var clientId = 38ecfc1a-bf51-448f-99a8-a61bc5771109;  // Guid | The id of the client.
            var userId = 21afcc3b-aff4-612c-15a2-f21fc1474163;  // Guid | The id of the user.

            try
            {
                // Gets a specific user on a given client.  Note: Only clients that belong to the partner are available. (Auth roles: ClientAdmin,ClientAdmin_Full)
                UserDto result = apiInstance.GetUserById(clientId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a specific user on a given client.  Note: Only clients that belong to the partner are available. (Auth roles: ClientAdmin,ClientAdmin_Full)
    ApiResponse<UserDto> response = apiInstance.GetUserByIdWithHttpInfo(clientId, userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.GetUserByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **Guid** | The id of the client. |  |
| **userId** | **Guid** | The id of the user. |  |

### Return type

[**UserDto**](UserDto.md)

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


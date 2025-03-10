# PowerOfficeGoV2.Api.AccessRolesApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ClientAdminClientIdAccessRolesGet**](AccessRolesApi.md#clientadminclientidaccessrolesget) | **GET** /ClientAdmin/{clientId}/AccessRoles | Gets the access roles defined on a given client. (Auth roles: ClientAdmin,ClientAdmin_Full) |
| [**ClientAdminUserIdUserAccessRolesGet**](AccessRolesApi.md#clientadminuseriduseraccessrolesget) | **GET** /ClientAdmin/{userId}/UserAccessRoles | Gets the clients a given user have access to along with the access role the user have on the client. (Auth roles: ClientAdmin,ClientAdmin_Full) |

<a id="clientadminclientidaccessrolesget"></a>
# **ClientAdminClientIdAccessRolesGet**
> List&lt;AccessRoleDto&gt; ClientAdminClientIdAccessRolesGet (Guid clientId, ResourceParameters resourceParameter = null)

Gets the access roles defined on a given client. (Auth roles: ClientAdmin,ClientAdmin_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class ClientAdminClientIdAccessRolesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new AccessRolesApi(config);
            var clientId = 38ecfc1a-bf51-448f-99a8-a61bc5771109;  // Guid | The id of the client.
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Gets the access roles defined on a given client. (Auth roles: ClientAdmin,ClientAdmin_Full)
                List<AccessRoleDto> result = apiInstance.ClientAdminClientIdAccessRolesGet(clientId, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccessRolesApi.ClientAdminClientIdAccessRolesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClientAdminClientIdAccessRolesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the access roles defined on a given client. (Auth roles: ClientAdmin,ClientAdmin_Full)
    ApiResponse<List<AccessRoleDto>> response = apiInstance.ClientAdminClientIdAccessRolesGetWithHttpInfo(clientId, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccessRolesApi.ClientAdminClientIdAccessRolesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **Guid** | The id of the client. |  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;AccessRoleDto&gt;**](AccessRoleDto.md)

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

<a id="clientadminuseriduseraccessrolesget"></a>
# **ClientAdminUserIdUserAccessRolesGet**
> List&lt;UserAccessRoleDto&gt; ClientAdminUserIdUserAccessRolesGet (Guid userId, ResourceParameters resourceParameter = null)

Gets the clients a given user have access to along with the access role the user have on the client. (Auth roles: ClientAdmin,ClientAdmin_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class ClientAdminUserIdUserAccessRolesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new AccessRolesApi(config);
            var userId = 38ecfc1a-bf51-448f-99a8-a61bc5771109;  // Guid | The id of the user.
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Gets the clients a given user have access to along with the access role the user have on the client. (Auth roles: ClientAdmin,ClientAdmin_Full)
                List<UserAccessRoleDto> result = apiInstance.ClientAdminUserIdUserAccessRolesGet(userId, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccessRolesApi.ClientAdminUserIdUserAccessRolesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClientAdminUserIdUserAccessRolesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the clients a given user have access to along with the access role the user have on the client. (Auth roles: ClientAdmin,ClientAdmin_Full)
    ApiResponse<List<UserAccessRoleDto>> response = apiInstance.ClientAdminUserIdUserAccessRolesGetWithHttpInfo(userId, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccessRolesApi.ClientAdminUserIdUserAccessRolesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **Guid** | The id of the user. |  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;UserAccessRoleDto&gt;**](UserAccessRoleDto.md)

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


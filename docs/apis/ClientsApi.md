# PowerOfficeGoV2.Api.ClientsApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ClientAdminAddIntegrationToClientClientIdPost**](ClientsApi.md#clientadminaddintegrationtoclientclientidpost) | **POST** /ClientAdmin/AddIntegrationToClient/{clientId} | Add the (currently authenticated) partner integration to an existing client belonging to the partner, and get the client-key (Norsk: klientnøkkel) in return.  Further api-calls can then be performed on the specific client using the newly created client credentials. (Auth roles: ClientAdmin_Full) |
| [**ClientAdminClientsGet**](ClientsApi.md#clientadminclientsget) | **GET** /ClientAdmin/Clients | Gets all the clients the partner has access to. (Auth roles: ClientAdmin,ClientAdmin_Full) |
| [**ClientAdminCreateNewClientPost**](ClientsApi.md#clientadmincreatenewclientpost) | **POST** /ClientAdmin/CreateNewClient | Create a new client in Go, optionally based on a template client.  Elements inherited from a template client set, include roles, general ledger accounts, activities, branding themes, and Altinn settings. (Auth roles: ClientAdmin_Full) |

<a id="clientadminaddintegrationtoclientclientidpost"></a>
# **ClientAdminAddIntegrationToClientClientIdPost**
> NewIntegrationDto ClientAdminAddIntegrationToClientClientIdPost (Guid clientId)

Add the (currently authenticated) partner integration to an existing client belonging to the partner, and get the client-key (Norsk: klientnøkkel) in return.  Further api-calls can then be performed on the specific client using the newly created client credentials. (Auth roles: ClientAdmin_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class ClientAdminAddIntegrationToClientClientIdPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ClientsApi(config);
            var clientId = "clientId_example";  // Guid | 

            try
            {
                // Add the (currently authenticated) partner integration to an existing client belonging to the partner, and get the client-key (Norsk: klientnøkkel) in return.  Further api-calls can then be performed on the specific client using the newly created client credentials. (Auth roles: ClientAdmin_Full)
                NewIntegrationDto result = apiInstance.ClientAdminAddIntegrationToClientClientIdPost(clientId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsApi.ClientAdminAddIntegrationToClientClientIdPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClientAdminAddIntegrationToClientClientIdPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add the (currently authenticated) partner integration to an existing client belonging to the partner, and get the client-key (Norsk: klientnøkkel) in return.  Further api-calls can then be performed on the specific client using the newly created client credentials. (Auth roles: ClientAdmin_Full)
    ApiResponse<NewIntegrationDto> response = apiInstance.ClientAdminAddIntegrationToClientClientIdPostWithHttpInfo(clientId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientsApi.ClientAdminAddIntegrationToClientClientIdPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **Guid** |  |  |

### Return type

[**NewIntegrationDto**](NewIntegrationDto.md)

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

<a id="clientadminclientsget"></a>
# **ClientAdminClientsGet**
> List&lt;ClientDto&gt; ClientAdminClientsGet (bool isActive = null, ResourceParameters resourceParameter = null)

Gets all the clients the partner has access to. (Auth roles: ClientAdmin,ClientAdmin_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class ClientAdminClientsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ClientsApi(config);
            var isActive = true;  // bool | Filter clients based on active status. (optional) 
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Gets all the clients the partner has access to. (Auth roles: ClientAdmin,ClientAdmin_Full)
                List<ClientDto> result = apiInstance.ClientAdminClientsGet(isActive, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsApi.ClientAdminClientsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClientAdminClientsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets all the clients the partner has access to. (Auth roles: ClientAdmin,ClientAdmin_Full)
    ApiResponse<List<ClientDto>> response = apiInstance.ClientAdminClientsGetWithHttpInfo(isActive, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientsApi.ClientAdminClientsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **isActive** | **bool** | Filter clients based on active status. | [optional]  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;ClientDto&gt;**](ClientDto.md)

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

<a id="clientadmincreatenewclientpost"></a>
# **ClientAdminCreateNewClientPost**
> ClientDto ClientAdminCreateNewClientPost (ClientPostDto clientPostDto = null)

Create a new client in Go, optionally based on a template client.  Elements inherited from a template client set, include roles, general ledger accounts, activities, branding themes, and Altinn settings. (Auth roles: ClientAdmin_Full)

If successful, the new entity will be returned with an (client) id which is unique and can be used to reference the created object in relevant requests.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class ClientAdminCreateNewClientPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new ClientsApi(config);
            var clientPostDto = new ClientPostDto(); // ClientPostDto |  (optional) 

            try
            {
                // Create a new client in Go, optionally based on a template client.  Elements inherited from a template client set, include roles, general ledger accounts, activities, branding themes, and Altinn settings. (Auth roles: ClientAdmin_Full)
                ClientDto result = apiInstance.ClientAdminCreateNewClientPost(clientPostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClientsApi.ClientAdminCreateNewClientPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClientAdminCreateNewClientPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new client in Go, optionally based on a template client.  Elements inherited from a template client set, include roles, general ledger accounts, activities, branding themes, and Altinn settings. (Auth roles: ClientAdmin_Full)
    ApiResponse<ClientDto> response = apiInstance.ClientAdminCreateNewClientPostWithHttpInfo(clientPostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClientsApi.ClientAdminCreateNewClientPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientPostDto** | [**ClientPostDto**](ClientPostDto.md) |  | [optional]  |

### Return type

[**ClientDto**](ClientDto.md)

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


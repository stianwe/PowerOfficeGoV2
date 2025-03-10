# PowerOfficeGoV2.Api.PaymentTermsApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetPaymentTermById**](PaymentTermsApi.md#getpaymenttermbyid) | **GET** /PaymentTerms/{id} | Gets the specific payment term by id. (Auth roles: CommonServices,CommonServices_Full) |
| [**GetPaymentTerms**](PaymentTermsApi.md#getpaymentterms) | **GET** /PaymentTerms | List the payment terms from the client sales settings. (Auth roles: CommonServices,CommonServices_Full) |
| [**PaymentTermsIdDelete**](PaymentTermsApi.md#paymenttermsiddelete) | **DELETE** /PaymentTerms/{id} | Delete a payment term from the client sales settings. (Auth roles: CommonServices_Full) |
| [**PaymentTermsIdPatch**](PaymentTermsApi.md#paymenttermsidpatch) | **PATCH** /PaymentTerms/{id} | Make changes to a payment term in the client sales settings. (Auth roles: CommonServices_Full) |
| [**PaymentTermsPost**](PaymentTermsApi.md#paymenttermspost) | **POST** /PaymentTerms | Create a new payment term in the client sales settings. (Auth roles: CommonServices_Full) |

<a id="getpaymenttermbyid"></a>
# **GetPaymentTermById**
> PaymentTermDto GetPaymentTermById (long id)

Gets the specific payment term by id. (Auth roles: CommonServices,CommonServices_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetPaymentTermByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new PaymentTermsApi(config);
            var id = 12345;  // long | The id of the payment term.

            try
            {
                // Gets the specific payment term by id. (Auth roles: CommonServices,CommonServices_Full)
                PaymentTermDto result = apiInstance.GetPaymentTermById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentTermsApi.GetPaymentTermById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPaymentTermByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the specific payment term by id. (Auth roles: CommonServices,CommonServices_Full)
    ApiResponse<PaymentTermDto> response = apiInstance.GetPaymentTermByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentTermsApi.GetPaymentTermByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | The id of the payment term. |  |

### Return type

[**PaymentTermDto**](PaymentTermDto.md)

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

<a id="getpaymentterms"></a>
# **GetPaymentTerms**
> List&lt;PaymentTermDto&gt; GetPaymentTerms (ResourceParameters resourceParameter = null)

List the payment terms from the client sales settings. (Auth roles: CommonServices,CommonServices_Full)

List the payment terms set on the client.  Go provides a default set of payment terms on new clients, but any custom payment term can be created and used on customers and sales orders created in Go.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetPaymentTermsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new PaymentTermsApi(config);
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // List the payment terms from the client sales settings. (Auth roles: CommonServices,CommonServices_Full)
                List<PaymentTermDto> result = apiInstance.GetPaymentTerms(resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentTermsApi.GetPaymentTerms: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPaymentTermsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List the payment terms from the client sales settings. (Auth roles: CommonServices,CommonServices_Full)
    ApiResponse<List<PaymentTermDto>> response = apiInstance.GetPaymentTermsWithHttpInfo(resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentTermsApi.GetPaymentTermsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;PaymentTermDto&gt;**](PaymentTermDto.md)

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

<a id="paymenttermsiddelete"></a>
# **PaymentTermsIdDelete**
> void PaymentTermsIdDelete (long id)

Delete a payment term from the client sales settings. (Auth roles: CommonServices_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class PaymentTermsIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new PaymentTermsApi(config);
            var id = 789L;  // long | The ID of the payment term.

            try
            {
                // Delete a payment term from the client sales settings. (Auth roles: CommonServices_Full)
                apiInstance.PaymentTermsIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentTermsApi.PaymentTermsIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PaymentTermsIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a payment term from the client sales settings. (Auth roles: CommonServices_Full)
    apiInstance.PaymentTermsIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentTermsApi.PaymentTermsIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | The ID of the payment term. |  |

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
| **201** | Given when resource was successfully created |  -  |
| **404** | Given when the resource was not found |  -  |
| **409** | Given when resource is in use and cannot be deleted |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="paymenttermsidpatch"></a>
# **PaymentTermsIdPatch**
> PaymentTermDto PaymentTermsIdPatch (long id, List<Operation> operation = null)

Make changes to a payment term in the client sales settings. (Auth roles: CommonServices_Full)

Change existing payment term with a given id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class PaymentTermsIdPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new PaymentTermsApi(config);
            var id = 789L;  // long | The id of the payment term.
            var operation = new List<Operation>(); // List<Operation> | JSON Patch structure for updating a Payment Term. See PaymentTermPatchDto schema for all available properties.              For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 (optional) 

            try
            {
                // Make changes to a payment term in the client sales settings. (Auth roles: CommonServices_Full)
                PaymentTermDto result = apiInstance.PaymentTermsIdPatch(id, operation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentTermsApi.PaymentTermsIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PaymentTermsIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Make changes to a payment term in the client sales settings. (Auth roles: CommonServices_Full)
    ApiResponse<PaymentTermDto> response = apiInstance.PaymentTermsIdPatchWithHttpInfo(id, operation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentTermsApi.PaymentTermsIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | The id of the payment term. |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) | JSON Patch structure for updating a Payment Term. See PaymentTermPatchDto schema for all available properties.              For more information on JSON patch and the various operations allowed, check out: https://datatracker.ietf.org/doc/html/rfc6902 | [optional]  |

### Return type

[**PaymentTermDto**](PaymentTermDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="paymenttermspost"></a>
# **PaymentTermsPost**
> PaymentTermDto PaymentTermsPost (PaymentTermPostDto paymentTermPostDto = null)

Create a new payment term in the client sales settings. (Auth roles: CommonServices_Full)

Go provides a default set of payment terms on new clients, but any custom payment term can be created and used on customers and sales orders created in Go.  IsActive defaults to true, if not provided.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class PaymentTermsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new PaymentTermsApi(config);
            var paymentTermPostDto = new PaymentTermPostDto(); // PaymentTermPostDto | A PaymentTermPostDto. (optional) 

            try
            {
                // Create a new payment term in the client sales settings. (Auth roles: CommonServices_Full)
                PaymentTermDto result = apiInstance.PaymentTermsPost(paymentTermPostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentTermsApi.PaymentTermsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PaymentTermsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new payment term in the client sales settings. (Auth roles: CommonServices_Full)
    ApiResponse<PaymentTermDto> response = apiInstance.PaymentTermsPostWithHttpInfo(paymentTermPostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentTermsApi.PaymentTermsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **paymentTermPostDto** | [**PaymentTermPostDto**](PaymentTermPostDto.md) | A PaymentTermPostDto. | [optional]  |

### Return type

[**PaymentTermDto**](PaymentTermDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Given when resource was created successfully |  -  |
| **400** | Given when request was badly formatted |  -  |
| **404** | Given when resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


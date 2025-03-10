# PowerOfficeGoV2.Api.CreateAndSendInvoiceApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetSentState**](CreateAndSendInvoiceApi.md#getsentstate) | **GET** /SalesOrders/sentState | Get the sent state of a sales order. (Auth roles: SalesOrders_Full) |
| [**SalesOrdersIdCreateAndSendInvoicePost**](CreateAndSendInvoiceApi.md#salesordersidcreateandsendinvoicepost) | **POST** /SalesOrders/{id}/createAndSendInvoice | Create a send request for a sales order. (Auth roles: SalesOrders_Full) |

<a id="getsentstate"></a>
# **GetSentState**
> List&lt;InvoiceSentStateDto&gt; GetSentState (Guid id = null)

Get the sent state of a sales order. (Auth roles: SalesOrders_Full)

Can be polled to confirm that the sales order was successfully transformed to an invoice or credit note and delivered.  If delivery failed, LastErrorMessage will have a value.  Note: Imported vouchers and invoices may not have a sent date.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetSentStateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new CreateAndSendInvoiceApi(config);
            var id = "id_example";  // Guid |  (optional) 

            try
            {
                // Get the sent state of a sales order. (Auth roles: SalesOrders_Full)
                List<InvoiceSentStateDto> result = apiInstance.GetSentState(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreateAndSendInvoiceApi.GetSentState: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSentStateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the sent state of a sales order. (Auth roles: SalesOrders_Full)
    ApiResponse<List<InvoiceSentStateDto>> response = apiInstance.GetSentStateWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CreateAndSendInvoiceApi.GetSentStateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  | [optional]  |

### Return type

[**List&lt;InvoiceSentStateDto&gt;**](InvoiceSentStateDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Given when resource returned successfully |  -  |
| **204** | Given when no content is returned. |  -  |
| **404** | Given when resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="salesordersidcreateandsendinvoicepost"></a>
# **SalesOrdersIdCreateAndSendInvoicePost**
> SendInvoiceRequestDto SalesOrdersIdCreateAndSendInvoicePost (Guid id, SendInvoiceRequestPostDto sendInvoiceRequestPostDto = null)

Create a send request for a sales order. (Auth roles: SalesOrders_Full)

Transforms the sales order to an invoice or credit note and delivers it to the customer.  If the request is successful, a 202Accepted response code will be returned,  and the header Location will contain a URL to the status endpoint with the sales order id.  The integration must have the invoice sending privilege.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class SalesOrdersIdCreateAndSendInvoicePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new CreateAndSendInvoiceApi(config);
            var id = "id_example";  // Guid | 
            var sendInvoiceRequestPostDto = new SendInvoiceRequestPostDto(); // SendInvoiceRequestPostDto |  (optional) 

            try
            {
                // Create a send request for a sales order. (Auth roles: SalesOrders_Full)
                SendInvoiceRequestDto result = apiInstance.SalesOrdersIdCreateAndSendInvoicePost(id, sendInvoiceRequestPostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreateAndSendInvoiceApi.SalesOrdersIdCreateAndSendInvoicePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SalesOrdersIdCreateAndSendInvoicePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a send request for a sales order. (Auth roles: SalesOrders_Full)
    ApiResponse<SendInvoiceRequestDto> response = apiInstance.SalesOrdersIdCreateAndSendInvoicePostWithHttpInfo(id, sendInvoiceRequestPostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CreateAndSendInvoiceApi.SalesOrdersIdCreateAndSendInvoicePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **sendInvoiceRequestPostDto** | [**SendInvoiceRequestPostDto**](SendInvoiceRequestPostDto.md) |  | [optional]  |

### Return type

[**SendInvoiceRequestDto**](SendInvoiceRequestDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Given when sales order is queued for delivery. |  -  |
| **400** | Given when request is badly formatted |  -  |
| **404** | Given when resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


# PowerOfficeGoV2.Api.OutgoingInvoicesApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetOutgoingInvoiceById**](OutgoingInvoicesApi.md#getoutgoinginvoicebyid) | **GET** /OutgoingInvoices/{id} | Gets the specific outgoing invoice / credit note by id.  The returned object are a lightweight version of an invoice, not containing any line details. (Auth roles: OutgoingInvoice,OutgoingInvoice_Full) |
| [**OutgoingInvoicesGet**](OutgoingInvoicesApi.md#outgoinginvoicesget) | **GET** /OutgoingInvoices | Gets the sent outgoing invoices from the client.  The returned objects are a lightweight version of an invoice, not containing any line details.  Multiple filtering options. (Auth roles: OutgoingInvoice,OutgoingInvoice_Full) |
| [**OutgoingInvoicesIdLinesGet**](OutgoingInvoicesApi.md#outgoinginvoicesidlinesget) | **GET** /OutgoingInvoices/{id}/Lines | Gets the lines of the specific outgoing invoice / credit note (specified by id).  The returned objects are the line details.  Note that the line information might not be complete or present if the invoice was imported to Go (ie. not generated and sent from Go). (Auth roles: OutgoingInvoice,OutgoingInvoice_Full) |

<a id="getoutgoinginvoicebyid"></a>
# **GetOutgoingInvoiceById**
> OutgoingInvoiceDto GetOutgoingInvoiceById (Guid id)

Gets the specific outgoing invoice / credit note by id.  The returned object are a lightweight version of an invoice, not containing any line details. (Auth roles: OutgoingInvoice,OutgoingInvoice_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetOutgoingInvoiceByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new OutgoingInvoicesApi(config);
            var id = 38ecfc1a-bf51-448f-99a8-a61bc5771109;  // Guid | The id of the outgoing invoice / credit note.

            try
            {
                // Gets the specific outgoing invoice / credit note by id.  The returned object are a lightweight version of an invoice, not containing any line details. (Auth roles: OutgoingInvoice,OutgoingInvoice_Full)
                OutgoingInvoiceDto result = apiInstance.GetOutgoingInvoiceById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OutgoingInvoicesApi.GetOutgoingInvoiceById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOutgoingInvoiceByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the specific outgoing invoice / credit note by id.  The returned object are a lightweight version of an invoice, not containing any line details. (Auth roles: OutgoingInvoice,OutgoingInvoice_Full)
    ApiResponse<OutgoingInvoiceDto> response = apiInstance.GetOutgoingInvoiceByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OutgoingInvoicesApi.GetOutgoingInvoiceByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The id of the outgoing invoice / credit note. |  |

### Return type

[**OutgoingInvoiceDto**](OutgoingInvoiceDto.md)

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

<a id="outgoinginvoicesget"></a>
# **OutgoingInvoicesGet**
> List&lt;OutgoingInvoiceDto&gt; OutgoingInvoicesGet (DateTimeOffset balanceLastChangedDateTimeOffsetGreaterThan = null, string customerNos = null, string customMatchingReferences = null, string departmentCodes = null, DateTimeOffset fromDate = null, bool includeSubProject = null, string invoiceIds = null, string invoiceNos = null, bool onlyCreatedByCurrentIntegration = null, bool onlyUnpaidInvoices = null, string projectCodes = null, DateTimeOffset sentDateTimeOffsetGreaterThan = null, DateTimeOffset toDate = null, string voucherNos = null, ResourceParameters resourceParameter = null)

Gets the sent outgoing invoices from the client.  The returned objects are a lightweight version of an invoice, not containing any line details.  Multiple filtering options. (Auth roles: OutgoingInvoice,OutgoingInvoice_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class OutgoingInvoicesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new OutgoingInvoicesApi(config);
            var balanceLastChangedDateTimeOffsetGreaterThan = 2021-09-25 08:03:00.1234567 -00:00;  // DateTimeOffset | Filter invoices with last changed timestamp in balance (remaining amount to be paid) greater than the provided timestamp. Can be used as a lightweight version of retrieving payment states of invoices. Timestamp not inclusive. (optional) 
            var customerNos = 10000-11000, 12000, 13000-;  // string | Filter by customer numbers. Separate by comma [,] to filter on multiple customer numbers. A range of numbers can be specified using dash/hyphen [-]. For example \"10000-11000, 12000, 13000-\" will result in invoices from customers with numbers from and including 10000 to 11000, 12000, 13000 and all above will be returned. If null or whitespace, the filter is not used. (optional) 
            var customMatchingReferences = 12345, abc123;  // string | Filter by custom matching references. Separate by comma [,] to filter on multiple custom matching references. (optional) 
            var departmentCodes = 1, 3, 4;  // string | Filter by department codes. Note that this selects invoices with department set in the header of the invoice. The invoice lines might specify other departments or no department. Separate by comma [,] to filter on multiple codes. If -1, then all invoices without department codes are returned. If null or whitespace, the filter is not used. (optional) 
            var fromDate = 2021-01-01;  // DateTimeOffset | From date, inclusive. Get all invoices with an voucher (invoice) date from this date (inclusive). Note that (date time) offsets (if provided) is not taken into account, only date is used. (optional) 
            var includeSubProject = true;  // bool | Include sub-project(s) for the currently filtered project(s). If projectCodes is null or whitespace, all (sub)projects are included (regardless of this variable). (optional) 
            var invoiceIds = 38ecfc1a-bf51-448f-99a8-a61bc5771109, ee373540-ca8d-4562-8fb6-6fb52de47722;  // string | Filter by invoice IDs. Separate by comma [,] to filter on multiple invoice IDs. If null or whitespace, the filter is not used. (optional) 
            var invoiceNos = 1-5, 7, 9-;  // string | Filter by invoice numbers. Separate by comma [,] to filter on multiple invoice numbers. A range of numbers can be specified using dash/hyphen [-]. For example \"1-5, 7, 9-\" will result in invoices with numbers 1 to 5, 7, 9 and all above will be returned. If null or whitespace, the filter is not used. (optional) 
            var onlyCreatedByCurrentIntegration = true;  // bool | Filter on invoices that the current integration has created. Can be used to return only invoices that the (currently) querying integration has created. Note that invoices are considered created by an integration only if they are posted with the OutgoingInvoiceVoucher endpoint, or if the invoice was sent using the SalesOrders endpoint. If a sales order draft was posted/sent by a user in the GUI, it will be the user that posted/sent it that created the outgoing invoice. (optional) 
            var onlyUnpaidInvoices = true;  // bool | Filter on invoices that are unpaid (ie balance != 0). (optional) 
            var projectCodes = 10, 20, 30.1;  // string | Filter by project codes. Separate by comma [,] to filter on multiple codes. If -1, then all invoices without project codes are returned. If null or whitespace, all invoices with or without project codes are returned (filter is not used). (optional) 
            var sentDateTimeOffsetGreaterThan = 2021-09-25 08:03:00.1234567 -00:00;  // DateTimeOffset | Filter invoices based on the sent timestamp. The Sent timestamp of when the invoice was generated and sent from Go (which might differ from the invoice date). This property is only set on the invoices generated in Go, and blank if invoices was imported (using a file or the api). Using this filter is one option of retrieving new invoices from Go. Timestamp not inclusive. (optional) 
            var toDate = 2021-01-28;  // DateTimeOffset | To date, inclusive. Get all invoices with an voucher (invoice) date up to this date (inclusive). Note that (date time) offsets (if provided) is not taken into account, only date is used. (optional) 
            var voucherNos = 1-5, 7, 9-;  // string | Filter by voucher numbers. Separate by comma [,] to filter on multiple voucher numbers. A range of numbers can be specified using dash/hyphen [-]. For example \"1-5, 7, 9-\" will result in invoices with voucher numbers from 1 to 5, 7, 9 and all above will be returned. If null or whitespace, the filter is not used. (optional) 
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Gets the sent outgoing invoices from the client.  The returned objects are a lightweight version of an invoice, not containing any line details.  Multiple filtering options. (Auth roles: OutgoingInvoice,OutgoingInvoice_Full)
                List<OutgoingInvoiceDto> result = apiInstance.OutgoingInvoicesGet(balanceLastChangedDateTimeOffsetGreaterThan, customerNos, customMatchingReferences, departmentCodes, fromDate, includeSubProject, invoiceIds, invoiceNos, onlyCreatedByCurrentIntegration, onlyUnpaidInvoices, projectCodes, sentDateTimeOffsetGreaterThan, toDate, voucherNos, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OutgoingInvoicesApi.OutgoingInvoicesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OutgoingInvoicesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the sent outgoing invoices from the client.  The returned objects are a lightweight version of an invoice, not containing any line details.  Multiple filtering options. (Auth roles: OutgoingInvoice,OutgoingInvoice_Full)
    ApiResponse<List<OutgoingInvoiceDto>> response = apiInstance.OutgoingInvoicesGetWithHttpInfo(balanceLastChangedDateTimeOffsetGreaterThan, customerNos, customMatchingReferences, departmentCodes, fromDate, includeSubProject, invoiceIds, invoiceNos, onlyCreatedByCurrentIntegration, onlyUnpaidInvoices, projectCodes, sentDateTimeOffsetGreaterThan, toDate, voucherNos, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OutgoingInvoicesApi.OutgoingInvoicesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **balanceLastChangedDateTimeOffsetGreaterThan** | **DateTimeOffset** | Filter invoices with last changed timestamp in balance (remaining amount to be paid) greater than the provided timestamp. Can be used as a lightweight version of retrieving payment states of invoices. Timestamp not inclusive. | [optional]  |
| **customerNos** | **string** | Filter by customer numbers. Separate by comma [,] to filter on multiple customer numbers. A range of numbers can be specified using dash/hyphen [-]. For example \&quot;10000-11000, 12000, 13000-\&quot; will result in invoices from customers with numbers from and including 10000 to 11000, 12000, 13000 and all above will be returned. If null or whitespace, the filter is not used. | [optional]  |
| **customMatchingReferences** | **string** | Filter by custom matching references. Separate by comma [,] to filter on multiple custom matching references. | [optional]  |
| **departmentCodes** | **string** | Filter by department codes. Note that this selects invoices with department set in the header of the invoice. The invoice lines might specify other departments or no department. Separate by comma [,] to filter on multiple codes. If -1, then all invoices without department codes are returned. If null or whitespace, the filter is not used. | [optional]  |
| **fromDate** | **DateTimeOffset** | From date, inclusive. Get all invoices with an voucher (invoice) date from this date (inclusive). Note that (date time) offsets (if provided) is not taken into account, only date is used. | [optional]  |
| **includeSubProject** | **bool** | Include sub-project(s) for the currently filtered project(s). If projectCodes is null or whitespace, all (sub)projects are included (regardless of this variable). | [optional]  |
| **invoiceIds** | **string** | Filter by invoice IDs. Separate by comma [,] to filter on multiple invoice IDs. If null or whitespace, the filter is not used. | [optional]  |
| **invoiceNos** | **string** | Filter by invoice numbers. Separate by comma [,] to filter on multiple invoice numbers. A range of numbers can be specified using dash/hyphen [-]. For example \&quot;1-5, 7, 9-\&quot; will result in invoices with numbers 1 to 5, 7, 9 and all above will be returned. If null or whitespace, the filter is not used. | [optional]  |
| **onlyCreatedByCurrentIntegration** | **bool** | Filter on invoices that the current integration has created. Can be used to return only invoices that the (currently) querying integration has created. Note that invoices are considered created by an integration only if they are posted with the OutgoingInvoiceVoucher endpoint, or if the invoice was sent using the SalesOrders endpoint. If a sales order draft was posted/sent by a user in the GUI, it will be the user that posted/sent it that created the outgoing invoice. | [optional]  |
| **onlyUnpaidInvoices** | **bool** | Filter on invoices that are unpaid (ie balance !&#x3D; 0). | [optional]  |
| **projectCodes** | **string** | Filter by project codes. Separate by comma [,] to filter on multiple codes. If -1, then all invoices without project codes are returned. If null or whitespace, all invoices with or without project codes are returned (filter is not used). | [optional]  |
| **sentDateTimeOffsetGreaterThan** | **DateTimeOffset** | Filter invoices based on the sent timestamp. The Sent timestamp of when the invoice was generated and sent from Go (which might differ from the invoice date). This property is only set on the invoices generated in Go, and blank if invoices was imported (using a file or the api). Using this filter is one option of retrieving new invoices from Go. Timestamp not inclusive. | [optional]  |
| **toDate** | **DateTimeOffset** | To date, inclusive. Get all invoices with an voucher (invoice) date up to this date (inclusive). Note that (date time) offsets (if provided) is not taken into account, only date is used. | [optional]  |
| **voucherNos** | **string** | Filter by voucher numbers. Separate by comma [,] to filter on multiple voucher numbers. A range of numbers can be specified using dash/hyphen [-]. For example \&quot;1-5, 7, 9-\&quot; will result in invoices with voucher numbers from 1 to 5, 7, 9 and all above will be returned. If null or whitespace, the filter is not used. | [optional]  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;OutgoingInvoiceDto&gt;**](OutgoingInvoiceDto.md)

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

<a id="outgoinginvoicesidlinesget"></a>
# **OutgoingInvoicesIdLinesGet**
> List&lt;OutgoingInvoiceLineDto&gt; OutgoingInvoicesIdLinesGet (Guid id, ResourceParameters resourceParameter = null)

Gets the lines of the specific outgoing invoice / credit note (specified by id).  The returned objects are the line details.  Note that the line information might not be complete or present if the invoice was imported to Go (ie. not generated and sent from Go). (Auth roles: OutgoingInvoice,OutgoingInvoice_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class OutgoingInvoicesIdLinesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new OutgoingInvoicesApi(config);
            var id = "id_example";  // Guid | 
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Gets the lines of the specific outgoing invoice / credit note (specified by id).  The returned objects are the line details.  Note that the line information might not be complete or present if the invoice was imported to Go (ie. not generated and sent from Go). (Auth roles: OutgoingInvoice,OutgoingInvoice_Full)
                List<OutgoingInvoiceLineDto> result = apiInstance.OutgoingInvoicesIdLinesGet(id, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OutgoingInvoicesApi.OutgoingInvoicesIdLinesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OutgoingInvoicesIdLinesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the lines of the specific outgoing invoice / credit note (specified by id).  The returned objects are the line details.  Note that the line information might not be complete or present if the invoice was imported to Go (ie. not generated and sent from Go). (Auth roles: OutgoingInvoice,OutgoingInvoice_Full)
    ApiResponse<List<OutgoingInvoiceLineDto>> response = apiInstance.OutgoingInvoicesIdLinesGetWithHttpInfo(id, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OutgoingInvoicesApi.OutgoingInvoicesIdLinesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;OutgoingInvoiceLineDto&gt;**](OutgoingInvoiceLineDto.md)

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


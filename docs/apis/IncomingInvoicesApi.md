# PowerOfficeGoV2.Api.IncomingInvoicesApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetIncomingInvoiceListItem**](IncomingInvoicesApi.md#getincominginvoicelistitem) | **GET** /IncomingInvoices | Gets the posted incoming invoices from the client. The returned objects are a lightweight version of a supplier invoice (or credit note), not containing the cost transaction lines. Use the endpoint AccountTransactions if all voucher lines are needed. Multiple filtering options. (Auth roles: IncomingInvoice,IncomingInvoice_Full) |
| [**IncomingInvoicesIdGet**](IncomingInvoicesApi.md#incominginvoicesidget) | **GET** /IncomingInvoices/{id} | Get an IncomingInvoiceListItem by Id (Auth roles: IncomingInvoice,IncomingInvoice_Full) |

<a id="getincominginvoicelistitem"></a>
# **GetIncomingInvoiceListItem**
> List&lt;IncomingInvoiceListItemDto&gt; GetIncomingInvoiceListItem (DateTimeOffset fromDate = null, DateTimeOffset toDate = null, DateTimeOffset balanceLastChangedDateTimeOffsetGreaterThan = null, string departmentCodes = null, bool includeSubProject = null, bool onlyUnpaidInvoices = null, string projectCodes = null, string supplierNos = null, string voucherNos = null, string voucherTypes = null, ResourceParameters resourceParameter = null)

Gets the posted incoming invoices from the client. The returned objects are a lightweight version of a supplier invoice (or credit note), not containing the cost transaction lines. Use the endpoint AccountTransactions if all voucher lines are needed. Multiple filtering options. (Auth roles: IncomingInvoice,IncomingInvoice_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetIncomingInvoiceListItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new IncomingInvoicesApi(config);
            var fromDate = 2023-01-26;  // DateTimeOffset | From date, inclusive. Get all invoices with an voucher (invoice) date from this date (inclusive). Note that (date time) offsets (if provided) is not taken into account, only date is used. (optional) 
            var toDate = 2023-02-28;  // DateTimeOffset | To date, inclusive. Get all invoices with an voucher (invoice) date up to this date (inclusive). Note that (date time) offsets (if provided) is not taken into account, only date is used. (optional) 
            var balanceLastChangedDateTimeOffsetGreaterThan = 2023-01-26 13:20:16.1234567 -00:00;  // DateTimeOffset | Filter invoices with last changed timestamp in balance (remaining amount to be paid) greater than the provided timestamp. Can be used as a lightweight version of retrieving payment states of invoices. Timestamp not inclusive. (optional) 
            var departmentCodes = 1, Development;  // string | Filter invoices on department codes. Note that this selects invoices with department set in the header of the invoice. The invoice costlines might specify other departments or no department. Separate by comma to filter on multiple codes. If blank, all invoices with or without department codes are returned (no filter). If -1, then all invoices without department codes are included. (optional) 
            var includeSubProject = true;  // bool | Include Sub-project(s) for specified project. If projectCodes is null, all (sub)projects are included (regardless of this variable). (optional) 
            var onlyUnpaidInvoices = true;  // bool | Filter on invoices that are unpaid (ie balance != 0). No filter set will provide all invoices regardless of balance state, depending on other filters set. (optional) 
            var projectCodes = 1, Kitchen;  // string | Filter invoices on project codes. Separate by comma to filter on multiple codes. If blank, all transactions with or without projects codes are returned (no filter). (optional) 
            var supplierNos = 20000-25999, 22500, 23000-;  // string | Filter by supplier numbers. SearchString should be in the form of \"20000-25999, 22500, 23000-\" where invoices from suppliers with numbers from (and including) 20000 to 25999, 22500 and all over 23000 will be selected. If filterString is null or whitespace, query is returned as is. (optional) 
            var voucherNos = 69;  // string | Filter on invoices voucher number. SearchString should be in the form of \"1-15, 42, 690-\" where voucher numbers from (and including) 1 to 15, 42 and 690 to infinity are selected. All vouchers in Go are posted in the same ascending voucher number series. (optional) 
            var voucherTypes = IncomingInvoice, IncomingCreditNote;  // string | Filter by voucher type. Defaults to incoming invoice and incoming credit note if no parameter is supplied. (optional) 
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Gets the posted incoming invoices from the client. The returned objects are a lightweight version of a supplier invoice (or credit note), not containing the cost transaction lines. Use the endpoint AccountTransactions if all voucher lines are needed. Multiple filtering options. (Auth roles: IncomingInvoice,IncomingInvoice_Full)
                List<IncomingInvoiceListItemDto> result = apiInstance.GetIncomingInvoiceListItem(fromDate, toDate, balanceLastChangedDateTimeOffsetGreaterThan, departmentCodes, includeSubProject, onlyUnpaidInvoices, projectCodes, supplierNos, voucherNos, voucherTypes, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IncomingInvoicesApi.GetIncomingInvoiceListItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetIncomingInvoiceListItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the posted incoming invoices from the client. The returned objects are a lightweight version of a supplier invoice (or credit note), not containing the cost transaction lines. Use the endpoint AccountTransactions if all voucher lines are needed. Multiple filtering options. (Auth roles: IncomingInvoice,IncomingInvoice_Full)
    ApiResponse<List<IncomingInvoiceListItemDto>> response = apiInstance.GetIncomingInvoiceListItemWithHttpInfo(fromDate, toDate, balanceLastChangedDateTimeOffsetGreaterThan, departmentCodes, includeSubProject, onlyUnpaidInvoices, projectCodes, supplierNos, voucherNos, voucherTypes, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IncomingInvoicesApi.GetIncomingInvoiceListItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fromDate** | **DateTimeOffset** | From date, inclusive. Get all invoices with an voucher (invoice) date from this date (inclusive). Note that (date time) offsets (if provided) is not taken into account, only date is used. | [optional]  |
| **toDate** | **DateTimeOffset** | To date, inclusive. Get all invoices with an voucher (invoice) date up to this date (inclusive). Note that (date time) offsets (if provided) is not taken into account, only date is used. | [optional]  |
| **balanceLastChangedDateTimeOffsetGreaterThan** | **DateTimeOffset** | Filter invoices with last changed timestamp in balance (remaining amount to be paid) greater than the provided timestamp. Can be used as a lightweight version of retrieving payment states of invoices. Timestamp not inclusive. | [optional]  |
| **departmentCodes** | **string** | Filter invoices on department codes. Note that this selects invoices with department set in the header of the invoice. The invoice costlines might specify other departments or no department. Separate by comma to filter on multiple codes. If blank, all invoices with or without department codes are returned (no filter). If -1, then all invoices without department codes are included. | [optional]  |
| **includeSubProject** | **bool** | Include Sub-project(s) for specified project. If projectCodes is null, all (sub)projects are included (regardless of this variable). | [optional]  |
| **onlyUnpaidInvoices** | **bool** | Filter on invoices that are unpaid (ie balance !&#x3D; 0). No filter set will provide all invoices regardless of balance state, depending on other filters set. | [optional]  |
| **projectCodes** | **string** | Filter invoices on project codes. Separate by comma to filter on multiple codes. If blank, all transactions with or without projects codes are returned (no filter). | [optional]  |
| **supplierNos** | **string** | Filter by supplier numbers. SearchString should be in the form of \&quot;20000-25999, 22500, 23000-\&quot; where invoices from suppliers with numbers from (and including) 20000 to 25999, 22500 and all over 23000 will be selected. If filterString is null or whitespace, query is returned as is. | [optional]  |
| **voucherNos** | **string** | Filter on invoices voucher number. SearchString should be in the form of \&quot;1-15, 42, 690-\&quot; where voucher numbers from (and including) 1 to 15, 42 and 690 to infinity are selected. All vouchers in Go are posted in the same ascending voucher number series. | [optional]  |
| **voucherTypes** | **string** | Filter by voucher type. Defaults to incoming invoice and incoming credit note if no parameter is supplied. | [optional]  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;IncomingInvoiceListItemDto&gt;**](IncomingInvoiceListItemDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Given when resource returned successfully |  -  |
| **204** | Given when resource returned no content |  -  |
| **400** | Given when request is badly formatted |  -  |
| **404** | Given when resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="incominginvoicesidget"></a>
# **IncomingInvoicesIdGet**
> IncomingInvoiceListItemDto IncomingInvoicesIdGet (Guid id)

Get an IncomingInvoiceListItem by Id (Auth roles: IncomingInvoice,IncomingInvoice_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class IncomingInvoicesIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new IncomingInvoicesApi(config);
            var id = "id_example";  // Guid | Id of the IncomingInvoiceListItem

            try
            {
                // Get an IncomingInvoiceListItem by Id (Auth roles: IncomingInvoice,IncomingInvoice_Full)
                IncomingInvoiceListItemDto result = apiInstance.IncomingInvoicesIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IncomingInvoicesApi.IncomingInvoicesIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IncomingInvoicesIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an IncomingInvoiceListItem by Id (Auth roles: IncomingInvoice,IncomingInvoice_Full)
    ApiResponse<IncomingInvoiceListItemDto> response = apiInstance.IncomingInvoicesIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IncomingInvoicesApi.IncomingInvoicesIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Id of the IncomingInvoiceListItem |  |

### Return type

[**IncomingInvoiceListItemDto**](IncomingInvoiceListItemDto.md)

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


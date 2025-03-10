# PowerOfficeGoV2.Api.CustomerSubLedgerEntriesApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CustomerledgerCustomerBalancesGet**](CustomerSubLedgerEntriesApi.md#customerledgercustomerbalancesget) | **GET** /Customerledger/CustomerBalances | Gets the customer balances at a given date (inclusive).  The balances represent the sum of accounts receivable for the customers at the given date.  NOTE: Customers without any ledger entries are not shown.  Multiple filtering options. (Auth roles: CustomerLedger,CustomerLedger_Full) |
| [**CustomerledgerEntriesByMatchIdGet**](CustomerSubLedgerEntriesApi.md#customerledgerentriesbymatchidget) | **GET** /Customerledger/EntriesByMatchId | Gets all customer sub-ledger transactions that share a given match ID. (Auth roles: CustomerLedger,CustomerLedger_Full) |
| [**CustomerledgerOpenItemsGet**](CustomerSubLedgerEntriesApi.md#customerledgeropenitemsget) | **GET** /Customerledger/OpenItems | Gets all customer sub-ledger transactions that are open items at a given date (inclusive). Multiple filtering options. (Auth roles: CustomerLedger,CustomerLedger_Full) |
| [**CustomerledgerStatementGet**](CustomerSubLedgerEntriesApi.md#customerledgerstatementget) | **GET** /Customerledger/Statement | Gets all customer sub-ledger transactions between two dates (inclusive). The dates represent the posted date (date of accounting effect). Multiple filtering options. (Auth roles: CustomerLedger,CustomerLedger_Full) |

<a id="customerledgercustomerbalancesget"></a>
# **CustomerledgerCustomerBalancesGet**
> List&lt;CustomerBalanceDto&gt; CustomerledgerCustomerBalancesGet (DateOnly date, string contactGroupIds = null, bool includeOnlyOpenItems = null, string subLedgerNumberSeriesIds = null, ResourceParameters resourceParameter = null)

Gets the customer balances at a given date (inclusive).  The balances represent the sum of accounts receivable for the customers at the given date.  NOTE: Customers without any ledger entries are not shown.  Multiple filtering options. (Auth roles: CustomerLedger,CustomerLedger_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class CustomerledgerCustomerBalancesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new CustomerSubLedgerEntriesApi(config);
            var date = 2021-01-01;  // DateOnly | Date, inclusive. Get all balances as of this date. Note that (date time) offsets (if provided) is not taken into account, only date is used.
            var contactGroupIds = 41345, 21445, 65457;  // string | Filter balances by contact group IDs. This will return the balances for the customers belonging in the given contact groups. Separate by comma to filter on multiple contact group IDs. If filterString is null or whitespace, query is returned as is. (optional) 
            var includeOnlyOpenItems = true;  // bool | Sets whether or not to return balances for customers with only open items. If false, all active customers and their balances will be returned, including zero balances for customers with no open items. NOTE: Customers without any ledger entries are not shown. (optional) 
            var subLedgerNumberSeriesIds = 38ecfc1a-bf51-448f-99a8-a61bc5771109, ee373540-ca8d-4562-8fb6-6fb52de47722;  // string | Filter balances by sub-ledger number series IDs. This will return balances for the customers belonging in the given sub-ledger number series. Separate by comma to filter on multiple sub-ledger number series IDs. If filterString is null or whitespace, query is returned as is.\" (optional) 
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Gets the customer balances at a given date (inclusive).  The balances represent the sum of accounts receivable for the customers at the given date.  NOTE: Customers without any ledger entries are not shown.  Multiple filtering options. (Auth roles: CustomerLedger,CustomerLedger_Full)
                List<CustomerBalanceDto> result = apiInstance.CustomerledgerCustomerBalancesGet(date, contactGroupIds, includeOnlyOpenItems, subLedgerNumberSeriesIds, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomerSubLedgerEntriesApi.CustomerledgerCustomerBalancesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CustomerledgerCustomerBalancesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the customer balances at a given date (inclusive).  The balances represent the sum of accounts receivable for the customers at the given date.  NOTE: Customers without any ledger entries are not shown.  Multiple filtering options. (Auth roles: CustomerLedger,CustomerLedger_Full)
    ApiResponse<List<CustomerBalanceDto>> response = apiInstance.CustomerledgerCustomerBalancesGetWithHttpInfo(date, contactGroupIds, includeOnlyOpenItems, subLedgerNumberSeriesIds, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomerSubLedgerEntriesApi.CustomerledgerCustomerBalancesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **date** | **DateOnly** | Date, inclusive. Get all balances as of this date. Note that (date time) offsets (if provided) is not taken into account, only date is used. |  |
| **contactGroupIds** | **string** | Filter balances by contact group IDs. This will return the balances for the customers belonging in the given contact groups. Separate by comma to filter on multiple contact group IDs. If filterString is null or whitespace, query is returned as is. | [optional]  |
| **includeOnlyOpenItems** | **bool** | Sets whether or not to return balances for customers with only open items. If false, all active customers and their balances will be returned, including zero balances for customers with no open items. NOTE: Customers without any ledger entries are not shown. | [optional]  |
| **subLedgerNumberSeriesIds** | **string** | Filter balances by sub-ledger number series IDs. This will return balances for the customers belonging in the given sub-ledger number series. Separate by comma to filter on multiple sub-ledger number series IDs. If filterString is null or whitespace, query is returned as is.\&quot; | [optional]  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;CustomerBalanceDto&gt;**](CustomerBalanceDto.md)

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

<a id="customerledgerentriesbymatchidget"></a>
# **CustomerledgerEntriesByMatchIdGet**
> List&lt;CustomerLedgerEntryDto&gt; CustomerledgerEntriesByMatchIdGet (long matchId, ResourceParameters resourceParameter = null)

Gets all customer sub-ledger transactions that share a given match ID. (Auth roles: CustomerLedger,CustomerLedger_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class CustomerledgerEntriesByMatchIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new CustomerSubLedgerEntriesApi(config);
            var matchId = 12345;  // long | The match ID to filter for.
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Gets all customer sub-ledger transactions that share a given match ID. (Auth roles: CustomerLedger,CustomerLedger_Full)
                List<CustomerLedgerEntryDto> result = apiInstance.CustomerledgerEntriesByMatchIdGet(matchId, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomerSubLedgerEntriesApi.CustomerledgerEntriesByMatchIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CustomerledgerEntriesByMatchIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets all customer sub-ledger transactions that share a given match ID. (Auth roles: CustomerLedger,CustomerLedger_Full)
    ApiResponse<List<CustomerLedgerEntryDto>> response = apiInstance.CustomerledgerEntriesByMatchIdGetWithHttpInfo(matchId, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomerSubLedgerEntriesApi.CustomerledgerEntriesByMatchIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **matchId** | **long** | The match ID to filter for. |  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;CustomerLedgerEntryDto&gt;**](CustomerLedgerEntryDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Given when resource returned successfully |  -  |
| **204** | Given when there is no content to return (response body is empty). This could happen if matchId exist, but match is not on a customer sub-ledger transaction. |  -  |
| **400** | Given when request is badly formatted |  -  |
| **404** | Given when resource was not found |  -  |
| **401** | Given when request is unauthorized (Access Token is missing or invalid) |  -  |
| **403** | Given when request is forbidden (Integration does not have required permission to use endpoint) |  -  |
| **429** | Given when request is throttled (too many requests) |  -  |
| **0** | When request is not processed correctly a ProblemDetail object is returned |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="customerledgeropenitemsget"></a>
# **CustomerledgerOpenItemsGet**
> List&lt;CustomerLedgerEntryDto&gt; CustomerledgerOpenItemsGet (DateOnly date, string contactGroupIds = null, DateTime createdDateTimeOffsetGreaterThan = null, string customerNos = null, string customMatchingReferences = null, string departmentCodes = null, string externalNos = null, bool includeSubProject = null, string invoiceNos = null, DateTime lastChangedDateTimeOffsetGreaterThan = null, bool onlyBalancesLessThanAmount = null, bool onlyCreatedByCurrentIntegration = null, string projectCodes = null, string subLedgerNumberSeriesIds = null, string voucherTypes = null, ResourceParameters resourceParameter = null)

Gets all customer sub-ledger transactions that are open items at a given date (inclusive). Multiple filtering options. (Auth roles: CustomerLedger,CustomerLedger_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class CustomerledgerOpenItemsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new CustomerSubLedgerEntriesApi(config);
            var date = 2021-01-01;  // DateOnly | Date, inclusive. Get all open entries as of this date. Note that (date time) offsets (if provided) is not taken into account, only date is used.
            var contactGroupIds = 41345, 21445, 65457;  // string | Filter by contact group IDs. This will return entries for the customers belonging in the given contact groups. Separate by comma to filter on multiple contact group IDs. If filterString is null or whitespace, query is returned as is. (optional) 
            var createdDateTimeOffsetGreaterThan = 2021-09-25 08:03:00.1234567 -00:00;  // DateTime | Filter entries based on the created timestamp property. This filtering will return all entries with a created timestamp greater than the timestamp provided. Can be used when polling for new entries from Go. Date not inclusive. (optional) 
            var customerNos = 10000-15990, 12500, 13000-;  // string | Filter by customer numbers. Customer number also represent the customer sub-ledger account number. SearchString should be in the form of \"10000-15999, 12500, 13000-\" where values from 10000 to 15999, 12500 and all over 13000 will be selected. If filterString is null or whitespace, query is returned as is. (optional) 
            var customMatchingReferences = cmr101;  // string | Filter transactions on invoices with given custom matching references. Separate by comma to filter on multiple custom matching references. (optional) 
            var departmentCodes = 1, 3, 4;  // string | Filter entries on department codes. Separate by comma to filter on multiple codes. If blank, all transactions with or without department codes are returned (no filter). If -1, then all transactions without department codes are included. (optional) 
            var externalNos = 30000, 14153-19534, 150000-;  // string | Filter by customer external numbers. SearchString should be in the form of \"30000, 14153-19534, 150000-\" where values for 30000, between (inclusive) 14153-19534 and all over 150000 (inclusive) will be retrieved. If filterString is null or whitespace, query is returned as is. (optional) 
            var includeSubProject = true;  // bool | Include Sub-project(s) for specified project. If projectCodes is null, all (sub)projects are included (regardless of this variable). (optional) 
            var invoiceNos = 1337, 69420;  // string | Filter transactions for invoices with given invoice numbers. Separate by comma to filter on multiple invoice numbers. (optional) 
            var lastChangedDateTimeOffsetGreaterThan = 2021-09-25 08:03:00.1234567 -00:00;  // DateTime | Filter entries based on the last changed timestamp property. The accounting entry in itself cannot change, but the match state of the sub-ledger entry might change. Using last changed filtering is one way of retrieving new matched items and as such the payment status of invoices. This filtering will return all entries with a last changed timestamp greater than the timestamp provided. Date not inclusive. (optional) 
            var onlyBalancesLessThanAmount = true;  // bool | Filter on transactions with balances less than amount. This will only provide entries with matches that are still open. (optional) 
            var onlyCreatedByCurrentIntegration = true;  // bool | Sets whether or not to return only entries that the current integration created. Can be used to reduce the number of entries if only the status of transactions that the querying integration created are relevant to report. (optional) 
            var projectCodes = 10, 20, 30.1;  // string | Filter entries on project codes. Separate by comma to filter on multiple codes. If blank, all transactions with or without projects codes are returned (no filter). If -1, then all transactions without project codes are included. (optional) 
            var subLedgerNumberSeriesIds = 38ecfc1a-bf51-448f-99a8-a61bc5771109, ee373540-ca8d-4562-8fb6-6fb52de47722;  // string | Filter items by sub-ledger number series IDs. This will return entries for the customers belonging in the given sub-ledger number series. Separate by comma to filter on multiple sub-ledger number series IDs. If filterString is null or whitespace, query is returned as is.\" (optional) 
            var voucherTypes = OutgoingInvoice, BankJournal;  // string | Filter by voucher types. Separate by comma to filter multiple voucher types. If blank, all transactions returned (no filter). (optional) 
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Gets all customer sub-ledger transactions that are open items at a given date (inclusive). Multiple filtering options. (Auth roles: CustomerLedger,CustomerLedger_Full)
                List<CustomerLedgerEntryDto> result = apiInstance.CustomerledgerOpenItemsGet(date, contactGroupIds, createdDateTimeOffsetGreaterThan, customerNos, customMatchingReferences, departmentCodes, externalNos, includeSubProject, invoiceNos, lastChangedDateTimeOffsetGreaterThan, onlyBalancesLessThanAmount, onlyCreatedByCurrentIntegration, projectCodes, subLedgerNumberSeriesIds, voucherTypes, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomerSubLedgerEntriesApi.CustomerledgerOpenItemsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CustomerledgerOpenItemsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets all customer sub-ledger transactions that are open items at a given date (inclusive). Multiple filtering options. (Auth roles: CustomerLedger,CustomerLedger_Full)
    ApiResponse<List<CustomerLedgerEntryDto>> response = apiInstance.CustomerledgerOpenItemsGetWithHttpInfo(date, contactGroupIds, createdDateTimeOffsetGreaterThan, customerNos, customMatchingReferences, departmentCodes, externalNos, includeSubProject, invoiceNos, lastChangedDateTimeOffsetGreaterThan, onlyBalancesLessThanAmount, onlyCreatedByCurrentIntegration, projectCodes, subLedgerNumberSeriesIds, voucherTypes, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomerSubLedgerEntriesApi.CustomerledgerOpenItemsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **date** | **DateOnly** | Date, inclusive. Get all open entries as of this date. Note that (date time) offsets (if provided) is not taken into account, only date is used. |  |
| **contactGroupIds** | **string** | Filter by contact group IDs. This will return entries for the customers belonging in the given contact groups. Separate by comma to filter on multiple contact group IDs. If filterString is null or whitespace, query is returned as is. | [optional]  |
| **createdDateTimeOffsetGreaterThan** | **DateTime** | Filter entries based on the created timestamp property. This filtering will return all entries with a created timestamp greater than the timestamp provided. Can be used when polling for new entries from Go. Date not inclusive. | [optional]  |
| **customerNos** | **string** | Filter by customer numbers. Customer number also represent the customer sub-ledger account number. SearchString should be in the form of \&quot;10000-15999, 12500, 13000-\&quot; where values from 10000 to 15999, 12500 and all over 13000 will be selected. If filterString is null or whitespace, query is returned as is. | [optional]  |
| **customMatchingReferences** | **string** | Filter transactions on invoices with given custom matching references. Separate by comma to filter on multiple custom matching references. | [optional]  |
| **departmentCodes** | **string** | Filter entries on department codes. Separate by comma to filter on multiple codes. If blank, all transactions with or without department codes are returned (no filter). If -1, then all transactions without department codes are included. | [optional]  |
| **externalNos** | **string** | Filter by customer external numbers. SearchString should be in the form of \&quot;30000, 14153-19534, 150000-\&quot; where values for 30000, between (inclusive) 14153-19534 and all over 150000 (inclusive) will be retrieved. If filterString is null or whitespace, query is returned as is. | [optional]  |
| **includeSubProject** | **bool** | Include Sub-project(s) for specified project. If projectCodes is null, all (sub)projects are included (regardless of this variable). | [optional]  |
| **invoiceNos** | **string** | Filter transactions for invoices with given invoice numbers. Separate by comma to filter on multiple invoice numbers. | [optional]  |
| **lastChangedDateTimeOffsetGreaterThan** | **DateTime** | Filter entries based on the last changed timestamp property. The accounting entry in itself cannot change, but the match state of the sub-ledger entry might change. Using last changed filtering is one way of retrieving new matched items and as such the payment status of invoices. This filtering will return all entries with a last changed timestamp greater than the timestamp provided. Date not inclusive. | [optional]  |
| **onlyBalancesLessThanAmount** | **bool** | Filter on transactions with balances less than amount. This will only provide entries with matches that are still open. | [optional]  |
| **onlyCreatedByCurrentIntegration** | **bool** | Sets whether or not to return only entries that the current integration created. Can be used to reduce the number of entries if only the status of transactions that the querying integration created are relevant to report. | [optional]  |
| **projectCodes** | **string** | Filter entries on project codes. Separate by comma to filter on multiple codes. If blank, all transactions with or without projects codes are returned (no filter). If -1, then all transactions without project codes are included. | [optional]  |
| **subLedgerNumberSeriesIds** | **string** | Filter items by sub-ledger number series IDs. This will return entries for the customers belonging in the given sub-ledger number series. Separate by comma to filter on multiple sub-ledger number series IDs. If filterString is null or whitespace, query is returned as is.\&quot; | [optional]  |
| **voucherTypes** | **string** | Filter by voucher types. Separate by comma to filter multiple voucher types. If blank, all transactions returned (no filter). | [optional]  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;CustomerLedgerEntryDto&gt;**](CustomerLedgerEntryDto.md)

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

<a id="customerledgerstatementget"></a>
# **CustomerledgerStatementGet**
> List&lt;CustomerLedgerEntryDto&gt; CustomerledgerStatementGet (DateOnly fromDate, DateOnly toDate, string contactGroupIds = null, DateTime createdDateTimeOffsetGreaterThan = null, string customerNos = null, string customMatchingReferences = null, string departmentCodes = null, string externalNos = null, bool includeSubProject = null, string invoiceNos = null, DateTime lastChangedDateTimeOffsetGreaterThan = null, bool onlyBalancesLessThanAmount = null, bool onlyCreatedByCurrentIntegration = null, string projectCodes = null, string subLedgerNumberSeriesIds = null, string voucherTypes = null, ResourceParameters resourceParameter = null)

Gets all customer sub-ledger transactions between two dates (inclusive). The dates represent the posted date (date of accounting effect). Multiple filtering options. (Auth roles: CustomerLedger,CustomerLedger_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class CustomerledgerStatementGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new CustomerSubLedgerEntriesApi(config);
            var fromDate = 2021-01-01;  // DateOnly | From date, inclusive. Get all transactions with a posted date from this date (inclusive). Note that (date time) offsets (if provided) is not taken into account, only date is used.
            var toDate = 2021-01-28;  // DateOnly | To date, inclusive. Get all transactions with a posted date up to this date (inclusive). If date is less then the current date (today); the balance displayed on all entries will be the balance the entry was on that date. Note that (date time) offsets (if provided) is not taken into account, only date is used.
            var contactGroupIds = 41345, 21445, 65457;  // string | Filter by contact group IDs. This will return entries for the customers belonging in the given contact groups. Separate by comma to filter on multiple contact group IDs. If filterString is null or whitespace, query is returned as is. (optional) 
            var createdDateTimeOffsetGreaterThan = 2021-09-25 08:03:00.1234567 -00:00;  // DateTime | Filter entries based on the created timestamp property. This filtering will return all entries with a created timestamp greater than the timestamp provided. Can be used when polling for new entries from Go. Date not inclusive. (optional) 
            var customerNos = 10000-15990, 12500, 13000-;  // string | Filter by customer numbers. Customer number also represent the customer sub-ledger account number. SearchString should be in the form of \"10000-15999, 12500, 13000-\" where values from 10000 to 15999, 12500 and all over 13000 will be selected. If filterString is null or whitespace, query is returned as is. (optional) 
            var customMatchingReferences = cmr101;  // string | Filter transactions on invoices with given custom matching references. Separate by comma to filter on multiple custom matching references. (optional) 
            var departmentCodes = 1, 3, 4;  // string | Filter entries on department codes. Separate by comma to filter on multiple codes. If blank, all transactions with or without department codes are returned (no filter). If -1, then all transactions without department codes are included. (optional) 
            var externalNos = 30000, 14153-19534, 150000-;  // string | Filter by customer external numbers. SearchString should be in the form of \"30000, 14153-19534, 150000-\" where values for 30000, between (inclusive) 14153-19534 and all over 150000 (inclusive) will be retrieved. If filterString is null or whitespace, query is returned as is. (optional) 
            var includeSubProject = true;  // bool | Include Sub-project(s) for specified project. If projectCodes is null, all (sub)projects are included (regardless of this variable). (optional) 
            var invoiceNos = 1337, 69420;  // string | Filter transactions for invoices with given invoice numbers. Separate by comma to filter on multiple invoice numbers. (optional) 
            var lastChangedDateTimeOffsetGreaterThan = 2021-09-25 08:03:00.1234567 -00:00;  // DateTime | Filter entries based on the last changed timestamp property. The accounting entry in itself cannot change, but the match state of the sub-ledger entry might change. Using last changed filtering is one way of retrieving new matched items and as such the payment status of invoices. This filtering will return all entries with a last changed timestamp greater than the timestamp provided. Date not inclusive. (optional) 
            var onlyBalancesLessThanAmount = true;  // bool | Filter on transactions with balances less than amount. This will only provide entries with matches. If, for instance, this filter is set true and combined with voucherType filter on outgoing invoices, this can be one way of retrieving payments on invoices. NOTE: We use absolute values, so for credit note entries where balance and amount is negative, we get transactions with amount greater than balance. (optional) 
            var onlyCreatedByCurrentIntegration = true;  // bool | Sets whether or not to return only entries that the current integration created. Can be used to reduce the number of entries if only the status of transactions that the querying integration created are relevant to report. (optional) 
            var projectCodes = 10, 20, 30.1;  // string | Filter entries on project codes. Separate by comma to filter on multiple codes. If blank, all transactions with or without projects codes are returned (no filter). If -1, then all transactions without project codes are included. (optional) 
            var subLedgerNumberSeriesIds = 38ecfc1a-bf51-448f-99a8-a61bc5771109, ee373540-ca8d-4562-8fb6-6fb52de47722;  // string | Filter entries by sub-ledger number series IDs. This will return entries for the customers belonging in the given sub-ledger number series. Separate by comma to filter on multiple sub-ledger number series IDs. If filterString is null or whitespace, query is returned as is.\" (optional) 
            var voucherTypes = OutgoingInvoice, BankJournal;  // string | Filter by voucher types. Separate by comma to filter multiple voucher types. If blank, all transactions returned (no filter). (optional) 
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Gets all customer sub-ledger transactions between two dates (inclusive). The dates represent the posted date (date of accounting effect). Multiple filtering options. (Auth roles: CustomerLedger,CustomerLedger_Full)
                List<CustomerLedgerEntryDto> result = apiInstance.CustomerledgerStatementGet(fromDate, toDate, contactGroupIds, createdDateTimeOffsetGreaterThan, customerNos, customMatchingReferences, departmentCodes, externalNos, includeSubProject, invoiceNos, lastChangedDateTimeOffsetGreaterThan, onlyBalancesLessThanAmount, onlyCreatedByCurrentIntegration, projectCodes, subLedgerNumberSeriesIds, voucherTypes, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomerSubLedgerEntriesApi.CustomerledgerStatementGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CustomerledgerStatementGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets all customer sub-ledger transactions between two dates (inclusive). The dates represent the posted date (date of accounting effect). Multiple filtering options. (Auth roles: CustomerLedger,CustomerLedger_Full)
    ApiResponse<List<CustomerLedgerEntryDto>> response = apiInstance.CustomerledgerStatementGetWithHttpInfo(fromDate, toDate, contactGroupIds, createdDateTimeOffsetGreaterThan, customerNos, customMatchingReferences, departmentCodes, externalNos, includeSubProject, invoiceNos, lastChangedDateTimeOffsetGreaterThan, onlyBalancesLessThanAmount, onlyCreatedByCurrentIntegration, projectCodes, subLedgerNumberSeriesIds, voucherTypes, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomerSubLedgerEntriesApi.CustomerledgerStatementGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fromDate** | **DateOnly** | From date, inclusive. Get all transactions with a posted date from this date (inclusive). Note that (date time) offsets (if provided) is not taken into account, only date is used. |  |
| **toDate** | **DateOnly** | To date, inclusive. Get all transactions with a posted date up to this date (inclusive). If date is less then the current date (today); the balance displayed on all entries will be the balance the entry was on that date. Note that (date time) offsets (if provided) is not taken into account, only date is used. |  |
| **contactGroupIds** | **string** | Filter by contact group IDs. This will return entries for the customers belonging in the given contact groups. Separate by comma to filter on multiple contact group IDs. If filterString is null or whitespace, query is returned as is. | [optional]  |
| **createdDateTimeOffsetGreaterThan** | **DateTime** | Filter entries based on the created timestamp property. This filtering will return all entries with a created timestamp greater than the timestamp provided. Can be used when polling for new entries from Go. Date not inclusive. | [optional]  |
| **customerNos** | **string** | Filter by customer numbers. Customer number also represent the customer sub-ledger account number. SearchString should be in the form of \&quot;10000-15999, 12500, 13000-\&quot; where values from 10000 to 15999, 12500 and all over 13000 will be selected. If filterString is null or whitespace, query is returned as is. | [optional]  |
| **customMatchingReferences** | **string** | Filter transactions on invoices with given custom matching references. Separate by comma to filter on multiple custom matching references. | [optional]  |
| **departmentCodes** | **string** | Filter entries on department codes. Separate by comma to filter on multiple codes. If blank, all transactions with or without department codes are returned (no filter). If -1, then all transactions without department codes are included. | [optional]  |
| **externalNos** | **string** | Filter by customer external numbers. SearchString should be in the form of \&quot;30000, 14153-19534, 150000-\&quot; where values for 30000, between (inclusive) 14153-19534 and all over 150000 (inclusive) will be retrieved. If filterString is null or whitespace, query is returned as is. | [optional]  |
| **includeSubProject** | **bool** | Include Sub-project(s) for specified project. If projectCodes is null, all (sub)projects are included (regardless of this variable). | [optional]  |
| **invoiceNos** | **string** | Filter transactions for invoices with given invoice numbers. Separate by comma to filter on multiple invoice numbers. | [optional]  |
| **lastChangedDateTimeOffsetGreaterThan** | **DateTime** | Filter entries based on the last changed timestamp property. The accounting entry in itself cannot change, but the match state of the sub-ledger entry might change. Using last changed filtering is one way of retrieving new matched items and as such the payment status of invoices. This filtering will return all entries with a last changed timestamp greater than the timestamp provided. Date not inclusive. | [optional]  |
| **onlyBalancesLessThanAmount** | **bool** | Filter on transactions with balances less than amount. This will only provide entries with matches. If, for instance, this filter is set true and combined with voucherType filter on outgoing invoices, this can be one way of retrieving payments on invoices. NOTE: We use absolute values, so for credit note entries where balance and amount is negative, we get transactions with amount greater than balance. | [optional]  |
| **onlyCreatedByCurrentIntegration** | **bool** | Sets whether or not to return only entries that the current integration created. Can be used to reduce the number of entries if only the status of transactions that the querying integration created are relevant to report. | [optional]  |
| **projectCodes** | **string** | Filter entries on project codes. Separate by comma to filter on multiple codes. If blank, all transactions with or without projects codes are returned (no filter). If -1, then all transactions without project codes are included. | [optional]  |
| **subLedgerNumberSeriesIds** | **string** | Filter entries by sub-ledger number series IDs. This will return entries for the customers belonging in the given sub-ledger number series. Separate by comma to filter on multiple sub-ledger number series IDs. If filterString is null or whitespace, query is returned as is.\&quot; | [optional]  |
| **voucherTypes** | **string** | Filter by voucher types. Separate by comma to filter multiple voucher types. If blank, all transactions returned (no filter). | [optional]  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;CustomerLedgerEntryDto&gt;**](CustomerLedgerEntryDto.md)

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


# PowerOfficeGoV2.Api.AccountTransactionsApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AccountTransactionsGet**](AccountTransactionsApi.md#accounttransactionsget) | **GET** /AccountTransactions | Gets all account transactions between two dates (inclusive). The dates represent the posted date (date of accounting effect). Multiple filtering options. (Auth roles: AccountTransaction,AccountTransaction_Full) |

<a id="accounttransactionsget"></a>
# **AccountTransactionsGet**
> List&lt;AccountTransactionDto&gt; AccountTransactionsGet (DateTimeOffset fromDate, DateTimeOffset toDate, string accountNos = null, string agricultureDepartments = null, DateTimeOffset createdDateTimeOffsetGreaterThan = null, string departmentCodes = null, bool includeSubProject = null, DateTimeOffset lastChangedDateTimeOffsetGreaterThan = null, string productCodes = null, string projectCodes = null, string vatCodes = null, string voucherNos = null, string voucherTypes = null, ResourceParameters resourceParameter = null)

Gets all account transactions between two dates (inclusive). The dates represent the posted date (date of accounting effect). Multiple filtering options. (Auth roles: AccountTransaction,AccountTransaction_Full)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class AccountTransactionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new AccountTransactionsApi(config);
            var fromDate = 2021-01-01;  // DateTimeOffset | From date, inclusive. Get all transactions with a posted date from this date (inclusive). Note that (date time) offsets (if provided) is not taken into account, only date is used.
            var toDate = 2021-01-28;  // DateTimeOffset | To date, inclusive. Get all transactions with a posted date up to this date (inclusive). Note that (date time) offsets (if provided) is not taken into account, only date is used.
            var accountNos = 1000-1999, 2500, 3000-;  // string | Filter by account numbers. Separate by comma [,] to filter on multiple account numbers. A range of numbers can be specified using dash/hyphen [-]. For example \"1000-1999, 2500, 3000-\" will result in transactions with account numbers from and including 1000 to 1999, 2500, 3000 and all above will be returned. If null or whitespace, the filter is not used. (optional) 
            var agricultureDepartments = Finance;  // string | Filter by agriculture departments. Separate by comma [,] to filter on multiple names. If null or whitespace, all transactions with or without agriculture departments are returned (filter is not used). (optional) 
            var createdDateTimeOffsetGreaterThan = 2021-09-25 08:03:00.1234567 -00:00;  // DateTimeOffset | Filter by created timestamp. This filtering will return all transactions with a created timestamp greater than the timestamp provided. Can be used when polling for new entries from Go. Date not inclusive. (optional) 
            var departmentCodes = 1, 3, 4;  // string | Filter by department codes. Separate by comma [,] to filter on multiple codes. If -1, then all transactions without department codes are returned. If null or whitespace, all transactions with or without department codes are returned (filter is not used). (optional) 
            var includeSubProject = true;  // bool | Include sub-project(s) for the currently filtered project(s). If projectCodes is null or whitespace, all (sub)projects are included (regardless of this variable). (optional) 
            var lastChangedDateTimeOffsetGreaterThan = 2021-09-25 08:03:00.1234567 -00:00;  // DateTimeOffset | Filter by last changed timestamp. No changes with accounting effect can be made on a posted voucher in Go, making createdDateTimeOffsetGreaterThan the preferred filtering in order to get new account transactions from Go. However, simple changes like the description can be made on a posted voucher, which will effect the last changed timestamp. This filtering will return all transactions with a last changed timestamp greater than the timestamp provided. Can be used when polling for new transactions and where changes in description are needed from Go. If used, changed transactions should replace what was previously stored in the external system. Note again that no changes can be made that affects the accounting as such. Date not inclusive. (optional) 
            var productCodes = 11A, 69, 420;  // string | Filter by product codes. Separate by comma [,] to filter on multiple codes. If -1, then all transactions without product codes are returned. If null or whitespace, the filter is not used. (optional) 
            var projectCodes = 10, 20, 30.1;  // string | Filter by project codes. Separate by comma [,] to filter on multiple codes. If -1, then all transactions without project codes are returned. If null or whitespace, all transactions with or without project codes are returned (filter is not used). (optional) 
            var vatCodes = 1, 3, 5;  // string | Filter by vat codes. Separate by comma [,] to filter on multiple codes. If null or whitespace, the filter is not used. (optional) 
            var voucherNos = 1-5, 7, 9-;  // string | Filter by voucher numbers. Separate by comma [,] to filter on multiple voucher numbers. A range of numbers can be specified using dash/hyphen [-]. For example \"1-5, 7, 9-\" will result in transactions with voucher numbers from and including 1 to 5, 7, 9 and all above will be returned. If null or whitespace, the filter is not used. (optional) 
            var voucherTypes = OutgoingInvoice, BankJournal;  // string | Filter by voucher types. Separate by comma [,] to filter on multiple voucher types. If null or whitespace, the filter is not used. (optional) 
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Gets all account transactions between two dates (inclusive). The dates represent the posted date (date of accounting effect). Multiple filtering options. (Auth roles: AccountTransaction,AccountTransaction_Full)
                List<AccountTransactionDto> result = apiInstance.AccountTransactionsGet(fromDate, toDate, accountNos, agricultureDepartments, createdDateTimeOffsetGreaterThan, departmentCodes, includeSubProject, lastChangedDateTimeOffsetGreaterThan, productCodes, projectCodes, vatCodes, voucherNos, voucherTypes, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountTransactionsApi.AccountTransactionsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AccountTransactionsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets all account transactions between two dates (inclusive). The dates represent the posted date (date of accounting effect). Multiple filtering options. (Auth roles: AccountTransaction,AccountTransaction_Full)
    ApiResponse<List<AccountTransactionDto>> response = apiInstance.AccountTransactionsGetWithHttpInfo(fromDate, toDate, accountNos, agricultureDepartments, createdDateTimeOffsetGreaterThan, departmentCodes, includeSubProject, lastChangedDateTimeOffsetGreaterThan, productCodes, projectCodes, vatCodes, voucherNos, voucherTypes, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountTransactionsApi.AccountTransactionsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fromDate** | **DateTimeOffset** | From date, inclusive. Get all transactions with a posted date from this date (inclusive). Note that (date time) offsets (if provided) is not taken into account, only date is used. |  |
| **toDate** | **DateTimeOffset** | To date, inclusive. Get all transactions with a posted date up to this date (inclusive). Note that (date time) offsets (if provided) is not taken into account, only date is used. |  |
| **accountNos** | **string** | Filter by account numbers. Separate by comma [,] to filter on multiple account numbers. A range of numbers can be specified using dash/hyphen [-]. For example \&quot;1000-1999, 2500, 3000-\&quot; will result in transactions with account numbers from and including 1000 to 1999, 2500, 3000 and all above will be returned. If null or whitespace, the filter is not used. | [optional]  |
| **agricultureDepartments** | **string** | Filter by agriculture departments. Separate by comma [,] to filter on multiple names. If null or whitespace, all transactions with or without agriculture departments are returned (filter is not used). | [optional]  |
| **createdDateTimeOffsetGreaterThan** | **DateTimeOffset** | Filter by created timestamp. This filtering will return all transactions with a created timestamp greater than the timestamp provided. Can be used when polling for new entries from Go. Date not inclusive. | [optional]  |
| **departmentCodes** | **string** | Filter by department codes. Separate by comma [,] to filter on multiple codes. If -1, then all transactions without department codes are returned. If null or whitespace, all transactions with or without department codes are returned (filter is not used). | [optional]  |
| **includeSubProject** | **bool** | Include sub-project(s) for the currently filtered project(s). If projectCodes is null or whitespace, all (sub)projects are included (regardless of this variable). | [optional]  |
| **lastChangedDateTimeOffsetGreaterThan** | **DateTimeOffset** | Filter by last changed timestamp. No changes with accounting effect can be made on a posted voucher in Go, making createdDateTimeOffsetGreaterThan the preferred filtering in order to get new account transactions from Go. However, simple changes like the description can be made on a posted voucher, which will effect the last changed timestamp. This filtering will return all transactions with a last changed timestamp greater than the timestamp provided. Can be used when polling for new transactions and where changes in description are needed from Go. If used, changed transactions should replace what was previously stored in the external system. Note again that no changes can be made that affects the accounting as such. Date not inclusive. | [optional]  |
| **productCodes** | **string** | Filter by product codes. Separate by comma [,] to filter on multiple codes. If -1, then all transactions without product codes are returned. If null or whitespace, the filter is not used. | [optional]  |
| **projectCodes** | **string** | Filter by project codes. Separate by comma [,] to filter on multiple codes. If -1, then all transactions without project codes are returned. If null or whitespace, all transactions with or without project codes are returned (filter is not used). | [optional]  |
| **vatCodes** | **string** | Filter by vat codes. Separate by comma [,] to filter on multiple codes. If null or whitespace, the filter is not used. | [optional]  |
| **voucherNos** | **string** | Filter by voucher numbers. Separate by comma [,] to filter on multiple voucher numbers. A range of numbers can be specified using dash/hyphen [-]. For example \&quot;1-5, 7, 9-\&quot; will result in transactions with voucher numbers from and including 1 to 5, 7, 9 and all above will be returned. If null or whitespace, the filter is not used. | [optional]  |
| **voucherTypes** | **string** | Filter by voucher types. Separate by comma [,] to filter on multiple voucher types. If null or whitespace, the filter is not used. | [optional]  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;AccountTransactionDto&gt;**](AccountTransactionDto.md)

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


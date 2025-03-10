# PowerOfficeGoV2.Api.PayItemsApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetPayItemById**](PayItemsApi.md#getpayitembyid) | **GET** /PayItems/{id} | Gets a specific pay item by id. (Auth roles: PayItem,PayItem_Full) |
| [**PayItemsGet**](PayItemsApi.md#payitemsget) | **GET** /PayItems | Get all pay items for the client. (Auth roles: PayItem,PayItem_Full) |

<a id="getpayitembyid"></a>
# **GetPayItemById**
> PayItemDto GetPayItemById (Guid id)

Gets a specific pay item by id. (Auth roles: PayItem,PayItem_Full)

A pay item is used by the payroll system to identify how an individual salary line should be treated,  in order to report and post the salary in a correct manner on the payroll issued.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class GetPayItemByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new PayItemsApi(config);
            var id = 21d4ddf1-c8bf-4874-8879-b70468fa1032;  // Guid | The id of the pay item.

            try
            {
                // Gets a specific pay item by id. (Auth roles: PayItem,PayItem_Full)
                PayItemDto result = apiInstance.GetPayItemById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PayItemsApi.GetPayItemById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPayItemByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a specific pay item by id. (Auth roles: PayItem,PayItem_Full)
    ApiResponse<PayItemDto> response = apiInstance.GetPayItemByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PayItemsApi.GetPayItemByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The id of the pay item. |  |

### Return type

[**PayItemDto**](PayItemDto.md)

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

<a id="payitemsget"></a>
# **PayItemsGet**
> List&lt;PayItemDto&gt; PayItemsGet (string codes = null, DateTime createdDateTimeOffsetGreaterThan = null, bool isActive = null, DateTime lastChangedDateTimeOffsetGreaterThan = null, ResourceParameters resourceParameter = null)

Get all pay items for the client. (Auth roles: PayItem,PayItem_Full)

A pay item is used by the payroll system to identify how an individual salary line should be treated,  in order to report and post the salary in a correct manner on the payroll issued.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class PayItemsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new PayItemsApi(config);
            var codes = 10, 20, 30;  // string | Filter by pay item codes. Separate by comma [,] to filter on multiple pay items. If null or whitespace, all pay items are returned (filter is not used). (optional) 
            var createdDateTimeOffsetGreaterThan = 2021-09-25 08:03:00.1234567 -00:00;  // DateTime | Filter by created timestamp property. This filtering will return all pay items with a created timestamp greater than the timestamp provided. Can be used when polling for new entries from Go. Timestamp not inclusive. (optional) 
            var isActive = true;  // bool | Filter pay items based on active status. True to only get pay items with active status, false to only get pay items with inactive status. (optional) 
            var lastChangedDateTimeOffsetGreaterThan = 2021-09-25 08:03:00.1234567 -00:00;  // DateTime | Filter by the last changed timestamp property. This filtering will return all pay items with a last changed timestamp greater than the timestamp provided. Can be used when polling for new or updated entries. Timestamp not inclusive. (optional) 
            var resourceParameter = new ResourceParameters(); // ResourceParameters |  (optional) 

            try
            {
                // Get all pay items for the client. (Auth roles: PayItem,PayItem_Full)
                List<PayItemDto> result = apiInstance.PayItemsGet(codes, createdDateTimeOffsetGreaterThan, isActive, lastChangedDateTimeOffsetGreaterThan, resourceParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PayItemsApi.PayItemsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PayItemsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all pay items for the client. (Auth roles: PayItem,PayItem_Full)
    ApiResponse<List<PayItemDto>> response = apiInstance.PayItemsGetWithHttpInfo(codes, createdDateTimeOffsetGreaterThan, isActive, lastChangedDateTimeOffsetGreaterThan, resourceParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PayItemsApi.PayItemsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **codes** | **string** | Filter by pay item codes. Separate by comma [,] to filter on multiple pay items. If null or whitespace, all pay items are returned (filter is not used). | [optional]  |
| **createdDateTimeOffsetGreaterThan** | **DateTime** | Filter by created timestamp property. This filtering will return all pay items with a created timestamp greater than the timestamp provided. Can be used when polling for new entries from Go. Timestamp not inclusive. | [optional]  |
| **isActive** | **bool** | Filter pay items based on active status. True to only get pay items with active status, false to only get pay items with inactive status. | [optional]  |
| **lastChangedDateTimeOffsetGreaterThan** | **DateTime** | Filter by the last changed timestamp property. This filtering will return all pay items with a last changed timestamp greater than the timestamp provided. Can be used when polling for new or updated entries. Timestamp not inclusive. | [optional]  |
| **resourceParameter** | [**ResourceParameters**](ResourceParameters.md) |  | [optional]  |

### Return type

[**List&lt;PayItemDto&gt;**](PayItemDto.md)

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


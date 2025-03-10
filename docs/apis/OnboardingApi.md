# PowerOfficeGoV2.Api.OnboardingApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**OnboardingFinalizePost**](OnboardingApi.md#onboardingfinalizepost) | **POST** /Onboarding/Finalize | Finalize the last procedural step of onboarding your integration for one or more PowerOffice Go client, using the external onboarding worklfow. |
| [**OnboardingInitiatePost**](OnboardingApi.md#onboardinginitiatepost) | **POST** /Onboarding/Initiate | Initiate the first procedural step of onboarding your integration for one or more PowerOffice Go client, using the external onboarding worklfow. |

<a id="onboardingfinalizepost"></a>
# **OnboardingFinalizePost**
> FinalizeOnboardingResponseDto OnboardingFinalizePost (FinalizeOnboardingPostDto finalizeOnboardingPostDto = null)

Finalize the last procedural step of onboarding your integration for one or more PowerOffice Go client, using the external onboarding worklfow.

Finalize the last step in the process of onboarding the integration on clients. Read our documentation page for detailed workflow descriptions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class OnboardingFinalizePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new OnboardingApi(config);
            var finalizeOnboardingPostDto = new FinalizeOnboardingPostDto(); // FinalizeOnboardingPostDto |  (optional) 

            try
            {
                // Finalize the last procedural step of onboarding your integration for one or more PowerOffice Go client, using the external onboarding worklfow.
                FinalizeOnboardingResponseDto result = apiInstance.OnboardingFinalizePost(finalizeOnboardingPostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnboardingApi.OnboardingFinalizePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OnboardingFinalizePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Finalize the last procedural step of onboarding your integration for one or more PowerOffice Go client, using the external onboarding worklfow.
    ApiResponse<FinalizeOnboardingResponseDto> response = apiInstance.OnboardingFinalizePostWithHttpInfo(finalizeOnboardingPostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OnboardingApi.OnboardingFinalizePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **finalizeOnboardingPostDto** | [**FinalizeOnboardingPostDto**](FinalizeOnboardingPostDto.md) |  | [optional]  |

### Return type

[**FinalizeOnboardingResponseDto**](FinalizeOnboardingResponseDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="onboardinginitiatepost"></a>
# **OnboardingInitiatePost**
> InitiateOnboardingResponseDto OnboardingInitiatePost (InitiateOnboardingPostDto initiateOnboardingPostDto = null)

Initiate the first procedural step of onboarding your integration for one or more PowerOffice Go client, using the external onboarding worklfow.

Initiate the first step in the process of onboarding the integration on clients. Read our documentation page for detailed workflow descriptions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;

namespace Example
{
    public class OnboardingInitiatePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new OnboardingApi(config);
            var initiateOnboardingPostDto = new InitiateOnboardingPostDto(); // InitiateOnboardingPostDto |  (optional) 

            try
            {
                // Initiate the first procedural step of onboarding your integration for one or more PowerOffice Go client, using the external onboarding worklfow.
                InitiateOnboardingResponseDto result = apiInstance.OnboardingInitiatePost(initiateOnboardingPostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnboardingApi.OnboardingInitiatePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OnboardingInitiatePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Initiate the first procedural step of onboarding your integration for one or more PowerOffice Go client, using the external onboarding worklfow.
    ApiResponse<InitiateOnboardingResponseDto> response = apiInstance.OnboardingInitiatePostWithHttpInfo(initiateOnboardingPostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OnboardingApi.OnboardingInitiatePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **initiateOnboardingPostDto** | [**InitiateOnboardingPostDto**](InitiateOnboardingPostDto.md) |  | [optional]  |

### Return type

[**InitiateOnboardingResponseDto**](InitiateOnboardingResponseDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Given when resource returned successfully |  -  |
| **400** | Given when request is badly formatted. |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


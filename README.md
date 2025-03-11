# PowerOfficeGoV2
A .net library for interacting with the PowerOfficeGo V2 API.

This NuGet was mostly generated by [Openapi Generator](https://github.com/OpenAPITools/openapi-generator) based on the [Swagger](https://prdm0go0stor0apiv20eurw.z6.web.core.windows.net/) for the V2 API provided by PowerOfficeGo.
Some additional utility functionality has been provided.

## Using the library in your project
### Setting up the api with dependency injection:

In your Program.cs:
```cs
using PowerOfficeGoV2.Extensions;

...

var builder = WebApplication.CreateBuilder(args); 
builder.Services.AddPowerOfficeGoApi(options => 
{
    // Use the PowerOfficeGo demo api (for demo clients). Default is false.
    options.UseDemoApi = true;
});

...
```

### Using the api
```cs
public class YourService
{
    private readonly IPowerOfficeGoApiService _powerOfficeGoApiService;
    
    public YourService(IPowerOfficeGoApiService powerOfficeGoApiService)
    {
        _powerOfficeGoApiService = powerOfficeGoApiService;
    }
    
    public async Task YourMethodAsync()
    {
        var vouchersApi = _powerOfficeGoApiService.GetApiAsync<JournalEntryVouchersApi>(...);
        var vouchersResponse = await vouchersApi.JournalEntryVouchersGetAsync();
        var vouchers = vouchersResponse.Ok();
    }
}
```

## Questions
- What about HttpRequest failures and retries?
  If supportsRetry is enabled, you can configure Polly in the ConfigureClients method.
- How are tokens used?
  Tokens are provided by a TokenProvider class. The default is RateLimitProvider which will perform client side rate limiting.
  Other providers can be used with the UseProvider method.
- Does an HttpRequest throw an error when the server response is not Ok?
  It depends how you made the request. If the return type is ApiResponse<T> no error will be thrown, though the Content property will be null.
  StatusCode and ReasonPhrase will contain information about the error.
  If the return type is T, then it will throw. If the return type is TOrDefault, it will return null.
- How do I validate requests and process responses?
  Use the provided On and After methods in the Api class from the namespace PowerOfficeGoV2.Rest.DefaultApi.
  Or provide your own class by using the generic ConfigureApi method.

## Authorization
Auth is supported through the IPowerOfficeGoApiService, which currently requires that your PowerOfficeGo extension is manually added to clients, and that the client secrets are passed when resolving apis through IPowerOfficeGoApiService.

In the future, the onboarding flow will be supported. See [#1](https://github.com/stianwe/PowerOfficeGoV2/issues/1).

## How to re-generate the code
1. Install [openapi-generator](https://github.com/OpenAPITools/openapi-generator?tab=readme-ov-file#1---installation)
2. Run ```./generate-api-code.sh```

## Dependencies
- [Microsoft.Extensions.Hosting](https://www.nuget.org/packages/Microsoft.Extensions.Hosting/) - 5.0.0 or later
- [Microsoft.Extensions.Http](https://www.nuget.org/packages/Microsoft.Extensions.Http/) - 5.0.0 or later
- [Microsoft.Extensions.Http.Polly](https://www.nuget.org/packages/Microsoft.Extensions.Http.Polly/) - 5.0.1 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 4.7.0 or later

## Build
- SDK version: 1.0.0
- Generator version: 7.12.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen

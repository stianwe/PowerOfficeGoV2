using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PowerOfficeGoV2.Client;

namespace PowerOfficeGoV2;

/// <summary>
/// Utility service to get api implementations for PowerOfficeGoV2 apis.
/// </summary>
public interface IPowerOfficeGoApiService
{
    /// <summary>
    /// Gets the api implementation specified with type parameter T, configured with a bearer token which will be obtained
    /// using the included parameters.
    ///
    /// <example>
    /// <c>
    /// var vouchersApi = powerOfficeGoApiService.GetApiAsync&lt;JournalEntryVouchersApi&gt;(...);
    /// var vouchers = await vouchersApi.JournalEntryVouchersGetAsync();
    /// </c>
    /// </example>
    /// </summary>
    /// <param name="clientKey">Client key obtained when setting the integration up with a client.</param>
    /// <param name="subscriptionKey">Subscription key obtained when creating the PowerOfficeGo extensions</param>
    /// <param name="applicationKey">Application key obtained when creating the PowerOfficeGo extensions</param>
    /// <param name="useDemoApi">Whether to use the live API or the demo API</param>
    /// <typeparam name="T">The type of the api, e.g. JournalEntryVouchersApi</typeparam>
    /// <returns>The api implementation or null if it could not be resolved</returns>
    Task<T?> GetApiAsync<T>(string clientKey, string subscriptionKey, string applicationKey, bool useDemoApi = false) where T: class;
    
    /// <summary>
    /// Gets the api implementation specified with type parameter T, configured with a bearer token which will be obtained
    /// using the included parameters.
    ///
    /// <example>
    /// <c>
    /// var vouchersApi = powerOfficeGoApiService.GetApiAsync&lt;JournalEntryVouchersApi&gt;(...);
    /// var vouchers = await vouchersApi.JournalEntryVouchersGetAsync();
    /// </c>
    /// </example>
    /// </summary>
    /// <param name="bearerToken">Already obtained bearer token.</param>
    /// <param name="subscriptionKey">Subscription key obtained when creating the PowerOfficeGo extensions</param>
    /// <param name="useDemoApi">Whether to use the live API or the demo API</param>
    /// <typeparam name="T">The type of the api, e.g. JournalEntryVouchersApi</typeparam>
    /// <returns>The api implementation or null if it could not be resolved</returns>
    Task<T?> GetApiAsync<T>(string bearerToken, string subscriptionKey, bool useDemoApi = false) where T: class;
}

/// <see cref="IPowerOfficeGoApiService"/>
public class PowerOfficeGoApiService : IPowerOfficeGoApiService
{
    private const string SubscriptionKeyHeaderName = "Ocp-Apim-Subscription-Key";
    private const string V2DemoBaseUrl = "https://goapi.poweroffice.net/Demo/v2";
    private const string V2LiveBaseUrl = "https://goapi.poweroffice.net/v2";
    
    private readonly IServiceProvider _serviceProvider;
    
    public PowerOfficeGoApiService(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    /// <inheritdoc />
    public async Task<T?> GetApiAsync<T>(string clientKey, string subscriptionKey, string applicationKey, bool useDemoApi = false) where T: class
    {
        var token = await GetTokenAsync(clientKey, subscriptionKey, applicationKey, useDemoApi);
        return await GetApiAsync<T>(token.AccessToken, subscriptionKey, useDemoApi);
    }
    
    /// <inheritdoc />
    public Task<T?> GetApiAsync<T>(string bearerToken, string subscriptionKey, bool useDemoApi = false) where T: class
    {
        var type = typeof(T);
        var eventsType = Type.GetType(type.AssemblyQualifiedName?.Replace(type.FullName!, type.FullName + "Events") ?? string.Empty);
        if (eventsType == null)
        {
            return Task.FromResult<T?>(null);
        }

        var httpClient = new HttpClient
        {
            BaseAddress = new Uri(useDemoApi ? V2DemoBaseUrl : V2LiveBaseUrl),
        };
        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);
        httpClient.DefaultRequestHeaders.Add(SubscriptionKeyHeaderName, subscriptionKey);
        
        var args = new[]
        {
            _serviceProvider.GetRequiredService<ILogger<T>>(),
            _serviceProvider.GetRequiredService<ILoggerFactory>(),
            httpClient,
            _serviceProvider.GetRequiredService<JsonSerializerOptionsProvider>(),
            _serviceProvider.GetRequiredService(eventsType),
        };
        
        return Task.FromResult((T?) Activator.CreateInstance(type, args));
    }
    
    private async Task<TokenResponse> GetTokenAsync(string clientKey, string subscriptionKey, string applicationKey, bool useDemoApi)
    {
        var uri = new Uri(useDemoApi ? "https://goapi.poweroffice.net/demo/oauth/Token" : "https://goapi.poweroffice.net/oauth/Token");
        var request = new HttpRequestMessage(HttpMethod.Post, uri);
        request.Headers.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"{applicationKey}:{clientKey}")));
        request.Headers.Add("Ocp-Apim-Subscription-Key", subscriptionKey);
        request.Content = new FormUrlEncodedContent(new Dictionary<string, string>
        {
            ["grant_type"] = "client_credentials",
        });

        var response = await new HttpClient().SendAsync(request);

        if (!response.IsSuccessStatusCode)
        {
            throw new Exception($"Failed to acquire PowerOffice token: {response.StatusCode}:\n{await response.Content.ReadAsStringAsync()}");
        }

        var tokenResponse = JsonSerializer.Deserialize<TokenResponse>(await response.Content.ReadAsStringAsync(), new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
        });
        if (tokenResponse is null)
        {
            throw new Exception("Failed to deserialize PowerOffice token response.");
        }

        return tokenResponse;
    }
    
    private record TokenResponse(string AccessToken, int ExpiresIn, string TokenType);
}
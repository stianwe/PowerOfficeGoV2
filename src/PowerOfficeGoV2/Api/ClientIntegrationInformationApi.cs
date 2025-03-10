// <auto-generated>
/*
 * merged spec
 *
 * merged spec
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using PowerOfficeGoV2.Client;
using PowerOfficeGoV2.Model;
using System.Diagnostics.CodeAnalysis;

namespace PowerOfficeGoV2.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// This class is registered as transient.
    /// </summary>
    public interface IClientIntegrationInformationApi : IApi
    {
        /// <summary>
        /// The class containing the events
        /// </summary>
        ClientIntegrationInformationApiEvents Events { get; }

        /// <summary>
        /// Get information about the integration. (Auth)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IClientIntegrationInformationGetApiResponse"/>&gt;</returns>
        Task<IClientIntegrationInformationGetApiResponse> ClientIntegrationInformationGetAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get information about the integration. (Auth)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IClientIntegrationInformationGetApiResponse"/>?&gt;</returns>
        Task<IClientIntegrationInformationGetApiResponse?> ClientIntegrationInformationGetOrDefaultAsync(System.Threading.CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The <see cref="IClientIntegrationInformationGetApiResponse"/>
    /// </summary>
    public interface IClientIntegrationInformationGetApiResponse : PowerOfficeGoV2.Client.IApiResponse, IOk<PowerOfficeGoV2.Model.ClientIntegrationInformationDto?>
    {
        /// <summary>
        /// Returns true if the response is 200 Ok
        /// </summary>
        /// <returns></returns>
        bool IsOk { get; }

        /// <summary>
        /// Returns true if the response is 401 Unauthorized
        /// </summary>
        /// <returns></returns>
        bool IsUnauthorized { get; }

        /// <summary>
        /// Returns true if the response is 403 Forbidden
        /// </summary>
        /// <returns></returns>
        bool IsForbidden { get; }

        /// <summary>
        /// Returns true if the response is 429 TooManyRequests
        /// </summary>
        /// <returns></returns>
        bool IsTooManyRequests { get; }

        /// <summary>
        /// Returns true if the response is the default response type
        /// </summary>
        /// <returns></returns>
        bool IsDefault { get; }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ClientIntegrationInformationApiEvents
    {
        /// <summary>
        /// The event raised after the server response
        /// </summary>
        public event EventHandler<ApiResponseEventArgs>? OnClientIntegrationInformationGet;

        /// <summary>
        /// The event raised after an error querying the server
        /// </summary>
        public event EventHandler<ExceptionEventArgs>? OnErrorClientIntegrationInformationGet;

        internal void ExecuteOnClientIntegrationInformationGet(ClientIntegrationInformationApi.ClientIntegrationInformationGetApiResponse apiResponse)
        {
            OnClientIntegrationInformationGet?.Invoke(this, new ApiResponseEventArgs(apiResponse));
        }

        internal void ExecuteOnErrorClientIntegrationInformationGet(Exception exception)
        {
            OnErrorClientIntegrationInformationGet?.Invoke(this, new ExceptionEventArgs(exception));
        }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public sealed partial class ClientIntegrationInformationApi : IClientIntegrationInformationApi
    {
        private JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        /// The logger factory
        /// </summary>
        public ILoggerFactory LoggerFactory { get; }

        /// <summary>
        /// The logger
        /// </summary>
        public ILogger<ClientIntegrationInformationApi> Logger { get; }

        /// <summary>
        /// The HttpClient
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// The class containing the events
        /// </summary>
        public ClientIntegrationInformationApiEvents Events { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientIntegrationInformationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ClientIntegrationInformationApi(ILogger<ClientIntegrationInformationApi> logger, ILoggerFactory loggerFactory, HttpClient httpClient, JsonSerializerOptionsProvider jsonSerializerOptionsProvider, ClientIntegrationInformationApiEvents clientIntegrationInformationApiEvents)
        {
            _jsonSerializerOptions = jsonSerializerOptionsProvider.Options;
            LoggerFactory = loggerFactory;
            Logger = LoggerFactory.CreateLogger<ClientIntegrationInformationApi>();
            HttpClient = httpClient;
            Events = clientIntegrationInformationApiEvents;
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        private void AfterClientIntegrationInformationGetDefaultImplementation(IClientIntegrationInformationGetApiResponse apiResponseLocalVar)
        {
            bool suppressDefaultLog = false;
            AfterClientIntegrationInformationGet(ref suppressDefaultLog, apiResponseLocalVar);
            if (!suppressDefaultLog)
                Logger.LogInformation("{0,-9} | {1} | {3}", (apiResponseLocalVar.DownloadedAt - apiResponseLocalVar.RequestedAt).TotalSeconds, apiResponseLocalVar.StatusCode, apiResponseLocalVar.Path);
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="apiResponseLocalVar"></param>
        partial void AfterClientIntegrationInformationGet(ref bool suppressDefaultLog, IClientIntegrationInformationGetApiResponse apiResponseLocalVar);

        /// <summary>
        /// Logs exceptions that occur while retrieving the server response
        /// </summary>
        /// <param name="exceptionLocalVar"></param>
        /// <param name="pathFormatLocalVar"></param>
        /// <param name="pathLocalVar"></param>
        private void OnErrorClientIntegrationInformationGetDefaultImplementation(Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar)
        {
            bool suppressDefaultLogLocalVar = false;
            OnErrorClientIntegrationInformationGet(ref suppressDefaultLogLocalVar, exceptionLocalVar, pathFormatLocalVar, pathLocalVar);
            if (!suppressDefaultLogLocalVar)
                Logger.LogError(exceptionLocalVar, "An error occurred while sending the request to the server.");
        }

        /// <summary>
        /// A partial method that gives developers a way to provide customized exception handling
        /// </summary>
        /// <param name="suppressDefaultLogLocalVar"></param>
        /// <param name="exceptionLocalVar"></param>
        /// <param name="pathFormatLocalVar"></param>
        /// <param name="pathLocalVar"></param>
        partial void OnErrorClientIntegrationInformationGet(ref bool suppressDefaultLogLocalVar, Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar);

        /// <summary>
        /// Get information about the integration. (Auth) 
        /// </summary>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IClientIntegrationInformationGetApiResponse"/>&gt;</returns>
        public async Task<IClientIntegrationInformationGetApiResponse?> ClientIntegrationInformationGetOrDefaultAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await ClientIntegrationInformationGetAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Get information about the integration. (Auth) 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IClientIntegrationInformationGetApiResponse"/>&gt;</returns>
        public async Task<IClientIntegrationInformationGetApiResponse> ClientIntegrationInformationGetAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress!.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = ClientUtils.CONTEXT_PATH + "/ClientIntegrationInformation";

                    httpRequestMessageLocalVar.RequestUri = uriBuilderLocalVar.Uri;

                    string[] acceptLocalVars = new string[] {
                        "application/json"
                    };

                    string? acceptLocalVar = ClientUtils.SelectHeaderAccept(acceptLocalVars);

                    if (acceptLocalVar != null)
                        httpRequestMessageLocalVar.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(acceptLocalVar));

                    httpRequestMessageLocalVar.Method = HttpMethod.Get;

                    DateTime requestedAtLocalVar = DateTime.UtcNow;

                    using (HttpResponseMessage httpResponseMessageLocalVar = await HttpClient.SendAsync(httpRequestMessageLocalVar, cancellationToken).ConfigureAwait(false))
                    {
                        string responseContentLocalVar = await httpResponseMessageLocalVar.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        ILogger<ClientIntegrationInformationGetApiResponse> apiResponseLoggerLocalVar = LoggerFactory.CreateLogger<ClientIntegrationInformationGetApiResponse>();

                        ClientIntegrationInformationGetApiResponse apiResponseLocalVar = new(apiResponseLoggerLocalVar, httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, "/ClientIntegrationInformation", requestedAtLocalVar, _jsonSerializerOptions);

                        AfterClientIntegrationInformationGetDefaultImplementation(apiResponseLocalVar);

                        Events.ExecuteOnClientIntegrationInformationGet(apiResponseLocalVar);

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorClientIntegrationInformationGetDefaultImplementation(e, "/ClientIntegrationInformation", uriBuilderLocalVar.Path);
                Events.ExecuteOnErrorClientIntegrationInformationGet(e);
                throw;
            }
        }

        /// <summary>
        /// The <see cref="ClientIntegrationInformationGetApiResponse"/>
        /// </summary>
        public partial class ClientIntegrationInformationGetApiResponse : PowerOfficeGoV2.Client.ApiResponse, IClientIntegrationInformationGetApiResponse
        {
            /// <summary>
            /// The logger
            /// </summary>
            public ILogger<ClientIntegrationInformationGetApiResponse> Logger { get; }

            /// <summary>
            /// The <see cref="ClientIntegrationInformationGetApiResponse"/>
            /// </summary>
            /// <param name="logger"></param>
            /// <param name="httpRequestMessage"></param>
            /// <param name="httpResponseMessage"></param>
            /// <param name="rawContent"></param>
            /// <param name="path"></param>
            /// <param name="requestedAt"></param>
            /// <param name="jsonSerializerOptions"></param>
            public ClientIntegrationInformationGetApiResponse(ILogger<ClientIntegrationInformationGetApiResponse> logger, System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage, string rawContent, string path, DateTime requestedAt, System.Text.Json.JsonSerializerOptions jsonSerializerOptions) : base(httpRequestMessage, httpResponseMessage, rawContent, path, requestedAt, jsonSerializerOptions)
            {
                Logger = logger;
                OnCreated(httpRequestMessage, httpResponseMessage);
            }

            partial void OnCreated(global::System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage);

            /// <summary>
            /// Returns true if the response is 200 Ok
            /// </summary>
            /// <returns></returns>
            public bool IsOk => 200 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 200 Ok
            /// </summary>
            /// <returns></returns>
            public PowerOfficeGoV2.Model.ClientIntegrationInformationDto? Ok()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsOk
                    ? System.Text.Json.JsonSerializer.Deserialize<PowerOfficeGoV2.Model.ClientIntegrationInformationDto>(RawContent, _jsonSerializerOptions)
                    : null;
            }

            /// <summary>
            /// Returns true if the response is 200 Ok and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryOk([NotNullWhen(true)]out PowerOfficeGoV2.Model.ClientIntegrationInformationDto? result)
            {
                result = null;

                try
                {
                    result = Ok();
                } catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)200);
                }

                return result != null;
            }

            /// <summary>
            /// Returns true if the response is 401 Unauthorized
            /// </summary>
            /// <returns></returns>
            public bool IsUnauthorized => 401 == (int)StatusCode;

            /// <summary>
            /// Returns true if the response is 403 Forbidden
            /// </summary>
            /// <returns></returns>
            public bool IsForbidden => 403 == (int)StatusCode;

            /// <summary>
            /// Returns true if the response is 429 TooManyRequests
            /// </summary>
            /// <returns></returns>
            public bool IsTooManyRequests => 429 == (int)StatusCode;

            /// <summary>
            /// Returns true if the response is the default response type
            /// </summary>
            /// <returns></returns>
            public bool IsDefault => !IsOk && !IsUnauthorized && !IsForbidden && !IsTooManyRequests;

            private void OnDeserializationErrorDefaultImplementation(Exception exception, HttpStatusCode httpStatusCode)
            {
                bool suppressDefaultLog = false;
                OnDeserializationError(ref suppressDefaultLog, exception, httpStatusCode);
                if (!suppressDefaultLog)
                    Logger.LogError(exception, "An error occurred while deserializing the {code} response.", httpStatusCode);
            }

            partial void OnDeserializationError(ref bool suppressDefaultLog, Exception exception, HttpStatusCode httpStatusCode);
        }
    }
}

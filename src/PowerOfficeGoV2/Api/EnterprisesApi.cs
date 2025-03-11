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
    public interface IEnterprisesApi : IApi
    {
        /// <summary>
        /// The class containing the events
        /// </summary>
        EnterprisesApiEvents Events { get; }

        /// <summary>
        /// Get the enterprises registered for the client. Enterprises are primarily used for payroll reporting in Go.  A company may have more than one enterprise if the company have operations in different industries. (Auth roles: Enterprises,Enterprises_Full)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseNos">Filter by enterprise number. Search string should be separated by comma. If filter string is null or whitespace, query is returned as is. (optional)</param>
        /// <param name="createdDateTimeOffsetGreaterThan">Filter by the enterprise created timestamp property. This filtering will return all enterprises with a created timestamp greater than the timestamp provided. Can be used when polling for new entries from Go. Timestamp not inclusive. (optional)</param>
        /// <param name="lastChangedDateTimeOffsetGreaterThan">Filter by the enterprise last changed timestamp property. This filtering will return all enterprises with a last changed timestamp greater than the timestamp provided. Timestamp not inclusive. (optional)</param>
        /// <param name="resourceParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IEnterprisesGetApiResponse"/>&gt;</returns>
        Task<IEnterprisesGetApiResponse> EnterprisesGetAsync(Option<string> enterpriseNos = default, Option<DateTimeOffset> createdDateTimeOffsetGreaterThan = default, Option<DateTimeOffset> lastChangedDateTimeOffsetGreaterThan = default, Option<ResourceParameters> resourceParameter = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the enterprises registered for the client. Enterprises are primarily used for payroll reporting in Go.  A company may have more than one enterprise if the company have operations in different industries. (Auth roles: Enterprises,Enterprises_Full)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="enterpriseNos">Filter by enterprise number. Search string should be separated by comma. If filter string is null or whitespace, query is returned as is. (optional)</param>
        /// <param name="createdDateTimeOffsetGreaterThan">Filter by the enterprise created timestamp property. This filtering will return all enterprises with a created timestamp greater than the timestamp provided. Can be used when polling for new entries from Go. Timestamp not inclusive. (optional)</param>
        /// <param name="lastChangedDateTimeOffsetGreaterThan">Filter by the enterprise last changed timestamp property. This filtering will return all enterprises with a last changed timestamp greater than the timestamp provided. Timestamp not inclusive. (optional)</param>
        /// <param name="resourceParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IEnterprisesGetApiResponse"/>?&gt;</returns>
        Task<IEnterprisesGetApiResponse?> EnterprisesGetOrDefaultAsync(Option<string> enterpriseNos = default, Option<DateTimeOffset> createdDateTimeOffsetGreaterThan = default, Option<DateTimeOffset> lastChangedDateTimeOffsetGreaterThan = default, Option<ResourceParameters> resourceParameter = default, System.Threading.CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The <see cref="IEnterprisesGetApiResponse"/>
    /// </summary>
    public interface IEnterprisesGetApiResponse : PowerOfficeGoV2.Client.IApiResponse, IOk<List<EnterpriseDto>?>, IBadRequest<PowerOfficeGoV2.Model.ProblemDetails?>, INotFound<PowerOfficeGoV2.Model.ProblemDetails?>
    {
        /// <summary>
        /// Returns true if the response is 200 Ok
        /// </summary>
        /// <returns></returns>
        bool IsOk { get; }

        /// <summary>
        /// Returns true if the response is 204 NoContent
        /// </summary>
        /// <returns></returns>
        bool IsNoContent { get; }

        /// <summary>
        /// Returns true if the response is 400 BadRequest
        /// </summary>
        /// <returns></returns>
        bool IsBadRequest { get; }

        /// <summary>
        /// Returns true if the response is 404 NotFound
        /// </summary>
        /// <returns></returns>
        bool IsNotFound { get; }

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
    public class EnterprisesApiEvents
    {
        /// <summary>
        /// The event raised after the server response
        /// </summary>
        public event EventHandler<ApiResponseEventArgs>? OnEnterprisesGet;

        /// <summary>
        /// The event raised after an error querying the server
        /// </summary>
        public event EventHandler<ExceptionEventArgs>? OnErrorEnterprisesGet;

        internal void ExecuteOnEnterprisesGet(EnterprisesApi.EnterprisesGetApiResponse apiResponse)
        {
            OnEnterprisesGet?.Invoke(this, new ApiResponseEventArgs(apiResponse));
        }

        internal void ExecuteOnErrorEnterprisesGet(Exception exception)
        {
            OnErrorEnterprisesGet?.Invoke(this, new ExceptionEventArgs(exception));
        }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public sealed partial class EnterprisesApi : IEnterprisesApi
    {
        private JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        /// The logger factory
        /// </summary>
        public ILoggerFactory LoggerFactory { get; }

        /// <summary>
        /// The logger
        /// </summary>
        public ILogger<EnterprisesApi> Logger { get; }

        /// <summary>
        /// The HttpClient
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// The class containing the events
        /// </summary>
        public EnterprisesApiEvents Events { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterprisesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EnterprisesApi(ILogger<EnterprisesApi> logger, ILoggerFactory loggerFactory, HttpClient httpClient, JsonSerializerOptionsProvider jsonSerializerOptionsProvider, EnterprisesApiEvents enterprisesApiEvents)
        {
            _jsonSerializerOptions = jsonSerializerOptionsProvider.Options;
            LoggerFactory = loggerFactory;
            Logger = LoggerFactory.CreateLogger<EnterprisesApi>();
            HttpClient = httpClient;
            Events = enterprisesApiEvents;
        }

        partial void FormatEnterprisesGet(ref Option<string> enterpriseNos, ref Option<DateTimeOffset> createdDateTimeOffsetGreaterThan, ref Option<DateTimeOffset> lastChangedDateTimeOffsetGreaterThan, Option<ResourceParameters> resourceParameter);

        /// <summary>
        /// Validates the request parameters
        /// </summary>
        /// <param name="enterpriseNos"></param>
        /// <param name="resourceParameter"></param>
        /// <returns></returns>
        private void ValidateEnterprisesGet(Option<string> enterpriseNos, Option<ResourceParameters> resourceParameter)
        {
            if (enterpriseNos.IsSet && enterpriseNos.Value == null)
                throw new ArgumentNullException(nameof(enterpriseNos));

            if (resourceParameter.IsSet && resourceParameter.Value == null)
                throw new ArgumentNullException(nameof(resourceParameter));
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="enterpriseNos"></param>
        /// <param name="createdDateTimeOffsetGreaterThan"></param>
        /// <param name="lastChangedDateTimeOffsetGreaterThan"></param>
        /// <param name="resourceParameter"></param>
        private void AfterEnterprisesGetDefaultImplementation(IEnterprisesGetApiResponse apiResponseLocalVar, Option<string> enterpriseNos, Option<DateTimeOffset> createdDateTimeOffsetGreaterThan, Option<DateTimeOffset> lastChangedDateTimeOffsetGreaterThan, Option<ResourceParameters> resourceParameter)
        {
            bool suppressDefaultLog = false;
            AfterEnterprisesGet(ref suppressDefaultLog, apiResponseLocalVar, enterpriseNos, createdDateTimeOffsetGreaterThan, lastChangedDateTimeOffsetGreaterThan, resourceParameter);
            if (!suppressDefaultLog)
                Logger.LogInformation("{0,-9} | {1} | {3}", (apiResponseLocalVar.DownloadedAt - apiResponseLocalVar.RequestedAt).TotalSeconds, apiResponseLocalVar.StatusCode, apiResponseLocalVar.Path);
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="enterpriseNos"></param>
        /// <param name="createdDateTimeOffsetGreaterThan"></param>
        /// <param name="lastChangedDateTimeOffsetGreaterThan"></param>
        /// <param name="resourceParameter"></param>
        partial void AfterEnterprisesGet(ref bool suppressDefaultLog, IEnterprisesGetApiResponse apiResponseLocalVar, Option<string> enterpriseNos, Option<DateTimeOffset> createdDateTimeOffsetGreaterThan, Option<DateTimeOffset> lastChangedDateTimeOffsetGreaterThan, Option<ResourceParameters> resourceParameter);

        /// <summary>
        /// Logs exceptions that occur while retrieving the server response
        /// </summary>
        /// <param name="exceptionLocalVar"></param>
        /// <param name="pathFormatLocalVar"></param>
        /// <param name="pathLocalVar"></param>
        /// <param name="enterpriseNos"></param>
        /// <param name="createdDateTimeOffsetGreaterThan"></param>
        /// <param name="lastChangedDateTimeOffsetGreaterThan"></param>
        /// <param name="resourceParameter"></param>
        private void OnErrorEnterprisesGetDefaultImplementation(Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, Option<string> enterpriseNos, Option<DateTimeOffset> createdDateTimeOffsetGreaterThan, Option<DateTimeOffset> lastChangedDateTimeOffsetGreaterThan, Option<ResourceParameters> resourceParameter)
        {
            bool suppressDefaultLogLocalVar = false;
            OnErrorEnterprisesGet(ref suppressDefaultLogLocalVar, exceptionLocalVar, pathFormatLocalVar, pathLocalVar, enterpriseNos, createdDateTimeOffsetGreaterThan, lastChangedDateTimeOffsetGreaterThan, resourceParameter);
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
        /// <param name="enterpriseNos"></param>
        /// <param name="createdDateTimeOffsetGreaterThan"></param>
        /// <param name="lastChangedDateTimeOffsetGreaterThan"></param>
        /// <param name="resourceParameter"></param>
        partial void OnErrorEnterprisesGet(ref bool suppressDefaultLogLocalVar, Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, Option<string> enterpriseNos, Option<DateTimeOffset> createdDateTimeOffsetGreaterThan, Option<DateTimeOffset> lastChangedDateTimeOffsetGreaterThan, Option<ResourceParameters> resourceParameter);

        /// <summary>
        /// Get the enterprises registered for the client. Enterprises are primarily used for payroll reporting in Go.  A company may have more than one enterprise if the company have operations in different industries. (Auth roles: Enterprises,Enterprises_Full) 
        /// </summary>
        /// <param name="enterpriseNos">Filter by enterprise number. Search string should be separated by comma. If filter string is null or whitespace, query is returned as is. (optional)</param>
        /// <param name="createdDateTimeOffsetGreaterThan">Filter by the enterprise created timestamp property. This filtering will return all enterprises with a created timestamp greater than the timestamp provided. Can be used when polling for new entries from Go. Timestamp not inclusive. (optional)</param>
        /// <param name="lastChangedDateTimeOffsetGreaterThan">Filter by the enterprise last changed timestamp property. This filtering will return all enterprises with a last changed timestamp greater than the timestamp provided. Timestamp not inclusive. (optional)</param>
        /// <param name="resourceParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IEnterprisesGetApiResponse"/>&gt;</returns>
        public async Task<IEnterprisesGetApiResponse?> EnterprisesGetOrDefaultAsync(Option<string> enterpriseNos = default, Option<DateTimeOffset> createdDateTimeOffsetGreaterThan = default, Option<DateTimeOffset> lastChangedDateTimeOffsetGreaterThan = default, Option<ResourceParameters> resourceParameter = default, System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await EnterprisesGetAsync(enterpriseNos, createdDateTimeOffsetGreaterThan, lastChangedDateTimeOffsetGreaterThan, resourceParameter, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Get the enterprises registered for the client. Enterprises are primarily used for payroll reporting in Go.  A company may have more than one enterprise if the company have operations in different industries. (Auth roles: Enterprises,Enterprises_Full) 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseNos">Filter by enterprise number. Search string should be separated by comma. If filter string is null or whitespace, query is returned as is. (optional)</param>
        /// <param name="createdDateTimeOffsetGreaterThan">Filter by the enterprise created timestamp property. This filtering will return all enterprises with a created timestamp greater than the timestamp provided. Can be used when polling for new entries from Go. Timestamp not inclusive. (optional)</param>
        /// <param name="lastChangedDateTimeOffsetGreaterThan">Filter by the enterprise last changed timestamp property. This filtering will return all enterprises with a last changed timestamp greater than the timestamp provided. Timestamp not inclusive. (optional)</param>
        /// <param name="resourceParameter"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IEnterprisesGetApiResponse"/>&gt;</returns>
        public async Task<IEnterprisesGetApiResponse> EnterprisesGetAsync(Option<string> enterpriseNos = default, Option<DateTimeOffset> createdDateTimeOffsetGreaterThan = default, Option<DateTimeOffset> lastChangedDateTimeOffsetGreaterThan = default, Option<ResourceParameters> resourceParameter = default, System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                ValidateEnterprisesGet(enterpriseNos, resourceParameter);

                FormatEnterprisesGet(ref enterpriseNos, ref createdDateTimeOffsetGreaterThan, ref lastChangedDateTimeOffsetGreaterThan, resourceParameter);

                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress!.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = ClientUtils.CONTEXT_PATH + "/Enterprises";

                    System.Collections.Specialized.NameValueCollection parseQueryStringLocalVar = System.Web.HttpUtility.ParseQueryString(string.Empty);

                    if (enterpriseNos.IsSet)
                        parseQueryStringLocalVar["enterpriseNos"] = ClientUtils.ParameterToString(enterpriseNos.Value);

                    if (createdDateTimeOffsetGreaterThan.IsSet)
                        parseQueryStringLocalVar["createdDateTimeOffsetGreaterThan"] = ClientUtils.ParameterToString(createdDateTimeOffsetGreaterThan.Value);

                    if (lastChangedDateTimeOffsetGreaterThan.IsSet)
                        parseQueryStringLocalVar["lastChangedDateTimeOffsetGreaterThan"] = ClientUtils.ParameterToString(lastChangedDateTimeOffsetGreaterThan.Value);

                    if (resourceParameter.IsSet)
                        parseQueryStringLocalVar["resourceParameter"] = ClientUtils.ParameterToString(resourceParameter.Value);

                    uriBuilderLocalVar.Query = parseQueryStringLocalVar.ToString();

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

                        ILogger<EnterprisesGetApiResponse> apiResponseLoggerLocalVar = LoggerFactory.CreateLogger<EnterprisesGetApiResponse>();

                        EnterprisesGetApiResponse apiResponseLocalVar = new(apiResponseLoggerLocalVar, httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, "/Enterprises", requestedAtLocalVar, _jsonSerializerOptions);

                        AfterEnterprisesGetDefaultImplementation(apiResponseLocalVar, enterpriseNos, createdDateTimeOffsetGreaterThan, lastChangedDateTimeOffsetGreaterThan, resourceParameter);

                        Events.ExecuteOnEnterprisesGet(apiResponseLocalVar);

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorEnterprisesGetDefaultImplementation(e, "/Enterprises", uriBuilderLocalVar.Path, enterpriseNos, createdDateTimeOffsetGreaterThan, lastChangedDateTimeOffsetGreaterThan, resourceParameter);
                Events.ExecuteOnErrorEnterprisesGet(e);
                throw;
            }
        }

        /// <summary>
        /// The <see cref="EnterprisesGetApiResponse"/>
        /// </summary>
        public partial class EnterprisesGetApiResponse : PowerOfficeGoV2.Client.ApiResponse, IEnterprisesGetApiResponse
        {
            /// <summary>
            /// The logger
            /// </summary>
            public ILogger<EnterprisesGetApiResponse> Logger { get; }

            /// <summary>
            /// The <see cref="EnterprisesGetApiResponse"/>
            /// </summary>
            /// <param name="logger"></param>
            /// <param name="httpRequestMessage"></param>
            /// <param name="httpResponseMessage"></param>
            /// <param name="rawContent"></param>
            /// <param name="path"></param>
            /// <param name="requestedAt"></param>
            /// <param name="jsonSerializerOptions"></param>
            public EnterprisesGetApiResponse(ILogger<EnterprisesGetApiResponse> logger, System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage, string rawContent, string path, DateTime requestedAt, System.Text.Json.JsonSerializerOptions jsonSerializerOptions) : base(httpRequestMessage, httpResponseMessage, rawContent, path, requestedAt, jsonSerializerOptions)
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
            public List<EnterpriseDto>? Ok()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsOk
                    ? System.Text.Json.JsonSerializer.Deserialize<List<EnterpriseDto>>(RawContent, _jsonSerializerOptions)
                    : null;
            }

            /// <summary>
            /// Returns true if the response is 200 Ok and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryOk([NotNullWhen(true)]out List<EnterpriseDto>? result)
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
            /// Returns true if the response is 204 NoContent
            /// </summary>
            /// <returns></returns>
            public bool IsNoContent => 204 == (int)StatusCode;

            /// <summary>
            /// Returns true if the response is 400 BadRequest
            /// </summary>
            /// <returns></returns>
            public bool IsBadRequest => 400 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 400 BadRequest
            /// </summary>
            /// <returns></returns>
            public PowerOfficeGoV2.Model.ProblemDetails? BadRequest()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsBadRequest
                    ? System.Text.Json.JsonSerializer.Deserialize<PowerOfficeGoV2.Model.ProblemDetails>(RawContent, _jsonSerializerOptions)
                    : null;
            }

            /// <summary>
            /// Returns true if the response is 400 BadRequest and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryBadRequest([NotNullWhen(true)]out PowerOfficeGoV2.Model.ProblemDetails? result)
            {
                result = null;

                try
                {
                    result = BadRequest();
                } catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)400);
                }

                return result != null;
            }

            /// <summary>
            /// Returns true if the response is 404 NotFound
            /// </summary>
            /// <returns></returns>
            public bool IsNotFound => 404 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 404 NotFound
            /// </summary>
            /// <returns></returns>
            public PowerOfficeGoV2.Model.ProblemDetails? NotFound()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsNotFound
                    ? System.Text.Json.JsonSerializer.Deserialize<PowerOfficeGoV2.Model.ProblemDetails>(RawContent, _jsonSerializerOptions)
                    : null;
            }

            /// <summary>
            /// Returns true if the response is 404 NotFound and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryNotFound([NotNullWhen(true)]out PowerOfficeGoV2.Model.ProblemDetails? result)
            {
                result = null;

                try
                {
                    result = NotFound();
                } catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)404);
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
            public bool IsDefault => !IsOk && !IsNoContent && !IsBadRequest && !IsNotFound && !IsUnauthorized && !IsForbidden && !IsTooManyRequests;

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

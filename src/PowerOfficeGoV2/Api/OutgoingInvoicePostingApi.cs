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
    public interface IOutgoingInvoicePostingApi : IApi
    {
        /// <summary>
        /// The class containing the events
        /// </summary>
        OutgoingInvoicePostingApiEvents Events { get; }

        /// <summary>
        /// Gets the specific Outgoing invoice voucher by id. (Auth roles: OutgoingInvoiceVoucher_Full)
        /// </summary>
        /// <remarks>
        /// Gets the specific outgoing invoice voucher by id. Note that when querying outgoing invoice vouchers,  a response will only be produced for vouchers the integration have created using POST operations with the  outgoing invoice voucher endpoint.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the outgoing invoice voucher.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IGetOutgoingInvoiceVoucherByIdApiResponse"/>&gt;</returns>
        Task<IGetOutgoingInvoiceVoucherByIdApiResponse> GetOutgoingInvoiceVoucherByIdAsync(Guid id, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specific Outgoing invoice voucher by id. (Auth roles: OutgoingInvoiceVoucher_Full)
        /// </summary>
        /// <remarks>
        /// Gets the specific outgoing invoice voucher by id. Note that when querying outgoing invoice vouchers,  a response will only be produced for vouchers the integration have created using POST operations with the  outgoing invoice voucher endpoint.
        /// </remarks>
        /// <param name="id">The id of the outgoing invoice voucher.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IGetOutgoingInvoiceVoucherByIdApiResponse"/>?&gt;</returns>
        Task<IGetOutgoingInvoiceVoucherByIdApiResponse?> GetOutgoingInvoiceVoucherByIdOrDefaultAsync(Guid id, System.Threading.CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The <see cref="IGetOutgoingInvoiceVoucherByIdApiResponse"/>
    /// </summary>
    public interface IGetOutgoingInvoiceVoucherByIdApiResponse : PowerOfficeGoV2.Client.IApiResponse, IOk<PowerOfficeGoV2.Model.OutgoingInvoiceVoucherDto?>, INotFound<PowerOfficeGoV2.Model.ProblemDetails?>
    {
        /// <summary>
        /// Returns true if the response is 200 Ok
        /// </summary>
        /// <returns></returns>
        bool IsOk { get; }

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
    public class OutgoingInvoicePostingApiEvents
    {
        /// <summary>
        /// The event raised after the server response
        /// </summary>
        public event EventHandler<ApiResponseEventArgs>? OnGetOutgoingInvoiceVoucherById;

        /// <summary>
        /// The event raised after an error querying the server
        /// </summary>
        public event EventHandler<ExceptionEventArgs>? OnErrorGetOutgoingInvoiceVoucherById;

        internal void ExecuteOnGetOutgoingInvoiceVoucherById(OutgoingInvoicePostingApi.GetOutgoingInvoiceVoucherByIdApiResponse apiResponse)
        {
            OnGetOutgoingInvoiceVoucherById?.Invoke(this, new ApiResponseEventArgs(apiResponse));
        }

        internal void ExecuteOnErrorGetOutgoingInvoiceVoucherById(Exception exception)
        {
            OnErrorGetOutgoingInvoiceVoucherById?.Invoke(this, new ExceptionEventArgs(exception));
        }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public sealed partial class OutgoingInvoicePostingApi : IOutgoingInvoicePostingApi
    {
        private JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        /// The logger factory
        /// </summary>
        public ILoggerFactory LoggerFactory { get; }

        /// <summary>
        /// The logger
        /// </summary>
        public ILogger<OutgoingInvoicePostingApi> Logger { get; }

        /// <summary>
        /// The HttpClient
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// The class containing the events
        /// </summary>
        public OutgoingInvoicePostingApiEvents Events { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutgoingInvoicePostingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OutgoingInvoicePostingApi(ILogger<OutgoingInvoicePostingApi> logger, ILoggerFactory loggerFactory, HttpClient httpClient, JsonSerializerOptionsProvider jsonSerializerOptionsProvider, OutgoingInvoicePostingApiEvents outgoingInvoicePostingApiEvents)
        {
            _jsonSerializerOptions = jsonSerializerOptionsProvider.Options;
            LoggerFactory = loggerFactory;
            Logger = LoggerFactory.CreateLogger<OutgoingInvoicePostingApi>();
            HttpClient = httpClient;
            Events = outgoingInvoicePostingApiEvents;
        }

        partial void FormatGetOutgoingInvoiceVoucherById(ref Guid id);

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="id"></param>
        private void AfterGetOutgoingInvoiceVoucherByIdDefaultImplementation(IGetOutgoingInvoiceVoucherByIdApiResponse apiResponseLocalVar, Guid id)
        {
            bool suppressDefaultLog = false;
            AfterGetOutgoingInvoiceVoucherById(ref suppressDefaultLog, apiResponseLocalVar, id);
            if (!suppressDefaultLog)
                Logger.LogInformation("{0,-9} | {1} | {3}", (apiResponseLocalVar.DownloadedAt - apiResponseLocalVar.RequestedAt).TotalSeconds, apiResponseLocalVar.StatusCode, apiResponseLocalVar.Path);
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="id"></param>
        partial void AfterGetOutgoingInvoiceVoucherById(ref bool suppressDefaultLog, IGetOutgoingInvoiceVoucherByIdApiResponse apiResponseLocalVar, Guid id);

        /// <summary>
        /// Logs exceptions that occur while retrieving the server response
        /// </summary>
        /// <param name="exceptionLocalVar"></param>
        /// <param name="pathFormatLocalVar"></param>
        /// <param name="pathLocalVar"></param>
        /// <param name="id"></param>
        private void OnErrorGetOutgoingInvoiceVoucherByIdDefaultImplementation(Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, Guid id)
        {
            bool suppressDefaultLogLocalVar = false;
            OnErrorGetOutgoingInvoiceVoucherById(ref suppressDefaultLogLocalVar, exceptionLocalVar, pathFormatLocalVar, pathLocalVar, id);
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
        /// <param name="id"></param>
        partial void OnErrorGetOutgoingInvoiceVoucherById(ref bool suppressDefaultLogLocalVar, Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, Guid id);

        /// <summary>
        /// Gets the specific Outgoing invoice voucher by id. (Auth roles: OutgoingInvoiceVoucher_Full) Gets the specific outgoing invoice voucher by id. Note that when querying outgoing invoice vouchers,  a response will only be produced for vouchers the integration have created using POST operations with the  outgoing invoice voucher endpoint.
        /// </summary>
        /// <param name="id">The id of the outgoing invoice voucher.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IGetOutgoingInvoiceVoucherByIdApiResponse"/>&gt;</returns>
        public async Task<IGetOutgoingInvoiceVoucherByIdApiResponse?> GetOutgoingInvoiceVoucherByIdOrDefaultAsync(Guid id, System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await GetOutgoingInvoiceVoucherByIdAsync(id, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Gets the specific Outgoing invoice voucher by id. (Auth roles: OutgoingInvoiceVoucher_Full) Gets the specific outgoing invoice voucher by id. Note that when querying outgoing invoice vouchers,  a response will only be produced for vouchers the integration have created using POST operations with the  outgoing invoice voucher endpoint.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the outgoing invoice voucher.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IGetOutgoingInvoiceVoucherByIdApiResponse"/>&gt;</returns>
        public async Task<IGetOutgoingInvoiceVoucherByIdApiResponse> GetOutgoingInvoiceVoucherByIdAsync(Guid id, System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                FormatGetOutgoingInvoiceVoucherById(ref id);

                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress!.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = ClientUtils.CONTEXT_PATH + "/Vouchers/OutgoingInvoiceJournals/{id}";
                    uriBuilderLocalVar.Path = uriBuilderLocalVar.Path.Replace("%7Bid%7D", Uri.EscapeDataString(id.ToString()));

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

                        ILogger<GetOutgoingInvoiceVoucherByIdApiResponse> apiResponseLoggerLocalVar = LoggerFactory.CreateLogger<GetOutgoingInvoiceVoucherByIdApiResponse>();

                        GetOutgoingInvoiceVoucherByIdApiResponse apiResponseLocalVar = new(apiResponseLoggerLocalVar, httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, "/Vouchers/OutgoingInvoiceJournals/{id}", requestedAtLocalVar, _jsonSerializerOptions);

                        AfterGetOutgoingInvoiceVoucherByIdDefaultImplementation(apiResponseLocalVar, id);

                        Events.ExecuteOnGetOutgoingInvoiceVoucherById(apiResponseLocalVar);

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorGetOutgoingInvoiceVoucherByIdDefaultImplementation(e, "/Vouchers/OutgoingInvoiceJournals/{id}", uriBuilderLocalVar.Path, id);
                Events.ExecuteOnErrorGetOutgoingInvoiceVoucherById(e);
                throw;
            }
        }

        /// <summary>
        /// The <see cref="GetOutgoingInvoiceVoucherByIdApiResponse"/>
        /// </summary>
        public partial class GetOutgoingInvoiceVoucherByIdApiResponse : PowerOfficeGoV2.Client.ApiResponse, IGetOutgoingInvoiceVoucherByIdApiResponse
        {
            /// <summary>
            /// The logger
            /// </summary>
            public ILogger<GetOutgoingInvoiceVoucherByIdApiResponse> Logger { get; }

            /// <summary>
            /// The <see cref="GetOutgoingInvoiceVoucherByIdApiResponse"/>
            /// </summary>
            /// <param name="logger"></param>
            /// <param name="httpRequestMessage"></param>
            /// <param name="httpResponseMessage"></param>
            /// <param name="rawContent"></param>
            /// <param name="path"></param>
            /// <param name="requestedAt"></param>
            /// <param name="jsonSerializerOptions"></param>
            public GetOutgoingInvoiceVoucherByIdApiResponse(ILogger<GetOutgoingInvoiceVoucherByIdApiResponse> logger, System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage, string rawContent, string path, DateTime requestedAt, System.Text.Json.JsonSerializerOptions jsonSerializerOptions) : base(httpRequestMessage, httpResponseMessage, rawContent, path, requestedAt, jsonSerializerOptions)
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
            public PowerOfficeGoV2.Model.OutgoingInvoiceVoucherDto? Ok()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsOk
                    ? System.Text.Json.JsonSerializer.Deserialize<PowerOfficeGoV2.Model.OutgoingInvoiceVoucherDto>(RawContent, _jsonSerializerOptions)
                    : null;
            }

            /// <summary>
            /// Returns true if the response is 200 Ok and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryOk([NotNullWhen(true)]out PowerOfficeGoV2.Model.OutgoingInvoiceVoucherDto? result)
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
            public bool IsDefault => !IsOk && !IsNotFound && !IsUnauthorized && !IsForbidden && !IsTooManyRequests;

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

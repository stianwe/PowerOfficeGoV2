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
    public interface ICurrencyRatesApi : IApi
    {
        /// <summary>
        /// The class containing the events
        /// </summary>
        CurrencyRatesApiEvents Events { get; }

        /// <summary>
        /// Get currency rate. (Auth roles: CommonServices,CommonServices_Full)
        /// </summary>
        /// <remarks>
        /// Get a currency exchange rate between two currencies for a given date.  Currency rate for a future date is not available, and will return the newest available rate.  The rates are updated daily around 1600 CET.  Rates originate from European Central Bank [https://data.ecb.europa.eu/currency-converter]
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fromCurrency"></param>
        /// <param name="toCurrency"></param>
        /// <param name="asOnDate"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ICurrencyRatesGetApiResponse"/>&gt;</returns>
        Task<ICurrencyRatesGetApiResponse> CurrencyRatesGetAsync(string fromCurrency, string toCurrency, DateTimeOffset asOnDate, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get currency rate. (Auth roles: CommonServices,CommonServices_Full)
        /// </summary>
        /// <remarks>
        /// Get a currency exchange rate between two currencies for a given date.  Currency rate for a future date is not available, and will return the newest available rate.  The rates are updated daily around 1600 CET.  Rates originate from European Central Bank [https://data.ecb.europa.eu/currency-converter]
        /// </remarks>
        /// <param name="fromCurrency"></param>
        /// <param name="toCurrency"></param>
        /// <param name="asOnDate"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ICurrencyRatesGetApiResponse"/>?&gt;</returns>
        Task<ICurrencyRatesGetApiResponse?> CurrencyRatesGetOrDefaultAsync(string fromCurrency, string toCurrency, DateTimeOffset asOnDate, System.Threading.CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The <see cref="ICurrencyRatesGetApiResponse"/>
    /// </summary>
    public interface ICurrencyRatesGetApiResponse : PowerOfficeGoV2.Client.IApiResponse, IOk<PowerOfficeGoV2.Model.CurrencyRateDto?>, IBadRequest<PowerOfficeGoV2.Model.ProblemDetails?>
    {
        /// <summary>
        /// Returns true if the response is 200 Ok
        /// </summary>
        /// <returns></returns>
        bool IsOk { get; }

        /// <summary>
        /// Returns true if the response is 400 BadRequest
        /// </summary>
        /// <returns></returns>
        bool IsBadRequest { get; }

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
    public class CurrencyRatesApiEvents
    {
        /// <summary>
        /// The event raised after the server response
        /// </summary>
        public event EventHandler<ApiResponseEventArgs>? OnCurrencyRatesGet;

        /// <summary>
        /// The event raised after an error querying the server
        /// </summary>
        public event EventHandler<ExceptionEventArgs>? OnErrorCurrencyRatesGet;

        internal void ExecuteOnCurrencyRatesGet(CurrencyRatesApi.CurrencyRatesGetApiResponse apiResponse)
        {
            OnCurrencyRatesGet?.Invoke(this, new ApiResponseEventArgs(apiResponse));
        }

        internal void ExecuteOnErrorCurrencyRatesGet(Exception exception)
        {
            OnErrorCurrencyRatesGet?.Invoke(this, new ExceptionEventArgs(exception));
        }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public sealed partial class CurrencyRatesApi : ICurrencyRatesApi
    {
        private JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        /// The logger factory
        /// </summary>
        public ILoggerFactory LoggerFactory { get; }

        /// <summary>
        /// The logger
        /// </summary>
        public ILogger<CurrencyRatesApi> Logger { get; }

        /// <summary>
        /// The HttpClient
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// The class containing the events
        /// </summary>
        public CurrencyRatesApiEvents Events { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyRatesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CurrencyRatesApi(ILogger<CurrencyRatesApi> logger, ILoggerFactory loggerFactory, HttpClient httpClient, JsonSerializerOptionsProvider jsonSerializerOptionsProvider, CurrencyRatesApiEvents currencyRatesApiEvents)
        {
            _jsonSerializerOptions = jsonSerializerOptionsProvider.Options;
            LoggerFactory = loggerFactory;
            Logger = LoggerFactory.CreateLogger<CurrencyRatesApi>();
            HttpClient = httpClient;
            Events = currencyRatesApiEvents;
        }

        partial void FormatCurrencyRatesGet(ref string fromCurrency, ref string toCurrency, ref DateTimeOffset asOnDate);

        /// <summary>
        /// Validates the request parameters
        /// </summary>
        /// <param name="fromCurrency"></param>
        /// <param name="toCurrency"></param>
        /// <returns></returns>
        private void ValidateCurrencyRatesGet(string fromCurrency, string toCurrency)
        {
            if (fromCurrency == null)
                throw new ArgumentNullException(nameof(fromCurrency));

            if (toCurrency == null)
                throw new ArgumentNullException(nameof(toCurrency));
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="fromCurrency"></param>
        /// <param name="toCurrency"></param>
        /// <param name="asOnDate"></param>
        private void AfterCurrencyRatesGetDefaultImplementation(ICurrencyRatesGetApiResponse apiResponseLocalVar, string fromCurrency, string toCurrency, DateTimeOffset asOnDate)
        {
            bool suppressDefaultLog = false;
            AfterCurrencyRatesGet(ref suppressDefaultLog, apiResponseLocalVar, fromCurrency, toCurrency, asOnDate);
            if (!suppressDefaultLog)
                Logger.LogInformation("{0,-9} | {1} | {3}", (apiResponseLocalVar.DownloadedAt - apiResponseLocalVar.RequestedAt).TotalSeconds, apiResponseLocalVar.StatusCode, apiResponseLocalVar.Path);
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="fromCurrency"></param>
        /// <param name="toCurrency"></param>
        /// <param name="asOnDate"></param>
        partial void AfterCurrencyRatesGet(ref bool suppressDefaultLog, ICurrencyRatesGetApiResponse apiResponseLocalVar, string fromCurrency, string toCurrency, DateTimeOffset asOnDate);

        /// <summary>
        /// Logs exceptions that occur while retrieving the server response
        /// </summary>
        /// <param name="exceptionLocalVar"></param>
        /// <param name="pathFormatLocalVar"></param>
        /// <param name="pathLocalVar"></param>
        /// <param name="fromCurrency"></param>
        /// <param name="toCurrency"></param>
        /// <param name="asOnDate"></param>
        private void OnErrorCurrencyRatesGetDefaultImplementation(Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, string fromCurrency, string toCurrency, DateTimeOffset asOnDate)
        {
            bool suppressDefaultLogLocalVar = false;
            OnErrorCurrencyRatesGet(ref suppressDefaultLogLocalVar, exceptionLocalVar, pathFormatLocalVar, pathLocalVar, fromCurrency, toCurrency, asOnDate);
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
        /// <param name="fromCurrency"></param>
        /// <param name="toCurrency"></param>
        /// <param name="asOnDate"></param>
        partial void OnErrorCurrencyRatesGet(ref bool suppressDefaultLogLocalVar, Exception exceptionLocalVar, string pathFormatLocalVar, string pathLocalVar, string fromCurrency, string toCurrency, DateTimeOffset asOnDate);

        /// <summary>
        /// Get currency rate. (Auth roles: CommonServices,CommonServices_Full) Get a currency exchange rate between two currencies for a given date.  Currency rate for a future date is not available, and will return the newest available rate.  The rates are updated daily around 1600 CET.  Rates originate from European Central Bank [https://data.ecb.europa.eu/currency-converter]
        /// </summary>
        /// <param name="fromCurrency"></param>
        /// <param name="toCurrency"></param>
        /// <param name="asOnDate"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ICurrencyRatesGetApiResponse"/>&gt;</returns>
        public async Task<ICurrencyRatesGetApiResponse?> CurrencyRatesGetOrDefaultAsync(string fromCurrency, string toCurrency, DateTimeOffset asOnDate, System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await CurrencyRatesGetAsync(fromCurrency, toCurrency, asOnDate, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Get currency rate. (Auth roles: CommonServices,CommonServices_Full) Get a currency exchange rate between two currencies for a given date.  Currency rate for a future date is not available, and will return the newest available rate.  The rates are updated daily around 1600 CET.  Rates originate from European Central Bank [https://data.ecb.europa.eu/currency-converter]
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="fromCurrency"></param>
        /// <param name="toCurrency"></param>
        /// <param name="asOnDate"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ICurrencyRatesGetApiResponse"/>&gt;</returns>
        public async Task<ICurrencyRatesGetApiResponse> CurrencyRatesGetAsync(string fromCurrency, string toCurrency, DateTimeOffset asOnDate, System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                ValidateCurrencyRatesGet(fromCurrency, toCurrency);

                FormatCurrencyRatesGet(ref fromCurrency, ref toCurrency, ref asOnDate);

                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress!.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = ClientUtils.CONTEXT_PATH + "/CurrencyRates";

                    System.Collections.Specialized.NameValueCollection parseQueryStringLocalVar = System.Web.HttpUtility.ParseQueryString(string.Empty);

                    parseQueryStringLocalVar["fromCurrency"] = ClientUtils.ParameterToString(fromCurrency);
                    parseQueryStringLocalVar["toCurrency"] = ClientUtils.ParameterToString(toCurrency);
                    parseQueryStringLocalVar["asOnDate"] = ClientUtils.ParameterToString(asOnDate);

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

                        ILogger<CurrencyRatesGetApiResponse> apiResponseLoggerLocalVar = LoggerFactory.CreateLogger<CurrencyRatesGetApiResponse>();

                        CurrencyRatesGetApiResponse apiResponseLocalVar = new(apiResponseLoggerLocalVar, httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, "/CurrencyRates", requestedAtLocalVar, _jsonSerializerOptions);

                        AfterCurrencyRatesGetDefaultImplementation(apiResponseLocalVar, fromCurrency, toCurrency, asOnDate);

                        Events.ExecuteOnCurrencyRatesGet(apiResponseLocalVar);

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorCurrencyRatesGetDefaultImplementation(e, "/CurrencyRates", uriBuilderLocalVar.Path, fromCurrency, toCurrency, asOnDate);
                Events.ExecuteOnErrorCurrencyRatesGet(e);
                throw;
            }
        }

        /// <summary>
        /// The <see cref="CurrencyRatesGetApiResponse"/>
        /// </summary>
        public partial class CurrencyRatesGetApiResponse : PowerOfficeGoV2.Client.ApiResponse, ICurrencyRatesGetApiResponse
        {
            /// <summary>
            /// The logger
            /// </summary>
            public ILogger<CurrencyRatesGetApiResponse> Logger { get; }

            /// <summary>
            /// The <see cref="CurrencyRatesGetApiResponse"/>
            /// </summary>
            /// <param name="logger"></param>
            /// <param name="httpRequestMessage"></param>
            /// <param name="httpResponseMessage"></param>
            /// <param name="rawContent"></param>
            /// <param name="path"></param>
            /// <param name="requestedAt"></param>
            /// <param name="jsonSerializerOptions"></param>
            public CurrencyRatesGetApiResponse(ILogger<CurrencyRatesGetApiResponse> logger, System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage, string rawContent, string path, DateTime requestedAt, System.Text.Json.JsonSerializerOptions jsonSerializerOptions) : base(httpRequestMessage, httpResponseMessage, rawContent, path, requestedAt, jsonSerializerOptions)
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
            public PowerOfficeGoV2.Model.CurrencyRateDto? Ok()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsOk
                    ? System.Text.Json.JsonSerializer.Deserialize<PowerOfficeGoV2.Model.CurrencyRateDto>(RawContent, _jsonSerializerOptions)
                    : null;
            }

            /// <summary>
            /// Returns true if the response is 200 Ok and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryOk([NotNullWhen(true)]out PowerOfficeGoV2.Model.CurrencyRateDto? result)
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
            public bool IsDefault => !IsOk && !IsBadRequest && !IsUnauthorized && !IsForbidden && !IsTooManyRequests;

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

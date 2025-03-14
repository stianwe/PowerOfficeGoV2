/*
 * merged spec
 *
 * merged spec
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Microsoft.Extensions.DependencyInjection;
using PowerOfficeGoV2.Api;
using PowerOfficeGoV2.Model;


/* *********************************************************************************
*              Follow these manual steps to construct tests.
*              This file will not be overwritten.
*  *********************************************************************************
* 1. Navigate to ApiTests.Base.cs and ensure any tokens are being created correctly.
*    Take care not to commit credentials to any repository.
*
* 2. Mocking is coordinated by ApiTestsBase#AddApiHttpClients.
*    To mock the client, use the generic AddApiHttpClients.
*    To mock the server, change the client's BaseAddress.
*
* 3. Locate the test you want below
*      - remove the skip property from the Fact attribute
*      - set the value of any variables if necessary
*
* 4. Run the tests and ensure they work.
*
*/


namespace PowerOfficeGoV2.Test.Api
{
    /// <summary>
    ///  Class for testing OutgoingInvoicesApi
    /// </summary>
    public sealed class OutgoingInvoicesApiTests : ApiTestsBase
    {
        private readonly IOutgoingInvoicesApi _instance;

        public OutgoingInvoicesApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<IOutgoingInvoicesApi>();
        }

        /// <summary>
        /// Test GetOutgoingInvoiceById
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetOutgoingInvoiceByIdAsyncTest()
        {
            Guid id = default!;
            var response = await _instance.GetOutgoingInvoiceByIdAsync(id);
            var model = response.Ok();
            Assert.IsType<OutgoingInvoiceDto>(model);
        }

        /// <summary>
        /// Test OutgoingInvoicesGet
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task OutgoingInvoicesGetAsyncTest()
        {
            Client.Option<DateTimeOffset> balanceLastChangedDateTimeOffsetGreaterThan = default!;
            Client.Option<string> customerNos = default!;
            Client.Option<string> customMatchingReferences = default!;
            Client.Option<string> departmentCodes = default!;
            Client.Option<DateTimeOffset> fromDate = default!;
            Client.Option<bool> includeSubProject = default!;
            Client.Option<string> invoiceIds = default!;
            Client.Option<string> invoiceNos = default!;
            Client.Option<bool> onlyCreatedByCurrentIntegration = default!;
            Client.Option<bool> onlyUnpaidInvoices = default!;
            Client.Option<string> projectCodes = default!;
            Client.Option<DateTimeOffset> sentDateTimeOffsetGreaterThan = default!;
            Client.Option<DateTimeOffset> toDate = default!;
            Client.Option<string> voucherNos = default!;
            Client.Option<ResourceParameters> resourceParameter = default!;
            var response = await _instance.OutgoingInvoicesGetAsync(balanceLastChangedDateTimeOffsetGreaterThan, customerNos, customMatchingReferences, departmentCodes, fromDate, includeSubProject, invoiceIds, invoiceNos, onlyCreatedByCurrentIntegration, onlyUnpaidInvoices, projectCodes, sentDateTimeOffsetGreaterThan, toDate, voucherNos, resourceParameter);
            var model = response.Ok();
            Assert.IsType<List<OutgoingInvoiceDto>>(model);
        }

        /// <summary>
        /// Test OutgoingInvoicesIdLinesGet
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task OutgoingInvoicesIdLinesGetAsyncTest()
        {
            Guid id = default!;
            Client.Option<ResourceParameters> resourceParameter = default!;
            var response = await _instance.OutgoingInvoicesIdLinesGetAsync(id, resourceParameter);
            var model = response.Ok();
            Assert.IsType<List<OutgoingInvoiceLineDto>>(model);
        }
    }
}

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
    ///  Class for testing IncomingInvoicesApi
    /// </summary>
    public sealed class IncomingInvoicesApiTests : ApiTestsBase
    {
        private readonly IIncomingInvoicesApi _instance;

        public IncomingInvoicesApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<IIncomingInvoicesApi>();
        }

        /// <summary>
        /// Test GetIncomingInvoiceListItem
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetIncomingInvoiceListItemAsyncTest()
        {
            Client.Option<DateTimeOffset> fromDate = default!;
            Client.Option<DateTimeOffset> toDate = default!;
            Client.Option<DateTimeOffset> balanceLastChangedDateTimeOffsetGreaterThan = default!;
            Client.Option<string> departmentCodes = default!;
            Client.Option<bool> includeSubProject = default!;
            Client.Option<bool> onlyUnpaidInvoices = default!;
            Client.Option<string> projectCodes = default!;
            Client.Option<string> supplierNos = default!;
            Client.Option<string> voucherNos = default!;
            Client.Option<string> voucherTypes = default!;
            Client.Option<ResourceParameters> resourceParameter = default!;
            var response = await _instance.GetIncomingInvoiceListItemAsync(fromDate, toDate, balanceLastChangedDateTimeOffsetGreaterThan, departmentCodes, includeSubProject, onlyUnpaidInvoices, projectCodes, supplierNos, voucherNos, voucherTypes, resourceParameter);
            var model = response.Ok();
            Assert.IsType<List<IncomingInvoiceListItemDto>>(model);
        }

        /// <summary>
        /// Test IncomingInvoicesIdGet
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task IncomingInvoicesIdGetAsyncTest()
        {
            Guid id = default!;
            var response = await _instance.IncomingInvoicesIdGetAsync(id);
            var model = response.Ok();
            Assert.IsType<IncomingInvoiceListItemDto>(model);
        }
    }
}

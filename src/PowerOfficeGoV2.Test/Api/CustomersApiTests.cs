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
    ///  Class for testing CustomersApi
    /// </summary>
    public sealed class CustomersApiTests : ApiTestsBase
    {
        private readonly ICustomersApi _instance;

        public CustomersApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<ICustomersApi>();
        }

        /// <summary>
        /// Test CustomersGet
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task CustomersGetAsyncTest()
        {
            Client.Option<string> contactGroupIds = default!;
            Client.Option<DateTimeOffset> customerCreatedDateTimeOffsetGreaterThan = default!;
            Client.Option<string> customerNos = default!;
            Client.Option<string> externalImportReference = default!;
            Client.Option<string> externalNos = default!;
            Client.Option<DateTimeOffset> lastChangedDateTimeOffsetGreaterThan = default!;
            Client.Option<ResourceParameters> resourceParameter = default!;
            var response = await _instance.CustomersGetAsync(contactGroupIds, customerCreatedDateTimeOffsetGreaterThan, customerNos, externalImportReference, externalNos, lastChangedDateTimeOffsetGreaterThan, resourceParameter);
            var model = response.Ok();
            Assert.IsType<List<CustomerDto>>(model);
        }

        /// <summary>
        /// Test CustomersIdDelete
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task CustomersIdDeleteAsyncTest()
        {
            long id = default!;
            await _instance.CustomersIdDeleteAsync(id);
        }

        /// <summary>
        /// Test CustomersIdPatch
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task CustomersIdPatchAsyncTest()
        {
            long id = default!;
            Client.Option<List<Operation>> operation = default!;
            var response = await _instance.CustomersIdPatchAsync(id, operation);
            var model = response.Ok();
            Assert.IsType<CustomerDto>(model);
        }

        /// <summary>
        /// Test CustomersPost
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task CustomersPostAsyncTest()
        {
            Client.Option<CustomerPostDto> customerPostDto = default!;
            var response = await _instance.CustomersPostAsync(customerPostDto);
            var model = response.Created();
            Assert.IsType<CustomerDto>(model);
        }

        /// <summary>
        /// Test GetCustomerById
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetCustomerByIdAsyncTest()
        {
            long id = default!;
            var response = await _instance.GetCustomerByIdAsync(id);
            var model = response.Ok();
            Assert.IsType<CustomerDto>(model);
        }
    }
}

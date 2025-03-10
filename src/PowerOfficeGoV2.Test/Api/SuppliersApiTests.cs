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
    ///  Class for testing SuppliersApi
    /// </summary>
    public sealed class SuppliersApiTests : ApiTestsBase
    {
        private readonly ISuppliersApi _instance;

        public SuppliersApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<ISuppliersApi>();
        }

        /// <summary>
        /// Test GetSupplierById
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetSupplierByIdAsyncTest()
        {
            long id = default!;
            var response = await _instance.GetSupplierByIdAsync(id);
            var model = response.Ok();
            Assert.IsType<SupplierDto>(model);
        }

        /// <summary>
        /// Test SuppliersGet
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task SuppliersGetAsyncTest()
        {
            Client.Option<string> contactGroupIds = default!;
            Client.Option<string> externalImportReference = default!;
            Client.Option<string> externalNos = default!;
            Client.Option<DateTime> lastChangedDateTimeOffsetGreaterThan = default!;
            Client.Option<DateTime> supplierCreatedDateTimeOffsetGreaterThan = default!;
            Client.Option<string> supplierNos = default!;
            Client.Option<ResourceParameters> resourceParameter = default!;
            var response = await _instance.SuppliersGetAsync(contactGroupIds, externalImportReference, externalNos, lastChangedDateTimeOffsetGreaterThan, supplierCreatedDateTimeOffsetGreaterThan, supplierNos, resourceParameter);
            var model = response.Ok();
            Assert.IsType<List<SupplierDto>>(model);
        }

        /// <summary>
        /// Test SuppliersIdDelete
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task SuppliersIdDeleteAsyncTest()
        {
            long id = default!;
            await _instance.SuppliersIdDeleteAsync(id);
        }

        /// <summary>
        /// Test SuppliersIdPatch
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task SuppliersIdPatchAsyncTest()
        {
            long id = default!;
            Client.Option<List<Operation>> operation = default!;
            var response = await _instance.SuppliersIdPatchAsync(id, operation);
            var model = response.Ok();
            Assert.IsType<SupplierDto>(model);
        }

        /// <summary>
        /// Test SuppliersPost
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task SuppliersPostAsyncTest()
        {
            Client.Option<SupplierPostDto> supplierPostDto = default!;
            var response = await _instance.SuppliersPostAsync(supplierPostDto);
            var model = response.Created();
            Assert.IsType<SupplierDto>(model);
        }
    }
}

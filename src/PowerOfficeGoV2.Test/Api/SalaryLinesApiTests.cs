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
    ///  Class for testing SalaryLinesApi
    /// </summary>
    public sealed class SalaryLinesApiTests : ApiTestsBase
    {
        private readonly ISalaryLinesApi _instance;

        public SalaryLinesApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<ISalaryLinesApi>();
        }

        /// <summary>
        /// Test GetSalaryLineById
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetSalaryLineByIdAsyncTest()
        {
            long id = default!;
            var response = await _instance.GetSalaryLineByIdAsync(id);
            var model = response.Ok();
            Assert.IsType<SalaryLineDto>(model);
        }

        /// <summary>
        /// Test SalaryLinesGet
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task SalaryLinesGetAsyncTest()
        {
            Client.Option<ResourceParameters> resourceParameter = default!;
            var response = await _instance.SalaryLinesGetAsync(resourceParameter);
            var model = response.Ok();
            Assert.IsType<List<SalaryLineDto>>(model);
        }

        /// <summary>
        /// Test SalaryLinesIdDelete
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task SalaryLinesIdDeleteAsyncTest()
        {
            long id = default!;
            await _instance.SalaryLinesIdDeleteAsync(id);
        }

        /// <summary>
        /// Test SalaryLinesIdPatch
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task SalaryLinesIdPatchAsyncTest()
        {
            long id = default!;
            Client.Option<List<Operation>> operation = default!;
            var response = await _instance.SalaryLinesIdPatchAsync(id, operation);
            var model = response.Ok();
            Assert.IsType<SalaryLineDto>(model);
        }

        /// <summary>
        /// Test SalaryLinesPost
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task SalaryLinesPostAsyncTest()
        {
            Client.Option<SalaryLinePostDto> salaryLinePostDto = default!;
            var response = await _instance.SalaryLinesPostAsync(salaryLinePostDto);
            var model = response.Created();
            Assert.IsType<SalaryLineDto>(model);
        }
    }
}

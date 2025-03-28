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
    ///  Class for testing EmployeeHourlyRatesApi
    /// </summary>
    public sealed class EmployeeHourlyRatesApiTests : ApiTestsBase
    {
        private readonly IEmployeeHourlyRatesApi _instance;

        public EmployeeHourlyRatesApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<IEmployeeHourlyRatesApi>();
        }

        /// <summary>
        /// Test EmployeesEmployeeIdHourlyRatesGet
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task EmployeesEmployeeIdHourlyRatesGetAsyncTest()
        {
            long employeeId = default!;
            Client.Option<bool> validNow = default!;
            Client.Option<ResourceParameters> resourceParameter = default!;
            var response = await _instance.EmployeesEmployeeIdHourlyRatesGetAsync(employeeId, validNow, resourceParameter);
            var model = response.Ok();
            Assert.IsType<List<EmployeeHourlyRateDto>>(model);
        }

        /// <summary>
        /// Test EmployeesEmployeeIdHourlyRatesHourlyRateIdDelete
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task EmployeesEmployeeIdHourlyRatesHourlyRateIdDeleteAsyncTest()
        {
            long employeeId = default!;
            long hourlyRateId = default!;
            await _instance.EmployeesEmployeeIdHourlyRatesHourlyRateIdDeleteAsync(employeeId, hourlyRateId);
        }

        /// <summary>
        /// Test EmployeesEmployeeIdHourlyRatesHourlyRateIdPatch
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task EmployeesEmployeeIdHourlyRatesHourlyRateIdPatchAsyncTest()
        {
            long employeeId = default!;
            long hourlyRateId = default!;
            Client.Option<List<Operation>> operation = default!;
            var response = await _instance.EmployeesEmployeeIdHourlyRatesHourlyRateIdPatchAsync(employeeId, hourlyRateId, operation);
            var model = response.Ok();
            Assert.IsType<EmployeeHourlyRateDto>(model);
        }

        /// <summary>
        /// Test EmployeesEmployeeIdHourlyRatesPost
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task EmployeesEmployeeIdHourlyRatesPostAsyncTest()
        {
            long employeeId = default!;
            Client.Option<EmployeeHourlyRatePostDto> employeeHourlyRatePostDto = default!;
            var response = await _instance.EmployeesEmployeeIdHourlyRatesPostAsync(employeeId, employeeHourlyRatePostDto);
            var model = response.Created();
            Assert.IsType<EmployeeHourlyRateDto>(model);
        }

        /// <summary>
        /// Test GetHourlyRateById
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetHourlyRateByIdAsyncTest()
        {
            long employeeId = default!;
            long hourlyRateId = default!;
            var response = await _instance.GetHourlyRateByIdAsync(employeeId, hourlyRateId);
            var model = response.Ok();
            Assert.IsType<EmployeeHourlyRateDto>(model);
        }
    }
}

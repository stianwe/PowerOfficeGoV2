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
    ///  Class for testing LocationsApi
    /// </summary>
    public sealed class LocationsApiTests : ApiTestsBase
    {
        private readonly ILocationsApi _instance;

        public LocationsApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<ILocationsApi>();
        }

        /// <summary>
        /// Test GetLocationById
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetLocationByIdAsyncTest()
        {
            long id = default!;
            var response = await _instance.GetLocationByIdAsync(id);
            var model = response.Ok();
            Assert.IsType<LocationDto>(model);
        }

        /// <summary>
        /// Test GetLocations
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetLocationsAsyncTest()
        {
            Client.Option<DateTimeOffset> createdDateTimeOffsetGreaterThan = default!;
            Client.Option<string> codes = default!;
            Client.Option<ResourceParameters> resourceParameter = default!;
            var response = await _instance.GetLocationsAsync(createdDateTimeOffsetGreaterThan, codes, resourceParameter);
            var model = response.Ok();
            Assert.IsType<List<LocationDto>>(model);
        }

        /// <summary>
        /// Test LocationsIdDelete
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task LocationsIdDeleteAsyncTest()
        {
            long id = default!;
            await _instance.LocationsIdDeleteAsync(id);
        }

        /// <summary>
        /// Test LocationsIdPatch
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task LocationsIdPatchAsyncTest()
        {
            long id = default!;
            Client.Option<List<Operation>> operation = default!;
            var response = await _instance.LocationsIdPatchAsync(id, operation);
            var model = response.Ok();
            Assert.IsType<LocationDto>(model);
        }

        /// <summary>
        /// Test LocationsPost
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task LocationsPostAsyncTest()
        {
            Client.Option<LocationPostDto> locationPostDto = default!;
            var response = await _instance.LocationsPostAsync(locationPostDto);
            var model = response.Ok();
            Assert.IsType<LocationDto>(model);
        }
    }
}

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
    ///  Class for testing BrandingThemesApi
    /// </summary>
    public sealed class BrandingThemesApiTests : ApiTestsBase
    {
        private readonly IBrandingThemesApi _instance;

        public BrandingThemesApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<IBrandingThemesApi>();
        }

        /// <summary>
        /// Test BrandingThemesGet
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task BrandingThemesGetAsyncTest()
        {
            Client.Option<ResourceParameters> resourceParameter = default!;
            var response = await _instance.BrandingThemesGetAsync(resourceParameter);
            var model = response.Ok();
            Assert.IsType<List<BrandingThemeDto>>(model);
        }

        /// <summary>
        /// Test GetBrandingThemeById
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetBrandingThemeByIdAsyncTest()
        {
            long id = default!;
            var response = await _instance.GetBrandingThemeByIdAsync(id);
            var model = response.Ok();
            Assert.IsType<BrandingThemeDto>(model);
        }
    }
}

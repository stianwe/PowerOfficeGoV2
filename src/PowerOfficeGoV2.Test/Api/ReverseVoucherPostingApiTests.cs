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
    ///  Class for testing ReverseVoucherPostingApi
    /// </summary>
    public sealed class ReverseVoucherPostingApiTests : ApiTestsBase
    {
        private readonly IReverseVoucherPostingApi _instance;

        public ReverseVoucherPostingApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<IReverseVoucherPostingApi>();
        }

        /// <summary>
        /// Test PostVoucherReversal
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task PostVoucherReversalAsyncTest()
        {
            Guid id = default!;
            await _instance.PostVoucherReversalAsync(id);
        }
    }
}

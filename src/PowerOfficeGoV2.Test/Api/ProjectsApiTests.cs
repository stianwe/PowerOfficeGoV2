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
    ///  Class for testing ProjectsApi
    /// </summary>
    public sealed class ProjectsApiTests : ApiTestsBase
    {
        private readonly IProjectsApi _instance;

        public ProjectsApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<IProjectsApi>();
        }

        /// <summary>
        /// Test GetProjectById
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetProjectByIdAsyncTest()
        {
            long id = default!;
            var response = await _instance.GetProjectByIdAsync(id);
            var model = response.Ok();
            Assert.IsType<ProjectDto>(model);
        }

        /// <summary>
        /// Test GetProjects
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetProjectsAsyncTest()
        {
            Client.Option<DateTimeOffset> createdDateTimeOffsetGreaterThan = default!;
            Client.Option<string> customerNos = default!;
            Client.Option<string> departmentCodes = default!;
            Client.Option<bool> excludeArchivedProject = default!;
            Client.Option<bool> includeSubProjects = default!;
            Client.Option<DateTimeOffset> lastChangedDateTimeOffsetGreaterThan = default!;
            Client.Option<string> name = default!;
            Client.Option<ProjectBillingMethod> projectBillingMethod = default!;
            Client.Option<string> projectCodes = default!;
            Client.Option<string> projectManagerEmployeeNos = default!;
            Client.Option<ProjectStatusType> status = default!;
            Client.Option<ResourceParameters> resourceParameter = default!;
            var response = await _instance.GetProjectsAsync(createdDateTimeOffsetGreaterThan, customerNos, departmentCodes, excludeArchivedProject, includeSubProjects, lastChangedDateTimeOffsetGreaterThan, name, projectBillingMethod, projectCodes, projectManagerEmployeeNos, status, resourceParameter);
            var model = response.Ok();
            Assert.IsType<List<ProjectDto>>(model);
        }

        /// <summary>
        /// Test ProjectsIdDelete
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task ProjectsIdDeleteAsyncTest()
        {
            long id = default!;
            await _instance.ProjectsIdDeleteAsync(id);
        }

        /// <summary>
        /// Test ProjectsIdPatch
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task ProjectsIdPatchAsyncTest()
        {
            long id = default!;
            Client.Option<List<Operation>> operation = default!;
            await _instance.ProjectsIdPatchAsync(id, operation);
        }

        /// <summary>
        /// Test ProjectsPost
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task ProjectsPostAsyncTest()
        {
            Client.Option<ProjectPostDto> projectPostDto = default!;
            var response = await _instance.ProjectsPostAsync(projectPostDto);
            var model = response.Created();
            Assert.IsType<ProjectDto>(model);
        }
    }
}

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using UnityCloudBuildApi.IO.Swagger.Client;
using UnityCloudBuildApi.IO.Swagger.Model;
using static UnityCloudBuildApi.Encode;

namespace UnityCloudBuildApi.IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBuildsApi
    {
        
        /// <summary>
        /// Get audit log
        /// </summary>
        /// <remarks>
        /// Retrieve a list of historical settings changes for this build target.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="perPage">Number of audit log records to retrieve</param>
        /// <param name="page">Skip to page number, based on per_page value</param>
        /// <returns>List&lt;InlineResponse2002&gt;</returns>
        List<InlineResponse2002> GetAuditLog (string orgid, string projectid, string buildtargetid, double? perPage = null, double? page = null);
  
        /// <summary>
        /// Get audit log
        /// </summary>
        /// <remarks>
        /// Retrieve a list of historical settings changes for this build target.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="perPage">Number of audit log records to retrieve</param>
        /// <param name="page">Skip to page number, based on per_page value</param>
        /// <returns>ApiResponse of List&lt;InlineResponse2002&gt;</returns>
        ApiResponse<List<InlineResponse2002>> GetAuditLogWithHttpInfo (string orgid, string projectid, string buildtargetid, double? perPage = null, double? page = null);

        /// <summary>
        /// Get audit log
        /// </summary>
        /// <remarks>
        /// Retrieve a list of historical settings changes for this build target.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="perPage">Number of audit log records to retrieve</param>
        /// <param name="page">Skip to page number, based on per_page value</param>
        /// <returns>Task of List&lt;InlineResponse2002&gt;</returns>
        System.Threading.Tasks.Task<List<InlineResponse2002>> GetAuditLogAsync (string orgid, string projectid, string buildtargetid, double? perPage = null, double? page = null);

        /// <summary>
        /// Get audit log
        /// </summary>
        /// <remarks>
        /// Retrieve a list of historical settings changes for this build target.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="perPage">Number of audit log records to retrieve</param>
        /// <param name="page">Skip to page number, based on per_page value</param>
        /// <returns>Task of ApiResponse (List&lt;InlineResponse2002&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<InlineResponse2002>>> GetAuditLogAsyncWithHttpInfo (string orgid, string projectid, string buildtargetid, double? perPage = null, double? page = null);
        
        /// <summary>
        /// List all builds
        /// </summary>
        /// <remarks>
        /// List all running and finished builds, sorted by build number\n(optionally paginating the results). Use &#39;_all&#39; as the buildtargetid\nto get all configured build targets. The response includes a Content-Range\nheader that identifies the range of results returned and the total number\nof results matching the given query parameters.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="include">Extra fields to include in the response</param>
        /// <param name="perPage">Number of audit log records to retrieve</param>
        /// <param name="page">Skip to page number, based on per_page value</param>
        /// <param name="buildStatus">Query for only builds of a specific status</param>
        /// <param name="platform">Query for only builds of a specific platform</param>
        /// <returns>List&lt;OrgsorgidprojectsprojectidbuildtargetsBuilds&gt;</returns>
        List<OrgsorgidprojectsprojectidbuildtargetsBuilds> GetBuilds (string orgid, string projectid, string buildtargetid, string include = null, double? perPage = null, double? page = null, string buildStatus = null, string platform = null);
  
        /// <summary>
        /// List all builds
        /// </summary>
        /// <remarks>
        /// List all running and finished builds, sorted by build number\n(optionally paginating the results). Use &#39;_all&#39; as the buildtargetid\nto get all configured build targets. The response includes a Content-Range\nheader that identifies the range of results returned and the total number\nof results matching the given query parameters.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="include">Extra fields to include in the response</param>
        /// <param name="perPage">Number of audit log records to retrieve</param>
        /// <param name="page">Skip to page number, based on per_page value</param>
        /// <param name="buildStatus">Query for only builds of a specific status</param>
        /// <param name="platform">Query for only builds of a specific platform</param>
        /// <returns>ApiResponse of List&lt;OrgsorgidprojectsprojectidbuildtargetsBuilds&gt;</returns>
        ApiResponse<List<OrgsorgidprojectsprojectidbuildtargetsBuilds>> GetBuildsWithHttpInfo (string orgid, string projectid, string buildtargetid, string include = null, double? perPage = null, double? page = null, string buildStatus = null, string platform = null);

        /// <summary>
        /// List all builds
        /// </summary>
        /// <remarks>
        /// List all running and finished builds, sorted by build number\n(optionally paginating the results). Use &#39;_all&#39; as the buildtargetid\nto get all configured build targets. The response includes a Content-Range\nheader that identifies the range of results returned and the total number\nof results matching the given query parameters.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="include">Extra fields to include in the response</param>
        /// <param name="perPage">Number of audit log records to retrieve</param>
        /// <param name="page">Skip to page number, based on per_page value</param>
        /// <param name="buildStatus">Query for only builds of a specific status</param>
        /// <param name="platform">Query for only builds of a specific platform</param>
        /// <returns>Task of List&lt;OrgsorgidprojectsprojectidbuildtargetsBuilds&gt;</returns>
        System.Threading.Tasks.Task<List<OrgsorgidprojectsprojectidbuildtargetsBuilds>> GetBuildsAsync (string orgid, string projectid, string buildtargetid, string include = null, double? perPage = null, double? page = null, string buildStatus = null, string platform = null);

        /// <summary>
        /// List all builds
        /// </summary>
        /// <remarks>
        /// List all running and finished builds, sorted by build number\n(optionally paginating the results). Use &#39;_all&#39; as the buildtargetid\nto get all configured build targets. The response includes a Content-Range\nheader that identifies the range of results returned and the total number\nof results matching the given query parameters.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="include">Extra fields to include in the response</param>
        /// <param name="perPage">Number of audit log records to retrieve</param>
        /// <param name="page">Skip to page number, based on per_page value</param>
        /// <param name="buildStatus">Query for only builds of a specific status</param>
        /// <param name="platform">Query for only builds of a specific platform</param>
        /// <returns>Task of ApiResponse (List&lt;OrgsorgidprojectsprojectidbuildtargetsBuilds&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<OrgsorgidprojectsprojectidbuildtargetsBuilds>>> GetBuildsAsyncWithHttpInfo (string orgid, string projectid, string buildtargetid, string include = null, double? perPage = null, double? page = null, string buildStatus = null, string platform = null);
        
        /// <summary>
        /// Create new build
        /// </summary>
        /// <remarks>
        /// Start the build process for this build target (or all targets,\nif &#39;_all&#39; is specified as the buildtargetid), if there is not one\ncurrently in process.\n\nIf a build is currently in process that information will be related\nin the &#39;error&#39; field.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="options">Options for starting the builds</param>
        /// <returns>List&lt;OrgsorgidprojectsprojectidbuildtargetsBuilds&gt;</returns>
        List<OrgsorgidprojectsprojectidbuildtargetsBuilds> StartBuilds (string orgid, string projectid, string buildtargetid, Options4 options = null);
  
        /// <summary>
        /// Create new build
        /// </summary>
        /// <remarks>
        /// Start the build process for this build target (or all targets,\nif &#39;_all&#39; is specified as the buildtargetid), if there is not one\ncurrently in process.\n\nIf a build is currently in process that information will be related\nin the &#39;error&#39; field.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="options">Options for starting the builds</param>
        /// <returns>ApiResponse of List&lt;OrgsorgidprojectsprojectidbuildtargetsBuilds&gt;</returns>
        ApiResponse<List<OrgsorgidprojectsprojectidbuildtargetsBuilds>> StartBuildsWithHttpInfo (string orgid, string projectid, string buildtargetid, Options4 options = null);

        /// <summary>
        /// Create new build
        /// </summary>
        /// <remarks>
        /// Start the build process for this build target (or all targets,\nif &#39;_all&#39; is specified as the buildtargetid), if there is not one\ncurrently in process.\n\nIf a build is currently in process that information will be related\nin the &#39;error&#39; field.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="options">Options for starting the builds</param>
        /// <returns>Task of List&lt;OrgsorgidprojectsprojectidbuildtargetsBuilds&gt;</returns>
        System.Threading.Tasks.Task<List<OrgsorgidprojectsprojectidbuildtargetsBuilds>> StartBuildsAsync (string orgid, string projectid, string buildtargetid, Options4 options = null);

        /// <summary>
        /// Create new build
        /// </summary>
        /// <remarks>
        /// Start the build process for this build target (or all targets,\nif &#39;_all&#39; is specified as the buildtargetid), if there is not one\ncurrently in process.\n\nIf a build is currently in process that information will be related\nin the &#39;error&#39; field.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="options">Options for starting the builds</param>
        /// <returns>Task of ApiResponse (List&lt;OrgsorgidprojectsprojectidbuildtargetsBuilds&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<OrgsorgidprojectsprojectidbuildtargetsBuilds>>> StartBuildsAsyncWithHttpInfo (string orgid, string projectid, string buildtargetid, Options4 options = null);
        
        /// <summary>
        /// Cancel all builds
        /// </summary>
        /// <remarks>
        /// Cancel all builds in progress for this build target (or all targets,\nif &#39;_all&#39; is specified as the buildtargetid). Canceling an already\nfinished build will do nothing and respond successfully.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <returns>string</returns>
        string CancelAllBuilds (string orgid, string projectid, string buildtargetid);
  
        /// <summary>
        /// Cancel all builds
        /// </summary>
        /// <remarks>
        /// Cancel all builds in progress for this build target (or all targets,\nif &#39;_all&#39; is specified as the buildtargetid). Canceling an already\nfinished build will do nothing and respond successfully.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> CancelAllBuildsWithHttpInfo (string orgid, string projectid, string buildtargetid);

        /// <summary>
        /// Cancel all builds
        /// </summary>
        /// <remarks>
        /// Cancel all builds in progress for this build target (or all targets,\nif &#39;_all&#39; is specified as the buildtargetid). Canceling an already\nfinished build will do nothing and respond successfully.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> CancelAllBuildsAsync (string orgid, string projectid, string buildtargetid);

        /// <summary>
        /// Cancel all builds
        /// </summary>
        /// <remarks>
        /// Cancel all builds in progress for this build target (or all targets,\nif &#39;_all&#39; is specified as the buildtargetid). Canceling an already\nfinished build will do nothing and respond successfully.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> CancelAllBuildsAsyncWithHttpInfo (string orgid, string projectid, string buildtargetid);
        
        /// <summary>
        /// Build Status
        /// </summary>
        /// <remarks>
        /// Retrieve information for a specific build. A Build resource contains\ninformation related to a build attempt for a build target, including\nthe build number, changeset, build times, and other pertinent data.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <param name="include">Extra fields to include in the response</param>
        /// <returns>OrgsorgidprojectsprojectidbuildtargetsBuilds</returns>
        OrgsorgidprojectsprojectidbuildtargetsBuilds GetBuild (string orgid, string projectid, string buildtargetid, string number, string include = null);
  
        /// <summary>
        /// Build Status
        /// </summary>
        /// <remarks>
        /// Retrieve information for a specific build. A Build resource contains\ninformation related to a build attempt for a build target, including\nthe build number, changeset, build times, and other pertinent data.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <param name="include">Extra fields to include in the response</param>
        /// <returns>ApiResponse of OrgsorgidprojectsprojectidbuildtargetsBuilds</returns>
        ApiResponse<OrgsorgidprojectsprojectidbuildtargetsBuilds> GetBuildWithHttpInfo (string orgid, string projectid, string buildtargetid, string number, string include = null);

        /// <summary>
        /// Build Status
        /// </summary>
        /// <remarks>
        /// Retrieve information for a specific build. A Build resource contains\ninformation related to a build attempt for a build target, including\nthe build number, changeset, build times, and other pertinent data.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <param name="include">Extra fields to include in the response</param>
        /// <returns>Task of OrgsorgidprojectsprojectidbuildtargetsBuilds</returns>
        System.Threading.Tasks.Task<OrgsorgidprojectsprojectidbuildtargetsBuilds> GetBuildAsync (string orgid, string projectid, string buildtargetid, string number, string include = null);

        /// <summary>
        /// Build Status
        /// </summary>
        /// <remarks>
        /// Retrieve information for a specific build. A Build resource contains\ninformation related to a build attempt for a build target, including\nthe build number, changeset, build times, and other pertinent data.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <param name="include">Extra fields to include in the response</param>
        /// <returns>Task of ApiResponse (OrgsorgidprojectsprojectidbuildtargetsBuilds)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrgsorgidprojectsprojectidbuildtargetsBuilds>> GetBuildAsyncWithHttpInfo (string orgid, string projectid, string buildtargetid, string number, string include = null);
        
        /// <summary>
        /// Cancel build
        /// </summary>
        /// <remarks>
        /// Cancel a build in progress. Canceling an already finished build\nwill do nothing and respond successfully.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <returns>string</returns>
        string CancelBuild (string orgid, string projectid, string buildtargetid, string number);
  
        /// <summary>
        /// Cancel build
        /// </summary>
        /// <remarks>
        /// Cancel a build in progress. Canceling an already finished build\nwill do nothing and respond successfully.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> CancelBuildWithHttpInfo (string orgid, string projectid, string buildtargetid, string number);

        /// <summary>
        /// Cancel build
        /// </summary>
        /// <remarks>
        /// Cancel a build in progress. Canceling an already finished build\nwill do nothing and respond successfully.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> CancelBuildAsync (string orgid, string projectid, string buildtargetid, string number);

        /// <summary>
        /// Cancel build
        /// </summary>
        /// <remarks>
        /// Cancel a build in progress. Canceling an already finished build\nwill do nothing and respond successfully.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> CancelBuildAsyncWithHttpInfo (string orgid, string projectid, string buildtargetid, string number);
        
        /// <summary>
        /// Get audit log
        /// </summary>
        /// <remarks>
        /// Retrieve a list of settings changes between the last and current build.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <param name="perPage">Number of audit log records to retrieve</param>
        /// <param name="page">Skip to page number, based on per_page value</param>
        /// <returns>List&lt;InlineResponse2002&gt;</returns>
        List<InlineResponse2002> GetAuditLog_0 (string orgid, string projectid, string buildtargetid, string number, double? perPage = null, double? page = null);
  
        /// <summary>
        /// Get audit log
        /// </summary>
        /// <remarks>
        /// Retrieve a list of settings changes between the last and current build.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <param name="perPage">Number of audit log records to retrieve</param>
        /// <param name="page">Skip to page number, based on per_page value</param>
        /// <returns>ApiResponse of List&lt;InlineResponse2002&gt;</returns>
        ApiResponse<List<InlineResponse2002>> GetAuditLog_0WithHttpInfo (string orgid, string projectid, string buildtargetid, string number, double? perPage = null, double? page = null);

        /// <summary>
        /// Get audit log
        /// </summary>
        /// <remarks>
        /// Retrieve a list of settings changes between the last and current build.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <param name="perPage">Number of audit log records to retrieve</param>
        /// <param name="page">Skip to page number, based on per_page value</param>
        /// <returns>Task of List&lt;InlineResponse2002&gt;</returns>
        System.Threading.Tasks.Task<List<InlineResponse2002>> GetAuditLog_0Async (string orgid, string projectid, string buildtargetid, string number, double? perPage = null, double? page = null);

        /// <summary>
        /// Get audit log
        /// </summary>
        /// <remarks>
        /// Retrieve a list of settings changes between the last and current build.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <param name="perPage">Number of audit log records to retrieve</param>
        /// <param name="page">Skip to page number, based on per_page value</param>
        /// <returns>Task of ApiResponse (List&lt;InlineResponse2002&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<InlineResponse2002>>> GetAuditLog_0AsyncWithHttpInfo (string orgid, string projectid, string buildtargetid, string number, double? perPage = null, double? page = null);
        
        /// <summary>
        /// Get build log
        /// </summary>
        /// <remarks>
        /// Retrieve the plain text log for a specifc build.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <param name="offsetlines">Stream log from the given line number</param>
        /// <param name="linenumbers">Include log line numbers in the text output</param>
        /// <param name="compact">Return the compact log, showing only errors and warnings</param>
        /// <param name="withHtml">Surround important lines (errors, warnings) with SPAN and CSS markup</param>
        /// <returns></returns>
        void GetBuildLog (string orgid, string projectid, string buildtargetid, string number, double? offsetlines = null, bool? linenumbers = null, bool? compact = null, bool? withHtml = null);
  
        /// <summary>
        /// Get build log
        /// </summary>
        /// <remarks>
        /// Retrieve the plain text log for a specifc build.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <param name="offsetlines">Stream log from the given line number</param>
        /// <param name="linenumbers">Include log line numbers in the text output</param>
        /// <param name="compact">Return the compact log, showing only errors and warnings</param>
        /// <param name="withHtml">Surround important lines (errors, warnings) with SPAN and CSS markup</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetBuildLogWithHttpInfo (string orgid, string projectid, string buildtargetid, string number, double? offsetlines = null, bool? linenumbers = null, bool? compact = null, bool? withHtml = null);

        /// <summary>
        /// Get build log
        /// </summary>
        /// <remarks>
        /// Retrieve the plain text log for a specifc build.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <param name="offsetlines">Stream log from the given line number</param>
        /// <param name="linenumbers">Include log line numbers in the text output</param>
        /// <param name="compact">Return the compact log, showing only errors and warnings</param>
        /// <param name="withHtml">Surround important lines (errors, warnings) with SPAN and CSS markup</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetBuildLogAsync (string orgid, string projectid, string buildtargetid, string number, double? offsetlines = null, bool? linenumbers = null, bool? compact = null, bool? withHtml = null);

        /// <summary>
        /// Get build log
        /// </summary>
        /// <remarks>
        /// Retrieve the plain text log for a specifc build.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <param name="offsetlines">Stream log from the given line number</param>
        /// <param name="linenumbers">Include log line numbers in the text output</param>
        /// <param name="compact">Return the compact log, showing only errors and warnings</param>
        /// <param name="withHtml">Surround important lines (errors, warnings) with SPAN and CSS markup</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetBuildLogAsyncWithHttpInfo (string orgid, string projectid, string buildtargetid, string number, double? offsetlines = null, bool? linenumbers = null, bool? compact = null, bool? withHtml = null);
        
        /// <summary>
        /// Get the share link
        /// </summary>
        /// <remarks>
        /// Gets a share link if it exists
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <returns>InlineResponse2004</returns>
        InlineResponse2004 GetShare (string orgid, string projectid, string buildtargetid, string number);
  
        /// <summary>
        /// Get the share link
        /// </summary>
        /// <remarks>
        /// Gets a share link if it exists
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <returns>ApiResponse of InlineResponse2004</returns>
        ApiResponse<InlineResponse2004> GetShareWithHttpInfo (string orgid, string projectid, string buildtargetid, string number);

        /// <summary>
        /// Get the share link
        /// </summary>
        /// <remarks>
        /// Gets a share link if it exists
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <returns>Task of InlineResponse2004</returns>
        System.Threading.Tasks.Task<InlineResponse2004> GetShareAsync (string orgid, string projectid, string buildtargetid, string number);

        /// <summary>
        /// Get the share link
        /// </summary>
        /// <remarks>
        /// Gets a share link if it exists
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <returns>Task of ApiResponse (InlineResponse2004)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2004>> GetShareAsyncWithHttpInfo (string orgid, string projectid, string buildtargetid, string number);
        
        /// <summary>
        /// Create a new link to share a project
        /// </summary>
        /// <remarks>
        /// Create a new short link to share a project. If this is called when a share already exists, that share\nwill be revoked and a new one created.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <returns>InlineResponse2004</returns>
        InlineResponse2004 CreateShare (string orgid, string projectid, string buildtargetid, string number);
  
        /// <summary>
        /// Create a new link to share a project
        /// </summary>
        /// <remarks>
        /// Create a new short link to share a project. If this is called when a share already exists, that share\nwill be revoked and a new one created.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <returns>ApiResponse of InlineResponse2004</returns>
        ApiResponse<InlineResponse2004> CreateShareWithHttpInfo (string orgid, string projectid, string buildtargetid, string number);

        /// <summary>
        /// Create a new link to share a project
        /// </summary>
        /// <remarks>
        /// Create a new short link to share a project. If this is called when a share already exists, that share\nwill be revoked and a new one created.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <returns>Task of InlineResponse2004</returns>
        System.Threading.Tasks.Task<InlineResponse2004> CreateShareAsync (string orgid, string projectid, string buildtargetid, string number);

        /// <summary>
        /// Create a new link to share a project
        /// </summary>
        /// <remarks>
        /// Create a new short link to share a project. If this is called when a share already exists, that share\nwill be revoked and a new one created.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <returns>Task of ApiResponse (InlineResponse2004)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2004>> CreateShareAsyncWithHttpInfo (string orgid, string projectid, string buildtargetid, string number);
        
        /// <summary>
        /// Revoke a shared link
        /// </summary>
        /// <remarks>
        /// Revoke a shared link, both {buildtargetid} and {number} may use _all to revoke all share links for a given buildtarget or entire project.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <returns>string</returns>
        string RevokeShare (string orgid, string projectid, string buildtargetid, string number);
  
        /// <summary>
        /// Revoke a shared link
        /// </summary>
        /// <remarks>
        /// Revoke a shared link, both {buildtargetid} and {number} may use _all to revoke all share links for a given buildtarget or entire project.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> RevokeShareWithHttpInfo (string orgid, string projectid, string buildtargetid, string number);

        /// <summary>
        /// Revoke a shared link
        /// </summary>
        /// <remarks>
        /// Revoke a shared link, both {buildtargetid} and {number} may use _all to revoke all share links for a given buildtarget or entire project.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> RevokeShareAsync (string orgid, string projectid, string buildtargetid, string number);

        /// <summary>
        /// Revoke a shared link
        /// </summary>
        /// <remarks>
        /// Revoke a shared link, both {buildtargetid} and {number} may use _all to revoke all share links for a given buildtarget or entire project.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> RevokeShareAsyncWithHttpInfo (string orgid, string projectid, string buildtargetid, string number);
        
        /// <summary>
        /// Create polling jobs
        /// </summary>
        /// <remarks>
        /// Create polling jobs for the specified buildtargetid (or all targets,\nif &#39;_all&#39; is specified as the buildtargetid). New builds will be\nsubsequently triggered for any build targets with changes detected.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <returns>InlineResponse202</returns>
        InlineResponse202 CreatePollingJobs (string orgid, string projectid, string buildtargetid);
  
        /// <summary>
        /// Create polling jobs
        /// </summary>
        /// <remarks>
        /// Create polling jobs for the specified buildtargetid (or all targets,\nif &#39;_all&#39; is specified as the buildtargetid). New builds will be\nsubsequently triggered for any build targets with changes detected.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <returns>ApiResponse of InlineResponse202</returns>
        ApiResponse<InlineResponse202> CreatePollingJobsWithHttpInfo (string orgid, string projectid, string buildtargetid);

        /// <summary>
        /// Create polling jobs
        /// </summary>
        /// <remarks>
        /// Create polling jobs for the specified buildtargetid (or all targets,\nif &#39;_all&#39; is specified as the buildtargetid). New builds will be\nsubsequently triggered for any build targets with changes detected.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <returns>Task of InlineResponse202</returns>
        System.Threading.Tasks.Task<InlineResponse202> CreatePollingJobsAsync (string orgid, string projectid, string buildtargetid);

        /// <summary>
        /// Create polling jobs
        /// </summary>
        /// <remarks>
        /// Create polling jobs for the specified buildtargetid (or all targets,\nif &#39;_all&#39; is specified as the buildtargetid). New builds will be\nsubsequently triggered for any build targets with changes detected.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <returns>Task of ApiResponse (InlineResponse202)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse202>> CreatePollingJobsAsyncWithHttpInfo (string orgid, string projectid, string buildtargetid);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BuildsApi : IBuildsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BuildsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BuildsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }
    
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }
   
        
        /// <summary>
        /// Get audit log Retrieve a list of historical settings changes for this build target.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param> 
        /// <param name="perPage">Number of audit log records to retrieve</param> 
        /// <param name="page">Skip to page number, based on per_page value</param> 
        /// <returns>List&lt;InlineResponse2002&gt;</returns>
        public List<InlineResponse2002> GetAuditLog (string orgid, string projectid, string buildtargetid, double? perPage = null, double? page = null)
        {
             ApiResponse<List<InlineResponse2002>> response = GetAuditLogWithHttpInfo(orgid, projectid, buildtargetid, perPage, page);
             return response.Data;
        }

        /// <summary>
        /// Get audit log Retrieve a list of historical settings changes for this build target.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param> 
        /// <param name="perPage">Number of audit log records to retrieve</param> 
        /// <param name="page">Skip to page number, based on per_page value</param> 
        /// <returns>ApiResponse of List&lt;InlineResponse2002&gt;</returns>
        public ApiResponse< List<InlineResponse2002> > GetAuditLogWithHttpInfo (string orgid, string projectid, string buildtargetid, double? perPage = null, double? page = null)
        {
            
            // verify the required parameter 'orgid' is set
            if (orgid == null)
                throw new ApiException(400, "Missing required parameter 'orgid' when calling BuildsApi->GetAuditLog");
            
            // verify the required parameter 'projectid' is set
            if (projectid == null)
                throw new ApiException(400, "Missing required parameter 'projectid' when calling BuildsApi->GetAuditLog");
            
            // verify the required parameter 'buildtargetid' is set
            if (buildtargetid == null)
                throw new ApiException(400, "Missing required parameter 'buildtargetid' when calling BuildsApi->GetAuditLog");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/buildtargets/{buildtargetid}/auditlog";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/plain", "text/html"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (orgid != null) pathParams.Add("orgid", Configuration.ApiClient.ParameterToString(orgid)); // path parameter
            if (projectid != null) pathParams.Add("projectid", Configuration.ApiClient.ParameterToString(projectid)); // path parameter
            if (buildtargetid != null) pathParams.Add("buildtargetid", Configuration.ApiClient.ParameterToString(buildtargetid)); // path parameter
            
            if (perPage != null) queryParams.Add("per_page", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            if (page != null) queryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            
            
            
            

            // authentication (apikey) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            // authentication (permissions) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetAuditLog: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetAuditLog: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<InlineResponse2002>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InlineResponse2002>) Configuration.ApiClient.Deserialize(response, typeof(List<InlineResponse2002>)));
            
        }
    
        /// <summary>
        /// Get audit log Retrieve a list of historical settings changes for this build target.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="perPage">Number of audit log records to retrieve</param>
        /// <param name="page">Skip to page number, based on per_page value</param>
        /// <returns>Task of List&lt;InlineResponse2002&gt;</returns>
        public async System.Threading.Tasks.Task<List<InlineResponse2002>> GetAuditLogAsync (string orgid, string projectid, string buildtargetid, double? perPage = null, double? page = null)
        {
             ApiResponse<List<InlineResponse2002>> response = await GetAuditLogAsyncWithHttpInfo(orgid, projectid, buildtargetid, perPage, page);
             return response.Data;

        }

        /// <summary>
        /// Get audit log Retrieve a list of historical settings changes for this build target.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="perPage">Number of audit log records to retrieve</param>
        /// <param name="page">Skip to page number, based on per_page value</param>
        /// <returns>Task of ApiResponse (List&lt;InlineResponse2002&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<InlineResponse2002>>> GetAuditLogAsyncWithHttpInfo (string orgid, string projectid, string buildtargetid, double? perPage = null, double? page = null)
        {
            // verify the required parameter 'orgid' is set
            if (orgid == null) throw new ApiException(400, "Missing required parameter 'orgid' when calling GetAuditLog");
            // verify the required parameter 'projectid' is set
            if (projectid == null) throw new ApiException(400, "Missing required parameter 'projectid' when calling GetAuditLog");
            // verify the required parameter 'buildtargetid' is set
            if (buildtargetid == null) throw new ApiException(400, "Missing required parameter 'buildtargetid' when calling GetAuditLog");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/buildtargets/{buildtargetid}/auditlog";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/plain", "text/html"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (orgid != null) pathParams.Add("orgid", Configuration.ApiClient.ParameterToString(orgid)); // path parameter
            if (projectid != null) pathParams.Add("projectid", Configuration.ApiClient.ParameterToString(projectid)); // path parameter
            if (buildtargetid != null) pathParams.Add("buildtargetid", Configuration.ApiClient.ParameterToString(buildtargetid)); // path parameter
            
            if (perPage != null) queryParams.Add("per_page", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            if (page != null) queryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            
            
            
            

            
            // authentication (apikey) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            
            // authentication (permissions) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetAuditLog: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetAuditLog: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<InlineResponse2002>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InlineResponse2002>) Configuration.ApiClient.Deserialize(response, typeof(List<InlineResponse2002>)));
            
        }
        
        /// <summary>
        /// List all builds List all running and finished builds, sorted by build number\n(optionally paginating the results). Use &#39;_all&#39; as the buildtargetid\nto get all configured build targets. The response includes a Content-Range\nheader that identifies the range of results returned and the total number\nof results matching the given query parameters.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param> 
        /// <param name="include">Extra fields to include in the response</param> 
        /// <param name="perPage">Number of audit log records to retrieve</param> 
        /// <param name="page">Skip to page number, based on per_page value</param> 
        /// <param name="buildStatus">Query for only builds of a specific status</param> 
        /// <param name="platform">Query for only builds of a specific platform</param> 
        /// <returns>List&lt;OrgsorgidprojectsprojectidbuildtargetsBuilds&gt;</returns>
        public List<OrgsorgidprojectsprojectidbuildtargetsBuilds> GetBuilds (string orgid, string projectid, string buildtargetid, string include = null, double? perPage = null, double? page = null, string buildStatus = null, string platform = null)
        {
             ApiResponse<List<OrgsorgidprojectsprojectidbuildtargetsBuilds>> response = GetBuildsWithHttpInfo(orgid, projectid, buildtargetid, include, perPage, page, buildStatus, platform);
             return response.Data;
        }

        /// <summary>
        /// List all builds List all running and finished builds, sorted by build number\n(optionally paginating the results). Use &#39;_all&#39; as the buildtargetid\nto get all configured build targets. The response includes a Content-Range\nheader that identifies the range of results returned and the total number\nof results matching the given query parameters.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param> 
        /// <param name="include">Extra fields to include in the response</param> 
        /// <param name="perPage">Number of audit log records to retrieve</param> 
        /// <param name="page">Skip to page number, based on per_page value</param> 
        /// <param name="buildStatus">Query for only builds of a specific status</param> 
        /// <param name="platform">Query for only builds of a specific platform</param> 
        /// <returns>ApiResponse of List&lt;OrgsorgidprojectsprojectidbuildtargetsBuilds&gt;</returns>
        public ApiResponse< List<OrgsorgidprojectsprojectidbuildtargetsBuilds> > GetBuildsWithHttpInfo (string orgid, string projectid, string buildtargetid, string include = null, double? perPage = null, double? page = null, string buildStatus = null, string platform = null)
        {
            
            // verify the required parameter 'orgid' is set
            if (orgid == null)
                throw new ApiException(400, "Missing required parameter 'orgid' when calling BuildsApi->GetBuilds");
            
            // verify the required parameter 'projectid' is set
            if (projectid == null)
                throw new ApiException(400, "Missing required parameter 'projectid' when calling BuildsApi->GetBuilds");
            
            // verify the required parameter 'buildtargetid' is set
            if (buildtargetid == null)
                throw new ApiException(400, "Missing required parameter 'buildtargetid' when calling BuildsApi->GetBuilds");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/buildtargets/{buildtargetid}/builds";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/plain", "text/html"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (orgid != null) pathParams.Add("orgid", Configuration.ApiClient.ParameterToString(orgid)); // path parameter
            if (projectid != null) pathParams.Add("projectid", Configuration.ApiClient.ParameterToString(projectid)); // path parameter
            if (buildtargetid != null) pathParams.Add("buildtargetid", Configuration.ApiClient.ParameterToString(buildtargetid)); // path parameter
            
            if (include != null) queryParams.Add("include", Configuration.ApiClient.ParameterToString(include)); // query parameter
            if (perPage != null) queryParams.Add("per_page", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            if (page != null) queryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (buildStatus != null) queryParams.Add("buildStatus", Configuration.ApiClient.ParameterToString(buildStatus)); // query parameter
            if (platform != null) queryParams.Add("platform", Configuration.ApiClient.ParameterToString(platform)); // query parameter
            
            
            
            

            // authentication (apikey) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            // authentication (permissions) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetBuilds: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetBuilds: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<OrgsorgidprojectsprojectidbuildtargetsBuilds>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<OrgsorgidprojectsprojectidbuildtargetsBuilds>) Configuration.ApiClient.Deserialize(response, typeof(List<OrgsorgidprojectsprojectidbuildtargetsBuilds>)));
            
        }
    
        /// <summary>
        /// List all builds List all running and finished builds, sorted by build number\n(optionally paginating the results). Use &#39;_all&#39; as the buildtargetid\nto get all configured build targets. The response includes a Content-Range\nheader that identifies the range of results returned and the total number\nof results matching the given query parameters.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="include">Extra fields to include in the response</param>
        /// <param name="perPage">Number of audit log records to retrieve</param>
        /// <param name="page">Skip to page number, based on per_page value</param>
        /// <param name="buildStatus">Query for only builds of a specific status</param>
        /// <param name="platform">Query for only builds of a specific platform</param>
        /// <returns>Task of List&lt;OrgsorgidprojectsprojectidbuildtargetsBuilds&gt;</returns>
        public async System.Threading.Tasks.Task<List<OrgsorgidprojectsprojectidbuildtargetsBuilds>> GetBuildsAsync (string orgid, string projectid, string buildtargetid, string include = null, double? perPage = null, double? page = null, string buildStatus = null, string platform = null)
        {
             ApiResponse<List<OrgsorgidprojectsprojectidbuildtargetsBuilds>> response = await GetBuildsAsyncWithHttpInfo(orgid, projectid, buildtargetid, include, perPage, page, buildStatus, platform);
             return response.Data;

        }

        /// <summary>
        /// List all builds List all running and finished builds, sorted by build number\n(optionally paginating the results). Use &#39;_all&#39; as the buildtargetid\nto get all configured build targets. The response includes a Content-Range\nheader that identifies the range of results returned and the total number\nof results matching the given query parameters.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="include">Extra fields to include in the response</param>
        /// <param name="perPage">Number of audit log records to retrieve</param>
        /// <param name="page">Skip to page number, based on per_page value</param>
        /// <param name="buildStatus">Query for only builds of a specific status</param>
        /// <param name="platform">Query for only builds of a specific platform</param>
        /// <returns>Task of ApiResponse (List&lt;OrgsorgidprojectsprojectidbuildtargetsBuilds&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<OrgsorgidprojectsprojectidbuildtargetsBuilds>>> GetBuildsAsyncWithHttpInfo (string orgid, string projectid, string buildtargetid, string include = null, double? perPage = null, double? page = null, string buildStatus = null, string platform = null)
        {
            // verify the required parameter 'orgid' is set
            if (orgid == null) throw new ApiException(400, "Missing required parameter 'orgid' when calling GetBuilds");
            // verify the required parameter 'projectid' is set
            if (projectid == null) throw new ApiException(400, "Missing required parameter 'projectid' when calling GetBuilds");
            // verify the required parameter 'buildtargetid' is set
            if (buildtargetid == null) throw new ApiException(400, "Missing required parameter 'buildtargetid' when calling GetBuilds");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/buildtargets/{buildtargetid}/builds";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/plain", "text/html"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (orgid != null) pathParams.Add("orgid", Configuration.ApiClient.ParameterToString(orgid)); // path parameter
            if (projectid != null) pathParams.Add("projectid", Configuration.ApiClient.ParameterToString(projectid)); // path parameter
            if (buildtargetid != null) pathParams.Add("buildtargetid", Configuration.ApiClient.ParameterToString(buildtargetid)); // path parameter
            
            if (include != null) queryParams.Add("include", Configuration.ApiClient.ParameterToString(include)); // query parameter
            if (perPage != null) queryParams.Add("per_page", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            if (page != null) queryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (buildStatus != null) queryParams.Add("buildStatus", Configuration.ApiClient.ParameterToString(buildStatus)); // query parameter
            if (platform != null) queryParams.Add("platform", Configuration.ApiClient.ParameterToString(platform)); // query parameter
            
            
            
            

            
            // authentication (apikey) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            
            // authentication (permissions) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetBuilds: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetBuilds: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<OrgsorgidprojectsprojectidbuildtargetsBuilds>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<OrgsorgidprojectsprojectidbuildtargetsBuilds>) Configuration.ApiClient.Deserialize(response, typeof(List<OrgsorgidprojectsprojectidbuildtargetsBuilds>)));
            
        }
        
        /// <summary>
        /// Create new build Start the build process for this build target (or all targets,\nif &#39;_all&#39; is specified as the buildtargetid), if there is not one\ncurrently in process.\n\nIf a build is currently in process that information will be related\nin the &#39;error&#39; field.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param> 
        /// <param name="options">Options for starting the builds</param> 
        /// <returns>List&lt;OrgsorgidprojectsprojectidbuildtargetsBuilds&gt;</returns>
        public List<OrgsorgidprojectsprojectidbuildtargetsBuilds> StartBuilds (string orgid, string projectid, string buildtargetid, Options4 options = null)
        {
             ApiResponse<List<OrgsorgidprojectsprojectidbuildtargetsBuilds>> response = StartBuildsWithHttpInfo(orgid, projectid, buildtargetid, options);
             return response.Data;
        }

        /// <summary>
        /// Create new build Start the build process for this build target (or all targets,\nif &#39;_all&#39; is specified as the buildtargetid), if there is not one\ncurrently in process.\n\nIf a build is currently in process that information will be related\nin the &#39;error&#39; field.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param> 
        /// <param name="options">Options for starting the builds</param> 
        /// <returns>ApiResponse of List&lt;OrgsorgidprojectsprojectidbuildtargetsBuilds&gt;</returns>
        public ApiResponse< List<OrgsorgidprojectsprojectidbuildtargetsBuilds> > StartBuildsWithHttpInfo (string orgid, string projectid, string buildtargetid, Options4 options = null)
        {
            
            // verify the required parameter 'orgid' is set
            if (orgid == null)
                throw new ApiException(400, "Missing required parameter 'orgid' when calling BuildsApi->StartBuilds");
            
            // verify the required parameter 'projectid' is set
            if (projectid == null)
                throw new ApiException(400, "Missing required parameter 'projectid' when calling BuildsApi->StartBuilds");
            
            // verify the required parameter 'buildtargetid' is set
            if (buildtargetid == null)
                throw new ApiException(400, "Missing required parameter 'buildtargetid' when calling BuildsApi->StartBuilds");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/buildtargets/{buildtargetid}/builds";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/plain", "text/html"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (orgid != null) pathParams.Add("orgid", Configuration.ApiClient.ParameterToString(orgid)); // path parameter
            if (projectid != null) pathParams.Add("projectid", Configuration.ApiClient.ParameterToString(projectid)); // path parameter
            if (buildtargetid != null) pathParams.Add("buildtargetid", Configuration.ApiClient.ParameterToString(buildtargetid)); // path parameter
            
            
            
            
            if (options.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(options); // http body (model) parameter
            }
            else
            {
                postBody = options; // byte array
            }

            // authentication (apikey) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            // authentication (permissions) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling StartBuilds: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling StartBuilds: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<OrgsorgidprojectsprojectidbuildtargetsBuilds>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<OrgsorgidprojectsprojectidbuildtargetsBuilds>) Configuration.ApiClient.Deserialize(response, typeof(List<OrgsorgidprojectsprojectidbuildtargetsBuilds>)));
            
        }
    
        /// <summary>
        /// Create new build Start the build process for this build target (or all targets,\nif &#39;_all&#39; is specified as the buildtargetid), if there is not one\ncurrently in process.\n\nIf a build is currently in process that information will be related\nin the &#39;error&#39; field.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="options">Options for starting the builds</param>
        /// <returns>Task of List&lt;OrgsorgidprojectsprojectidbuildtargetsBuilds&gt;</returns>
        public async System.Threading.Tasks.Task<List<OrgsorgidprojectsprojectidbuildtargetsBuilds>> StartBuildsAsync (string orgid, string projectid, string buildtargetid, Options4 options = null)
        {
             ApiResponse<List<OrgsorgidprojectsprojectidbuildtargetsBuilds>> response = await StartBuildsAsyncWithHttpInfo(orgid, projectid, buildtargetid, options);
             return response.Data;

        }

        /// <summary>
        /// Create new build Start the build process for this build target (or all targets,\nif &#39;_all&#39; is specified as the buildtargetid), if there is not one\ncurrently in process.\n\nIf a build is currently in process that information will be related\nin the &#39;error&#39; field.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="options">Options for starting the builds</param>
        /// <returns>Task of ApiResponse (List&lt;OrgsorgidprojectsprojectidbuildtargetsBuilds&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<OrgsorgidprojectsprojectidbuildtargetsBuilds>>> StartBuildsAsyncWithHttpInfo (string orgid, string projectid, string buildtargetid, Options4 options = null)
        {
            // verify the required parameter 'orgid' is set
            if (orgid == null) throw new ApiException(400, "Missing required parameter 'orgid' when calling StartBuilds");
            // verify the required parameter 'projectid' is set
            if (projectid == null) throw new ApiException(400, "Missing required parameter 'projectid' when calling StartBuilds");
            // verify the required parameter 'buildtargetid' is set
            if (buildtargetid == null) throw new ApiException(400, "Missing required parameter 'buildtargetid' when calling StartBuilds");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/buildtargets/{buildtargetid}/builds";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/plain", "text/html"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (orgid != null) pathParams.Add("orgid", Configuration.ApiClient.ParameterToString(orgid)); // path parameter
            if (projectid != null) pathParams.Add("projectid", Configuration.ApiClient.ParameterToString(projectid)); // path parameter
            if (buildtargetid != null) pathParams.Add("buildtargetid", Configuration.ApiClient.ParameterToString(buildtargetid)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(options); // http body (model) parameter
            

            
            // authentication (apikey) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            
            // authentication (permissions) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling StartBuilds: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling StartBuilds: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<OrgsorgidprojectsprojectidbuildtargetsBuilds>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<OrgsorgidprojectsprojectidbuildtargetsBuilds>) Configuration.ApiClient.Deserialize(response, typeof(List<OrgsorgidprojectsprojectidbuildtargetsBuilds>)));
            
        }
        
        /// <summary>
        /// Cancel all builds Cancel all builds in progress for this build target (or all targets,\nif &#39;_all&#39; is specified as the buildtargetid). Canceling an already\nfinished build will do nothing and respond successfully.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param> 
        /// <returns>string</returns>
        public string CancelAllBuilds (string orgid, string projectid, string buildtargetid)
        {
             ApiResponse<string> response = CancelAllBuildsWithHttpInfo(orgid, projectid, buildtargetid);
             return response.Data;
        }

        /// <summary>
        /// Cancel all builds Cancel all builds in progress for this build target (or all targets,\nif &#39;_all&#39; is specified as the buildtargetid). Canceling an already\nfinished build will do nothing and respond successfully.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > CancelAllBuildsWithHttpInfo (string orgid, string projectid, string buildtargetid)
        {
            
            // verify the required parameter 'orgid' is set
            if (orgid == null)
                throw new ApiException(400, "Missing required parameter 'orgid' when calling BuildsApi->CancelAllBuilds");
            
            // verify the required parameter 'projectid' is set
            if (projectid == null)
                throw new ApiException(400, "Missing required parameter 'projectid' when calling BuildsApi->CancelAllBuilds");
            
            // verify the required parameter 'buildtargetid' is set
            if (buildtargetid == null)
                throw new ApiException(400, "Missing required parameter 'buildtargetid' when calling BuildsApi->CancelAllBuilds");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/buildtargets/{buildtargetid}/builds";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/plain", "text/html"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (orgid != null) pathParams.Add("orgid", Configuration.ApiClient.ParameterToString(orgid)); // path parameter
            if (projectid != null) pathParams.Add("projectid", Configuration.ApiClient.ParameterToString(projectid)); // path parameter
            if (buildtargetid != null) pathParams.Add("buildtargetid", Configuration.ApiClient.ParameterToString(buildtargetid)); // path parameter
            
            
            
            
            

            // authentication (apikey) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            // authentication (permissions) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CancelAllBuilds: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CancelAllBuilds: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Cancel all builds Cancel all builds in progress for this build target (or all targets,\nif &#39;_all&#39; is specified as the buildtargetid). Canceling an already\nfinished build will do nothing and respond successfully.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> CancelAllBuildsAsync (string orgid, string projectid, string buildtargetid)
        {
             ApiResponse<string> response = await CancelAllBuildsAsyncWithHttpInfo(orgid, projectid, buildtargetid);
             return response.Data;

        }

        /// <summary>
        /// Cancel all builds Cancel all builds in progress for this build target (or all targets,\nif &#39;_all&#39; is specified as the buildtargetid). Canceling an already\nfinished build will do nothing and respond successfully.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> CancelAllBuildsAsyncWithHttpInfo (string orgid, string projectid, string buildtargetid)
        {
            // verify the required parameter 'orgid' is set
            if (orgid == null) throw new ApiException(400, "Missing required parameter 'orgid' when calling CancelAllBuilds");
            // verify the required parameter 'projectid' is set
            if (projectid == null) throw new ApiException(400, "Missing required parameter 'projectid' when calling CancelAllBuilds");
            // verify the required parameter 'buildtargetid' is set
            if (buildtargetid == null) throw new ApiException(400, "Missing required parameter 'buildtargetid' when calling CancelAllBuilds");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/buildtargets/{buildtargetid}/builds";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/plain", "text/html"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (orgid != null) pathParams.Add("orgid", Configuration.ApiClient.ParameterToString(orgid)); // path parameter
            if (projectid != null) pathParams.Add("projectid", Configuration.ApiClient.ParameterToString(projectid)); // path parameter
            if (buildtargetid != null) pathParams.Add("buildtargetid", Configuration.ApiClient.ParameterToString(buildtargetid)); // path parameter
            
            
            
            
            

            
            // authentication (apikey) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            
            // authentication (permissions) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CancelAllBuilds: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CancelAllBuilds: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Build Status Retrieve information for a specific build. A Build resource contains\ninformation related to a build attempt for a build target, including\nthe build number, changeset, build times, and other pertinent data.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param> 
        /// <param name="number">Build number or in some cases _all</param> 
        /// <param name="include">Extra fields to include in the response</param> 
        /// <returns>OrgsorgidprojectsprojectidbuildtargetsBuilds</returns>
        public OrgsorgidprojectsprojectidbuildtargetsBuilds GetBuild (string orgid, string projectid, string buildtargetid, string number, string include = null)
        {
             ApiResponse<OrgsorgidprojectsprojectidbuildtargetsBuilds> response = GetBuildWithHttpInfo(orgid, projectid, buildtargetid, number, include);
             return response.Data;
        }

        /// <summary>
        /// Build Status Retrieve information for a specific build. A Build resource contains\ninformation related to a build attempt for a build target, including\nthe build number, changeset, build times, and other pertinent data.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param> 
        /// <param name="number">Build number or in some cases _all</param> 
        /// <param name="include">Extra fields to include in the response</param> 
        /// <returns>ApiResponse of OrgsorgidprojectsprojectidbuildtargetsBuilds</returns>
        public ApiResponse< OrgsorgidprojectsprojectidbuildtargetsBuilds > GetBuildWithHttpInfo (string orgid, string projectid, string buildtargetid, string number, string include = null)
        {
            
            // verify the required parameter 'orgid' is set
            if (orgid == null)
                throw new ApiException(400, "Missing required parameter 'orgid' when calling BuildsApi->GetBuild");
            
            // verify the required parameter 'projectid' is set
            if (projectid == null)
                throw new ApiException(400, "Missing required parameter 'projectid' when calling BuildsApi->GetBuild");
            
            // verify the required parameter 'buildtargetid' is set
            if (buildtargetid == null)
                throw new ApiException(400, "Missing required parameter 'buildtargetid' when calling BuildsApi->GetBuild");
            
            // verify the required parameter 'number' is set
            if (number == null)
                throw new ApiException(400, "Missing required parameter 'number' when calling BuildsApi->GetBuild");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/buildtargets/{buildtargetid}/builds/{number}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/plain", "text/html"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (orgid != null) pathParams.Add("orgid", Configuration.ApiClient.ParameterToString(orgid)); // path parameter
            if (projectid != null) pathParams.Add("projectid", Configuration.ApiClient.ParameterToString(projectid)); // path parameter
            if (buildtargetid != null) pathParams.Add("buildtargetid", Configuration.ApiClient.ParameterToString(buildtargetid)); // path parameter
            if (number != null) pathParams.Add("number", Configuration.ApiClient.ParameterToString(number)); // path parameter
            
            if (include != null) queryParams.Add("include", Configuration.ApiClient.ParameterToString(include)); // query parameter
            
            
            
            

            // authentication (apikey) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            // authentication (permissions) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetBuild: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetBuild: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<OrgsorgidprojectsprojectidbuildtargetsBuilds>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrgsorgidprojectsprojectidbuildtargetsBuilds) Configuration.ApiClient.Deserialize(response, typeof(OrgsorgidprojectsprojectidbuildtargetsBuilds)));
            
        }
    
        /// <summary>
        /// Build Status Retrieve information for a specific build. A Build resource contains\ninformation related to a build attempt for a build target, including\nthe build number, changeset, build times, and other pertinent data.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <param name="include">Extra fields to include in the response</param>
        /// <returns>Task of OrgsorgidprojectsprojectidbuildtargetsBuilds</returns>
        public async System.Threading.Tasks.Task<OrgsorgidprojectsprojectidbuildtargetsBuilds> GetBuildAsync (string orgid, string projectid, string buildtargetid, string number, string include = null)
        {
             ApiResponse<OrgsorgidprojectsprojectidbuildtargetsBuilds> response = await GetBuildAsyncWithHttpInfo(orgid, projectid, buildtargetid, number, include);
             return response.Data;

        }

        /// <summary>
        /// Build Status Retrieve information for a specific build. A Build resource contains\ninformation related to a build attempt for a build target, including\nthe build number, changeset, build times, and other pertinent data.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <param name="include">Extra fields to include in the response</param>
        /// <returns>Task of ApiResponse (OrgsorgidprojectsprojectidbuildtargetsBuilds)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrgsorgidprojectsprojectidbuildtargetsBuilds>> GetBuildAsyncWithHttpInfo (string orgid, string projectid, string buildtargetid, string number, string include = null)
        {
            // verify the required parameter 'orgid' is set
            if (orgid == null) throw new ApiException(400, "Missing required parameter 'orgid' when calling GetBuild");
            // verify the required parameter 'projectid' is set
            if (projectid == null) throw new ApiException(400, "Missing required parameter 'projectid' when calling GetBuild");
            // verify the required parameter 'buildtargetid' is set
            if (buildtargetid == null) throw new ApiException(400, "Missing required parameter 'buildtargetid' when calling GetBuild");
            // verify the required parameter 'number' is set
            if (number == null) throw new ApiException(400, "Missing required parameter 'number' when calling GetBuild");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/buildtargets/{buildtargetid}/builds/{number}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/plain", "text/html"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (orgid != null) pathParams.Add("orgid", Configuration.ApiClient.ParameterToString(orgid)); // path parameter
            if (projectid != null) pathParams.Add("projectid", Configuration.ApiClient.ParameterToString(projectid)); // path parameter
            if (buildtargetid != null) pathParams.Add("buildtargetid", Configuration.ApiClient.ParameterToString(buildtargetid)); // path parameter
            if (number != null) pathParams.Add("number", Configuration.ApiClient.ParameterToString(number)); // path parameter
            
            if (include != null) queryParams.Add("include", Configuration.ApiClient.ParameterToString(include)); // query parameter
            
            
            
            

            
            // authentication (apikey) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            
            // authentication (permissions) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetBuild: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetBuild: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<OrgsorgidprojectsprojectidbuildtargetsBuilds>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrgsorgidprojectsprojectidbuildtargetsBuilds) Configuration.ApiClient.Deserialize(response, typeof(OrgsorgidprojectsprojectidbuildtargetsBuilds)));
            
        }
        
        /// <summary>
        /// Cancel build Cancel a build in progress. Canceling an already finished build\nwill do nothing and respond successfully.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param> 
        /// <param name="number">Build number or in some cases _all</param> 
        /// <returns>string</returns>
        public string CancelBuild (string orgid, string projectid, string buildtargetid, string number)
        {
             ApiResponse<string> response = CancelBuildWithHttpInfo(orgid, projectid, buildtargetid, number);
             return response.Data;
        }

        /// <summary>
        /// Cancel build Cancel a build in progress. Canceling an already finished build\nwill do nothing and respond successfully.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param> 
        /// <param name="number">Build number or in some cases _all</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > CancelBuildWithHttpInfo (string orgid, string projectid, string buildtargetid, string number)
        {
            
            // verify the required parameter 'orgid' is set
            if (orgid == null)
                throw new ApiException(400, "Missing required parameter 'orgid' when calling BuildsApi->CancelBuild");
            
            // verify the required parameter 'projectid' is set
            if (projectid == null)
                throw new ApiException(400, "Missing required parameter 'projectid' when calling BuildsApi->CancelBuild");
            
            // verify the required parameter 'buildtargetid' is set
            if (buildtargetid == null)
                throw new ApiException(400, "Missing required parameter 'buildtargetid' when calling BuildsApi->CancelBuild");
            
            // verify the required parameter 'number' is set
            if (number == null)
                throw new ApiException(400, "Missing required parameter 'number' when calling BuildsApi->CancelBuild");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/buildtargets/{buildtargetid}/builds/{number}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/plain", "text/html"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (orgid != null) pathParams.Add("orgid", Configuration.ApiClient.ParameterToString(orgid)); // path parameter
            if (projectid != null) pathParams.Add("projectid", Configuration.ApiClient.ParameterToString(projectid)); // path parameter
            if (buildtargetid != null) pathParams.Add("buildtargetid", Configuration.ApiClient.ParameterToString(buildtargetid)); // path parameter
            if (number != null) pathParams.Add("number", Configuration.ApiClient.ParameterToString(number)); // path parameter
            
            
            
            
            

            // authentication (apikey) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            // authentication (permissions) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CancelBuild: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CancelBuild: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Cancel build Cancel a build in progress. Canceling an already finished build\nwill do nothing and respond successfully.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> CancelBuildAsync (string orgid, string projectid, string buildtargetid, string number)
        {
             ApiResponse<string> response = await CancelBuildAsyncWithHttpInfo(orgid, projectid, buildtargetid, number);
             return response.Data;

        }

        /// <summary>
        /// Cancel build Cancel a build in progress. Canceling an already finished build\nwill do nothing and respond successfully.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> CancelBuildAsyncWithHttpInfo (string orgid, string projectid, string buildtargetid, string number)
        {
            // verify the required parameter 'orgid' is set
            if (orgid == null) throw new ApiException(400, "Missing required parameter 'orgid' when calling CancelBuild");
            // verify the required parameter 'projectid' is set
            if (projectid == null) throw new ApiException(400, "Missing required parameter 'projectid' when calling CancelBuild");
            // verify the required parameter 'buildtargetid' is set
            if (buildtargetid == null) throw new ApiException(400, "Missing required parameter 'buildtargetid' when calling CancelBuild");
            // verify the required parameter 'number' is set
            if (number == null) throw new ApiException(400, "Missing required parameter 'number' when calling CancelBuild");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/buildtargets/{buildtargetid}/builds/{number}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/plain", "text/html"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (orgid != null) pathParams.Add("orgid", Configuration.ApiClient.ParameterToString(orgid)); // path parameter
            if (projectid != null) pathParams.Add("projectid", Configuration.ApiClient.ParameterToString(projectid)); // path parameter
            if (buildtargetid != null) pathParams.Add("buildtargetid", Configuration.ApiClient.ParameterToString(buildtargetid)); // path parameter
            if (number != null) pathParams.Add("number", Configuration.ApiClient.ParameterToString(number)); // path parameter
            
            
            
            
            

            
            // authentication (apikey) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            
            // authentication (permissions) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CancelBuild: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CancelBuild: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get audit log Retrieve a list of settings changes between the last and current build.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param> 
        /// <param name="number">Build number or in some cases _all</param> 
        /// <param name="perPage">Number of audit log records to retrieve</param> 
        /// <param name="page">Skip to page number, based on per_page value</param> 
        /// <returns>List&lt;InlineResponse2002&gt;</returns>
        public List<InlineResponse2002> GetAuditLog_0 (string orgid, string projectid, string buildtargetid, string number, double? perPage = null, double? page = null)
        {
             ApiResponse<List<InlineResponse2002>> response = GetAuditLog_0WithHttpInfo(orgid, projectid, buildtargetid, number, perPage, page);
             return response.Data;
        }

        /// <summary>
        /// Get audit log Retrieve a list of settings changes between the last and current build.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param> 
        /// <param name="number">Build number or in some cases _all</param> 
        /// <param name="perPage">Number of audit log records to retrieve</param> 
        /// <param name="page">Skip to page number, based on per_page value</param> 
        /// <returns>ApiResponse of List&lt;InlineResponse2002&gt;</returns>
        public ApiResponse< List<InlineResponse2002> > GetAuditLog_0WithHttpInfo (string orgid, string projectid, string buildtargetid, string number, double? perPage = null, double? page = null)
        {
            
            // verify the required parameter 'orgid' is set
            if (orgid == null)
                throw new ApiException(400, "Missing required parameter 'orgid' when calling BuildsApi->GetAuditLog_0");
            
            // verify the required parameter 'projectid' is set
            if (projectid == null)
                throw new ApiException(400, "Missing required parameter 'projectid' when calling BuildsApi->GetAuditLog_0");
            
            // verify the required parameter 'buildtargetid' is set
            if (buildtargetid == null)
                throw new ApiException(400, "Missing required parameter 'buildtargetid' when calling BuildsApi->GetAuditLog_0");
            
            // verify the required parameter 'number' is set
            if (number == null)
                throw new ApiException(400, "Missing required parameter 'number' when calling BuildsApi->GetAuditLog_0");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/buildtargets/{buildtargetid}/builds/{number}/auditlog";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/plain", "text/html"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (orgid != null) pathParams.Add("orgid", Configuration.ApiClient.ParameterToString(orgid)); // path parameter
            if (projectid != null) pathParams.Add("projectid", Configuration.ApiClient.ParameterToString(projectid)); // path parameter
            if (buildtargetid != null) pathParams.Add("buildtargetid", Configuration.ApiClient.ParameterToString(buildtargetid)); // path parameter
            if (number != null) pathParams.Add("number", Configuration.ApiClient.ParameterToString(number)); // path parameter
            
            if (perPage != null) queryParams.Add("per_page", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            if (page != null) queryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            
            
            
            

            // authentication (apikey) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            // authentication (permissions) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetAuditLog_0: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetAuditLog_0: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<InlineResponse2002>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InlineResponse2002>) Configuration.ApiClient.Deserialize(response, typeof(List<InlineResponse2002>)));
            
        }
    
        /// <summary>
        /// Get audit log Retrieve a list of settings changes between the last and current build.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <param name="perPage">Number of audit log records to retrieve</param>
        /// <param name="page">Skip to page number, based on per_page value</param>
        /// <returns>Task of List&lt;InlineResponse2002&gt;</returns>
        public async System.Threading.Tasks.Task<List<InlineResponse2002>> GetAuditLog_0Async (string orgid, string projectid, string buildtargetid, string number, double? perPage = null, double? page = null)
        {
             ApiResponse<List<InlineResponse2002>> response = await GetAuditLog_0AsyncWithHttpInfo(orgid, projectid, buildtargetid, number, perPage, page);
             return response.Data;

        }

        /// <summary>
        /// Get audit log Retrieve a list of settings changes between the last and current build.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <param name="perPage">Number of audit log records to retrieve</param>
        /// <param name="page">Skip to page number, based on per_page value</param>
        /// <returns>Task of ApiResponse (List&lt;InlineResponse2002&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<InlineResponse2002>>> GetAuditLog_0AsyncWithHttpInfo (string orgid, string projectid, string buildtargetid, string number, double? perPage = null, double? page = null)
        {
            // verify the required parameter 'orgid' is set
            if (orgid == null) throw new ApiException(400, "Missing required parameter 'orgid' when calling GetAuditLog_0");
            // verify the required parameter 'projectid' is set
            if (projectid == null) throw new ApiException(400, "Missing required parameter 'projectid' when calling GetAuditLog_0");
            // verify the required parameter 'buildtargetid' is set
            if (buildtargetid == null) throw new ApiException(400, "Missing required parameter 'buildtargetid' when calling GetAuditLog_0");
            // verify the required parameter 'number' is set
            if (number == null) throw new ApiException(400, "Missing required parameter 'number' when calling GetAuditLog_0");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/buildtargets/{buildtargetid}/builds/{number}/auditlog";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/plain", "text/html"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (orgid != null) pathParams.Add("orgid", Configuration.ApiClient.ParameterToString(orgid)); // path parameter
            if (projectid != null) pathParams.Add("projectid", Configuration.ApiClient.ParameterToString(projectid)); // path parameter
            if (buildtargetid != null) pathParams.Add("buildtargetid", Configuration.ApiClient.ParameterToString(buildtargetid)); // path parameter
            if (number != null) pathParams.Add("number", Configuration.ApiClient.ParameterToString(number)); // path parameter
            
            if (perPage != null) queryParams.Add("per_page", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            if (page != null) queryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            
            
            
            

            
            // authentication (apikey) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            
            // authentication (permissions) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetAuditLog_0: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetAuditLog_0: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<InlineResponse2002>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InlineResponse2002>) Configuration.ApiClient.Deserialize(response, typeof(List<InlineResponse2002>)));
            
        }
        
        /// <summary>
        /// Get build log Retrieve the plain text log for a specifc build.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param> 
        /// <param name="number">Build number or in some cases _all</param> 
        /// <param name="offsetlines">Stream log from the given line number</param> 
        /// <param name="linenumbers">Include log line numbers in the text output</param> 
        /// <param name="compact">Return the compact log, showing only errors and warnings</param> 
        /// <param name="withHtml">Surround important lines (errors, warnings) with SPAN and CSS markup</param> 
        /// <returns></returns>
        public void GetBuildLog (string orgid, string projectid, string buildtargetid, string number, double? offsetlines = null, bool? linenumbers = null, bool? compact = null, bool? withHtml = null)
        {
             GetBuildLogWithHttpInfo(orgid, projectid, buildtargetid, number, offsetlines, linenumbers, compact, withHtml);
        }

        /// <summary>
        /// Get build log Retrieve the plain text log for a specifc build.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param> 
        /// <param name="number">Build number or in some cases _all</param> 
        /// <param name="offsetlines">Stream log from the given line number</param> 
        /// <param name="linenumbers">Include log line numbers in the text output</param> 
        /// <param name="compact">Return the compact log, showing only errors and warnings</param> 
        /// <param name="withHtml">Surround important lines (errors, warnings) with SPAN and CSS markup</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetBuildLogWithHttpInfo (string orgid, string projectid, string buildtargetid, string number, double? offsetlines = null, bool? linenumbers = null, bool? compact = null, bool? withHtml = null)
        {
            
            // verify the required parameter 'orgid' is set
            if (orgid == null)
                throw new ApiException(400, "Missing required parameter 'orgid' when calling BuildsApi->GetBuildLog");
            
            // verify the required parameter 'projectid' is set
            if (projectid == null)
                throw new ApiException(400, "Missing required parameter 'projectid' when calling BuildsApi->GetBuildLog");
            
            // verify the required parameter 'buildtargetid' is set
            if (buildtargetid == null)
                throw new ApiException(400, "Missing required parameter 'buildtargetid' when calling BuildsApi->GetBuildLog");
            
            // verify the required parameter 'number' is set
            if (number == null)
                throw new ApiException(400, "Missing required parameter 'number' when calling BuildsApi->GetBuildLog");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/buildtargets/{buildtargetid}/builds/{number}/log";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/plain", "text/html"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (orgid != null) pathParams.Add("orgid", Configuration.ApiClient.ParameterToString(orgid)); // path parameter
            if (projectid != null) pathParams.Add("projectid", Configuration.ApiClient.ParameterToString(projectid)); // path parameter
            if (buildtargetid != null) pathParams.Add("buildtargetid", Configuration.ApiClient.ParameterToString(buildtargetid)); // path parameter
            if (number != null) pathParams.Add("number", Configuration.ApiClient.ParameterToString(number)); // path parameter
            
            if (offsetlines != null) queryParams.Add("offsetlines", Configuration.ApiClient.ParameterToString(offsetlines)); // query parameter
            if (linenumbers != null) queryParams.Add("linenumbers", Configuration.ApiClient.ParameterToString(linenumbers)); // query parameter
            if (compact != null) queryParams.Add("compact", Configuration.ApiClient.ParameterToString(compact)); // query parameter
            if (withHtml != null) queryParams.Add("withHtml", Configuration.ApiClient.ParameterToString(withHtml)); // query parameter
            
            
            
            

            // authentication (apikey) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            // authentication (permissions) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetBuildLog: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetBuildLog: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Get build log Retrieve the plain text log for a specifc build.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <param name="offsetlines">Stream log from the given line number</param>
        /// <param name="linenumbers">Include log line numbers in the text output</param>
        /// <param name="compact">Return the compact log, showing only errors and warnings</param>
        /// <param name="withHtml">Surround important lines (errors, warnings) with SPAN and CSS markup</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetBuildLogAsync (string orgid, string projectid, string buildtargetid, string number, double? offsetlines = null, bool? linenumbers = null, bool? compact = null, bool? withHtml = null)
        {
             await GetBuildLogAsyncWithHttpInfo(orgid, projectid, buildtargetid, number, offsetlines, linenumbers, compact, withHtml);

        }

        /// <summary>
        /// Get build log Retrieve the plain text log for a specifc build.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <param name="offsetlines">Stream log from the given line number</param>
        /// <param name="linenumbers">Include log line numbers in the text output</param>
        /// <param name="compact">Return the compact log, showing only errors and warnings</param>
        /// <param name="withHtml">Surround important lines (errors, warnings) with SPAN and CSS markup</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetBuildLogAsyncWithHttpInfo (string orgid, string projectid, string buildtargetid, string number, double? offsetlines = null, bool? linenumbers = null, bool? compact = null, bool? withHtml = null)
        {
            // verify the required parameter 'orgid' is set
            if (orgid == null) throw new ApiException(400, "Missing required parameter 'orgid' when calling GetBuildLog");
            // verify the required parameter 'projectid' is set
            if (projectid == null) throw new ApiException(400, "Missing required parameter 'projectid' when calling GetBuildLog");
            // verify the required parameter 'buildtargetid' is set
            if (buildtargetid == null) throw new ApiException(400, "Missing required parameter 'buildtargetid' when calling GetBuildLog");
            // verify the required parameter 'number' is set
            if (number == null) throw new ApiException(400, "Missing required parameter 'number' when calling GetBuildLog");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/buildtargets/{buildtargetid}/builds/{number}/log";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/plain", "text/html"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (orgid != null) pathParams.Add("orgid", Configuration.ApiClient.ParameterToString(orgid)); // path parameter
            if (projectid != null) pathParams.Add("projectid", Configuration.ApiClient.ParameterToString(projectid)); // path parameter
            if (buildtargetid != null) pathParams.Add("buildtargetid", Configuration.ApiClient.ParameterToString(buildtargetid)); // path parameter
            if (number != null) pathParams.Add("number", Configuration.ApiClient.ParameterToString(number)); // path parameter
            
            if (offsetlines != null) queryParams.Add("offsetlines", Configuration.ApiClient.ParameterToString(offsetlines)); // query parameter
            if (linenumbers != null) queryParams.Add("linenumbers", Configuration.ApiClient.ParameterToString(linenumbers)); // query parameter
            if (compact != null) queryParams.Add("compact", Configuration.ApiClient.ParameterToString(compact)); // query parameter
            if (withHtml != null) queryParams.Add("withHtml", Configuration.ApiClient.ParameterToString(withHtml)); // query parameter
            
            
            
            

            
            // authentication (apikey) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            
            // authentication (permissions) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetBuildLog: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetBuildLog: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get the share link Gets a share link if it exists
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param> 
        /// <param name="number">Build number or in some cases _all</param> 
        /// <returns>InlineResponse2004</returns>
        public InlineResponse2004 GetShare (string orgid, string projectid, string buildtargetid, string number)
        {
             ApiResponse<InlineResponse2004> response = GetShareWithHttpInfo(orgid, projectid, buildtargetid, number);
             return response.Data;
        }

        /// <summary>
        /// Get the share link Gets a share link if it exists
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param> 
        /// <param name="number">Build number or in some cases _all</param> 
        /// <returns>ApiResponse of InlineResponse2004</returns>
        public ApiResponse< InlineResponse2004 > GetShareWithHttpInfo (string orgid, string projectid, string buildtargetid, string number)
        {
            
            // verify the required parameter 'orgid' is set
            if (orgid == null)
                throw new ApiException(400, "Missing required parameter 'orgid' when calling BuildsApi->GetShare");
            
            // verify the required parameter 'projectid' is set
            if (projectid == null)
                throw new ApiException(400, "Missing required parameter 'projectid' when calling BuildsApi->GetShare");
            
            // verify the required parameter 'buildtargetid' is set
            if (buildtargetid == null)
                throw new ApiException(400, "Missing required parameter 'buildtargetid' when calling BuildsApi->GetShare");
            
            // verify the required parameter 'number' is set
            if (number == null)
                throw new ApiException(400, "Missing required parameter 'number' when calling BuildsApi->GetShare");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/buildtargets/{buildtargetid}/builds/{number}/share";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/plain", "text/html"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (orgid != null) pathParams.Add("orgid", Configuration.ApiClient.ParameterToString(orgid)); // path parameter
            if (projectid != null) pathParams.Add("projectid", Configuration.ApiClient.ParameterToString(projectid)); // path parameter
            if (buildtargetid != null) pathParams.Add("buildtargetid", Configuration.ApiClient.ParameterToString(buildtargetid)); // path parameter
            if (number != null) pathParams.Add("number", Configuration.ApiClient.ParameterToString(number)); // path parameter
            
            
            
            
            

            // authentication (apikey) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            // authentication (permissions) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetShare: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetShare: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2004>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2004) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2004)));
            
        }
    
        /// <summary>
        /// Get the share link Gets a share link if it exists
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <returns>Task of InlineResponse2004</returns>
        public async System.Threading.Tasks.Task<InlineResponse2004> GetShareAsync (string orgid, string projectid, string buildtargetid, string number)
        {
             ApiResponse<InlineResponse2004> response = await GetShareAsyncWithHttpInfo(orgid, projectid, buildtargetid, number);
             return response.Data;

        }

        /// <summary>
        /// Get the share link Gets a share link if it exists
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <returns>Task of ApiResponse (InlineResponse2004)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2004>> GetShareAsyncWithHttpInfo (string orgid, string projectid, string buildtargetid, string number)
        {
            // verify the required parameter 'orgid' is set
            if (orgid == null) throw new ApiException(400, "Missing required parameter 'orgid' when calling GetShare");
            // verify the required parameter 'projectid' is set
            if (projectid == null) throw new ApiException(400, "Missing required parameter 'projectid' when calling GetShare");
            // verify the required parameter 'buildtargetid' is set
            if (buildtargetid == null) throw new ApiException(400, "Missing required parameter 'buildtargetid' when calling GetShare");
            // verify the required parameter 'number' is set
            if (number == null) throw new ApiException(400, "Missing required parameter 'number' when calling GetShare");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/buildtargets/{buildtargetid}/builds/{number}/share";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/plain", "text/html"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (orgid != null) pathParams.Add("orgid", Configuration.ApiClient.ParameterToString(orgid)); // path parameter
            if (projectid != null) pathParams.Add("projectid", Configuration.ApiClient.ParameterToString(projectid)); // path parameter
            if (buildtargetid != null) pathParams.Add("buildtargetid", Configuration.ApiClient.ParameterToString(buildtargetid)); // path parameter
            if (number != null) pathParams.Add("number", Configuration.ApiClient.ParameterToString(number)); // path parameter
            
            
            
            
            

            
            // authentication (apikey) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            
            // authentication (permissions) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetShare: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetShare: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2004>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2004) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2004)));
            
        }
        
        /// <summary>
        /// Create a new link to share a project Create a new short link to share a project. If this is called when a share already exists, that share\nwill be revoked and a new one created.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param> 
        /// <param name="number">Build number or in some cases _all</param> 
        /// <returns>InlineResponse2004</returns>
        public InlineResponse2004 CreateShare (string orgid, string projectid, string buildtargetid, string number)
        {
             ApiResponse<InlineResponse2004> response = CreateShareWithHttpInfo(orgid, projectid, buildtargetid, number);
             return response.Data;
        }

        /// <summary>
        /// Create a new link to share a project Create a new short link to share a project. If this is called when a share already exists, that share\nwill be revoked and a new one created.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param> 
        /// <param name="number">Build number or in some cases _all</param> 
        /// <returns>ApiResponse of InlineResponse2004</returns>
        public ApiResponse< InlineResponse2004 > CreateShareWithHttpInfo (string orgid, string projectid, string buildtargetid, string number)
        {
            
            // verify the required parameter 'orgid' is set
            if (orgid == null)
                throw new ApiException(400, "Missing required parameter 'orgid' when calling BuildsApi->CreateShare");
            
            // verify the required parameter 'projectid' is set
            if (projectid == null)
                throw new ApiException(400, "Missing required parameter 'projectid' when calling BuildsApi->CreateShare");
            
            // verify the required parameter 'buildtargetid' is set
            if (buildtargetid == null)
                throw new ApiException(400, "Missing required parameter 'buildtargetid' when calling BuildsApi->CreateShare");
            
            // verify the required parameter 'number' is set
            if (number == null)
                throw new ApiException(400, "Missing required parameter 'number' when calling BuildsApi->CreateShare");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/buildtargets/{buildtargetid}/builds/{number}/share";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/plain", "text/html"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (orgid != null) pathParams.Add("orgid", Configuration.ApiClient.ParameterToString(orgid)); // path parameter
            if (projectid != null) pathParams.Add("projectid", Configuration.ApiClient.ParameterToString(projectid)); // path parameter
            if (buildtargetid != null) pathParams.Add("buildtargetid", Configuration.ApiClient.ParameterToString(buildtargetid)); // path parameter
            if (number != null) pathParams.Add("number", Configuration.ApiClient.ParameterToString(number)); // path parameter
            
            
            
            
            

            // authentication (apikey) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            // authentication (permissions) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateShare: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateShare: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2004>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2004) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2004)));
            
        }
    
        /// <summary>
        /// Create a new link to share a project Create a new short link to share a project. If this is called when a share already exists, that share\nwill be revoked and a new one created.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <returns>Task of InlineResponse2004</returns>
        public async System.Threading.Tasks.Task<InlineResponse2004> CreateShareAsync (string orgid, string projectid, string buildtargetid, string number)
        {
             ApiResponse<InlineResponse2004> response = await CreateShareAsyncWithHttpInfo(orgid, projectid, buildtargetid, number);
             return response.Data;

        }

        /// <summary>
        /// Create a new link to share a project Create a new short link to share a project. If this is called when a share already exists, that share\nwill be revoked and a new one created.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <returns>Task of ApiResponse (InlineResponse2004)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2004>> CreateShareAsyncWithHttpInfo (string orgid, string projectid, string buildtargetid, string number)
        {
            // verify the required parameter 'orgid' is set
            if (orgid == null) throw new ApiException(400, "Missing required parameter 'orgid' when calling CreateShare");
            // verify the required parameter 'projectid' is set
            if (projectid == null) throw new ApiException(400, "Missing required parameter 'projectid' when calling CreateShare");
            // verify the required parameter 'buildtargetid' is set
            if (buildtargetid == null) throw new ApiException(400, "Missing required parameter 'buildtargetid' when calling CreateShare");
            // verify the required parameter 'number' is set
            if (number == null) throw new ApiException(400, "Missing required parameter 'number' when calling CreateShare");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/buildtargets/{buildtargetid}/builds/{number}/share";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/plain", "text/html"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (orgid != null) pathParams.Add("orgid", Configuration.ApiClient.ParameterToString(orgid)); // path parameter
            if (projectid != null) pathParams.Add("projectid", Configuration.ApiClient.ParameterToString(projectid)); // path parameter
            if (buildtargetid != null) pathParams.Add("buildtargetid", Configuration.ApiClient.ParameterToString(buildtargetid)); // path parameter
            if (number != null) pathParams.Add("number", Configuration.ApiClient.ParameterToString(number)); // path parameter
            
            
            
            
            

            
            // authentication (apikey) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            
            // authentication (permissions) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateShare: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateShare: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2004>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2004) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2004)));
            
        }
        
        /// <summary>
        /// Revoke a shared link Revoke a shared link, both {buildtargetid} and {number} may use _all to revoke all share links for a given buildtarget or entire project.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param> 
        /// <param name="number">Build number or in some cases _all</param> 
        /// <returns>string</returns>
        public string RevokeShare (string orgid, string projectid, string buildtargetid, string number)
        {
             ApiResponse<string> response = RevokeShareWithHttpInfo(orgid, projectid, buildtargetid, number);
             return response.Data;
        }

        /// <summary>
        /// Revoke a shared link Revoke a shared link, both {buildtargetid} and {number} may use _all to revoke all share links for a given buildtarget or entire project.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param> 
        /// <param name="number">Build number or in some cases _all</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > RevokeShareWithHttpInfo (string orgid, string projectid, string buildtargetid, string number)
        {
            
            // verify the required parameter 'orgid' is set
            if (orgid == null)
                throw new ApiException(400, "Missing required parameter 'orgid' when calling BuildsApi->RevokeShare");
            
            // verify the required parameter 'projectid' is set
            if (projectid == null)
                throw new ApiException(400, "Missing required parameter 'projectid' when calling BuildsApi->RevokeShare");
            
            // verify the required parameter 'buildtargetid' is set
            if (buildtargetid == null)
                throw new ApiException(400, "Missing required parameter 'buildtargetid' when calling BuildsApi->RevokeShare");
            
            // verify the required parameter 'number' is set
            if (number == null)
                throw new ApiException(400, "Missing required parameter 'number' when calling BuildsApi->RevokeShare");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/buildtargets/{buildtargetid}/builds/{number}/share";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/plain", "text/html"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (orgid != null) pathParams.Add("orgid", Configuration.ApiClient.ParameterToString(orgid)); // path parameter
            if (projectid != null) pathParams.Add("projectid", Configuration.ApiClient.ParameterToString(projectid)); // path parameter
            if (buildtargetid != null) pathParams.Add("buildtargetid", Configuration.ApiClient.ParameterToString(buildtargetid)); // path parameter
            if (number != null) pathParams.Add("number", Configuration.ApiClient.ParameterToString(number)); // path parameter
            
            
            
            
            

            // authentication (apikey) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            // authentication (permissions) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling RevokeShare: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RevokeShare: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Revoke a shared link Revoke a shared link, both {buildtargetid} and {number} may use _all to revoke all share links for a given buildtarget or entire project.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> RevokeShareAsync (string orgid, string projectid, string buildtargetid, string number)
        {
             ApiResponse<string> response = await RevokeShareAsyncWithHttpInfo(orgid, projectid, buildtargetid, number);
             return response.Data;

        }

        /// <summary>
        /// Revoke a shared link Revoke a shared link, both {buildtargetid} and {number} may use _all to revoke all share links for a given buildtarget or entire project.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="number">Build number or in some cases _all</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> RevokeShareAsyncWithHttpInfo (string orgid, string projectid, string buildtargetid, string number)
        {
            // verify the required parameter 'orgid' is set
            if (orgid == null) throw new ApiException(400, "Missing required parameter 'orgid' when calling RevokeShare");
            // verify the required parameter 'projectid' is set
            if (projectid == null) throw new ApiException(400, "Missing required parameter 'projectid' when calling RevokeShare");
            // verify the required parameter 'buildtargetid' is set
            if (buildtargetid == null) throw new ApiException(400, "Missing required parameter 'buildtargetid' when calling RevokeShare");
            // verify the required parameter 'number' is set
            if (number == null) throw new ApiException(400, "Missing required parameter 'number' when calling RevokeShare");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/buildtargets/{buildtargetid}/builds/{number}/share";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/plain", "text/html"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (orgid != null) pathParams.Add("orgid", Configuration.ApiClient.ParameterToString(orgid)); // path parameter
            if (projectid != null) pathParams.Add("projectid", Configuration.ApiClient.ParameterToString(projectid)); // path parameter
            if (buildtargetid != null) pathParams.Add("buildtargetid", Configuration.ApiClient.ParameterToString(buildtargetid)); // path parameter
            if (number != null) pathParams.Add("number", Configuration.ApiClient.ParameterToString(number)); // path parameter
            
            
            
            
            

            
            // authentication (apikey) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            
            // authentication (permissions) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling RevokeShare: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RevokeShare: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Create polling jobs Create polling jobs for the specified buildtargetid (or all targets,\nif &#39;_all&#39; is specified as the buildtargetid). New builds will be\nsubsequently triggered for any build targets with changes detected.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param> 
        /// <returns>InlineResponse202</returns>
        public InlineResponse202 CreatePollingJobs (string orgid, string projectid, string buildtargetid)
        {
             ApiResponse<InlineResponse202> response = CreatePollingJobsWithHttpInfo(orgid, projectid, buildtargetid);
             return response.Data;
        }

        /// <summary>
        /// Create polling jobs Create polling jobs for the specified buildtargetid (or all targets,\nif &#39;_all&#39; is specified as the buildtargetid). New builds will be\nsubsequently triggered for any build targets with changes detected.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param> 
        /// <returns>ApiResponse of InlineResponse202</returns>
        public ApiResponse< InlineResponse202 > CreatePollingJobsWithHttpInfo (string orgid, string projectid, string buildtargetid)
        {
            
            // verify the required parameter 'orgid' is set
            if (orgid == null)
                throw new ApiException(400, "Missing required parameter 'orgid' when calling BuildsApi->CreatePollingJobs");
            
            // verify the required parameter 'projectid' is set
            if (projectid == null)
                throw new ApiException(400, "Missing required parameter 'projectid' when calling BuildsApi->CreatePollingJobs");
            
            // verify the required parameter 'buildtargetid' is set
            if (buildtargetid == null)
                throw new ApiException(400, "Missing required parameter 'buildtargetid' when calling BuildsApi->CreatePollingJobs");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/buildtargets/{buildtargetid}/polling";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/plain", "text/html"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (orgid != null) pathParams.Add("orgid", Configuration.ApiClient.ParameterToString(orgid)); // path parameter
            if (projectid != null) pathParams.Add("projectid", Configuration.ApiClient.ParameterToString(projectid)); // path parameter
            if (buildtargetid != null) pathParams.Add("buildtargetid", Configuration.ApiClient.ParameterToString(buildtargetid)); // path parameter
            
            
            
            
            

            // authentication (apikey) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            // authentication (permissions) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreatePollingJobs: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreatePollingJobs: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse202>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse202) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse202)));
            
        }
    
        /// <summary>
        /// Create polling jobs Create polling jobs for the specified buildtargetid (or all targets,\nif &#39;_all&#39; is specified as the buildtargetid). New builds will be\nsubsequently triggered for any build targets with changes detected.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <returns>Task of InlineResponse202</returns>
        public async System.Threading.Tasks.Task<InlineResponse202> CreatePollingJobsAsync (string orgid, string projectid, string buildtargetid)
        {
             ApiResponse<InlineResponse202> response = await CreatePollingJobsAsyncWithHttpInfo(orgid, projectid, buildtargetid);
             return response.Data;

        }

        /// <summary>
        /// Create polling jobs Create polling jobs for the specified buildtargetid (or all targets,\nif &#39;_all&#39; is specified as the buildtargetid). New builds will be\nsubsequently triggered for any build targets with changes detected.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <returns>Task of ApiResponse (InlineResponse202)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse202>> CreatePollingJobsAsyncWithHttpInfo (string orgid, string projectid, string buildtargetid)
        {
            // verify the required parameter 'orgid' is set
            if (orgid == null) throw new ApiException(400, "Missing required parameter 'orgid' when calling CreatePollingJobs");
            // verify the required parameter 'projectid' is set
            if (projectid == null) throw new ApiException(400, "Missing required parameter 'projectid' when calling CreatePollingJobs");
            // verify the required parameter 'buildtargetid' is set
            if (buildtargetid == null) throw new ApiException(400, "Missing required parameter 'buildtargetid' when calling CreatePollingJobs");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/buildtargets/{buildtargetid}/polling";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "text/plain", "text/html"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (orgid != null) pathParams.Add("orgid", Configuration.ApiClient.ParameterToString(orgid)); // path parameter
            if (projectid != null) pathParams.Add("projectid", Configuration.ApiClient.ParameterToString(projectid)); // path parameter
            if (buildtargetid != null) pathParams.Add("buildtargetid", Configuration.ApiClient.ParameterToString(buildtargetid)); // path parameter
            
            
            
            
            

            
            // authentication (apikey) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            
            // authentication (permissions) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreatePollingJobs: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreatePollingJobs: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse202>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse202) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse202)));
            
        }
        
    }
    
}

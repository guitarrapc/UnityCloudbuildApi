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
    public interface IProjectsApi
    {
        
        /// <summary>
        /// List all projects (org)
        /// </summary>
        /// <remarks>
        /// List all projects that belong to the specified organization. Add \&quot;?include=settings\&quot;\nas a query parameter to include the project settings with the response.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="include">Extra fields to include in the response</param>
        /// <returns>List&lt;InlineResponse2001&gt;</returns>
        List<InlineResponse2001> ListProjectsForOrg (string orgid, string include = null);
  
        /// <summary>
        /// List all projects (org)
        /// </summary>
        /// <remarks>
        /// List all projects that belong to the specified organization. Add \&quot;?include=settings\&quot;\nas a query parameter to include the project settings with the response.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="include">Extra fields to include in the response</param>
        /// <returns>ApiResponse of List&lt;InlineResponse2001&gt;</returns>
        ApiResponse<List<InlineResponse2001>> ListProjectsForOrgWithHttpInfo (string orgid, string include = null);

        /// <summary>
        /// List all projects (org)
        /// </summary>
        /// <remarks>
        /// List all projects that belong to the specified organization. Add \&quot;?include=settings\&quot;\nas a query parameter to include the project settings with the response.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="include">Extra fields to include in the response</param>
        /// <returns>Task of List&lt;InlineResponse2001&gt;</returns>
        System.Threading.Tasks.Task<List<InlineResponse2001>> ListProjectsForOrgAsync (string orgid, string include = null);

        /// <summary>
        /// List all projects (org)
        /// </summary>
        /// <remarks>
        /// List all projects that belong to the specified organization. Add \&quot;?include=settings\&quot;\nas a query parameter to include the project settings with the response.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="include">Extra fields to include in the response</param>
        /// <returns>Task of ApiResponse (List&lt;InlineResponse2001&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<InlineResponse2001>>> ListProjectsForOrgAsyncWithHttpInfo (string orgid, string include = null);
        
        /// <summary>
        /// Create project
        /// </summary>
        /// <remarks>
        /// Create a project for the specified organization
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="options">Options for project create/update</param>
        /// <returns>InlineResponse2001</returns>
        InlineResponse2001 AddProject (string orgid, Options options);
  
        /// <summary>
        /// Create project
        /// </summary>
        /// <remarks>
        /// Create a project for the specified organization
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="options">Options for project create/update</param>
        /// <returns>ApiResponse of InlineResponse2001</returns>
        ApiResponse<InlineResponse2001> AddProjectWithHttpInfo (string orgid, Options options);

        /// <summary>
        /// Create project
        /// </summary>
        /// <remarks>
        /// Create a project for the specified organization
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="options">Options for project create/update</param>
        /// <returns>Task of InlineResponse2001</returns>
        System.Threading.Tasks.Task<InlineResponse2001> AddProjectAsync (string orgid, Options options);

        /// <summary>
        /// Create project
        /// </summary>
        /// <remarks>
        /// Create a project for the specified organization
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="options">Options for project create/update</param>
        /// <returns>Task of ApiResponse (InlineResponse2001)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2001>> AddProjectAsyncWithHttpInfo (string orgid, Options options);
        
        /// <summary>
        /// Get project details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="include">Extra fields to include in the response</param>
        /// <returns>InlineResponse2001</returns>
        InlineResponse2001 GetProject (string orgid, string projectid, string include = null);
  
        /// <summary>
        /// Get project details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="include">Extra fields to include in the response</param>
        /// <returns>ApiResponse of InlineResponse2001</returns>
        ApiResponse<InlineResponse2001> GetProjectWithHttpInfo (string orgid, string projectid, string include = null);

        /// <summary>
        /// Get project details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="include">Extra fields to include in the response</param>
        /// <returns>Task of InlineResponse2001</returns>
        System.Threading.Tasks.Task<InlineResponse2001> GetProjectAsync (string orgid, string projectid, string include = null);

        /// <summary>
        /// Get project details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="include">Extra fields to include in the response</param>
        /// <returns>Task of ApiResponse (InlineResponse2001)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2001>> GetProjectAsyncWithHttpInfo (string orgid, string projectid, string include = null);
        
        /// <summary>
        /// Update project details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="options">Options for project create/update</param>
        /// <returns>InlineResponse2001</returns>
        InlineResponse2001 UpdateProject (string orgid, string projectid, Options1 options);
  
        /// <summary>
        /// Update project details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="options">Options for project create/update</param>
        /// <returns>ApiResponse of InlineResponse2001</returns>
        ApiResponse<InlineResponse2001> UpdateProjectWithHttpInfo (string orgid, string projectid, Options1 options);

        /// <summary>
        /// Update project details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="options">Options for project create/update</param>
        /// <returns>Task of InlineResponse2001</returns>
        System.Threading.Tasks.Task<InlineResponse2001> UpdateProjectAsync (string orgid, string projectid, Options1 options);

        /// <summary>
        /// Update project details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="options">Options for project create/update</param>
        /// <returns>Task of ApiResponse (InlineResponse2001)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2001>> UpdateProjectAsyncWithHttpInfo (string orgid, string projectid, Options1 options);
        
        /// <summary>
        /// Disable project
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>string</returns>
        string DisableProject (string orgid, string projectid);
  
        /// <summary>
        /// Disable project
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DisableProjectWithHttpInfo (string orgid, string projectid);

        /// <summary>
        /// Disable project
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DisableProjectAsync (string orgid, string projectid);

        /// <summary>
        /// Disable project
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DisableProjectAsyncWithHttpInfo (string orgid, string projectid);
        
        /// <summary>
        /// Get audit log
        /// </summary>
        /// <remarks>
        /// Retrieve a list of historical settings changes for this project
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="perPage">Number of audit log records to retrieve</param>
        /// <param name="page">Skip to page number, based on per_page value</param>
        /// <returns>List&lt;InlineResponse2002&gt;</returns>
        List<InlineResponse2002> GetAuditLog (string orgid, string projectid, double? perPage = null, double? page = null);
  
        /// <summary>
        /// Get audit log
        /// </summary>
        /// <remarks>
        /// Retrieve a list of historical settings changes for this project
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="perPage">Number of audit log records to retrieve</param>
        /// <param name="page">Skip to page number, based on per_page value</param>
        /// <returns>ApiResponse of List&lt;InlineResponse2002&gt;</returns>
        ApiResponse<List<InlineResponse2002>> GetAuditLogWithHttpInfo (string orgid, string projectid, double? perPage = null, double? page = null);

        /// <summary>
        /// Get audit log
        /// </summary>
        /// <remarks>
        /// Retrieve a list of historical settings changes for this project
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="perPage">Number of audit log records to retrieve</param>
        /// <param name="page">Skip to page number, based on per_page value</param>
        /// <returns>Task of List&lt;InlineResponse2002&gt;</returns>
        System.Threading.Tasks.Task<List<InlineResponse2002>> GetAuditLogAsync (string orgid, string projectid, double? perPage = null, double? page = null);

        /// <summary>
        /// Get audit log
        /// </summary>
        /// <remarks>
        /// Retrieve a list of historical settings changes for this project
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="perPage">Number of audit log records to retrieve</param>
        /// <param name="page">Skip to page number, based on per_page value</param>
        /// <returns>Task of ApiResponse (List&lt;InlineResponse2002&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<InlineResponse2002>>> GetAuditLogAsyncWithHttpInfo (string orgid, string projectid, double? perPage = null, double? page = null);
        
        /// <summary>
        /// Get billing plan
        /// </summary>
        /// <remarks>
        /// Get the billing plan for the specified project
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 GetBillingPlans (string orgid, string projectid);
  
        /// <summary>
        /// Get billing plan
        /// </summary>
        /// <remarks>
        /// Get the billing plan for the specified project
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>ApiResponse of InlineResponse200</returns>
        ApiResponse<InlineResponse200> GetBillingPlansWithHttpInfo (string orgid, string projectid);

        /// <summary>
        /// Get billing plan
        /// </summary>
        /// <remarks>
        /// Get the billing plan for the specified project
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>Task of InlineResponse200</returns>
        System.Threading.Tasks.Task<InlineResponse200> GetBillingPlansAsync (string orgid, string projectid);

        /// <summary>
        /// Get billing plan
        /// </summary>
        /// <remarks>
        /// Get the billing plan for the specified project
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> GetBillingPlansAsyncWithHttpInfo (string orgid, string projectid);
        
        /// <summary>
        /// Get SSH Key
        /// </summary>
        /// <remarks>
        /// Get the ssh public key for the specified project
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>InlineResponse2007</returns>
        InlineResponse2007 GetSSHKey (string orgid, string projectid);
  
        /// <summary>
        /// Get SSH Key
        /// </summary>
        /// <remarks>
        /// Get the ssh public key for the specified project
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>ApiResponse of InlineResponse2007</returns>
        ApiResponse<InlineResponse2007> GetSSHKeyWithHttpInfo (string orgid, string projectid);

        /// <summary>
        /// Get SSH Key
        /// </summary>
        /// <remarks>
        /// Get the ssh public key for the specified project
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>Task of InlineResponse2007</returns>
        System.Threading.Tasks.Task<InlineResponse2007> GetSSHKeyAsync (string orgid, string projectid);

        /// <summary>
        /// Get SSH Key
        /// </summary>
        /// <remarks>
        /// Get the ssh public key for the specified project
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>Task of ApiResponse (InlineResponse2007)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2007>> GetSSHKeyAsyncWithHttpInfo (string orgid, string projectid);
        
        /// <summary>
        /// Get project statistics
        /// </summary>
        /// <remarks>
        /// Get statistics for the specified project
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>InlineResponse2008</returns>
        InlineResponse2008 GetStats (string orgid, string projectid);
  
        /// <summary>
        /// Get project statistics
        /// </summary>
        /// <remarks>
        /// Get statistics for the specified project
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>ApiResponse of InlineResponse2008</returns>
        ApiResponse<InlineResponse2008> GetStatsWithHttpInfo (string orgid, string projectid);

        /// <summary>
        /// Get project statistics
        /// </summary>
        /// <remarks>
        /// Get statistics for the specified project
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>Task of InlineResponse2008</returns>
        System.Threading.Tasks.Task<InlineResponse2008> GetStatsAsync (string orgid, string projectid);

        /// <summary>
        /// Get project statistics
        /// </summary>
        /// <remarks>
        /// Get statistics for the specified project
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>Task of ApiResponse (InlineResponse2008)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2008>> GetStatsAsyncWithHttpInfo (string orgid, string projectid);
        
        /// <summary>
        /// List all users
        /// </summary>
        /// <remarks>
        /// List all users with access to the specified project
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>List&lt;InlineResponse2009&gt;</returns>
        List<InlineResponse2009> ListUsersForProject (string orgid, string projectid);
  
        /// <summary>
        /// List all users
        /// </summary>
        /// <remarks>
        /// List all users with access to the specified project
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>ApiResponse of List&lt;InlineResponse2009&gt;</returns>
        ApiResponse<List<InlineResponse2009>> ListUsersForProjectWithHttpInfo (string orgid, string projectid);

        /// <summary>
        /// List all users
        /// </summary>
        /// <remarks>
        /// List all users with access to the specified project
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>Task of List&lt;InlineResponse2009&gt;</returns>
        System.Threading.Tasks.Task<List<InlineResponse2009>> ListUsersForProjectAsync (string orgid, string projectid);

        /// <summary>
        /// List all users
        /// </summary>
        /// <remarks>
        /// List all users with access to the specified project
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>Task of ApiResponse (List&lt;InlineResponse2009&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<InlineResponse2009>>> ListUsersForProjectAsyncWithHttpInfo (string orgid, string projectid);
        
        /// <summary>
        /// Grant user access
        /// </summary>
        /// <remarks>
        /// Grant the specified user access to the specified project
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="options"></param>
        /// <returns>InlineResponse2009</returns>
        InlineResponse2009 AddUserToProject (string orgid, string projectid, Options5 options = null);
  
        /// <summary>
        /// Grant user access
        /// </summary>
        /// <remarks>
        /// Grant the specified user access to the specified project
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="options"></param>
        /// <returns>ApiResponse of InlineResponse2009</returns>
        ApiResponse<InlineResponse2009> AddUserToProjectWithHttpInfo (string orgid, string projectid, Options5 options = null);

        /// <summary>
        /// Grant user access
        /// </summary>
        /// <remarks>
        /// Grant the specified user access to the specified project
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="options"></param>
        /// <returns>Task of InlineResponse2009</returns>
        System.Threading.Tasks.Task<InlineResponse2009> AddUserToProjectAsync (string orgid, string projectid, Options5 options = null);

        /// <summary>
        /// Grant user access
        /// </summary>
        /// <remarks>
        /// Grant the specified user access to the specified project
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="options"></param>
        /// <returns>Task of ApiResponse (InlineResponse2009)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2009>> AddUserToProjectAsyncWithHttpInfo (string orgid, string projectid, Options5 options = null);
        
        /// <summary>
        /// Revoke user access
        /// </summary>
        /// <remarks>
        /// Revoke access to the specified project from the specified user
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="email"></param>
        /// <returns>string</returns>
        string RemoveUserFromProject (string orgid, string projectid, string email);
  
        /// <summary>
        /// Revoke user access
        /// </summary>
        /// <remarks>
        /// Revoke access to the specified project from the specified user
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="email"></param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> RemoveUserFromProjectWithHttpInfo (string orgid, string projectid, string email);

        /// <summary>
        /// Revoke user access
        /// </summary>
        /// <remarks>
        /// Revoke access to the specified project from the specified user
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="email"></param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> RemoveUserFromProjectAsync (string orgid, string projectid, string email);

        /// <summary>
        /// Revoke user access
        /// </summary>
        /// <remarks>
        /// Revoke access to the specified project from the specified user
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="email"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> RemoveUserFromProjectAsyncWithHttpInfo (string orgid, string projectid, string email);
        
        /// <summary>
        /// List all projects (user)
        /// </summary>
        /// <remarks>
        /// List all projects that you have permission to access across all organizations. Add \&quot;?include=settings\&quot;\nas a query parameter to include the project settings with the response.
        /// </remarks>
        /// <param name="include">Extra fields to include in the response</param>
        /// <returns>List&lt;InlineResponse2001&gt;</returns>
        List<InlineResponse2001> ListProjectsForUser (string include = null);
  
        /// <summary>
        /// List all projects (user)
        /// </summary>
        /// <remarks>
        /// List all projects that you have permission to access across all organizations. Add \&quot;?include=settings\&quot;\nas a query parameter to include the project settings with the response.
        /// </remarks>
        /// <param name="include">Extra fields to include in the response</param>
        /// <returns>ApiResponse of List&lt;InlineResponse2001&gt;</returns>
        ApiResponse<List<InlineResponse2001>> ListProjectsForUserWithHttpInfo (string include = null);

        /// <summary>
        /// List all projects (user)
        /// </summary>
        /// <remarks>
        /// List all projects that you have permission to access across all organizations. Add \&quot;?include=settings\&quot;\nas a query parameter to include the project settings with the response.
        /// </remarks>
        /// <param name="include">Extra fields to include in the response</param>
        /// <returns>Task of List&lt;InlineResponse2001&gt;</returns>
        System.Threading.Tasks.Task<List<InlineResponse2001>> ListProjectsForUserAsync (string include = null);

        /// <summary>
        /// List all projects (user)
        /// </summary>
        /// <remarks>
        /// List all projects that you have permission to access across all organizations. Add \&quot;?include=settings\&quot;\nas a query parameter to include the project settings with the response.
        /// </remarks>
        /// <param name="include">Extra fields to include in the response</param>
        /// <returns>Task of ApiResponse (List&lt;InlineResponse2001&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<InlineResponse2001>>> ListProjectsForUserAsyncWithHttpInfo (string include = null);
        
        /// <summary>
        /// Get project details
        /// </summary>
        /// <remarks>
        /// Gets the same data as /orgs/{orgid}/project/{projectid} but looks up the project by the Unity Project ID. This\nvalue is returned in the project&#39;s guid field.
        /// </remarks>
        /// <param name="projectupid">Project UPID - Unity global id</param>
        /// <returns>InlineResponse2001</returns>
        InlineResponse2001 GetProjectByUpid (string projectupid);
  
        /// <summary>
        /// Get project details
        /// </summary>
        /// <remarks>
        /// Gets the same data as /orgs/{orgid}/project/{projectid} but looks up the project by the Unity Project ID. This\nvalue is returned in the project&#39;s guid field.
        /// </remarks>
        /// <param name="projectupid">Project UPID - Unity global id</param>
        /// <returns>ApiResponse of InlineResponse2001</returns>
        ApiResponse<InlineResponse2001> GetProjectByUpidWithHttpInfo (string projectupid);

        /// <summary>
        /// Get project details
        /// </summary>
        /// <remarks>
        /// Gets the same data as /orgs/{orgid}/project/{projectid} but looks up the project by the Unity Project ID. This\nvalue is returned in the project&#39;s guid field.
        /// </remarks>
        /// <param name="projectupid">Project UPID - Unity global id</param>
        /// <returns>Task of InlineResponse2001</returns>
        System.Threading.Tasks.Task<InlineResponse2001> GetProjectByUpidAsync (string projectupid);

        /// <summary>
        /// Get project details
        /// </summary>
        /// <remarks>
        /// Gets the same data as /orgs/{orgid}/project/{projectid} but looks up the project by the Unity Project ID. This\nvalue is returned in the project&#39;s guid field.
        /// </remarks>
        /// <param name="projectupid">Project UPID - Unity global id</param>
        /// <returns>Task of ApiResponse (InlineResponse2001)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2001>> GetProjectByUpidAsyncWithHttpInfo (string projectupid);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ProjectsApi : IProjectsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProjectsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ProjectsApi(Configuration configuration = null)
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
        /// List all projects (org) List all projects that belong to the specified organization. Add \&quot;?include=settings\&quot;\nas a query parameter to include the project settings with the response.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="include">Extra fields to include in the response</param> 
        /// <returns>List&lt;InlineResponse2001&gt;</returns>
        public List<InlineResponse2001> ListProjectsForOrg (string orgid, string include = null)
        {
             ApiResponse<List<InlineResponse2001>> response = ListProjectsForOrgWithHttpInfo(orgid, include);
             return response.Data;
        }

        /// <summary>
        /// List all projects (org) List all projects that belong to the specified organization. Add \&quot;?include=settings\&quot;\nas a query parameter to include the project settings with the response.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="include">Extra fields to include in the response</param> 
        /// <returns>ApiResponse of List&lt;InlineResponse2001&gt;</returns>
        public ApiResponse< List<InlineResponse2001> > ListProjectsForOrgWithHttpInfo (string orgid, string include = null)
        {
            
            // verify the required parameter 'orgid' is set
            if (orgid == null)
                throw new ApiException(400, "Missing required parameter 'orgid' when calling ProjectsApi->ListProjectsForOrg");
            
    
            var path_ = "/orgs/{orgid}/projects";
    
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
                throw new ApiException (statusCode, "Error calling ListProjectsForOrg: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListProjectsForOrg: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<InlineResponse2001>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InlineResponse2001>) Configuration.ApiClient.Deserialize(response, typeof(List<InlineResponse2001>)));
            
        }
    
        /// <summary>
        /// List all projects (org) List all projects that belong to the specified organization. Add \&quot;?include=settings\&quot;\nas a query parameter to include the project settings with the response.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="include">Extra fields to include in the response</param>
        /// <returns>Task of List&lt;InlineResponse2001&gt;</returns>
        public async System.Threading.Tasks.Task<List<InlineResponse2001>> ListProjectsForOrgAsync (string orgid, string include = null)
        {
             ApiResponse<List<InlineResponse2001>> response = await ListProjectsForOrgAsyncWithHttpInfo(orgid, include);
             return response.Data;

        }

        /// <summary>
        /// List all projects (org) List all projects that belong to the specified organization. Add \&quot;?include=settings\&quot;\nas a query parameter to include the project settings with the response.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="include">Extra fields to include in the response</param>
        /// <returns>Task of ApiResponse (List&lt;InlineResponse2001&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<InlineResponse2001>>> ListProjectsForOrgAsyncWithHttpInfo (string orgid, string include = null)
        {
            // verify the required parameter 'orgid' is set
            if (orgid == null) throw new ApiException(400, "Missing required parameter 'orgid' when calling ListProjectsForOrg");
            
    
            var path_ = "/orgs/{orgid}/projects";
    
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
                throw new ApiException (statusCode, "Error calling ListProjectsForOrg: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListProjectsForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<InlineResponse2001>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InlineResponse2001>) Configuration.ApiClient.Deserialize(response, typeof(List<InlineResponse2001>)));
            
        }
        
        /// <summary>
        /// Create project Create a project for the specified organization
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="options">Options for project create/update</param> 
        /// <returns>InlineResponse2001</returns>
        public InlineResponse2001 AddProject (string orgid, Options options)
        {
             ApiResponse<InlineResponse2001> response = AddProjectWithHttpInfo(orgid, options);
             return response.Data;
        }

        /// <summary>
        /// Create project Create a project for the specified organization
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="options">Options for project create/update</param> 
        /// <returns>ApiResponse of InlineResponse2001</returns>
        public ApiResponse< InlineResponse2001 > AddProjectWithHttpInfo (string orgid, Options options)
        {
            
            // verify the required parameter 'orgid' is set
            if (orgid == null)
                throw new ApiException(400, "Missing required parameter 'orgid' when calling ProjectsApi->AddProject");
            
            // verify the required parameter 'options' is set
            if (options == null)
                throw new ApiException(400, "Missing required parameter 'options' when calling ProjectsApi->AddProject");
            
    
            var path_ = "/orgs/{orgid}/projects";
    
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
                throw new ApiException (statusCode, "Error calling AddProject: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AddProject: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2001>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2001) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2001)));
            
        }
    
        /// <summary>
        /// Create project Create a project for the specified organization
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="options">Options for project create/update</param>
        /// <returns>Task of InlineResponse2001</returns>
        public async System.Threading.Tasks.Task<InlineResponse2001> AddProjectAsync (string orgid, Options options)
        {
             ApiResponse<InlineResponse2001> response = await AddProjectAsyncWithHttpInfo(orgid, options);
             return response.Data;

        }

        /// <summary>
        /// Create project Create a project for the specified organization
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="options">Options for project create/update</param>
        /// <returns>Task of ApiResponse (InlineResponse2001)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2001>> AddProjectAsyncWithHttpInfo (string orgid, Options options)
        {
            // verify the required parameter 'orgid' is set
            if (orgid == null) throw new ApiException(400, "Missing required parameter 'orgid' when calling AddProject");
            // verify the required parameter 'options' is set
            if (options == null) throw new ApiException(400, "Missing required parameter 'options' when calling AddProject");
            
    
            var path_ = "/orgs/{orgid}/projects";
    
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
                throw new ApiException (statusCode, "Error calling AddProject: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AddProject: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2001>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2001) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2001)));
            
        }
        
        /// <summary>
        /// Get project details 
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="include">Extra fields to include in the response</param> 
        /// <returns>InlineResponse2001</returns>
        public InlineResponse2001 GetProject (string orgid, string projectid, string include = null)
        {
             ApiResponse<InlineResponse2001> response = GetProjectWithHttpInfo(orgid, projectid, include);
             return response.Data;
        }

        /// <summary>
        /// Get project details 
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="include">Extra fields to include in the response</param> 
        /// <returns>ApiResponse of InlineResponse2001</returns>
        public ApiResponse< InlineResponse2001 > GetProjectWithHttpInfo (string orgid, string projectid, string include = null)
        {
            
            // verify the required parameter 'orgid' is set
            if (orgid == null)
                throw new ApiException(400, "Missing required parameter 'orgid' when calling ProjectsApi->GetProject");
            
            // verify the required parameter 'projectid' is set
            if (projectid == null)
                throw new ApiException(400, "Missing required parameter 'projectid' when calling ProjectsApi->GetProject");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}";
    
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
                throw new ApiException (statusCode, "Error calling GetProject: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProject: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2001>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2001) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2001)));
            
        }
    
        /// <summary>
        /// Get project details 
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="include">Extra fields to include in the response</param>
        /// <returns>Task of InlineResponse2001</returns>
        public async System.Threading.Tasks.Task<InlineResponse2001> GetProjectAsync (string orgid, string projectid, string include = null)
        {
             ApiResponse<InlineResponse2001> response = await GetProjectAsyncWithHttpInfo(orgid, projectid, include);
             return response.Data;

        }

        /// <summary>
        /// Get project details 
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="include">Extra fields to include in the response</param>
        /// <returns>Task of ApiResponse (InlineResponse2001)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2001>> GetProjectAsyncWithHttpInfo (string orgid, string projectid, string include = null)
        {
            // verify the required parameter 'orgid' is set
            if (orgid == null) throw new ApiException(400, "Missing required parameter 'orgid' when calling GetProject");
            // verify the required parameter 'projectid' is set
            if (projectid == null) throw new ApiException(400, "Missing required parameter 'projectid' when calling GetProject");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}";
    
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
                throw new ApiException (statusCode, "Error calling GetProject: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProject: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2001>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2001) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2001)));
            
        }
        
        /// <summary>
        /// Update project details 
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="options">Options for project create/update</param> 
        /// <returns>InlineResponse2001</returns>
        public InlineResponse2001 UpdateProject (string orgid, string projectid, Options1 options)
        {
             ApiResponse<InlineResponse2001> response = UpdateProjectWithHttpInfo(orgid, projectid, options);
             return response.Data;
        }

        /// <summary>
        /// Update project details 
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="options">Options for project create/update</param> 
        /// <returns>ApiResponse of InlineResponse2001</returns>
        public ApiResponse< InlineResponse2001 > UpdateProjectWithHttpInfo (string orgid, string projectid, Options1 options)
        {
            
            // verify the required parameter 'orgid' is set
            if (orgid == null)
                throw new ApiException(400, "Missing required parameter 'orgid' when calling ProjectsApi->UpdateProject");
            
            // verify the required parameter 'projectid' is set
            if (projectid == null)
                throw new ApiException(400, "Missing required parameter 'projectid' when calling ProjectsApi->UpdateProject");
            
            // verify the required parameter 'options' is set
            if (options == null)
                throw new ApiException(400, "Missing required parameter 'options' when calling ProjectsApi->UpdateProject");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}";
    
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
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateProject: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateProject: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2001>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2001) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2001)));
            
        }
    
        /// <summary>
        /// Update project details 
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="options">Options for project create/update</param>
        /// <returns>Task of InlineResponse2001</returns>
        public async System.Threading.Tasks.Task<InlineResponse2001> UpdateProjectAsync (string orgid, string projectid, Options1 options)
        {
             ApiResponse<InlineResponse2001> response = await UpdateProjectAsyncWithHttpInfo(orgid, projectid, options);
             return response.Data;

        }

        /// <summary>
        /// Update project details 
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="options">Options for project create/update</param>
        /// <returns>Task of ApiResponse (InlineResponse2001)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2001>> UpdateProjectAsyncWithHttpInfo (string orgid, string projectid, Options1 options)
        {
            // verify the required parameter 'orgid' is set
            if (orgid == null) throw new ApiException(400, "Missing required parameter 'orgid' when calling UpdateProject");
            // verify the required parameter 'projectid' is set
            if (projectid == null) throw new ApiException(400, "Missing required parameter 'projectid' when calling UpdateProject");
            // verify the required parameter 'options' is set
            if (options == null) throw new ApiException(400, "Missing required parameter 'options' when calling UpdateProject");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}";
    
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
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateProject: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateProject: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2001>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2001) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2001)));
            
        }
        
        /// <summary>
        /// Disable project 
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <returns>string</returns>
        public string DisableProject (string orgid, string projectid)
        {
             ApiResponse<string> response = DisableProjectWithHttpInfo(orgid, projectid);
             return response.Data;
        }

        /// <summary>
        /// Disable project 
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DisableProjectWithHttpInfo (string orgid, string projectid)
        {
            
            // verify the required parameter 'orgid' is set
            if (orgid == null)
                throw new ApiException(400, "Missing required parameter 'orgid' when calling ProjectsApi->DisableProject");
            
            // verify the required parameter 'projectid' is set
            if (projectid == null)
                throw new ApiException(400, "Missing required parameter 'projectid' when calling ProjectsApi->DisableProject");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}";
    
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
                throw new ApiException (statusCode, "Error calling DisableProject: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DisableProject: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Disable project 
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DisableProjectAsync (string orgid, string projectid)
        {
             ApiResponse<string> response = await DisableProjectAsyncWithHttpInfo(orgid, projectid);
             return response.Data;

        }

        /// <summary>
        /// Disable project 
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DisableProjectAsyncWithHttpInfo (string orgid, string projectid)
        {
            // verify the required parameter 'orgid' is set
            if (orgid == null) throw new ApiException(400, "Missing required parameter 'orgid' when calling DisableProject");
            // verify the required parameter 'projectid' is set
            if (projectid == null) throw new ApiException(400, "Missing required parameter 'projectid' when calling DisableProject");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}";
    
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
                throw new ApiException (statusCode, "Error calling DisableProject: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DisableProject: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get audit log Retrieve a list of historical settings changes for this project
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="perPage">Number of audit log records to retrieve</param> 
        /// <param name="page">Skip to page number, based on per_page value</param> 
        /// <returns>List&lt;InlineResponse2002&gt;</returns>
        public List<InlineResponse2002> GetAuditLog (string orgid, string projectid, double? perPage = null, double? page = null)
        {
             ApiResponse<List<InlineResponse2002>> response = GetAuditLogWithHttpInfo(orgid, projectid, perPage, page);
             return response.Data;
        }

        /// <summary>
        /// Get audit log Retrieve a list of historical settings changes for this project
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="perPage">Number of audit log records to retrieve</param> 
        /// <param name="page">Skip to page number, based on per_page value</param> 
        /// <returns>ApiResponse of List&lt;InlineResponse2002&gt;</returns>
        public ApiResponse< List<InlineResponse2002> > GetAuditLogWithHttpInfo (string orgid, string projectid, double? perPage = null, double? page = null)
        {
            
            // verify the required parameter 'orgid' is set
            if (orgid == null)
                throw new ApiException(400, "Missing required parameter 'orgid' when calling ProjectsApi->GetAuditLog");
            
            // verify the required parameter 'projectid' is set
            if (projectid == null)
                throw new ApiException(400, "Missing required parameter 'projectid' when calling ProjectsApi->GetAuditLog");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/auditlog";
    
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
        /// Get audit log Retrieve a list of historical settings changes for this project
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="perPage">Number of audit log records to retrieve</param>
        /// <param name="page">Skip to page number, based on per_page value</param>
        /// <returns>Task of List&lt;InlineResponse2002&gt;</returns>
        public async System.Threading.Tasks.Task<List<InlineResponse2002>> GetAuditLogAsync (string orgid, string projectid, double? perPage = null, double? page = null)
        {
             ApiResponse<List<InlineResponse2002>> response = await GetAuditLogAsyncWithHttpInfo(orgid, projectid, perPage, page);
             return response.Data;

        }

        /// <summary>
        /// Get audit log Retrieve a list of historical settings changes for this project
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="perPage">Number of audit log records to retrieve</param>
        /// <param name="page">Skip to page number, based on per_page value</param>
        /// <returns>Task of ApiResponse (List&lt;InlineResponse2002&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<InlineResponse2002>>> GetAuditLogAsyncWithHttpInfo (string orgid, string projectid, double? perPage = null, double? page = null)
        {
            // verify the required parameter 'orgid' is set
            if (orgid == null) throw new ApiException(400, "Missing required parameter 'orgid' when calling GetAuditLog");
            // verify the required parameter 'projectid' is set
            if (projectid == null) throw new ApiException(400, "Missing required parameter 'projectid' when calling GetAuditLog");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/auditlog";
    
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
        /// Get billing plan Get the billing plan for the specified project
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <returns>InlineResponse200</returns>
        public InlineResponse200 GetBillingPlans (string orgid, string projectid)
        {
             ApiResponse<InlineResponse200> response = GetBillingPlansWithHttpInfo(orgid, projectid);
             return response.Data;
        }

        /// <summary>
        /// Get billing plan Get the billing plan for the specified project
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <returns>ApiResponse of InlineResponse200</returns>
        public ApiResponse< InlineResponse200 > GetBillingPlansWithHttpInfo (string orgid, string projectid)
        {
            
            // verify the required parameter 'orgid' is set
            if (orgid == null)
                throw new ApiException(400, "Missing required parameter 'orgid' when calling ProjectsApi->GetBillingPlans");
            
            // verify the required parameter 'projectid' is set
            if (projectid == null)
                throw new ApiException(400, "Missing required parameter 'projectid' when calling ProjectsApi->GetBillingPlans");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/billingplan";
    
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
                throw new ApiException (statusCode, "Error calling GetBillingPlans: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetBillingPlans: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse200>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse200) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse200)));
            
        }
    
        /// <summary>
        /// Get billing plan Get the billing plan for the specified project
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>Task of InlineResponse200</returns>
        public async System.Threading.Tasks.Task<InlineResponse200> GetBillingPlansAsync (string orgid, string projectid)
        {
             ApiResponse<InlineResponse200> response = await GetBillingPlansAsyncWithHttpInfo(orgid, projectid);
             return response.Data;

        }

        /// <summary>
        /// Get billing plan Get the billing plan for the specified project
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> GetBillingPlansAsyncWithHttpInfo (string orgid, string projectid)
        {
            // verify the required parameter 'orgid' is set
            if (orgid == null) throw new ApiException(400, "Missing required parameter 'orgid' when calling GetBillingPlans");
            // verify the required parameter 'projectid' is set
            if (projectid == null) throw new ApiException(400, "Missing required parameter 'projectid' when calling GetBillingPlans");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/billingplan";
    
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
                throw new ApiException (statusCode, "Error calling GetBillingPlans: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetBillingPlans: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse200>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse200) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse200)));
            
        }
        
        /// <summary>
        /// Get SSH Key Get the ssh public key for the specified project
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <returns>InlineResponse2007</returns>
        public InlineResponse2007 GetSSHKey (string orgid, string projectid)
        {
             ApiResponse<InlineResponse2007> response = GetSSHKeyWithHttpInfo(orgid, projectid);
             return response.Data;
        }

        /// <summary>
        /// Get SSH Key Get the ssh public key for the specified project
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <returns>ApiResponse of InlineResponse2007</returns>
        public ApiResponse< InlineResponse2007 > GetSSHKeyWithHttpInfo (string orgid, string projectid)
        {
            
            // verify the required parameter 'orgid' is set
            if (orgid == null)
                throw new ApiException(400, "Missing required parameter 'orgid' when calling ProjectsApi->GetSSHKey");
            
            // verify the required parameter 'projectid' is set
            if (projectid == null)
                throw new ApiException(400, "Missing required parameter 'projectid' when calling ProjectsApi->GetSSHKey");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/sshkey";
    
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
                throw new ApiException (statusCode, "Error calling GetSSHKey: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSSHKey: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2007>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2007) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2007)));
            
        }
    
        /// <summary>
        /// Get SSH Key Get the ssh public key for the specified project
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>Task of InlineResponse2007</returns>
        public async System.Threading.Tasks.Task<InlineResponse2007> GetSSHKeyAsync (string orgid, string projectid)
        {
             ApiResponse<InlineResponse2007> response = await GetSSHKeyAsyncWithHttpInfo(orgid, projectid);
             return response.Data;

        }

        /// <summary>
        /// Get SSH Key Get the ssh public key for the specified project
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>Task of ApiResponse (InlineResponse2007)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2007>> GetSSHKeyAsyncWithHttpInfo (string orgid, string projectid)
        {
            // verify the required parameter 'orgid' is set
            if (orgid == null) throw new ApiException(400, "Missing required parameter 'orgid' when calling GetSSHKey");
            // verify the required parameter 'projectid' is set
            if (projectid == null) throw new ApiException(400, "Missing required parameter 'projectid' when calling GetSSHKey");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/sshkey";
    
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
                throw new ApiException (statusCode, "Error calling GetSSHKey: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSSHKey: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2007>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2007) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2007)));
            
        }
        
        /// <summary>
        /// Get project statistics Get statistics for the specified project
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <returns>InlineResponse2008</returns>
        public InlineResponse2008 GetStats (string orgid, string projectid)
        {
             ApiResponse<InlineResponse2008> response = GetStatsWithHttpInfo(orgid, projectid);
             return response.Data;
        }

        /// <summary>
        /// Get project statistics Get statistics for the specified project
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <returns>ApiResponse of InlineResponse2008</returns>
        public ApiResponse< InlineResponse2008 > GetStatsWithHttpInfo (string orgid, string projectid)
        {
            
            // verify the required parameter 'orgid' is set
            if (orgid == null)
                throw new ApiException(400, "Missing required parameter 'orgid' when calling ProjectsApi->GetStats");
            
            // verify the required parameter 'projectid' is set
            if (projectid == null)
                throw new ApiException(400, "Missing required parameter 'projectid' when calling ProjectsApi->GetStats");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/stats";
    
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
                throw new ApiException (statusCode, "Error calling GetStats: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetStats: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2008>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2008) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2008)));
            
        }
    
        /// <summary>
        /// Get project statistics Get statistics for the specified project
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>Task of InlineResponse2008</returns>
        public async System.Threading.Tasks.Task<InlineResponse2008> GetStatsAsync (string orgid, string projectid)
        {
             ApiResponse<InlineResponse2008> response = await GetStatsAsyncWithHttpInfo(orgid, projectid);
             return response.Data;

        }

        /// <summary>
        /// Get project statistics Get statistics for the specified project
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>Task of ApiResponse (InlineResponse2008)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2008>> GetStatsAsyncWithHttpInfo (string orgid, string projectid)
        {
            // verify the required parameter 'orgid' is set
            if (orgid == null) throw new ApiException(400, "Missing required parameter 'orgid' when calling GetStats");
            // verify the required parameter 'projectid' is set
            if (projectid == null) throw new ApiException(400, "Missing required parameter 'projectid' when calling GetStats");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/stats";
    
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
                throw new ApiException (statusCode, "Error calling GetStats: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetStats: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2008>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2008) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2008)));
            
        }
        
        /// <summary>
        /// List all users List all users with access to the specified project
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <returns>List&lt;InlineResponse2009&gt;</returns>
        public List<InlineResponse2009> ListUsersForProject (string orgid, string projectid)
        {
             ApiResponse<List<InlineResponse2009>> response = ListUsersForProjectWithHttpInfo(orgid, projectid);
             return response.Data;
        }

        /// <summary>
        /// List all users List all users with access to the specified project
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <returns>ApiResponse of List&lt;InlineResponse2009&gt;</returns>
        public ApiResponse< List<InlineResponse2009> > ListUsersForProjectWithHttpInfo (string orgid, string projectid)
        {
            
            // verify the required parameter 'orgid' is set
            if (orgid == null)
                throw new ApiException(400, "Missing required parameter 'orgid' when calling ProjectsApi->ListUsersForProject");
            
            // verify the required parameter 'projectid' is set
            if (projectid == null)
                throw new ApiException(400, "Missing required parameter 'projectid' when calling ProjectsApi->ListUsersForProject");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/users";
    
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
                throw new ApiException (statusCode, "Error calling ListUsersForProject: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListUsersForProject: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<InlineResponse2009>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InlineResponse2009>) Configuration.ApiClient.Deserialize(response, typeof(List<InlineResponse2009>)));
            
        }
    
        /// <summary>
        /// List all users List all users with access to the specified project
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>Task of List&lt;InlineResponse2009&gt;</returns>
        public async System.Threading.Tasks.Task<List<InlineResponse2009>> ListUsersForProjectAsync (string orgid, string projectid)
        {
             ApiResponse<List<InlineResponse2009>> response = await ListUsersForProjectAsyncWithHttpInfo(orgid, projectid);
             return response.Data;

        }

        /// <summary>
        /// List all users List all users with access to the specified project
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>Task of ApiResponse (List&lt;InlineResponse2009&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<InlineResponse2009>>> ListUsersForProjectAsyncWithHttpInfo (string orgid, string projectid)
        {
            // verify the required parameter 'orgid' is set
            if (orgid == null) throw new ApiException(400, "Missing required parameter 'orgid' when calling ListUsersForProject");
            // verify the required parameter 'projectid' is set
            if (projectid == null) throw new ApiException(400, "Missing required parameter 'projectid' when calling ListUsersForProject");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/users";
    
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
                throw new ApiException (statusCode, "Error calling ListUsersForProject: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListUsersForProject: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<InlineResponse2009>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InlineResponse2009>) Configuration.ApiClient.Deserialize(response, typeof(List<InlineResponse2009>)));
            
        }
        
        /// <summary>
        /// Grant user access Grant the specified user access to the specified project
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="options"></param> 
        /// <returns>InlineResponse2009</returns>
        public InlineResponse2009 AddUserToProject (string orgid, string projectid, Options5 options = null)
        {
             ApiResponse<InlineResponse2009> response = AddUserToProjectWithHttpInfo(orgid, projectid, options);
             return response.Data;
        }

        /// <summary>
        /// Grant user access Grant the specified user access to the specified project
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="options"></param> 
        /// <returns>ApiResponse of InlineResponse2009</returns>
        public ApiResponse< InlineResponse2009 > AddUserToProjectWithHttpInfo (string orgid, string projectid, Options5 options = null)
        {
            
            // verify the required parameter 'orgid' is set
            if (orgid == null)
                throw new ApiException(400, "Missing required parameter 'orgid' when calling ProjectsApi->AddUserToProject");
            
            // verify the required parameter 'projectid' is set
            if (projectid == null)
                throw new ApiException(400, "Missing required parameter 'projectid' when calling ProjectsApi->AddUserToProject");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/users";
    
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
                throw new ApiException (statusCode, "Error calling AddUserToProject: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AddUserToProject: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2009>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2009) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2009)));
            
        }
    
        /// <summary>
        /// Grant user access Grant the specified user access to the specified project
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="options"></param>
        /// <returns>Task of InlineResponse2009</returns>
        public async System.Threading.Tasks.Task<InlineResponse2009> AddUserToProjectAsync (string orgid, string projectid, Options5 options = null)
        {
             ApiResponse<InlineResponse2009> response = await AddUserToProjectAsyncWithHttpInfo(orgid, projectid, options);
             return response.Data;

        }

        /// <summary>
        /// Grant user access Grant the specified user access to the specified project
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="options"></param>
        /// <returns>Task of ApiResponse (InlineResponse2009)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2009>> AddUserToProjectAsyncWithHttpInfo (string orgid, string projectid, Options5 options = null)
        {
            // verify the required parameter 'orgid' is set
            if (orgid == null) throw new ApiException(400, "Missing required parameter 'orgid' when calling AddUserToProject");
            // verify the required parameter 'projectid' is set
            if (projectid == null) throw new ApiException(400, "Missing required parameter 'projectid' when calling AddUserToProject");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/users";
    
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
                throw new ApiException (statusCode, "Error calling AddUserToProject: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AddUserToProject: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2009>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2009) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2009)));
            
        }
        
        /// <summary>
        /// Revoke user access Revoke access to the specified project from the specified user
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="email"></param> 
        /// <returns>string</returns>
        public string RemoveUserFromProject (string orgid, string projectid, string email)
        {
             ApiResponse<string> response = RemoveUserFromProjectWithHttpInfo(orgid, projectid, email);
             return response.Data;
        }

        /// <summary>
        /// Revoke user access Revoke access to the specified project from the specified user
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="email"></param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > RemoveUserFromProjectWithHttpInfo (string orgid, string projectid, string email)
        {
            
            // verify the required parameter 'orgid' is set
            if (orgid == null)
                throw new ApiException(400, "Missing required parameter 'orgid' when calling ProjectsApi->RemoveUserFromProject");
            
            // verify the required parameter 'projectid' is set
            if (projectid == null)
                throw new ApiException(400, "Missing required parameter 'projectid' when calling ProjectsApi->RemoveUserFromProject");
            
            // verify the required parameter 'email' is set
            if (email == null)
                throw new ApiException(400, "Missing required parameter 'email' when calling ProjectsApi->RemoveUserFromProject");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/users/{email}";
    
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
            if (email != null) pathParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling RemoveUserFromProject: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RemoveUserFromProject: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Revoke user access Revoke access to the specified project from the specified user
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="email"></param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> RemoveUserFromProjectAsync (string orgid, string projectid, string email)
        {
             ApiResponse<string> response = await RemoveUserFromProjectAsyncWithHttpInfo(orgid, projectid, email);
             return response.Data;

        }

        /// <summary>
        /// Revoke user access Revoke access to the specified project from the specified user
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="email"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> RemoveUserFromProjectAsyncWithHttpInfo (string orgid, string projectid, string email)
        {
            // verify the required parameter 'orgid' is set
            if (orgid == null) throw new ApiException(400, "Missing required parameter 'orgid' when calling RemoveUserFromProject");
            // verify the required parameter 'projectid' is set
            if (projectid == null) throw new ApiException(400, "Missing required parameter 'projectid' when calling RemoveUserFromProject");
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling RemoveUserFromProject");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/users/{email}";
    
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
            if (email != null) pathParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling RemoveUserFromProject: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RemoveUserFromProject: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// List all projects (user) List all projects that you have permission to access across all organizations. Add \&quot;?include=settings\&quot;\nas a query parameter to include the project settings with the response.
        /// </summary>
        /// <param name="include">Extra fields to include in the response</param> 
        /// <returns>List&lt;InlineResponse2001&gt;</returns>
        public List<InlineResponse2001> ListProjectsForUser (string include = null)
        {
             ApiResponse<List<InlineResponse2001>> response = ListProjectsForUserWithHttpInfo(include);
             return response.Data;
        }

        /// <summary>
        /// List all projects (user) List all projects that you have permission to access across all organizations. Add \&quot;?include=settings\&quot;\nas a query parameter to include the project settings with the response.
        /// </summary>
        /// <param name="include">Extra fields to include in the response</param> 
        /// <returns>ApiResponse of List&lt;InlineResponse2001&gt;</returns>
        public ApiResponse< List<InlineResponse2001> > ListProjectsForUserWithHttpInfo (string include = null)
        {
            
    
            var path_ = "/projects";
    
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
            
            if (include != null) queryParams.Add("include", Configuration.ApiClient.ParameterToString(include)); // query parameter
            
            
            
            

            // authentication (apikey) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListProjectsForUser: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListProjectsForUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<InlineResponse2001>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InlineResponse2001>) Configuration.ApiClient.Deserialize(response, typeof(List<InlineResponse2001>)));
            
        }
    
        /// <summary>
        /// List all projects (user) List all projects that you have permission to access across all organizations. Add \&quot;?include=settings\&quot;\nas a query parameter to include the project settings with the response.
        /// </summary>
        /// <param name="include">Extra fields to include in the response</param>
        /// <returns>Task of List&lt;InlineResponse2001&gt;</returns>
        public async System.Threading.Tasks.Task<List<InlineResponse2001>> ListProjectsForUserAsync (string include = null)
        {
             ApiResponse<List<InlineResponse2001>> response = await ListProjectsForUserAsyncWithHttpInfo(include);
             return response.Data;

        }

        /// <summary>
        /// List all projects (user) List all projects that you have permission to access across all organizations. Add \&quot;?include=settings\&quot;\nas a query parameter to include the project settings with the response.
        /// </summary>
        /// <param name="include">Extra fields to include in the response</param>
        /// <returns>Task of ApiResponse (List&lt;InlineResponse2001&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<InlineResponse2001>>> ListProjectsForUserAsyncWithHttpInfo (string include = null)
        {
            
    
            var path_ = "/projects";
    
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
            
            if (include != null) queryParams.Add("include", Configuration.ApiClient.ParameterToString(include)); // query parameter
            
            
            
            

            
            // authentication (apikey) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling ListProjectsForUser: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListProjectsForUser: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<InlineResponse2001>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InlineResponse2001>) Configuration.ApiClient.Deserialize(response, typeof(List<InlineResponse2001>)));
            
        }
        
        /// <summary>
        /// Get project details Gets the same data as /orgs/{orgid}/project/{projectid} but looks up the project by the Unity Project ID. This\nvalue is returned in the project&#39;s guid field.
        /// </summary>
        /// <param name="projectupid">Project UPID - Unity global id</param> 
        /// <returns>InlineResponse2001</returns>
        public InlineResponse2001 GetProjectByUpid (string projectupid)
        {
             ApiResponse<InlineResponse2001> response = GetProjectByUpidWithHttpInfo(projectupid);
             return response.Data;
        }

        /// <summary>
        /// Get project details Gets the same data as /orgs/{orgid}/project/{projectid} but looks up the project by the Unity Project ID. This\nvalue is returned in the project&#39;s guid field.
        /// </summary>
        /// <param name="projectupid">Project UPID - Unity global id</param> 
        /// <returns>ApiResponse of InlineResponse2001</returns>
        public ApiResponse< InlineResponse2001 > GetProjectByUpidWithHttpInfo (string projectupid)
        {
            
            // verify the required parameter 'projectupid' is set
            if (projectupid == null)
                throw new ApiException(400, "Missing required parameter 'projectupid' when calling ProjectsApi->GetProjectByUpid");
            
    
            var path_ = "/projects/{projectupid}";
    
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
            if (projectupid != null) pathParams.Add("projectupid", Configuration.ApiClient.ParameterToString(projectupid)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetProjectByUpid: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProjectByUpid: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2001>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2001) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2001)));
            
        }
    
        /// <summary>
        /// Get project details Gets the same data as /orgs/{orgid}/project/{projectid} but looks up the project by the Unity Project ID. This\nvalue is returned in the project&#39;s guid field.
        /// </summary>
        /// <param name="projectupid">Project UPID - Unity global id</param>
        /// <returns>Task of InlineResponse2001</returns>
        public async System.Threading.Tasks.Task<InlineResponse2001> GetProjectByUpidAsync (string projectupid)
        {
             ApiResponse<InlineResponse2001> response = await GetProjectByUpidAsyncWithHttpInfo(projectupid);
             return response.Data;

        }

        /// <summary>
        /// Get project details Gets the same data as /orgs/{orgid}/project/{projectid} but looks up the project by the Unity Project ID. This\nvalue is returned in the project&#39;s guid field.
        /// </summary>
        /// <param name="projectupid">Project UPID - Unity global id</param>
        /// <returns>Task of ApiResponse (InlineResponse2001)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2001>> GetProjectByUpidAsyncWithHttpInfo (string projectupid)
        {
            // verify the required parameter 'projectupid' is set
            if (projectupid == null) throw new ApiException(400, "Missing required parameter 'projectupid' when calling GetProjectByUpid");
            
    
            var path_ = "/projects/{projectupid}";
    
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
            if (projectupid != null) pathParams.Add("projectupid", Configuration.ApiClient.ParameterToString(projectupid)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetProjectByUpid: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetProjectByUpid: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2001>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2001) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2001)));
            
        }
        
    }
    
}

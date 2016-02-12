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
    public interface IBuildtargetsApi
    {
        
        /// <summary>
        /// List all build targets for a project
        /// </summary>
        /// <remarks>
        /// Gets all configured build targets for a project, regardless of whether they are enabled. Add \&quot;?include=settings,credentials\&quot;\nas a query parameter to include the build target settings and credentials with the response.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="include">Extra fields to include in the response</param>
        /// <param name="includeLastSuccess">Include last successful build</param>
        /// <returns>List&lt;InlineResponse2003&gt;</returns>
        List<InlineResponse2003> GetBuildTargets (string orgid, string projectid, string include = null, bool? includeLastSuccess = null);
  
        /// <summary>
        /// List all build targets for a project
        /// </summary>
        /// <remarks>
        /// Gets all configured build targets for a project, regardless of whether they are enabled. Add \&quot;?include=settings,credentials\&quot;\nas a query parameter to include the build target settings and credentials with the response.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="include">Extra fields to include in the response</param>
        /// <param name="includeLastSuccess">Include last successful build</param>
        /// <returns>ApiResponse of List&lt;InlineResponse2003&gt;</returns>
        ApiResponse<List<InlineResponse2003>> GetBuildTargetsWithHttpInfo (string orgid, string projectid, string include = null, bool? includeLastSuccess = null);

        /// <summary>
        /// List all build targets for a project
        /// </summary>
        /// <remarks>
        /// Gets all configured build targets for a project, regardless of whether they are enabled. Add \&quot;?include=settings,credentials\&quot;\nas a query parameter to include the build target settings and credentials with the response.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="include">Extra fields to include in the response</param>
        /// <param name="includeLastSuccess">Include last successful build</param>
        /// <returns>Task of List&lt;InlineResponse2003&gt;</returns>
        System.Threading.Tasks.Task<List<InlineResponse2003>> GetBuildTargetsAsync (string orgid, string projectid, string include = null, bool? includeLastSuccess = null);

        /// <summary>
        /// List all build targets for a project
        /// </summary>
        /// <remarks>
        /// Gets all configured build targets for a project, regardless of whether they are enabled. Add \&quot;?include=settings,credentials\&quot;\nas a query parameter to include the build target settings and credentials with the response.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="include">Extra fields to include in the response</param>
        /// <param name="includeLastSuccess">Include last successful build</param>
        /// <returns>Task of ApiResponse (List&lt;InlineResponse2003&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<InlineResponse2003>>> GetBuildTargetsAsyncWithHttpInfo (string orgid, string projectid, string include = null, bool? includeLastSuccess = null);
        
        /// <summary>
        /// Create build target for a project
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="options">Options for build target create/update</param>
        /// <returns>InlineResponse2003</returns>
        InlineResponse2003 AddBuildTarget (string orgid, string projectid, Options2 options);
  
        /// <summary>
        /// Create build target for a project
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="options">Options for build target create/update</param>
        /// <returns>ApiResponse of InlineResponse2003</returns>
        ApiResponse<InlineResponse2003> AddBuildTargetWithHttpInfo (string orgid, string projectid, Options2 options);

        /// <summary>
        /// Create build target for a project
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="options">Options for build target create/update</param>
        /// <returns>Task of InlineResponse2003</returns>
        System.Threading.Tasks.Task<InlineResponse2003> AddBuildTargetAsync (string orgid, string projectid, Options2 options);

        /// <summary>
        /// Create build target for a project
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="options">Options for build target create/update</param>
        /// <returns>Task of ApiResponse (InlineResponse2003)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2003>> AddBuildTargetAsyncWithHttpInfo (string orgid, string projectid, Options2 options);
        
        /// <summary>
        /// Get a build target
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <returns>InlineResponse2003</returns>
        InlineResponse2003 GetBuildTarget (string orgid, string projectid, string buildtargetid);
  
        /// <summary>
        /// Get a build target
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <returns>ApiResponse of InlineResponse2003</returns>
        ApiResponse<InlineResponse2003> GetBuildTargetWithHttpInfo (string orgid, string projectid, string buildtargetid);

        /// <summary>
        /// Get a build target
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <returns>Task of InlineResponse2003</returns>
        System.Threading.Tasks.Task<InlineResponse2003> GetBuildTargetAsync (string orgid, string projectid, string buildtargetid);

        /// <summary>
        /// Get a build target
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <returns>Task of ApiResponse (InlineResponse2003)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2003>> GetBuildTargetAsyncWithHttpInfo (string orgid, string projectid, string buildtargetid);
        
        /// <summary>
        /// Update build target details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="options">Options for build target create/update</param>
        /// <returns>InlineResponse2003</returns>
        InlineResponse2003 UpdateBuildTarget (string orgid, string projectid, string buildtargetid, Options3 options);
  
        /// <summary>
        /// Update build target details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="options">Options for build target create/update</param>
        /// <returns>ApiResponse of InlineResponse2003</returns>
        ApiResponse<InlineResponse2003> UpdateBuildTargetWithHttpInfo (string orgid, string projectid, string buildtargetid, Options3 options);

        /// <summary>
        /// Update build target details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="options">Options for build target create/update</param>
        /// <returns>Task of InlineResponse2003</returns>
        System.Threading.Tasks.Task<InlineResponse2003> UpdateBuildTargetAsync (string orgid, string projectid, string buildtargetid, Options3 options);

        /// <summary>
        /// Update build target details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="options">Options for build target create/update</param>
        /// <returns>Task of ApiResponse (InlineResponse2003)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2003>> UpdateBuildTargetAsyncWithHttpInfo (string orgid, string projectid, string buildtargetid, Options3 options);
        
        /// <summary>
        /// Delete build target
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <returns>string</returns>
        string DeleteBuildTarget (string orgid, string projectid, string buildtargetid);
  
        /// <summary>
        /// Delete build target
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteBuildTargetWithHttpInfo (string orgid, string projectid, string buildtargetid);

        /// <summary>
        /// Delete build target
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteBuildTargetAsync (string orgid, string projectid, string buildtargetid);

        /// <summary>
        /// Delete build target
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteBuildTargetAsyncWithHttpInfo (string orgid, string projectid, string buildtargetid);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BuildtargetsApi : IBuildtargetsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildtargetsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BuildtargetsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildtargetsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BuildtargetsApi(Configuration configuration = null)
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
        /// List all build targets for a project Gets all configured build targets for a project, regardless of whether they are enabled. Add \&quot;?include=settings,credentials\&quot;\nas a query parameter to include the build target settings and credentials with the response.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="include">Extra fields to include in the response</param> 
        /// <param name="includeLastSuccess">Include last successful build</param> 
        /// <returns>List&lt;InlineResponse2003&gt;</returns>
        public List<InlineResponse2003> GetBuildTargets (string orgid, string projectid, string include = null, bool? includeLastSuccess = null)
        {
             ApiResponse<List<InlineResponse2003>> response = GetBuildTargetsWithHttpInfo(orgid, projectid, include, includeLastSuccess);
             return response.Data;
        }

        /// <summary>
        /// List all build targets for a project Gets all configured build targets for a project, regardless of whether they are enabled. Add \&quot;?include=settings,credentials\&quot;\nas a query parameter to include the build target settings and credentials with the response.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="include">Extra fields to include in the response</param> 
        /// <param name="includeLastSuccess">Include last successful build</param> 
        /// <returns>ApiResponse of List&lt;InlineResponse2003&gt;</returns>
        public ApiResponse< List<InlineResponse2003> > GetBuildTargetsWithHttpInfo (string orgid, string projectid, string include = null, bool? includeLastSuccess = null)
        {
            
            // verify the required parameter 'orgid' is set
            if (orgid == null)
                throw new ApiException(400, "Missing required parameter 'orgid' when calling BuildtargetsApi->GetBuildTargets");
            
            // verify the required parameter 'projectid' is set
            if (projectid == null)
                throw new ApiException(400, "Missing required parameter 'projectid' when calling BuildtargetsApi->GetBuildTargets");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/buildtargets";
    
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
            if (includeLastSuccess != null) queryParams.Add("include_last_success", Configuration.ApiClient.ParameterToString(includeLastSuccess)); // query parameter
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetBuildTargets: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetBuildTargets: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<InlineResponse2003>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InlineResponse2003>) Configuration.ApiClient.Deserialize(response, typeof(List<InlineResponse2003>)));
            
        }
    
        /// <summary>
        /// List all build targets for a project Gets all configured build targets for a project, regardless of whether they are enabled. Add \&quot;?include=settings,credentials\&quot;\nas a query parameter to include the build target settings and credentials with the response.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="include">Extra fields to include in the response</param>
        /// <param name="includeLastSuccess">Include last successful build</param>
        /// <returns>Task of List&lt;InlineResponse2003&gt;</returns>
        public async System.Threading.Tasks.Task<List<InlineResponse2003>> GetBuildTargetsAsync (string orgid, string projectid, string include = null, bool? includeLastSuccess = null)
        {
             ApiResponse<List<InlineResponse2003>> response = await GetBuildTargetsAsyncWithHttpInfo(orgid, projectid, include, includeLastSuccess);
             return response.Data;

        }

        /// <summary>
        /// List all build targets for a project Gets all configured build targets for a project, regardless of whether they are enabled. Add \&quot;?include=settings,credentials\&quot;\nas a query parameter to include the build target settings and credentials with the response.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="include">Extra fields to include in the response</param>
        /// <param name="includeLastSuccess">Include last successful build</param>
        /// <returns>Task of ApiResponse (List&lt;InlineResponse2003&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<InlineResponse2003>>> GetBuildTargetsAsyncWithHttpInfo (string orgid, string projectid, string include = null, bool? includeLastSuccess = null)
        {
            // verify the required parameter 'orgid' is set
            if (orgid == null) throw new ApiException(400, "Missing required parameter 'orgid' when calling GetBuildTargets");
            // verify the required parameter 'projectid' is set
            if (projectid == null) throw new ApiException(400, "Missing required parameter 'projectid' when calling GetBuildTargets");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/buildtargets";
    
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
            if (includeLastSuccess != null) queryParams.Add("include_last_success", Configuration.ApiClient.ParameterToString(includeLastSuccess)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetBuildTargets: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetBuildTargets: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<InlineResponse2003>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InlineResponse2003>) Configuration.ApiClient.Deserialize(response, typeof(List<InlineResponse2003>)));
            
        }
        
        /// <summary>
        /// Create build target for a project 
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="options">Options for build target create/update</param> 
        /// <returns>InlineResponse2003</returns>
        public InlineResponse2003 AddBuildTarget (string orgid, string projectid, Options2 options)
        {
             ApiResponse<InlineResponse2003> response = AddBuildTargetWithHttpInfo(orgid, projectid, options);
             return response.Data;
        }

        /// <summary>
        /// Create build target for a project 
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="options">Options for build target create/update</param> 
        /// <returns>ApiResponse of InlineResponse2003</returns>
        public ApiResponse< InlineResponse2003 > AddBuildTargetWithHttpInfo (string orgid, string projectid, Options2 options)
        {
            
            // verify the required parameter 'orgid' is set
            if (orgid == null)
                throw new ApiException(400, "Missing required parameter 'orgid' when calling BuildtargetsApi->AddBuildTarget");
            
            // verify the required parameter 'projectid' is set
            if (projectid == null)
                throw new ApiException(400, "Missing required parameter 'projectid' when calling BuildtargetsApi->AddBuildTarget");
            
            // verify the required parameter 'options' is set
            if (options == null)
                throw new ApiException(400, "Missing required parameter 'options' when calling BuildtargetsApi->AddBuildTarget");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/buildtargets";
    
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
                throw new ApiException (statusCode, "Error calling AddBuildTarget: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AddBuildTarget: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2003>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2003) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2003)));
            
        }
    
        /// <summary>
        /// Create build target for a project 
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="options">Options for build target create/update</param>
        /// <returns>Task of InlineResponse2003</returns>
        public async System.Threading.Tasks.Task<InlineResponse2003> AddBuildTargetAsync (string orgid, string projectid, Options2 options)
        {
             ApiResponse<InlineResponse2003> response = await AddBuildTargetAsyncWithHttpInfo(orgid, projectid, options);
             return response.Data;

        }

        /// <summary>
        /// Create build target for a project 
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="options">Options for build target create/update</param>
        /// <returns>Task of ApiResponse (InlineResponse2003)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2003>> AddBuildTargetAsyncWithHttpInfo (string orgid, string projectid, Options2 options)
        {
            // verify the required parameter 'orgid' is set
            if (orgid == null) throw new ApiException(400, "Missing required parameter 'orgid' when calling AddBuildTarget");
            // verify the required parameter 'projectid' is set
            if (projectid == null) throw new ApiException(400, "Missing required parameter 'projectid' when calling AddBuildTarget");
            // verify the required parameter 'options' is set
            if (options == null) throw new ApiException(400, "Missing required parameter 'options' when calling AddBuildTarget");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/buildtargets";
    
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
                throw new ApiException (statusCode, "Error calling AddBuildTarget: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AddBuildTarget: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2003>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2003) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2003)));
            
        }
        
        /// <summary>
        /// Get a build target 
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param> 
        /// <returns>InlineResponse2003</returns>
        public InlineResponse2003 GetBuildTarget (string orgid, string projectid, string buildtargetid)
        {
             ApiResponse<InlineResponse2003> response = GetBuildTargetWithHttpInfo(orgid, projectid, buildtargetid);
             return response.Data;
        }

        /// <summary>
        /// Get a build target 
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param> 
        /// <returns>ApiResponse of InlineResponse2003</returns>
        public ApiResponse< InlineResponse2003 > GetBuildTargetWithHttpInfo (string orgid, string projectid, string buildtargetid)
        {
            
            // verify the required parameter 'orgid' is set
            if (orgid == null)
                throw new ApiException(400, "Missing required parameter 'orgid' when calling BuildtargetsApi->GetBuildTarget");
            
            // verify the required parameter 'projectid' is set
            if (projectid == null)
                throw new ApiException(400, "Missing required parameter 'projectid' when calling BuildtargetsApi->GetBuildTarget");
            
            // verify the required parameter 'buildtargetid' is set
            if (buildtargetid == null)
                throw new ApiException(400, "Missing required parameter 'buildtargetid' when calling BuildtargetsApi->GetBuildTarget");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/buildtargets/{buildtargetid}";
    
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
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetBuildTarget: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetBuildTarget: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2003>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2003) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2003)));
            
        }
    
        /// <summary>
        /// Get a build target 
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <returns>Task of InlineResponse2003</returns>
        public async System.Threading.Tasks.Task<InlineResponse2003> GetBuildTargetAsync (string orgid, string projectid, string buildtargetid)
        {
             ApiResponse<InlineResponse2003> response = await GetBuildTargetAsyncWithHttpInfo(orgid, projectid, buildtargetid);
             return response.Data;

        }

        /// <summary>
        /// Get a build target 
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <returns>Task of ApiResponse (InlineResponse2003)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2003>> GetBuildTargetAsyncWithHttpInfo (string orgid, string projectid, string buildtargetid)
        {
            // verify the required parameter 'orgid' is set
            if (orgid == null) throw new ApiException(400, "Missing required parameter 'orgid' when calling GetBuildTarget");
            // verify the required parameter 'projectid' is set
            if (projectid == null) throw new ApiException(400, "Missing required parameter 'projectid' when calling GetBuildTarget");
            // verify the required parameter 'buildtargetid' is set
            if (buildtargetid == null) throw new ApiException(400, "Missing required parameter 'buildtargetid' when calling GetBuildTarget");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/buildtargets/{buildtargetid}";
    
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
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetBuildTarget: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetBuildTarget: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2003>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2003) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2003)));
            
        }
        
        /// <summary>
        /// Update build target details 
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param> 
        /// <param name="options">Options for build target create/update</param> 
        /// <returns>InlineResponse2003</returns>
        public InlineResponse2003 UpdateBuildTarget (string orgid, string projectid, string buildtargetid, Options3 options)
        {
             ApiResponse<InlineResponse2003> response = UpdateBuildTargetWithHttpInfo(orgid, projectid, buildtargetid, options);
             return response.Data;
        }

        /// <summary>
        /// Update build target details 
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param> 
        /// <param name="options">Options for build target create/update</param> 
        /// <returns>ApiResponse of InlineResponse2003</returns>
        public ApiResponse< InlineResponse2003 > UpdateBuildTargetWithHttpInfo (string orgid, string projectid, string buildtargetid, Options3 options)
        {
            
            // verify the required parameter 'orgid' is set
            if (orgid == null)
                throw new ApiException(400, "Missing required parameter 'orgid' when calling BuildtargetsApi->UpdateBuildTarget");
            
            // verify the required parameter 'projectid' is set
            if (projectid == null)
                throw new ApiException(400, "Missing required parameter 'projectid' when calling BuildtargetsApi->UpdateBuildTarget");
            
            // verify the required parameter 'buildtargetid' is set
            if (buildtargetid == null)
                throw new ApiException(400, "Missing required parameter 'buildtargetid' when calling BuildtargetsApi->UpdateBuildTarget");
            
            // verify the required parameter 'options' is set
            if (options == null)
                throw new ApiException(400, "Missing required parameter 'options' when calling BuildtargetsApi->UpdateBuildTarget");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/buildtargets/{buildtargetid}";
    
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
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateBuildTarget: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateBuildTarget: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2003>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2003) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2003)));
            
        }
    
        /// <summary>
        /// Update build target details 
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="options">Options for build target create/update</param>
        /// <returns>Task of InlineResponse2003</returns>
        public async System.Threading.Tasks.Task<InlineResponse2003> UpdateBuildTargetAsync (string orgid, string projectid, string buildtargetid, Options3 options)
        {
             ApiResponse<InlineResponse2003> response = await UpdateBuildTargetAsyncWithHttpInfo(orgid, projectid, buildtargetid, options);
             return response.Data;

        }

        /// <summary>
        /// Update build target details 
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <param name="options">Options for build target create/update</param>
        /// <returns>Task of ApiResponse (InlineResponse2003)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2003>> UpdateBuildTargetAsyncWithHttpInfo (string orgid, string projectid, string buildtargetid, Options3 options)
        {
            // verify the required parameter 'orgid' is set
            if (orgid == null) throw new ApiException(400, "Missing required parameter 'orgid' when calling UpdateBuildTarget");
            // verify the required parameter 'projectid' is set
            if (projectid == null) throw new ApiException(400, "Missing required parameter 'projectid' when calling UpdateBuildTarget");
            // verify the required parameter 'buildtargetid' is set
            if (buildtargetid == null) throw new ApiException(400, "Missing required parameter 'buildtargetid' when calling UpdateBuildTarget");
            // verify the required parameter 'options' is set
            if (options == null) throw new ApiException(400, "Missing required parameter 'options' when calling UpdateBuildTarget");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/buildtargets/{buildtargetid}";
    
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
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateBuildTarget: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateBuildTarget: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2003>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2003) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2003)));
            
        }
        
        /// <summary>
        /// Delete build target 
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param> 
        /// <returns>string</returns>
        public string DeleteBuildTarget (string orgid, string projectid, string buildtargetid)
        {
             ApiResponse<string> response = DeleteBuildTargetWithHttpInfo(orgid, projectid, buildtargetid);
             return response.Data;
        }

        /// <summary>
        /// Delete build target 
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteBuildTargetWithHttpInfo (string orgid, string projectid, string buildtargetid)
        {
            
            // verify the required parameter 'orgid' is set
            if (orgid == null)
                throw new ApiException(400, "Missing required parameter 'orgid' when calling BuildtargetsApi->DeleteBuildTarget");
            
            // verify the required parameter 'projectid' is set
            if (projectid == null)
                throw new ApiException(400, "Missing required parameter 'projectid' when calling BuildtargetsApi->DeleteBuildTarget");
            
            // verify the required parameter 'buildtargetid' is set
            if (buildtargetid == null)
                throw new ApiException(400, "Missing required parameter 'buildtargetid' when calling BuildtargetsApi->DeleteBuildTarget");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/buildtargets/{buildtargetid}";
    
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
                throw new ApiException (statusCode, "Error calling DeleteBuildTarget: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteBuildTarget: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete build target 
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteBuildTargetAsync (string orgid, string projectid, string buildtargetid)
        {
             ApiResponse<string> response = await DeleteBuildTargetAsyncWithHttpInfo(orgid, projectid, buildtargetid);
             return response.Data;

        }

        /// <summary>
        /// Delete build target 
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="buildtargetid">unique id auto-generated from the build target name</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteBuildTargetAsyncWithHttpInfo (string orgid, string projectid, string buildtargetid)
        {
            // verify the required parameter 'orgid' is set
            if (orgid == null) throw new ApiException(400, "Missing required parameter 'orgid' when calling DeleteBuildTarget");
            // verify the required parameter 'projectid' is set
            if (projectid == null) throw new ApiException(400, "Missing required parameter 'projectid' when calling DeleteBuildTarget");
            // verify the required parameter 'buildtargetid' is set
            if (buildtargetid == null) throw new ApiException(400, "Missing required parameter 'buildtargetid' when calling DeleteBuildTarget");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/buildtargets/{buildtargetid}";
    
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
                throw new ApiException (statusCode, "Error calling DeleteBuildTarget: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteBuildTarget: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
    }
    
}

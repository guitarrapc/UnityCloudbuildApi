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
    public interface IOrgsApi
    {
        
        /// <summary>
        /// Get billing plan
        /// </summary>
        /// <remarks>
        /// Get the billing plan for the specified organization
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 GetBillingPlans (string orgid);
  
        /// <summary>
        /// Get billing plan
        /// </summary>
        /// <remarks>
        /// Get the billing plan for the specified organization
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <returns>ApiResponse of InlineResponse200</returns>
        ApiResponse<InlineResponse200> GetBillingPlansWithHttpInfo (string orgid);

        /// <summary>
        /// Get billing plan
        /// </summary>
        /// <remarks>
        /// Get the billing plan for the specified organization
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <returns>Task of InlineResponse200</returns>
        System.Threading.Tasks.Task<InlineResponse200> GetBillingPlansAsync (string orgid);

        /// <summary>
        /// Get billing plan
        /// </summary>
        /// <remarks>
        /// Get the billing plan for the specified organization
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> GetBillingPlansAsyncWithHttpInfo (string orgid);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OrgsApi : IOrgsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrgsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OrgsApi(Configuration configuration = null)
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
        /// Get billing plan Get the billing plan for the specified organization
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <returns>InlineResponse200</returns>
        public InlineResponse200 GetBillingPlans (string orgid)
        {
             ApiResponse<InlineResponse200> response = GetBillingPlansWithHttpInfo(orgid);
             return response.Data;
        }

        /// <summary>
        /// Get billing plan Get the billing plan for the specified organization
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <returns>ApiResponse of InlineResponse200</returns>
        public ApiResponse< InlineResponse200 > GetBillingPlansWithHttpInfo (string orgid)
        {
            
            // verify the required parameter 'orgid' is set
            if (orgid == null)
                throw new ApiException(400, "Missing required parameter 'orgid' when calling OrgsApi->GetBillingPlans");
            
    
            var path_ = "/orgs/{orgid}/billingplan";
    
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
        /// Get billing plan Get the billing plan for the specified organization
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <returns>Task of InlineResponse200</returns>
        public async System.Threading.Tasks.Task<InlineResponse200> GetBillingPlansAsync (string orgid)
        {
             ApiResponse<InlineResponse200> response = await GetBillingPlansAsyncWithHttpInfo(orgid);
             return response.Data;

        }

        /// <summary>
        /// Get billing plan Get the billing plan for the specified organization
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> GetBillingPlansAsyncWithHttpInfo (string orgid)
        {
            // verify the required parameter 'orgid' is set
            if (orgid == null) throw new ApiException(400, "Missing required parameter 'orgid' when calling GetBillingPlans");
            
    
            var path_ = "/orgs/{orgid}/billingplan";
    
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
        
    }
    
}

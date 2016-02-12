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
    public interface IUsersApi
    {
        
        /// <summary>
        /// Get current user
        /// </summary>
        /// <remarks>
        /// Get the currently authenticated user.
        /// </remarks>
        /// <param name="include">Extra fields to include in the response</param>
        /// <returns>InlineResponse20010</returns>
        InlineResponse20010 GetUserSelf (string include = null);
  
        /// <summary>
        /// Get current user
        /// </summary>
        /// <remarks>
        /// Get the currently authenticated user.
        /// </remarks>
        /// <param name="include">Extra fields to include in the response</param>
        /// <returns>ApiResponse of InlineResponse20010</returns>
        ApiResponse<InlineResponse20010> GetUserSelfWithHttpInfo (string include = null);

        /// <summary>
        /// Get current user
        /// </summary>
        /// <remarks>
        /// Get the currently authenticated user.
        /// </remarks>
        /// <param name="include">Extra fields to include in the response</param>
        /// <returns>Task of InlineResponse20010</returns>
        System.Threading.Tasks.Task<InlineResponse20010> GetUserSelfAsync (string include = null);

        /// <summary>
        /// Get current user
        /// </summary>
        /// <remarks>
        /// Get the currently authenticated user.
        /// </remarks>
        /// <param name="include">Extra fields to include in the response</param>
        /// <returns>Task of ApiResponse (InlineResponse20010)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20010>> GetUserSelfAsyncWithHttpInfo (string include = null);
        
        /// <summary>
        /// Update current user
        /// </summary>
        /// <remarks>
        /// You can update a few fields on the current user. Each field is optional and you\ndo not need to specify all fields on update.
        /// </remarks>
        /// <param name="options"></param>
        /// <returns>InlineResponse20010</returns>
        InlineResponse20010 UpdateUserSelf (Options6 options = null);
  
        /// <summary>
        /// Update current user
        /// </summary>
        /// <remarks>
        /// You can update a few fields on the current user. Each field is optional and you\ndo not need to specify all fields on update.
        /// </remarks>
        /// <param name="options"></param>
        /// <returns>ApiResponse of InlineResponse20010</returns>
        ApiResponse<InlineResponse20010> UpdateUserSelfWithHttpInfo (Options6 options = null);

        /// <summary>
        /// Update current user
        /// </summary>
        /// <remarks>
        /// You can update a few fields on the current user. Each field is optional and you\ndo not need to specify all fields on update.
        /// </remarks>
        /// <param name="options"></param>
        /// <returns>Task of InlineResponse20010</returns>
        System.Threading.Tasks.Task<InlineResponse20010> UpdateUserSelfAsync (Options6 options = null);

        /// <summary>
        /// Update current user
        /// </summary>
        /// <remarks>
        /// You can update a few fields on the current user. Each field is optional and you\ndo not need to specify all fields on update.
        /// </remarks>
        /// <param name="options"></param>
        /// <returns>Task of ApiResponse (InlineResponse20010)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20010>> UpdateUserSelfAsyncWithHttpInfo (Options6 options = null);
        
        /// <summary>
        /// Regenerate API Key
        /// </summary>
        /// <remarks>
        /// Remove current API key and generate a new one. *WARNING* you will need to use the returned\nAPI key in all subsequent calls.
        /// </remarks>
        /// <returns>InlineResponse20011</returns>
        InlineResponse20011 RegenApiKey ();
  
        /// <summary>
        /// Regenerate API Key
        /// </summary>
        /// <remarks>
        /// Remove current API key and generate a new one. *WARNING* you will need to use the returned\nAPI key in all subsequent calls.
        /// </remarks>
        /// <returns>ApiResponse of InlineResponse20011</returns>
        ApiResponse<InlineResponse20011> RegenApiKeyWithHttpInfo ();

        /// <summary>
        /// Regenerate API Key
        /// </summary>
        /// <remarks>
        /// Remove current API key and generate a new one. *WARNING* you will need to use the returned\nAPI key in all subsequent calls.
        /// </remarks>
        /// <returns>Task of InlineResponse20011</returns>
        System.Threading.Tasks.Task<InlineResponse20011> RegenApiKeyAsync ();

        /// <summary>
        /// Regenerate API Key
        /// </summary>
        /// <remarks>
        /// Remove current API key and generate a new one. *WARNING* you will need to use the returned\nAPI key in all subsequent calls.
        /// </remarks>
        /// <returns>Task of ApiResponse (InlineResponse20011)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20011>> RegenApiKeyAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get billing plan
        /// </summary>
        /// <remarks>
        /// Get the billing plan for the currently authenticated user.\n\nYou can get links to upgrade your plan by specifying redirect urls. You&#39;ll\nneed one for success, cancellation, and upgrade failure. Those urls are\nspecified in the query string.
        /// </remarks>
        /// <param name="success"></param>
        /// <param name="failure"></param>
        /// <param name="cancel"></param>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 GetUserSelfBillingPlan (string success = null, string failure = null, string cancel = null);
  
        /// <summary>
        /// Get billing plan
        /// </summary>
        /// <remarks>
        /// Get the billing plan for the currently authenticated user.\n\nYou can get links to upgrade your plan by specifying redirect urls. You&#39;ll\nneed one for success, cancellation, and upgrade failure. Those urls are\nspecified in the query string.
        /// </remarks>
        /// <param name="success"></param>
        /// <param name="failure"></param>
        /// <param name="cancel"></param>
        /// <returns>ApiResponse of InlineResponse200</returns>
        ApiResponse<InlineResponse200> GetUserSelfBillingPlanWithHttpInfo (string success = null, string failure = null, string cancel = null);

        /// <summary>
        /// Get billing plan
        /// </summary>
        /// <remarks>
        /// Get the billing plan for the currently authenticated user.\n\nYou can get links to upgrade your plan by specifying redirect urls. You&#39;ll\nneed one for success, cancellation, and upgrade failure. Those urls are\nspecified in the query string.
        /// </remarks>
        /// <param name="success"></param>
        /// <param name="failure"></param>
        /// <param name="cancel"></param>
        /// <returns>Task of InlineResponse200</returns>
        System.Threading.Tasks.Task<InlineResponse200> GetUserSelfBillingPlanAsync (string success = null, string failure = null, string cancel = null);

        /// <summary>
        /// Get billing plan
        /// </summary>
        /// <remarks>
        /// Get the billing plan for the currently authenticated user.\n\nYou can get links to upgrade your plan by specifying redirect urls. You&#39;ll\nneed one for success, cancellation, and upgrade failure. Those urls are\nspecified in the query string.
        /// </remarks>
        /// <param name="success"></param>
        /// <param name="failure"></param>
        /// <param name="cancel"></param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> GetUserSelfBillingPlanAsyncWithHttpInfo (string success = null, string failure = null, string cancel = null);
        
        /// <summary>
        /// Downgrade billing plan
        /// </summary>
        /// <remarks>
        /// Downgrading a billing plan can only be done for a lower plan. The current plan will stay\nin effect until the end of the current plan&#39;s billing cycle.
        /// </remarks>
        /// <param name="options"></param>
        /// <returns>string</returns>
        string DowngradeBillingPlan (Options7 options);
  
        /// <summary>
        /// Downgrade billing plan
        /// </summary>
        /// <remarks>
        /// Downgrading a billing plan can only be done for a lower plan. The current plan will stay\nin effect until the end of the current plan&#39;s billing cycle.
        /// </remarks>
        /// <param name="options"></param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DowngradeBillingPlanWithHttpInfo (Options7 options);

        /// <summary>
        /// Downgrade billing plan
        /// </summary>
        /// <remarks>
        /// Downgrading a billing plan can only be done for a lower plan. The current plan will stay\nin effect until the end of the current plan&#39;s billing cycle.
        /// </remarks>
        /// <param name="options"></param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DowngradeBillingPlanAsync (Options7 options);

        /// <summary>
        /// Downgrade billing plan
        /// </summary>
        /// <remarks>
        /// Downgrading a billing plan can only be done for a lower plan. The current plan will stay\nin effect until the end of the current plan&#39;s billing cycle.
        /// </remarks>
        /// <param name="options"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DowngradeBillingPlanAsyncWithHttpInfo (Options7 options);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UsersApi : IUsersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsersApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UsersApi(Configuration configuration = null)
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
        /// Get current user Get the currently authenticated user.
        /// </summary>
        /// <param name="include">Extra fields to include in the response</param> 
        /// <returns>InlineResponse20010</returns>
        public InlineResponse20010 GetUserSelf (string include = null)
        {
             ApiResponse<InlineResponse20010> response = GetUserSelfWithHttpInfo(include);
             return response.Data;
        }

        /// <summary>
        /// Get current user Get the currently authenticated user.
        /// </summary>
        /// <param name="include">Extra fields to include in the response</param> 
        /// <returns>ApiResponse of InlineResponse20010</returns>
        public ApiResponse< InlineResponse20010 > GetUserSelfWithHttpInfo (string include = null)
        {
            
    
            var path_ = "/users/me";
    
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
                throw new ApiException (statusCode, "Error calling GetUserSelf: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUserSelf: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20010>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20010) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20010)));
            
        }
    
        /// <summary>
        /// Get current user Get the currently authenticated user.
        /// </summary>
        /// <param name="include">Extra fields to include in the response</param>
        /// <returns>Task of InlineResponse20010</returns>
        public async System.Threading.Tasks.Task<InlineResponse20010> GetUserSelfAsync (string include = null)
        {
             ApiResponse<InlineResponse20010> response = await GetUserSelfAsyncWithHttpInfo(include);
             return response.Data;

        }

        /// <summary>
        /// Get current user Get the currently authenticated user.
        /// </summary>
        /// <param name="include">Extra fields to include in the response</param>
        /// <returns>Task of ApiResponse (InlineResponse20010)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20010>> GetUserSelfAsyncWithHttpInfo (string include = null)
        {
            
    
            var path_ = "/users/me";
    
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
                throw new ApiException (statusCode, "Error calling GetUserSelf: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUserSelf: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20010>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20010) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20010)));
            
        }
        
        /// <summary>
        /// Update current user You can update a few fields on the current user. Each field is optional and you\ndo not need to specify all fields on update.
        /// </summary>
        /// <param name="options"></param> 
        /// <returns>InlineResponse20010</returns>
        public InlineResponse20010 UpdateUserSelf (Options6 options = null)
        {
             ApiResponse<InlineResponse20010> response = UpdateUserSelfWithHttpInfo(options);
             return response.Data;
        }

        /// <summary>
        /// Update current user You can update a few fields on the current user. Each field is optional and you\ndo not need to specify all fields on update.
        /// </summary>
        /// <param name="options"></param> 
        /// <returns>ApiResponse of InlineResponse20010</returns>
        public ApiResponse< InlineResponse20010 > UpdateUserSelfWithHttpInfo (Options6 options = null)
        {
            
    
            var path_ = "/users/me";
    
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
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateUserSelf: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateUserSelf: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20010>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20010) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20010)));
            
        }
    
        /// <summary>
        /// Update current user You can update a few fields on the current user. Each field is optional and you\ndo not need to specify all fields on update.
        /// </summary>
        /// <param name="options"></param>
        /// <returns>Task of InlineResponse20010</returns>
        public async System.Threading.Tasks.Task<InlineResponse20010> UpdateUserSelfAsync (Options6 options = null)
        {
             ApiResponse<InlineResponse20010> response = await UpdateUserSelfAsyncWithHttpInfo(options);
             return response.Data;

        }

        /// <summary>
        /// Update current user You can update a few fields on the current user. Each field is optional and you\ndo not need to specify all fields on update.
        /// </summary>
        /// <param name="options"></param>
        /// <returns>Task of ApiResponse (InlineResponse20010)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20010>> UpdateUserSelfAsyncWithHttpInfo (Options6 options = null)
        {
            
    
            var path_ = "/users/me";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(options); // http body (model) parameter
            

            
            // authentication (apikey) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateUserSelf: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateUserSelf: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20010>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20010) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20010)));
            
        }
        
        /// <summary>
        /// Regenerate API Key Remove current API key and generate a new one. *WARNING* you will need to use the returned\nAPI key in all subsequent calls.
        /// </summary>
        /// <returns>InlineResponse20011</returns>
        public InlineResponse20011 RegenApiKey ()
        {
             ApiResponse<InlineResponse20011> response = RegenApiKeyWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// Regenerate API Key Remove current API key and generate a new one. *WARNING* you will need to use the returned\nAPI key in all subsequent calls.
        /// </summary>
        /// <returns>ApiResponse of InlineResponse20011</returns>
        public ApiResponse< InlineResponse20011 > RegenApiKeyWithHttpInfo ()
        {
            
    
            var path_ = "/users/me/apikey";
    
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
            
            
            
            
            

            // authentication (apikey) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling RegenApiKey: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RegenApiKey: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20011>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20011) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20011)));
            
        }
    
        /// <summary>
        /// Regenerate API Key Remove current API key and generate a new one. *WARNING* you will need to use the returned\nAPI key in all subsequent calls.
        /// </summary>
        /// <returns>Task of InlineResponse20011</returns>
        public async System.Threading.Tasks.Task<InlineResponse20011> RegenApiKeyAsync ()
        {
             ApiResponse<InlineResponse20011> response = await RegenApiKeyAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// Regenerate API Key Remove current API key and generate a new one. *WARNING* you will need to use the returned\nAPI key in all subsequent calls.
        /// </summary>
        /// <returns>Task of ApiResponse (InlineResponse20011)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20011>> RegenApiKeyAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/users/me/apikey";
    
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
            
            
            
            
            

            
            // authentication (apikey) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling RegenApiKey: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RegenApiKey: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20011>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20011) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20011)));
            
        }
        
        /// <summary>
        /// Get billing plan Get the billing plan for the currently authenticated user.\n\nYou can get links to upgrade your plan by specifying redirect urls. You&#39;ll\nneed one for success, cancellation, and upgrade failure. Those urls are\nspecified in the query string.
        /// </summary>
        /// <param name="success"></param> 
        /// <param name="failure"></param> 
        /// <param name="cancel"></param> 
        /// <returns>InlineResponse200</returns>
        public InlineResponse200 GetUserSelfBillingPlan (string success = null, string failure = null, string cancel = null)
        {
             ApiResponse<InlineResponse200> response = GetUserSelfBillingPlanWithHttpInfo(success, failure, cancel);
             return response.Data;
        }

        /// <summary>
        /// Get billing plan Get the billing plan for the currently authenticated user.\n\nYou can get links to upgrade your plan by specifying redirect urls. You&#39;ll\nneed one for success, cancellation, and upgrade failure. Those urls are\nspecified in the query string.
        /// </summary>
        /// <param name="success"></param> 
        /// <param name="failure"></param> 
        /// <param name="cancel"></param> 
        /// <returns>ApiResponse of InlineResponse200</returns>
        public ApiResponse< InlineResponse200 > GetUserSelfBillingPlanWithHttpInfo (string success = null, string failure = null, string cancel = null)
        {
            
    
            var path_ = "/users/me/billingplan";
    
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
            
            if (success != null) queryParams.Add("success", Configuration.ApiClient.ParameterToString(success)); // query parameter
            if (failure != null) queryParams.Add("failure", Configuration.ApiClient.ParameterToString(failure)); // query parameter
            if (cancel != null) queryParams.Add("cancel", Configuration.ApiClient.ParameterToString(cancel)); // query parameter
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetUserSelfBillingPlan: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUserSelfBillingPlan: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse200>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse200) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse200)));
            
        }
    
        /// <summary>
        /// Get billing plan Get the billing plan for the currently authenticated user.\n\nYou can get links to upgrade your plan by specifying redirect urls. You&#39;ll\nneed one for success, cancellation, and upgrade failure. Those urls are\nspecified in the query string.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="failure"></param>
        /// <param name="cancel"></param>
        /// <returns>Task of InlineResponse200</returns>
        public async System.Threading.Tasks.Task<InlineResponse200> GetUserSelfBillingPlanAsync (string success = null, string failure = null, string cancel = null)
        {
             ApiResponse<InlineResponse200> response = await GetUserSelfBillingPlanAsyncWithHttpInfo(success, failure, cancel);
             return response.Data;

        }

        /// <summary>
        /// Get billing plan Get the billing plan for the currently authenticated user.\n\nYou can get links to upgrade your plan by specifying redirect urls. You&#39;ll\nneed one for success, cancellation, and upgrade failure. Those urls are\nspecified in the query string.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="failure"></param>
        /// <param name="cancel"></param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> GetUserSelfBillingPlanAsyncWithHttpInfo (string success = null, string failure = null, string cancel = null)
        {
            
    
            var path_ = "/users/me/billingplan";
    
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
            
            if (success != null) queryParams.Add("success", Configuration.ApiClient.ParameterToString(success)); // query parameter
            if (failure != null) queryParams.Add("failure", Configuration.ApiClient.ParameterToString(failure)); // query parameter
            if (cancel != null) queryParams.Add("cancel", Configuration.ApiClient.ParameterToString(cancel)); // query parameter
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetUserSelfBillingPlan: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUserSelfBillingPlan: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse200>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse200) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse200)));
            
        }
        
        /// <summary>
        /// Downgrade billing plan Downgrading a billing plan can only be done for a lower plan. The current plan will stay\nin effect until the end of the current plan&#39;s billing cycle.
        /// </summary>
        /// <param name="options"></param> 
        /// <returns>string</returns>
        public string DowngradeBillingPlan (Options7 options)
        {
             ApiResponse<string> response = DowngradeBillingPlanWithHttpInfo(options);
             return response.Data;
        }

        /// <summary>
        /// Downgrade billing plan Downgrading a billing plan can only be done for a lower plan. The current plan will stay\nin effect until the end of the current plan&#39;s billing cycle.
        /// </summary>
        /// <param name="options"></param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DowngradeBillingPlanWithHttpInfo (Options7 options)
        {
            
            // verify the required parameter 'options' is set
            if (options == null)
                throw new ApiException(400, "Missing required parameter 'options' when calling UsersApi->DowngradeBillingPlan");
            
    
            var path_ = "/users/me/billingplan/downgrade";
    
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
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DowngradeBillingPlan: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DowngradeBillingPlan: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Downgrade billing plan Downgrading a billing plan can only be done for a lower plan. The current plan will stay\nin effect until the end of the current plan&#39;s billing cycle.
        /// </summary>
        /// <param name="options"></param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DowngradeBillingPlanAsync (Options7 options)
        {
             ApiResponse<string> response = await DowngradeBillingPlanAsyncWithHttpInfo(options);
             return response.Data;

        }

        /// <summary>
        /// Downgrade billing plan Downgrading a billing plan can only be done for a lower plan. The current plan will stay\nin effect until the end of the current plan&#39;s billing cycle.
        /// </summary>
        /// <param name="options"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DowngradeBillingPlanAsyncWithHttpInfo (Options7 options)
        {
            // verify the required parameter 'options' is set
            if (options == null) throw new ApiException(400, "Missing required parameter 'options' when calling DowngradeBillingPlan");
            
    
            var path_ = "/users/me/billingplan/downgrade";
    
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
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(options); // http body (model) parameter
            

            
            // authentication (apikey) required
            
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DowngradeBillingPlan: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DowngradeBillingPlan: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
    }
    
}

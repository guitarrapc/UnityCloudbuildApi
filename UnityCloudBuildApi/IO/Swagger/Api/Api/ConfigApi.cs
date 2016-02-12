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
    public interface IConfigApi
    {
        
        /// <summary>
        /// List all unity versions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>List&lt;InlineResponse20013&gt;</returns>
        List<InlineResponse20013> ListUnityVersions ();
  
        /// <summary>
        /// List all unity versions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of List&lt;InlineResponse20013&gt;</returns>
        ApiResponse<List<InlineResponse20013>> ListUnityVersionsWithHttpInfo ();

        /// <summary>
        /// List all unity versions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of List&lt;InlineResponse20013&gt;</returns>
        System.Threading.Tasks.Task<List<InlineResponse20013>> ListUnityVersionsAsync ();

        /// <summary>
        /// List all unity versions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (List&lt;InlineResponse20013&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<InlineResponse20013>>> ListUnityVersionsAsyncWithHttpInfo ();
        
        /// <summary>
        /// List all xcode versions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>List&lt;InlineResponse20014&gt;</returns>
        List<InlineResponse20014> ListXcodeVersions ();
  
        /// <summary>
        /// List all xcode versions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>ApiResponse of List&lt;InlineResponse20014&gt;</returns>
        ApiResponse<List<InlineResponse20014>> ListXcodeVersionsWithHttpInfo ();

        /// <summary>
        /// List all xcode versions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of List&lt;InlineResponse20014&gt;</returns>
        System.Threading.Tasks.Task<List<InlineResponse20014>> ListXcodeVersionsAsync ();

        /// <summary>
        /// List all xcode versions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>Task of ApiResponse (List&lt;InlineResponse20014&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<InlineResponse20014>>> ListXcodeVersionsAsyncWithHttpInfo ();
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ConfigApi : IConfigApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConfigApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ConfigApi(Configuration configuration = null)
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
        /// List all unity versions 
        /// </summary>
        /// <returns>List&lt;InlineResponse20013&gt;</returns>
        public List<InlineResponse20013> ListUnityVersions ()
        {
             ApiResponse<List<InlineResponse20013>> response = ListUnityVersionsWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// List all unity versions 
        /// </summary>
        /// <returns>ApiResponse of List&lt;InlineResponse20013&gt;</returns>
        public ApiResponse< List<InlineResponse20013> > ListUnityVersionsWithHttpInfo ()
        {
            
    
            var path_ = "/versions/unity";
    
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
                throw new ApiException (statusCode, "Error calling ListUnityVersions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListUnityVersions: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<InlineResponse20013>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InlineResponse20013>) Configuration.ApiClient.Deserialize(response, typeof(List<InlineResponse20013>)));
            
        }
    
        /// <summary>
        /// List all unity versions 
        /// </summary>
        /// <returns>Task of List&lt;InlineResponse20013&gt;</returns>
        public async System.Threading.Tasks.Task<List<InlineResponse20013>> ListUnityVersionsAsync ()
        {
             ApiResponse<List<InlineResponse20013>> response = await ListUnityVersionsAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// List all unity versions 
        /// </summary>
        /// <returns>Task of ApiResponse (List&lt;InlineResponse20013&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<InlineResponse20013>>> ListUnityVersionsAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/versions/unity";
    
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
                throw new ApiException (statusCode, "Error calling ListUnityVersions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListUnityVersions: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<InlineResponse20013>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InlineResponse20013>) Configuration.ApiClient.Deserialize(response, typeof(List<InlineResponse20013>)));
            
        }
        
        /// <summary>
        /// List all xcode versions 
        /// </summary>
        /// <returns>List&lt;InlineResponse20014&gt;</returns>
        public List<InlineResponse20014> ListXcodeVersions ()
        {
             ApiResponse<List<InlineResponse20014>> response = ListXcodeVersionsWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// List all xcode versions 
        /// </summary>
        /// <returns>ApiResponse of List&lt;InlineResponse20014&gt;</returns>
        public ApiResponse< List<InlineResponse20014> > ListXcodeVersionsWithHttpInfo ()
        {
            
    
            var path_ = "/versions/xcode";
    
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
                throw new ApiException (statusCode, "Error calling ListXcodeVersions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListXcodeVersions: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<InlineResponse20014>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InlineResponse20014>) Configuration.ApiClient.Deserialize(response, typeof(List<InlineResponse20014>)));
            
        }
    
        /// <summary>
        /// List all xcode versions 
        /// </summary>
        /// <returns>Task of List&lt;InlineResponse20014&gt;</returns>
        public async System.Threading.Tasks.Task<List<InlineResponse20014>> ListXcodeVersionsAsync ()
        {
             ApiResponse<List<InlineResponse20014>> response = await ListXcodeVersionsAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// List all xcode versions 
        /// </summary>
        /// <returns>Task of ApiResponse (List&lt;InlineResponse20014&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<InlineResponse20014>>> ListXcodeVersionsAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/versions/xcode";
    
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
                throw new ApiException (statusCode, "Error calling ListXcodeVersions: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListXcodeVersions: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<InlineResponse20014>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InlineResponse20014>) Configuration.ApiClient.Deserialize(response, typeof(List<InlineResponse20014>)));
            
        }
        
    }
    
}

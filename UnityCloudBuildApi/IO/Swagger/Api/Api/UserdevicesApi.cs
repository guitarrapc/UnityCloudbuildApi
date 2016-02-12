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
    public interface IUserdevicesApi
    {
        
        /// <summary>
        /// List iOS device profiles
        /// </summary>
        /// <remarks>
        /// List all iOS device profiles for the current user
        /// </remarks>
        /// <returns>List&lt;InlineResponse20012&gt;</returns>
        List<InlineResponse20012> ListDevicesForUser ();
  
        /// <summary>
        /// List iOS device profiles
        /// </summary>
        /// <remarks>
        /// List all iOS device profiles for the current user
        /// </remarks>
        /// <returns>ApiResponse of List&lt;InlineResponse20012&gt;</returns>
        ApiResponse<List<InlineResponse20012>> ListDevicesForUserWithHttpInfo ();

        /// <summary>
        /// List iOS device profiles
        /// </summary>
        /// <remarks>
        /// List all iOS device profiles for the current user
        /// </remarks>
        /// <returns>Task of List&lt;InlineResponse20012&gt;</returns>
        System.Threading.Tasks.Task<List<InlineResponse20012>> ListDevicesForUserAsync ();

        /// <summary>
        /// List iOS device profiles
        /// </summary>
        /// <remarks>
        /// List all iOS device profiles for the current user
        /// </remarks>
        /// <returns>Task of ApiResponse (List&lt;InlineResponse20012&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<InlineResponse20012>>> ListDevicesForUserAsyncWithHttpInfo ();
        
        /// <summary>
        /// Create iOS device profile
        /// </summary>
        /// <remarks>
        /// Create iOS device profile for the current user
        /// </remarks>
        /// <param name="options"></param>
        /// <returns>InlineResponse20012</returns>
        InlineResponse20012 CreateDevice (Options8 options);
  
        /// <summary>
        /// Create iOS device profile
        /// </summary>
        /// <remarks>
        /// Create iOS device profile for the current user
        /// </remarks>
        /// <param name="options"></param>
        /// <returns>ApiResponse of InlineResponse20012</returns>
        ApiResponse<InlineResponse20012> CreateDeviceWithHttpInfo (Options8 options);

        /// <summary>
        /// Create iOS device profile
        /// </summary>
        /// <remarks>
        /// Create iOS device profile for the current user
        /// </remarks>
        /// <param name="options"></param>
        /// <returns>Task of InlineResponse20012</returns>
        System.Threading.Tasks.Task<InlineResponse20012> CreateDeviceAsync (Options8 options);

        /// <summary>
        /// Create iOS device profile
        /// </summary>
        /// <remarks>
        /// Create iOS device profile for the current user
        /// </remarks>
        /// <param name="options"></param>
        /// <returns>Task of ApiResponse (InlineResponse20012)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20012>> CreateDeviceAsyncWithHttpInfo (Options8 options);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UserdevicesApi : IUserdevicesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserdevicesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserdevicesApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserdevicesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UserdevicesApi(Configuration configuration = null)
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
        /// List iOS device profiles List all iOS device profiles for the current user
        /// </summary>
        /// <returns>List&lt;InlineResponse20012&gt;</returns>
        public List<InlineResponse20012> ListDevicesForUser ()
        {
             ApiResponse<List<InlineResponse20012>> response = ListDevicesForUserWithHttpInfo();
             return response.Data;
        }

        /// <summary>
        /// List iOS device profiles List all iOS device profiles for the current user
        /// </summary>
        /// <returns>ApiResponse of List&lt;InlineResponse20012&gt;</returns>
        public ApiResponse< List<InlineResponse20012> > ListDevicesForUserWithHttpInfo ()
        {
            
    
            var path_ = "/users/me/devices";
    
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
                throw new ApiException (statusCode, "Error calling ListDevicesForUser: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListDevicesForUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<InlineResponse20012>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InlineResponse20012>) Configuration.ApiClient.Deserialize(response, typeof(List<InlineResponse20012>)));
            
        }
    
        /// <summary>
        /// List iOS device profiles List all iOS device profiles for the current user
        /// </summary>
        /// <returns>Task of List&lt;InlineResponse20012&gt;</returns>
        public async System.Threading.Tasks.Task<List<InlineResponse20012>> ListDevicesForUserAsync ()
        {
             ApiResponse<List<InlineResponse20012>> response = await ListDevicesForUserAsyncWithHttpInfo();
             return response.Data;

        }

        /// <summary>
        /// List iOS device profiles List all iOS device profiles for the current user
        /// </summary>
        /// <returns>Task of ApiResponse (List&lt;InlineResponse20012&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<InlineResponse20012>>> ListDevicesForUserAsyncWithHttpInfo ()
        {
            
    
            var path_ = "/users/me/devices";
    
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
                throw new ApiException (statusCode, "Error calling ListDevicesForUser: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling ListDevicesForUser: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<InlineResponse20012>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InlineResponse20012>) Configuration.ApiClient.Deserialize(response, typeof(List<InlineResponse20012>)));
            
        }
        
        /// <summary>
        /// Create iOS device profile Create iOS device profile for the current user
        /// </summary>
        /// <param name="options"></param> 
        /// <returns>InlineResponse20012</returns>
        public InlineResponse20012 CreateDevice (Options8 options)
        {
             ApiResponse<InlineResponse20012> response = CreateDeviceWithHttpInfo(options);
             return response.Data;
        }

        /// <summary>
        /// Create iOS device profile Create iOS device profile for the current user
        /// </summary>
        /// <param name="options"></param> 
        /// <returns>ApiResponse of InlineResponse20012</returns>
        public ApiResponse< InlineResponse20012 > CreateDeviceWithHttpInfo (Options8 options)
        {
            
            // verify the required parameter 'options' is set
            if (options == null)
                throw new ApiException(400, "Missing required parameter 'options' when calling UserdevicesApi->CreateDevice");
            
    
            var path_ = "/users/me/devices";
    
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
                throw new ApiException (statusCode, "Error calling CreateDevice: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateDevice: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse20012>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20012) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20012)));
            
        }
    
        /// <summary>
        /// Create iOS device profile Create iOS device profile for the current user
        /// </summary>
        /// <param name="options"></param>
        /// <returns>Task of InlineResponse20012</returns>
        public async System.Threading.Tasks.Task<InlineResponse20012> CreateDeviceAsync (Options8 options)
        {
             ApiResponse<InlineResponse20012> response = await CreateDeviceAsyncWithHttpInfo(options);
             return response.Data;

        }

        /// <summary>
        /// Create iOS device profile Create iOS device profile for the current user
        /// </summary>
        /// <param name="options"></param>
        /// <returns>Task of ApiResponse (InlineResponse20012)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20012>> CreateDeviceAsyncWithHttpInfo (Options8 options)
        {
            // verify the required parameter 'options' is set
            if (options == null) throw new ApiException(400, "Missing required parameter 'options' when calling CreateDevice");
            
    
            var path_ = "/users/me/devices";
    
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
                throw new ApiException (statusCode, "Error calling CreateDevice: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateDevice: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse20012>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20012) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse20012)));
            
        }
        
    }
    
}

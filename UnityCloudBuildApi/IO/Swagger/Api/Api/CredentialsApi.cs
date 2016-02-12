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
    public interface ICredentialsApi
    {
        
        /// <summary>
        /// Get All Android Credentials
        /// </summary>
        /// <remarks>
        /// Get all credentials available for the project. A user in the\nprojects org will see all credentials uploaded for any project\nwithin the org, whereas a user with project-level permissions\nwill only see credentials assigned to the specific project.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>List&lt;InlineResponse2005&gt;</returns>
        List<InlineResponse2005> GetAllAndroid (string orgid, string projectid);
  
        /// <summary>
        /// Get All Android Credentials
        /// </summary>
        /// <remarks>
        /// Get all credentials available for the project. A user in the\nprojects org will see all credentials uploaded for any project\nwithin the org, whereas a user with project-level permissions\nwill only see credentials assigned to the specific project.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>ApiResponse of List&lt;InlineResponse2005&gt;</returns>
        ApiResponse<List<InlineResponse2005>> GetAllAndroidWithHttpInfo (string orgid, string projectid);

        /// <summary>
        /// Get All Android Credentials
        /// </summary>
        /// <remarks>
        /// Get all credentials available for the project. A user in the\nprojects org will see all credentials uploaded for any project\nwithin the org, whereas a user with project-level permissions\nwill only see credentials assigned to the specific project.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>Task of List&lt;InlineResponse2005&gt;</returns>
        System.Threading.Tasks.Task<List<InlineResponse2005>> GetAllAndroidAsync (string orgid, string projectid);

        /// <summary>
        /// Get All Android Credentials
        /// </summary>
        /// <remarks>
        /// Get all credentials available for the project. A user in the\nprojects org will see all credentials uploaded for any project\nwithin the org, whereas a user with project-level permissions\nwill only see credentials assigned to the specific project.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>Task of ApiResponse (List&lt;InlineResponse2005&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<InlineResponse2005>>> GetAllAndroidAsyncWithHttpInfo (string orgid, string projectid);
        
        /// <summary>
        /// Upload Android Credentials
        /// </summary>
        /// <remarks>
        /// Upload a new android keystore for the project. NOTE: you must\nbe a manager in the project&#39;s organization to add new credentials.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="label">Label for the uploaded credential</param>
        /// <param name="file">Keystore file</param>
        /// <param name="alias">Keystore alias</param>
        /// <param name="keypass">Keystore keypass</param>
        /// <param name="storepass">Keystore storepass</param>
        /// <returns>InlineResponse2005</returns>
        InlineResponse2005 AddCredentialsAndroid (string orgid, string projectid, string label, Stream file, string alias, string keypass, string storepass);
  
        /// <summary>
        /// Upload Android Credentials
        /// </summary>
        /// <remarks>
        /// Upload a new android keystore for the project. NOTE: you must\nbe a manager in the project&#39;s organization to add new credentials.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="label">Label for the uploaded credential</param>
        /// <param name="file">Keystore file</param>
        /// <param name="alias">Keystore alias</param>
        /// <param name="keypass">Keystore keypass</param>
        /// <param name="storepass">Keystore storepass</param>
        /// <returns>ApiResponse of InlineResponse2005</returns>
        ApiResponse<InlineResponse2005> AddCredentialsAndroidWithHttpInfo (string orgid, string projectid, string label, Stream file, string alias, string keypass, string storepass);

        /// <summary>
        /// Upload Android Credentials
        /// </summary>
        /// <remarks>
        /// Upload a new android keystore for the project. NOTE: you must\nbe a manager in the project&#39;s organization to add new credentials.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="label">Label for the uploaded credential</param>
        /// <param name="file">Keystore file</param>
        /// <param name="alias">Keystore alias</param>
        /// <param name="keypass">Keystore keypass</param>
        /// <param name="storepass">Keystore storepass</param>
        /// <returns>Task of InlineResponse2005</returns>
        System.Threading.Tasks.Task<InlineResponse2005> AddCredentialsAndroidAsync (string orgid, string projectid, string label, Stream file, string alias, string keypass, string storepass);

        /// <summary>
        /// Upload Android Credentials
        /// </summary>
        /// <remarks>
        /// Upload a new android keystore for the project. NOTE: you must\nbe a manager in the project&#39;s organization to add new credentials.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="label">Label for the uploaded credential</param>
        /// <param name="file">Keystore file</param>
        /// <param name="alias">Keystore alias</param>
        /// <param name="keypass">Keystore keypass</param>
        /// <param name="storepass">Keystore storepass</param>
        /// <returns>Task of ApiResponse (InlineResponse2005)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2005>> AddCredentialsAndroidAsyncWithHttpInfo (string orgid, string projectid, string label, Stream file, string alias, string keypass, string storepass);
        
        /// <summary>
        /// Get Android Credential Details
        /// </summary>
        /// <remarks>
        /// Get specific android credential details
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="credentialid">Credential Identifier</param>
        /// <returns>InlineResponse2005</returns>
        InlineResponse2005 GetOneAndroid (string orgid, string projectid, string credentialid);
  
        /// <summary>
        /// Get Android Credential Details
        /// </summary>
        /// <remarks>
        /// Get specific android credential details
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="credentialid">Credential Identifier</param>
        /// <returns>ApiResponse of InlineResponse2005</returns>
        ApiResponse<InlineResponse2005> GetOneAndroidWithHttpInfo (string orgid, string projectid, string credentialid);

        /// <summary>
        /// Get Android Credential Details
        /// </summary>
        /// <remarks>
        /// Get specific android credential details
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="credentialid">Credential Identifier</param>
        /// <returns>Task of InlineResponse2005</returns>
        System.Threading.Tasks.Task<InlineResponse2005> GetOneAndroidAsync (string orgid, string projectid, string credentialid);

        /// <summary>
        /// Get Android Credential Details
        /// </summary>
        /// <remarks>
        /// Get specific android credential details
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="credentialid">Credential Identifier</param>
        /// <returns>Task of ApiResponse (InlineResponse2005)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2005>> GetOneAndroidAsyncWithHttpInfo (string orgid, string projectid, string credentialid);
        
        /// <summary>
        /// Update Android Credentials
        /// </summary>
        /// <remarks>
        /// Update an android keystore for the project. NOTE: you must\nbe a manager in the project&#39;s organization to add new credentials.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="credentialid">Credential Identifier</param>
        /// <param name="label">Label for the uploaded credential</param>
        /// <param name="file">Keystore file</param>
        /// <param name="alias">Keystore alias</param>
        /// <param name="keypass">Keystore keypass</param>
        /// <param name="storepass">Keystore storepass</param>
        /// <returns>InlineResponse2005</returns>
        InlineResponse2005 UpdateAndroid (string orgid, string projectid, string credentialid, string label = null, Stream file = null, string alias = null, string keypass = null, string storepass = null);
  
        /// <summary>
        /// Update Android Credentials
        /// </summary>
        /// <remarks>
        /// Update an android keystore for the project. NOTE: you must\nbe a manager in the project&#39;s organization to add new credentials.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="credentialid">Credential Identifier</param>
        /// <param name="label">Label for the uploaded credential</param>
        /// <param name="file">Keystore file</param>
        /// <param name="alias">Keystore alias</param>
        /// <param name="keypass">Keystore keypass</param>
        /// <param name="storepass">Keystore storepass</param>
        /// <returns>ApiResponse of InlineResponse2005</returns>
        ApiResponse<InlineResponse2005> UpdateAndroidWithHttpInfo (string orgid, string projectid, string credentialid, string label = null, Stream file = null, string alias = null, string keypass = null, string storepass = null);

        /// <summary>
        /// Update Android Credentials
        /// </summary>
        /// <remarks>
        /// Update an android keystore for the project. NOTE: you must\nbe a manager in the project&#39;s organization to add new credentials.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="credentialid">Credential Identifier</param>
        /// <param name="label">Label for the uploaded credential</param>
        /// <param name="file">Keystore file</param>
        /// <param name="alias">Keystore alias</param>
        /// <param name="keypass">Keystore keypass</param>
        /// <param name="storepass">Keystore storepass</param>
        /// <returns>Task of InlineResponse2005</returns>
        System.Threading.Tasks.Task<InlineResponse2005> UpdateAndroidAsync (string orgid, string projectid, string credentialid, string label = null, Stream file = null, string alias = null, string keypass = null, string storepass = null);

        /// <summary>
        /// Update Android Credentials
        /// </summary>
        /// <remarks>
        /// Update an android keystore for the project. NOTE: you must\nbe a manager in the project&#39;s organization to add new credentials.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="credentialid">Credential Identifier</param>
        /// <param name="label">Label for the uploaded credential</param>
        /// <param name="file">Keystore file</param>
        /// <param name="alias">Keystore alias</param>
        /// <param name="keypass">Keystore keypass</param>
        /// <param name="storepass">Keystore storepass</param>
        /// <returns>Task of ApiResponse (InlineResponse2005)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2005>> UpdateAndroidAsyncWithHttpInfo (string orgid, string projectid, string credentialid, string label = null, Stream file = null, string alias = null, string keypass = null, string storepass = null);
        
        /// <summary>
        /// Delete Android Credentials
        /// </summary>
        /// <remarks>
        /// Delete specific android credentials for a project. NOTE:\nyou must be a manager in the project&#39;s organization to\ndelete credentials.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="credentialid">Credential Identifier</param>
        /// <returns>string</returns>
        string DeleteAndroid (string orgid, string projectid, string credentialid);
  
        /// <summary>
        /// Delete Android Credentials
        /// </summary>
        /// <remarks>
        /// Delete specific android credentials for a project. NOTE:\nyou must be a manager in the project&#39;s organization to\ndelete credentials.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="credentialid">Credential Identifier</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteAndroidWithHttpInfo (string orgid, string projectid, string credentialid);

        /// <summary>
        /// Delete Android Credentials
        /// </summary>
        /// <remarks>
        /// Delete specific android credentials for a project. NOTE:\nyou must be a manager in the project&#39;s organization to\ndelete credentials.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="credentialid">Credential Identifier</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteAndroidAsync (string orgid, string projectid, string credentialid);

        /// <summary>
        /// Delete Android Credentials
        /// </summary>
        /// <remarks>
        /// Delete specific android credentials for a project. NOTE:\nyou must be a manager in the project&#39;s organization to\ndelete credentials.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="credentialid">Credential Identifier</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteAndroidAsyncWithHttpInfo (string orgid, string projectid, string credentialid);
        
        /// <summary>
        /// Get All iOS Credentials
        /// </summary>
        /// <remarks>
        /// Get all credentials available for the project. A user in the\nprojects org will see all credentials uploaded for any project\nwithin the org, whereas a user with project-level permissions\nwill only see credentials assigned to the specific project.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>List&lt;InlineResponse2006&gt;</returns>
        List<InlineResponse2006> GetAllIos (string orgid, string projectid);
  
        /// <summary>
        /// Get All iOS Credentials
        /// </summary>
        /// <remarks>
        /// Get all credentials available for the project. A user in the\nprojects org will see all credentials uploaded for any project\nwithin the org, whereas a user with project-level permissions\nwill only see credentials assigned to the specific project.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>ApiResponse of List&lt;InlineResponse2006&gt;</returns>
        ApiResponse<List<InlineResponse2006>> GetAllIosWithHttpInfo (string orgid, string projectid);

        /// <summary>
        /// Get All iOS Credentials
        /// </summary>
        /// <remarks>
        /// Get all credentials available for the project. A user in the\nprojects org will see all credentials uploaded for any project\nwithin the org, whereas a user with project-level permissions\nwill only see credentials assigned to the specific project.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>Task of List&lt;InlineResponse2006&gt;</returns>
        System.Threading.Tasks.Task<List<InlineResponse2006>> GetAllIosAsync (string orgid, string projectid);

        /// <summary>
        /// Get All iOS Credentials
        /// </summary>
        /// <remarks>
        /// Get all credentials available for the project. A user in the\nprojects org will see all credentials uploaded for any project\nwithin the org, whereas a user with project-level permissions\nwill only see credentials assigned to the specific project.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>Task of ApiResponse (List&lt;InlineResponse2006&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<InlineResponse2006>>> GetAllIosAsyncWithHttpInfo (string orgid, string projectid);
        
        /// <summary>
        /// Upload iOS Credentials
        /// </summary>
        /// <remarks>
        /// Upload a new iOS certificate and provisioning profile for the project.\nNOTE: you must be a manager in the project&#39;s organization to add new\ncredentials.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="label">Label for the uploaded credentials</param>
        /// <param name="fileCertificate">Certificate file (.p12)</param>
        /// <param name="fileProvisioningProfile">Provisioning Profile (.mobileprovision)</param>
        /// <param name="certificatePass">Certificate (.p12) password</param>
        /// <returns>InlineResponse2006</returns>
        InlineResponse2006 AddCredentialsIos (string orgid, string projectid, string label, Stream fileCertificate, Stream fileProvisioningProfile, string certificatePass = null);
  
        /// <summary>
        /// Upload iOS Credentials
        /// </summary>
        /// <remarks>
        /// Upload a new iOS certificate and provisioning profile for the project.\nNOTE: you must be a manager in the project&#39;s organization to add new\ncredentials.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="label">Label for the uploaded credentials</param>
        /// <param name="fileCertificate">Certificate file (.p12)</param>
        /// <param name="fileProvisioningProfile">Provisioning Profile (.mobileprovision)</param>
        /// <param name="certificatePass">Certificate (.p12) password</param>
        /// <returns>ApiResponse of InlineResponse2006</returns>
        ApiResponse<InlineResponse2006> AddCredentialsIosWithHttpInfo (string orgid, string projectid, string label, Stream fileCertificate, Stream fileProvisioningProfile, string certificatePass = null);

        /// <summary>
        /// Upload iOS Credentials
        /// </summary>
        /// <remarks>
        /// Upload a new iOS certificate and provisioning profile for the project.\nNOTE: you must be a manager in the project&#39;s organization to add new\ncredentials.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="label">Label for the uploaded credentials</param>
        /// <param name="fileCertificate">Certificate file (.p12)</param>
        /// <param name="fileProvisioningProfile">Provisioning Profile (.mobileprovision)</param>
        /// <param name="certificatePass">Certificate (.p12) password</param>
        /// <returns>Task of InlineResponse2006</returns>
        System.Threading.Tasks.Task<InlineResponse2006> AddCredentialsIosAsync (string orgid, string projectid, string label, Stream fileCertificate, Stream fileProvisioningProfile, string certificatePass = null);

        /// <summary>
        /// Upload iOS Credentials
        /// </summary>
        /// <remarks>
        /// Upload a new iOS certificate and provisioning profile for the project.\nNOTE: you must be a manager in the project&#39;s organization to add new\ncredentials.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="label">Label for the uploaded credentials</param>
        /// <param name="fileCertificate">Certificate file (.p12)</param>
        /// <param name="fileProvisioningProfile">Provisioning Profile (.mobileprovision)</param>
        /// <param name="certificatePass">Certificate (.p12) password</param>
        /// <returns>Task of ApiResponse (InlineResponse2006)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2006>> AddCredentialsIosAsyncWithHttpInfo (string orgid, string projectid, string label, Stream fileCertificate, Stream fileProvisioningProfile, string certificatePass = null);
        
        /// <summary>
        /// Get iOS Credential Details
        /// </summary>
        /// <remarks>
        /// Get specific iOS credential details
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="credentialid">Credential Identifier</param>
        /// <returns>InlineResponse2006</returns>
        InlineResponse2006 GetOneIos (string orgid, string projectid, string credentialid);
  
        /// <summary>
        /// Get iOS Credential Details
        /// </summary>
        /// <remarks>
        /// Get specific iOS credential details
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="credentialid">Credential Identifier</param>
        /// <returns>ApiResponse of InlineResponse2006</returns>
        ApiResponse<InlineResponse2006> GetOneIosWithHttpInfo (string orgid, string projectid, string credentialid);

        /// <summary>
        /// Get iOS Credential Details
        /// </summary>
        /// <remarks>
        /// Get specific iOS credential details
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="credentialid">Credential Identifier</param>
        /// <returns>Task of InlineResponse2006</returns>
        System.Threading.Tasks.Task<InlineResponse2006> GetOneIosAsync (string orgid, string projectid, string credentialid);

        /// <summary>
        /// Get iOS Credential Details
        /// </summary>
        /// <remarks>
        /// Get specific iOS credential details
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="credentialid">Credential Identifier</param>
        /// <returns>Task of ApiResponse (InlineResponse2006)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2006>> GetOneIosAsyncWithHttpInfo (string orgid, string projectid, string credentialid);
        
        /// <summary>
        /// Update iOS Credentials
        /// </summary>
        /// <remarks>
        /// Update an iOS certificate / provisioning profile for the project.\nNOTE: you must be a manager in the project&#39;s organization to update\ncredentials.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="credentialid">Credential Identifier</param>
        /// <param name="label">Label for the updated credentials</param>
        /// <param name="fileCertificate">Certificate file (.p12)</param>
        /// <param name="fileProvisioningProfile">Provisioning Profile (.mobileprovision)</param>
        /// <param name="certificatePass">Certificate (.p12) password</param>
        /// <returns>InlineResponse2006</returns>
        InlineResponse2006 UpdateIos (string orgid, string projectid, string credentialid, string label = null, Stream fileCertificate = null, Stream fileProvisioningProfile = null, string certificatePass = null);
  
        /// <summary>
        /// Update iOS Credentials
        /// </summary>
        /// <remarks>
        /// Update an iOS certificate / provisioning profile for the project.\nNOTE: you must be a manager in the project&#39;s organization to update\ncredentials.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="credentialid">Credential Identifier</param>
        /// <param name="label">Label for the updated credentials</param>
        /// <param name="fileCertificate">Certificate file (.p12)</param>
        /// <param name="fileProvisioningProfile">Provisioning Profile (.mobileprovision)</param>
        /// <param name="certificatePass">Certificate (.p12) password</param>
        /// <returns>ApiResponse of InlineResponse2006</returns>
        ApiResponse<InlineResponse2006> UpdateIosWithHttpInfo (string orgid, string projectid, string credentialid, string label = null, Stream fileCertificate = null, Stream fileProvisioningProfile = null, string certificatePass = null);

        /// <summary>
        /// Update iOS Credentials
        /// </summary>
        /// <remarks>
        /// Update an iOS certificate / provisioning profile for the project.\nNOTE: you must be a manager in the project&#39;s organization to update\ncredentials.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="credentialid">Credential Identifier</param>
        /// <param name="label">Label for the updated credentials</param>
        /// <param name="fileCertificate">Certificate file (.p12)</param>
        /// <param name="fileProvisioningProfile">Provisioning Profile (.mobileprovision)</param>
        /// <param name="certificatePass">Certificate (.p12) password</param>
        /// <returns>Task of InlineResponse2006</returns>
        System.Threading.Tasks.Task<InlineResponse2006> UpdateIosAsync (string orgid, string projectid, string credentialid, string label = null, Stream fileCertificate = null, Stream fileProvisioningProfile = null, string certificatePass = null);

        /// <summary>
        /// Update iOS Credentials
        /// </summary>
        /// <remarks>
        /// Update an iOS certificate / provisioning profile for the project.\nNOTE: you must be a manager in the project&#39;s organization to update\ncredentials.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="credentialid">Credential Identifier</param>
        /// <param name="label">Label for the updated credentials</param>
        /// <param name="fileCertificate">Certificate file (.p12)</param>
        /// <param name="fileProvisioningProfile">Provisioning Profile (.mobileprovision)</param>
        /// <param name="certificatePass">Certificate (.p12) password</param>
        /// <returns>Task of ApiResponse (InlineResponse2006)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2006>> UpdateIosAsyncWithHttpInfo (string orgid, string projectid, string credentialid, string label = null, Stream fileCertificate = null, Stream fileProvisioningProfile = null, string certificatePass = null);
        
        /// <summary>
        /// Delete iOS Credentials
        /// </summary>
        /// <remarks>
        /// Delete specific ios credentials for a project. NOTE:\nyou must be a manager in the project&#39;s organization to\ndelete credentials.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="credentialid">Credential Identifier</param>
        /// <returns>string</returns>
        string DeleteIos (string orgid, string projectid, string credentialid);
  
        /// <summary>
        /// Delete iOS Credentials
        /// </summary>
        /// <remarks>
        /// Delete specific ios credentials for a project. NOTE:\nyou must be a manager in the project&#39;s organization to\ndelete credentials.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="credentialid">Credential Identifier</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteIosWithHttpInfo (string orgid, string projectid, string credentialid);

        /// <summary>
        /// Delete iOS Credentials
        /// </summary>
        /// <remarks>
        /// Delete specific ios credentials for a project. NOTE:\nyou must be a manager in the project&#39;s organization to\ndelete credentials.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="credentialid">Credential Identifier</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteIosAsync (string orgid, string projectid, string credentialid);

        /// <summary>
        /// Delete iOS Credentials
        /// </summary>
        /// <remarks>
        /// Delete specific ios credentials for a project. NOTE:\nyou must be a manager in the project&#39;s organization to\ndelete credentials.
        /// </remarks>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="credentialid">Credential Identifier</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteIosAsyncWithHttpInfo (string orgid, string projectid, string credentialid);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CredentialsApi : ICredentialsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CredentialsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CredentialsApi(Configuration configuration = null)
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
        /// Get All Android Credentials Get all credentials available for the project. A user in the\nprojects org will see all credentials uploaded for any project\nwithin the org, whereas a user with project-level permissions\nwill only see credentials assigned to the specific project.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <returns>List&lt;InlineResponse2005&gt;</returns>
        public List<InlineResponse2005> GetAllAndroid (string orgid, string projectid)
        {
             ApiResponse<List<InlineResponse2005>> response = GetAllAndroidWithHttpInfo(orgid, projectid);
             return response.Data;
        }

        /// <summary>
        /// Get All Android Credentials Get all credentials available for the project. A user in the\nprojects org will see all credentials uploaded for any project\nwithin the org, whereas a user with project-level permissions\nwill only see credentials assigned to the specific project.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <returns>ApiResponse of List&lt;InlineResponse2005&gt;</returns>
        public ApiResponse< List<InlineResponse2005> > GetAllAndroidWithHttpInfo (string orgid, string projectid)
        {
            
            // verify the required parameter 'orgid' is set
            if (orgid == null)
                throw new ApiException(400, "Missing required parameter 'orgid' when calling CredentialsApi->GetAllAndroid");
            
            // verify the required parameter 'projectid' is set
            if (projectid == null)
                throw new ApiException(400, "Missing required parameter 'projectid' when calling CredentialsApi->GetAllAndroid");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/credentials/signing/android";
    
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
                throw new ApiException (statusCode, "Error calling GetAllAndroid: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetAllAndroid: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<InlineResponse2005>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InlineResponse2005>) Configuration.ApiClient.Deserialize(response, typeof(List<InlineResponse2005>)));
            
        }
    
        /// <summary>
        /// Get All Android Credentials Get all credentials available for the project. A user in the\nprojects org will see all credentials uploaded for any project\nwithin the org, whereas a user with project-level permissions\nwill only see credentials assigned to the specific project.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>Task of List&lt;InlineResponse2005&gt;</returns>
        public async System.Threading.Tasks.Task<List<InlineResponse2005>> GetAllAndroidAsync (string orgid, string projectid)
        {
             ApiResponse<List<InlineResponse2005>> response = await GetAllAndroidAsyncWithHttpInfo(orgid, projectid);
             return response.Data;

        }

        /// <summary>
        /// Get All Android Credentials Get all credentials available for the project. A user in the\nprojects org will see all credentials uploaded for any project\nwithin the org, whereas a user with project-level permissions\nwill only see credentials assigned to the specific project.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>Task of ApiResponse (List&lt;InlineResponse2005&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<InlineResponse2005>>> GetAllAndroidAsyncWithHttpInfo (string orgid, string projectid)
        {
            // verify the required parameter 'orgid' is set
            if (orgid == null) throw new ApiException(400, "Missing required parameter 'orgid' when calling GetAllAndroid");
            // verify the required parameter 'projectid' is set
            if (projectid == null) throw new ApiException(400, "Missing required parameter 'projectid' when calling GetAllAndroid");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/credentials/signing/android";
    
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
                throw new ApiException (statusCode, "Error calling GetAllAndroid: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetAllAndroid: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<InlineResponse2005>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InlineResponse2005>) Configuration.ApiClient.Deserialize(response, typeof(List<InlineResponse2005>)));
            
        }
        
        /// <summary>
        /// Upload Android Credentials Upload a new android keystore for the project. NOTE: you must\nbe a manager in the project&#39;s organization to add new credentials.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="label">Label for the uploaded credential</param> 
        /// <param name="file">Keystore file</param> 
        /// <param name="alias">Keystore alias</param> 
        /// <param name="keypass">Keystore keypass</param> 
        /// <param name="storepass">Keystore storepass</param> 
        /// <returns>InlineResponse2005</returns>
        public InlineResponse2005 AddCredentialsAndroid (string orgid, string projectid, string label, Stream file, string alias, string keypass, string storepass)
        {
             ApiResponse<InlineResponse2005> response = AddCredentialsAndroidWithHttpInfo(orgid, projectid, label, file, alias, keypass, storepass);
             return response.Data;
        }

        /// <summary>
        /// Upload Android Credentials Upload a new android keystore for the project. NOTE: you must\nbe a manager in the project&#39;s organization to add new credentials.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="label">Label for the uploaded credential</param> 
        /// <param name="file">Keystore file</param> 
        /// <param name="alias">Keystore alias</param> 
        /// <param name="keypass">Keystore keypass</param> 
        /// <param name="storepass">Keystore storepass</param> 
        /// <returns>ApiResponse of InlineResponse2005</returns>
        public ApiResponse< InlineResponse2005 > AddCredentialsAndroidWithHttpInfo (string orgid, string projectid, string label, Stream file, string alias, string keypass, string storepass)
        {
            
            // verify the required parameter 'orgid' is set
            if (orgid == null)
                throw new ApiException(400, "Missing required parameter 'orgid' when calling CredentialsApi->AddCredentialsAndroid");
            
            // verify the required parameter 'projectid' is set
            if (projectid == null)
                throw new ApiException(400, "Missing required parameter 'projectid' when calling CredentialsApi->AddCredentialsAndroid");
            
            // verify the required parameter 'label' is set
            if (label == null)
                throw new ApiException(400, "Missing required parameter 'label' when calling CredentialsApi->AddCredentialsAndroid");
            
            // verify the required parameter 'file' is set
            if (file == null)
                throw new ApiException(400, "Missing required parameter 'file' when calling CredentialsApi->AddCredentialsAndroid");
            
            // verify the required parameter 'alias' is set
            if (alias == null)
                throw new ApiException(400, "Missing required parameter 'alias' when calling CredentialsApi->AddCredentialsAndroid");
            
            // verify the required parameter 'keypass' is set
            if (keypass == null)
                throw new ApiException(400, "Missing required parameter 'keypass' when calling CredentialsApi->AddCredentialsAndroid");
            
            // verify the required parameter 'storepass' is set
            if (storepass == null)
                throw new ApiException(400, "Missing required parameter 'storepass' when calling CredentialsApi->AddCredentialsAndroid");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/credentials/signing/android";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "multipart/form-data"
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
            
            
            
            if (label != null) formParams.Add("label", Configuration.ApiClient.ParameterToString(label)); // form parameter
            if (file != null) fileParams.Add("file", Configuration.ApiClient.ParameterToFile("file", file));
            if (alias != null) formParams.Add("alias", Configuration.ApiClient.ParameterToString(alias)); // form parameter
            if (keypass != null) formParams.Add("keypass", Configuration.ApiClient.ParameterToString(keypass)); // form parameter
            if (storepass != null) formParams.Add("storepass", Configuration.ApiClient.ParameterToString(storepass)); // form parameter
            
            

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
                throw new ApiException (statusCode, "Error calling AddCredentialsAndroid: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AddCredentialsAndroid: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2005>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2005) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2005)));
            
        }
    
        /// <summary>
        /// Upload Android Credentials Upload a new android keystore for the project. NOTE: you must\nbe a manager in the project&#39;s organization to add new credentials.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="label">Label for the uploaded credential</param>
        /// <param name="file">Keystore file</param>
        /// <param name="alias">Keystore alias</param>
        /// <param name="keypass">Keystore keypass</param>
        /// <param name="storepass">Keystore storepass</param>
        /// <returns>Task of InlineResponse2005</returns>
        public async System.Threading.Tasks.Task<InlineResponse2005> AddCredentialsAndroidAsync (string orgid, string projectid, string label, Stream file, string alias, string keypass, string storepass)
        {
             ApiResponse<InlineResponse2005> response = await AddCredentialsAndroidAsyncWithHttpInfo(orgid, projectid, label, file, alias, keypass, storepass);
             return response.Data;

        }

        /// <summary>
        /// Upload Android Credentials Upload a new android keystore for the project. NOTE: you must\nbe a manager in the project&#39;s organization to add new credentials.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="label">Label for the uploaded credential</param>
        /// <param name="file">Keystore file</param>
        /// <param name="alias">Keystore alias</param>
        /// <param name="keypass">Keystore keypass</param>
        /// <param name="storepass">Keystore storepass</param>
        /// <returns>Task of ApiResponse (InlineResponse2005)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2005>> AddCredentialsAndroidAsyncWithHttpInfo (string orgid, string projectid, string label, Stream file, string alias, string keypass, string storepass)
        {
            // verify the required parameter 'orgid' is set
            if (orgid == null) throw new ApiException(400, "Missing required parameter 'orgid' when calling AddCredentialsAndroid");
            // verify the required parameter 'projectid' is set
            if (projectid == null) throw new ApiException(400, "Missing required parameter 'projectid' when calling AddCredentialsAndroid");
            // verify the required parameter 'label' is set
            if (label == null) throw new ApiException(400, "Missing required parameter 'label' when calling AddCredentialsAndroid");
            // verify the required parameter 'file' is set
            if (file == null) throw new ApiException(400, "Missing required parameter 'file' when calling AddCredentialsAndroid");
            // verify the required parameter 'alias' is set
            if (alias == null) throw new ApiException(400, "Missing required parameter 'alias' when calling AddCredentialsAndroid");
            // verify the required parameter 'keypass' is set
            if (keypass == null) throw new ApiException(400, "Missing required parameter 'keypass' when calling AddCredentialsAndroid");
            // verify the required parameter 'storepass' is set
            if (storepass == null) throw new ApiException(400, "Missing required parameter 'storepass' when calling AddCredentialsAndroid");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/credentials/signing/android";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "multipart/form-data"
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
            
            
            
            if (label != null) formParams.Add("label", Configuration.ApiClient.ParameterToString(label)); // form parameter
            if (file != null) fileParams.Add("file", Configuration.ApiClient.ParameterToFile("file", file));
            if (alias != null) formParams.Add("alias", Configuration.ApiClient.ParameterToString(alias)); // form parameter
            if (keypass != null) formParams.Add("keypass", Configuration.ApiClient.ParameterToString(keypass)); // form parameter
            if (storepass != null) formParams.Add("storepass", Configuration.ApiClient.ParameterToString(storepass)); // form parameter
            
            

            
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
                throw new ApiException (statusCode, "Error calling AddCredentialsAndroid: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AddCredentialsAndroid: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2005>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2005) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2005)));
            
        }
        
        /// <summary>
        /// Get Android Credential Details Get specific android credential details
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="credentialid">Credential Identifier</param> 
        /// <returns>InlineResponse2005</returns>
        public InlineResponse2005 GetOneAndroid (string orgid, string projectid, string credentialid)
        {
             ApiResponse<InlineResponse2005> response = GetOneAndroidWithHttpInfo(orgid, projectid, credentialid);
             return response.Data;
        }

        /// <summary>
        /// Get Android Credential Details Get specific android credential details
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="credentialid">Credential Identifier</param> 
        /// <returns>ApiResponse of InlineResponse2005</returns>
        public ApiResponse< InlineResponse2005 > GetOneAndroidWithHttpInfo (string orgid, string projectid, string credentialid)
        {
            
            // verify the required parameter 'orgid' is set
            if (orgid == null)
                throw new ApiException(400, "Missing required parameter 'orgid' when calling CredentialsApi->GetOneAndroid");
            
            // verify the required parameter 'projectid' is set
            if (projectid == null)
                throw new ApiException(400, "Missing required parameter 'projectid' when calling CredentialsApi->GetOneAndroid");
            
            // verify the required parameter 'credentialid' is set
            if (credentialid == null)
                throw new ApiException(400, "Missing required parameter 'credentialid' when calling CredentialsApi->GetOneAndroid");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/credentials/signing/android/{credentialid}";
    
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
            if (credentialid != null) pathParams.Add("credentialid", Configuration.ApiClient.ParameterToString(credentialid)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetOneAndroid: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetOneAndroid: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2005>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2005) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2005)));
            
        }
    
        /// <summary>
        /// Get Android Credential Details Get specific android credential details
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="credentialid">Credential Identifier</param>
        /// <returns>Task of InlineResponse2005</returns>
        public async System.Threading.Tasks.Task<InlineResponse2005> GetOneAndroidAsync (string orgid, string projectid, string credentialid)
        {
             ApiResponse<InlineResponse2005> response = await GetOneAndroidAsyncWithHttpInfo(orgid, projectid, credentialid);
             return response.Data;

        }

        /// <summary>
        /// Get Android Credential Details Get specific android credential details
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="credentialid">Credential Identifier</param>
        /// <returns>Task of ApiResponse (InlineResponse2005)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2005>> GetOneAndroidAsyncWithHttpInfo (string orgid, string projectid, string credentialid)
        {
            // verify the required parameter 'orgid' is set
            if (orgid == null) throw new ApiException(400, "Missing required parameter 'orgid' when calling GetOneAndroid");
            // verify the required parameter 'projectid' is set
            if (projectid == null) throw new ApiException(400, "Missing required parameter 'projectid' when calling GetOneAndroid");
            // verify the required parameter 'credentialid' is set
            if (credentialid == null) throw new ApiException(400, "Missing required parameter 'credentialid' when calling GetOneAndroid");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/credentials/signing/android/{credentialid}";
    
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
            if (credentialid != null) pathParams.Add("credentialid", Configuration.ApiClient.ParameterToString(credentialid)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetOneAndroid: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetOneAndroid: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2005>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2005) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2005)));
            
        }
        
        /// <summary>
        /// Update Android Credentials Update an android keystore for the project. NOTE: you must\nbe a manager in the project&#39;s organization to add new credentials.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="credentialid">Credential Identifier</param> 
        /// <param name="label">Label for the uploaded credential</param> 
        /// <param name="file">Keystore file</param> 
        /// <param name="alias">Keystore alias</param> 
        /// <param name="keypass">Keystore keypass</param> 
        /// <param name="storepass">Keystore storepass</param> 
        /// <returns>InlineResponse2005</returns>
        public InlineResponse2005 UpdateAndroid (string orgid, string projectid, string credentialid, string label = null, Stream file = null, string alias = null, string keypass = null, string storepass = null)
        {
             ApiResponse<InlineResponse2005> response = UpdateAndroidWithHttpInfo(orgid, projectid, credentialid, label, file, alias, keypass, storepass);
             return response.Data;
        }

        /// <summary>
        /// Update Android Credentials Update an android keystore for the project. NOTE: you must\nbe a manager in the project&#39;s organization to add new credentials.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="credentialid">Credential Identifier</param> 
        /// <param name="label">Label for the uploaded credential</param> 
        /// <param name="file">Keystore file</param> 
        /// <param name="alias">Keystore alias</param> 
        /// <param name="keypass">Keystore keypass</param> 
        /// <param name="storepass">Keystore storepass</param> 
        /// <returns>ApiResponse of InlineResponse2005</returns>
        public ApiResponse< InlineResponse2005 > UpdateAndroidWithHttpInfo (string orgid, string projectid, string credentialid, string label = null, Stream file = null, string alias = null, string keypass = null, string storepass = null)
        {
            
            // verify the required parameter 'orgid' is set
            if (orgid == null)
                throw new ApiException(400, "Missing required parameter 'orgid' when calling CredentialsApi->UpdateAndroid");
            
            // verify the required parameter 'projectid' is set
            if (projectid == null)
                throw new ApiException(400, "Missing required parameter 'projectid' when calling CredentialsApi->UpdateAndroid");
            
            // verify the required parameter 'credentialid' is set
            if (credentialid == null)
                throw new ApiException(400, "Missing required parameter 'credentialid' when calling CredentialsApi->UpdateAndroid");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/credentials/signing/android/{credentialid}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "multipart/form-data"
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
            if (credentialid != null) pathParams.Add("credentialid", Configuration.ApiClient.ParameterToString(credentialid)); // path parameter
            
            
            
            if (label != null) formParams.Add("label", Configuration.ApiClient.ParameterToString(label)); // form parameter
            if (file != null) fileParams.Add("file", Configuration.ApiClient.ParameterToFile("file", file));
            if (alias != null) formParams.Add("alias", Configuration.ApiClient.ParameterToString(alias)); // form parameter
            if (keypass != null) formParams.Add("keypass", Configuration.ApiClient.ParameterToString(keypass)); // form parameter
            if (storepass != null) formParams.Add("storepass", Configuration.ApiClient.ParameterToString(storepass)); // form parameter
            
            

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
                throw new ApiException (statusCode, "Error calling UpdateAndroid: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateAndroid: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2005>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2005) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2005)));
            
        }
    
        /// <summary>
        /// Update Android Credentials Update an android keystore for the project. NOTE: you must\nbe a manager in the project&#39;s organization to add new credentials.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="credentialid">Credential Identifier</param>
        /// <param name="label">Label for the uploaded credential</param>
        /// <param name="file">Keystore file</param>
        /// <param name="alias">Keystore alias</param>
        /// <param name="keypass">Keystore keypass</param>
        /// <param name="storepass">Keystore storepass</param>
        /// <returns>Task of InlineResponse2005</returns>
        public async System.Threading.Tasks.Task<InlineResponse2005> UpdateAndroidAsync (string orgid, string projectid, string credentialid, string label = null, Stream file = null, string alias = null, string keypass = null, string storepass = null)
        {
             ApiResponse<InlineResponse2005> response = await UpdateAndroidAsyncWithHttpInfo(orgid, projectid, credentialid, label, file, alias, keypass, storepass);
             return response.Data;

        }

        /// <summary>
        /// Update Android Credentials Update an android keystore for the project. NOTE: you must\nbe a manager in the project&#39;s organization to add new credentials.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="credentialid">Credential Identifier</param>
        /// <param name="label">Label for the uploaded credential</param>
        /// <param name="file">Keystore file</param>
        /// <param name="alias">Keystore alias</param>
        /// <param name="keypass">Keystore keypass</param>
        /// <param name="storepass">Keystore storepass</param>
        /// <returns>Task of ApiResponse (InlineResponse2005)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2005>> UpdateAndroidAsyncWithHttpInfo (string orgid, string projectid, string credentialid, string label = null, Stream file = null, string alias = null, string keypass = null, string storepass = null)
        {
            // verify the required parameter 'orgid' is set
            if (orgid == null) throw new ApiException(400, "Missing required parameter 'orgid' when calling UpdateAndroid");
            // verify the required parameter 'projectid' is set
            if (projectid == null) throw new ApiException(400, "Missing required parameter 'projectid' when calling UpdateAndroid");
            // verify the required parameter 'credentialid' is set
            if (credentialid == null) throw new ApiException(400, "Missing required parameter 'credentialid' when calling UpdateAndroid");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/credentials/signing/android/{credentialid}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "multipart/form-data"
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
            if (credentialid != null) pathParams.Add("credentialid", Configuration.ApiClient.ParameterToString(credentialid)); // path parameter
            
            
            
            if (label != null) formParams.Add("label", Configuration.ApiClient.ParameterToString(label)); // form parameter
            if (file != null) fileParams.Add("file", Configuration.ApiClient.ParameterToFile("file", file));
            if (alias != null) formParams.Add("alias", Configuration.ApiClient.ParameterToString(alias)); // form parameter
            if (keypass != null) formParams.Add("keypass", Configuration.ApiClient.ParameterToString(keypass)); // form parameter
            if (storepass != null) formParams.Add("storepass", Configuration.ApiClient.ParameterToString(storepass)); // form parameter
            
            

            
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
                throw new ApiException (statusCode, "Error calling UpdateAndroid: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateAndroid: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2005>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2005) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2005)));
            
        }
        
        /// <summary>
        /// Delete Android Credentials Delete specific android credentials for a project. NOTE:\nyou must be a manager in the project&#39;s organization to\ndelete credentials.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="credentialid">Credential Identifier</param> 
        /// <returns>string</returns>
        public string DeleteAndroid (string orgid, string projectid, string credentialid)
        {
             ApiResponse<string> response = DeleteAndroidWithHttpInfo(orgid, projectid, credentialid);
             return response.Data;
        }

        /// <summary>
        /// Delete Android Credentials Delete specific android credentials for a project. NOTE:\nyou must be a manager in the project&#39;s organization to\ndelete credentials.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="credentialid">Credential Identifier</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteAndroidWithHttpInfo (string orgid, string projectid, string credentialid)
        {
            
            // verify the required parameter 'orgid' is set
            if (orgid == null)
                throw new ApiException(400, "Missing required parameter 'orgid' when calling CredentialsApi->DeleteAndroid");
            
            // verify the required parameter 'projectid' is set
            if (projectid == null)
                throw new ApiException(400, "Missing required parameter 'projectid' when calling CredentialsApi->DeleteAndroid");
            
            // verify the required parameter 'credentialid' is set
            if (credentialid == null)
                throw new ApiException(400, "Missing required parameter 'credentialid' when calling CredentialsApi->DeleteAndroid");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/credentials/signing/android/{credentialid}";
    
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
            if (credentialid != null) pathParams.Add("credentialid", Configuration.ApiClient.ParameterToString(credentialid)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling DeleteAndroid: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteAndroid: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete Android Credentials Delete specific android credentials for a project. NOTE:\nyou must be a manager in the project&#39;s organization to\ndelete credentials.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="credentialid">Credential Identifier</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteAndroidAsync (string orgid, string projectid, string credentialid)
        {
             ApiResponse<string> response = await DeleteAndroidAsyncWithHttpInfo(orgid, projectid, credentialid);
             return response.Data;

        }

        /// <summary>
        /// Delete Android Credentials Delete specific android credentials for a project. NOTE:\nyou must be a manager in the project&#39;s organization to\ndelete credentials.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="credentialid">Credential Identifier</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteAndroidAsyncWithHttpInfo (string orgid, string projectid, string credentialid)
        {
            // verify the required parameter 'orgid' is set
            if (orgid == null) throw new ApiException(400, "Missing required parameter 'orgid' when calling DeleteAndroid");
            // verify the required parameter 'projectid' is set
            if (projectid == null) throw new ApiException(400, "Missing required parameter 'projectid' when calling DeleteAndroid");
            // verify the required parameter 'credentialid' is set
            if (credentialid == null) throw new ApiException(400, "Missing required parameter 'credentialid' when calling DeleteAndroid");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/credentials/signing/android/{credentialid}";
    
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
            if (credentialid != null) pathParams.Add("credentialid", Configuration.ApiClient.ParameterToString(credentialid)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteAndroid: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteAndroid: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
        /// <summary>
        /// Get All iOS Credentials Get all credentials available for the project. A user in the\nprojects org will see all credentials uploaded for any project\nwithin the org, whereas a user with project-level permissions\nwill only see credentials assigned to the specific project.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <returns>List&lt;InlineResponse2006&gt;</returns>
        public List<InlineResponse2006> GetAllIos (string orgid, string projectid)
        {
             ApiResponse<List<InlineResponse2006>> response = GetAllIosWithHttpInfo(orgid, projectid);
             return response.Data;
        }

        /// <summary>
        /// Get All iOS Credentials Get all credentials available for the project. A user in the\nprojects org will see all credentials uploaded for any project\nwithin the org, whereas a user with project-level permissions\nwill only see credentials assigned to the specific project.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <returns>ApiResponse of List&lt;InlineResponse2006&gt;</returns>
        public ApiResponse< List<InlineResponse2006> > GetAllIosWithHttpInfo (string orgid, string projectid)
        {
            
            // verify the required parameter 'orgid' is set
            if (orgid == null)
                throw new ApiException(400, "Missing required parameter 'orgid' when calling CredentialsApi->GetAllIos");
            
            // verify the required parameter 'projectid' is set
            if (projectid == null)
                throw new ApiException(400, "Missing required parameter 'projectid' when calling CredentialsApi->GetAllIos");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/credentials/signing/ios";
    
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
                throw new ApiException (statusCode, "Error calling GetAllIos: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetAllIos: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<InlineResponse2006>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InlineResponse2006>) Configuration.ApiClient.Deserialize(response, typeof(List<InlineResponse2006>)));
            
        }
    
        /// <summary>
        /// Get All iOS Credentials Get all credentials available for the project. A user in the\nprojects org will see all credentials uploaded for any project\nwithin the org, whereas a user with project-level permissions\nwill only see credentials assigned to the specific project.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>Task of List&lt;InlineResponse2006&gt;</returns>
        public async System.Threading.Tasks.Task<List<InlineResponse2006>> GetAllIosAsync (string orgid, string projectid)
        {
             ApiResponse<List<InlineResponse2006>> response = await GetAllIosAsyncWithHttpInfo(orgid, projectid);
             return response.Data;

        }

        /// <summary>
        /// Get All iOS Credentials Get all credentials available for the project. A user in the\nprojects org will see all credentials uploaded for any project\nwithin the org, whereas a user with project-level permissions\nwill only see credentials assigned to the specific project.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <returns>Task of ApiResponse (List&lt;InlineResponse2006&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<InlineResponse2006>>> GetAllIosAsyncWithHttpInfo (string orgid, string projectid)
        {
            // verify the required parameter 'orgid' is set
            if (orgid == null) throw new ApiException(400, "Missing required parameter 'orgid' when calling GetAllIos");
            // verify the required parameter 'projectid' is set
            if (projectid == null) throw new ApiException(400, "Missing required parameter 'projectid' when calling GetAllIos");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/credentials/signing/ios";
    
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
                throw new ApiException (statusCode, "Error calling GetAllIos: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetAllIos: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<InlineResponse2006>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InlineResponse2006>) Configuration.ApiClient.Deserialize(response, typeof(List<InlineResponse2006>)));
            
        }
        
        /// <summary>
        /// Upload iOS Credentials Upload a new iOS certificate and provisioning profile for the project.\nNOTE: you must be a manager in the project&#39;s organization to add new\ncredentials.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="label">Label for the uploaded credentials</param> 
        /// <param name="fileCertificate">Certificate file (.p12)</param> 
        /// <param name="fileProvisioningProfile">Provisioning Profile (.mobileprovision)</param> 
        /// <param name="certificatePass">Certificate (.p12) password</param> 
        /// <returns>InlineResponse2006</returns>
        public InlineResponse2006 AddCredentialsIos (string orgid, string projectid, string label, Stream fileCertificate, Stream fileProvisioningProfile, string certificatePass = null)
        {
             ApiResponse<InlineResponse2006> response = AddCredentialsIosWithHttpInfo(orgid, projectid, label, fileCertificate, fileProvisioningProfile, certificatePass);
             return response.Data;
        }

        /// <summary>
        /// Upload iOS Credentials Upload a new iOS certificate and provisioning profile for the project.\nNOTE: you must be a manager in the project&#39;s organization to add new\ncredentials.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="label">Label for the uploaded credentials</param> 
        /// <param name="fileCertificate">Certificate file (.p12)</param> 
        /// <param name="fileProvisioningProfile">Provisioning Profile (.mobileprovision)</param> 
        /// <param name="certificatePass">Certificate (.p12) password</param> 
        /// <returns>ApiResponse of InlineResponse2006</returns>
        public ApiResponse< InlineResponse2006 > AddCredentialsIosWithHttpInfo (string orgid, string projectid, string label, Stream fileCertificate, Stream fileProvisioningProfile, string certificatePass = null)
        {
            
            // verify the required parameter 'orgid' is set
            if (orgid == null)
                throw new ApiException(400, "Missing required parameter 'orgid' when calling CredentialsApi->AddCredentialsIos");
            
            // verify the required parameter 'projectid' is set
            if (projectid == null)
                throw new ApiException(400, "Missing required parameter 'projectid' when calling CredentialsApi->AddCredentialsIos");
            
            // verify the required parameter 'label' is set
            if (label == null)
                throw new ApiException(400, "Missing required parameter 'label' when calling CredentialsApi->AddCredentialsIos");
            
            // verify the required parameter 'fileCertificate' is set
            if (fileCertificate == null)
                throw new ApiException(400, "Missing required parameter 'fileCertificate' when calling CredentialsApi->AddCredentialsIos");
            
            // verify the required parameter 'fileProvisioningProfile' is set
            if (fileProvisioningProfile == null)
                throw new ApiException(400, "Missing required parameter 'fileProvisioningProfile' when calling CredentialsApi->AddCredentialsIos");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/credentials/signing/ios";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "multipart/form-data"
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
            
            
            
            if (label != null) formParams.Add("label", Configuration.ApiClient.ParameterToString(label)); // form parameter
            if (fileCertificate != null) fileParams.Add("fileCertificate", Configuration.ApiClient.ParameterToFile("fileCertificate", fileCertificate));
            if (fileProvisioningProfile != null) fileParams.Add("fileProvisioningProfile", Configuration.ApiClient.ParameterToFile("fileProvisioningProfile", fileProvisioningProfile));
            if (certificatePass != null) formParams.Add("certificatePass", Configuration.ApiClient.ParameterToString(certificatePass)); // form parameter
            
            

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
                throw new ApiException (statusCode, "Error calling AddCredentialsIos: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AddCredentialsIos: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2006>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2006) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2006)));
            
        }
    
        /// <summary>
        /// Upload iOS Credentials Upload a new iOS certificate and provisioning profile for the project.\nNOTE: you must be a manager in the project&#39;s organization to add new\ncredentials.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="label">Label for the uploaded credentials</param>
        /// <param name="fileCertificate">Certificate file (.p12)</param>
        /// <param name="fileProvisioningProfile">Provisioning Profile (.mobileprovision)</param>
        /// <param name="certificatePass">Certificate (.p12) password</param>
        /// <returns>Task of InlineResponse2006</returns>
        public async System.Threading.Tasks.Task<InlineResponse2006> AddCredentialsIosAsync (string orgid, string projectid, string label, Stream fileCertificate, Stream fileProvisioningProfile, string certificatePass = null)
        {
             ApiResponse<InlineResponse2006> response = await AddCredentialsIosAsyncWithHttpInfo(orgid, projectid, label, fileCertificate, fileProvisioningProfile, certificatePass);
             return response.Data;

        }

        /// <summary>
        /// Upload iOS Credentials Upload a new iOS certificate and provisioning profile for the project.\nNOTE: you must be a manager in the project&#39;s organization to add new\ncredentials.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="label">Label for the uploaded credentials</param>
        /// <param name="fileCertificate">Certificate file (.p12)</param>
        /// <param name="fileProvisioningProfile">Provisioning Profile (.mobileprovision)</param>
        /// <param name="certificatePass">Certificate (.p12) password</param>
        /// <returns>Task of ApiResponse (InlineResponse2006)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2006>> AddCredentialsIosAsyncWithHttpInfo (string orgid, string projectid, string label, Stream fileCertificate, Stream fileProvisioningProfile, string certificatePass = null)
        {
            // verify the required parameter 'orgid' is set
            if (orgid == null) throw new ApiException(400, "Missing required parameter 'orgid' when calling AddCredentialsIos");
            // verify the required parameter 'projectid' is set
            if (projectid == null) throw new ApiException(400, "Missing required parameter 'projectid' when calling AddCredentialsIos");
            // verify the required parameter 'label' is set
            if (label == null) throw new ApiException(400, "Missing required parameter 'label' when calling AddCredentialsIos");
            // verify the required parameter 'fileCertificate' is set
            if (fileCertificate == null) throw new ApiException(400, "Missing required parameter 'fileCertificate' when calling AddCredentialsIos");
            // verify the required parameter 'fileProvisioningProfile' is set
            if (fileProvisioningProfile == null) throw new ApiException(400, "Missing required parameter 'fileProvisioningProfile' when calling AddCredentialsIos");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/credentials/signing/ios";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "multipart/form-data"
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
            
            
            
            if (label != null) formParams.Add("label", Configuration.ApiClient.ParameterToString(label)); // form parameter
            if (fileCertificate != null) fileParams.Add("fileCertificate", Configuration.ApiClient.ParameterToFile("fileCertificate", fileCertificate));
            if (fileProvisioningProfile != null) fileParams.Add("fileProvisioningProfile", Configuration.ApiClient.ParameterToFile("fileProvisioningProfile", fileProvisioningProfile));
            if (certificatePass != null) formParams.Add("certificatePass", Configuration.ApiClient.ParameterToString(certificatePass)); // form parameter
            
            

            
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
                throw new ApiException (statusCode, "Error calling AddCredentialsIos: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AddCredentialsIos: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2006>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2006) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2006)));
            
        }
        
        /// <summary>
        /// Get iOS Credential Details Get specific iOS credential details
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="credentialid">Credential Identifier</param> 
        /// <returns>InlineResponse2006</returns>
        public InlineResponse2006 GetOneIos (string orgid, string projectid, string credentialid)
        {
             ApiResponse<InlineResponse2006> response = GetOneIosWithHttpInfo(orgid, projectid, credentialid);
             return response.Data;
        }

        /// <summary>
        /// Get iOS Credential Details Get specific iOS credential details
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="credentialid">Credential Identifier</param> 
        /// <returns>ApiResponse of InlineResponse2006</returns>
        public ApiResponse< InlineResponse2006 > GetOneIosWithHttpInfo (string orgid, string projectid, string credentialid)
        {
            
            // verify the required parameter 'orgid' is set
            if (orgid == null)
                throw new ApiException(400, "Missing required parameter 'orgid' when calling CredentialsApi->GetOneIos");
            
            // verify the required parameter 'projectid' is set
            if (projectid == null)
                throw new ApiException(400, "Missing required parameter 'projectid' when calling CredentialsApi->GetOneIos");
            
            // verify the required parameter 'credentialid' is set
            if (credentialid == null)
                throw new ApiException(400, "Missing required parameter 'credentialid' when calling CredentialsApi->GetOneIos");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/credentials/signing/ios/{credentialid}";
    
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
            if (credentialid != null) pathParams.Add("credentialid", Configuration.ApiClient.ParameterToString(credentialid)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling GetOneIos: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetOneIos: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2006>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2006) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2006)));
            
        }
    
        /// <summary>
        /// Get iOS Credential Details Get specific iOS credential details
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="credentialid">Credential Identifier</param>
        /// <returns>Task of InlineResponse2006</returns>
        public async System.Threading.Tasks.Task<InlineResponse2006> GetOneIosAsync (string orgid, string projectid, string credentialid)
        {
             ApiResponse<InlineResponse2006> response = await GetOneIosAsyncWithHttpInfo(orgid, projectid, credentialid);
             return response.Data;

        }

        /// <summary>
        /// Get iOS Credential Details Get specific iOS credential details
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="credentialid">Credential Identifier</param>
        /// <returns>Task of ApiResponse (InlineResponse2006)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2006>> GetOneIosAsyncWithHttpInfo (string orgid, string projectid, string credentialid)
        {
            // verify the required parameter 'orgid' is set
            if (orgid == null) throw new ApiException(400, "Missing required parameter 'orgid' when calling GetOneIos");
            // verify the required parameter 'projectid' is set
            if (projectid == null) throw new ApiException(400, "Missing required parameter 'projectid' when calling GetOneIos");
            // verify the required parameter 'credentialid' is set
            if (credentialid == null) throw new ApiException(400, "Missing required parameter 'credentialid' when calling GetOneIos");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/credentials/signing/ios/{credentialid}";
    
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
            if (credentialid != null) pathParams.Add("credentialid", Configuration.ApiClient.ParameterToString(credentialid)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling GetOneIos: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetOneIos: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2006>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2006) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2006)));
            
        }
        
        /// <summary>
        /// Update iOS Credentials Update an iOS certificate / provisioning profile for the project.\nNOTE: you must be a manager in the project&#39;s organization to update\ncredentials.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="credentialid">Credential Identifier</param> 
        /// <param name="label">Label for the updated credentials</param> 
        /// <param name="fileCertificate">Certificate file (.p12)</param> 
        /// <param name="fileProvisioningProfile">Provisioning Profile (.mobileprovision)</param> 
        /// <param name="certificatePass">Certificate (.p12) password</param> 
        /// <returns>InlineResponse2006</returns>
        public InlineResponse2006 UpdateIos (string orgid, string projectid, string credentialid, string label = null, Stream fileCertificate = null, Stream fileProvisioningProfile = null, string certificatePass = null)
        {
             ApiResponse<InlineResponse2006> response = UpdateIosWithHttpInfo(orgid, projectid, credentialid, label, fileCertificate, fileProvisioningProfile, certificatePass);
             return response.Data;
        }

        /// <summary>
        /// Update iOS Credentials Update an iOS certificate / provisioning profile for the project.\nNOTE: you must be a manager in the project&#39;s organization to update\ncredentials.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="credentialid">Credential Identifier</param> 
        /// <param name="label">Label for the updated credentials</param> 
        /// <param name="fileCertificate">Certificate file (.p12)</param> 
        /// <param name="fileProvisioningProfile">Provisioning Profile (.mobileprovision)</param> 
        /// <param name="certificatePass">Certificate (.p12) password</param> 
        /// <returns>ApiResponse of InlineResponse2006</returns>
        public ApiResponse< InlineResponse2006 > UpdateIosWithHttpInfo (string orgid, string projectid, string credentialid, string label = null, Stream fileCertificate = null, Stream fileProvisioningProfile = null, string certificatePass = null)
        {
            
            // verify the required parameter 'orgid' is set
            if (orgid == null)
                throw new ApiException(400, "Missing required parameter 'orgid' when calling CredentialsApi->UpdateIos");
            
            // verify the required parameter 'projectid' is set
            if (projectid == null)
                throw new ApiException(400, "Missing required parameter 'projectid' when calling CredentialsApi->UpdateIos");
            
            // verify the required parameter 'credentialid' is set
            if (credentialid == null)
                throw new ApiException(400, "Missing required parameter 'credentialid' when calling CredentialsApi->UpdateIos");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/credentials/signing/ios/{credentialid}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "multipart/form-data"
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
            if (credentialid != null) pathParams.Add("credentialid", Configuration.ApiClient.ParameterToString(credentialid)); // path parameter
            
            
            
            if (label != null) formParams.Add("label", Configuration.ApiClient.ParameterToString(label)); // form parameter
            if (fileCertificate != null) fileParams.Add("fileCertificate", Configuration.ApiClient.ParameterToFile("fileCertificate", fileCertificate));
            if (fileProvisioningProfile != null) fileParams.Add("fileProvisioningProfile", Configuration.ApiClient.ParameterToFile("fileProvisioningProfile", fileProvisioningProfile));
            if (certificatePass != null) formParams.Add("certificatePass", Configuration.ApiClient.ParameterToString(certificatePass)); // form parameter
            
            

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
                throw new ApiException (statusCode, "Error calling UpdateIos: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateIos: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<InlineResponse2006>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2006) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2006)));
            
        }
    
        /// <summary>
        /// Update iOS Credentials Update an iOS certificate / provisioning profile for the project.\nNOTE: you must be a manager in the project&#39;s organization to update\ncredentials.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="credentialid">Credential Identifier</param>
        /// <param name="label">Label for the updated credentials</param>
        /// <param name="fileCertificate">Certificate file (.p12)</param>
        /// <param name="fileProvisioningProfile">Provisioning Profile (.mobileprovision)</param>
        /// <param name="certificatePass">Certificate (.p12) password</param>
        /// <returns>Task of InlineResponse2006</returns>
        public async System.Threading.Tasks.Task<InlineResponse2006> UpdateIosAsync (string orgid, string projectid, string credentialid, string label = null, Stream fileCertificate = null, Stream fileProvisioningProfile = null, string certificatePass = null)
        {
             ApiResponse<InlineResponse2006> response = await UpdateIosAsyncWithHttpInfo(orgid, projectid, credentialid, label, fileCertificate, fileProvisioningProfile, certificatePass);
             return response.Data;

        }

        /// <summary>
        /// Update iOS Credentials Update an iOS certificate / provisioning profile for the project.\nNOTE: you must be a manager in the project&#39;s organization to update\ncredentials.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="credentialid">Credential Identifier</param>
        /// <param name="label">Label for the updated credentials</param>
        /// <param name="fileCertificate">Certificate file (.p12)</param>
        /// <param name="fileProvisioningProfile">Provisioning Profile (.mobileprovision)</param>
        /// <param name="certificatePass">Certificate (.p12) password</param>
        /// <returns>Task of ApiResponse (InlineResponse2006)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2006>> UpdateIosAsyncWithHttpInfo (string orgid, string projectid, string credentialid, string label = null, Stream fileCertificate = null, Stream fileProvisioningProfile = null, string certificatePass = null)
        {
            // verify the required parameter 'orgid' is set
            if (orgid == null) throw new ApiException(400, "Missing required parameter 'orgid' when calling UpdateIos");
            // verify the required parameter 'projectid' is set
            if (projectid == null) throw new ApiException(400, "Missing required parameter 'projectid' when calling UpdateIos");
            // verify the required parameter 'credentialid' is set
            if (credentialid == null) throw new ApiException(400, "Missing required parameter 'credentialid' when calling UpdateIos");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/credentials/signing/ios/{credentialid}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "multipart/form-data"
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
            if (credentialid != null) pathParams.Add("credentialid", Configuration.ApiClient.ParameterToString(credentialid)); // path parameter
            
            
            
            if (label != null) formParams.Add("label", Configuration.ApiClient.ParameterToString(label)); // form parameter
            if (fileCertificate != null) fileParams.Add("fileCertificate", Configuration.ApiClient.ParameterToFile("fileCertificate", fileCertificate));
            if (fileProvisioningProfile != null) fileParams.Add("fileProvisioningProfile", Configuration.ApiClient.ParameterToFile("fileProvisioningProfile", fileProvisioningProfile));
            if (certificatePass != null) formParams.Add("certificatePass", Configuration.ApiClient.ParameterToString(certificatePass)); // form parameter
            
            

            
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
                throw new ApiException (statusCode, "Error calling UpdateIos: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateIos: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<InlineResponse2006>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2006) Configuration.ApiClient.Deserialize(response, typeof(InlineResponse2006)));
            
        }
        
        /// <summary>
        /// Delete iOS Credentials Delete specific ios credentials for a project. NOTE:\nyou must be a manager in the project&#39;s organization to\ndelete credentials.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="credentialid">Credential Identifier</param> 
        /// <returns>string</returns>
        public string DeleteIos (string orgid, string projectid, string credentialid)
        {
             ApiResponse<string> response = DeleteIosWithHttpInfo(orgid, projectid, credentialid);
             return response.Data;
        }

        /// <summary>
        /// Delete iOS Credentials Delete specific ios credentials for a project. NOTE:\nyou must be a manager in the project&#39;s organization to\ndelete credentials.
        /// </summary>
        /// <param name="orgid">Organization identifier</param> 
        /// <param name="projectid">Project identifier</param> 
        /// <param name="credentialid">Credential Identifier</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteIosWithHttpInfo (string orgid, string projectid, string credentialid)
        {
            
            // verify the required parameter 'orgid' is set
            if (orgid == null)
                throw new ApiException(400, "Missing required parameter 'orgid' when calling CredentialsApi->DeleteIos");
            
            // verify the required parameter 'projectid' is set
            if (projectid == null)
                throw new ApiException(400, "Missing required parameter 'projectid' when calling CredentialsApi->DeleteIos");
            
            // verify the required parameter 'credentialid' is set
            if (credentialid == null)
                throw new ApiException(400, "Missing required parameter 'credentialid' when calling CredentialsApi->DeleteIos");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/credentials/signing/ios/{credentialid}";
    
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
            if (credentialid != null) pathParams.Add("credentialid", Configuration.ApiClient.ParameterToString(credentialid)); // path parameter
            
            
            
            
            

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
                throw new ApiException (statusCode, "Error calling DeleteIos: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteIos: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Delete iOS Credentials Delete specific ios credentials for a project. NOTE:\nyou must be a manager in the project&#39;s organization to\ndelete credentials.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="credentialid">Credential Identifier</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteIosAsync (string orgid, string projectid, string credentialid)
        {
             ApiResponse<string> response = await DeleteIosAsyncWithHttpInfo(orgid, projectid, credentialid);
             return response.Data;

        }

        /// <summary>
        /// Delete iOS Credentials Delete specific ios credentials for a project. NOTE:\nyou must be a manager in the project&#39;s organization to\ndelete credentials.
        /// </summary>
        /// <param name="orgid">Organization identifier</param>
        /// <param name="projectid">Project identifier</param>
        /// <param name="credentialid">Credential Identifier</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteIosAsyncWithHttpInfo (string orgid, string projectid, string credentialid)
        {
            // verify the required parameter 'orgid' is set
            if (orgid == null) throw new ApiException(400, "Missing required parameter 'orgid' when calling DeleteIos");
            // verify the required parameter 'projectid' is set
            if (projectid == null) throw new ApiException(400, "Missing required parameter 'projectid' when calling DeleteIos");
            // verify the required parameter 'credentialid' is set
            if (credentialid == null) throw new ApiException(400, "Missing required parameter 'credentialid' when calling DeleteIos");
            
    
            var path_ = "/orgs/{orgid}/projects/{projectid}/credentials/signing/ios/{credentialid}";
    
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
            if (credentialid != null) pathParams.Add("credentialid", Configuration.ApiClient.ParameterToString(credentialid)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (statusCode, "Error calling DeleteIos: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteIos: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
    }
    
}

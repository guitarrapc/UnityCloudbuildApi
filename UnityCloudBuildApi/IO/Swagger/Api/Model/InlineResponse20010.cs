using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace UnityCloudBuildApi.IO.Swagger.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class InlineResponse20010 :  IEquatable<InlineResponse20010>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20010" /> class.
        /// </summary>
        public InlineResponse20010()
        {
            
        }

        
        /// <summary>
        /// primary organization the user belongs to
        /// </summary>
        /// <value>primary organization the user belongs to</value>
        [DataMember(Name="primaryOrg", EmitDefaultValue=false)]
        public string PrimaryOrg { get; set; }
  
        
        /// <summary>
        /// when true the user is waiting to be approved for access to Cloud Build
        /// </summary>
        /// <value>when true the user is waiting to be approved for access to Cloud Build</value>
        [DataMember(Name="waiting", EmitDefaultValue=false)]
        public bool? Waiting { get; set; }
  
        
        /// <summary>
        /// API key
        /// </summary>
        /// <value>API key</value>
        [DataMember(Name="apiKey", EmitDefaultValue=false)]
        public string ApiKey { get; set; }
  
        
        /// <summary>
        /// full name
        /// </summary>
        /// <value>full name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// links for retrieving more information about the user
        /// </summary>
        /// <value>links for retrieving more information about the user</value>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public Object Links { get; set; }
  
        
        /// <summary>
        /// internal unity id that is shared across services
        /// </summary>
        /// <value>internal unity id that is shared across services</value>
        [DataMember(Name="unityid", EmitDefaultValue=false)]
        public string Unityid { get; set; }
  
        
        /// <summary>
        /// when true build status email notifications will no longer be sent
        /// </summary>
        /// <value>when true build status email notifications will no longer be sent</value>
        [DataMember(Name="disableNotifications", EmitDefaultValue=false)]
        public bool? DisableNotifications { get; set; }
  
        
        /// <summary>
        /// email address
        /// </summary>
        /// <value>email address</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20010 {\n");
            sb.Append("  PrimaryOrg: ").Append(PrimaryOrg).Append("\n");
            sb.Append("  Waiting: ").Append(Waiting).Append("\n");
            sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Unityid: ").Append(Unityid).Append("\n");
            sb.Append("  DisableNotifications: ").Append(DisableNotifications).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as InlineResponse20010);
        }

        /// <summary>
        /// Returns true if InlineResponse20010 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse20010 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20010 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PrimaryOrg == other.PrimaryOrg ||
                    this.PrimaryOrg != null &&
                    this.PrimaryOrg.Equals(other.PrimaryOrg)
                ) && 
                (
                    this.Waiting == other.Waiting ||
                    this.Waiting != null &&
                    this.Waiting.Equals(other.Waiting)
                ) && 
                (
                    this.ApiKey == other.ApiKey ||
                    this.ApiKey != null &&
                    this.ApiKey.Equals(other.ApiKey)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
                ) && 
                (
                    this.Unityid == other.Unityid ||
                    this.Unityid != null &&
                    this.Unityid.Equals(other.Unityid)
                ) && 
                (
                    this.DisableNotifications == other.DisableNotifications ||
                    this.DisableNotifications != null &&
                    this.DisableNotifications.Equals(other.DisableNotifications)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.PrimaryOrg != null)
                    hash = hash * 59 + this.PrimaryOrg.GetHashCode();
                
                if (this.Waiting != null)
                    hash = hash * 59 + this.Waiting.GetHashCode();
                
                if (this.ApiKey != null)
                    hash = hash * 59 + this.ApiKey.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                
                if (this.Unityid != null)
                    hash = hash * 59 + this.Unityid.GetHashCode();
                
                if (this.DisableNotifications != null)
                    hash = hash * 59 + this.DisableNotifications.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                return hash;
            }
        }

    }
}

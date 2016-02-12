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
    public partial class InlineResponse2003 :  IEquatable<InlineResponse2003>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2003" /> class.
        /// </summary>
        public InlineResponse2003()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public OrgsorgidprojectsprojectidbuildtargetsSettings Settings { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Credentials
        /// </summary>
        [DataMember(Name="credentials", EmitDefaultValue=false)]
        public OrgsorgidprojectsprojectidbuildtargetsCredentials Credentials { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Builds
        /// </summary>
        [DataMember(Name="builds", EmitDefaultValue=false)]
        public List<OrgsorgidprojectsprojectidbuildtargetsBuilds> Builds { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public Object Links { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        [DataMember(Name="platform", EmitDefaultValue=false)]
        public string Platform { get; set; }
  
        
        /// <summary>
        /// whether this target can be built by the API
        /// </summary>
        /// <value>whether this target can be built by the API</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
  
        
        /// <summary>
        /// unique id auto-generated from the build target name
        /// </summary>
        /// <value>unique id auto-generated from the build target name</value>
        [DataMember(Name="buildtargetid", EmitDefaultValue=false)]
        public string Buildtargetid { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2003 {\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  Credentials: ").Append(Credentials).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Builds: ").Append(Builds).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Buildtargetid: ").Append(Buildtargetid).Append("\n");
            
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
            return this.Equals(obj as InlineResponse2003);
        }

        /// <summary>
        /// Returns true if InlineResponse2003 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2003 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2003 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Settings == other.Settings ||
                    this.Settings != null &&
                    this.Settings.Equals(other.Settings)
                ) && 
                (
                    this.Credentials == other.Credentials ||
                    this.Credentials != null &&
                    this.Credentials.Equals(other.Credentials)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Builds == other.Builds ||
                    this.Builds != null &&
                    this.Builds.SequenceEqual(other.Builds)
                ) && 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
                ) && 
                (
                    this.Platform == other.Platform ||
                    this.Platform != null &&
                    this.Platform.Equals(other.Platform)
                ) && 
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) && 
                (
                    this.Buildtargetid == other.Buildtargetid ||
                    this.Buildtargetid != null &&
                    this.Buildtargetid.Equals(other.Buildtargetid)
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
                
                if (this.Settings != null)
                    hash = hash * 59 + this.Settings.GetHashCode();
                
                if (this.Credentials != null)
                    hash = hash * 59 + this.Credentials.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Builds != null)
                    hash = hash * 59 + this.Builds.GetHashCode();
                
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                
                if (this.Platform != null)
                    hash = hash * 59 + this.Platform.GetHashCode();
                
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                
                if (this.Buildtargetid != null)
                    hash = hash * 59 + this.Buildtargetid.GetHashCode();
                
                return hash;
            }
        }

    }
}

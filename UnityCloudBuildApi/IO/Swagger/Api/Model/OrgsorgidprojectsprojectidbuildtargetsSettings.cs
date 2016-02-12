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
    public partial class OrgsorgidprojectsprojectidbuildtargetsSettings :  IEquatable<OrgsorgidprojectsprojectidbuildtargetsSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsorgidprojectsprojectidbuildtargetsSettings" /> class.
        /// </summary>
        public OrgsorgidprojectsprojectidbuildtargetsSettings()
        {
            
        }

        
        /// <summary>
        /// 'latest' or a unity dot version with underscores (ex. '4_6_5')
        /// </summary>
        /// <value>'latest' or a unity dot version with underscores (ex. '4_6_5')</value>
        [DataMember(Name="unityVersion", EmitDefaultValue=false)]
        public string UnityVersion { get; set; }
  
        
        /// <summary>
        /// start builds automatically when your repo is updated
        /// </summary>
        /// <value>start builds automatically when your repo is updated</value>
        [DataMember(Name="autoBuild", EmitDefaultValue=false)]
        public bool? AutoBuild { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Advanced
        /// </summary>
        [DataMember(Name="advanced", EmitDefaultValue=false)]
        public OrgsorgidprojectsprojectidbuildtargetsSettingsAdvanced Advanced { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Scm
        /// </summary>
        [DataMember(Name="scm", EmitDefaultValue=false)]
        public OrgsorgidprojectsprojectidbuildtargetsSettingsScm Scm { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Executablename
        /// </summary>
        [DataMember(Name="executablename", EmitDefaultValue=false)]
        public string Executablename { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        [DataMember(Name="platform", EmitDefaultValue=false)]
        public OrgsorgidprojectsprojectidbuildtargetsSettingsPlatform Platform { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrgsorgidprojectsprojectidbuildtargetsSettings {\n");
            sb.Append("  UnityVersion: ").Append(UnityVersion).Append("\n");
            sb.Append("  AutoBuild: ").Append(AutoBuild).Append("\n");
            sb.Append("  Advanced: ").Append(Advanced).Append("\n");
            sb.Append("  Scm: ").Append(Scm).Append("\n");
            sb.Append("  Executablename: ").Append(Executablename).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            
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
            return this.Equals(obj as OrgsorgidprojectsprojectidbuildtargetsSettings);
        }

        /// <summary>
        /// Returns true if OrgsorgidprojectsprojectidbuildtargetsSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of OrgsorgidprojectsprojectidbuildtargetsSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrgsorgidprojectsprojectidbuildtargetsSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UnityVersion == other.UnityVersion ||
                    this.UnityVersion != null &&
                    this.UnityVersion.Equals(other.UnityVersion)
                ) && 
                (
                    this.AutoBuild == other.AutoBuild ||
                    this.AutoBuild != null &&
                    this.AutoBuild.Equals(other.AutoBuild)
                ) && 
                (
                    this.Advanced == other.Advanced ||
                    this.Advanced != null &&
                    this.Advanced.Equals(other.Advanced)
                ) && 
                (
                    this.Scm == other.Scm ||
                    this.Scm != null &&
                    this.Scm.Equals(other.Scm)
                ) && 
                (
                    this.Executablename == other.Executablename ||
                    this.Executablename != null &&
                    this.Executablename.Equals(other.Executablename)
                ) && 
                (
                    this.Platform == other.Platform ||
                    this.Platform != null &&
                    this.Platform.Equals(other.Platform)
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
                
                if (this.UnityVersion != null)
                    hash = hash * 59 + this.UnityVersion.GetHashCode();
                
                if (this.AutoBuild != null)
                    hash = hash * 59 + this.AutoBuild.GetHashCode();
                
                if (this.Advanced != null)
                    hash = hash * 59 + this.Advanced.GetHashCode();
                
                if (this.Scm != null)
                    hash = hash * 59 + this.Scm.GetHashCode();
                
                if (this.Executablename != null)
                    hash = hash * 59 + this.Executablename.GetHashCode();
                
                if (this.Platform != null)
                    hash = hash * 59 + this.Platform.GetHashCode();
                
                return hash;
            }
        }

    }
}

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
    public partial class OrgsorgidprojectsprojectidbuildtargetsSettingsPlatform :  IEquatable<OrgsorgidprojectsprojectidbuildtargetsSettingsPlatform>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsorgidprojectsprojectidbuildtargetsSettingsPlatform" /> class.
        /// </summary>
        public OrgsorgidprojectsprojectidbuildtargetsSettingsPlatform()
        {
            
        }

        
        /// <summary>
        /// a unique identifier (com.example.name)
        /// </summary>
        /// <value>a unique identifier (com.example.name)</value>
        [DataMember(Name="bundleId", EmitDefaultValue=false)]
        public string BundleId { get; set; }
  
        
        /// <summary>
        /// Gets or Sets XcodeVersion
        /// </summary>
        [DataMember(Name="xcodeVersion", EmitDefaultValue=false)]
        public string XcodeVersion { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrgsorgidprojectsprojectidbuildtargetsSettingsPlatform {\n");
            sb.Append("  BundleId: ").Append(BundleId).Append("\n");
            sb.Append("  XcodeVersion: ").Append(XcodeVersion).Append("\n");
            
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
            return this.Equals(obj as OrgsorgidprojectsprojectidbuildtargetsSettingsPlatform);
        }

        /// <summary>
        /// Returns true if OrgsorgidprojectsprojectidbuildtargetsSettingsPlatform instances are equal
        /// </summary>
        /// <param name="other">Instance of OrgsorgidprojectsprojectidbuildtargetsSettingsPlatform to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrgsorgidprojectsprojectidbuildtargetsSettingsPlatform other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BundleId == other.BundleId ||
                    this.BundleId != null &&
                    this.BundleId.Equals(other.BundleId)
                ) && 
                (
                    this.XcodeVersion == other.XcodeVersion ||
                    this.XcodeVersion != null &&
                    this.XcodeVersion.Equals(other.XcodeVersion)
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
                
                if (this.BundleId != null)
                    hash = hash * 59 + this.BundleId.GetHashCode();
                
                if (this.XcodeVersion != null)
                    hash = hash * 59 + this.XcodeVersion.GetHashCode();
                
                return hash;
            }
        }

    }
}

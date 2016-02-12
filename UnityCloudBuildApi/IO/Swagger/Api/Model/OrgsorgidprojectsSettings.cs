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
    public partial class OrgsorgidprojectsSettings :  IEquatable<OrgsorgidprojectsSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsorgidprojectsSettings" /> class.
        /// </summary>
        public OrgsorgidprojectsSettings()
        {
            this.RemoteCacheStrategy = "library";
            
        }

        
        /// <summary>
        /// Gets or Sets RemoteCacheStrategy
        /// </summary>
        [DataMember(Name="remoteCacheStrategy", EmitDefaultValue=false)]
        public string RemoteCacheStrategy { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Scm
        /// </summary>
        [DataMember(Name="scm", EmitDefaultValue=false)]
        public OrgsorgidprojectsSettingsScm Scm { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrgsorgidprojectsSettings {\n");
            sb.Append("  RemoteCacheStrategy: ").Append(RemoteCacheStrategy).Append("\n");
            sb.Append("  Scm: ").Append(Scm).Append("\n");
            
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
            return this.Equals(obj as OrgsorgidprojectsSettings);
        }

        /// <summary>
        /// Returns true if OrgsorgidprojectsSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of OrgsorgidprojectsSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrgsorgidprojectsSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RemoteCacheStrategy == other.RemoteCacheStrategy ||
                    this.RemoteCacheStrategy != null &&
                    this.RemoteCacheStrategy.Equals(other.RemoteCacheStrategy)
                ) && 
                (
                    this.Scm == other.Scm ||
                    this.Scm != null &&
                    this.Scm.Equals(other.Scm)
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
                
                if (this.RemoteCacheStrategy != null)
                    hash = hash * 59 + this.RemoteCacheStrategy.GetHashCode();
                
                if (this.Scm != null)
                    hash = hash * 59 + this.Scm.GetHashCode();
                
                return hash;
            }
        }

    }
}

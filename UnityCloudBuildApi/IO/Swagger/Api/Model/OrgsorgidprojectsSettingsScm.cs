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
    public partial class OrgsorgidprojectsSettingsScm :  IEquatable<OrgsorgidprojectsSettingsScm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsorgidprojectsSettingsScm" /> class.
        /// </summary>
        public OrgsorgidprojectsSettingsScm()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Pass
        /// </summary>
        [DataMember(Name="pass", EmitDefaultValue=false)]
        public string Pass { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
  
        
        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public string User { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrgsorgidprojectsSettingsScm {\n");
            sb.Append("  Pass: ").Append(Pass).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            
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
            return this.Equals(obj as OrgsorgidprojectsSettingsScm);
        }

        /// <summary>
        /// Returns true if OrgsorgidprojectsSettingsScm instances are equal
        /// </summary>
        /// <param name="other">Instance of OrgsorgidprojectsSettingsScm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrgsorgidprojectsSettingsScm other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Pass == other.Pass ||
                    this.Pass != null &&
                    this.Pass.Equals(other.Pass)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) && 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
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
                
                if (this.Pass != null)
                    hash = hash * 59 + this.Pass.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                
                return hash;
            }
        }

    }
}

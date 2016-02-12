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
    public partial class OrgsorgidprojectsprojectidbuildtargetsSettingsScm :  IEquatable<OrgsorgidprojectsprojectidbuildtargetsSettingsScm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsorgidprojectsprojectidbuildtargetsSettingsScm" /> class.
        /// </summary>
        public OrgsorgidprojectsprojectidbuildtargetsSettingsScm()
        {
            
        }

        
        /// <summary>
        /// perforce only client workspace to build from
        /// </summary>
        /// <value>perforce only client workspace to build from</value>
        [DataMember(Name="client", EmitDefaultValue=false)]
        public string Client { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Branch
        /// </summary>
        [DataMember(Name="branch", EmitDefaultValue=false)]
        public string Branch { get; set; }
  
        
        /// <summary>
        /// subdirectory to build from
        /// </summary>
        /// <value>subdirectory to build from</value>
        [DataMember(Name="subdirectory", EmitDefaultValue=false)]
        public string Subdirectory { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrgsorgidprojectsprojectidbuildtargetsSettingsScm {\n");
            sb.Append("  Client: ").Append(Client).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Branch: ").Append(Branch).Append("\n");
            sb.Append("  Subdirectory: ").Append(Subdirectory).Append("\n");
            
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
            return this.Equals(obj as OrgsorgidprojectsprojectidbuildtargetsSettingsScm);
        }

        /// <summary>
        /// Returns true if OrgsorgidprojectsprojectidbuildtargetsSettingsScm instances are equal
        /// </summary>
        /// <param name="other">Instance of OrgsorgidprojectsprojectidbuildtargetsSettingsScm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrgsorgidprojectsprojectidbuildtargetsSettingsScm other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Client == other.Client ||
                    this.Client != null &&
                    this.Client.Equals(other.Client)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Branch == other.Branch ||
                    this.Branch != null &&
                    this.Branch.Equals(other.Branch)
                ) && 
                (
                    this.Subdirectory == other.Subdirectory ||
                    this.Subdirectory != null &&
                    this.Subdirectory.Equals(other.Subdirectory)
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
                
                if (this.Client != null)
                    hash = hash * 59 + this.Client.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.Branch != null)
                    hash = hash * 59 + this.Branch.GetHashCode();
                
                if (this.Subdirectory != null)
                    hash = hash * 59 + this.Subdirectory.GetHashCode();
                
                return hash;
            }
        }

    }
}

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
    public partial class OrgsorgidprojectsprojectidbuildtargetsSettingsAdvanced :  IEquatable<OrgsorgidprojectsprojectidbuildtargetsSettingsAdvanced>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsorgidprojectsprojectidbuildtargetsSettingsAdvanced" /> class.
        /// </summary>
        public OrgsorgidprojectsprojectidbuildtargetsSettingsAdvanced()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Unity
        /// </summary>
        [DataMember(Name="unity", EmitDefaultValue=false)]
        public OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnity Unity { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrgsorgidprojectsprojectidbuildtargetsSettingsAdvanced {\n");
            sb.Append("  Unity: ").Append(Unity).Append("\n");
            
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
            return this.Equals(obj as OrgsorgidprojectsprojectidbuildtargetsSettingsAdvanced);
        }

        /// <summary>
        /// Returns true if OrgsorgidprojectsprojectidbuildtargetsSettingsAdvanced instances are equal
        /// </summary>
        /// <param name="other">Instance of OrgsorgidprojectsprojectidbuildtargetsSettingsAdvanced to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrgsorgidprojectsprojectidbuildtargetsSettingsAdvanced other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Unity == other.Unity ||
                    this.Unity != null &&
                    this.Unity.Equals(other.Unity)
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
                
                if (this.Unity != null)
                    hash = hash * 59 + this.Unity.GetHashCode();
                
                return hash;
            }
        }

    }
}

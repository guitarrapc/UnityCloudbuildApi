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
    public partial class OrgsorgidprojectsprojectidbuildtargetsCredentials1 :  IEquatable<OrgsorgidprojectsprojectidbuildtargetsCredentials1>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsorgidprojectsprojectidbuildtargetsCredentials1" /> class.
        /// </summary>
        public OrgsorgidprojectsprojectidbuildtargetsCredentials1()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Signing
        /// </summary>
        [DataMember(Name="signing", EmitDefaultValue=false)]
        public OrgsorgidprojectsprojectidbuildtargetsCredentials1Signing Signing { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrgsorgidprojectsprojectidbuildtargetsCredentials1 {\n");
            sb.Append("  Signing: ").Append(Signing).Append("\n");
            
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
            return this.Equals(obj as OrgsorgidprojectsprojectidbuildtargetsCredentials1);
        }

        /// <summary>
        /// Returns true if OrgsorgidprojectsprojectidbuildtargetsCredentials1 instances are equal
        /// </summary>
        /// <param name="other">Instance of OrgsorgidprojectsprojectidbuildtargetsCredentials1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrgsorgidprojectsprojectidbuildtargetsCredentials1 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Signing == other.Signing ||
                    this.Signing != null &&
                    this.Signing.Equals(other.Signing)
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
                
                if (this.Signing != null)
                    hash = hash * 59 + this.Signing.GetHashCode();
                
                return hash;
            }
        }

    }
}

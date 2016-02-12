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
    public partial class OrgsorgidprojectsprojectidbuildtargetsCredentialsSigningCredentialResourceRefKeystore :  IEquatable<OrgsorgidprojectsprojectidbuildtargetsCredentialsSigningCredentialResourceRefKeystore>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsorgidprojectsprojectidbuildtargetsCredentialsSigningCredentialResourceRefKeystore" /> class.
        /// </summary>
        public OrgsorgidprojectsprojectidbuildtargetsCredentialsSigningCredentialResourceRefKeystore()
        {
            
        }

        
        /// <summary>
        /// whether this is a debug or production keystore
        /// </summary>
        /// <value>whether this is a debug or production keystore</value>
        [DataMember(Name="debug", EmitDefaultValue=false)]
        public bool? Debug { get; set; }
  
        
        /// <summary>
        /// friendly name for keystore
        /// </summary>
        /// <value>friendly name for keystore</value>
        [DataMember(Name="alias", EmitDefaultValue=false)]
        public string Alias { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrgsorgidprojectsprojectidbuildtargetsCredentialsSigningCredentialResourceRefKeystore {\n");
            sb.Append("  Debug: ").Append(Debug).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            
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
            return this.Equals(obj as OrgsorgidprojectsprojectidbuildtargetsCredentialsSigningCredentialResourceRefKeystore);
        }

        /// <summary>
        /// Returns true if OrgsorgidprojectsprojectidbuildtargetsCredentialsSigningCredentialResourceRefKeystore instances are equal
        /// </summary>
        /// <param name="other">Instance of OrgsorgidprojectsprojectidbuildtargetsCredentialsSigningCredentialResourceRefKeystore to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrgsorgidprojectsprojectidbuildtargetsCredentialsSigningCredentialResourceRefKeystore other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Debug == other.Debug ||
                    this.Debug != null &&
                    this.Debug.Equals(other.Debug)
                ) && 
                (
                    this.Alias == other.Alias ||
                    this.Alias != null &&
                    this.Alias.Equals(other.Alias)
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
                
                if (this.Debug != null)
                    hash = hash * 59 + this.Debug.GetHashCode();
                
                if (this.Alias != null)
                    hash = hash * 59 + this.Alias.GetHashCode();
                
                return hash;
            }
        }

    }
}

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
    public partial class OrgsorgidprojectsprojectidbuildtargetsCredentialsSigning :  IEquatable<OrgsorgidprojectsprojectidbuildtargetsCredentialsSigning>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsorgidprojectsprojectidbuildtargetsCredentialsSigning" /> class.
        /// </summary>
        public OrgsorgidprojectsprojectidbuildtargetsCredentialsSigning()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets CredentialResourceRef
        /// </summary>
        [DataMember(Name="credentialResourceRef", EmitDefaultValue=false)]
        public OrgsorgidprojectsprojectidbuildtargetsCredentialsSigningCredentialResourceRef CredentialResourceRef { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Credentialid
        /// </summary>
        [DataMember(Name="credentialid", EmitDefaultValue=false)]
        public string Credentialid { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrgsorgidprojectsprojectidbuildtargetsCredentialsSigning {\n");
            sb.Append("  CredentialResourceRef: ").Append(CredentialResourceRef).Append("\n");
            sb.Append("  Credentialid: ").Append(Credentialid).Append("\n");
            
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
            return this.Equals(obj as OrgsorgidprojectsprojectidbuildtargetsCredentialsSigning);
        }

        /// <summary>
        /// Returns true if OrgsorgidprojectsprojectidbuildtargetsCredentialsSigning instances are equal
        /// </summary>
        /// <param name="other">Instance of OrgsorgidprojectsprojectidbuildtargetsCredentialsSigning to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrgsorgidprojectsprojectidbuildtargetsCredentialsSigning other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CredentialResourceRef == other.CredentialResourceRef ||
                    this.CredentialResourceRef != null &&
                    this.CredentialResourceRef.Equals(other.CredentialResourceRef)
                ) && 
                (
                    this.Credentialid == other.Credentialid ||
                    this.Credentialid != null &&
                    this.Credentialid.Equals(other.Credentialid)
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
                
                if (this.CredentialResourceRef != null)
                    hash = hash * 59 + this.CredentialResourceRef.GetHashCode();
                
                if (this.Credentialid != null)
                    hash = hash * 59 + this.Credentialid.GetHashCode();
                
                return hash;
            }
        }

    }
}

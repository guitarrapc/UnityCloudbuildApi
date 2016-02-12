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
    public partial class InlineResponse2006 :  IEquatable<InlineResponse2006>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2006" /> class.
        /// </summary>
        public InlineResponse2006()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public string Created { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Certificate
        /// </summary>
        [DataMember(Name="certificate", EmitDefaultValue=false)]
        public OrgsorgidprojectsprojectidbuildtargetsCredentialsSigningCredentialResourceRefCertificate Certificate { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Credentialid
        /// </summary>
        [DataMember(Name="credentialid", EmitDefaultValue=false)]
        public string Credentialid { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ProvisioningProfile
        /// </summary>
        [DataMember(Name="provisioningProfile", EmitDefaultValue=false)]
        public OrgsorgidprojectsprojectidbuildtargetsCredentialsSigningCredentialResourceRefProvisioningProfile ProvisioningProfile { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public Object Links { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }
  
        
        /// <summary>
        /// Gets or Sets LastMod
        /// </summary>
        [DataMember(Name="lastMod", EmitDefaultValue=false)]
        public string LastMod { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        [DataMember(Name="platform", EmitDefaultValue=false)]
        public string Platform { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2006 {\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Certificate: ").Append(Certificate).Append("\n");
            sb.Append("  Credentialid: ").Append(Credentialid).Append("\n");
            sb.Append("  ProvisioningProfile: ").Append(ProvisioningProfile).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  LastMod: ").Append(LastMod).Append("\n");
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
            return this.Equals(obj as InlineResponse2006);
        }

        /// <summary>
        /// Returns true if InlineResponse2006 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2006 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2006 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.Certificate == other.Certificate ||
                    this.Certificate != null &&
                    this.Certificate.Equals(other.Certificate)
                ) && 
                (
                    this.Credentialid == other.Credentialid ||
                    this.Credentialid != null &&
                    this.Credentialid.Equals(other.Credentialid)
                ) && 
                (
                    this.ProvisioningProfile == other.ProvisioningProfile ||
                    this.ProvisioningProfile != null &&
                    this.ProvisioningProfile.Equals(other.ProvisioningProfile)
                ) && 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
                ) && 
                (
                    this.Label == other.Label ||
                    this.Label != null &&
                    this.Label.Equals(other.Label)
                ) && 
                (
                    this.LastMod == other.LastMod ||
                    this.LastMod != null &&
                    this.LastMod.Equals(other.LastMod)
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
                
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                
                if (this.Certificate != null)
                    hash = hash * 59 + this.Certificate.GetHashCode();
                
                if (this.Credentialid != null)
                    hash = hash * 59 + this.Credentialid.GetHashCode();
                
                if (this.ProvisioningProfile != null)
                    hash = hash * 59 + this.ProvisioningProfile.GetHashCode();
                
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                
                if (this.Label != null)
                    hash = hash * 59 + this.Label.GetHashCode();
                
                if (this.LastMod != null)
                    hash = hash * 59 + this.LastMod.GetHashCode();
                
                if (this.Platform != null)
                    hash = hash * 59 + this.Platform.GetHashCode();
                
                return hash;
            }
        }

    }
}

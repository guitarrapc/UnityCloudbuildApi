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
    public partial class OrgsorgidprojectsprojectidbuildtargetsCredentialsSigningCredentialResourceRefProvisioningProfile :  IEquatable<OrgsorgidprojectsprojectidbuildtargetsCredentialsSigningCredentialResourceRefProvisioningProfile>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsorgidprojectsprojectidbuildtargetsCredentialsSigningCredentialResourceRefProvisioningProfile" /> class.
        /// </summary>
        public OrgsorgidprojectsprojectidbuildtargetsCredentialsSigningCredentialResourceRefProvisioningProfile()
        {
            
        }

        
        /// <summary>
        /// number of devices provisioned for this certificate
        /// </summary>
        /// <value>number of devices provisioned for this certificate</value>
        [DataMember(Name="numDevices", EmitDefaultValue=false)]
        public double? NumDevices { get; set; }
  
        
        /// <summary>
        /// generated team id from Apple
        /// </summary>
        /// <value>generated team id from Apple</value>
        [DataMember(Name="teamId", EmitDefaultValue=false)]
        public string TeamId { get; set; }
  
        
        /// <summary>
        /// a unique identifier (com.example.name)
        /// </summary>
        /// <value>a unique identifier (com.example.name)</value>
        [DataMember(Name="bundleId", EmitDefaultValue=false)]
        public string BundleId { get; set; }
  
        
        /// <summary>
        /// uploaded date
        /// </summary>
        /// <value>uploaded date</value>
        [DataMember(Name="uploaded", EmitDefaultValue=false)]
        public string Uploaded { get; set; }
  
        
        /// <summary>
        /// expiration date
        /// </summary>
        /// <value>expiration date</value>
        [DataMember(Name="expiration", EmitDefaultValue=false)]
        public string Expiration { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
  
        
        /// <summary>
        /// is this compiled for Apple's enterprise program
        /// </summary>
        /// <value>is this compiled for Apple's enterprise program</value>
        [DataMember(Name="isEnterpriseProfile", EmitDefaultValue=false)]
        public bool? IsEnterpriseProfile { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrgsorgidprojectsprojectidbuildtargetsCredentialsSigningCredentialResourceRefProvisioningProfile {\n");
            sb.Append("  NumDevices: ").Append(NumDevices).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  BundleId: ").Append(BundleId).Append("\n");
            sb.Append("  Uploaded: ").Append(Uploaded).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IsEnterpriseProfile: ").Append(IsEnterpriseProfile).Append("\n");
            
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
            return this.Equals(obj as OrgsorgidprojectsprojectidbuildtargetsCredentialsSigningCredentialResourceRefProvisioningProfile);
        }

        /// <summary>
        /// Returns true if OrgsorgidprojectsprojectidbuildtargetsCredentialsSigningCredentialResourceRefProvisioningProfile instances are equal
        /// </summary>
        /// <param name="other">Instance of OrgsorgidprojectsprojectidbuildtargetsCredentialsSigningCredentialResourceRefProvisioningProfile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrgsorgidprojectsprojectidbuildtargetsCredentialsSigningCredentialResourceRefProvisioningProfile other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.NumDevices == other.NumDevices ||
                    this.NumDevices != null &&
                    this.NumDevices.Equals(other.NumDevices)
                ) && 
                (
                    this.TeamId == other.TeamId ||
                    this.TeamId != null &&
                    this.TeamId.Equals(other.TeamId)
                ) && 
                (
                    this.BundleId == other.BundleId ||
                    this.BundleId != null &&
                    this.BundleId.Equals(other.BundleId)
                ) && 
                (
                    this.Uploaded == other.Uploaded ||
                    this.Uploaded != null &&
                    this.Uploaded.Equals(other.Uploaded)
                ) && 
                (
                    this.Expiration == other.Expiration ||
                    this.Expiration != null &&
                    this.Expiration.Equals(other.Expiration)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.IsEnterpriseProfile == other.IsEnterpriseProfile ||
                    this.IsEnterpriseProfile != null &&
                    this.IsEnterpriseProfile.Equals(other.IsEnterpriseProfile)
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
                
                if (this.NumDevices != null)
                    hash = hash * 59 + this.NumDevices.GetHashCode();
                
                if (this.TeamId != null)
                    hash = hash * 59 + this.TeamId.GetHashCode();
                
                if (this.BundleId != null)
                    hash = hash * 59 + this.BundleId.GetHashCode();
                
                if (this.Uploaded != null)
                    hash = hash * 59 + this.Uploaded.GetHashCode();
                
                if (this.Expiration != null)
                    hash = hash * 59 + this.Expiration.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.IsEnterpriseProfile != null)
                    hash = hash * 59 + this.IsEnterpriseProfile.GetHashCode();
                
                return hash;
            }
        }

    }
}

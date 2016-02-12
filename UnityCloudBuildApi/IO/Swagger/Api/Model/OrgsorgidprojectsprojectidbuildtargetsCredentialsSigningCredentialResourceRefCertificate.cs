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
    public partial class OrgsorgidprojectsprojectidbuildtargetsCredentialsSigningCredentialResourceRefCertificate :  IEquatable<OrgsorgidprojectsprojectidbuildtargetsCredentialsSigningCredentialResourceRefCertificate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsorgidprojectsprojectidbuildtargetsCredentialsSigningCredentialResourceRefCertificate" /> class.
        /// </summary>
        public OrgsorgidprojectsprojectidbuildtargetsCredentialsSigningCredentialResourceRefCertificate()
        {
            
        }

        
        /// <summary>
        /// certificate name (from the certificate)
        /// </summary>
        /// <value>certificate name (from the certificate)</value>
        [DataMember(Name="certName", EmitDefaultValue=false)]
        public string CertName { get; set; }
  
        
        /// <summary>
        /// generated team id from Apple
        /// </summary>
        /// <value>generated team id from Apple</value>
        [DataMember(Name="teamId", EmitDefaultValue=false)]
        public string TeamId { get; set; }
  
        
        /// <summary>
        /// uploaded date
        /// </summary>
        /// <value>uploaded date</value>
        [DataMember(Name="uploaded", EmitDefaultValue=false)]
        public string Uploaded { get; set; }
  
        
        /// <summary>
        /// if this is a distribution certificate
        /// </summary>
        /// <value>if this is a distribution certificate</value>
        [DataMember(Name="isDistribution", EmitDefaultValue=false)]
        public bool? IsDistribution { get; set; }
  
        
        /// <summary>
        /// expiration date
        /// </summary>
        /// <value>expiration date</value>
        [DataMember(Name="expiration", EmitDefaultValue=false)]
        public string Expiration { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrgsorgidprojectsprojectidbuildtargetsCredentialsSigningCredentialResourceRefCertificate {\n");
            sb.Append("  CertName: ").Append(CertName).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  Uploaded: ").Append(Uploaded).Append("\n");
            sb.Append("  IsDistribution: ").Append(IsDistribution).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
            
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
            return this.Equals(obj as OrgsorgidprojectsprojectidbuildtargetsCredentialsSigningCredentialResourceRefCertificate);
        }

        /// <summary>
        /// Returns true if OrgsorgidprojectsprojectidbuildtargetsCredentialsSigningCredentialResourceRefCertificate instances are equal
        /// </summary>
        /// <param name="other">Instance of OrgsorgidprojectsprojectidbuildtargetsCredentialsSigningCredentialResourceRefCertificate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrgsorgidprojectsprojectidbuildtargetsCredentialsSigningCredentialResourceRefCertificate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CertName == other.CertName ||
                    this.CertName != null &&
                    this.CertName.Equals(other.CertName)
                ) && 
                (
                    this.TeamId == other.TeamId ||
                    this.TeamId != null &&
                    this.TeamId.Equals(other.TeamId)
                ) && 
                (
                    this.Uploaded == other.Uploaded ||
                    this.Uploaded != null &&
                    this.Uploaded.Equals(other.Uploaded)
                ) && 
                (
                    this.IsDistribution == other.IsDistribution ||
                    this.IsDistribution != null &&
                    this.IsDistribution.Equals(other.IsDistribution)
                ) && 
                (
                    this.Expiration == other.Expiration ||
                    this.Expiration != null &&
                    this.Expiration.Equals(other.Expiration)
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
                
                if (this.CertName != null)
                    hash = hash * 59 + this.CertName.GetHashCode();
                
                if (this.TeamId != null)
                    hash = hash * 59 + this.TeamId.GetHashCode();
                
                if (this.Uploaded != null)
                    hash = hash * 59 + this.Uploaded.GetHashCode();
                
                if (this.IsDistribution != null)
                    hash = hash * 59 + this.IsDistribution.GetHashCode();
                
                if (this.Expiration != null)
                    hash = hash * 59 + this.Expiration.GetHashCode();
                
                return hash;
            }
        }

    }
}

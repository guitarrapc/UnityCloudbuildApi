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
    public partial class InlineResponse2001 :  IEquatable<InlineResponse2001>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2001" /> class.
        /// </summary>
        public InlineResponse2001()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets ServiceFlags
        /// </summary>
        [DataMember(Name="serviceFlags", EmitDefaultValue=false)]
        public Object ServiceFlags { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public OrgsorgidprojectsSettings Settings { get; set; }
  
        
        /// <summary>
        /// Gets or Sets OrgName
        /// </summary>
        [DataMember(Name="orgName", EmitDefaultValue=false)]
        public string OrgName { get; set; }
  
        
        /// <summary>
        /// Gets or Sets CachedIcon
        /// </summary>
        [DataMember(Name="cachedIcon", EmitDefaultValue=false)]
        public string CachedIcon { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public string Created { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Guid
        /// </summary>
        [DataMember(Name="guid", EmitDefaultValue=false)]
        public string Guid { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public Object Links { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Projectid
        /// </summary>
        [DataMember(Name="projectid", EmitDefaultValue=false)]
        public string Projectid { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Orgid
        /// </summary>
        [DataMember(Name="orgid", EmitDefaultValue=false)]
        public string Orgid { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2001 {\n");
            sb.Append("  ServiceFlags: ").Append(ServiceFlags).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  OrgName: ").Append(OrgName).Append("\n");
            sb.Append("  CachedIcon: ").Append(CachedIcon).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Projectid: ").Append(Projectid).Append("\n");
            sb.Append("  Orgid: ").Append(Orgid).Append("\n");
            
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
            return this.Equals(obj as InlineResponse2001);
        }

        /// <summary>
        /// Returns true if InlineResponse2001 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2001 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2001 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ServiceFlags == other.ServiceFlags ||
                    this.ServiceFlags != null &&
                    this.ServiceFlags.Equals(other.ServiceFlags)
                ) && 
                (
                    this.Settings == other.Settings ||
                    this.Settings != null &&
                    this.Settings.Equals(other.Settings)
                ) && 
                (
                    this.OrgName == other.OrgName ||
                    this.OrgName != null &&
                    this.OrgName.Equals(other.OrgName)
                ) && 
                (
                    this.CachedIcon == other.CachedIcon ||
                    this.CachedIcon != null &&
                    this.CachedIcon.Equals(other.CachedIcon)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Guid == other.Guid ||
                    this.Guid != null &&
                    this.Guid.Equals(other.Guid)
                ) && 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
                ) && 
                (
                    this.Projectid == other.Projectid ||
                    this.Projectid != null &&
                    this.Projectid.Equals(other.Projectid)
                ) && 
                (
                    this.Orgid == other.Orgid ||
                    this.Orgid != null &&
                    this.Orgid.Equals(other.Orgid)
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
                
                if (this.ServiceFlags != null)
                    hash = hash * 59 + this.ServiceFlags.GetHashCode();
                
                if (this.Settings != null)
                    hash = hash * 59 + this.Settings.GetHashCode();
                
                if (this.OrgName != null)
                    hash = hash * 59 + this.OrgName.GetHashCode();
                
                if (this.CachedIcon != null)
                    hash = hash * 59 + this.CachedIcon.GetHashCode();
                
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Guid != null)
                    hash = hash * 59 + this.Guid.GetHashCode();
                
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                
                if (this.Projectid != null)
                    hash = hash * 59 + this.Projectid.GetHashCode();
                
                if (this.Orgid != null)
                    hash = hash * 59 + this.Orgid.GetHashCode();
                
                return hash;
            }
        }

    }
}

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
    public partial class OrgsorgidprojectsprojectidbuildtargetsProjectVersion :  IEquatable<OrgsorgidprojectsprojectidbuildtargetsProjectVersion>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsorgidprojectsprojectidbuildtargetsProjectVersion" /> class.
        /// </summary>
        public OrgsorgidprojectsprojectidbuildtargetsProjectVersion()
        {
            
        }

        
        /// <summary>
        /// filename for the primary artifact
        /// </summary>
        /// <value>filename for the primary artifact</value>
        [DataMember(Name="filename", EmitDefaultValue=false)]
        public string Filename { get; set; }
  
        
        /// <summary>
        /// size of the the primary build artifact in bytes
        /// </summary>
        /// <value>size of the the primary build artifact in bytes</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public double? Size { get; set; }
  
        
        /// <summary>
        /// creation date
        /// </summary>
        /// <value>creation date</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public string Created { get; set; }
  
        
        /// <summary>
        /// iPhone unique identifiers that are able to install this build
        /// </summary>
        /// <value>iPhone unique identifiers that are able to install this build</value>
        [DataMember(Name="udids", EmitDefaultValue=false)]
        public List<string> Udids { get; set; }
  
        
        /// <summary>
        /// automatically generated name for the build
        /// </summary>
        /// <value>automatically generated name for the build</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// a unique identifier (com.example.name)
        /// </summary>
        /// <value>a unique identifier (com.example.name)</value>
        [DataMember(Name="bundleId", EmitDefaultValue=false)]
        public string BundleId { get; set; }
  
        
        /// <summary>
        /// links to build artifacts
        /// </summary>
        /// <value>links to build artifacts</value>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public Object Links { get; set; }
  
        
        /// <summary>
        /// name of the project
        /// </summary>
        /// <value>name of the project</value>
        [DataMember(Name="projectName", EmitDefaultValue=false)]
        public string ProjectName { get; set; }
  
        
        /// <summary>
        /// last modified date
        /// </summary>
        /// <value>last modified date</value>
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
            sb.Append("class OrgsorgidprojectsprojectidbuildtargetsProjectVersion {\n");
            sb.Append("  Filename: ").Append(Filename).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Udids: ").Append(Udids).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  BundleId: ").Append(BundleId).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  ProjectName: ").Append(ProjectName).Append("\n");
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
            return this.Equals(obj as OrgsorgidprojectsprojectidbuildtargetsProjectVersion);
        }

        /// <summary>
        /// Returns true if OrgsorgidprojectsprojectidbuildtargetsProjectVersion instances are equal
        /// </summary>
        /// <param name="other">Instance of OrgsorgidprojectsprojectidbuildtargetsProjectVersion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrgsorgidprojectsprojectidbuildtargetsProjectVersion other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Filename == other.Filename ||
                    this.Filename != null &&
                    this.Filename.Equals(other.Filename)
                ) && 
                (
                    this.Size == other.Size ||
                    this.Size != null &&
                    this.Size.Equals(other.Size)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.Udids == other.Udids ||
                    this.Udids != null &&
                    this.Udids.SequenceEqual(other.Udids)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.BundleId == other.BundleId ||
                    this.BundleId != null &&
                    this.BundleId.Equals(other.BundleId)
                ) && 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
                ) && 
                (
                    this.ProjectName == other.ProjectName ||
                    this.ProjectName != null &&
                    this.ProjectName.Equals(other.ProjectName)
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
                
                if (this.Filename != null)
                    hash = hash * 59 + this.Filename.GetHashCode();
                
                if (this.Size != null)
                    hash = hash * 59 + this.Size.GetHashCode();
                
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                
                if (this.Udids != null)
                    hash = hash * 59 + this.Udids.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.BundleId != null)
                    hash = hash * 59 + this.BundleId.GetHashCode();
                
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                
                if (this.ProjectName != null)
                    hash = hash * 59 + this.ProjectName.GetHashCode();
                
                if (this.LastMod != null)
                    hash = hash * 59 + this.LastMod.GetHashCode();
                
                if (this.Platform != null)
                    hash = hash * 59 + this.Platform.GetHashCode();
                
                return hash;
            }
        }

    }
}

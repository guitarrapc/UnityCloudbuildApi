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
    public partial class InlineResponse2008 :  IEquatable<InlineResponse2008>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2008" /> class.
        /// </summary>
        public InlineResponse2008()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets SuccessfulBuilds
        /// </summary>
        [DataMember(Name="successfulBuilds", EmitDefaultValue=false)]
        public double? SuccessfulBuilds { get; set; }
  
        
        /// <summary>
        /// Gets or Sets BuildSuccessHealth
        /// </summary>
        [DataMember(Name="buildSuccessHealth", EmitDefaultValue=false)]
        public double? BuildSuccessHealth { get; set; }
  
        
        /// <summary>
        /// Gets or Sets AverageTime
        /// </summary>
        [DataMember(Name="averageTime", EmitDefaultValue=false)]
        public double? AverageTime { get; set; }
  
        
        /// <summary>
        /// Gets or Sets FailedBuilds
        /// </summary>
        [DataMember(Name="failedBuilds", EmitDefaultValue=false)]
        public double? FailedBuilds { get; set; }
  
        
        /// <summary>
        /// Gets or Sets BuildCancelHealth
        /// </summary>
        [DataMember(Name="buildCancelHealth", EmitDefaultValue=false)]
        public double? BuildCancelHealth { get; set; }
  
        
        /// <summary>
        /// Gets or Sets BuildPendingHealth
        /// </summary>
        [DataMember(Name="buildPendingHealth", EmitDefaultValue=false)]
        public double? BuildPendingHealth { get; set; }
  
        
        /// <summary>
        /// Gets or Sets JobCount
        /// </summary>
        [DataMember(Name="jobCount", EmitDefaultValue=false)]
        public double? JobCount { get; set; }
  
        
        /// <summary>
        /// Gets or Sets CanceledBuilds
        /// </summary>
        [DataMember(Name="canceledBuilds", EmitDefaultValue=false)]
        public double? CanceledBuilds { get; set; }
  
        
        /// <summary>
        /// Gets or Sets AverageWorkspaceSize
        /// </summary>
        [DataMember(Name="averageWorkspaceSize", EmitDefaultValue=false)]
        public double? AverageWorkspaceSize { get; set; }
  
        
        /// <summary>
        /// Gets or Sets BuildPoorHealth
        /// </summary>
        [DataMember(Name="buildPoorHealth", EmitDefaultValue=false)]
        public double? BuildPoorHealth { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2008 {\n");
            sb.Append("  SuccessfulBuilds: ").Append(SuccessfulBuilds).Append("\n");
            sb.Append("  BuildSuccessHealth: ").Append(BuildSuccessHealth).Append("\n");
            sb.Append("  AverageTime: ").Append(AverageTime).Append("\n");
            sb.Append("  FailedBuilds: ").Append(FailedBuilds).Append("\n");
            sb.Append("  BuildCancelHealth: ").Append(BuildCancelHealth).Append("\n");
            sb.Append("  BuildPendingHealth: ").Append(BuildPendingHealth).Append("\n");
            sb.Append("  JobCount: ").Append(JobCount).Append("\n");
            sb.Append("  CanceledBuilds: ").Append(CanceledBuilds).Append("\n");
            sb.Append("  AverageWorkspaceSize: ").Append(AverageWorkspaceSize).Append("\n");
            sb.Append("  BuildPoorHealth: ").Append(BuildPoorHealth).Append("\n");
            
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
            return this.Equals(obj as InlineResponse2008);
        }

        /// <summary>
        /// Returns true if InlineResponse2008 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2008 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2008 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SuccessfulBuilds == other.SuccessfulBuilds ||
                    this.SuccessfulBuilds != null &&
                    this.SuccessfulBuilds.Equals(other.SuccessfulBuilds)
                ) && 
                (
                    this.BuildSuccessHealth == other.BuildSuccessHealth ||
                    this.BuildSuccessHealth != null &&
                    this.BuildSuccessHealth.Equals(other.BuildSuccessHealth)
                ) && 
                (
                    this.AverageTime == other.AverageTime ||
                    this.AverageTime != null &&
                    this.AverageTime.Equals(other.AverageTime)
                ) && 
                (
                    this.FailedBuilds == other.FailedBuilds ||
                    this.FailedBuilds != null &&
                    this.FailedBuilds.Equals(other.FailedBuilds)
                ) && 
                (
                    this.BuildCancelHealth == other.BuildCancelHealth ||
                    this.BuildCancelHealth != null &&
                    this.BuildCancelHealth.Equals(other.BuildCancelHealth)
                ) && 
                (
                    this.BuildPendingHealth == other.BuildPendingHealth ||
                    this.BuildPendingHealth != null &&
                    this.BuildPendingHealth.Equals(other.BuildPendingHealth)
                ) && 
                (
                    this.JobCount == other.JobCount ||
                    this.JobCount != null &&
                    this.JobCount.Equals(other.JobCount)
                ) && 
                (
                    this.CanceledBuilds == other.CanceledBuilds ||
                    this.CanceledBuilds != null &&
                    this.CanceledBuilds.Equals(other.CanceledBuilds)
                ) && 
                (
                    this.AverageWorkspaceSize == other.AverageWorkspaceSize ||
                    this.AverageWorkspaceSize != null &&
                    this.AverageWorkspaceSize.Equals(other.AverageWorkspaceSize)
                ) && 
                (
                    this.BuildPoorHealth == other.BuildPoorHealth ||
                    this.BuildPoorHealth != null &&
                    this.BuildPoorHealth.Equals(other.BuildPoorHealth)
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
                
                if (this.SuccessfulBuilds != null)
                    hash = hash * 59 + this.SuccessfulBuilds.GetHashCode();
                
                if (this.BuildSuccessHealth != null)
                    hash = hash * 59 + this.BuildSuccessHealth.GetHashCode();
                
                if (this.AverageTime != null)
                    hash = hash * 59 + this.AverageTime.GetHashCode();
                
                if (this.FailedBuilds != null)
                    hash = hash * 59 + this.FailedBuilds.GetHashCode();
                
                if (this.BuildCancelHealth != null)
                    hash = hash * 59 + this.BuildCancelHealth.GetHashCode();
                
                if (this.BuildPendingHealth != null)
                    hash = hash * 59 + this.BuildPendingHealth.GetHashCode();
                
                if (this.JobCount != null)
                    hash = hash * 59 + this.JobCount.GetHashCode();
                
                if (this.CanceledBuilds != null)
                    hash = hash * 59 + this.CanceledBuilds.GetHashCode();
                
                if (this.AverageWorkspaceSize != null)
                    hash = hash * 59 + this.AverageWorkspaceSize.GetHashCode();
                
                if (this.BuildPoorHealth != null)
                    hash = hash * 59 + this.BuildPoorHealth.GetHashCode();
                
                return hash;
            }
        }

    }
}

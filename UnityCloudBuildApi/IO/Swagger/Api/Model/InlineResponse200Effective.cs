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
    /// effective billing plan, this includes temporary overrides and specials
    /// </summary>
    [DataContract]
    public partial class InlineResponse200Effective :  IEquatable<InlineResponse200Effective>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse200Effective" /> class.
        /// </summary>
        public InlineResponse200Effective()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets RepoSizeLimitThresholdMB
        /// </summary>
        [DataMember(Name="repoSizeLimitThresholdMB", EmitDefaultValue=false)]
        public double? RepoSizeLimitThresholdMB { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ScheduledBuilds
        /// </summary>
        [DataMember(Name="scheduledBuilds", EmitDefaultValue=false)]
        public bool? ScheduledBuilds { get; set; }
  
        
        /// <summary>
        /// Gets or Sets CooldownMinutes
        /// </summary>
        [DataMember(Name="cooldownMinutes", EmitDefaultValue=false)]
        public double? CooldownMinutes { get; set; }
  
        
        /// <summary>
        /// Gets or Sets AdvancedFeatures
        /// </summary>
        [DataMember(Name="advancedFeatures", EmitDefaultValue=false)]
        public List<string> AdvancedFeatures { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DownloadLimitMB
        /// </summary>
        [DataMember(Name="downloadLimitMB", EmitDefaultValue=false)]
        public double? DownloadLimitMB { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ConcurrentBuilds
        /// </summary>
        [DataMember(Name="concurrentBuilds", EmitDefaultValue=false)]
        public double? ConcurrentBuilds { get; set; }
  
        
        /// <summary>
        /// Gets or Sets LibraryCaching
        /// </summary>
        [DataMember(Name="libraryCaching", EmitDefaultValue=false)]
        public bool? LibraryCaching { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }
  
        
        /// <summary>
        /// Gets or Sets WorkspaceCaching
        /// </summary>
        [DataMember(Name="workspaceCaching", EmitDefaultValue=false)]
        public bool? WorkspaceCaching { get; set; }
  
        
        /// <summary>
        /// Gets or Sets NumProjects
        /// </summary>
        [DataMember(Name="numProjects", EmitDefaultValue=false)]
        public double? NumProjects { get; set; }
  
        
        /// <summary>
        /// Gets or Sets CooldownGracePeriodMinutes
        /// </summary>
        [DataMember(Name="cooldownGracePeriodMinutes", EmitDefaultValue=false)]
        public double? CooldownGracePeriodMinutes { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ApiAccess
        /// </summary>
        [DataMember(Name="apiAccess", EmitDefaultValue=false)]
        public bool? ApiAccess { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ScmTypes
        /// </summary>
        [DataMember(Name="scmTypes", EmitDefaultValue=false)]
        public List<string> ScmTypes { get; set; }
  
        
        /// <summary>
        /// Gets or Sets PushExternalServices
        /// </summary>
        [DataMember(Name="pushExternalServices", EmitDefaultValue=false)]
        public bool? PushExternalServices { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Collaborators
        /// </summary>
        [DataMember(Name="collaborators", EmitDefaultValue=false)]
        public double? Collaborators { get; set; }
  
        
        /// <summary>
        /// Gets or Sets SupportTickets
        /// </summary>
        [DataMember(Name="supportTickets", EmitDefaultValue=false)]
        public bool? SupportTickets { get; set; }
  
        
        /// <summary>
        /// Gets or Sets BuildManifest
        /// </summary>
        [DataMember(Name="buildManifest", EmitDefaultValue=false)]
        public bool? BuildManifest { get; set; }
  
        
        /// <summary>
        /// Gets or Sets RepoSizeLimitMB
        /// </summary>
        [DataMember(Name="repoSizeLimitMB", EmitDefaultValue=false)]
        public double? RepoSizeLimitMB { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse200Effective {\n");
            sb.Append("  RepoSizeLimitThresholdMB: ").Append(RepoSizeLimitThresholdMB).Append("\n");
            sb.Append("  ScheduledBuilds: ").Append(ScheduledBuilds).Append("\n");
            sb.Append("  CooldownMinutes: ").Append(CooldownMinutes).Append("\n");
            sb.Append("  AdvancedFeatures: ").Append(AdvancedFeatures).Append("\n");
            sb.Append("  DownloadLimitMB: ").Append(DownloadLimitMB).Append("\n");
            sb.Append("  ConcurrentBuilds: ").Append(ConcurrentBuilds).Append("\n");
            sb.Append("  LibraryCaching: ").Append(LibraryCaching).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  WorkspaceCaching: ").Append(WorkspaceCaching).Append("\n");
            sb.Append("  NumProjects: ").Append(NumProjects).Append("\n");
            sb.Append("  CooldownGracePeriodMinutes: ").Append(CooldownGracePeriodMinutes).Append("\n");
            sb.Append("  ApiAccess: ").Append(ApiAccess).Append("\n");
            sb.Append("  ScmTypes: ").Append(ScmTypes).Append("\n");
            sb.Append("  PushExternalServices: ").Append(PushExternalServices).Append("\n");
            sb.Append("  Collaborators: ").Append(Collaborators).Append("\n");
            sb.Append("  SupportTickets: ").Append(SupportTickets).Append("\n");
            sb.Append("  BuildManifest: ").Append(BuildManifest).Append("\n");
            sb.Append("  RepoSizeLimitMB: ").Append(RepoSizeLimitMB).Append("\n");
            
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
            return this.Equals(obj as InlineResponse200Effective);
        }

        /// <summary>
        /// Returns true if InlineResponse200Effective instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse200Effective to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse200Effective other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RepoSizeLimitThresholdMB == other.RepoSizeLimitThresholdMB ||
                    this.RepoSizeLimitThresholdMB != null &&
                    this.RepoSizeLimitThresholdMB.Equals(other.RepoSizeLimitThresholdMB)
                ) && 
                (
                    this.ScheduledBuilds == other.ScheduledBuilds ||
                    this.ScheduledBuilds != null &&
                    this.ScheduledBuilds.Equals(other.ScheduledBuilds)
                ) && 
                (
                    this.CooldownMinutes == other.CooldownMinutes ||
                    this.CooldownMinutes != null &&
                    this.CooldownMinutes.Equals(other.CooldownMinutes)
                ) && 
                (
                    this.AdvancedFeatures == other.AdvancedFeatures ||
                    this.AdvancedFeatures != null &&
                    this.AdvancedFeatures.SequenceEqual(other.AdvancedFeatures)
                ) && 
                (
                    this.DownloadLimitMB == other.DownloadLimitMB ||
                    this.DownloadLimitMB != null &&
                    this.DownloadLimitMB.Equals(other.DownloadLimitMB)
                ) && 
                (
                    this.ConcurrentBuilds == other.ConcurrentBuilds ||
                    this.ConcurrentBuilds != null &&
                    this.ConcurrentBuilds.Equals(other.ConcurrentBuilds)
                ) && 
                (
                    this.LibraryCaching == other.LibraryCaching ||
                    this.LibraryCaching != null &&
                    this.LibraryCaching.Equals(other.LibraryCaching)
                ) && 
                (
                    this.Label == other.Label ||
                    this.Label != null &&
                    this.Label.Equals(other.Label)
                ) && 
                (
                    this.WorkspaceCaching == other.WorkspaceCaching ||
                    this.WorkspaceCaching != null &&
                    this.WorkspaceCaching.Equals(other.WorkspaceCaching)
                ) && 
                (
                    this.NumProjects == other.NumProjects ||
                    this.NumProjects != null &&
                    this.NumProjects.Equals(other.NumProjects)
                ) && 
                (
                    this.CooldownGracePeriodMinutes == other.CooldownGracePeriodMinutes ||
                    this.CooldownGracePeriodMinutes != null &&
                    this.CooldownGracePeriodMinutes.Equals(other.CooldownGracePeriodMinutes)
                ) && 
                (
                    this.ApiAccess == other.ApiAccess ||
                    this.ApiAccess != null &&
                    this.ApiAccess.Equals(other.ApiAccess)
                ) && 
                (
                    this.ScmTypes == other.ScmTypes ||
                    this.ScmTypes != null &&
                    this.ScmTypes.SequenceEqual(other.ScmTypes)
                ) && 
                (
                    this.PushExternalServices == other.PushExternalServices ||
                    this.PushExternalServices != null &&
                    this.PushExternalServices.Equals(other.PushExternalServices)
                ) && 
                (
                    this.Collaborators == other.Collaborators ||
                    this.Collaborators != null &&
                    this.Collaborators.Equals(other.Collaborators)
                ) && 
                (
                    this.SupportTickets == other.SupportTickets ||
                    this.SupportTickets != null &&
                    this.SupportTickets.Equals(other.SupportTickets)
                ) && 
                (
                    this.BuildManifest == other.BuildManifest ||
                    this.BuildManifest != null &&
                    this.BuildManifest.Equals(other.BuildManifest)
                ) && 
                (
                    this.RepoSizeLimitMB == other.RepoSizeLimitMB ||
                    this.RepoSizeLimitMB != null &&
                    this.RepoSizeLimitMB.Equals(other.RepoSizeLimitMB)
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
                
                if (this.RepoSizeLimitThresholdMB != null)
                    hash = hash * 59 + this.RepoSizeLimitThresholdMB.GetHashCode();
                
                if (this.ScheduledBuilds != null)
                    hash = hash * 59 + this.ScheduledBuilds.GetHashCode();
                
                if (this.CooldownMinutes != null)
                    hash = hash * 59 + this.CooldownMinutes.GetHashCode();
                
                if (this.AdvancedFeatures != null)
                    hash = hash * 59 + this.AdvancedFeatures.GetHashCode();
                
                if (this.DownloadLimitMB != null)
                    hash = hash * 59 + this.DownloadLimitMB.GetHashCode();
                
                if (this.ConcurrentBuilds != null)
                    hash = hash * 59 + this.ConcurrentBuilds.GetHashCode();
                
                if (this.LibraryCaching != null)
                    hash = hash * 59 + this.LibraryCaching.GetHashCode();
                
                if (this.Label != null)
                    hash = hash * 59 + this.Label.GetHashCode();
                
                if (this.WorkspaceCaching != null)
                    hash = hash * 59 + this.WorkspaceCaching.GetHashCode();
                
                if (this.NumProjects != null)
                    hash = hash * 59 + this.NumProjects.GetHashCode();
                
                if (this.CooldownGracePeriodMinutes != null)
                    hash = hash * 59 + this.CooldownGracePeriodMinutes.GetHashCode();
                
                if (this.ApiAccess != null)
                    hash = hash * 59 + this.ApiAccess.GetHashCode();
                
                if (this.ScmTypes != null)
                    hash = hash * 59 + this.ScmTypes.GetHashCode();
                
                if (this.PushExternalServices != null)
                    hash = hash * 59 + this.PushExternalServices.GetHashCode();
                
                if (this.Collaborators != null)
                    hash = hash * 59 + this.Collaborators.GetHashCode();
                
                if (this.SupportTickets != null)
                    hash = hash * 59 + this.SupportTickets.GetHashCode();
                
                if (this.BuildManifest != null)
                    hash = hash * 59 + this.BuildManifest.GetHashCode();
                
                if (this.RepoSizeLimitMB != null)
                    hash = hash * 59 + this.RepoSizeLimitMB.GetHashCode();
                
                return hash;
            }
        }

    }
}

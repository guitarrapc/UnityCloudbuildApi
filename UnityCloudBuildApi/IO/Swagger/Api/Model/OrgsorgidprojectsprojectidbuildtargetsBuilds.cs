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
    /// buildattempt
    /// </summary>
    [DataContract]
    public partial class OrgsorgidprojectsprojectidbuildtargetsBuilds :  IEquatable<OrgsorgidprojectsprojectidbuildtargetsBuilds>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsorgidprojectsprojectidbuildtargetsBuilds" /> class.
        /// </summary>
        public OrgsorgidprojectsprojectidbuildtargetsBuilds()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets TestResults
        /// </summary>
        [DataMember(Name="testResults", EmitDefaultValue=false)]
        public OrgsorgidprojectsprojectidbuildtargetsTestResults TestResults { get; set; }
  
        
        /// <summary>
        /// total time for the build
        /// </summary>
        /// <value>total time for the build</value>
        [DataMember(Name="totalTimeInSeconds", EmitDefaultValue=false)]
        public double? TotalTimeInSeconds { get; set; }
  
        
        /// <summary>
        /// amount of time spent checking out code
        /// </summary>
        /// <value>amount of time spent checking out code</value>
        [DataMember(Name="checkoutTimeInSeconds", EmitDefaultValue=false)]
        public double? CheckoutTimeInSeconds { get; set; }
  
        
        /// <summary>
        /// Gets or Sets AuditChanges
        /// </summary>
        [DataMember(Name="auditChanges", EmitDefaultValue=false)]
        public double? AuditChanges { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        [DataMember(Name="platform", EmitDefaultValue=false)]
        public string Platform { get; set; }
  
        
        /// <summary>
        /// when the build starting checking out code
        /// </summary>
        /// <value>when the build starting checking out code</value>
        [DataMember(Name="checkoutStartTime", EmitDefaultValue=false)]
        public string CheckoutStartTime { get; set; }
  
        
        /// <summary>
        /// Gets or Sets BuildStatus
        /// </summary>
        [DataMember(Name="buildStatus", EmitDefaultValue=false)]
        public string BuildStatus { get; set; }
  
        
        /// <summary>
        /// a list of source control changes between this and the last build
        /// </summary>
        /// <value>a list of source control changes between this and the last build</value>
        [DataMember(Name="changeset", EmitDefaultValue=false)]
        public List<OrgsorgidprojectsprojectidbuildtargetsTestResultsIntegrationTests> Changeset { get; set; }
  
        
        /// <summary>
        /// 'latest' or a unity dot version with underscores (ex. '4_6_5')
        /// </summary>
        /// <value>'latest' or a unity dot version with underscores (ex. '4_6_5')</value>
        [DataMember(Name="unityVersion", EmitDefaultValue=false)]
        public string UnityVersion { get; set; }
  
        
        /// <summary>
        /// source control commit id for the build
        /// </summary>
        /// <value>source control commit id for the build</value>
        [DataMember(Name="lastBuiltRevision", EmitDefaultValue=false)]
        public string LastBuiltRevision { get; set; }
  
        
        /// <summary>
        /// when the build started compiling
        /// </summary>
        /// <value>when the build started compiling</value>
        [DataMember(Name="buildStartTime", EmitDefaultValue=false)]
        public string BuildStartTime { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public Object Links { get; set; }
  
        
        /// <summary>
        /// amount of time spend compiling
        /// </summary>
        /// <value>amount of time spend compiling</value>
        [DataMember(Name="buildTimeInSeconds", EmitDefaultValue=false)]
        public double? BuildTimeInSeconds { get; set; }
  
        
        /// <summary>
        /// unique id auto-generated from the build target name
        /// </summary>
        /// <value>unique id auto-generated from the build target name</value>
        [DataMember(Name="buildtargetid", EmitDefaultValue=false)]
        public string Buildtargetid { get; set; }
  
        
        /// <summary>
        /// when the build was created
        /// </summary>
        /// <value>when the build was created</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public string Created { get; set; }
  
        
        /// <summary>
        /// size of workspace in bytes
        /// </summary>
        /// <value>size of workspace in bytes</value>
        [DataMember(Name="workspaceSize", EmitDefaultValue=false)]
        public double? WorkspaceSize { get; set; }
  
        
        /// <summary>
        /// when the build completely finished
        /// </summary>
        /// <value>when the build completely finished</value>
        [DataMember(Name="finished", EmitDefaultValue=false)]
        public string Finished { get; set; }
  
        
        /// <summary>
        /// amount of time spent saving build artifacts
        /// </summary>
        /// <value>amount of time spent saving build artifacts</value>
        [DataMember(Name="publishTimeInSeconds", EmitDefaultValue=false)]
        public double? PublishTimeInSeconds { get; set; }
  
        
        /// <summary>
        /// scm branch to be built
        /// </summary>
        /// <value>scm branch to be built</value>
        [DataMember(Name="scmBranch", EmitDefaultValue=false)]
        public string ScmBranch { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Build
        /// </summary>
        [DataMember(Name="build", EmitDefaultValue=false)]
        public double? Build { get; set; }
  
        
        /// <summary>
        /// Gets or Sets BuildTargetName
        /// </summary>
        [DataMember(Name="buildTargetName", EmitDefaultValue=false)]
        public string BuildTargetName { get; set; }
  
        
        /// <summary>
        /// when the build started saving build artifacts
        /// </summary>
        /// <value>when the build started saving build artifacts</value>
        [DataMember(Name="publishStartTime", EmitDefaultValue=false)]
        public string PublishStartTime { get; set; }
  
        
        /// <summary>
        /// Gets or Sets XcodeVersion
        /// </summary>
        [DataMember(Name="xcodeVersion", EmitDefaultValue=false)]
        public string XcodeVersion { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ProjectVersion
        /// </summary>
        [DataMember(Name="projectVersion", EmitDefaultValue=false)]
        public OrgsorgidprojectsprojectidbuildtargetsProjectVersion ProjectVersion { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrgsorgidprojectsprojectidbuildtargetsBuilds {\n");
            sb.Append("  TestResults: ").Append(TestResults).Append("\n");
            sb.Append("  TotalTimeInSeconds: ").Append(TotalTimeInSeconds).Append("\n");
            sb.Append("  CheckoutTimeInSeconds: ").Append(CheckoutTimeInSeconds).Append("\n");
            sb.Append("  AuditChanges: ").Append(AuditChanges).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  CheckoutStartTime: ").Append(CheckoutStartTime).Append("\n");
            sb.Append("  BuildStatus: ").Append(BuildStatus).Append("\n");
            sb.Append("  Changeset: ").Append(Changeset).Append("\n");
            sb.Append("  UnityVersion: ").Append(UnityVersion).Append("\n");
            sb.Append("  LastBuiltRevision: ").Append(LastBuiltRevision).Append("\n");
            sb.Append("  BuildStartTime: ").Append(BuildStartTime).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  BuildTimeInSeconds: ").Append(BuildTimeInSeconds).Append("\n");
            sb.Append("  Buildtargetid: ").Append(Buildtargetid).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  WorkspaceSize: ").Append(WorkspaceSize).Append("\n");
            sb.Append("  Finished: ").Append(Finished).Append("\n");
            sb.Append("  PublishTimeInSeconds: ").Append(PublishTimeInSeconds).Append("\n");
            sb.Append("  ScmBranch: ").Append(ScmBranch).Append("\n");
            sb.Append("  Build: ").Append(Build).Append("\n");
            sb.Append("  BuildTargetName: ").Append(BuildTargetName).Append("\n");
            sb.Append("  PublishStartTime: ").Append(PublishStartTime).Append("\n");
            sb.Append("  XcodeVersion: ").Append(XcodeVersion).Append("\n");
            sb.Append("  ProjectVersion: ").Append(ProjectVersion).Append("\n");
            
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
            return this.Equals(obj as OrgsorgidprojectsprojectidbuildtargetsBuilds);
        }

        /// <summary>
        /// Returns true if OrgsorgidprojectsprojectidbuildtargetsBuilds instances are equal
        /// </summary>
        /// <param name="other">Instance of OrgsorgidprojectsprojectidbuildtargetsBuilds to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrgsorgidprojectsprojectidbuildtargetsBuilds other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TestResults == other.TestResults ||
                    this.TestResults != null &&
                    this.TestResults.Equals(other.TestResults)
                ) && 
                (
                    this.TotalTimeInSeconds == other.TotalTimeInSeconds ||
                    this.TotalTimeInSeconds != null &&
                    this.TotalTimeInSeconds.Equals(other.TotalTimeInSeconds)
                ) && 
                (
                    this.CheckoutTimeInSeconds == other.CheckoutTimeInSeconds ||
                    this.CheckoutTimeInSeconds != null &&
                    this.CheckoutTimeInSeconds.Equals(other.CheckoutTimeInSeconds)
                ) && 
                (
                    this.AuditChanges == other.AuditChanges ||
                    this.AuditChanges != null &&
                    this.AuditChanges.Equals(other.AuditChanges)
                ) && 
                (
                    this.Error == other.Error ||
                    this.Error != null &&
                    this.Error.Equals(other.Error)
                ) && 
                (
                    this.Platform == other.Platform ||
                    this.Platform != null &&
                    this.Platform.Equals(other.Platform)
                ) && 
                (
                    this.CheckoutStartTime == other.CheckoutStartTime ||
                    this.CheckoutStartTime != null &&
                    this.CheckoutStartTime.Equals(other.CheckoutStartTime)
                ) && 
                (
                    this.BuildStatus == other.BuildStatus ||
                    this.BuildStatus != null &&
                    this.BuildStatus.Equals(other.BuildStatus)
                ) && 
                (
                    this.Changeset == other.Changeset ||
                    this.Changeset != null &&
                    this.Changeset.SequenceEqual(other.Changeset)
                ) && 
                (
                    this.UnityVersion == other.UnityVersion ||
                    this.UnityVersion != null &&
                    this.UnityVersion.Equals(other.UnityVersion)
                ) && 
                (
                    this.LastBuiltRevision == other.LastBuiltRevision ||
                    this.LastBuiltRevision != null &&
                    this.LastBuiltRevision.Equals(other.LastBuiltRevision)
                ) && 
                (
                    this.BuildStartTime == other.BuildStartTime ||
                    this.BuildStartTime != null &&
                    this.BuildStartTime.Equals(other.BuildStartTime)
                ) && 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
                ) && 
                (
                    this.BuildTimeInSeconds == other.BuildTimeInSeconds ||
                    this.BuildTimeInSeconds != null &&
                    this.BuildTimeInSeconds.Equals(other.BuildTimeInSeconds)
                ) && 
                (
                    this.Buildtargetid == other.Buildtargetid ||
                    this.Buildtargetid != null &&
                    this.Buildtargetid.Equals(other.Buildtargetid)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.WorkspaceSize == other.WorkspaceSize ||
                    this.WorkspaceSize != null &&
                    this.WorkspaceSize.Equals(other.WorkspaceSize)
                ) && 
                (
                    this.Finished == other.Finished ||
                    this.Finished != null &&
                    this.Finished.Equals(other.Finished)
                ) && 
                (
                    this.PublishTimeInSeconds == other.PublishTimeInSeconds ||
                    this.PublishTimeInSeconds != null &&
                    this.PublishTimeInSeconds.Equals(other.PublishTimeInSeconds)
                ) && 
                (
                    this.ScmBranch == other.ScmBranch ||
                    this.ScmBranch != null &&
                    this.ScmBranch.Equals(other.ScmBranch)
                ) && 
                (
                    this.Build == other.Build ||
                    this.Build != null &&
                    this.Build.Equals(other.Build)
                ) && 
                (
                    this.BuildTargetName == other.BuildTargetName ||
                    this.BuildTargetName != null &&
                    this.BuildTargetName.Equals(other.BuildTargetName)
                ) && 
                (
                    this.PublishStartTime == other.PublishStartTime ||
                    this.PublishStartTime != null &&
                    this.PublishStartTime.Equals(other.PublishStartTime)
                ) && 
                (
                    this.XcodeVersion == other.XcodeVersion ||
                    this.XcodeVersion != null &&
                    this.XcodeVersion.Equals(other.XcodeVersion)
                ) && 
                (
                    this.ProjectVersion == other.ProjectVersion ||
                    this.ProjectVersion != null &&
                    this.ProjectVersion.Equals(other.ProjectVersion)
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
                
                if (this.TestResults != null)
                    hash = hash * 59 + this.TestResults.GetHashCode();
                
                if (this.TotalTimeInSeconds != null)
                    hash = hash * 59 + this.TotalTimeInSeconds.GetHashCode();
                
                if (this.CheckoutTimeInSeconds != null)
                    hash = hash * 59 + this.CheckoutTimeInSeconds.GetHashCode();
                
                if (this.AuditChanges != null)
                    hash = hash * 59 + this.AuditChanges.GetHashCode();
                
                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();
                
                if (this.Platform != null)
                    hash = hash * 59 + this.Platform.GetHashCode();
                
                if (this.CheckoutStartTime != null)
                    hash = hash * 59 + this.CheckoutStartTime.GetHashCode();
                
                if (this.BuildStatus != null)
                    hash = hash * 59 + this.BuildStatus.GetHashCode();
                
                if (this.Changeset != null)
                    hash = hash * 59 + this.Changeset.GetHashCode();
                
                if (this.UnityVersion != null)
                    hash = hash * 59 + this.UnityVersion.GetHashCode();
                
                if (this.LastBuiltRevision != null)
                    hash = hash * 59 + this.LastBuiltRevision.GetHashCode();
                
                if (this.BuildStartTime != null)
                    hash = hash * 59 + this.BuildStartTime.GetHashCode();
                
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                
                if (this.BuildTimeInSeconds != null)
                    hash = hash * 59 + this.BuildTimeInSeconds.GetHashCode();
                
                if (this.Buildtargetid != null)
                    hash = hash * 59 + this.Buildtargetid.GetHashCode();
                
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                
                if (this.WorkspaceSize != null)
                    hash = hash * 59 + this.WorkspaceSize.GetHashCode();
                
                if (this.Finished != null)
                    hash = hash * 59 + this.Finished.GetHashCode();
                
                if (this.PublishTimeInSeconds != null)
                    hash = hash * 59 + this.PublishTimeInSeconds.GetHashCode();
                
                if (this.ScmBranch != null)
                    hash = hash * 59 + this.ScmBranch.GetHashCode();
                
                if (this.Build != null)
                    hash = hash * 59 + this.Build.GetHashCode();
                
                if (this.BuildTargetName != null)
                    hash = hash * 59 + this.BuildTargetName.GetHashCode();
                
                if (this.PublishStartTime != null)
                    hash = hash * 59 + this.PublishStartTime.GetHashCode();
                
                if (this.XcodeVersion != null)
                    hash = hash * 59 + this.XcodeVersion.GetHashCode();
                
                if (this.ProjectVersion != null)
                    hash = hash * 59 + this.ProjectVersion.GetHashCode();
                
                return hash;
            }
        }

    }
}

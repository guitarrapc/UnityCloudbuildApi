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
    public partial class OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnityPlayerExporter :  IEquatable<OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnityPlayerExporter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnityPlayerExporter" /> class.
        /// </summary>
        public OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnityPlayerExporter()
        {
            
        }

        
        /// <summary>
        /// Unity Editor build options. Use BuildOptions.Development and BuildOptions.AllowDebugging to create a development build.
        /// </summary>
        /// <value>Unity Editor build options. Use BuildOptions.Development and BuildOptions.AllowDebugging to create a development build.</value>
        [DataMember(Name="buildOptions", EmitDefaultValue=false)]
        public List<string> BuildOptions { get; set; }
  
        
        /// <summary>
        /// A list of scenes to build overriding those specified in the Build Settings menu of your Unity project.
        /// </summary>
        /// <value>A list of scenes to build overriding those specified in the Build Settings menu of your Unity project.</value>
        [DataMember(Name="sceneList", EmitDefaultValue=false)]
        public List<string> SceneList { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnityPlayerExporter {\n");
            sb.Append("  BuildOptions: ").Append(BuildOptions).Append("\n");
            sb.Append("  SceneList: ").Append(SceneList).Append("\n");
            
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
            return this.Equals(obj as OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnityPlayerExporter);
        }

        /// <summary>
        /// Returns true if OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnityPlayerExporter instances are equal
        /// </summary>
        /// <param name="other">Instance of OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnityPlayerExporter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnityPlayerExporter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BuildOptions == other.BuildOptions ||
                    this.BuildOptions != null &&
                    this.BuildOptions.SequenceEqual(other.BuildOptions)
                ) && 
                (
                    this.SceneList == other.SceneList ||
                    this.SceneList != null &&
                    this.SceneList.SequenceEqual(other.SceneList)
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
                
                if (this.BuildOptions != null)
                    hash = hash * 59 + this.BuildOptions.GetHashCode();
                
                if (this.SceneList != null)
                    hash = hash * 59 + this.SceneList.GetHashCode();
                
                return hash;
            }
        }

    }
}

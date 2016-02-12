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
    public partial class OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnityAssetBundles :  IEquatable<OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnityAssetBundles>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnityAssetBundles" /> class.
        /// </summary>
        public OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnityAssetBundles()
        {
            
        }

        
        /// <summary>
        /// copy bundles to streaming assets folder, which will be packaged into the exported player.
        /// </summary>
        /// <value>copy bundles to streaming assets folder, which will be packaged into the exported player.</value>
        [DataMember(Name="copyToStreamingAssets", EmitDefaultValue=false)]
        public bool? CopyToStreamingAssets { get; set; }
  
        
        /// <summary>
        /// base path relative to Assets folder where asset bundles are output. Default is 'AssetBundles'
        /// </summary>
        /// <value>base path relative to Assets folder where asset bundles are output. Default is 'AssetBundles'</value>
        [DataMember(Name="basePath", EmitDefaultValue=false)]
        public string BasePath { get; set; }
  
        
        /// <summary>
        /// array of patterns to match (C# Regular Expressions) when copying asset bundle files. By default, all bundles will be copied.
        /// </summary>
        /// <value>array of patterns to match (C# Regular Expressions) when copying asset bundle files. By default, all bundles will be copied.</value>
        [DataMember(Name="copyBundlePatterns", EmitDefaultValue=false)]
        public List<string> CopyBundlePatterns { get; set; }
  
        
        /// <summary>
        /// enable asset bundle builds for this target
        /// </summary>
        /// <value>enable asset bundle builds for this target</value>
        [DataMember(Name="buildBundles", EmitDefaultValue=false)]
        public bool? BuildBundles { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnityAssetBundles {\n");
            sb.Append("  CopyToStreamingAssets: ").Append(CopyToStreamingAssets).Append("\n");
            sb.Append("  BasePath: ").Append(BasePath).Append("\n");
            sb.Append("  CopyBundlePatterns: ").Append(CopyBundlePatterns).Append("\n");
            sb.Append("  BuildBundles: ").Append(BuildBundles).Append("\n");
            
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
            return this.Equals(obj as OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnityAssetBundles);
        }

        /// <summary>
        /// Returns true if OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnityAssetBundles instances are equal
        /// </summary>
        /// <param name="other">Instance of OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnityAssetBundles to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnityAssetBundles other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CopyToStreamingAssets == other.CopyToStreamingAssets ||
                    this.CopyToStreamingAssets != null &&
                    this.CopyToStreamingAssets.Equals(other.CopyToStreamingAssets)
                ) && 
                (
                    this.BasePath == other.BasePath ||
                    this.BasePath != null &&
                    this.BasePath.Equals(other.BasePath)
                ) && 
                (
                    this.CopyBundlePatterns == other.CopyBundlePatterns ||
                    this.CopyBundlePatterns != null &&
                    this.CopyBundlePatterns.SequenceEqual(other.CopyBundlePatterns)
                ) && 
                (
                    this.BuildBundles == other.BuildBundles ||
                    this.BuildBundles != null &&
                    this.BuildBundles.Equals(other.BuildBundles)
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
                
                if (this.CopyToStreamingAssets != null)
                    hash = hash * 59 + this.CopyToStreamingAssets.GetHashCode();
                
                if (this.BasePath != null)
                    hash = hash * 59 + this.BasePath.GetHashCode();
                
                if (this.CopyBundlePatterns != null)
                    hash = hash * 59 + this.CopyBundlePatterns.GetHashCode();
                
                if (this.BuildBundles != null)
                    hash = hash * 59 + this.BuildBundles.GetHashCode();
                
                return hash;
            }
        }

    }
}

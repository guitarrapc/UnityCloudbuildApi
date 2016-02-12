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
    public partial class OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnity :  IEquatable<OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnity" /> class.
        /// </summary>
        public OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnity()
        {
            
        }

        
        /// <summary>
        /// Mark build as failed if integration tests do not pass.
        /// </summary>
        /// <value>Mark build as failed if integration tests do not pass.</value>
        [DataMember(Name="failedIntegrationTestFailsBuild", EmitDefaultValue=false)]
        public bool? FailedIntegrationTestFailsBuild { get; set; }
  
        
        /// <summary>
        /// The fully-qualified name of a public static method you want us to call before we start the Unity build process.\nFor example: ClassName.NeatMethod or NameSpace.ClassName.NeatMethod.\nNo trailing parenthesis, and it can't have the same name as your Post-Export method!
        /// </summary>
        /// <value>The fully-qualified name of a public static method you want us to call before we start the Unity build process.\nFor example: ClassName.NeatMethod or NameSpace.ClassName.NeatMethod.\nNo trailing parenthesis, and it can't have the same name as your Post-Export method!</value>
        [DataMember(Name="preExportMethod", EmitDefaultValue=false)]
        public string PreExportMethod { get; set; }
  
        
        /// <summary>
        /// Gets or Sets PlayerSettings
        /// </summary>
        [DataMember(Name="playerSettings", EmitDefaultValue=false)]
        public OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnityPlayerSettings PlayerSettings { get; set; }
  
        
        /// <summary>
        /// Run any unit tests your project has when a build happens.
        /// </summary>
        /// <value>Run any unit tests your project has when a build happens.</value>
        [DataMember(Name="runUnitTests", EmitDefaultValue=false)]
        public bool? RunUnitTests { get; set; }
  
        
        /// <summary>
        /// Relative path to the script that should be run after the build process finishes.
        /// </summary>
        /// <value>Relative path to the script that should be run after the build process finishes.</value>
        [DataMember(Name="postBuildScript", EmitDefaultValue=false)]
        public string PostBuildScript { get; set; }
  
        
        /// <summary>
        /// The fully-qualified name of a public static method you want us to call after we finish the Unity build process\n(but before Xcode). For example: ClassName.CoolMethod or NameSpace.ClassName.CoolMethod. No trailing parenthesis,\nand it can't have the same name as your Post-Export method! This method must accept a string parameter, which\nwill receive the path to the exported Unity player (or Xcode project in the case of iOS).
        /// </summary>
        /// <value>The fully-qualified name of a public static method you want us to call after we finish the Unity build process\n(but before Xcode). For example: ClassName.CoolMethod or NameSpace.ClassName.CoolMethod. No trailing parenthesis,\nand it can't have the same name as your Post-Export method! This method must accept a string parameter, which\nwill receive the path to the exported Unity player (or Xcode project in the case of iOS).</value>
        [DataMember(Name="postExportMethod", EmitDefaultValue=false)]
        public string PostExportMethod { get; set; }
  
        
        /// <summary>
        /// Gets or Sets AssetBundles
        /// </summary>
        [DataMember(Name="assetBundles", EmitDefaultValue=false)]
        public OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnityAssetBundles AssetBundles { get; set; }
  
        
        /// <summary>
        /// Mark builds as failed if the unit tests do not pass.
        /// </summary>
        /// <value>Mark builds as failed if the unit tests do not pass.</value>
        [DataMember(Name="failedUnitTestFailsBuild", EmitDefaultValue=false)]
        public bool? FailedUnitTestFailsBuild { get; set; }
  
        
        /// <summary>
        /// The Unity method to call when running unit tests.
        /// </summary>
        /// <value>The Unity method to call when running unit tests.</value>
        [DataMember(Name="unitTestMethod", EmitDefaultValue=false)]
        public string UnitTestMethod { get; set; }
  
        
        /// <summary>
        /// Gets or Sets PlayerExporter
        /// </summary>
        [DataMember(Name="playerExporter", EmitDefaultValue=false)]
        public OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnityPlayerExporter PlayerExporter { get; set; }
  
        
        /// <summary>
        /// Enter the names of the symbols you want to define for iOS. These symbols can then be used as the conditions\nfor #if directives just like the built-in ones. (i.e. #IF MYDEFINE or #IF AMAZON)
        /// </summary>
        /// <value>Enter the names of the symbols you want to define for iOS. These symbols can then be used as the conditions\nfor #if directives just like the built-in ones. (i.e. #IF MYDEFINE or #IF AMAZON)</value>
        [DataMember(Name="scriptingDefineSymbols", EmitDefaultValue=false)]
        public string ScriptingDefineSymbols { get; set; }
  
        
        /// <summary>
        /// The Unity method to call when running integration tests.
        /// </summary>
        /// <value>The Unity method to call when running integration tests.</value>
        [DataMember(Name="integrationTestMethod", EmitDefaultValue=false)]
        public string IntegrationTestMethod { get; set; }
  
        
        /// <summary>
        /// The collection of scenes to run integration tests within.
        /// </summary>
        /// <value>The collection of scenes to run integration tests within.</value>
        [DataMember(Name="integrationTestSceneList", EmitDefaultValue=false)]
        public List<string> IntegrationTestSceneList { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnity {\n");
            sb.Append("  FailedIntegrationTestFailsBuild: ").Append(FailedIntegrationTestFailsBuild).Append("\n");
            sb.Append("  PreExportMethod: ").Append(PreExportMethod).Append("\n");
            sb.Append("  PlayerSettings: ").Append(PlayerSettings).Append("\n");
            sb.Append("  RunUnitTests: ").Append(RunUnitTests).Append("\n");
            sb.Append("  PostBuildScript: ").Append(PostBuildScript).Append("\n");
            sb.Append("  PostExportMethod: ").Append(PostExportMethod).Append("\n");
            sb.Append("  AssetBundles: ").Append(AssetBundles).Append("\n");
            sb.Append("  FailedUnitTestFailsBuild: ").Append(FailedUnitTestFailsBuild).Append("\n");
            sb.Append("  UnitTestMethod: ").Append(UnitTestMethod).Append("\n");
            sb.Append("  PlayerExporter: ").Append(PlayerExporter).Append("\n");
            sb.Append("  ScriptingDefineSymbols: ").Append(ScriptingDefineSymbols).Append("\n");
            sb.Append("  IntegrationTestMethod: ").Append(IntegrationTestMethod).Append("\n");
            sb.Append("  IntegrationTestSceneList: ").Append(IntegrationTestSceneList).Append("\n");
            
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
            return this.Equals(obj as OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnity);
        }

        /// <summary>
        /// Returns true if OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnity instances are equal
        /// </summary>
        /// <param name="other">Instance of OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrgsorgidprojectsprojectidbuildtargetsSettingsAdvancedUnity other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FailedIntegrationTestFailsBuild == other.FailedIntegrationTestFailsBuild ||
                    this.FailedIntegrationTestFailsBuild != null &&
                    this.FailedIntegrationTestFailsBuild.Equals(other.FailedIntegrationTestFailsBuild)
                ) && 
                (
                    this.PreExportMethod == other.PreExportMethod ||
                    this.PreExportMethod != null &&
                    this.PreExportMethod.Equals(other.PreExportMethod)
                ) && 
                (
                    this.PlayerSettings == other.PlayerSettings ||
                    this.PlayerSettings != null &&
                    this.PlayerSettings.Equals(other.PlayerSettings)
                ) && 
                (
                    this.RunUnitTests == other.RunUnitTests ||
                    this.RunUnitTests != null &&
                    this.RunUnitTests.Equals(other.RunUnitTests)
                ) && 
                (
                    this.PostBuildScript == other.PostBuildScript ||
                    this.PostBuildScript != null &&
                    this.PostBuildScript.Equals(other.PostBuildScript)
                ) && 
                (
                    this.PostExportMethod == other.PostExportMethod ||
                    this.PostExportMethod != null &&
                    this.PostExportMethod.Equals(other.PostExportMethod)
                ) && 
                (
                    this.AssetBundles == other.AssetBundles ||
                    this.AssetBundles != null &&
                    this.AssetBundles.Equals(other.AssetBundles)
                ) && 
                (
                    this.FailedUnitTestFailsBuild == other.FailedUnitTestFailsBuild ||
                    this.FailedUnitTestFailsBuild != null &&
                    this.FailedUnitTestFailsBuild.Equals(other.FailedUnitTestFailsBuild)
                ) && 
                (
                    this.UnitTestMethod == other.UnitTestMethod ||
                    this.UnitTestMethod != null &&
                    this.UnitTestMethod.Equals(other.UnitTestMethod)
                ) && 
                (
                    this.PlayerExporter == other.PlayerExporter ||
                    this.PlayerExporter != null &&
                    this.PlayerExporter.Equals(other.PlayerExporter)
                ) && 
                (
                    this.ScriptingDefineSymbols == other.ScriptingDefineSymbols ||
                    this.ScriptingDefineSymbols != null &&
                    this.ScriptingDefineSymbols.Equals(other.ScriptingDefineSymbols)
                ) && 
                (
                    this.IntegrationTestMethod == other.IntegrationTestMethod ||
                    this.IntegrationTestMethod != null &&
                    this.IntegrationTestMethod.Equals(other.IntegrationTestMethod)
                ) && 
                (
                    this.IntegrationTestSceneList == other.IntegrationTestSceneList ||
                    this.IntegrationTestSceneList != null &&
                    this.IntegrationTestSceneList.SequenceEqual(other.IntegrationTestSceneList)
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
                
                if (this.FailedIntegrationTestFailsBuild != null)
                    hash = hash * 59 + this.FailedIntegrationTestFailsBuild.GetHashCode();
                
                if (this.PreExportMethod != null)
                    hash = hash * 59 + this.PreExportMethod.GetHashCode();
                
                if (this.PlayerSettings != null)
                    hash = hash * 59 + this.PlayerSettings.GetHashCode();
                
                if (this.RunUnitTests != null)
                    hash = hash * 59 + this.RunUnitTests.GetHashCode();
                
                if (this.PostBuildScript != null)
                    hash = hash * 59 + this.PostBuildScript.GetHashCode();
                
                if (this.PostExportMethod != null)
                    hash = hash * 59 + this.PostExportMethod.GetHashCode();
                
                if (this.AssetBundles != null)
                    hash = hash * 59 + this.AssetBundles.GetHashCode();
                
                if (this.FailedUnitTestFailsBuild != null)
                    hash = hash * 59 + this.FailedUnitTestFailsBuild.GetHashCode();
                
                if (this.UnitTestMethod != null)
                    hash = hash * 59 + this.UnitTestMethod.GetHashCode();
                
                if (this.PlayerExporter != null)
                    hash = hash * 59 + this.PlayerExporter.GetHashCode();
                
                if (this.ScriptingDefineSymbols != null)
                    hash = hash * 59 + this.ScriptingDefineSymbols.GetHashCode();
                
                if (this.IntegrationTestMethod != null)
                    hash = hash * 59 + this.IntegrationTestMethod.GetHashCode();
                
                if (this.IntegrationTestSceneList != null)
                    hash = hash * 59 + this.IntegrationTestSceneList.GetHashCode();
                
                return hash;
            }
        }

    }
}

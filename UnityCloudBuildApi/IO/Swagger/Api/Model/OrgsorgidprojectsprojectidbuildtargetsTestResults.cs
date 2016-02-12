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
    /// results from the build&#39;s unit &amp; integration tests, if any
    /// </summary>
    [DataContract]
    public partial class OrgsorgidprojectsprojectidbuildtargetsTestResults :  IEquatable<OrgsorgidprojectsprojectidbuildtargetsTestResults>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsorgidprojectsprojectidbuildtargetsTestResults" /> class.
        /// </summary>
        public OrgsorgidprojectsprojectidbuildtargetsTestResults()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets UnitTest
        /// </summary>
        [DataMember(Name="unit_test", EmitDefaultValue=false)]
        public Object UnitTest { get; set; }
  
        
        /// <summary>
        /// Gets or Sets IntegrationTests
        /// </summary>
        [DataMember(Name="integration_tests", EmitDefaultValue=false)]
        public List<OrgsorgidprojectsprojectidbuildtargetsTestResultsIntegrationTests> IntegrationTests { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrgsorgidprojectsprojectidbuildtargetsTestResults {\n");
            sb.Append("  UnitTest: ").Append(UnitTest).Append("\n");
            sb.Append("  IntegrationTests: ").Append(IntegrationTests).Append("\n");
            
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
            return this.Equals(obj as OrgsorgidprojectsprojectidbuildtargetsTestResults);
        }

        /// <summary>
        /// Returns true if OrgsorgidprojectsprojectidbuildtargetsTestResults instances are equal
        /// </summary>
        /// <param name="other">Instance of OrgsorgidprojectsprojectidbuildtargetsTestResults to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrgsorgidprojectsprojectidbuildtargetsTestResults other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UnitTest == other.UnitTest ||
                    this.UnitTest != null &&
                    this.UnitTest.Equals(other.UnitTest)
                ) && 
                (
                    this.IntegrationTests == other.IntegrationTests ||
                    this.IntegrationTests != null &&
                    this.IntegrationTests.SequenceEqual(other.IntegrationTests)
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
                
                if (this.UnitTest != null)
                    hash = hash * 59 + this.UnitTest.GetHashCode();
                
                if (this.IntegrationTests != null)
                    hash = hash * 59 + this.IntegrationTests.GetHashCode();
                
                return hash;
            }
        }

    }
}

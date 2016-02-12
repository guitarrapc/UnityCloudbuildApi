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
    public partial class InlineResponse202 :  IEquatable<InlineResponse202>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse202" /> class.
        /// </summary>
        public InlineResponse202()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets PollingBuildTargets
        /// </summary>
        [DataMember(Name="pollingBuildTargets", EmitDefaultValue=false)]
        public List<string> PollingBuildTargets { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse202 {\n");
            sb.Append("  PollingBuildTargets: ").Append(PollingBuildTargets).Append("\n");
            
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
            return this.Equals(obj as InlineResponse202);
        }

        /// <summary>
        /// Returns true if InlineResponse202 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse202 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse202 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PollingBuildTargets == other.PollingBuildTargets ||
                    this.PollingBuildTargets != null &&
                    this.PollingBuildTargets.SequenceEqual(other.PollingBuildTargets)
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
                
                if (this.PollingBuildTargets != null)
                    hash = hash * 59 + this.PollingBuildTargets.GetHashCode();
                
                return hash;
            }
        }

    }
}

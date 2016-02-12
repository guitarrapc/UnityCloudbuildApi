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
    public partial class Options7 :  IEquatable<Options7>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Options7" /> class.
        /// </summary>
        public Options7()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Plan
        /// </summary>
        [DataMember(Name="plan", EmitDefaultValue=false)]
        public string Plan { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Options7 {\n");
            sb.Append("  Plan: ").Append(Plan).Append("\n");
            
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
            return this.Equals(obj as Options7);
        }

        /// <summary>
        /// Returns true if Options7 instances are equal
        /// </summary>
        /// <param name="other">Instance of Options7 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Options7 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Plan == other.Plan ||
                    this.Plan != null &&
                    this.Plan.Equals(other.Plan)
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
                
                if (this.Plan != null)
                    hash = hash * 59 + this.Plan.GetHashCode();
                
                return hash;
            }
        }

    }
}

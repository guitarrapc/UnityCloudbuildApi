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
    public partial class Options4 :  IEquatable<Options4>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Options4" /> class.
        /// </summary>
        public Options4()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Clean
        /// </summary>
        [DataMember(Name="clean", EmitDefaultValue=false)]
        public bool? Clean { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Delay
        /// </summary>
        [DataMember(Name="delay", EmitDefaultValue=false)]
        public double? Delay { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Options4 {\n");
            sb.Append("  Clean: ").Append(Clean).Append("\n");
            sb.Append("  Delay: ").Append(Delay).Append("\n");
            
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
            return this.Equals(obj as Options4);
        }

        /// <summary>
        /// Returns true if Options4 instances are equal
        /// </summary>
        /// <param name="other">Instance of Options4 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Options4 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Clean == other.Clean ||
                    this.Clean != null &&
                    this.Clean.Equals(other.Clean)
                ) && 
                (
                    this.Delay == other.Delay ||
                    this.Delay != null &&
                    this.Delay.Equals(other.Delay)
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
                
                if (this.Clean != null)
                    hash = hash * 59 + this.Clean.GetHashCode();
                
                if (this.Delay != null)
                    hash = hash * 59 + this.Delay.GetHashCode();
                
                return hash;
            }
        }

    }
}

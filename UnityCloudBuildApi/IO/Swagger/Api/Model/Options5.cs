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
    public partial class Options5 :  IEquatable<Options5>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Options5" /> class.
        /// </summary>
        public Options5()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Notify
        /// </summary>
        [DataMember(Name="notify", EmitDefaultValue=false)]
        public bool? Notify { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Options5 {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Notify: ").Append(Notify).Append("\n");
            
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
            return this.Equals(obj as Options5);
        }

        /// <summary>
        /// Returns true if Options5 instances are equal
        /// </summary>
        /// <param name="other">Instance of Options5 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Options5 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Notify == other.Notify ||
                    this.Notify != null &&
                    this.Notify.Equals(other.Notify)
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
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.Notify != null)
                    hash = hash * 59 + this.Notify.GetHashCode();
                
                return hash;
            }
        }

    }
}

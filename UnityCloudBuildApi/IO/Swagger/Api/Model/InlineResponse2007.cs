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
    public partial class InlineResponse2007 :  IEquatable<InlineResponse2007>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2007" /> class.
        /// </summary>
        public InlineResponse2007()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Publickey
        /// </summary>
        [DataMember(Name="publickey", EmitDefaultValue=false)]
        public string Publickey { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2007 {\n");
            sb.Append("  Publickey: ").Append(Publickey).Append("\n");
            
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
            return this.Equals(obj as InlineResponse2007);
        }

        /// <summary>
        /// Returns true if InlineResponse2007 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2007 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2007 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Publickey == other.Publickey ||
                    this.Publickey != null &&
                    this.Publickey.Equals(other.Publickey)
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
                
                if (this.Publickey != null)
                    hash = hash * 59 + this.Publickey.GetHashCode();
                
                return hash;
            }
        }

    }
}

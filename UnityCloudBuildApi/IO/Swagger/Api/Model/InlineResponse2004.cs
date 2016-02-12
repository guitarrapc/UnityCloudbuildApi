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
    public partial class InlineResponse2004 :  IEquatable<InlineResponse2004>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2004" /> class.
        /// </summary>
        public InlineResponse2004()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Shareid
        /// </summary>
        [DataMember(Name="shareid", EmitDefaultValue=false)]
        public string Shareid { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2004 {\n");
            sb.Append("  Shareid: ").Append(Shareid).Append("\n");
            
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
            return this.Equals(obj as InlineResponse2004);
        }

        /// <summary>
        /// Returns true if InlineResponse2004 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2004 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2004 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Shareid == other.Shareid ||
                    this.Shareid != null &&
                    this.Shareid.Equals(other.Shareid)
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
                
                if (this.Shareid != null)
                    hash = hash * 59 + this.Shareid.GetHashCode();
                
                return hash;
            }
        }

    }
}

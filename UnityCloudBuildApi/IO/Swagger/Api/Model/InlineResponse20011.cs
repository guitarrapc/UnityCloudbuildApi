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
    public partial class InlineResponse20011 :  IEquatable<InlineResponse20011>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20011" /> class.
        /// </summary>
        public InlineResponse20011()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets ApiKey
        /// </summary>
        [DataMember(Name="apiKey", EmitDefaultValue=false)]
        public string ApiKey { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20011 {\n");
            sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
            
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
            return this.Equals(obj as InlineResponse20011);
        }

        /// <summary>
        /// Returns true if InlineResponse20011 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse20011 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20011 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ApiKey == other.ApiKey ||
                    this.ApiKey != null &&
                    this.ApiKey.Equals(other.ApiKey)
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
                
                if (this.ApiKey != null)
                    hash = hash * 59 + this.ApiKey.GetHashCode();
                
                return hash;
            }
        }

    }
}

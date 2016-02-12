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
    public partial class Options8 :  IEquatable<Options8>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Options8" /> class.
        /// </summary>
        public Options8()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Udid
        /// </summary>
        [DataMember(Name="udid", EmitDefaultValue=false)]
        public string Udid { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Devicename
        /// </summary>
        [DataMember(Name="devicename", EmitDefaultValue=false)]
        public string Devicename { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Os
        /// </summary>
        [DataMember(Name="os", EmitDefaultValue=false)]
        public string Os { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Osversion
        /// </summary>
        [DataMember(Name="osversion", EmitDefaultValue=false)]
        public string Osversion { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Product
        /// </summary>
        [DataMember(Name="product", EmitDefaultValue=false)]
        public string Product { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Options8 {\n");
            sb.Append("  Udid: ").Append(Udid).Append("\n");
            sb.Append("  Devicename: ").Append(Devicename).Append("\n");
            sb.Append("  Os: ").Append(Os).Append("\n");
            sb.Append("  Osversion: ").Append(Osversion).Append("\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            
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
            return this.Equals(obj as Options8);
        }

        /// <summary>
        /// Returns true if Options8 instances are equal
        /// </summary>
        /// <param name="other">Instance of Options8 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Options8 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Udid == other.Udid ||
                    this.Udid != null &&
                    this.Udid.Equals(other.Udid)
                ) && 
                (
                    this.Devicename == other.Devicename ||
                    this.Devicename != null &&
                    this.Devicename.Equals(other.Devicename)
                ) && 
                (
                    this.Os == other.Os ||
                    this.Os != null &&
                    this.Os.Equals(other.Os)
                ) && 
                (
                    this.Osversion == other.Osversion ||
                    this.Osversion != null &&
                    this.Osversion.Equals(other.Osversion)
                ) && 
                (
                    this.Product == other.Product ||
                    this.Product != null &&
                    this.Product.Equals(other.Product)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                
                if (this.Udid != null)
                    hash = hash * 59 + this.Udid.GetHashCode();
                
                if (this.Devicename != null)
                    hash = hash * 59 + this.Devicename.GetHashCode();
                
                if (this.Os != null)
                    hash = hash * 59 + this.Os.GetHashCode();
                
                if (this.Osversion != null)
                    hash = hash * 59 + this.Osversion.GetHashCode();
                
                if (this.Product != null)
                    hash = hash * 59 + this.Product.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                return hash;
            }
        }

    }
}

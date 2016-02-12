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
    public partial class InlineResponse200 :  IEquatable<InlineResponse200>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse200" /> class.
        /// </summary>
        public InlineResponse200()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Effective
        /// </summary>
        [DataMember(Name="effective", EmitDefaultValue=false)]
        public InlineResponse200Effective Effective { get; set; }
  
        
        /// <summary>
        /// Gets or Sets BillingDetails
        /// </summary>
        [DataMember(Name="billingDetails", EmitDefaultValue=false)]
        public InlineResponse200BillingDetails BillingDetails { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Upgrade
        /// </summary>
        [DataMember(Name="upgrade", EmitDefaultValue=false)]
        public InlineResponse200Upgrade Upgrade { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Billing
        /// </summary>
        [DataMember(Name="billing", EmitDefaultValue=false)]
        public InlineResponse200Billing Billing { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse200 {\n");
            sb.Append("  Effective: ").Append(Effective).Append("\n");
            sb.Append("  BillingDetails: ").Append(BillingDetails).Append("\n");
            sb.Append("  Upgrade: ").Append(Upgrade).Append("\n");
            sb.Append("  Billing: ").Append(Billing).Append("\n");
            
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
            return this.Equals(obj as InlineResponse200);
        }

        /// <summary>
        /// Returns true if InlineResponse200 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse200 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse200 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Effective == other.Effective ||
                    this.Effective != null &&
                    this.Effective.Equals(other.Effective)
                ) && 
                (
                    this.BillingDetails == other.BillingDetails ||
                    this.BillingDetails != null &&
                    this.BillingDetails.Equals(other.BillingDetails)
                ) && 
                (
                    this.Upgrade == other.Upgrade ||
                    this.Upgrade != null &&
                    this.Upgrade.Equals(other.Upgrade)
                ) && 
                (
                    this.Billing == other.Billing ||
                    this.Billing != null &&
                    this.Billing.Equals(other.Billing)
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
                
                if (this.Effective != null)
                    hash = hash * 59 + this.Effective.GetHashCode();
                
                if (this.BillingDetails != null)
                    hash = hash * 59 + this.BillingDetails.GetHashCode();
                
                if (this.Upgrade != null)
                    hash = hash * 59 + this.Upgrade.GetHashCode();
                
                if (this.Billing != null)
                    hash = hash * 59 + this.Billing.GetHashCode();
                
                return hash;
            }
        }

    }
}

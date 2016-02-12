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
    public partial class InlineResponse200BillingDetails :  IEquatable<InlineResponse200BillingDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse200BillingDetails" /> class.
        /// </summary>
        public InlineResponse200BillingDetails()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="end_date", EmitDefaultValue=false)]
        public string EndDate { get; set; }
  
        
        /// <summary>
        /// Gets or Sets LastAmountPaid
        /// </summary>
        [DataMember(Name="last_amount_paid", EmitDefaultValue=false)]
        public double? LastAmountPaid { get; set; }
  
        
        /// <summary>
        /// Gets or Sets CurrentFeatureName
        /// </summary>
        [DataMember(Name="current_feature_name", EmitDefaultValue=false)]
        public string CurrentFeatureName { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }
  
        
        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        public string StartDate { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse200BillingDetails {\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  LastAmountPaid: ").Append(LastAmountPaid).Append("\n");
            sb.Append("  CurrentFeatureName: ").Append(CurrentFeatureName).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            
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
            return this.Equals(obj as InlineResponse200BillingDetails);
        }

        /// <summary>
        /// Returns true if InlineResponse200BillingDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse200BillingDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse200BillingDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
                ) && 
                (
                    this.LastAmountPaid == other.LastAmountPaid ||
                    this.LastAmountPaid != null &&
                    this.LastAmountPaid.Equals(other.LastAmountPaid)
                ) && 
                (
                    this.CurrentFeatureName == other.CurrentFeatureName ||
                    this.CurrentFeatureName != null &&
                    this.CurrentFeatureName.Equals(other.CurrentFeatureName)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) && 
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
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
                
                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();
                
                if (this.LastAmountPaid != null)
                    hash = hash * 59 + this.LastAmountPaid.GetHashCode();
                
                if (this.CurrentFeatureName != null)
                    hash = hash * 59 + this.CurrentFeatureName.GetHashCode();
                
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                
                return hash;
            }
        }

    }
}

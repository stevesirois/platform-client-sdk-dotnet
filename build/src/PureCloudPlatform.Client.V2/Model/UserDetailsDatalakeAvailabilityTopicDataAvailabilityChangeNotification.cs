using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// UserDetailsDatalakeAvailabilityTopicDataAvailabilityChangeNotification
    /// </summary>
    [DataContract]
    public partial class UserDetailsDatalakeAvailabilityTopicDataAvailabilityChangeNotification :  IEquatable<UserDetailsDatalakeAvailabilityTopicDataAvailabilityChangeNotification>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserDetailsDatalakeAvailabilityTopicDataAvailabilityChangeNotification" /> class.
        /// </summary>
        /// <param name="DataAvailabilityDate">DataAvailabilityDate.</param>
        public UserDetailsDatalakeAvailabilityTopicDataAvailabilityChangeNotification(UserDetailsDatalakeAvailabilityTopicDateTime DataAvailabilityDate = null)
        {
            this.DataAvailabilityDate = DataAvailabilityDate;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets DataAvailabilityDate
        /// </summary>
        [DataMember(Name="dataAvailabilityDate", EmitDefaultValue=false)]
        public UserDetailsDatalakeAvailabilityTopicDateTime DataAvailabilityDate { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserDetailsDatalakeAvailabilityTopicDataAvailabilityChangeNotification {\n");
            
            sb.Append("  DataAvailabilityDate: ").Append(DataAvailabilityDate).Append("\n");
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
            return this.Equals(obj as UserDetailsDatalakeAvailabilityTopicDataAvailabilityChangeNotification);
        }

        /// <summary>
        /// Returns true if UserDetailsDatalakeAvailabilityTopicDataAvailabilityChangeNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of UserDetailsDatalakeAvailabilityTopicDataAvailabilityChangeNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserDetailsDatalakeAvailabilityTopicDataAvailabilityChangeNotification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DataAvailabilityDate == other.DataAvailabilityDate ||
                    this.DataAvailabilityDate != null &&
                    this.DataAvailabilityDate.Equals(other.DataAvailabilityDate)
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
                
                if (this.DataAvailabilityDate != null)
                    hash = hash * 59 + this.DataAvailabilityDate.GetHashCode();
                
                return hash;
            }
        }
    }

}
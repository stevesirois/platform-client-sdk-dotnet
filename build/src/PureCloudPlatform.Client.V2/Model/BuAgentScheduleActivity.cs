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
    /// BuAgentScheduleActivity
    /// </summary>
    [DataContract]
    public partial class BuAgentScheduleActivity :  IEquatable<BuAgentScheduleActivity>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BuAgentScheduleActivity" /> class.
        /// </summary>
        /// <param name="StartDate">The start date/time of this activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="LengthMinutes">The length of this activity in minutes.</param>
        /// <param name="Description">The description of this activity.</param>
        /// <param name="ActivityCodeId">The ID of the activity code associated with this activity.</param>
        /// <param name="Paid">Whether this activity is paid.</param>
        /// <param name="TimeOffRequestId">The ID of the time off request associated with this activity, if applicable.</param>
        public BuAgentScheduleActivity(DateTime? StartDate = null, int? LengthMinutes = null, string Description = null, string ActivityCodeId = null, bool? Paid = null, string TimeOffRequestId = null)
        {
            this.StartDate = StartDate;
            this.LengthMinutes = LengthMinutes;
            this.Description = Description;
            this.ActivityCodeId = ActivityCodeId;
            this.Paid = Paid;
            this.TimeOffRequestId = TimeOffRequestId;
            
        }
        
        
        
        /// <summary>
        /// The start date/time of this activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The start date/time of this activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }
        
        
        
        /// <summary>
        /// The length of this activity in minutes
        /// </summary>
        /// <value>The length of this activity in minutes</value>
        [DataMember(Name="lengthMinutes", EmitDefaultValue=false)]
        public int? LengthMinutes { get; set; }
        
        
        
        /// <summary>
        /// The description of this activity
        /// </summary>
        /// <value>The description of this activity</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        /// <summary>
        /// The ID of the activity code associated with this activity
        /// </summary>
        /// <value>The ID of the activity code associated with this activity</value>
        [DataMember(Name="activityCodeId", EmitDefaultValue=false)]
        public string ActivityCodeId { get; set; }
        
        
        
        /// <summary>
        /// Whether this activity is paid
        /// </summary>
        /// <value>Whether this activity is paid</value>
        [DataMember(Name="paid", EmitDefaultValue=false)]
        public bool? Paid { get; set; }
        
        
        
        /// <summary>
        /// The ID of the time off request associated with this activity, if applicable
        /// </summary>
        /// <value>The ID of the time off request associated with this activity, if applicable</value>
        [DataMember(Name="timeOffRequestId", EmitDefaultValue=false)]
        public string TimeOffRequestId { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuAgentScheduleActivity {\n");
            
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  LengthMinutes: ").Append(LengthMinutes).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ActivityCodeId: ").Append(ActivityCodeId).Append("\n");
            sb.Append("  Paid: ").Append(Paid).Append("\n");
            sb.Append("  TimeOffRequestId: ").Append(TimeOffRequestId).Append("\n");
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
            return this.Equals(obj as BuAgentScheduleActivity);
        }

        /// <summary>
        /// Returns true if BuAgentScheduleActivity instances are equal
        /// </summary>
        /// <param name="other">Instance of BuAgentScheduleActivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuAgentScheduleActivity other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) &&
                (
                    this.LengthMinutes == other.LengthMinutes ||
                    this.LengthMinutes != null &&
                    this.LengthMinutes.Equals(other.LengthMinutes)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.ActivityCodeId == other.ActivityCodeId ||
                    this.ActivityCodeId != null &&
                    this.ActivityCodeId.Equals(other.ActivityCodeId)
                ) &&
                (
                    this.Paid == other.Paid ||
                    this.Paid != null &&
                    this.Paid.Equals(other.Paid)
                ) &&
                (
                    this.TimeOffRequestId == other.TimeOffRequestId ||
                    this.TimeOffRequestId != null &&
                    this.TimeOffRequestId.Equals(other.TimeOffRequestId)
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
                
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                
                if (this.LengthMinutes != null)
                    hash = hash * 59 + this.LengthMinutes.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.ActivityCodeId != null)
                    hash = hash * 59 + this.ActivityCodeId.GetHashCode();
                
                if (this.Paid != null)
                    hash = hash * 59 + this.Paid.GetHashCode();
                
                if (this.TimeOffRequestId != null)
                    hash = hash * 59 + this.TimeOffRequestId.GetHashCode();
                
                return hash;
            }
        }
    }

}
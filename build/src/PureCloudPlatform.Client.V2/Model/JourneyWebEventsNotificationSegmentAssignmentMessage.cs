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
    /// JourneyWebEventsNotificationSegmentAssignmentMessage
    /// </summary>
    [DataContract]
    public partial class JourneyWebEventsNotificationSegmentAssignmentMessage :  IEquatable<JourneyWebEventsNotificationSegmentAssignmentMessage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyWebEventsNotificationSegmentAssignmentMessage" /> class.
        /// </summary>
        /// <param name="Segment">Segment.</param>
        public JourneyWebEventsNotificationSegmentAssignmentMessage(JourneyWebEventsNotificationSegment Segment = null)
        {
            this.Segment = Segment;
            
        }
        


        /// <summary>
        /// Gets or Sets Segment
        /// </summary>
        [DataMember(Name="segment", EmitDefaultValue=false)]
        public JourneyWebEventsNotificationSegment Segment { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JourneyWebEventsNotificationSegmentAssignmentMessage {\n");

            sb.Append("  Segment: ").Append(Segment).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                Formatting = Formatting.Indented
            });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as JourneyWebEventsNotificationSegmentAssignmentMessage);
        }

        /// <summary>
        /// Returns true if JourneyWebEventsNotificationSegmentAssignmentMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of JourneyWebEventsNotificationSegmentAssignmentMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneyWebEventsNotificationSegmentAssignmentMessage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Segment == other.Segment ||
                    this.Segment != null &&
                    this.Segment.Equals(other.Segment)
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
                if (this.Segment != null)
                    hash = hash * 59 + this.Segment.GetHashCode();

                return hash;
            }
        }
    }

}
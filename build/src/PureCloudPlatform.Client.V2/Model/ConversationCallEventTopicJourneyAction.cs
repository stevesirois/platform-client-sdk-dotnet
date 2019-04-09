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
    /// ConversationCallEventTopicJourneyAction
    /// </summary>
    [DataContract]
    public partial class ConversationCallEventTopicJourneyAction :  IEquatable<ConversationCallEventTopicJourneyAction>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationCallEventTopicJourneyAction" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="ActionMap">ActionMap.</param>
        public ConversationCallEventTopicJourneyAction(string Id = null, ConversationCallEventTopicJourneyActionMap ActionMap = null)
        {
            this.Id = Id;
            this.ActionMap = ActionMap;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ActionMap
        /// </summary>
        [DataMember(Name="actionMap", EmitDefaultValue=false)]
        public ConversationCallEventTopicJourneyActionMap ActionMap { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationCallEventTopicJourneyAction {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ActionMap: ").Append(ActionMap).Append("\n");
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
            return this.Equals(obj as ConversationCallEventTopicJourneyAction);
        }

        /// <summary>
        /// Returns true if ConversationCallEventTopicJourneyAction instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationCallEventTopicJourneyAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationCallEventTopicJourneyAction other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.ActionMap == other.ActionMap ||
                    this.ActionMap != null &&
                    this.ActionMap.Equals(other.ActionMap)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.ActionMap != null)
                    hash = hash * 59 + this.ActionMap.GetHashCode();
                
                return hash;
            }
        }
    }

}
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
    /// GuestCategoryResponseListing
    /// </summary>
    [DataContract]
    public partial class GuestCategoryResponseListing :  IEquatable<GuestCategoryResponseListing>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GuestCategoryResponseListing" /> class.
        /// </summary>
        /// <param name="Entities">Entities.</param>
        /// <param name="NextUri">NextUri.</param>
        /// <param name="SelfUri">SelfUri.</param>
        /// <param name="PreviousUri">PreviousUri.</param>
        /// <param name="SessionId">SessionId.</param>
        public GuestCategoryResponseListing(List<GuestCategoryResponse> Entities = null, string NextUri = null, string SelfUri = null, string PreviousUri = null, string SessionId = null)
        {
            this.Entities = Entities;
            this.NextUri = NextUri;
            this.SelfUri = SelfUri;
            this.PreviousUri = PreviousUri;
            this.SessionId = SessionId;
            
        }
        


        /// <summary>
        /// Gets or Sets Entities
        /// </summary>
        [DataMember(Name="entities", EmitDefaultValue=false)]
        public List<GuestCategoryResponse> Entities { get; set; }



        /// <summary>
        /// Gets or Sets NextUri
        /// </summary>
        [DataMember(Name="nextUri", EmitDefaultValue=false)]
        public string NextUri { get; set; }



        /// <summary>
        /// Gets or Sets SelfUri
        /// </summary>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; set; }



        /// <summary>
        /// Gets or Sets PreviousUri
        /// </summary>
        [DataMember(Name="previousUri", EmitDefaultValue=false)]
        public string PreviousUri { get; set; }



        /// <summary>
        /// Gets or Sets SessionId
        /// </summary>
        [DataMember(Name="sessionId", EmitDefaultValue=false)]
        public string SessionId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GuestCategoryResponseListing {\n");

            sb.Append("  Entities: ").Append(Entities).Append("\n");
            sb.Append("  NextUri: ").Append(NextUri).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("  PreviousUri: ").Append(PreviousUri).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
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
            return this.Equals(obj as GuestCategoryResponseListing);
        }

        /// <summary>
        /// Returns true if GuestCategoryResponseListing instances are equal
        /// </summary>
        /// <param name="other">Instance of GuestCategoryResponseListing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GuestCategoryResponseListing other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Entities == other.Entities ||
                    this.Entities != null &&
                    this.Entities.SequenceEqual(other.Entities)
                ) &&
                (
                    this.NextUri == other.NextUri ||
                    this.NextUri != null &&
                    this.NextUri.Equals(other.NextUri)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                ) &&
                (
                    this.PreviousUri == other.PreviousUri ||
                    this.PreviousUri != null &&
                    this.PreviousUri.Equals(other.PreviousUri)
                ) &&
                (
                    this.SessionId == other.SessionId ||
                    this.SessionId != null &&
                    this.SessionId.Equals(other.SessionId)
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
                if (this.Entities != null)
                    hash = hash * 59 + this.Entities.GetHashCode();

                if (this.NextUri != null)
                    hash = hash * 59 + this.NextUri.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                if (this.PreviousUri != null)
                    hash = hash * 59 + this.PreviousUri.GetHashCode();

                if (this.SessionId != null)
                    hash = hash * 59 + this.SessionId.GetHashCode();

                return hash;
            }
        }
    }

}

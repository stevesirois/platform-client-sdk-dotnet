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
    /// ModelingProcessingError
    /// </summary>
    [DataContract]
    public partial class ModelingProcessingError :  IEquatable<ModelingProcessingError>
    {
        /// <summary>
        /// An internal code representing the type of error. ModelInputMissing for 'Model Builder inputs not found.' ModelInputInvalid for 'Model Builder inputs are invalid. Ensure the input data format is correct.' ModelFailed for 'An error occured while building the model with the given input.'
        /// </summary>
        /// <value>An internal code representing the type of error. ModelInputMissing for 'Model Builder inputs not found.' ModelInputInvalid for 'Model Builder inputs are invalid. Ensure the input data format is correct.' ModelFailed for 'An error occured while building the model with the given input.'</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum InternalErrorCodeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Modelinputmissing for "ModelInputMissing"
            /// </summary>
            [EnumMember(Value = "ModelInputMissing")]
            Modelinputmissing,
            
            /// <summary>
            /// Enum Modelinputinvalid for "ModelInputInvalid"
            /// </summary>
            [EnumMember(Value = "ModelInputInvalid")]
            Modelinputinvalid,
            
            /// <summary>
            /// Enum Modelfailed for "ModelFailed"
            /// </summary>
            [EnumMember(Value = "ModelFailed")]
            Modelfailed
        }
        /// <summary>
        /// An internal code representing the type of error. ModelInputMissing for 'Model Builder inputs not found.' ModelInputInvalid for 'Model Builder inputs are invalid. Ensure the input data format is correct.' ModelFailed for 'An error occured while building the model with the given input.'
        /// </summary>
        /// <value>An internal code representing the type of error. ModelInputMissing for 'Model Builder inputs not found.' ModelInputInvalid for 'Model Builder inputs are invalid. Ensure the input data format is correct.' ModelFailed for 'An error occured while building the model with the given input.'</value>
        [DataMember(Name="internalErrorCode", EmitDefaultValue=false)]
        public InternalErrorCodeEnum? InternalErrorCode { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelingProcessingError" /> class.
        /// </summary>
        public ModelingProcessingError()
        {
            
        }
        




        /// <summary>
        /// A text description of the error
        /// </summary>
        /// <value>A text description of the error</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelingProcessingError {\n");

            sb.Append("  InternalErrorCode: ").Append(InternalErrorCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(obj as ModelingProcessingError);
        }

        /// <summary>
        /// Returns true if ModelingProcessingError instances are equal
        /// </summary>
        /// <param name="other">Instance of ModelingProcessingError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelingProcessingError other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.InternalErrorCode == other.InternalErrorCode ||
                    this.InternalErrorCode != null &&
                    this.InternalErrorCode.Equals(other.InternalErrorCode)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
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
                if (this.InternalErrorCode != null)
                    hash = hash * 59 + this.InternalErrorCode.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                return hash;
            }
        }
    }

}

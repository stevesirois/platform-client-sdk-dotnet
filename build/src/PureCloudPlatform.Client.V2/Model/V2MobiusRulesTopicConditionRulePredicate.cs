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
    /// V2MobiusRulesTopicConditionRulePredicate
    /// </summary>
    [DataContract]
    public partial class V2MobiusRulesTopicConditionRulePredicate :  IEquatable<V2MobiusRulesTopicConditionRulePredicate>
    {
        /// <summary>
        /// Gets or Sets MetricType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MetricTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Interval for "Interval"
            /// </summary>
            [EnumMember(Value = "Interval")]
            Interval,
            
            /// <summary>
            /// Enum Instance for "Instance"
            /// </summary>
            [EnumMember(Value = "Instance")]
            Instance,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// Gets or Sets MetricValueType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MetricValueTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Count for "Count"
            /// </summary>
            [EnumMember(Value = "Count")]
            Count,
            
            /// <summary>
            /// Enum Percentage for "Percentage"
            /// </summary>
            [EnumMember(Value = "Percentage")]
            Percentage,
            
            /// <summary>
            /// Enum Average for "Average"
            /// </summary>
            [EnumMember(Value = "Average")]
            Average,
            
            /// <summary>
            /// Enum Timer for "Timer"
            /// </summary>
            [EnumMember(Value = "Timer")]
            Timer,
            
            /// <summary>
            /// Enum Observation for "Observation"
            /// </summary>
            [EnumMember(Value = "Observation")]
            Observation,
            
            /// <summary>
            /// Enum Min for "Min"
            /// </summary>
            [EnumMember(Value = "Min")]
            Min,
            
            /// <summary>
            /// Enum Max for "Max"
            /// </summary>
            [EnumMember(Value = "Max")]
            Max,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// Gets or Sets ComparisonOperator
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ComparisonOperatorEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Gt for "Gt"
            /// </summary>
            [EnumMember(Value = "Gt")]
            Gt,
            
            /// <summary>
            /// Enum Gte for "Gte"
            /// </summary>
            [EnumMember(Value = "Gte")]
            Gte,
            
            /// <summary>
            /// Enum Lt for "Lt"
            /// </summary>
            [EnumMember(Value = "Lt")]
            Lt,
            
            /// <summary>
            /// Enum Lte for "Lte"
            /// </summary>
            [EnumMember(Value = "Lte")]
            Lte,
            
            /// <summary>
            /// Enum Eq for "Eq"
            /// </summary>
            [EnumMember(Value = "Eq")]
            Eq,
            
            /// <summary>
            /// Enum Ne for "Ne"
            /// </summary>
            [EnumMember(Value = "Ne")]
            Ne,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// Gets or Sets MetricType
        /// </summary>
        [DataMember(Name="metricType", EmitDefaultValue=false)]
        public MetricTypeEnum? MetricType { get; set; }
        /// <summary>
        /// Gets or Sets MetricValueType
        /// </summary>
        [DataMember(Name="metricValueType", EmitDefaultValue=false)]
        public MetricValueTypeEnum? MetricValueType { get; set; }
        /// <summary>
        /// Gets or Sets ComparisonOperator
        /// </summary>
        [DataMember(Name="comparisonOperator", EmitDefaultValue=false)]
        public ComparisonOperatorEnum? ComparisonOperator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="V2MobiusRulesTopicConditionRulePredicate" /> class.
        /// </summary>
        /// <param name="Entity">Entity.</param>
        /// <param name="Metric">Metric.</param>
        /// <param name="MetricType">MetricType.</param>
        /// <param name="MetricValueType">MetricValueType.</param>
        /// <param name="Value">Value.</param>
        /// <param name="ComparisonOperator">ComparisonOperator.</param>
        public V2MobiusRulesTopicConditionRulePredicate(V2MobiusRulesTopicEntityProperties Entity = null, string Metric = null, MetricTypeEnum? MetricType = null, MetricValueTypeEnum? MetricValueType = null, double? Value = null, ComparisonOperatorEnum? ComparisonOperator = null)
        {
            this.Entity = Entity;
            this.Metric = Metric;
            this.MetricType = MetricType;
            this.MetricValueType = MetricValueType;
            this.Value = Value;
            this.ComparisonOperator = ComparisonOperator;
            
        }
        


        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public V2MobiusRulesTopicEntityProperties Entity { get; set; }



        /// <summary>
        /// Gets or Sets Metric
        /// </summary>
        [DataMember(Name="metric", EmitDefaultValue=false)]
        public string Metric { get; set; }







        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public double? Value { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2MobiusRulesTopicConditionRulePredicate {\n");

            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  Metric: ").Append(Metric).Append("\n");
            sb.Append("  MetricType: ").Append(MetricType).Append("\n");
            sb.Append("  MetricValueType: ").Append(MetricValueType).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  ComparisonOperator: ").Append(ComparisonOperator).Append("\n");
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
            return this.Equals(obj as V2MobiusRulesTopicConditionRulePredicate);
        }

        /// <summary>
        /// Returns true if V2MobiusRulesTopicConditionRulePredicate instances are equal
        /// </summary>
        /// <param name="other">Instance of V2MobiusRulesTopicConditionRulePredicate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2MobiusRulesTopicConditionRulePredicate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Entity == other.Entity ||
                    this.Entity != null &&
                    this.Entity.Equals(other.Entity)
                ) &&
                (
                    this.Metric == other.Metric ||
                    this.Metric != null &&
                    this.Metric.Equals(other.Metric)
                ) &&
                (
                    this.MetricType == other.MetricType ||
                    this.MetricType != null &&
                    this.MetricType.Equals(other.MetricType)
                ) &&
                (
                    this.MetricValueType == other.MetricValueType ||
                    this.MetricValueType != null &&
                    this.MetricValueType.Equals(other.MetricValueType)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.ComparisonOperator == other.ComparisonOperator ||
                    this.ComparisonOperator != null &&
                    this.ComparisonOperator.Equals(other.ComparisonOperator)
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
                if (this.Entity != null)
                    hash = hash * 59 + this.Entity.GetHashCode();

                if (this.Metric != null)
                    hash = hash * 59 + this.Metric.GetHashCode();

                if (this.MetricType != null)
                    hash = hash * 59 + this.MetricType.GetHashCode();

                if (this.MetricValueType != null)
                    hash = hash * 59 + this.MetricValueType.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                if (this.ComparisonOperator != null)
                    hash = hash * 59 + this.ComparisonOperator.GetHashCode();

                return hash;
            }
        }
    }

}

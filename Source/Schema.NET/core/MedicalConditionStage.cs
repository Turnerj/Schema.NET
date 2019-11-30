namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A stage of a medical condition, such as 'Stage IIIa'.
    /// </summary>
    public partial interface IMedicalConditionStage : IMedicalIntangible
    {
        /// <summary>
        /// The stage represented as a number, e.g. 3.
        /// </summary>
        OneOrMany<double?> StageAsNumber { get; set; }

        /// <summary>
        /// The substage, e.g. 'a' for Stage IIIa.
        /// </summary>
        OneOrMany<string> SubStageSuffix { get; set; }
    }

    /// <summary>
    /// A stage of a medical condition, such as 'Stage IIIa'.
    /// </summary>
    public partial class MedicalConditionStage : MedicalIntangible, IMedicalConditionStage
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "MedicalConditionStage";

        /// <summary>
        /// The stage represented as a number, e.g. 3.
        /// </summary>
        [JsonPropertyName("stageAsNumber")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<double?> StageAsNumber { get; set; }

        /// <summary>
        /// The substage, e.g. 'a' for Stage IIIa.
        /// </summary>
        [JsonPropertyName("subStageSuffix")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> SubStageSuffix { get; set; }
    }
}

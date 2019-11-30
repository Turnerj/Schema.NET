namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A common pathway for the electrochemical nerve impulses that are transmitted along each of the axons.
    /// </summary>
    public partial interface INerve : IAnatomicalStructure
    {
        /// <summary>
        /// The neurological pathway extension that involves muscle control.
        /// </summary>
        OneOrMany<IMuscle> NerveMotor { get; set; }

        /// <summary>
        /// The neurological pathway extension that inputs and sends information to the brain or spinal cord.
        /// </summary>
        Values<IAnatomicalStructure, ISuperficialAnatomy> SensoryUnit { get; set; }

        /// <summary>
        /// The neurological pathway that originates the neurons.
        /// </summary>
        OneOrMany<IBrainStructure> SourcedFrom { get; set; }
    }

    /// <summary>
    /// A common pathway for the electrochemical nerve impulses that are transmitted along each of the axons.
    /// </summary>
    public partial class Nerve : AnatomicalStructure, INerve
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Nerve";

        /// <summary>
        /// The neurological pathway extension that involves muscle control.
        /// </summary>
        [JsonPropertyName("nerveMotor")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMuscle> NerveMotor { get; set; }

        /// <summary>
        /// The neurological pathway extension that inputs and sends information to the brain or spinal cord.
        /// </summary>
        [JsonPropertyName("sensoryUnit")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IAnatomicalStructure, ISuperficialAnatomy> SensoryUnit { get; set; }

        /// <summary>
        /// The neurological pathway that originates the neurons.
        /// </summary>
        [JsonPropertyName("sourcedFrom")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IBrainStructure> SourcedFrom { get; set; }
    }
}

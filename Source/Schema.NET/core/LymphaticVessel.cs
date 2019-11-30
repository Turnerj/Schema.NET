namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A type of blood vessel that specifically carries lymph fluid unidirectionally toward the heart.
    /// </summary>
    public partial interface ILymphaticVessel : IVessel
    {
        /// <summary>
        /// The vasculature the lymphatic structure originates, or afferents, from.
        /// </summary>
        OneOrMany<IVessel> OriginatesFrom { get; set; }

        /// <summary>
        /// The anatomical or organ system drained by this vessel; generally refers to a specific part of an organ.
        /// </summary>
        Values<IAnatomicalStructure, IAnatomicalSystem> RegionDrained { get; set; }

        /// <summary>
        /// The vasculature the lymphatic structure runs, or efferents, to.
        /// </summary>
        OneOrMany<IVessel> RunsTo { get; set; }
    }

    /// <summary>
    /// A type of blood vessel that specifically carries lymph fluid unidirectionally toward the heart.
    /// </summary>
    public partial class LymphaticVessel : Vessel, ILymphaticVessel
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "LymphaticVessel";

        /// <summary>
        /// The vasculature the lymphatic structure originates, or afferents, from.
        /// </summary>
        [JsonPropertyName("originatesFrom")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IVessel> OriginatesFrom { get; set; }

        /// <summary>
        /// The anatomical or organ system drained by this vessel; generally refers to a specific part of an organ.
        /// </summary>
        [JsonPropertyName("regionDrained")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IAnatomicalStructure, IAnatomicalSystem> RegionDrained { get; set; }

        /// <summary>
        /// The vasculature the lymphatic structure runs, or efferents, to.
        /// </summary>
        [JsonPropertyName("runsTo")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IVessel> RunsTo { get; set; }
    }
}

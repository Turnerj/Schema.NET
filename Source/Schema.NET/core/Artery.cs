namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A type of blood vessel that specifically carries blood away from the heart.
    /// </summary>
    public partial interface IArtery : IVessel
    {
        /// <summary>
        /// The branches that comprise the arterial structure.
        /// </summary>
        OneOrMany<IAnatomicalStructure> ArterialBranch { get; set; }

        /// <summary>
        /// The anatomical or organ system that the artery originates from.
        /// </summary>
        OneOrMany<IAnatomicalStructure> Source { get; set; }

        /// <summary>
        /// The area to which the artery supplies blood.
        /// </summary>
        OneOrMany<IAnatomicalStructure> SupplyTo { get; set; }
    }

    /// <summary>
    /// A type of blood vessel that specifically carries blood away from the heart.
    /// </summary>
    public partial class Artery : Vessel, IArtery
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Artery";

        /// <summary>
        /// The branches that comprise the arterial structure.
        /// </summary>
        [JsonPropertyName("arterialBranch")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAnatomicalStructure> ArterialBranch { get; set; }

        /// <summary>
        /// The anatomical or organ system that the artery originates from.
        /// </summary>
        [JsonPropertyName("source")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAnatomicalStructure> Source { get; set; }

        /// <summary>
        /// The area to which the artery supplies blood.
        /// </summary>
        [JsonPropertyName("supplyTo")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAnatomicalStructure> SupplyTo { get; set; }
    }
}

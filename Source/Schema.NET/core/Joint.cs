namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The anatomical location at which two or more bones make contact.
    /// </summary>
    public partial interface IJoint : IAnatomicalStructure
    {
        /// <summary>
        /// The biomechanical properties of the bone.
        /// </summary>
        OneOrMany<string> BiomechnicalClass { get; set; }

        /// <summary>
        /// The degree of mobility the joint allows.
        /// </summary>
        Values<IMedicalEntity, string> FunctionalClass { get; set; }

        /// <summary>
        /// The name given to how bone physically connects to each other.
        /// </summary>
        OneOrMany<string> StructuralClass { get; set; }
    }

    /// <summary>
    /// The anatomical location at which two or more bones make contact.
    /// </summary>
    public partial class Joint : AnatomicalStructure, IJoint
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Joint";

        /// <summary>
        /// The biomechanical properties of the bone.
        /// </summary>
        [JsonPropertyName("biomechnicalClass")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> BiomechnicalClass { get; set; }

        /// <summary>
        /// The degree of mobility the joint allows.
        /// </summary>
        [JsonPropertyName("functionalClass")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMedicalEntity, string> FunctionalClass { get; set; }

        /// <summary>
        /// The name given to how bone physically connects to each other.
        /// </summary>
        [JsonPropertyName("structuralClass")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> StructuralClass { get; set; }
    }
}

namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An infectious disease is a clinically evident human disease resulting from the presence of pathogenic microbial agents, like pathogenic viruses, pathogenic bacteria, fungi, protozoa, multicellular parasites, and prions. To be considered an infectious disease, such pathogens are known to be able to cause this disease.
    /// </summary>
    public partial interface IInfectiousDisease : IMedicalCondition
    {
        /// <summary>
        /// The actual infectious agent, such as a specific bacterium.
        /// </summary>
        OneOrMany<string> InfectiousAgent { get; set; }

        /// <summary>
        /// The class of infectious agent (bacteria, prion, etc.) that causes the disease.
        /// </summary>
        OneOrMany<InfectiousAgentClass?> InfectiousAgentClass { get; set; }

        /// <summary>
        /// How the disease spreads, either as a route or vector, for example 'direct contact', 'Aedes aegypti', etc.
        /// </summary>
        OneOrMany<string> TransmissionMethod { get; set; }
    }

    /// <summary>
    /// An infectious disease is a clinically evident human disease resulting from the presence of pathogenic microbial agents, like pathogenic viruses, pathogenic bacteria, fungi, protozoa, multicellular parasites, and prions. To be considered an infectious disease, such pathogens are known to be able to cause this disease.
    /// </summary>
    public partial class InfectiousDisease : MedicalCondition, IInfectiousDisease
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "InfectiousDisease";

        /// <summary>
        /// The actual infectious agent, such as a specific bacterium.
        /// </summary>
        [JsonPropertyName("infectiousAgent")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> InfectiousAgent { get; set; }

        /// <summary>
        /// The class of infectious agent (bacteria, prion, etc.) that causes the disease.
        /// </summary>
        [JsonPropertyName("infectiousAgentClass")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<InfectiousAgentClass?> InfectiousAgentClass { get; set; }

        /// <summary>
        /// How the disease spreads, either as a route or vector, for example 'direct contact', 'Aedes aegypti', etc.
        /// </summary>
        [JsonPropertyName("transmissionMethod")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> TransmissionMethod { get; set; }
    }
}

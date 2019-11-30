namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Aquarium.
    /// </summary>
    public partial interface IAquarium : ICivicStructure
    {
    }

    /// <summary>
    /// Aquarium.
    /// </summary>
    public partial class Aquarium : CivicStructure, IAquarium
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Aquarium";
    }
}

namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A playground.
    /// </summary>
    public partial interface IPlayground : ICivicStructure
    {
    }

    /// <summary>
    /// A playground.
    /// </summary>
    public partial class Playground : CivicStructure, IPlayground
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Playground";
    }
}

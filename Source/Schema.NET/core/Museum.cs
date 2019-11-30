namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A museum.
    /// </summary>
    public partial interface IMuseum : ICivicStructure
    {
    }

    /// <summary>
    /// A museum.
    /// </summary>
    public partial class Museum : CivicStructure, IMuseum
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Museum";
    }
}

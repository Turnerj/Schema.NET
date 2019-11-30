namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A zoo.
    /// </summary>
    public partial interface IZoo : ICivicStructure
    {
    }

    /// <summary>
    /// A zoo.
    /// </summary>
    public partial class Zoo : CivicStructure, IZoo
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Zoo";
    }
}

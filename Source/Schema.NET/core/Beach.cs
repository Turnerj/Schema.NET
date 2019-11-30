namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Beach.
    /// </summary>
    public partial interface IBeach : ICivicStructure
    {
    }

    /// <summary>
    /// Beach.
    /// </summary>
    public partial class Beach : CivicStructure, IBeach
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Beach";
    }
}

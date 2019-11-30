namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A bridge.
    /// </summary>
    public partial interface IBridge : ICivicStructure
    {
    }

    /// <summary>
    /// A bridge.
    /// </summary>
    public partial class Bridge : CivicStructure, IBridge
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Bridge";
    }
}

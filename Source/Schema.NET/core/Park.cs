namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A park.
    /// </summary>
    public partial interface IPark : ICivicStructure
    {
    }

    /// <summary>
    /// A park.
    /// </summary>
    public partial class Park : CivicStructure, IPark
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Park";
    }
}

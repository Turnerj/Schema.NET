namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A graveyard.
    /// </summary>
    public partial interface ICemetery : ICivicStructure
    {
    }

    /// <summary>
    /// A graveyard.
    /// </summary>
    public partial class Cemetery : CivicStructure, ICemetery
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Cemetery";
    }
}

namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A subway station.
    /// </summary>
    public partial interface ISubwayStation : ICivicStructure
    {
    }

    /// <summary>
    /// A subway station.
    /// </summary>
    public partial class SubwayStation : CivicStructure, ISubwayStation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "SubwayStation";
    }
}

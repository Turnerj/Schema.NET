namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A bus station.
    /// </summary>
    public partial interface IBusStation : ICivicStructure
    {
    }

    /// <summary>
    /// A bus station.
    /// </summary>
    public partial class BusStation : CivicStructure, IBusStation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "BusStation";
    }
}

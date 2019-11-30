namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A bus stop.
    /// </summary>
    public partial interface IBusStop : ICivicStructure
    {
    }

    /// <summary>
    /// A bus stop.
    /// </summary>
    public partial class BusStop : CivicStructure, IBusStop
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "BusStop";
    }
}

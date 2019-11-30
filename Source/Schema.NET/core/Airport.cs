namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An airport.
    /// </summary>
    public partial interface IAirport : ICivicStructure
    {
        /// <summary>
        /// IATA identifier for an airline or airport.
        /// </summary>
        OneOrMany<string> IataCode { get; set; }

        /// <summary>
        /// ICAO identifier for an airport.
        /// </summary>
        OneOrMany<string> IcaoCode { get; set; }
    }

    /// <summary>
    /// An airport.
    /// </summary>
    public partial class Airport : CivicStructure, IAirport
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Airport";

        /// <summary>
        /// IATA identifier for an airline or airport.
        /// </summary>
        [JsonPropertyName("iataCode")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> IataCode { get; set; }

        /// <summary>
        /// ICAO identifier for an airport.
        /// </summary>
        [JsonPropertyName("icaoCode")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> IcaoCode { get; set; }
    }
}

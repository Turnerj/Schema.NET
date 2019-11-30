namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An organization that provides flights for passengers.
    /// </summary>
    public partial interface IAirline : IOrganization
    {
        /// <summary>
        /// The type of boarding policy used by the airline (e.g. zone-based or group-based).
        /// </summary>
        OneOrMany<BoardingPolicyType?> BoardingPolicy { get; set; }

        /// <summary>
        /// IATA identifier for an airline or airport.
        /// </summary>
        OneOrMany<string> IataCode { get; set; }
    }

    /// <summary>
    /// An organization that provides flights for passengers.
    /// </summary>
    public partial class Airline : Organization, IAirline
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Airline";

        /// <summary>
        /// The type of boarding policy used by the airline (e.g. zone-based or group-based).
        /// </summary>
        [JsonPropertyName("boardingPolicy")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<BoardingPolicyType?> BoardingPolicy { get; set; }

        /// <summary>
        /// IATA identifier for an airline or airport.
        /// </summary>
        [JsonPropertyName("iataCode")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> IataCode { get; set; }
    }
}

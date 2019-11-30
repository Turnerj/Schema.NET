namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Event type: Sports event.
    /// </summary>
    public partial interface ISportsEvent : IEvent
    {
        /// <summary>
        /// The away team in a sports event.
        /// </summary>
        Values<IPerson, ISportsTeam> AwayTeam { get; set; }

        /// <summary>
        /// A competitor in a sports event.
        /// </summary>
        Values<IPerson, ISportsTeam> Competitor { get; set; }

        /// <summary>
        /// The home team in a sports event.
        /// </summary>
        Values<IPerson, ISportsTeam> HomeTeam { get; set; }
    }

    /// <summary>
    /// Event type: Sports event.
    /// </summary>
    public partial class SportsEvent : Event, ISportsEvent
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "SportsEvent";

        /// <summary>
        /// The away team in a sports event.
        /// </summary>
        [JsonPropertyName("awayTeam")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IPerson, ISportsTeam> AwayTeam { get; set; }

        /// <summary>
        /// A competitor in a sports event.
        /// </summary>
        [JsonPropertyName("competitor")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IPerson, ISportsTeam> Competitor { get; set; }

        /// <summary>
        /// The home team in a sports event.
        /// </summary>
        [JsonPropertyName("homeTeam")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IPerson, ISportsTeam> HomeTeam { get; set; }
    }
}

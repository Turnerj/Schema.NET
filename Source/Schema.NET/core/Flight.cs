namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An airline flight.
    /// </summary>
    public partial interface IFlight : ITrip
    {
        /// <summary>
        /// The kind of aircraft (e.g., "Boeing 747").
        /// </summary>
        Values<string, IVehicle> Aircraft { get; set; }

        /// <summary>
        /// The airport where the flight terminates.
        /// </summary>
        OneOrMany<IAirport> ArrivalAirport { get; set; }

        /// <summary>
        /// Identifier of the flight's arrival gate.
        /// </summary>
        OneOrMany<string> ArrivalGate { get; set; }

        /// <summary>
        /// Identifier of the flight's arrival terminal.
        /// </summary>
        OneOrMany<string> ArrivalTerminal { get; set; }

        /// <summary>
        /// The type of boarding policy used by the airline (e.g. zone-based or group-based).
        /// </summary>
        OneOrMany<BoardingPolicyType?> BoardingPolicy { get; set; }

        /// <summary>
        /// The airport where the flight originates.
        /// </summary>
        OneOrMany<IAirport> DepartureAirport { get; set; }

        /// <summary>
        /// Identifier of the flight's departure gate.
        /// </summary>
        OneOrMany<string> DepartureGate { get; set; }

        /// <summary>
        /// Identifier of the flight's departure terminal.
        /// </summary>
        OneOrMany<string> DepartureTerminal { get; set; }

        /// <summary>
        /// The estimated time the flight will take.
        /// </summary>
        Values<TimeSpan?, string> EstimatedFlightDuration { get; set; }

        /// <summary>
        /// The distance of the flight.
        /// </summary>
        Values<string, string> FlightDistance { get; set; }

        /// <summary>
        /// The unique identifier for a flight including the airline IATA code. For example, if describing United flight 110, where the IATA code for United is 'UA', the flightNumber is 'UA110'.
        /// </summary>
        OneOrMany<string> FlightNumber { get; set; }

        /// <summary>
        /// Description of the meals that will be provided or available for purchase.
        /// </summary>
        OneOrMany<string> MealService { get; set; }

        /// <summary>
        /// An entity which offers (sells / leases / lends / loans) the services / goods.  A seller may also be a provider.
        /// </summary>
        Values<IOrganization, IPerson> Seller { get; set; }

        /// <summary>
        /// The time when a passenger can check into the flight online.
        /// </summary>
        OneOrMany<DateTimeOffset?> WebCheckinTime { get; set; }
    }

    /// <summary>
    /// An airline flight.
    /// </summary>
    public partial class Flight : Trip, IFlight
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Flight";

        /// <summary>
        /// The kind of aircraft (e.g., "Boeing 747").
        /// </summary>
        [JsonPropertyName("aircraft")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, IVehicle> Aircraft { get; set; }

        /// <summary>
        /// The airport where the flight terminates.
        /// </summary>
        [JsonPropertyName("arrivalAirport")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAirport> ArrivalAirport { get; set; }

        /// <summary>
        /// Identifier of the flight's arrival gate.
        /// </summary>
        [JsonPropertyName("arrivalGate")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ArrivalGate { get; set; }

        /// <summary>
        /// Identifier of the flight's arrival terminal.
        /// </summary>
        [JsonPropertyName("arrivalTerminal")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ArrivalTerminal { get; set; }

        /// <summary>
        /// The type of boarding policy used by the airline (e.g. zone-based or group-based).
        /// </summary>
        [JsonPropertyName("boardingPolicy")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<BoardingPolicyType?> BoardingPolicy { get; set; }

        /// <summary>
        /// The airport where the flight originates.
        /// </summary>
        [JsonPropertyName("departureAirport")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAirport> DepartureAirport { get; set; }

        /// <summary>
        /// Identifier of the flight's departure gate.
        /// </summary>
        [JsonPropertyName("departureGate")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> DepartureGate { get; set; }

        /// <summary>
        /// Identifier of the flight's departure terminal.
        /// </summary>
        [JsonPropertyName("departureTerminal")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> DepartureTerminal { get; set; }

        /// <summary>
        /// The estimated time the flight will take.
        /// </summary>
        [JsonPropertyName("estimatedFlightDuration")]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesJsonConverter))]
        public Values<TimeSpan?, string> EstimatedFlightDuration { get; set; }

        /// <summary>
        /// The distance of the flight.
        /// </summary>
        [JsonPropertyName("flightDistance")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, string> FlightDistance { get; set; }

        /// <summary>
        /// The unique identifier for a flight including the airline IATA code. For example, if describing United flight 110, where the IATA code for United is 'UA', the flightNumber is 'UA110'.
        /// </summary>
        [JsonPropertyName("flightNumber")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> FlightNumber { get; set; }

        /// <summary>
        /// Description of the meals that will be provided or available for purchase.
        /// </summary>
        [JsonPropertyName("mealService")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> MealService { get; set; }

        /// <summary>
        /// An entity which offers (sells / leases / lends / loans) the services / goods.  A seller may also be a provider.
        /// </summary>
        [JsonPropertyName("seller")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Seller { get; set; }

        /// <summary>
        /// The time when a passenger can check into the flight online.
        /// </summary>
        [JsonPropertyName("webCheckinTime")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DateTimeOffset?> WebCheckinTime { get; set; }
    }
}

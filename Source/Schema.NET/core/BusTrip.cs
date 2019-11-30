namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A trip on a commercial bus line.
    /// </summary>
    public partial interface IBusTrip : ITrip
    {
        /// <summary>
        /// The stop or station from which the bus arrives.
        /// </summary>
        Values<IBusStation, IBusStop> ArrivalBusStop { get; set; }

        /// <summary>
        /// The name of the bus (e.g. Bolt Express).
        /// </summary>
        OneOrMany<string> BusName { get; set; }

        /// <summary>
        /// The unique identifier for the bus.
        /// </summary>
        OneOrMany<string> BusNumber { get; set; }

        /// <summary>
        /// The stop or station from which the bus departs.
        /// </summary>
        Values<IBusStation, IBusStop> DepartureBusStop { get; set; }
    }

    /// <summary>
    /// A trip on a commercial bus line.
    /// </summary>
    public partial class BusTrip : Trip, IBusTrip
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "BusTrip";

        /// <summary>
        /// The stop or station from which the bus arrives.
        /// </summary>
        [JsonPropertyName("arrivalBusStop")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IBusStation, IBusStop> ArrivalBusStop { get; set; }

        /// <summary>
        /// The name of the bus (e.g. Bolt Express).
        /// </summary>
        [JsonPropertyName("busName")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> BusName { get; set; }

        /// <summary>
        /// The unique identifier for the bus.
        /// </summary>
        [JsonPropertyName("busNumber")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> BusNumber { get; set; }

        /// <summary>
        /// The stop or station from which the bus departs.
        /// </summary>
        [JsonPropertyName("departureBusStop")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IBusStation, IBusStop> DepartureBusStop { get; set; }
    }
}

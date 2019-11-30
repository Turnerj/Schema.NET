namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A trip on a commercial train line.
    /// </summary>
    public partial interface ITrainTrip : ITrip
    {
        /// <summary>
        /// The platform where the train arrives.
        /// </summary>
        OneOrMany<string> ArrivalPlatform { get; set; }

        /// <summary>
        /// The station where the train trip ends.
        /// </summary>
        OneOrMany<ITrainStation> ArrivalStation { get; set; }

        /// <summary>
        /// The platform from which the train departs.
        /// </summary>
        OneOrMany<string> DeparturePlatform { get; set; }

        /// <summary>
        /// The station from which the train departs.
        /// </summary>
        OneOrMany<ITrainStation> DepartureStation { get; set; }

        /// <summary>
        /// The name of the train (e.g. The Orient Express).
        /// </summary>
        OneOrMany<string> TrainName { get; set; }

        /// <summary>
        /// The unique identifier for the train.
        /// </summary>
        OneOrMany<string> TrainNumber { get; set; }
    }

    /// <summary>
    /// A trip on a commercial train line.
    /// </summary>
    public partial class TrainTrip : Trip, ITrainTrip
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "TrainTrip";

        /// <summary>
        /// The platform where the train arrives.
        /// </summary>
        [JsonPropertyName("arrivalPlatform")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ArrivalPlatform { get; set; }

        /// <summary>
        /// The station where the train trip ends.
        /// </summary>
        [JsonPropertyName("arrivalStation")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ITrainStation> ArrivalStation { get; set; }

        /// <summary>
        /// The platform from which the train departs.
        /// </summary>
        [JsonPropertyName("departurePlatform")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> DeparturePlatform { get; set; }

        /// <summary>
        /// The station from which the train departs.
        /// </summary>
        [JsonPropertyName("departureStation")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ITrainStation> DepartureStation { get; set; }

        /// <summary>
        /// The name of the train (e.g. The Orient Express).
        /// </summary>
        [JsonPropertyName("trainName")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> TrainName { get; set; }

        /// <summary>
        /// The unique identifier for the train.
        /// </summary>
        [JsonPropertyName("trainNumber")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> TrainNumber { get; set; }
    }
}

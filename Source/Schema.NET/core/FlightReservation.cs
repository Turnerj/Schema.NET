namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A reservation for air travel.&lt;br/&gt;&lt;br/&gt;
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use &lt;a class="localLink" href="http://schema.org/Offer"&gt;Offer&lt;/a&gt;.
    /// </summary>
    public partial interface IFlightReservation : IReservation
    {
        /// <summary>
        /// The airline-specific indicator of boarding order / preference.
        /// </summary>
        OneOrMany<string> BoardingGroup { get; set; }

        /// <summary>
        /// The priority status assigned to a passenger for security or boarding (e.g. FastTrack or Priority).
        /// </summary>
        OneOrMany<string> PassengerPriorityStatus { get; set; }

        /// <summary>
        /// The passenger's sequence number as assigned by the airline.
        /// </summary>
        OneOrMany<string> PassengerSequenceNumber { get; set; }

        /// <summary>
        /// The type of security screening the passenger is subject to.
        /// </summary>
        OneOrMany<string> SecurityScreening { get; set; }
    }

    /// <summary>
    /// A reservation for air travel.&lt;br/&gt;&lt;br/&gt;
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use &lt;a class="localLink" href="http://schema.org/Offer"&gt;Offer&lt;/a&gt;.
    /// </summary>
    public partial class FlightReservation : Reservation, IFlightReservation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "FlightReservation";

        /// <summary>
        /// The airline-specific indicator of boarding order / preference.
        /// </summary>
        [JsonPropertyName("boardingGroup")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> BoardingGroup { get; set; }

        /// <summary>
        /// The priority status assigned to a passenger for security or boarding (e.g. FastTrack or Priority).
        /// </summary>
        [JsonPropertyName("passengerPriorityStatus")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> PassengerPriorityStatus { get; set; }

        /// <summary>
        /// The passenger's sequence number as assigned by the airline.
        /// </summary>
        [JsonPropertyName("passengerSequenceNumber")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> PassengerSequenceNumber { get; set; }

        /// <summary>
        /// The type of security screening the passenger is subject to.
        /// </summary>
        [JsonPropertyName("securityScreening")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> SecurityScreening { get; set; }
    }
}

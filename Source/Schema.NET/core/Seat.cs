namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Used to describe a seat, such as a reserved seat in an event reservation.
    /// </summary>
    public partial interface ISeat : IIntangible
    {
        /// <summary>
        /// The type/class of the seat.
        /// </summary>
        OneOrMany<string> SeatingType { get; set; }

        /// <summary>
        /// The location of the reserved seat (e.g., 27).
        /// </summary>
        OneOrMany<string> SeatNumber { get; set; }

        /// <summary>
        /// The row location of the reserved seat (e.g., B).
        /// </summary>
        OneOrMany<string> SeatRow { get; set; }

        /// <summary>
        /// The section location of the reserved seat (e.g. Orchestra).
        /// </summary>
        OneOrMany<string> SeatSection { get; set; }
    }

    /// <summary>
    /// Used to describe a seat, such as a reserved seat in an event reservation.
    /// </summary>
    public partial class Seat : Intangible, ISeat
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Seat";

        /// <summary>
        /// The type/class of the seat.
        /// </summary>
        [JsonPropertyName("seatingType")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> SeatingType { get; set; }

        /// <summary>
        /// The location of the reserved seat (e.g., 27).
        /// </summary>
        [JsonPropertyName("seatNumber")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> SeatNumber { get; set; }

        /// <summary>
        /// The row location of the reserved seat (e.g., B).
        /// </summary>
        [JsonPropertyName("seatRow")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> SeatRow { get; set; }

        /// <summary>
        /// The section location of the reserved seat (e.g. Orchestra).
        /// </summary>
        [JsonPropertyName("seatSection")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> SeatSection { get; set; }
    }
}

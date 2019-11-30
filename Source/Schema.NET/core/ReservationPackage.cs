namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A group of multiple reservations with common values for all sub-reservations.
    /// </summary>
    public partial interface IReservationPackage : IReservation
    {
        /// <summary>
        /// The individual reservations included in the package. Typically a repeated property.
        /// </summary>
        OneOrMany<IReservation> SubReservation { get; set; }
    }

    /// <summary>
    /// A group of multiple reservations with common values for all sub-reservations.
    /// </summary>
    public partial class ReservationPackage : Reservation, IReservationPackage
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ReservationPackage";

        /// <summary>
        /// The individual reservations included in the package. Typically a repeated property.
        /// </summary>
        [JsonPropertyName("subReservation")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IReservation> SubReservation { get; set; }
    }
}

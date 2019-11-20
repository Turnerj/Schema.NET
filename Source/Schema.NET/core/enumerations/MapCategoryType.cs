namespace Schema.NET
{
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;


    /// <summary>
    /// An enumeration of several kinds of Map.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MapCategoryType
    {
        /// <summary>
        /// A parking map.
        /// </summary>
        [EnumMember(Value = "https://schema.org/ParkingMap")]
        ParkingMap,

        /// <summary>
        /// A seating map.
        /// </summary>
        [EnumMember(Value = "https://schema.org/SeatingMap")]
        SeatingMap,

        /// <summary>
        /// A transit map.
        /// </summary>
        [EnumMember(Value = "https://schema.org/TransitMap")]
        TransitMap,

        /// <summary>
        /// A venue map (e.g. for malls, auditoriums, museums, etc.).
        /// </summary>
        [EnumMember(Value = "https://schema.org/VenueMap")]
        VenueMap
    }
}

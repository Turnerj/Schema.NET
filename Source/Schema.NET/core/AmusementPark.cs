namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An amusement park.
    /// </summary>
    public partial interface IAmusementPark : IEntertainmentBusiness
    {
    }

    /// <summary>
    /// An amusement park.
    /// </summary>
    public partial class AmusementPark : EntertainmentBusiness, IAmusementPark
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "AmusementPark";
    }
}

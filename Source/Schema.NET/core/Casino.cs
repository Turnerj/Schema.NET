namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A casino.
    /// </summary>
    public partial interface ICasino : IEntertainmentBusiness
    {
    }

    /// <summary>
    /// A casino.
    /// </summary>
    public partial class Casino : EntertainmentBusiness, ICasino
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Casino";
    }
}

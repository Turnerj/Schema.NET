namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An event venue.
    /// </summary>
    public partial interface IEventVenue : ICivicStructure
    {
    }

    /// <summary>
    /// An event venue.
    /// </summary>
    public partial class EventVenue : CivicStructure, IEventVenue
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "EventVenue";
    }
}

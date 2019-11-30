namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A music venue.
    /// </summary>
    public partial interface IMusicVenue : ICivicStructure
    {
    }

    /// <summary>
    /// A music venue.
    /// </summary>
    public partial class MusicVenue : CivicStructure, IMusicVenue
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "MusicVenue";
    }
}

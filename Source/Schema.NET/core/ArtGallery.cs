namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An art gallery.
    /// </summary>
    public partial interface IArtGallery : IEntertainmentBusiness
    {
    }

    /// <summary>
    /// An art gallery.
    /// </summary>
    public partial class ArtGallery : EntertainmentBusiness, IArtGallery
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ArtGallery";
    }
}

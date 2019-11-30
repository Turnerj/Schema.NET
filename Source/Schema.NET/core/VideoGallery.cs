namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Web page type: Video gallery page.
    /// </summary>
    public partial interface IVideoGallery : ICollectionPage
    {
    }

    /// <summary>
    /// Web page type: Video gallery page.
    /// </summary>
    public partial class VideoGallery : CollectionPage, IVideoGallery
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "VideoGallery";
    }
}

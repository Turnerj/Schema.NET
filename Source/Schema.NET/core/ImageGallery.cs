namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Web page type: Image gallery page.
    /// </summary>
    public partial interface IImageGallery : ICollectionPage
    {
    }

    /// <summary>
    /// Web page type: Image gallery page.
    /// </summary>
    public partial class ImageGallery : CollectionPage, IImageGallery
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ImageGallery";
    }
}

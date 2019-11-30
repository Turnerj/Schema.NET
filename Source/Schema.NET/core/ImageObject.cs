namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An image file.
    /// </summary>
    public partial interface IImageObject : IMediaObject
    {
        /// <summary>
        /// The caption for this object. For downloadable machine formats (closed caption, subtitles etc.) use MediaObject and indicate the &lt;a class="localLink" href="http://schema.org/encodingFormat"&gt;encodingFormat&lt;/a&gt;.
        /// </summary>
        Values<IMediaObject, string> Caption { get; set; }

        /// <summary>
        /// exif data for this object.
        /// </summary>
        Values<IPropertyValue, string> ExifData { get; set; }

        /// <summary>
        /// Indicates whether this image is representative of the content of the page.
        /// </summary>
        OneOrMany<bool?> RepresentativeOfPage { get; set; }

        /// <summary>
        /// Thumbnail image for an image or video.
        /// </summary>
        OneOrMany<IImageObject> Thumbnail { get; set; }
    }

    /// <summary>
    /// An image file.
    /// </summary>
    public partial class ImageObject : MediaObject, IImageObject
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ImageObject";

        /// <summary>
        /// The caption for this object. For downloadable machine formats (closed caption, subtitles etc.) use MediaObject and indicate the &lt;a class="localLink" href="http://schema.org/encodingFormat"&gt;encodingFormat&lt;/a&gt;.
        /// </summary>
        [JsonPropertyName("caption")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMediaObject, string> Caption { get; set; }

        /// <summary>
        /// exif data for this object.
        /// </summary>
        [JsonPropertyName("exifData")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IPropertyValue, string> ExifData { get; set; }

        /// <summary>
        /// Indicates whether this image is representative of the content of the page.
        /// </summary>
        [JsonPropertyName("representativeOfPage")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<bool?> RepresentativeOfPage { get; set; }

        /// <summary>
        /// Thumbnail image for an image or video.
        /// </summary>
        [JsonPropertyName("thumbnail")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IImageObject> Thumbnail { get; set; }
    }
}

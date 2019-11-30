namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A video file.
    /// </summary>
    public partial interface IVideoObject : IMediaObject
    {
        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        OneOrMany<IPerson> Actor { get; set; }

        /// <summary>
        /// The caption for this object. For downloadable machine formats (closed caption, subtitles etc.) use MediaObject and indicate the &lt;a class="localLink" href="http://schema.org/encodingFormat"&gt;encodingFormat&lt;/a&gt;.
        /// </summary>
        Values<IMediaObject, string> Caption { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        OneOrMany<IPerson> Director { get; set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        Values<IMusicGroup, IPerson> MusicBy { get; set; }

        /// <summary>
        /// Thumbnail image for an image or video.
        /// </summary>
        OneOrMany<IImageObject> Thumbnail { get; set; }

        /// <summary>
        /// If this MediaObject is an AudioObject or VideoObject, the transcript of that object.
        /// </summary>
        OneOrMany<string> Transcript { get; set; }

        /// <summary>
        /// The frame size of the video.
        /// </summary>
        OneOrMany<string> VideoFrameSize { get; set; }

        /// <summary>
        /// The quality of the video.
        /// </summary>
        OneOrMany<string> VideoQuality { get; set; }
    }

    /// <summary>
    /// A video file.
    /// </summary>
    public partial class VideoObject : MediaObject, IVideoObject
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "VideoObject";

        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [JsonPropertyName("actor")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Actor { get; set; }

        /// <summary>
        /// The caption for this object. For downloadable machine formats (closed caption, subtitles etc.) use MediaObject and indicate the &lt;a class="localLink" href="http://schema.org/encodingFormat"&gt;encodingFormat&lt;/a&gt;.
        /// </summary>
        [JsonPropertyName("caption")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMediaObject, string> Caption { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [JsonPropertyName("director")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Director { get; set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [JsonPropertyName("musicBy")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMusicGroup, IPerson> MusicBy { get; set; }

        /// <summary>
        /// Thumbnail image for an image or video.
        /// </summary>
        [JsonPropertyName("thumbnail")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IImageObject> Thumbnail { get; set; }

        /// <summary>
        /// If this MediaObject is an AudioObject or VideoObject, the transcript of that object.
        /// </summary>
        [JsonPropertyName("transcript")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Transcript { get; set; }

        /// <summary>
        /// The frame size of the video.
        /// </summary>
        [JsonPropertyName("videoFrameSize")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> VideoFrameSize { get; set; }

        /// <summary>
        /// The quality of the video.
        /// </summary>
        [JsonPropertyName("videoQuality")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> VideoQuality { get; set; }
    }
}

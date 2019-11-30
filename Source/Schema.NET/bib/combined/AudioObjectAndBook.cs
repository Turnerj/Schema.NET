namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// See AudioObject, Book for more information.
    /// </summary>
    public partial interface IAudioObjectAndBook : IAudioObject, IBook
    {
    }

    /// <summary>
    /// See AudioObject, Book for more information.
    /// </summary>
    public abstract partial class AudioObjectAndBook : MediaObject, IAudioObjectAndBook
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "AudioObjectAndBook";

        /// <summary>
        /// Indicates whether the book is an abridged edition.
        /// </summary>
        [JsonPropertyName("abridged")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<bool?> Abridged { get; set; }

        /// <summary>
        /// The edition of the book.
        /// </summary>
        [JsonPropertyName("bookEdition")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> BookEdition { get; set; }

        /// <summary>
        /// The format of the book.
        /// </summary>
        [JsonPropertyName("bookFormat")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<BookFormatType?> BookFormat { get; set; }

        /// <summary>
        /// The caption for this object. For downloadable machine formats (closed caption, subtitles etc.) use MediaObject and indicate the &lt;a class="localLink" href="http://schema.org/encodingFormat"&gt;encodingFormat&lt;/a&gt;.
        /// </summary>
        [JsonPropertyName("caption")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMediaObject, string> Caption { get; set; }

        /// <summary>
        /// The illustrator of the book.
        /// </summary>
        [JsonPropertyName("illustrator")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Illustrator { get; set; }

        /// <summary>
        /// The ISBN of the book.
        /// </summary>
        [JsonPropertyName("isbn")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Isbn { get; set; }

        /// <summary>
        /// The number of pages in the book.
        /// </summary>
        [JsonPropertyName("numberOfPages")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> NumberOfPages { get; set; }

        /// <summary>
        /// If this MediaObject is an AudioObject or VideoObject, the transcript of that object.
        /// </summary>
        [JsonPropertyName("transcript")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Transcript { get; set; }
    }
}

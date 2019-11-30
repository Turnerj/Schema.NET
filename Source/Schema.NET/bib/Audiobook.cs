namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An audiobook.
    /// </summary>
    public partial interface IAudiobook : IAudioObjectAndBook
    {
        /// <summary>
        /// A person who reads (performs) the audiobook.
        /// </summary>
        OneOrMany<IPerson> ReadBy { get; set; }
    }

    /// <summary>
    /// An audiobook.
    /// </summary>
    public partial class Audiobook : AudioObjectAndBook, IAudiobook
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Audiobook";

        /// <summary>
        /// The duration of the item (movie, audio recording, event, etc.) in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.
        /// </summary>
        [JsonPropertyName("duration")]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesJsonConverter))]
        public override OneOrMany<TimeSpan?> Duration { get; set; }

        /// <summary>
        /// A person who reads (performs) the audiobook.
        /// </summary>
        [JsonPropertyName("readBy")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> ReadBy { get; set; }
    }
}

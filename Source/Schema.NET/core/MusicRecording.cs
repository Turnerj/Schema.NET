namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A music recording (track), usually a single song.
    /// </summary>
    public partial interface IMusicRecording : ICreativeWork
    {
        /// <summary>
        /// The artist that performed this album or recording.
        /// </summary>
        Values<IMusicGroup, IPerson> ByArtist { get; set; }

        /// <summary>
        /// The duration of the item (movie, audio recording, event, etc.) in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.
        /// </summary>
        OneOrMany<TimeSpan?> Duration { get; set; }

        /// <summary>
        /// The album to which this recording belongs.
        /// </summary>
        OneOrMany<IMusicAlbum> InAlbum { get; set; }

        /// <summary>
        /// The playlist to which this recording belongs.
        /// </summary>
        OneOrMany<IMusicPlaylist> InPlaylist { get; set; }

        /// <summary>
        /// The International Standard Recording Code for the recording.
        /// </summary>
        OneOrMany<string> IsrcCode { get; set; }

        /// <summary>
        /// The composition this track is a recording of.
        /// </summary>
        OneOrMany<IMusicComposition> RecordingOf { get; set; }
    }

    /// <summary>
    /// A music recording (track), usually a single song.
    /// </summary>
    public partial class MusicRecording : CreativeWork, IMusicRecording
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "MusicRecording";

        /// <summary>
        /// The artist that performed this album or recording.
        /// </summary>
        [JsonPropertyName("byArtist")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMusicGroup, IPerson> ByArtist { get; set; }

        /// <summary>
        /// The duration of the item (movie, audio recording, event, etc.) in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.
        /// </summary>
        [JsonPropertyName("duration")]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesJsonConverter))]
        public OneOrMany<TimeSpan?> Duration { get; set; }

        /// <summary>
        /// The album to which this recording belongs.
        /// </summary>
        [JsonPropertyName("inAlbum")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMusicAlbum> InAlbum { get; set; }

        /// <summary>
        /// The playlist to which this recording belongs.
        /// </summary>
        [JsonPropertyName("inPlaylist")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMusicPlaylist> InPlaylist { get; set; }

        /// <summary>
        /// The International Standard Recording Code for the recording.
        /// </summary>
        [JsonPropertyName("isrcCode")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> IsrcCode { get; set; }

        /// <summary>
        /// The composition this track is a recording of.
        /// </summary>
        [JsonPropertyName("recordingOf")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMusicComposition> RecordingOf { get; set; }
    }
}

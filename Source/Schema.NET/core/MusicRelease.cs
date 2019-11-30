namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A MusicRelease is a specific release of a music album.
    /// </summary>
    public partial interface IMusicRelease : IMusicPlaylist
    {
        /// <summary>
        /// The catalog number for the release.
        /// </summary>
        OneOrMany<string> CatalogNumber { get; set; }

        /// <summary>
        /// The group the release is credited to if different than the byArtist. For example, Red and Blue is credited to "Stefani Germanotta Band", but by Lady Gaga.
        /// </summary>
        Values<IOrganization, IPerson> CreditedTo { get; set; }

        /// <summary>
        /// The duration of the item (movie, audio recording, event, etc.) in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.
        /// </summary>
        OneOrMany<TimeSpan?> Duration { get; set; }

        /// <summary>
        /// Format of this release (the type of recording media used, ie. compact disc, digital media, LP, etc.).
        /// </summary>
        OneOrMany<MusicReleaseFormatType?> MusicReleaseFormat { get; set; }

        /// <summary>
        /// The label that issued the release.
        /// </summary>
        OneOrMany<IOrganization> RecordLabel { get; set; }

        /// <summary>
        /// The album this is a release of.
        /// </summary>
        OneOrMany<IMusicAlbum> ReleaseOf { get; set; }
    }

    /// <summary>
    /// A MusicRelease is a specific release of a music album.
    /// </summary>
    public partial class MusicRelease : MusicPlaylist, IMusicRelease
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "MusicRelease";

        /// <summary>
        /// The catalog number for the release.
        /// </summary>
        [JsonPropertyName("catalogNumber")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> CatalogNumber { get; set; }

        /// <summary>
        /// The group the release is credited to if different than the byArtist. For example, Red and Blue is credited to "Stefani Germanotta Band", but by Lady Gaga.
        /// </summary>
        [JsonPropertyName("creditedTo")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> CreditedTo { get; set; }

        /// <summary>
        /// The duration of the item (movie, audio recording, event, etc.) in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.
        /// </summary>
        [JsonPropertyName("duration")]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesJsonConverter))]
        public OneOrMany<TimeSpan?> Duration { get; set; }

        /// <summary>
        /// Format of this release (the type of recording media used, ie. compact disc, digital media, LP, etc.).
        /// </summary>
        [JsonPropertyName("musicReleaseFormat")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<MusicReleaseFormatType?> MusicReleaseFormat { get; set; }

        /// <summary>
        /// The label that issued the release.
        /// </summary>
        [JsonPropertyName("recordLabel")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrganization> RecordLabel { get; set; }

        /// <summary>
        /// The album this is a release of.
        /// </summary>
        [JsonPropertyName("releaseOf")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMusicAlbum> ReleaseOf { get; set; }
    }
}

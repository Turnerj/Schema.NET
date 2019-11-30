namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A collection of music tracks.
    /// </summary>
    public partial interface IMusicAlbum : IMusicPlaylist
    {
        /// <summary>
        /// Classification of the album by it's type of content: soundtrack, live album, studio album, etc.
        /// </summary>
        OneOrMany<MusicAlbumProductionType?> AlbumProductionType { get; set; }

        /// <summary>
        /// A release of this album.
        /// </summary>
        OneOrMany<IMusicRelease> AlbumRelease { get; set; }

        /// <summary>
        /// The kind of release which this album is: single, EP or album.
        /// </summary>
        OneOrMany<MusicAlbumReleaseType?> AlbumReleaseType { get; set; }

        /// <summary>
        /// The artist that performed this album or recording.
        /// </summary>
        Values<IMusicGroup, IPerson> ByArtist { get; set; }
    }

    /// <summary>
    /// A collection of music tracks.
    /// </summary>
    public partial class MusicAlbum : MusicPlaylist, IMusicAlbum
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "MusicAlbum";

        /// <summary>
        /// Classification of the album by it's type of content: soundtrack, live album, studio album, etc.
        /// </summary>
        [JsonPropertyName("albumProductionType")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<MusicAlbumProductionType?> AlbumProductionType { get; set; }

        /// <summary>
        /// A release of this album.
        /// </summary>
        [JsonPropertyName("albumRelease")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMusicRelease> AlbumRelease { get; set; }

        /// <summary>
        /// The kind of release which this album is: single, EP or album.
        /// </summary>
        [JsonPropertyName("albumReleaseType")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<MusicAlbumReleaseType?> AlbumReleaseType { get; set; }

        /// <summary>
        /// The artist that performed this album or recording.
        /// </summary>
        [JsonPropertyName("byArtist")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMusicGroup, IPerson> ByArtist { get; set; }
    }
}

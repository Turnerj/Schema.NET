namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A collection of music tracks in playlist form.
    /// </summary>
    public partial interface IMusicPlaylist : ICreativeWork
    {
        /// <summary>
        /// The number of tracks in this album or playlist.
        /// </summary>
        OneOrMany<int?> NumTracks { get; set; }

        /// <summary>
        /// A music recording (track)&amp;#x2014;usually a single song. If an ItemList is given, the list should contain items of type MusicRecording.
        /// </summary>
        Values<IItemList, IMusicRecording> Track { get; set; }
    }

    /// <summary>
    /// A collection of music tracks in playlist form.
    /// </summary>
    public partial class MusicPlaylist : CreativeWork, IMusicPlaylist
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "MusicPlaylist";

        /// <summary>
        /// The number of tracks in this album or playlist.
        /// </summary>
        [JsonPropertyName("numTracks")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> NumTracks { get; set; }

        /// <summary>
        /// A music recording (track)&amp;#x2014;usually a single song. If an ItemList is given, the list should contain items of type MusicRecording.
        /// </summary>
        [JsonPropertyName("track")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IItemList, IMusicRecording> Track { get; set; }
    }
}

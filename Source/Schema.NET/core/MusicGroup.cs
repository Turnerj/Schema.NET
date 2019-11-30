namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A musical group, such as a band, an orchestra, or a choir. Can also be a solo musician.
    /// </summary>
    public partial interface IMusicGroup : IPerformingGroup
    {
        /// <summary>
        /// A music album.
        /// </summary>
        OneOrMany<IMusicAlbum> Album { get; set; }

        /// <summary>
        /// Genre of the creative work, broadcast channel or group.
        /// </summary>
        Values<string, Uri> Genre { get; set; }

        /// <summary>
        /// A music recording (track)&amp;#x2014;usually a single song. If an ItemList is given, the list should contain items of type MusicRecording.
        /// </summary>
        Values<IItemList, IMusicRecording> Track { get; set; }
    }

    /// <summary>
    /// A musical group, such as a band, an orchestra, or a choir. Can also be a solo musician.
    /// </summary>
    public partial class MusicGroup : PerformingGroup, IMusicGroup
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "MusicGroup";

        /// <summary>
        /// A music album.
        /// </summary>
        [JsonPropertyName("album")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMusicAlbum> Album { get; set; }

        /// <summary>
        /// Genre of the creative work, broadcast channel or group.
        /// </summary>
        [JsonPropertyName("genre")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> Genre { get; set; }

        /// <summary>
        /// A music recording (track)&amp;#x2014;usually a single song. If an ItemList is given, the list should contain items of type MusicRecording.
        /// </summary>
        [JsonPropertyName("track")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IItemList, IMusicRecording> Track { get; set; }
    }
}

namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A short TV or radio program or a segment/part of a program.
    /// </summary>
    public partial interface IClip : ICreativeWork
    {
        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        OneOrMany<IPerson> Actor { get; set; }

        /// <summary>
        /// Position of the clip within an ordered group of clips.
        /// </summary>
        Values<int?, string> ClipNumber { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        OneOrMany<IPerson> Director { get; set; }

        /// <summary>
        /// The end time of the clip expressed as the number of seconds from the beginning of the work.
        /// </summary>
        OneOrMany<double?> EndOffset { get; set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        Values<IMusicGroup, IPerson> MusicBy { get; set; }

        /// <summary>
        /// The episode to which this clip belongs.
        /// </summary>
        OneOrMany<IEpisode> PartOfEpisode { get; set; }

        /// <summary>
        /// The season to which this episode belongs.
        /// </summary>
        OneOrMany<ICreativeWorkSeason> PartOfSeason { get; set; }

        /// <summary>
        /// The series to which this episode or season belongs.
        /// </summary>
        OneOrMany<ICreativeWorkSeries> PartOfSeries { get; set; }

        /// <summary>
        /// The start time of the clip expressed as the number of seconds from the beginning of the work.
        /// </summary>
        OneOrMany<double?> StartOffset { get; set; }
    }

    /// <summary>
    /// A short TV or radio program or a segment/part of a program.
    /// </summary>
    public partial class Clip : CreativeWork, IClip
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Clip";

        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [JsonPropertyName("actor")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Actor { get; set; }

        /// <summary>
        /// Position of the clip within an ordered group of clips.
        /// </summary>
        [JsonPropertyName("clipNumber")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<int?, string> ClipNumber { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [JsonPropertyName("director")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Director { get; set; }

        /// <summary>
        /// The end time of the clip expressed as the number of seconds from the beginning of the work.
        /// </summary>
        [JsonPropertyName("endOffset")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<double?> EndOffset { get; set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [JsonPropertyName("musicBy")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMusicGroup, IPerson> MusicBy { get; set; }

        /// <summary>
        /// The episode to which this clip belongs.
        /// </summary>
        [JsonPropertyName("partOfEpisode")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IEpisode> PartOfEpisode { get; set; }

        /// <summary>
        /// The season to which this episode belongs.
        /// </summary>
        [JsonPropertyName("partOfSeason")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ICreativeWorkSeason> PartOfSeason { get; set; }

        /// <summary>
        /// The series to which this episode or season belongs.
        /// </summary>
        [JsonPropertyName("partOfSeries")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ICreativeWorkSeries> PartOfSeries { get; set; }

        /// <summary>
        /// The start time of the clip expressed as the number of seconds from the beginning of the work.
        /// </summary>
        [JsonPropertyName("startOffset")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<double?> StartOffset { get; set; }
    }
}

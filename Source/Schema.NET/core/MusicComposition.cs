namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A musical composition.
    /// </summary>
    public partial interface IMusicComposition : ICreativeWork
    {
        /// <summary>
        /// The person or organization who wrote a composition, or who is the composer of a work performed at some event.
        /// </summary>
        Values<IOrganization, IPerson> Composer { get; set; }

        /// <summary>
        /// The date and place the work was first performed.
        /// </summary>
        OneOrMany<IEvent> FirstPerformance { get; set; }

        /// <summary>
        /// Smaller compositions included in this work (e.g. a movement in a symphony).
        /// </summary>
        OneOrMany<IMusicComposition> IncludedComposition { get; set; }

        /// <summary>
        /// The International Standard Musical Work Code for the composition.
        /// </summary>
        OneOrMany<string> IswcCode { get; set; }

        /// <summary>
        /// The person who wrote the words.
        /// </summary>
        OneOrMany<IPerson> Lyricist { get; set; }

        /// <summary>
        /// The words in the song.
        /// </summary>
        OneOrMany<ICreativeWork> Lyrics { get; set; }

        /// <summary>
        /// The key, mode, or scale this composition uses.
        /// </summary>
        OneOrMany<string> MusicalKey { get; set; }

        /// <summary>
        /// An arrangement derived from the composition.
        /// </summary>
        OneOrMany<IMusicComposition> MusicArrangement { get; set; }

        /// <summary>
        /// The type of composition (e.g. overture, sonata, symphony, etc.).
        /// </summary>
        OneOrMany<string> MusicCompositionForm { get; set; }

        /// <summary>
        /// An audio recording of the work.
        /// </summary>
        OneOrMany<IMusicRecording> RecordedAs { get; set; }
    }

    /// <summary>
    /// A musical composition.
    /// </summary>
    public partial class MusicComposition : CreativeWork, IMusicComposition
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "MusicComposition";

        /// <summary>
        /// The person or organization who wrote a composition, or who is the composer of a work performed at some event.
        /// </summary>
        [JsonPropertyName("composer")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Composer { get; set; }

        /// <summary>
        /// The date and place the work was first performed.
        /// </summary>
        [JsonPropertyName("firstPerformance")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IEvent> FirstPerformance { get; set; }

        /// <summary>
        /// Smaller compositions included in this work (e.g. a movement in a symphony).
        /// </summary>
        [JsonPropertyName("includedComposition")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMusicComposition> IncludedComposition { get; set; }

        /// <summary>
        /// The International Standard Musical Work Code for the composition.
        /// </summary>
        [JsonPropertyName("iswcCode")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> IswcCode { get; set; }

        /// <summary>
        /// The person who wrote the words.
        /// </summary>
        [JsonPropertyName("lyricist")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Lyricist { get; set; }

        /// <summary>
        /// The words in the song.
        /// </summary>
        [JsonPropertyName("lyrics")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ICreativeWork> Lyrics { get; set; }

        /// <summary>
        /// The key, mode, or scale this composition uses.
        /// </summary>
        [JsonPropertyName("musicalKey")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> MusicalKey { get; set; }

        /// <summary>
        /// An arrangement derived from the composition.
        /// </summary>
        [JsonPropertyName("musicArrangement")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMusicComposition> MusicArrangement { get; set; }

        /// <summary>
        /// The type of composition (e.g. overture, sonata, symphony, etc.).
        /// </summary>
        [JsonPropertyName("musicCompositionForm")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> MusicCompositionForm { get; set; }

        /// <summary>
        /// An audio recording of the work.
        /// </summary>
        [JsonPropertyName("recordedAs")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMusicRecording> RecordedAs { get; set; }
    }
}

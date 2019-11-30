namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The term "story" is any indivisible, re-printable
    ///     unit of a comic, including the interior stories, covers, and backmatter. Most
    ///     comics have at least two stories: a cover (ComicCoverArt) and an interior story.
    /// </summary>
    public partial interface IComicStory : ICreativeWork
    {
        /// <summary>
        /// The primary artist for a work
        ///     in a medium other than pencils or digital line art--for example, if the
        ///     primary artwork is done in watercolors or digital paints.
        /// </summary>
        OneOrMany<IPerson> Artist { get; set; }

        /// <summary>
        /// The individual who adds color to inked drawings.
        /// </summary>
        OneOrMany<IPerson> Colorist { get; set; }

        /// <summary>
        /// The individual who traces over the pencil drawings in ink after pencils are complete.
        /// </summary>
        OneOrMany<IPerson> Inker { get; set; }

        /// <summary>
        /// The individual who adds lettering, including speech balloons and sound effects, to artwork.
        /// </summary>
        OneOrMany<IPerson> Letterer { get; set; }

        /// <summary>
        /// The individual who draws the primary narrative artwork.
        /// </summary>
        OneOrMany<IPerson> Penciler { get; set; }
    }

    /// <summary>
    /// The term "story" is any indivisible, re-printable
    ///     unit of a comic, including the interior stories, covers, and backmatter. Most
    ///     comics have at least two stories: a cover (ComicCoverArt) and an interior story.
    /// </summary>
    public partial class ComicStory : CreativeWork, IComicStory
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ComicStory";

        /// <summary>
        /// The primary artist for a work
        ///     in a medium other than pencils or digital line art--for example, if the
        ///     primary artwork is done in watercolors or digital paints.
        /// </summary>
        [JsonPropertyName("artist")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Artist { get; set; }

        /// <summary>
        /// The individual who adds color to inked drawings.
        /// </summary>
        [JsonPropertyName("colorist")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Colorist { get; set; }

        /// <summary>
        /// The individual who traces over the pencil drawings in ink after pencils are complete.
        /// </summary>
        [JsonPropertyName("inker")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Inker { get; set; }

        /// <summary>
        /// The individual who adds lettering, including speech balloons and sound effects, to artwork.
        /// </summary>
        [JsonPropertyName("letterer")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Letterer { get; set; }

        /// <summary>
        /// The individual who draws the primary narrative artwork.
        /// </summary>
        [JsonPropertyName("penciler")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Penciler { get; set; }
    }
}

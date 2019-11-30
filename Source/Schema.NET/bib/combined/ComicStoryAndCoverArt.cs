namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// See ComicStory, CoverArt for more information.
    /// </summary>
    public partial interface IComicStoryAndCoverArt : ICoverArt, IComicStory
    {
    }

    /// <summary>
    /// See ComicStory, CoverArt for more information.
    /// </summary>
    public abstract partial class ComicStoryAndCoverArt : VisualArtwork, IComicStoryAndCoverArt
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ComicStoryAndCoverArt";

        /// <summary>
        /// The primary artist for a work
        ///     in a medium other than pencils or digital line art--for example, if the
        ///     primary artwork is done in watercolors or digital paints.
        /// </summary>
        [JsonPropertyName("artist")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IPerson> Artist { get; set; }

        /// <summary>
        /// The individual who adds color to inked drawings.
        /// </summary>
        [JsonPropertyName("colorist")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IPerson> Colorist { get; set; }

        /// <summary>
        /// The individual who traces over the pencil drawings in ink after pencils are complete.
        /// </summary>
        [JsonPropertyName("inker")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IPerson> Inker { get; set; }

        /// <summary>
        /// The individual who adds lettering, including speech balloons and sound effects, to artwork.
        /// </summary>
        [JsonPropertyName("letterer")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IPerson> Letterer { get; set; }

        /// <summary>
        /// The individual who draws the primary narrative artwork.
        /// </summary>
        [JsonPropertyName("penciler")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IPerson> Penciler { get; set; }
    }
}

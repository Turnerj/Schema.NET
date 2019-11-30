namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Individual comic issues are serially published as
    ///     part of a larger series. For the sake of consistency, even one-shot issues
    ///     belong to a series comprised of a single issue. All comic issues can be
    ///     uniquely identified by: the combination of the name and volume number of the
    ///     series to which the issue belongs; the issue number; and the variant
    ///     description of the issue (if any).
    /// </summary>
    public partial interface IComicIssue : IPublicationIssue
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

        /// <summary>
        /// A description of the variant cover
        ///     for the issue, if the issue is a variant printing. For example, "Bryan Hitch
        ///     Variant Cover" or "2nd Printing Variant".
        /// </summary>
        OneOrMany<string> VariantCover { get; set; }
    }

    /// <summary>
    /// Individual comic issues are serially published as
    ///     part of a larger series. For the sake of consistency, even one-shot issues
    ///     belong to a series comprised of a single issue. All comic issues can be
    ///     uniquely identified by: the combination of the name and volume number of the
    ///     series to which the issue belongs; the issue number; and the variant
    ///     description of the issue (if any).
    /// </summary>
    public partial class ComicIssue : PublicationIssue, IComicIssue
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ComicIssue";

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

        /// <summary>
        /// A description of the variant cover
        ///     for the issue, if the issue is a variant printing. For example, "Bryan Hitch
        ///     Variant Cover" or "2nd Printing Variant".
        /// </summary>
        [JsonPropertyName("variantCover")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> VariantCover { get; set; }
    }
}

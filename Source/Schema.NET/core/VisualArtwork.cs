namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A work of art that is primarily visual in character.
    /// </summary>
    public partial interface IVisualArtwork : ICreativeWork
    {
        /// <summary>
        /// The number of copies when multiple copies of a piece of artwork are produced - e.g. for a limited edition of 20 prints, 'artEdition' refers to the total number of copies (in this example "20").
        /// </summary>
        Values<int?, string> ArtEdition { get; set; }

        /// <summary>
        /// e.g. Painting, Drawing, Sculpture, Print, Photograph, Assemblage, Collage, etc.
        /// </summary>
        Values<string, Uri> Artform { get; set; }

        /// <summary>
        /// The primary artist for a work
        ///     in a medium other than pencils or digital line art--for example, if the
        ///     primary artwork is done in watercolors or digital paints.
        /// </summary>
        OneOrMany<IPerson> Artist { get; set; }

        /// <summary>
        /// The material used. (e.g. Oil, Watercolour, Acrylic, Linoprint, Marble, Cyanotype, Digital, Lithograph, DryPoint, Intaglio, Pastel, Woodcut, Pencil, Mixed Media, etc.)
        /// </summary>
        Values<string, Uri> ArtMedium { get; set; }

        /// <summary>
        /// The supporting materials for the artwork, e.g. Canvas, Paper, Wood, Board, etc.
        /// </summary>
        Values<string, Uri> ArtworkSurface { get; set; }

        /// <summary>
        /// The individual who adds color to inked drawings.
        /// </summary>
        OneOrMany<IPerson> Colorist { get; set; }

        /// <summary>
        /// The depth of the item.
        /// </summary>
        Values<string, IQuantitativeValue> Depth { get; set; }

        /// <summary>
        /// The height of the item.
        /// </summary>
        Values<string, IQuantitativeValue> Height { get; set; }

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
        /// The width of the item.
        /// </summary>
        Values<string, IQuantitativeValue> Width { get; set; }
    }

    /// <summary>
    /// A work of art that is primarily visual in character.
    /// </summary>
    public partial class VisualArtwork : CreativeWork, IVisualArtwork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "VisualArtwork";

        /// <summary>
        /// The number of copies when multiple copies of a piece of artwork are produced - e.g. for a limited edition of 20 prints, 'artEdition' refers to the total number of copies (in this example "20").
        /// </summary>
        [JsonPropertyName("artEdition")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<int?, string> ArtEdition { get; set; }

        /// <summary>
        /// e.g. Painting, Drawing, Sculpture, Print, Photograph, Assemblage, Collage, etc.
        /// </summary>
        [JsonPropertyName("artform")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> Artform { get; set; }

        /// <summary>
        /// The primary artist for a work
        ///     in a medium other than pencils or digital line art--for example, if the
        ///     primary artwork is done in watercolors or digital paints.
        /// </summary>
        [JsonPropertyName("artist")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IPerson> Artist { get; set; }

        /// <summary>
        /// The material used. (e.g. Oil, Watercolour, Acrylic, Linoprint, Marble, Cyanotype, Digital, Lithograph, DryPoint, Intaglio, Pastel, Woodcut, Pencil, Mixed Media, etc.)
        /// </summary>
        [JsonPropertyName("artMedium")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> ArtMedium { get; set; }

        /// <summary>
        /// The supporting materials for the artwork, e.g. Canvas, Paper, Wood, Board, etc.
        /// </summary>
        [JsonPropertyName("artworkSurface")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> ArtworkSurface { get; set; }

        /// <summary>
        /// The individual who adds color to inked drawings.
        /// </summary>
        [JsonPropertyName("colorist")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IPerson> Colorist { get; set; }

        /// <summary>
        /// The depth of the item.
        /// </summary>
        [JsonPropertyName("depth")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, IQuantitativeValue> Depth { get; set; }

        /// <summary>
        /// The height of the item.
        /// </summary>
        [JsonPropertyName("height")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, IQuantitativeValue> Height { get; set; }

        /// <summary>
        /// The individual who traces over the pencil drawings in ink after pencils are complete.
        /// </summary>
        [JsonPropertyName("inker")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IPerson> Inker { get; set; }

        /// <summary>
        /// The individual who adds lettering, including speech balloons and sound effects, to artwork.
        /// </summary>
        [JsonPropertyName("letterer")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IPerson> Letterer { get; set; }

        /// <summary>
        /// The individual who draws the primary narrative artwork.
        /// </summary>
        [JsonPropertyName("penciler")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IPerson> Penciler { get; set; }

        /// <summary>
        /// The width of the item.
        /// </summary>
        [JsonPropertyName("width")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, IQuantitativeValue> Width { get; set; }
    }
}

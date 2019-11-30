namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A book.
    /// </summary>
    public partial interface IBook : ICreativeWork
    {
        /// <summary>
        /// Indicates whether the book is an abridged edition.
        /// </summary>
        OneOrMany<bool?> Abridged { get; set; }

        /// <summary>
        /// The edition of the book.
        /// </summary>
        OneOrMany<string> BookEdition { get; set; }

        /// <summary>
        /// The format of the book.
        /// </summary>
        OneOrMany<BookFormatType?> BookFormat { get; set; }

        /// <summary>
        /// The illustrator of the book.
        /// </summary>
        OneOrMany<IPerson> Illustrator { get; set; }

        /// <summary>
        /// The ISBN of the book.
        /// </summary>
        OneOrMany<string> Isbn { get; set; }

        /// <summary>
        /// The number of pages in the book.
        /// </summary>
        OneOrMany<int?> NumberOfPages { get; set; }
    }

    /// <summary>
    /// A book.
    /// </summary>
    public partial class Book : CreativeWork, IBook
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Book";

        /// <summary>
        /// Indicates whether the book is an abridged edition.
        /// </summary>
        [JsonPropertyName("abridged")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<bool?> Abridged { get; set; }

        /// <summary>
        /// The edition of the book.
        /// </summary>
        [JsonPropertyName("bookEdition")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> BookEdition { get; set; }

        /// <summary>
        /// The format of the book.
        /// </summary>
        [JsonPropertyName("bookFormat")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<BookFormatType?> BookFormat { get; set; }

        /// <summary>
        /// The illustrator of the book.
        /// </summary>
        [JsonPropertyName("illustrator")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Illustrator { get; set; }

        /// <summary>
        /// The ISBN of the book.
        /// </summary>
        [JsonPropertyName("isbn")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Isbn { get; set; }

        /// <summary>
        /// The number of pages in the book.
        /// </summary>
        [JsonPropertyName("numberOfPages")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> NumberOfPages { get; set; }
    }
}

namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A series of books. Included books can be indicated with the hasPart property.
    /// </summary>
    public partial interface IBookSeries : ICreativeWorkSeries
    {
    }

    /// <summary>
    /// A series of books. Included books can be indicated with the hasPart property.
    /// </summary>
    public partial class BookSeries : CreativeWorkSeries, IBookSeries
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "BookSeries";
    }
}

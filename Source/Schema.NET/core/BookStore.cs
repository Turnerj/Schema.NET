namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A bookstore.
    /// </summary>
    public partial interface IBookStore : IStore
    {
    }

    /// <summary>
    /// A bookstore.
    /// </summary>
    public partial class BookStore : Store, IBookStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "BookStore";
    }
}

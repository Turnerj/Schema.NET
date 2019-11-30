namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A movie rental store.
    /// </summary>
    public partial interface IMovieRentalStore : IStore
    {
    }

    /// <summary>
    /// A movie rental store.
    /// </summary>
    public partial class MovieRentalStore : Store, IMovieRentalStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "MovieRentalStore";
    }
}

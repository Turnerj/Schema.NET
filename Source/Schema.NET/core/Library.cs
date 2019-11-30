namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A library.
    /// </summary>
    public partial interface ILibrary : ILocalBusiness
    {
    }

    /// <summary>
    /// A library.
    /// </summary>
    public partial class Library : LocalBusiness, ILibrary
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Library";
    }
}

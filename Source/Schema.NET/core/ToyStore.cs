namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A toy store.
    /// </summary>
    public partial interface IToyStore : IStore
    {
    }

    /// <summary>
    /// A toy store.
    /// </summary>
    public partial class ToyStore : Store, IToyStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ToyStore";
    }
}

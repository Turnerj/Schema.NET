namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A bike store.
    /// </summary>
    public partial interface IBikeStore : IStore
    {
    }

    /// <summary>
    /// A bike store.
    /// </summary>
    public partial class BikeStore : Store, IBikeStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "BikeStore";
    }
}

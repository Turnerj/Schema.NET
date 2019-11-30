namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A men's clothing store.
    /// </summary>
    public partial interface IMensClothingStore : IStore
    {
    }

    /// <summary>
    /// A men's clothing store.
    /// </summary>
    public partial class MensClothingStore : Store, IMensClothingStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "MensClothingStore";
    }
}

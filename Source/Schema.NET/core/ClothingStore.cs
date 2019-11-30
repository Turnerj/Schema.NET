namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A clothing store.
    /// </summary>
    public partial interface IClothingStore : IStore
    {
    }

    /// <summary>
    /// A clothing store.
    /// </summary>
    public partial class ClothingStore : Store, IClothingStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ClothingStore";
    }
}

namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A shoe store.
    /// </summary>
    public partial interface IShoeStore : IStore
    {
    }

    /// <summary>
    /// A shoe store.
    /// </summary>
    public partial class ShoeStore : Store, IShoeStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ShoeStore";
    }
}

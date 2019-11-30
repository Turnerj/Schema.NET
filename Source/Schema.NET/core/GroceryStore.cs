namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A grocery store.
    /// </summary>
    public partial interface IGroceryStore : IStore
    {
    }

    /// <summary>
    /// A grocery store.
    /// </summary>
    public partial class GroceryStore : Store, IGroceryStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "GroceryStore";
    }
}

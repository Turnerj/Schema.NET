namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A furniture store.
    /// </summary>
    public partial interface IFurnitureStore : IStore
    {
    }

    /// <summary>
    /// A furniture store.
    /// </summary>
    public partial class FurnitureStore : Store, IFurnitureStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "FurnitureStore";
    }
}

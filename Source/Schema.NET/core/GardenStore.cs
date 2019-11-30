namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A garden store.
    /// </summary>
    public partial interface IGardenStore : IStore
    {
    }

    /// <summary>
    /// A garden store.
    /// </summary>
    public partial class GardenStore : Store, IGardenStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "GardenStore";
    }
}

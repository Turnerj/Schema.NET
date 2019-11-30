namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A placeholder for multiple similar products of the same kind.
    /// </summary>
    public partial interface ISomeProducts : IProduct
    {
        /// <summary>
        /// The current approximate inventory level for the item or items.
        /// </summary>
        OneOrMany<IQuantitativeValue> InventoryLevel { get; set; }
    }

    /// <summary>
    /// A placeholder for multiple similar products of the same kind.
    /// </summary>
    public partial class SomeProducts : Product, ISomeProducts
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "SomeProducts";

        /// <summary>
        /// The current approximate inventory level for the item or items.
        /// </summary>
        [JsonPropertyName("inventoryLevel")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> InventoryLevel { get; set; }
    }
}

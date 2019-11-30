namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A tire shop.
    /// </summary>
    public partial interface ITireShop : IStore
    {
    }

    /// <summary>
    /// A tire shop.
    /// </summary>
    public partial class TireShop : Store, ITireShop
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "TireShop";
    }
}

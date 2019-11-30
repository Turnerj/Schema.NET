namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A home goods store.
    /// </summary>
    public partial interface IHomeGoodsStore : IStore
    {
    }

    /// <summary>
    /// A home goods store.
    /// </summary>
    public partial class HomeGoodsStore : Store, IHomeGoodsStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "HomeGoodsStore";
    }
}

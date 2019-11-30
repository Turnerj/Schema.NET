namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A sporting goods store.
    /// </summary>
    public partial interface ISportingGoodsStore : IStore
    {
    }

    /// <summary>
    /// A sporting goods store.
    /// </summary>
    public partial class SportingGoodsStore : Store, ISportingGoodsStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "SportingGoodsStore";
    }
}

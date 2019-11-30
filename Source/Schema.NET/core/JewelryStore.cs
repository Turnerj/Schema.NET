namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A jewelry store.
    /// </summary>
    public partial interface IJewelryStore : IStore
    {
    }

    /// <summary>
    /// A jewelry store.
    /// </summary>
    public partial class JewelryStore : Store, IJewelryStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "JewelryStore";
    }
}

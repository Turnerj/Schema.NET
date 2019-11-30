namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A wholesale store.
    /// </summary>
    public partial interface IWholesaleStore : IStore
    {
    }

    /// <summary>
    /// A wholesale store.
    /// </summary>
    public partial class WholesaleStore : Store, IWholesaleStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "WholesaleStore";
    }
}

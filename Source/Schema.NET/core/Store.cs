namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A retail good store.
    /// </summary>
    public partial interface IStore : ILocalBusiness
    {
    }

    /// <summary>
    /// A retail good store.
    /// </summary>
    public partial class Store : LocalBusiness, IStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Store";
    }
}

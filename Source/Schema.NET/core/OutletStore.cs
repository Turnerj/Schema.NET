namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An outlet store.
    /// </summary>
    public partial interface IOutletStore : IStore
    {
    }

    /// <summary>
    /// An outlet store.
    /// </summary>
    public partial class OutletStore : Store, IOutletStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "OutletStore";
    }
}

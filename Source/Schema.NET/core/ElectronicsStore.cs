namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An electronics store.
    /// </summary>
    public partial interface IElectronicsStore : IStore
    {
    }

    /// <summary>
    /// An electronics store.
    /// </summary>
    public partial class ElectronicsStore : Store, IElectronicsStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ElectronicsStore";
    }
}

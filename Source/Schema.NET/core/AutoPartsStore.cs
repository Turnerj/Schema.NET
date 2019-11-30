namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An auto parts store.
    /// </summary>
    public partial interface IAutoPartsStore : IAutomotiveBusinessAndStore
    {
    }

    /// <summary>
    /// An auto parts store.
    /// </summary>
    public partial class AutoPartsStore : AutomotiveBusinessAndStore, IAutoPartsStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "AutoPartsStore";
    }
}

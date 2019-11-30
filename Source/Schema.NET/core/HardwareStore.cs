namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A hardware store.
    /// </summary>
    public partial interface IHardwareStore : IStore
    {
    }

    /// <summary>
    /// A hardware store.
    /// </summary>
    public partial class HardwareStore : Store, IHardwareStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "HardwareStore";
    }
}

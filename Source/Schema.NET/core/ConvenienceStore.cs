namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A convenience store.
    /// </summary>
    public partial interface IConvenienceStore : IStore
    {
    }

    /// <summary>
    /// A convenience store.
    /// </summary>
    public partial class ConvenienceStore : Store, IConvenienceStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ConvenienceStore";
    }
}

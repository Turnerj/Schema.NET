namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A shop that sells alcoholic drinks such as wine, beer, whisky and other spirits.
    /// </summary>
    public partial interface ILiquorStore : IStore
    {
    }

    /// <summary>
    /// A shop that sells alcoholic drinks such as wine, beer, whisky and other spirits.
    /// </summary>
    public partial class LiquorStore : Store, ILiquorStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "LiquorStore";
    }
}

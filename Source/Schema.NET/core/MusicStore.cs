namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A music store.
    /// </summary>
    public partial interface IMusicStore : IStore
    {
    }

    /// <summary>
    /// A music store.
    /// </summary>
    public partial class MusicStore : Store, IMusicStore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "MusicStore";
    }
}

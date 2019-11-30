namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A florist.
    /// </summary>
    public partial interface IFlorist : IStore
    {
    }

    /// <summary>
    /// A florist.
    /// </summary>
    public partial class Florist : Store, IFlorist
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Florist";
    }
}

namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A piece of sculpture.
    /// </summary>
    public partial interface ISculpture : ICreativeWork
    {
    }

    /// <summary>
    /// A piece of sculpture.
    /// </summary>
    public partial class Sculpture : CreativeWork, ISculpture
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Sculpture";
    }
}

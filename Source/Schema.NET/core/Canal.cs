namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A canal, like the Panama Canal.
    /// </summary>
    public partial interface ICanal : IBodyOfWater
    {
    }

    /// <summary>
    /// A canal, like the Panama Canal.
    /// </summary>
    public partial class Canal : BodyOfWater, ICanal
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Canal";
    }
}

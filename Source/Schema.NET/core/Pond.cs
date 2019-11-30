namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A pond.
    /// </summary>
    public partial interface IPond : IBodyOfWater
    {
    }

    /// <summary>
    /// A pond.
    /// </summary>
    public partial class Pond : BodyOfWater, IPond
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Pond";
    }
}

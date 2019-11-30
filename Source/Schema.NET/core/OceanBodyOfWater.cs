namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An ocean (for example, the Pacific).
    /// </summary>
    public partial interface IOceanBodyOfWater : IBodyOfWater
    {
    }

    /// <summary>
    /// An ocean (for example, the Pacific).
    /// </summary>
    public partial class OceanBodyOfWater : BodyOfWater, IOceanBodyOfWater
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "OceanBodyOfWater";
    }
}

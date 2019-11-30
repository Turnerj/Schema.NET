namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A waterfall, like Niagara.
    /// </summary>
    public partial interface IWaterfall : IBodyOfWater
    {
    }

    /// <summary>
    /// A waterfall, like Niagara.
    /// </summary>
    public partial class Waterfall : BodyOfWater, IWaterfall
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Waterfall";
    }
}

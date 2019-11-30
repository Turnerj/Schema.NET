namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// One of the continents (for example, Europe or Africa).
    /// </summary>
    public partial interface IContinent : ILandform
    {
    }

    /// <summary>
    /// One of the continents (for example, Europe or Africa).
    /// </summary>
    public partial class Continent : Landform, IContinent
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Continent";
    }
}

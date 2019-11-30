namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A ski resort.
    /// </summary>
    public partial interface ISkiResort : ISportsActivityLocation
    {
    }

    /// <summary>
    /// A ski resort.
    /// </summary>
    public partial class SkiResort : SportsActivityLocation, ISkiResort
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "SkiResort";
    }
}

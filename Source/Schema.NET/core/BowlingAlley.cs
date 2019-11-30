namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A bowling alley.
    /// </summary>
    public partial interface IBowlingAlley : ISportsActivityLocation
    {
    }

    /// <summary>
    /// A bowling alley.
    /// </summary>
    public partial class BowlingAlley : SportsActivityLocation, IBowlingAlley
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "BowlingAlley";
    }
}

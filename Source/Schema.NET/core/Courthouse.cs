namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A courthouse.
    /// </summary>
    public partial interface ICourthouse : IGovernmentBuilding
    {
    }

    /// <summary>
    /// A courthouse.
    /// </summary>
    public partial class Courthouse : GovernmentBuilding, ICourthouse
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Courthouse";
    }
}

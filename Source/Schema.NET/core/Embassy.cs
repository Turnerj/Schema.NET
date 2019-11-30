namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An embassy.
    /// </summary>
    public partial interface IEmbassy : IGovernmentBuilding
    {
    }

    /// <summary>
    /// An embassy.
    /// </summary>
    public partial class Embassy : GovernmentBuilding, IEmbassy
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Embassy";
    }
}

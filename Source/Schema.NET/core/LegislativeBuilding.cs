namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A legislative building&amp;#x2014;for example, the state capitol.
    /// </summary>
    public partial interface ILegislativeBuilding : IGovernmentBuilding
    {
    }

    /// <summary>
    /// A legislative building&amp;#x2014;for example, the state capitol.
    /// </summary>
    public partial class LegislativeBuilding : GovernmentBuilding, ILegislativeBuilding
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "LegislativeBuilding";
    }
}

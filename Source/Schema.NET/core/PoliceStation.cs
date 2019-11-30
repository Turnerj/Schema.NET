namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A police station.
    /// </summary>
    public partial interface IPoliceStation : ICivicStructureAndEmergencyService
    {
    }

    /// <summary>
    /// A police station.
    /// </summary>
    public partial class PoliceStation : CivicStructureAndEmergencyService, IPoliceStation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "PoliceStation";
    }
}

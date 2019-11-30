namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A fire station. With firemen.
    /// </summary>
    public partial interface IFireStation : ICivicStructureAndEmergencyService
    {
    }

    /// <summary>
    /// A fire station. With firemen.
    /// </summary>
    public partial class FireStation : CivicStructureAndEmergencyService, IFireStation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "FireStation";
    }
}

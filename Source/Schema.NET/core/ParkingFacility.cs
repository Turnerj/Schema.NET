namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A parking lot or other parking facility.
    /// </summary>
    public partial interface IParkingFacility : ICivicStructure
    {
    }

    /// <summary>
    /// A parking lot or other parking facility.
    /// </summary>
    public partial class ParkingFacility : CivicStructure, IParkingFacility
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ParkingFacility";
    }
}

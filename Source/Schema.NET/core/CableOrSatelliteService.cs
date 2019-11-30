namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A service which provides access to media programming like TV or radio. Access may be via cable or satellite.
    /// </summary>
    public partial interface ICableOrSatelliteService : IService
    {
    }

    /// <summary>
    /// A service which provides access to media programming like TV or radio. Access may be via cable or satellite.
    /// </summary>
    public partial class CableOrSatelliteService : Service, ICableOrSatelliteService
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "CableOrSatelliteService";
    }
}

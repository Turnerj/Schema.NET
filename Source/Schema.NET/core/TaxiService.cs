namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A service for a vehicle for hire with a driver for local travel. Fares are usually calculated based on distance traveled.
    /// </summary>
    public partial interface ITaxiService : IService
    {
    }

    /// <summary>
    /// A service for a vehicle for hire with a driver for local travel. Fares are usually calculated based on distance traveled.
    /// </summary>
    public partial class TaxiService : Service, ITaxiService
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "TaxiService";
    }
}

namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An historical landmark or building.
    /// </summary>
    public partial interface ILandmarksOrHistoricalBuildings : IPlace
    {
    }

    /// <summary>
    /// An historical landmark or building.
    /// </summary>
    public partial class LandmarksOrHistoricalBuildings : Place, ILandmarksOrHistoricalBuildings
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "LandmarksOrHistoricalBuildings";
    }
}

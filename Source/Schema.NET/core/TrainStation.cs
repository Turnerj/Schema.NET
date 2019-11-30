namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A train station.
    /// </summary>
    public partial interface ITrainStation : ICivicStructure
    {
    }

    /// <summary>
    /// A train station.
    /// </summary>
    public partial class TrainStation : CivicStructure, ITrainStation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "TrainStation";
    }
}

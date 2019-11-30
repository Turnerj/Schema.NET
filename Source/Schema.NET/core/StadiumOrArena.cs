namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A stadium.
    /// </summary>
    public partial interface IStadiumOrArena : ICivicStructureAndSportsActivityLocation
    {
    }

    /// <summary>
    /// A stadium.
    /// </summary>
    public partial class StadiumOrArena : CivicStructureAndSportsActivityLocation, IStadiumOrArena
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "StadiumOrArena";
    }
}

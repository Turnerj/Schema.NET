namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A unique instance of a television BroadcastService on a CableOrSatelliteService lineup.
    /// </summary>
    public partial interface ITelevisionChannel : IBroadcastChannel
    {
    }

    /// <summary>
    /// A unique instance of a television BroadcastService on a CableOrSatelliteService lineup.
    /// </summary>
    public partial class TelevisionChannel : BroadcastChannel, ITelevisionChannel
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "TelevisionChannel";
    }
}

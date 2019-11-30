namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A unique instance of a radio BroadcastService on a CableOrSatelliteService lineup.
    /// </summary>
    public partial interface IRadioChannel : IBroadcastChannel
    {
    }

    /// <summary>
    /// A unique instance of a radio BroadcastService on a CableOrSatelliteService lineup.
    /// </summary>
    public partial class RadioChannel : BroadcastChannel, IRadioChannel
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "RadioChannel";
    }
}

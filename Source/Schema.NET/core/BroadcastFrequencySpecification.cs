namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The frequency in MHz and the modulation used for a particular BroadcastService.
    /// </summary>
    public partial interface IBroadcastFrequencySpecification : IIntangible
    {
        /// <summary>
        /// The frequency in MHz for a particular broadcast.
        /// </summary>
        Values<double?, IQuantitativeValue> BroadcastFrequencyValue { get; set; }

        /// <summary>
        /// The modulation (e.g. FM, AM, etc) used by a particular broadcast service
        /// </summary>
        OneOrMany<string> BroadcastSignalModulation { get; set; }

        /// <summary>
        /// The subchannel used for the broadcast.
        /// </summary>
        OneOrMany<string> BroadcastSubChannel { get; set; }
    }

    /// <summary>
    /// The frequency in MHz and the modulation used for a particular BroadcastService.
    /// </summary>
    public partial class BroadcastFrequencySpecification : Intangible, IBroadcastFrequencySpecification
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "BroadcastFrequencySpecification";

        /// <summary>
        /// The frequency in MHz for a particular broadcast.
        /// </summary>
        [JsonPropertyName("broadcastFrequencyValue")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<double?, IQuantitativeValue> BroadcastFrequencyValue { get; set; }

        /// <summary>
        /// The modulation (e.g. FM, AM, etc) used by a particular broadcast service
        /// </summary>
        [JsonPropertyName("broadcastSignalModulation")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> BroadcastSignalModulation { get; set; }

        /// <summary>
        /// The subchannel used for the broadcast.
        /// </summary>
        [JsonPropertyName("broadcastSubChannel")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> BroadcastSubChannel { get; set; }
    }
}

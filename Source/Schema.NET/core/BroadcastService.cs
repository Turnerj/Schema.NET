namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A delivery service through which content is provided via broadcast over the air or online.
    /// </summary>
    public partial interface IBroadcastService : IService
    {
        /// <summary>
        /// The media network(s) whose content is broadcast on this station.
        /// </summary>
        OneOrMany<IOrganization> BroadcastAffiliateOf { get; set; }

        /// <summary>
        /// The name displayed in the channel guide. For many US affiliates, it is the network name.
        /// </summary>
        OneOrMany<string> BroadcastDisplayName { get; set; }

        /// <summary>
        /// The organization owning or operating the broadcast service.
        /// </summary>
        OneOrMany<IOrganization> Broadcaster { get; set; }

        /// <summary>
        /// The frequency used for over-the-air broadcasts. Numeric values or simple ranges e.g. 87-99. In addition a shortcut idiom is supported for frequences of AM and FM radio channels, e.g. "87 FM".
        /// </summary>
        Values<IBroadcastFrequencySpecification, string> BroadcastFrequency { get; set; }

        /// <summary>
        /// The timezone in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 format&lt;/a&gt; for which the service bases its broadcasts
        /// </summary>
        OneOrMany<string> BroadcastTimezone { get; set; }

        /// <summary>
        /// A &lt;a href="https://en.wikipedia.org/wiki/Call_sign"&gt;callsign&lt;/a&gt;, as used in broadcasting and radio communications to identify people, radio and TV stations, or vehicles.
        /// </summary>
        OneOrMany<string> CallSign { get; set; }

        /// <summary>
        /// A broadcast channel of a broadcast service.
        /// </summary>
        OneOrMany<IBroadcastChannel> HasBroadcastChannel { get; set; }

        /// <summary>
        /// A broadcast service to which the broadcast service may belong to such as regional variations of a national channel.
        /// </summary>
        OneOrMany<IBroadcastService> ParentService { get; set; }

        /// <summary>
        /// The type of screening or video broadcast used (e.g. IMAX, 3D, SD, HD, etc.).
        /// </summary>
        OneOrMany<string> VideoFormat { get; set; }
    }

    /// <summary>
    /// A delivery service through which content is provided via broadcast over the air or online.
    /// </summary>
    public partial class BroadcastService : Service, IBroadcastService
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "BroadcastService";

        /// <summary>
        /// The media network(s) whose content is broadcast on this station.
        /// </summary>
        [JsonPropertyName("broadcastAffiliateOf")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrganization> BroadcastAffiliateOf { get; set; }

        /// <summary>
        /// The name displayed in the channel guide. For many US affiliates, it is the network name.
        /// </summary>
        [JsonPropertyName("broadcastDisplayName")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> BroadcastDisplayName { get; set; }

        /// <summary>
        /// The organization owning or operating the broadcast service.
        /// </summary>
        [JsonPropertyName("broadcaster")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrganization> Broadcaster { get; set; }

        /// <summary>
        /// The frequency used for over-the-air broadcasts. Numeric values or simple ranges e.g. 87-99. In addition a shortcut idiom is supported for frequences of AM and FM radio channels, e.g. "87 FM".
        /// </summary>
        [JsonPropertyName("broadcastFrequency")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IBroadcastFrequencySpecification, string> BroadcastFrequency { get; set; }

        /// <summary>
        /// The timezone in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 format&lt;/a&gt; for which the service bases its broadcasts
        /// </summary>
        [JsonPropertyName("broadcastTimezone")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> BroadcastTimezone { get; set; }

        /// <summary>
        /// A &lt;a href="https://en.wikipedia.org/wiki/Call_sign"&gt;callsign&lt;/a&gt;, as used in broadcasting and radio communications to identify people, radio and TV stations, or vehicles.
        /// </summary>
        [JsonPropertyName("callSign")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> CallSign { get; set; }

        /// <summary>
        /// A broadcast channel of a broadcast service.
        /// </summary>
        [JsonPropertyName("hasBroadcastChannel")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IBroadcastChannel> HasBroadcastChannel { get; set; }

        /// <summary>
        /// A broadcast service to which the broadcast service may belong to such as regional variations of a national channel.
        /// </summary>
        [JsonPropertyName("parentService")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IBroadcastService> ParentService { get; set; }

        /// <summary>
        /// The type of screening or video broadcast used (e.g. IMAX, 3D, SD, HD, etc.).
        /// </summary>
        [JsonPropertyName("videoFormat")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> VideoFormat { get; set; }
    }
}

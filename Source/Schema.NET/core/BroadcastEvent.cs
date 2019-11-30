namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An over the air or online broadcast event.
    /// </summary>
    public partial interface IBroadcastEvent : IPublicationEvent
    {
        /// <summary>
        /// The event being broadcast such as a sporting event or awards ceremony.
        /// </summary>
        OneOrMany<IEvent> BroadcastOfEvent { get; set; }

        /// <summary>
        /// True is the broadcast is of a live event.
        /// </summary>
        OneOrMany<bool?> IsLiveBroadcast { get; set; }

        /// <summary>
        /// Languages in which subtitles/captions are available, in &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard format&lt;/a&gt;.
        /// </summary>
        Values<ILanguage, string> SubtitleLanguage { get; set; }

        /// <summary>
        /// The type of screening or video broadcast used (e.g. IMAX, 3D, SD, HD, etc.).
        /// </summary>
        OneOrMany<string> VideoFormat { get; set; }
    }

    /// <summary>
    /// An over the air or online broadcast event.
    /// </summary>
    public partial class BroadcastEvent : PublicationEvent, IBroadcastEvent
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "BroadcastEvent";

        /// <summary>
        /// The event being broadcast such as a sporting event or awards ceremony.
        /// </summary>
        [JsonPropertyName("broadcastOfEvent")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IEvent> BroadcastOfEvent { get; set; }

        /// <summary>
        /// True is the broadcast is of a live event.
        /// </summary>
        [JsonPropertyName("isLiveBroadcast")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<bool?> IsLiveBroadcast { get; set; }

        /// <summary>
        /// Languages in which subtitles/captions are available, in &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard format&lt;/a&gt;.
        /// </summary>
        [JsonPropertyName("subtitleLanguage")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ILanguage, string> SubtitleLanguage { get; set; }

        /// <summary>
        /// The type of screening or video broadcast used (e.g. IMAX, 3D, SD, HD, etc.).
        /// </summary>
        [JsonPropertyName("videoFormat")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> VideoFormat { get; set; }
    }
}

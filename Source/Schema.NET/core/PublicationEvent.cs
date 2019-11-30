namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A PublicationEvent corresponds indifferently to the event of publication for a CreativeWork of any type e.g. a broadcast event, an on-demand event, a book/journal publication via a variety of delivery media.
    /// </summary>
    public partial interface IPublicationEvent : IEvent
    {
        /// <summary>
        /// An agent associated with the publication event.
        /// </summary>
        Values<IOrganization, IPerson> PublishedBy { get; set; }

        /// <summary>
        /// A broadcast service associated with the publication event.
        /// </summary>
        OneOrMany<IBroadcastService> PublishedOn { get; set; }
    }

    /// <summary>
    /// A PublicationEvent corresponds indifferently to the event of publication for a CreativeWork of any type e.g. a broadcast event, an on-demand event, a book/journal publication via a variety of delivery media.
    /// </summary>
    public partial class PublicationEvent : Event, IPublicationEvent
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "PublicationEvent";

        /// <summary>
        /// A flag to signal that the item, event, or place is accessible for free.
        /// </summary>
        [JsonPropertyName("isAccessibleForFree")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<bool?> IsAccessibleForFree { get; set; }

        /// <summary>
        /// An agent associated with the publication event.
        /// </summary>
        [JsonPropertyName("publishedBy")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> PublishedBy { get; set; }

        /// <summary>
        /// A broadcast service associated with the publication event.
        /// </summary>
        [JsonPropertyName("publishedOn")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IBroadcastService> PublishedOn { get; set; }
    }
}

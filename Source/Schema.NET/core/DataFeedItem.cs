namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A single item within a larger data feed.
    /// </summary>
    public partial interface IDataFeedItem : IIntangible
    {
        /// <summary>
        /// The date on which the CreativeWork was created or the item was added to a DataFeed.
        /// </summary>
        Values<int?, DateTime?, DateTimeOffset?> DateCreated { get; set; }

        /// <summary>
        /// The datetime the item was removed from the DataFeed.
        /// </summary>
        Values<int?, DateTime?, DateTimeOffset?> DateDeleted { get; set; }

        /// <summary>
        /// The date on which the CreativeWork was most recently modified or when the item's entry was modified within a DataFeed.
        /// </summary>
        Values<int?, DateTime?, DateTimeOffset?> DateModified { get; set; }

        /// <summary>
        /// An entity represented by an entry in a list or data feed (e.g. an 'artist' in a list of 'artists')’.
        /// </summary>
        OneOrMany<IThing> Item { get; set; }
    }

    /// <summary>
    /// A single item within a larger data feed.
    /// </summary>
    public partial class DataFeedItem : Intangible, IDataFeedItem
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "DataFeedItem";

        /// <summary>
        /// The date on which the CreativeWork was created or the item was added to a DataFeed.
        /// </summary>
        [JsonPropertyName("dateCreated")]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, DateTimeOffset?> DateCreated { get; set; }

        /// <summary>
        /// The datetime the item was removed from the DataFeed.
        /// </summary>
        [JsonPropertyName("dateDeleted")]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, DateTimeOffset?> DateDeleted { get; set; }

        /// <summary>
        /// The date on which the CreativeWork was most recently modified or when the item's entry was modified within a DataFeed.
        /// </summary>
        [JsonPropertyName("dateModified")]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, DateTimeOffset?> DateModified { get; set; }

        /// <summary>
        /// An entity represented by an entry in a list or data feed (e.g. an 'artist' in a list of 'artists')’.
        /// </summary>
        [JsonPropertyName("item")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IThing> Item { get; set; }
    }
}

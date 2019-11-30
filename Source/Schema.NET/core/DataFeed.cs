namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A single feed providing structured information about one or more entities or topics.
    /// </summary>
    public partial interface IDataFeed : IDataset
    {
        /// <summary>
        /// An item within in a data feed. Data feeds may have many elements.
        /// </summary>
        Values<IDataFeedItem, string, IThing> DataFeedElement { get; set; }
    }

    /// <summary>
    /// A single feed providing structured information about one or more entities or topics.
    /// </summary>
    public partial class DataFeed : Dataset, IDataFeed
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "DataFeed";

        /// <summary>
        /// An item within in a data feed. Data feeds may have many elements.
        /// </summary>
        [JsonPropertyName("dataFeedElement")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IDataFeedItem, string, IThing> DataFeedElement { get; set; }
    }
}

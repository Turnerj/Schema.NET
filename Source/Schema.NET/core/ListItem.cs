namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An list item, e.g. a step in a checklist or how-to description.
    /// </summary>
    public partial interface IListItem : IIntangible
    {
        /// <summary>
        /// An entity represented by an entry in a list or data feed (e.g. an 'artist' in a list of 'artists')’.
        /// </summary>
        OneOrMany<IThing> Item { get; set; }

        /// <summary>
        /// A link to the ListItem that follows the current one.
        /// </summary>
        OneOrMany<IListItem> NextItem { get; set; }

        /// <summary>
        /// The position of an item in a series or sequence of items.
        /// </summary>
        Values<int?, string> Position { get; set; }

        /// <summary>
        /// A link to the ListItem that preceeds the current one.
        /// </summary>
        OneOrMany<IListItem> PreviousItem { get; set; }
    }

    /// <summary>
    /// An list item, e.g. a step in a checklist or how-to description.
    /// </summary>
    public partial class ListItem : Intangible, IListItem
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ListItem";

        /// <summary>
        /// An entity represented by an entry in a list or data feed (e.g. an 'artist' in a list of 'artists')’.
        /// </summary>
        [JsonPropertyName("item")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IThing> Item { get; set; }

        /// <summary>
        /// A link to the ListItem that follows the current one.
        /// </summary>
        [JsonPropertyName("nextItem")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IListItem> NextItem { get; set; }

        /// <summary>
        /// The position of an item in a series or sequence of items.
        /// </summary>
        [JsonPropertyName("position")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<int?, string> Position { get; set; }

        /// <summary>
        /// A link to the ListItem that preceeds the current one.
        /// </summary>
        [JsonPropertyName("previousItem")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IListItem> PreviousItem { get; set; }
    }
}

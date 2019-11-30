namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An item used as either a tool or supply when performing the instructions for how to to achieve a result.
    /// </summary>
    public partial interface IHowToItem : IListItem
    {
        /// <summary>
        /// The required quantity of the item(s).
        /// </summary>
        Values<double?, IQuantitativeValue, string> RequiredQuantity { get; set; }
    }

    /// <summary>
    /// An item used as either a tool or supply when performing the instructions for how to to achieve a result.
    /// </summary>
    public partial class HowToItem : ListItem, IHowToItem
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "HowToItem";

        /// <summary>
        /// The required quantity of the item(s).
        /// </summary>
        [JsonPropertyName("requiredQuantity")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<double?, IQuantitativeValue, string> RequiredQuantity { get; set; }
    }
}

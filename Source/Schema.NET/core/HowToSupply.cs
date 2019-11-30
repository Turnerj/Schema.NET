namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A supply consumed when performing the instructions for how to achieve a result.
    /// </summary>
    public partial interface IHowToSupply : IHowToItem
    {
        /// <summary>
        /// The estimated cost of the supply or supplies consumed when performing instructions.
        /// </summary>
        Values<IMonetaryAmount, string> EstimatedCost { get; set; }
    }

    /// <summary>
    /// A supply consumed when performing the instructions for how to achieve a result.
    /// </summary>
    public partial class HowToSupply : HowToItem, IHowToSupply
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "HowToSupply";

        /// <summary>
        /// The estimated cost of the supply or supplies consumed when performing instructions.
        /// </summary>
        [JsonPropertyName("estimatedCost")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMonetaryAmount, string> EstimatedCost { get; set; }
    }
}

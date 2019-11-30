namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of taking money from a buyer in exchange for goods or services rendered. An agent sells an object, product, or service to a buyer for a price. Reciprocal of BuyAction.
    /// </summary>
    public partial interface ISellAction : ITradeAction
    {
        /// <summary>
        /// A sub property of participant. The participant/person/organization that bought the object.
        /// </summary>
        OneOrMany<IPerson> Buyer { get; set; }
    }

    /// <summary>
    /// The act of taking money from a buyer in exchange for goods or services rendered. An agent sells an object, product, or service to a buyer for a price. Reciprocal of BuyAction.
    /// </summary>
    public partial class SellAction : TradeAction, ISellAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "SellAction";

        /// <summary>
        /// A sub property of participant. The participant/person/organization that bought the object.
        /// </summary>
        [JsonPropertyName("buyer")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Buyer { get; set; }
    }
}

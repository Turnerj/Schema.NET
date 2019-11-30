namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An agent orders an object/product/service to be delivered/sent.
    /// </summary>
    public partial interface IOrderAction : ITradeAction
    {
        /// <summary>
        /// A sub property of instrument. The method of delivery.
        /// </summary>
        OneOrMany<DeliveryMethod?> DeliveryMethod { get; set; }
    }

    /// <summary>
    /// An agent orders an object/product/service to be delivered/sent.
    /// </summary>
    public partial class OrderAction : TradeAction, IOrderAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "OrderAction";

        /// <summary>
        /// A sub property of instrument. The method of delivery.
        /// </summary>
        [JsonPropertyName("deliveryMethod")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DeliveryMethod?> DeliveryMethod { get; set; }
    }
}

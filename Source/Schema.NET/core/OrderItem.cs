namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An order item is a line of an order. It includes the quantity and shipping details of a bought offer.
    /// </summary>
    public partial interface IOrderItem : IIntangible
    {
        /// <summary>
        /// The delivery of the parcel related to this order or order item.
        /// </summary>
        OneOrMany<IParcelDelivery> OrderDelivery { get; set; }

        /// <summary>
        /// The item ordered.
        /// </summary>
        Values<IOrderItem, IProduct, IService> OrderedItem { get; set; }

        /// <summary>
        /// The identifier of the order item.
        /// </summary>
        OneOrMany<string> OrderItemNumber { get; set; }

        /// <summary>
        /// The current status of the order item.
        /// </summary>
        OneOrMany<OrderStatus?> OrderItemStatus { get; set; }

        /// <summary>
        /// The number of the item ordered. If the property is not set, assume the quantity is one.
        /// </summary>
        OneOrMany<double?> OrderQuantity { get; set; }
    }

    /// <summary>
    /// An order item is a line of an order. It includes the quantity and shipping details of a bought offer.
    /// </summary>
    public partial class OrderItem : Intangible, IOrderItem
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "OrderItem";

        /// <summary>
        /// The delivery of the parcel related to this order or order item.
        /// </summary>
        [JsonPropertyName("orderDelivery")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IParcelDelivery> OrderDelivery { get; set; }

        /// <summary>
        /// The item ordered.
        /// </summary>
        [JsonPropertyName("orderedItem")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrderItem, IProduct, IService> OrderedItem { get; set; }

        /// <summary>
        /// The identifier of the order item.
        /// </summary>
        [JsonPropertyName("orderItemNumber")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> OrderItemNumber { get; set; }

        /// <summary>
        /// The current status of the order item.
        /// </summary>
        [JsonPropertyName("orderItemStatus")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<OrderStatus?> OrderItemStatus { get; set; }

        /// <summary>
        /// The number of the item ordered. If the property is not set, assume the quantity is one.
        /// </summary>
        [JsonPropertyName("orderQuantity")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<double?> OrderQuantity { get; set; }
    }
}

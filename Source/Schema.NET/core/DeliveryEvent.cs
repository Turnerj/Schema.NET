namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An event involving the delivery of an item.
    /// </summary>
    public partial interface IDeliveryEvent : IEvent
    {
        /// <summary>
        /// Password, PIN, or access code needed for delivery (e.g. from a locker).
        /// </summary>
        OneOrMany<string> AccessCode { get; set; }

        /// <summary>
        /// When the item is available for pickup from the store, locker, etc.
        /// </summary>
        OneOrMany<DateTimeOffset?> AvailableFrom { get; set; }

        /// <summary>
        /// After this date, the item will no longer be available for pickup.
        /// </summary>
        OneOrMany<DateTimeOffset?> AvailableThrough { get; set; }

        /// <summary>
        /// Method used for delivery or shipping.
        /// </summary>
        OneOrMany<DeliveryMethod?> HasDeliveryMethod { get; set; }
    }

    /// <summary>
    /// An event involving the delivery of an item.
    /// </summary>
    public partial class DeliveryEvent : Event, IDeliveryEvent
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "DeliveryEvent";

        /// <summary>
        /// Password, PIN, or access code needed for delivery (e.g. from a locker).
        /// </summary>
        [JsonPropertyName("accessCode")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> AccessCode { get; set; }

        /// <summary>
        /// When the item is available for pickup from the store, locker, etc.
        /// </summary>
        [JsonPropertyName("availableFrom")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DateTimeOffset?> AvailableFrom { get; set; }

        /// <summary>
        /// After this date, the item will no longer be available for pickup.
        /// </summary>
        [JsonPropertyName("availableThrough")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DateTimeOffset?> AvailableThrough { get; set; }

        /// <summary>
        /// Method used for delivery or shipping.
        /// </summary>
        [JsonPropertyName("hasDeliveryMethod")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DeliveryMethod?> HasDeliveryMethod { get; set; }
    }
}

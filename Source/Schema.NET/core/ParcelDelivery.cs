namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The delivery of a parcel either via the postal service or a commercial service.
    /// </summary>
    public partial interface IParcelDelivery : IIntangible
    {
        /// <summary>
        /// Destination address.
        /// </summary>
        OneOrMany<IPostalAddress> DeliveryAddress { get; set; }

        /// <summary>
        /// New entry added as the package passes through each leg of its journey (from shipment to final delivery).
        /// </summary>
        OneOrMany<IDeliveryEvent> DeliveryStatus { get; set; }

        /// <summary>
        /// The earliest date the package may arrive.
        /// </summary>
        Values<int?, DateTime?, DateTimeOffset?> ExpectedArrivalFrom { get; set; }

        /// <summary>
        /// The latest date the package may arrive.
        /// </summary>
        Values<int?, DateTime?, DateTimeOffset?> ExpectedArrivalUntil { get; set; }

        /// <summary>
        /// Method used for delivery or shipping.
        /// </summary>
        OneOrMany<DeliveryMethod?> HasDeliveryMethod { get; set; }

        /// <summary>
        /// Item(s) being shipped.
        /// </summary>
        OneOrMany<IProduct> ItemShipped { get; set; }

        /// <summary>
        /// Shipper's address.
        /// </summary>
        OneOrMany<IPostalAddress> OriginAddress { get; set; }

        /// <summary>
        /// The overall order the items in this delivery were included in.
        /// </summary>
        OneOrMany<IOrder> PartOfOrder { get; set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        Values<IOrganization, IPerson> Provider { get; set; }

        /// <summary>
        /// Shipper tracking number.
        /// </summary>
        OneOrMany<string> TrackingNumber { get; set; }

        /// <summary>
        /// Tracking url for the parcel delivery.
        /// </summary>
        OneOrMany<Uri> TrackingUrl { get; set; }
    }

    /// <summary>
    /// The delivery of a parcel either via the postal service or a commercial service.
    /// </summary>
    public partial class ParcelDelivery : Intangible, IParcelDelivery
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ParcelDelivery";

        /// <summary>
        /// Destination address.
        /// </summary>
        [JsonPropertyName("deliveryAddress")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPostalAddress> DeliveryAddress { get; set; }

        /// <summary>
        /// New entry added as the package passes through each leg of its journey (from shipment to final delivery).
        /// </summary>
        [JsonPropertyName("deliveryStatus")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IDeliveryEvent> DeliveryStatus { get; set; }

        /// <summary>
        /// The earliest date the package may arrive.
        /// </summary>
        [JsonPropertyName("expectedArrivalFrom")]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, DateTimeOffset?> ExpectedArrivalFrom { get; set; }

        /// <summary>
        /// The latest date the package may arrive.
        /// </summary>
        [JsonPropertyName("expectedArrivalUntil")]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, DateTimeOffset?> ExpectedArrivalUntil { get; set; }

        /// <summary>
        /// Method used for delivery or shipping.
        /// </summary>
        [JsonPropertyName("hasDeliveryMethod")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DeliveryMethod?> HasDeliveryMethod { get; set; }

        /// <summary>
        /// Item(s) being shipped.
        /// </summary>
        [JsonPropertyName("itemShipped")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IProduct> ItemShipped { get; set; }

        /// <summary>
        /// Shipper's address.
        /// </summary>
        [JsonPropertyName("originAddress")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPostalAddress> OriginAddress { get; set; }

        /// <summary>
        /// The overall order the items in this delivery were included in.
        /// </summary>
        [JsonPropertyName("partOfOrder")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrder> PartOfOrder { get; set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [JsonPropertyName("provider")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Provider { get; set; }

        /// <summary>
        /// Shipper tracking number.
        /// </summary>
        [JsonPropertyName("trackingNumber")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> TrackingNumber { get; set; }

        /// <summary>
        /// Tracking url for the parcel delivery.
        /// </summary>
        [JsonPropertyName("trackingUrl")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<Uri> TrackingUrl { get; set; }
    }
}

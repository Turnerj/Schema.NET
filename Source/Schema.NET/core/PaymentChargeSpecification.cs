namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The costs of settling the payment using a particular payment method.
    /// </summary>
    public partial interface IPaymentChargeSpecification : IPriceSpecification
    {
        /// <summary>
        /// The delivery method(s) to which the delivery charge or payment charge specification applies.
        /// </summary>
        OneOrMany<DeliveryMethod?> AppliesToDeliveryMethod { get; set; }

        /// <summary>
        /// The payment method(s) to which the payment charge specification applies.
        /// </summary>
        OneOrMany<PaymentMethod?> AppliesToPaymentMethod { get; set; }
    }

    /// <summary>
    /// The costs of settling the payment using a particular payment method.
    /// </summary>
    public partial class PaymentChargeSpecification : PriceSpecification, IPaymentChargeSpecification
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "PaymentChargeSpecification";

        /// <summary>
        /// The delivery method(s) to which the delivery charge or payment charge specification applies.
        /// </summary>
        [JsonPropertyName("appliesToDeliveryMethod")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DeliveryMethod?> AppliesToDeliveryMethod { get; set; }

        /// <summary>
        /// The payment method(s) to which the payment charge specification applies.
        /// </summary>
        [JsonPropertyName("appliesToPaymentMethod")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<PaymentMethod?> AppliesToPaymentMethod { get; set; }
    }
}

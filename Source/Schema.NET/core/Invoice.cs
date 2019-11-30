namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A statement of the money due for goods or services; a bill.
    /// </summary>
    public partial interface IInvoice : IIntangible
    {
        /// <summary>
        /// The identifier for the account the payment will be applied to.
        /// </summary>
        OneOrMany<string> AccountId { get; set; }

        /// <summary>
        /// The time interval used to compute the invoice.
        /// </summary>
        OneOrMany<TimeSpan?> BillingPeriod { get; set; }

        /// <summary>
        /// An entity that arranges for an exchange between a buyer and a seller.  In most cases a broker never acquires or releases ownership of a product or service involved in an exchange.  If it is not clear whether an entity is a broker, seller, or buyer, the latter two terms are preferred.
        /// </summary>
        Values<IOrganization, IPerson> Broker { get; set; }

        /// <summary>
        /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
        /// </summary>
        Values<PhysicalActivityCategory?, string, IThing> Category { get; set; }

        /// <summary>
        /// A number that confirms the given order or payment has been received.
        /// </summary>
        OneOrMany<string> ConfirmationNumber { get; set; }

        /// <summary>
        /// Party placing the order or paying the invoice.
        /// </summary>
        Values<IOrganization, IPerson> Customer { get; set; }

        /// <summary>
        /// The minimum payment required at this time.
        /// </summary>
        Values<IMonetaryAmount, IPriceSpecification> MinimumPaymentDue { get; set; }

        /// <summary>
        /// The date that payment is due.
        /// </summary>
        Values<int?, DateTime?, DateTimeOffset?> PaymentDueDate { get; set; }

        /// <summary>
        /// The name of the credit card or other method of payment for the order.
        /// </summary>
        OneOrMany<PaymentMethod?> PaymentMethod { get; set; }

        /// <summary>
        /// An identifier for the method of payment used (e.g. the last 4 digits of the credit card).
        /// </summary>
        OneOrMany<string> PaymentMethodId { get; set; }

        /// <summary>
        /// The status of payment; whether the invoice has been paid or not.
        /// </summary>
        Values<PaymentStatusType?, string> PaymentStatus { get; set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        Values<IOrganization, IPerson> Provider { get; set; }

        /// <summary>
        /// The Order(s) related to this Invoice. One or more Orders may be combined into a single Invoice.
        /// </summary>
        OneOrMany<IOrder> ReferencesOrder { get; set; }

        /// <summary>
        /// The date the invoice is scheduled to be paid.
        /// </summary>
        Values<int?, DateTime?> ScheduledPaymentDate { get; set; }

        /// <summary>
        /// The total amount due.
        /// </summary>
        Values<IMonetaryAmount, IPriceSpecification> TotalPaymentDue { get; set; }
    }

    /// <summary>
    /// A statement of the money due for goods or services; a bill.
    /// </summary>
    public partial class Invoice : Intangible, IInvoice
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Invoice";

        /// <summary>
        /// The identifier for the account the payment will be applied to.
        /// </summary>
        [JsonPropertyName("accountId")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> AccountId { get; set; }

        /// <summary>
        /// The time interval used to compute the invoice.
        /// </summary>
        [JsonPropertyName("billingPeriod")]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesJsonConverter))]
        public OneOrMany<TimeSpan?> BillingPeriod { get; set; }

        /// <summary>
        /// An entity that arranges for an exchange between a buyer and a seller.  In most cases a broker never acquires or releases ownership of a product or service involved in an exchange.  If it is not clear whether an entity is a broker, seller, or buyer, the latter two terms are preferred.
        /// </summary>
        [JsonPropertyName("broker")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Broker { get; set; }

        /// <summary>
        /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
        /// </summary>
        [JsonPropertyName("category")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<PhysicalActivityCategory?, string, IThing> Category { get; set; }

        /// <summary>
        /// A number that confirms the given order or payment has been received.
        /// </summary>
        [JsonPropertyName("confirmationNumber")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ConfirmationNumber { get; set; }

        /// <summary>
        /// Party placing the order or paying the invoice.
        /// </summary>
        [JsonPropertyName("customer")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Customer { get; set; }

        /// <summary>
        /// The minimum payment required at this time.
        /// </summary>
        [JsonPropertyName("minimumPaymentDue")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMonetaryAmount, IPriceSpecification> MinimumPaymentDue { get; set; }

        /// <summary>
        /// The date that payment is due.
        /// </summary>
        [JsonPropertyName("paymentDueDate")]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, DateTimeOffset?> PaymentDueDate { get; set; }

        /// <summary>
        /// The name of the credit card or other method of payment for the order.
        /// </summary>
        [JsonPropertyName("paymentMethod")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<PaymentMethod?> PaymentMethod { get; set; }

        /// <summary>
        /// An identifier for the method of payment used (e.g. the last 4 digits of the credit card).
        /// </summary>
        [JsonPropertyName("paymentMethodId")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> PaymentMethodId { get; set; }

        /// <summary>
        /// The status of payment; whether the invoice has been paid or not.
        /// </summary>
        [JsonPropertyName("paymentStatus")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<PaymentStatusType?, string> PaymentStatus { get; set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [JsonPropertyName("provider")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Provider { get; set; }

        /// <summary>
        /// The Order(s) related to this Invoice. One or more Orders may be combined into a single Invoice.
        /// </summary>
        [JsonPropertyName("referencesOrder")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrder> ReferencesOrder { get; set; }

        /// <summary>
        /// The date the invoice is scheduled to be paid.
        /// </summary>
        [JsonPropertyName("scheduledPaymentDate")]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?> ScheduledPaymentDate { get; set; }

        /// <summary>
        /// The total amount due.
        /// </summary>
        [JsonPropertyName("totalPaymentDue")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMonetaryAmount, IPriceSpecification> TotalPaymentDue { get; set; }
    }
}

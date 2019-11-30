namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A Service to transfer funds from a person or organization to a beneficiary person or organization.
    /// </summary>
    public partial interface IPaymentService : IFinancialProduct
    {
    }

    /// <summary>
    /// A Service to transfer funds from a person or organization to a beneficiary person or organization.
    /// </summary>
    public partial class PaymentService : FinancialProduct, IPaymentService
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "PaymentService";
    }
}

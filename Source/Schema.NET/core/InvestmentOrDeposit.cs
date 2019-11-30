namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A type of financial product that typically requires the client to transfer funds to a financial service in return for potential beneficial financial return.
    /// </summary>
    public partial interface IInvestmentOrDeposit : IFinancialProduct
    {
        /// <summary>
        /// The amount of money.
        /// </summary>
        Values<IMonetaryAmount, decimal?> Amount { get; set; }
    }

    /// <summary>
    /// A type of financial product that typically requires the client to transfer funds to a financial service in return for potential beneficial financial return.
    /// </summary>
    public partial class InvestmentOrDeposit : FinancialProduct, IInvestmentOrDeposit
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "InvestmentOrDeposit";

        /// <summary>
        /// The amount of money.
        /// </summary>
        [JsonPropertyName("amount")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMonetaryAmount, decimal?> Amount { get; set; }
    }
}

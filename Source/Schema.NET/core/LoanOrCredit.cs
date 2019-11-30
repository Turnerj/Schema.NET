namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A financial product for the loaning of an amount of money under agreed terms and charges.
    /// </summary>
    public partial interface ILoanOrCredit : IFinancialProduct
    {
        /// <summary>
        /// The amount of money.
        /// </summary>
        Values<IMonetaryAmount, decimal?> Amount { get; set; }

        /// <summary>
        /// The currency in which the monetary amount is expressed.&lt;br/&gt;&lt;br/&gt;
        /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".
        /// </summary>
        OneOrMany<string> Currency { get; set; }

        /// <summary>
        /// The period of time after any due date that the borrower has to fulfil its obligations before a default (failure to pay) is deemed to have occurred.
        /// </summary>
        OneOrMany<TimeSpan?> GracePeriod { get; set; }

        /// <summary>
        /// The duration of the loan or credit agreement.
        /// </summary>
        OneOrMany<IQuantitativeValue> LoanTerm { get; set; }

        /// <summary>
        /// The type of a loan or credit.
        /// </summary>
        Values<string, Uri> LoanType { get; set; }

        /// <summary>
        /// The only way you get the money back in the event of default is the security. Recourse is where you still have the opportunity to go back to the borrower for the rest of the money.
        /// </summary>
        OneOrMany<bool?> RecourseLoan { get; set; }

        /// <summary>
        /// Whether the terms for payment of interest can be renegotiated during the life of the loan.
        /// </summary>
        OneOrMany<bool?> RenegotiableLoan { get; set; }

        /// <summary>
        /// Assets required to secure loan or credit repayments. It may take form of third party pledge, goods, financial instruments (cash, securities, etc.)
        /// </summary>
        Values<string, IThing> RequiredCollateral { get; set; }
    }

    /// <summary>
    /// A financial product for the loaning of an amount of money under agreed terms and charges.
    /// </summary>
    public partial class LoanOrCredit : FinancialProduct, ILoanOrCredit
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "LoanOrCredit";

        /// <summary>
        /// The amount of money.
        /// </summary>
        [JsonPropertyName("amount")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMonetaryAmount, decimal?> Amount { get; set; }

        /// <summary>
        /// The currency in which the monetary amount is expressed.&lt;br/&gt;&lt;br/&gt;
        /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".
        /// </summary>
        [JsonPropertyName("currency")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Currency { get; set; }

        /// <summary>
        /// The period of time after any due date that the borrower has to fulfil its obligations before a default (failure to pay) is deemed to have occurred.
        /// </summary>
        [JsonPropertyName("gracePeriod")]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesJsonConverter))]
        public OneOrMany<TimeSpan?> GracePeriod { get; set; }

        /// <summary>
        /// The duration of the loan or credit agreement.
        /// </summary>
        [JsonPropertyName("loanTerm")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> LoanTerm { get; set; }

        /// <summary>
        /// The type of a loan or credit.
        /// </summary>
        [JsonPropertyName("loanType")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> LoanType { get; set; }

        /// <summary>
        /// The only way you get the money back in the event of default is the security. Recourse is where you still have the opportunity to go back to the borrower for the rest of the money.
        /// </summary>
        [JsonPropertyName("recourseLoan")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<bool?> RecourseLoan { get; set; }

        /// <summary>
        /// Whether the terms for payment of interest can be renegotiated during the life of the loan.
        /// </summary>
        [JsonPropertyName("renegotiableLoan")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<bool?> RenegotiableLoan { get; set; }

        /// <summary>
        /// Assets required to secure loan or credit repayments. It may take form of third party pledge, goods, financial instruments (cash, securities, etc.)
        /// </summary>
        [JsonPropertyName("requiredCollateral")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, IThing> RequiredCollateral { get; set; }
    }
}

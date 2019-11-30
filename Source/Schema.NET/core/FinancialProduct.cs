namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A product provided to consumers and businesses by financial institutions such as banks, insurance companies, brokerage firms, consumer finance companies, and investment companies which comprise the financial services industry.
    /// </summary>
    public partial interface IFinancialProduct : IService
    {
        /// <summary>
        /// The annual rate that is charged for borrowing (or made by investing), expressed as a single percentage number that represents the actual yearly cost of funds over the term of a loan. This includes any fees or additional costs associated with the transaction.
        /// </summary>
        Values<double?, IQuantitativeValue> AnnualPercentageRate { get; set; }

        /// <summary>
        /// Description of fees, commissions, and other terms applied either to a class of financial product, or by a financial service organization.
        /// </summary>
        Values<string, Uri> FeesAndCommissionsSpecification { get; set; }

        /// <summary>
        /// The interest rate, charged or paid, applicable to the financial product. Note: This is different from the calculated annualPercentageRate.
        /// </summary>
        Values<double?, IQuantitativeValue> InterestRate { get; set; }
    }

    /// <summary>
    /// A product provided to consumers and businesses by financial institutions such as banks, insurance companies, brokerage firms, consumer finance companies, and investment companies which comprise the financial services industry.
    /// </summary>
    public partial class FinancialProduct : Service, IFinancialProduct
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "FinancialProduct";

        /// <summary>
        /// The annual rate that is charged for borrowing (or made by investing), expressed as a single percentage number that represents the actual yearly cost of funds over the term of a loan. This includes any fees or additional costs associated with the transaction.
        /// </summary>
        [JsonPropertyName("annualPercentageRate")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<double?, IQuantitativeValue> AnnualPercentageRate { get; set; }

        /// <summary>
        /// Description of fees, commissions, and other terms applied either to a class of financial product, or by a financial service organization.
        /// </summary>
        [JsonPropertyName("feesAndCommissionsSpecification")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> FeesAndCommissionsSpecification { get; set; }

        /// <summary>
        /// The interest rate, charged or paid, applicable to the financial product. Note: This is different from the calculated annualPercentageRate.
        /// </summary>
        [JsonPropertyName("interestRate")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<double?, IQuantitativeValue> InterestRate { get; set; }
    }
}

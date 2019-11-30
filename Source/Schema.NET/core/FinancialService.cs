namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Financial services business.
    /// </summary>
    public partial interface IFinancialService : ILocalBusiness
    {
        /// <summary>
        /// Description of fees, commissions, and other terms applied either to a class of financial product, or by a financial service organization.
        /// </summary>
        Values<string, Uri> FeesAndCommissionsSpecification { get; set; }
    }

    /// <summary>
    /// Financial services business.
    /// </summary>
    public partial class FinancialService : LocalBusiness, IFinancialService
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "FinancialService";

        /// <summary>
        /// Description of fees, commissions, and other terms applied either to a class of financial product, or by a financial service organization.
        /// </summary>
        [JsonPropertyName("feesAndCommissionsSpecification")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> FeesAndCommissionsSpecification { get; set; }
    }
}

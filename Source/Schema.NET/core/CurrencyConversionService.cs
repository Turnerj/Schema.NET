namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A service to convert funds from one currency to another currency.
    /// </summary>
    public partial interface ICurrencyConversionService : IFinancialProduct
    {
    }

    /// <summary>
    /// A service to convert funds from one currency to another currency.
    /// </summary>
    public partial class CurrencyConversionService : FinancialProduct, ICurrencyConversionService
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "CurrencyConversionService";
    }
}

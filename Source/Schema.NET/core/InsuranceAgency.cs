namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An Insurance agency.
    /// </summary>
    public partial interface IInsuranceAgency : IFinancialService
    {
    }

    /// <summary>
    /// An Insurance agency.
    /// </summary>
    public partial class InsuranceAgency : FinancialService, IInsuranceAgency
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "InsuranceAgency";
    }
}

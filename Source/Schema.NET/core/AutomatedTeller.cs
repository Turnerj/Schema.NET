namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// ATM/cash machine.
    /// </summary>
    public partial interface IAutomatedTeller : IFinancialService
    {
    }

    /// <summary>
    /// ATM/cash machine.
    /// </summary>
    public partial class AutomatedTeller : FinancialService, IAutomatedTeller
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "AutomatedTeller";
    }
}

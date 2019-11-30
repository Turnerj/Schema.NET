﻿namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Bank or credit union.
    /// </summary>
    public partial interface IBankOrCreditUnion : IFinancialService
    {
    }

    /// <summary>
    /// Bank or credit union.
    /// </summary>
    public partial class BankOrCreditUnion : FinancialService, IBankOrCreditUnion
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "BankOrCreditUnion";
    }
}

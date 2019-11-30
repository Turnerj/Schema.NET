namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A type of Bank Account with a main purpose of depositing funds to gain interest or other benefits.
    /// </summary>
    public partial interface IDepositAccount : IBankAccountAndInvestmentOrDeposit
    {
    }

    /// <summary>
    /// A type of Bank Account with a main purpose of depositing funds to gain interest or other benefits.
    /// </summary>
    public partial class DepositAccount : BankAccountAndInvestmentOrDeposit, IDepositAccount
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "DepositAccount";
    }
}

namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// See BankAccount, InvestmentOrDeposit for more information.
    /// </summary>
    public partial interface IBankAccountAndInvestmentOrDeposit : IBankAccount, IInvestmentOrDeposit
    {
    }

    /// <summary>
    /// See BankAccount, InvestmentOrDeposit for more information.
    /// </summary>
    public abstract partial class BankAccountAndInvestmentOrDeposit : FinancialProduct, IBankAccountAndInvestmentOrDeposit
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "BankAccountAndInvestmentOrDeposit";

        /// <summary>
        /// A minimum amount that has to be paid in every month.
        /// </summary>
        [JsonPropertyName("accountMinimumInflow")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMonetaryAmount> AccountMinimumInflow { get; set; }

        /// <summary>
        /// An overdraft is an extension of credit from a lending institution when an account reaches zero. An overdraft allows the individual to continue withdrawing money even if the account has no funds in it. Basically the bank allows people to borrow a set amount of money.
        /// </summary>
        [JsonPropertyName("accountOverdraftLimit")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMonetaryAmount> AccountOverdraftLimit { get; set; }

        /// <summary>
        /// The amount of money.
        /// </summary>
        [JsonPropertyName("amount")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMonetaryAmount, decimal?> Amount { get; set; }

        /// <summary>
        /// The type of a bank account.
        /// </summary>
        [JsonPropertyName("bankAccountType")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> BankAccountType { get; set; }
    }
}

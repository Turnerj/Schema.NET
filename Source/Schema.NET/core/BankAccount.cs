namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A product or service offered by a bank whereby one may deposit, withdraw or transfer money and in some cases be paid interest.
    /// </summary>
    public partial interface IBankAccount : IFinancialProduct
    {
        /// <summary>
        /// A minimum amount that has to be paid in every month.
        /// </summary>
        OneOrMany<IMonetaryAmount> AccountMinimumInflow { get; set; }

        /// <summary>
        /// An overdraft is an extension of credit from a lending institution when an account reaches zero. An overdraft allows the individual to continue withdrawing money even if the account has no funds in it. Basically the bank allows people to borrow a set amount of money.
        /// </summary>
        OneOrMany<IMonetaryAmount> AccountOverdraftLimit { get; set; }

        /// <summary>
        /// The type of a bank account.
        /// </summary>
        Values<string, Uri> BankAccountType { get; set; }
    }

    /// <summary>
    /// A product or service offered by a bank whereby one may deposit, withdraw or transfer money and in some cases be paid interest.
    /// </summary>
    public partial class BankAccount : FinancialProduct, IBankAccount
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "BankAccount";

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
        /// The type of a bank account.
        /// </summary>
        [JsonPropertyName("bankAccountType")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> BankAccountType { get; set; }
    }
}

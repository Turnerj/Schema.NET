namespace Schema.NET
{
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A payment method using a credit, debit, store or other card to associate the payment with an account.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PaymentCard
    {
    }
}

namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Auto body shop.
    /// </summary>
    public partial interface IAutoBodyShop : IAutomotiveBusiness
    {
    }

    /// <summary>
    /// Auto body shop.
    /// </summary>
    public partial class AutoBodyShop : AutomotiveBusiness, IAutoBodyShop
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "AutoBodyShop";
    }
}

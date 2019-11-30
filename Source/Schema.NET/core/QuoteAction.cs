namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An agent quotes/estimates/appraises an object/product/service with a price at a location/store.
    /// </summary>
    public partial interface IQuoteAction : ITradeAction
    {
    }

    /// <summary>
    /// An agent quotes/estimates/appraises an object/product/service with a price at a location/store.
    /// </summary>
    public partial class QuoteAction : TradeAction, IQuoteAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "QuoteAction";
    }
}

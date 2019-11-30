namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An agent orders a (not yet released) object/product/service to be delivered/sent.
    /// </summary>
    public partial interface IPreOrderAction : ITradeAction
    {
    }

    /// <summary>
    /// An agent orders a (not yet released) object/product/service to be delivered/sent.
    /// </summary>
    public partial class PreOrderAction : TradeAction, IPreOrderAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "PreOrderAction";
    }
}

namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Event type: Sales event.
    /// </summary>
    public partial interface ISaleEvent : IEvent
    {
    }

    /// <summary>
    /// Event type: Sales event.
    /// </summary>
    public partial class SaleEvent : Event, ISaleEvent
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "SaleEvent";
    }
}

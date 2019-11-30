namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Event type: Business event.
    /// </summary>
    public partial interface IBusinessEvent : IEvent
    {
    }

    /// <summary>
    /// Event type: Business event.
    /// </summary>
    public partial class BusinessEvent : Event, IBusinessEvent
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "BusinessEvent";
    }
}

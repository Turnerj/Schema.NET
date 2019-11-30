namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Event type: Comedy event.
    /// </summary>
    public partial interface IComedyEvent : IEvent
    {
    }

    /// <summary>
    /// Event type: Comedy event.
    /// </summary>
    public partial class ComedyEvent : Event, IComedyEvent
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ComedyEvent";
    }
}

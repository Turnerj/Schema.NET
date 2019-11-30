namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Event type: A social dance.
    /// </summary>
    public partial interface IDanceEvent : IEvent
    {
    }

    /// <summary>
    /// Event type: A social dance.
    /// </summary>
    public partial class DanceEvent : Event, IDanceEvent
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "DanceEvent";
    }
}

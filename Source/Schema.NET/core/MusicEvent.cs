namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Event type: Music event.
    /// </summary>
    public partial interface IMusicEvent : IEvent
    {
    }

    /// <summary>
    /// Event type: Music event.
    /// </summary>
    public partial class MusicEvent : Event, IMusicEvent
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "MusicEvent";
    }
}

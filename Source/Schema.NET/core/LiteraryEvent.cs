namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Event type: Literary event.
    /// </summary>
    public partial interface ILiteraryEvent : IEvent
    {
    }

    /// <summary>
    /// Event type: Literary event.
    /// </summary>
    public partial class LiteraryEvent : Event, ILiteraryEvent
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "LiteraryEvent";
    }
}

namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Event type: Visual arts event.
    /// </summary>
    public partial interface IVisualArtsEvent : IEvent
    {
    }

    /// <summary>
    /// Event type: Visual arts event.
    /// </summary>
    public partial class VisualArtsEvent : Event, IVisualArtsEvent
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "VisualArtsEvent";
    }
}

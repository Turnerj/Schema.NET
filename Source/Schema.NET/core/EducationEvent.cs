namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Event type: Education event.
    /// </summary>
    public partial interface IEducationEvent : IEvent
    {
    }

    /// <summary>
    /// Event type: Education event.
    /// </summary>
    public partial class EducationEvent : Event, IEducationEvent
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "EducationEvent";
    }
}

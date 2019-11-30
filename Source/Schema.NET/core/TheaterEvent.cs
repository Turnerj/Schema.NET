namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Event type: Theater performance.
    /// </summary>
    public partial interface ITheaterEvent : IEvent
    {
    }

    /// <summary>
    /// Event type: Theater performance.
    /// </summary>
    public partial class TheaterEvent : Event, ITheaterEvent
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "TheaterEvent";
    }
}

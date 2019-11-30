namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Event type: Social event.
    /// </summary>
    public partial interface ISocialEvent : IEvent
    {
    }

    /// <summary>
    /// Event type: Social event.
    /// </summary>
    public partial class SocialEvent : Event, ISocialEvent
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "SocialEvent";
    }
}

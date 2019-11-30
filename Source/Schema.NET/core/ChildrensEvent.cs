namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Event type: Children's event.
    /// </summary>
    public partial interface IChildrensEvent : IEvent
    {
    }

    /// <summary>
    /// Event type: Children's event.
    /// </summary>
    public partial class ChildrensEvent : Event, IChildrensEvent
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ChildrensEvent";
    }
}

namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Event type: Exhibition event, e.g. at a museum, library, archive, tradeshow, ...
    /// </summary>
    public partial interface IExhibitionEvent : IEvent
    {
    }

    /// <summary>
    /// Event type: Exhibition event, e.g. at a museum, library, archive, tradeshow, ...
    /// </summary>
    public partial class ExhibitionEvent : Event, IExhibitionEvent
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ExhibitionEvent";
    }
}

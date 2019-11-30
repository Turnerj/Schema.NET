namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Event type: Food event.
    /// </summary>
    public partial interface IFoodEvent : IEvent
    {
    }

    /// <summary>
    /// Event type: Food event.
    /// </summary>
    public partial class FoodEvent : Event, IFoodEvent
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "FoodEvent";
    }
}

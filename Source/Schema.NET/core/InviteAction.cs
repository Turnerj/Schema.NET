namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of asking someone to attend an event. Reciprocal of RsvpAction.
    /// </summary>
    public partial interface IInviteAction : ICommunicateAction
    {
        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        OneOrMany<IEvent> Event { get; set; }
    }

    /// <summary>
    /// The act of asking someone to attend an event. Reciprocal of RsvpAction.
    /// </summary>
    public partial class InviteAction : CommunicateAction, IInviteAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "InviteAction";

        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        [JsonPropertyName("event")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IEvent> Event { get; set; }
    }
}

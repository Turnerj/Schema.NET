namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of notifying an event organizer as to whether you expect to attend the event.
    /// </summary>
    public partial interface IRsvpAction : IInformAction
    {
        /// <summary>
        /// If responding yes, the number of guests who will attend in addition to the invitee.
        /// </summary>
        OneOrMany<int?> AdditionalNumberOfGuests { get; set; }

        /// <summary>
        /// Comments, typically from users.
        /// </summary>
        OneOrMany<IComment> Comment { get; set; }

        /// <summary>
        /// The response (yes, no, maybe) to the RSVP.
        /// </summary>
        OneOrMany<RsvpResponseType?> RsvpResponse { get; set; }
    }

    /// <summary>
    /// The act of notifying an event organizer as to whether you expect to attend the event.
    /// </summary>
    public partial class RsvpAction : InformAction, IRsvpAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "RsvpAction";

        /// <summary>
        /// If responding yes, the number of guests who will attend in addition to the invitee.
        /// </summary>
        [JsonPropertyName("additionalNumberOfGuests")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> AdditionalNumberOfGuests { get; set; }

        /// <summary>
        /// Comments, typically from users.
        /// </summary>
        [JsonPropertyName("comment")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IComment> Comment { get; set; }

        /// <summary>
        /// The response (yes, no, maybe) to the RSVP.
        /// </summary>
        [JsonPropertyName("rsvpResponse")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<RsvpResponseType?> RsvpResponse { get; set; }
    }
}

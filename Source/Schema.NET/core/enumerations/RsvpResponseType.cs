namespace Schema.NET
{
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    /// <summary>
    /// RsvpResponseType is an enumeration type whose instances represent responding to an RSVP request.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RsvpResponseType
    {
        /// <summary>
        /// The invitee may or may not attend.
        /// </summary>
        [EnumMember(Value = "https://schema.org/RsvpResponseMaybe")]
        RsvpResponseMaybe,

        /// <summary>
        /// The invitee will not attend.
        /// </summary>
        [EnumMember(Value = "https://schema.org/RsvpResponseNo")]
        RsvpResponseNo,

        /// <summary>
        /// The invitee will attend.
        /// </summary>
        [EnumMember(Value = "https://schema.org/RsvpResponseYes")]
        RsvpResponseYes
    }
}

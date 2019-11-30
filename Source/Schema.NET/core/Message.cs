namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A single message from a sender to one or more organizations or people.
    /// </summary>
    public partial interface IMessage : ICreativeWork
    {
        /// <summary>
        /// A sub property of recipient. The recipient blind copied on a message.
        /// </summary>
        Values<IContactPoint, IOrganization, IPerson> BccRecipient { get; set; }

        /// <summary>
        /// A sub property of recipient. The recipient copied on a message.
        /// </summary>
        Values<IContactPoint, IOrganization, IPerson> CcRecipient { get; set; }

        /// <summary>
        /// The date/time at which the message has been read by the recipient if a single recipient exists.
        /// </summary>
        Values<int?, DateTime?, DateTimeOffset?> DateRead { get; set; }

        /// <summary>
        /// The date/time the message was received if a single recipient exists.
        /// </summary>
        OneOrMany<DateTimeOffset?> DateReceived { get; set; }

        /// <summary>
        /// The date/time at which the message was sent.
        /// </summary>
        OneOrMany<DateTimeOffset?> DateSent { get; set; }

        /// <summary>
        /// A CreativeWork attached to the message.
        /// </summary>
        OneOrMany<ICreativeWork> MessageAttachment { get; set; }

        /// <summary>
        /// A sub property of participant. The participant who is at the receiving end of the action.
        /// </summary>
        Values<IAudience, IContactPoint, IOrganization, IPerson> Recipient { get; set; }

        /// <summary>
        /// A sub property of participant. The participant who is at the sending end of the action.
        /// </summary>
        Values<IAudience, IOrganization, IPerson> Sender { get; set; }

        /// <summary>
        /// A sub property of recipient. The recipient who was directly sent the message.
        /// </summary>
        Values<IAudience, IContactPoint, IOrganization, IPerson> ToRecipient { get; set; }
    }

    /// <summary>
    /// A single message from a sender to one or more organizations or people.
    /// </summary>
    public partial class Message : CreativeWork, IMessage
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Message";

        /// <summary>
        /// A sub property of recipient. The recipient blind copied on a message.
        /// </summary>
        [JsonPropertyName("bccRecipient")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IContactPoint, IOrganization, IPerson> BccRecipient { get; set; }

        /// <summary>
        /// A sub property of recipient. The recipient copied on a message.
        /// </summary>
        [JsonPropertyName("ccRecipient")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IContactPoint, IOrganization, IPerson> CcRecipient { get; set; }

        /// <summary>
        /// The date/time at which the message has been read by the recipient if a single recipient exists.
        /// </summary>
        [JsonPropertyName("dateRead")]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, DateTimeOffset?> DateRead { get; set; }

        /// <summary>
        /// The date/time the message was received if a single recipient exists.
        /// </summary>
        [JsonPropertyName("dateReceived")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DateTimeOffset?> DateReceived { get; set; }

        /// <summary>
        /// The date/time at which the message was sent.
        /// </summary>
        [JsonPropertyName("dateSent")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DateTimeOffset?> DateSent { get; set; }

        /// <summary>
        /// A CreativeWork attached to the message.
        /// </summary>
        [JsonPropertyName("messageAttachment")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ICreativeWork> MessageAttachment { get; set; }

        /// <summary>
        /// A sub property of participant. The participant who is at the receiving end of the action.
        /// </summary>
        [JsonPropertyName("recipient")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IAudience, IContactPoint, IOrganization, IPerson> Recipient { get; set; }

        /// <summary>
        /// A sub property of participant. The participant who is at the sending end of the action.
        /// </summary>
        [JsonPropertyName("sender")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IAudience, IOrganization, IPerson> Sender { get; set; }

        /// <summary>
        /// A sub property of recipient. The recipient who was directly sent the message.
        /// </summary>
        [JsonPropertyName("toRecipient")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IAudience, IContactPoint, IOrganization, IPerson> ToRecipient { get; set; }
    }
}

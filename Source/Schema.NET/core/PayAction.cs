namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An agent pays a price to a participant.
    /// </summary>
    public partial interface IPayAction : ITradeAction
    {
        /// <summary>
        /// A goal towards an action is taken. Can be concrete or abstract.
        /// </summary>
        Values<MedicalDevicePurpose?, IThing> Purpose { get; set; }

        /// <summary>
        /// A sub property of participant. The participant who is at the receiving end of the action.
        /// </summary>
        Values<IAudience, IContactPoint, IOrganization, IPerson> Recipient { get; set; }
    }

    /// <summary>
    /// An agent pays a price to a participant.
    /// </summary>
    public partial class PayAction : TradeAction, IPayAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "PayAction";

        /// <summary>
        /// A goal towards an action is taken. Can be concrete or abstract.
        /// </summary>
        [JsonPropertyName("purpose")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<MedicalDevicePurpose?, IThing> Purpose { get; set; }

        /// <summary>
        /// A sub property of participant. The participant who is at the receiving end of the action.
        /// </summary>
        [JsonPropertyName("recipient")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IAudience, IContactPoint, IOrganization, IPerson> Recipient { get; set; }
    }
}

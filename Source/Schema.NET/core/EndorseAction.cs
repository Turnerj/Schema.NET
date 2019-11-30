namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An agent approves/certifies/likes/supports/sanction an object.
    /// </summary>
    public partial interface IEndorseAction : IReactAction
    {
        /// <summary>
        /// A sub property of participant. The person/organization being supported.
        /// </summary>
        Values<IOrganization, IPerson> Endorsee { get; set; }
    }

    /// <summary>
    /// An agent approves/certifies/likes/supports/sanction an object.
    /// </summary>
    public partial class EndorseAction : ReactAction, IEndorseAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "EndorseAction";

        /// <summary>
        /// A sub property of participant. The person/organization being supported.
        /// </summary>
        [JsonPropertyName("endorsee")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Endorsee { get; set; }
    }
}

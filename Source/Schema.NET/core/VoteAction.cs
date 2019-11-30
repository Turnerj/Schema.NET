namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of expressing a preference from a fixed/finite/structured set of choices/options.
    /// </summary>
    public partial interface IVoteAction : IChooseAction
    {
        /// <summary>
        /// A sub property of object. The candidate subject of this action.
        /// </summary>
        OneOrMany<IPerson> Candidate { get; set; }
    }

    /// <summary>
    /// The act of expressing a preference from a fixed/finite/structured set of choices/options.
    /// </summary>
    public partial class VoteAction : ChooseAction, IVoteAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "VoteAction";

        /// <summary>
        /// A sub property of object. The candidate subject of this action.
        /// </summary>
        [JsonPropertyName("candidate")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Candidate { get; set; }
    }
}

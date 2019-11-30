namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of achieving victory in a competitive activity.
    /// </summary>
    public partial interface IWinAction : IAchieveAction
    {
        /// <summary>
        /// A sub property of participant. The loser of the action.
        /// </summary>
        OneOrMany<IPerson> Loser { get; set; }
    }

    /// <summary>
    /// The act of achieving victory in a competitive activity.
    /// </summary>
    public partial class WinAction : AchieveAction, IWinAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "WinAction";

        /// <summary>
        /// A sub property of participant. The loser of the action.
        /// </summary>
        [JsonPropertyName("loser")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Loser { get; set; }
    }
}

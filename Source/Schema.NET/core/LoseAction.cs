namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of being defeated in a competitive activity.
    /// </summary>
    public partial interface ILoseAction : IAchieveAction
    {
        /// <summary>
        /// A sub property of participant. The winner of the action.
        /// </summary>
        OneOrMany<IPerson> Winner { get; set; }
    }

    /// <summary>
    /// The act of being defeated in a competitive activity.
    /// </summary>
    public partial class LoseAction : AchieveAction, ILoseAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "LoseAction";

        /// <summary>
        /// A sub property of participant. The winner of the action.
        /// </summary>
        [JsonPropertyName("winner")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Winner { get; set; }
    }
}

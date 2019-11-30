namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of expressing a preference from a set of options or a large or unbounded set of choices/options.
    /// </summary>
    public partial interface IChooseAction : IAssessAction
    {
        /// <summary>
        /// A sub property of object. The options subject to this action.
        /// </summary>
        Values<string, IThing> ActionOption { get; set; }
    }

    /// <summary>
    /// The act of expressing a preference from a set of options or a large or unbounded set of choices/options.
    /// </summary>
    public partial class ChooseAction : AssessAction, IChooseAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ChooseAction";

        /// <summary>
        /// A sub property of object. The options subject to this action.
        /// </summary>
        [JsonPropertyName("actionOption")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, IThing> ActionOption { get; set; }
    }
}

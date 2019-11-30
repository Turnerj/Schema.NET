namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of forming one's opinion, reaction or sentiment.
    /// </summary>
    public partial interface IAssessAction : IAction
    {
    }

    /// <summary>
    /// The act of forming one's opinion, reaction or sentiment.
    /// </summary>
    public partial class AssessAction : Action, IAssessAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "AssessAction";
    }
}

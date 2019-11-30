namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of generating a comment about a subject.
    /// </summary>
    public partial interface ICommentAction : ICommunicateAction
    {
        /// <summary>
        /// A sub property of result. The Comment created or sent as a result of this action.
        /// </summary>
        OneOrMany<IComment> ResultComment { get; set; }
    }

    /// <summary>
    /// The act of generating a comment about a subject.
    /// </summary>
    public partial class CommentAction : CommunicateAction, ICommentAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "CommentAction";

        /// <summary>
        /// A sub property of result. The Comment created or sent as a result of this action.
        /// </summary>
        [JsonPropertyName("resultComment")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IComment> ResultComment { get; set; }
    }
}

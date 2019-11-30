namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An answer offered to a question; perhaps correct, perhaps opinionated or wrong.
    /// </summary>
    public partial interface IAnswer : IComment
    {
    }

    /// <summary>
    /// An answer offered to a question; perhaps correct, perhaps opinionated or wrong.
    /// </summary>
    public partial class Answer : Comment, IAnswer
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Answer";
    }
}

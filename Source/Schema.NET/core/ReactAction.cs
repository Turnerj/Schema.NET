namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of responding instinctively and emotionally to an object, expressing a sentiment.
    /// </summary>
    public partial interface IReactAction : IAssessAction
    {
    }

    /// <summary>
    /// The act of responding instinctively and emotionally to an object, expressing a sentiment.
    /// </summary>
    public partial class ReactAction : AssessAction, IReactAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ReactAction";
    }
}

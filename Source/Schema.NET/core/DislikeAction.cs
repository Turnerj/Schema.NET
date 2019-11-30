namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of expressing a negative sentiment about the object. An agent dislikes an object (a proposition, topic or theme) with participants.
    /// </summary>
    public partial interface IDislikeAction : IReactAction
    {
    }

    /// <summary>
    /// The act of expressing a negative sentiment about the object. An agent dislikes an object (a proposition, topic or theme) with participants.
    /// </summary>
    public partial class DislikeAction : ReactAction, IDislikeAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "DislikeAction";
    }
}

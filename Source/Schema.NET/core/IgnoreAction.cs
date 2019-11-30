namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of intentionally disregarding the object. An agent ignores an object.
    /// </summary>
    public partial interface IIgnoreAction : IAssessAction
    {
    }

    /// <summary>
    /// The act of intentionally disregarding the object. An agent ignores an object.
    /// </summary>
    public partial class IgnoreAction : AssessAction, IIgnoreAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "IgnoreAction";
    }
}

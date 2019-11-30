namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of managing by changing/editing the state of the object.
    /// </summary>
    public partial interface IUpdateAction : IAction
    {
        /// <summary>
        /// A sub property of object. The collection target of the action.
        /// </summary>
        OneOrMany<IThing> TargetCollection { get; set; }
    }

    /// <summary>
    /// The act of managing by changing/editing the state of the object.
    /// </summary>
    public partial class UpdateAction : Action, IUpdateAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "UpdateAction";

        /// <summary>
        /// A sub property of object. The collection target of the action.
        /// </summary>
        [JsonPropertyName("targetCollection")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IThing> TargetCollection { get; set; }
    }
}

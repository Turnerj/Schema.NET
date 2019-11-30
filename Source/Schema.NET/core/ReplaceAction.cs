namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of editing a recipient by replacing an old object with a new object.
    /// </summary>
    public partial interface IReplaceAction : IUpdateAction
    {
        /// <summary>
        /// A sub property of object. The object that is being replaced.
        /// </summary>
        OneOrMany<IThing> Replacee { get; set; }

        /// <summary>
        /// A sub property of object. The object that replaces.
        /// </summary>
        OneOrMany<IThing> Replacer { get; set; }
    }

    /// <summary>
    /// The act of editing a recipient by replacing an old object with a new object.
    /// </summary>
    public partial class ReplaceAction : UpdateAction, IReplaceAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ReplaceAction";

        /// <summary>
        /// A sub property of object. The object that is being replaced.
        /// </summary>
        [JsonPropertyName("replacee")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IThing> Replacee { get; set; }

        /// <summary>
        /// A sub property of object. The object that replaces.
        /// </summary>
        [JsonPropertyName("replacer")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IThing> Replacer { get; set; }
    }
}

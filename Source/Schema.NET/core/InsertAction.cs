namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of adding at a specific location in an ordered collection.
    /// </summary>
    public partial interface IInsertAction : IAddAction
    {
        /// <summary>
        /// A sub property of location. The final location of the object or the agent after the action.
        /// </summary>
        OneOrMany<IPlace> ToLocation { get; set; }
    }

    /// <summary>
    /// The act of adding at a specific location in an ordered collection.
    /// </summary>
    public partial class InsertAction : AddAction, IInsertAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "InsertAction";

        /// <summary>
        /// A sub property of location. The final location of the object or the agent after the action.
        /// </summary>
        [JsonPropertyName("toLocation")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace> ToLocation { get; set; }
    }
}

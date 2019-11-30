namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of inserting at the end if an ordered collection.
    /// </summary>
    public partial interface IAppendAction : IInsertAction
    {
    }

    /// <summary>
    /// The act of inserting at the end if an ordered collection.
    /// </summary>
    public partial class AppendAction : InsertAction, IAppendAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "AppendAction";
    }
}

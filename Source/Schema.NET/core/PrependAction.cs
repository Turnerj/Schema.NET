namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of inserting at the beginning if an ordered collection.
    /// </summary>
    public partial interface IPrependAction : IInsertAction
    {
    }

    /// <summary>
    /// The act of inserting at the beginning if an ordered collection.
    /// </summary>
    public partial class PrependAction : InsertAction, IPrependAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "PrependAction";
    }
}

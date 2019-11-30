namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of editing a recipient by removing one of its objects.
    /// </summary>
    public partial interface IDeleteAction : IUpdateAction
    {
    }

    /// <summary>
    /// The act of editing a recipient by removing one of its objects.
    /// </summary>
    public partial class DeleteAction : UpdateAction, IDeleteAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "DeleteAction";
    }
}

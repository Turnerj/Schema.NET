namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of consuming audio content.
    /// </summary>
    public partial interface IListenAction : IConsumeAction
    {
    }

    /// <summary>
    /// The act of consuming audio content.
    /// </summary>
    public partial class ListenAction : ConsumeAction, IListenAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ListenAction";
    }
}

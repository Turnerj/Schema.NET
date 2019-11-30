namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of consuming written content.
    /// </summary>
    public partial interface IReadAction : IConsumeAction
    {
    }

    /// <summary>
    /// The act of consuming written content.
    /// </summary>
    public partial class ReadAction : ConsumeAction, IReadAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ReadAction";
    }
}

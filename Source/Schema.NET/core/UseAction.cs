namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of applying an object to its intended purpose.
    /// </summary>
    public partial interface IUseAction : IConsumeAction
    {
    }

    /// <summary>
    /// The act of applying an object to its intended purpose.
    /// </summary>
    public partial class UseAction : ConsumeAction, IUseAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "UseAction";
    }
}

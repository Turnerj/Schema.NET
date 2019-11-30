namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of swallowing solid objects.
    /// </summary>
    public partial interface IEatAction : IConsumeAction
    {
    }

    /// <summary>
    /// The act of swallowing solid objects.
    /// </summary>
    public partial class EatAction : ConsumeAction, IEatAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "EatAction";
    }
}

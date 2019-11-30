namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of consuming static visual content.
    /// </summary>
    public partial interface IViewAction : IConsumeAction
    {
    }

    /// <summary>
    /// The act of consuming static visual content.
    /// </summary>
    public partial class ViewAction : ConsumeAction, IViewAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ViewAction";
    }
}

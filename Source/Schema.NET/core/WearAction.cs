namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of dressing oneself in clothing.
    /// </summary>
    public partial interface IWearAction : IUseAction
    {
    }

    /// <summary>
    /// The act of dressing oneself in clothing.
    /// </summary>
    public partial class WearAction : UseAction, IWearAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "WearAction";
    }
}

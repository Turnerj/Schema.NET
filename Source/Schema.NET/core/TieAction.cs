namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of reaching a draw in a competitive activity.
    /// </summary>
    public partial interface ITieAction : IAchieveAction
    {
    }

    /// <summary>
    /// The act of reaching a draw in a competitive activity.
    /// </summary>
    public partial class TieAction : AchieveAction, ITieAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "TieAction";
    }
}

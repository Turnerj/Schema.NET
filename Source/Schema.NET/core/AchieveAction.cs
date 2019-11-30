namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of accomplishing something via previous efforts. It is an instantaneous action rather than an ongoing process.
    /// </summary>
    public partial interface IAchieveAction : IAction
    {
    }

    /// <summary>
    /// The act of accomplishing something via previous efforts. It is an instantaneous action rather than an ongoing process.
    /// </summary>
    public partial class AchieveAction : Action, IAchieveAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "AchieveAction";
    }
}

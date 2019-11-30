namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An agent controls a device or application.
    /// </summary>
    public partial interface IControlAction : IAction
    {
    }

    /// <summary>
    /// An agent controls a device or application.
    /// </summary>
    public partial class ControlAction : Action, IControlAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ControlAction";
    }
}

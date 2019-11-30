namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of momentarily pausing a device or application (e.g. pause music playback or pause a timer).
    /// </summary>
    public partial interface ISuspendAction : IControlAction
    {
    }

    /// <summary>
    /// The act of momentarily pausing a device or application (e.g. pause music playback or pause a timer).
    /// </summary>
    public partial class SuspendAction : ControlAction, ISuspendAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "SuspendAction";
    }
}

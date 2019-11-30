namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of resuming a device or application which was formerly paused (e.g. resume music playback or resume a timer).
    /// </summary>
    public partial interface IResumeAction : IControlAction
    {
    }

    /// <summary>
    /// The act of resuming a device or application which was formerly paused (e.g. resume music playback or resume a timer).
    /// </summary>
    public partial class ResumeAction : ControlAction, IResumeAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ResumeAction";
    }
}

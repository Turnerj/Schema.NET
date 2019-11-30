namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of starting or activating a device or application (e.g. starting a timer or turning on a flashlight).
    /// </summary>
    public partial interface IActivateAction : IControlAction
    {
    }

    /// <summary>
    /// The act of starting or activating a device or application (e.g. starting a timer or turning on a flashlight).
    /// </summary>
    public partial class ActivateAction : ControlAction, IActivateAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ActivateAction";
    }
}

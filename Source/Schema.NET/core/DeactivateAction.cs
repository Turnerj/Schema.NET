namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of stopping or deactivating a device or application (e.g. stopping a timer or turning off a flashlight).
    /// </summary>
    public partial interface IDeactivateAction : IControlAction
    {
    }

    /// <summary>
    /// The act of stopping or deactivating a device or application (e.g. stopping a timer or turning off a flashlight).
    /// </summary>
    public partial class DeactivateAction : ControlAction, IDeactivateAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "DeactivateAction";
    }
}

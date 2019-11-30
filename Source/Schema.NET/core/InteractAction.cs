namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of interacting with another person or organization.
    /// </summary>
    public partial interface IInteractAction : IAction
    {
    }

    /// <summary>
    /// The act of interacting with another person or organization.
    /// </summary>
    public partial class InteractAction : Action, IInteractAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "InteractAction";
    }
}

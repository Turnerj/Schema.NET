namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of marrying a person.
    /// </summary>
    public partial interface IMarryAction : IInteractAction
    {
    }

    /// <summary>
    /// The act of marrying a person.
    /// </summary>
    public partial class MarryAction : InteractAction, IMarryAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "MarryAction";
    }
}

namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of allocating an action/event/task to some destination (someone or something).
    /// </summary>
    public partial interface IAssignAction : IAllocateAction
    {
    }

    /// <summary>
    /// The act of allocating an action/event/task to some destination (someone or something).
    /// </summary>
    public partial class AssignAction : AllocateAction, IAssignAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "AssignAction";
    }
}

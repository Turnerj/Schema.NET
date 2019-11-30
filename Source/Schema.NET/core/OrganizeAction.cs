namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of manipulating/administering/supervising/controlling one or more objects.
    /// </summary>
    public partial interface IOrganizeAction : IAction
    {
    }

    /// <summary>
    /// The act of manipulating/administering/supervising/controlling one or more objects.
    /// </summary>
    public partial class OrganizeAction : Action, IOrganizeAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "OrganizeAction";
    }
}

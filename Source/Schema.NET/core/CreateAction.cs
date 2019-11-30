namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of deliberately creating/producing/generating/building a result out of the agent.
    /// </summary>
    public partial interface ICreateAction : IAction
    {
    }

    /// <summary>
    /// The act of deliberately creating/producing/generating/building a result out of the agent.
    /// </summary>
    public partial class CreateAction : Action, ICreateAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "CreateAction";
    }
}

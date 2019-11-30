namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The act of  departing from a place. An agent departs from an fromLocation for a destination, optionally with participants.
    /// </summary>
    public partial interface IDepartAction : IMoveAction
    {
    }

    /// <summary>
    /// The act of  departing from a place. An agent departs from an fromLocation for a destination, optionally with participants.
    /// </summary>
    public partial class DepartAction : MoveAction, IDepartAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "DepartAction";
    }
}

namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A state or province of a country.
    /// </summary>
    public partial interface IState : IAdministrativeArea
    {
    }

    /// <summary>
    /// A state or province of a country.
    /// </summary>
    public partial class State : AdministrativeArea, IState
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "State";
    }
}

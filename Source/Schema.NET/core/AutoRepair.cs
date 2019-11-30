namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Car repair business.
    /// </summary>
    public partial interface IAutoRepair : IAutomotiveBusiness
    {
    }

    /// <summary>
    /// Car repair business.
    /// </summary>
    public partial class AutoRepair : AutomotiveBusiness, IAutoRepair
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "AutoRepair";
    }
}

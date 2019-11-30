namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A car wash business.
    /// </summary>
    public partial interface IAutoWash : IAutomotiveBusiness
    {
    }

    /// <summary>
    /// A car wash business.
    /// </summary>
    public partial class AutoWash : AutomotiveBusiness, IAutoWash
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "AutoWash";
    }
}

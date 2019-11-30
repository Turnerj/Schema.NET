namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A car rental business.
    /// </summary>
    public partial interface IAutoRental : IAutomotiveBusiness
    {
    }

    /// <summary>
    /// A car rental business.
    /// </summary>
    public partial class AutoRental : AutomotiveBusiness, IAutoRental
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "AutoRental";
    }
}

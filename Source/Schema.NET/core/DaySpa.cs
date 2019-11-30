namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A day spa.
    /// </summary>
    public partial interface IDaySpa : IHealthAndBeautyBusiness
    {
    }

    /// <summary>
    /// A day spa.
    /// </summary>
    public partial class DaySpa : HealthAndBeautyBusiness, IDaySpa
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "DaySpa";
    }
}

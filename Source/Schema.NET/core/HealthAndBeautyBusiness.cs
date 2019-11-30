namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Health and beauty.
    /// </summary>
    public partial interface IHealthAndBeautyBusiness : ILocalBusiness
    {
    }

    /// <summary>
    /// Health and beauty.
    /// </summary>
    public partial class HealthAndBeautyBusiness : LocalBusiness, IHealthAndBeautyBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "HealthAndBeautyBusiness";
    }
}

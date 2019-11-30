namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// See HealthAndBeautyBusiness, SportsActivityLocation for more information.
    /// </summary>
    public partial interface IHealthAndBeautyBusinessAndSportsActivityLocation : IHealthAndBeautyBusiness, ISportsActivityLocation
    {
    }

    /// <summary>
    /// See HealthAndBeautyBusiness, SportsActivityLocation for more information.
    /// </summary>
    public abstract partial class HealthAndBeautyBusinessAndSportsActivityLocation : LocalBusiness, IHealthAndBeautyBusinessAndSportsActivityLocation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "HealthAndBeautyBusinessAndSportsActivityLocation";
    }
}

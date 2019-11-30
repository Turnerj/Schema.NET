namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A health club.
    /// </summary>
    public partial interface IHealthClub : IHealthAndBeautyBusinessAndSportsActivityLocation
    {
    }

    /// <summary>
    /// A health club.
    /// </summary>
    public partial class HealthClub : HealthAndBeautyBusinessAndSportsActivityLocation, IHealthClub
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "HealthClub";
    }
}

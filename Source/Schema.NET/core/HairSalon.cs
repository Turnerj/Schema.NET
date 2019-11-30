namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A hair salon.
    /// </summary>
    public partial interface IHairSalon : IHealthAndBeautyBusiness
    {
    }

    /// <summary>
    /// A hair salon.
    /// </summary>
    public partial class HairSalon : HealthAndBeautyBusiness, IHairSalon
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "HairSalon";
    }
}

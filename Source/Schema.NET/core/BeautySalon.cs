namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Beauty salon.
    /// </summary>
    public partial interface IBeautySalon : IHealthAndBeautyBusiness
    {
    }

    /// <summary>
    /// Beauty salon.
    /// </summary>
    public partial class BeautySalon : HealthAndBeautyBusiness, IBeautySalon
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "BeautySalon";
    }
}

namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A nail salon.
    /// </summary>
    public partial interface INailSalon : IHealthAndBeautyBusiness
    {
    }

    /// <summary>
    /// A nail salon.
    /// </summary>
    public partial class NailSalon : HealthAndBeautyBusiness, INailSalon
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "NailSalon";
    }
}

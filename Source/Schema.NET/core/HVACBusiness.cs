namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A business that provide Heating, Ventilation and Air Conditioning services.
    /// </summary>
    public partial interface IHVACBusiness : IHomeAndConstructionBusiness
    {
    }

    /// <summary>
    /// A business that provide Heating, Ventilation and Air Conditioning services.
    /// </summary>
    public partial class HVACBusiness : HomeAndConstructionBusiness, IHVACBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "HVACBusiness";
    }
}

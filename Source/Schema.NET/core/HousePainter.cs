namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A house painting service.
    /// </summary>
    public partial interface IHousePainter : IHomeAndConstructionBusiness
    {
    }

    /// <summary>
    /// A house painting service.
    /// </summary>
    public partial class HousePainter : HomeAndConstructionBusiness, IHousePainter
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "HousePainter";
    }
}

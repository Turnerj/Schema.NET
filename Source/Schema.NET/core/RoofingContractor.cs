namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A roofing contractor.
    /// </summary>
    public partial interface IRoofingContractor : IHomeAndConstructionBusiness
    {
    }

    /// <summary>
    /// A roofing contractor.
    /// </summary>
    public partial class RoofingContractor : HomeAndConstructionBusiness, IRoofingContractor
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "RoofingContractor";
    }
}

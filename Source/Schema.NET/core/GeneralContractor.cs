namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A general contractor.
    /// </summary>
    public partial interface IGeneralContractor : IHomeAndConstructionBusiness
    {
    }

    /// <summary>
    /// A general contractor.
    /// </summary>
    public partial class GeneralContractor : HomeAndConstructionBusiness, IGeneralContractor
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "GeneralContractor";
    }
}

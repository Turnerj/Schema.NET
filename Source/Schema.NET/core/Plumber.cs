namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A plumbing service.
    /// </summary>
    public partial interface IPlumber : IHomeAndConstructionBusiness
    {
    }

    /// <summary>
    /// A plumbing service.
    /// </summary>
    public partial class Plumber : HomeAndConstructionBusiness, IPlumber
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Plumber";
    }
}

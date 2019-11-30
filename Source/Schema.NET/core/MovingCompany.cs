namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A moving company.
    /// </summary>
    public partial interface IMovingCompany : IHomeAndConstructionBusiness
    {
    }

    /// <summary>
    /// A moving company.
    /// </summary>
    public partial class MovingCompany : HomeAndConstructionBusiness, IMovingCompany
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "MovingCompany";
    }
}

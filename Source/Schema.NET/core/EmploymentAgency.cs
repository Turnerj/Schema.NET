namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An employment agency.
    /// </summary>
    public partial interface IEmploymentAgency : ILocalBusiness
    {
    }

    /// <summary>
    /// An employment agency.
    /// </summary>
    public partial class EmploymentAgency : LocalBusiness, IEmploymentAgency
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "EmploymentAgency";
    }
}

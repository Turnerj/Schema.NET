namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An educational organization.
    /// </summary>
    public partial interface IEducationalOrganization : IOrganization
    {
    }

    /// <summary>
    /// An educational organization.
    /// </summary>
    public partial class EducationalOrganization : Organization, IEducationalOrganization
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "EducationalOrganization";

        /// <summary>
        /// Alumni of an organization.
        /// </summary>
        [JsonPropertyName("alumni")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IPerson> Alumni { get; set; }
    }
}

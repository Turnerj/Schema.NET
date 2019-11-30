namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A governmental organization or agency.
    /// </summary>
    public partial interface IGovernmentOrganization : IOrganization
    {
    }

    /// <summary>
    /// A governmental organization or agency.
    /// </summary>
    public partial class GovernmentOrganization : Organization, IGovernmentOrganization
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "GovernmentOrganization";
    }
}

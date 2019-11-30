namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A service provided by a government organization, e.g. food stamps, veterans benefits, etc.
    /// </summary>
    public partial interface IGovernmentService : IService
    {
        /// <summary>
        /// The operating organization, if different from the provider.  This enables the representation of services that are provided by an organization, but operated by another organization like a subcontractor.
        /// </summary>
        OneOrMany<IOrganization> ServiceOperator { get; set; }
    }

    /// <summary>
    /// A service provided by a government organization, e.g. food stamps, veterans benefits, etc.
    /// </summary>
    public partial class GovernmentService : Service, IGovernmentService
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "GovernmentService";

        /// <summary>
        /// The operating organization, if different from the provider.  This enables the representation of services that are provided by an organization, but operated by another organization like a subcontractor.
        /// </summary>
        [JsonPropertyName("serviceOperator")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrganization> ServiceOperator { get; set; }
    }
}

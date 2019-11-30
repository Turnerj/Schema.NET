namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A subclass of Role used to describe roles within organizations.
    /// </summary>
    public partial interface IOrganizationRole : IRole
    {
        /// <summary>
        /// A number associated with a role in an organization, for example, the number on an athlete's jersey.
        /// </summary>
        OneOrMany<double?> NumberedPosition { get; set; }
    }

    /// <summary>
    /// A subclass of Role used to describe roles within organizations.
    /// </summary>
    public partial class OrganizationRole : Role, IOrganizationRole
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "OrganizationRole";

        /// <summary>
        /// A number associated with a role in an organization, for example, the number on an athlete's jersey.
        /// </summary>
        [JsonPropertyName("numberedPosition")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<double?> NumberedPosition { get; set; }
    }
}

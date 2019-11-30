namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A permission for a particular person or group to access a particular file.
    /// </summary>
    public partial interface IDigitalDocumentPermission : IIntangible
    {
        /// <summary>
        /// The person, organization, contact point, or audience that has been granted this permission.
        /// </summary>
        Values<IAudience, IContactPoint, IOrganization, IPerson> Grantee { get; set; }

        /// <summary>
        /// The type of permission granted the person, organization, or audience.
        /// </summary>
        OneOrMany<DigitalDocumentPermissionType?> PermissionType { get; set; }
    }

    /// <summary>
    /// A permission for a particular person or group to access a particular file.
    /// </summary>
    public partial class DigitalDocumentPermission : Intangible, IDigitalDocumentPermission
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "DigitalDocumentPermission";

        /// <summary>
        /// The person, organization, contact point, or audience that has been granted this permission.
        /// </summary>
        [JsonPropertyName("grantee")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IAudience, IContactPoint, IOrganization, IPerson> Grantee { get; set; }

        /// <summary>
        /// The type of permission granted the person, organization, or audience.
        /// </summary>
        [JsonPropertyName("permissionType")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DigitalDocumentPermissionType?> PermissionType { get; set; }
    }
}

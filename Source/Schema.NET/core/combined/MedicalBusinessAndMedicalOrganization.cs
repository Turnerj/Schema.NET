namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// See MedicalBusiness, MedicalOrganization for more information.
    /// </summary>
    public partial interface IMedicalBusinessAndMedicalOrganization : IMedicalBusiness, IMedicalOrganization
    {
    }

    /// <summary>
    /// See MedicalBusiness, MedicalOrganization for more information.
    /// </summary>
    public abstract partial class MedicalBusinessAndMedicalOrganization : LocalBusinessAndOrganization, IMedicalBusinessAndMedicalOrganization
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "MedicalBusinessAndMedicalOrganization";

        /// <summary>
        /// Name or unique ID of network. (Networks are often reused across different insurance plans).
        /// </summary>
        [JsonPropertyName("healthPlanNetworkId")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> HealthPlanNetworkId { get; set; }

        /// <summary>
        /// Whether the provider is accepting new patients.
        /// </summary>
        [JsonPropertyName("isAcceptingNewPatients")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<bool?> IsAcceptingNewPatients { get; set; }

        /// <summary>
        /// A medical specialty of the provider.
        /// </summary>
        [JsonPropertyName("medicalSpecialty")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<MedicalSpecialty?> MedicalSpecialty { get; set; }
    }
}

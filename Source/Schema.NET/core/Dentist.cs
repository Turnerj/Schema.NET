namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A dentist.
    /// </summary>
    public partial interface IDentist : IMedicalBusinessAndMedicalOrganization
    {
    }

    /// <summary>
    /// A dentist.
    /// </summary>
    public partial class Dentist : MedicalBusinessAndMedicalOrganization, IDentist
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Dentist";
    }
}

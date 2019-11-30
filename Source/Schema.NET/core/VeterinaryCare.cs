namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A vet's office.
    /// </summary>
    public partial interface IVeterinaryCare : IMedicalOrganization
    {
    }

    /// <summary>
    /// A vet's office.
    /// </summary>
    public partial class VeterinaryCare : MedicalOrganization, IVeterinaryCare
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "VeterinaryCare";
    }
}

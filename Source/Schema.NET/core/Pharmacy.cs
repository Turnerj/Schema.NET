namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A pharmacy or drugstore.
    /// </summary>
    public partial interface IPharmacy : IMedicalBusinessAndMedicalOrganization
    {
    }

    /// <summary>
    /// A pharmacy or drugstore.
    /// </summary>
    public partial class Pharmacy : MedicalBusinessAndMedicalOrganization, IPharmacy
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Pharmacy";
    }
}

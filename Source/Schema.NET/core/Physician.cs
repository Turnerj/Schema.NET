namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A doctor's office.
    /// </summary>
    public partial interface IPhysician : IMedicalBusinessAndMedicalOrganization
    {
        /// <summary>
        /// A medical service available from this provider.
        /// </summary>
        Values<IMedicalProcedure, IMedicalTest, IMedicalTherapy> AvailableService { get; set; }

        /// <summary>
        /// A hospital with which the physician or office is affiliated.
        /// </summary>
        OneOrMany<IHospital> HospitalAffiliation { get; set; }
    }

    /// <summary>
    /// A doctor's office.
    /// </summary>
    public partial class Physician : MedicalBusinessAndMedicalOrganization, IPhysician
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Physician";

        /// <summary>
        /// A medical service available from this provider.
        /// </summary>
        [JsonPropertyName("availableService")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMedicalProcedure, IMedicalTest, IMedicalTherapy> AvailableService { get; set; }

        /// <summary>
        /// A hospital with which the physician or office is affiliated.
        /// </summary>
        [JsonPropertyName("hospitalAffiliation")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IHospital> HospitalAffiliation { get; set; }

        /// <summary>
        /// A medical specialty of the provider.
        /// </summary>
        [JsonPropertyName("medicalSpecialty")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<MedicalSpecialty?> MedicalSpecialty { get; set; }
    }
}

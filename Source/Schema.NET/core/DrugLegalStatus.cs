namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The legal availability status of a medical drug.
    /// </summary>
    public partial interface IDrugLegalStatus : IMedicalIntangible
    {
        /// <summary>
        /// The location in which the status applies.
        /// </summary>
        OneOrMany<IAdministrativeArea> ApplicableLocation { get; set; }
    }

    /// <summary>
    /// The legal availability status of a medical drug.
    /// </summary>
    public partial class DrugLegalStatus : MedicalIntangible, IDrugLegalStatus
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "DrugLegalStatus";

        /// <summary>
        /// The location in which the status applies.
        /// </summary>
        [JsonPropertyName("applicableLocation")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAdministrativeArea> ApplicableLocation { get; set; }
    }
}

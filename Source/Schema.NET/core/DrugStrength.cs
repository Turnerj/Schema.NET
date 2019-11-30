namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A specific strength in which a medical drug is available in a specific country.
    /// </summary>
    public partial interface IDrugStrength : IMedicalIntangible
    {
        /// <summary>
        /// An active ingredient, typically chemical compounds and/or biologic substances.
        /// </summary>
        OneOrMany<string> ActiveIngredient { get; set; }

        /// <summary>
        /// The location in which the strength is available.
        /// </summary>
        OneOrMany<IAdministrativeArea> AvailableIn { get; set; }

        /// <summary>
        /// Recommended intake of this supplement for a given population as defined by a specific recommending authority.
        /// </summary>
        OneOrMany<IMaximumDoseSchedule> MaximumIntake { get; set; }

        /// <summary>
        /// The units of an active ingredient's strength, e.g. mg.
        /// </summary>
        OneOrMany<string> StrengthUnit { get; set; }

        /// <summary>
        /// The value of an active ingredient's strength, e.g. 325.
        /// </summary>
        OneOrMany<double?> StrengthValue { get; set; }
    }

    /// <summary>
    /// A specific strength in which a medical drug is available in a specific country.
    /// </summary>
    public partial class DrugStrength : MedicalIntangible, IDrugStrength
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "DrugStrength";

        /// <summary>
        /// An active ingredient, typically chemical compounds and/or biologic substances.
        /// </summary>
        [JsonPropertyName("activeIngredient")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ActiveIngredient { get; set; }

        /// <summary>
        /// The location in which the strength is available.
        /// </summary>
        [JsonPropertyName("availableIn")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAdministrativeArea> AvailableIn { get; set; }

        /// <summary>
        /// Recommended intake of this supplement for a given population as defined by a specific recommending authority.
        /// </summary>
        [JsonPropertyName("maximumIntake")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMaximumDoseSchedule> MaximumIntake { get; set; }

        /// <summary>
        /// The units of an active ingredient's strength, e.g. mg.
        /// </summary>
        [JsonPropertyName("strengthUnit")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> StrengthUnit { get; set; }

        /// <summary>
        /// The value of an active ingredient's strength, e.g. 325.
        /// </summary>
        [JsonPropertyName("strengthValue")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<double?> StrengthValue { get; set; }
    }
}

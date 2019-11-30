namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A product taken by mouth that contains a dietary ingredient intended to supplement the diet. Dietary ingredients may include vitamins, minerals, herbs or other botanicals, amino acids, and substances such as enzymes, organ tissues, glandulars and metabolites.
    /// </summary>
    public partial interface IDietarySupplement : ISubstance
    {
        /// <summary>
        /// Descriptive information establishing a historical perspective on the supplement. May include the rationale for the name, the population where the supplement first came to prominence, etc.
        /// </summary>
        OneOrMany<string> Background { get; set; }

        /// <summary>
        /// True if this item's name is a proprietary/brand name (vs. generic name).
        /// </summary>
        OneOrMany<bool?> IsProprietary { get; set; }

        /// <summary>
        /// The manufacturer of the product.
        /// </summary>
        OneOrMany<IOrganization> Manufacturer { get; set; }

        /// <summary>
        /// The specific biochemical interaction through which this drug or supplement produces its pharmacological effect.
        /// </summary>
        OneOrMany<string> MechanismOfAction { get; set; }

        /// <summary>
        /// The generic name of this drug or supplement.
        /// </summary>
        OneOrMany<string> NonProprietaryName { get; set; }

        /// <summary>
        /// Proprietary name given to the diet plan, typically by its originator or creator.
        /// </summary>
        OneOrMany<string> ProprietaryName { get; set; }

        /// <summary>
        /// Recommended intake of this supplement for a given population as defined by a specific recommending authority.
        /// </summary>
        OneOrMany<IRecommendedDoseSchedule> RecommendedIntake { get; set; }

        /// <summary>
        /// Any potential safety concern associated with the supplement. May include interactions with other drugs and foods, pregnancy, breastfeeding, known adverse reactions, and documented efficacy of the supplement.
        /// </summary>
        OneOrMany<string> SafetyConsideration { get; set; }

        /// <summary>
        /// Characteristics of the population for which this is intended, or which typically uses it, e.g. 'adults'.
        /// </summary>
        OneOrMany<string> TargetPopulation { get; set; }
    }

    /// <summary>
    /// A product taken by mouth that contains a dietary ingredient intended to supplement the diet. Dietary ingredients may include vitamins, minerals, herbs or other botanicals, amino acids, and substances such as enzymes, organ tissues, glandulars and metabolites.
    /// </summary>
    public partial class DietarySupplement : Substance, IDietarySupplement
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "DietarySupplement";

        /// <summary>
        /// An active ingredient, typically chemical compounds and/or biologic substances.
        /// </summary>
        [JsonPropertyName("activeIngredient")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<string> ActiveIngredient { get; set; }

        /// <summary>
        /// Descriptive information establishing a historical perspective on the supplement. May include the rationale for the name, the population where the supplement first came to prominence, etc.
        /// </summary>
        [JsonPropertyName("background")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Background { get; set; }

        /// <summary>
        /// True if this item's name is a proprietary/brand name (vs. generic name).
        /// </summary>
        [JsonPropertyName("isProprietary")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<bool?> IsProprietary { get; set; }

        /// <summary>
        /// The drug or supplement's legal status, including any controlled substance schedules that apply.
        /// </summary>
        [JsonPropertyName("legalStatus")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override Values<IDrugLegalStatus, MedicalEnumeration?, string> LegalStatus { get; set; }

        /// <summary>
        /// The manufacturer of the product.
        /// </summary>
        [JsonPropertyName("manufacturer")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrganization> Manufacturer { get; set; }

        /// <summary>
        /// Recommended intake of this supplement for a given population as defined by a specific recommending authority.
        /// </summary>
        [JsonPropertyName("maximumIntake")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IMaximumDoseSchedule> MaximumIntake { get; set; }

        /// <summary>
        /// The specific biochemical interaction through which this drug or supplement produces its pharmacological effect.
        /// </summary>
        [JsonPropertyName("mechanismOfAction")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> MechanismOfAction { get; set; }

        /// <summary>
        /// The generic name of this drug or supplement.
        /// </summary>
        [JsonPropertyName("nonProprietaryName")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> NonProprietaryName { get; set; }

        /// <summary>
        /// Proprietary name given to the diet plan, typically by its originator or creator.
        /// </summary>
        [JsonPropertyName("proprietaryName")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ProprietaryName { get; set; }

        /// <summary>
        /// Recommended intake of this supplement for a given population as defined by a specific recommending authority.
        /// </summary>
        [JsonPropertyName("recommendedIntake")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IRecommendedDoseSchedule> RecommendedIntake { get; set; }

        /// <summary>
        /// Any potential safety concern associated with the supplement. May include interactions with other drugs and foods, pregnancy, breastfeeding, known adverse reactions, and documented efficacy of the supplement.
        /// </summary>
        [JsonPropertyName("safetyConsideration")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> SafetyConsideration { get; set; }

        /// <summary>
        /// Characteristics of the population for which this is intended, or which typically uses it, e.g. 'adults'.
        /// </summary>
        [JsonPropertyName("targetPopulation")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> TargetPopulation { get; set; }
    }
}

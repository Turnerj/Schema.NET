namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A chemical or biologic substance, used as a medical therapy, that has a physiological effect on an organism. Here the term drug is used interchangeably with the term medicine although clinical knowledge make a clear difference between them.
    /// </summary>
    public partial interface IDrug : ISubstance
    {
        /// <summary>
        /// A route by which this drug may be administered, e.g. 'oral'.
        /// </summary>
        OneOrMany<string> AdministrationRoute { get; set; }

        /// <summary>
        /// Any precaution, guidance, contraindication, etc. related to consumption of alcohol while taking this drug.
        /// </summary>
        OneOrMany<string> AlcoholWarning { get; set; }

        /// <summary>
        /// An available dosage strength for the drug.
        /// </summary>
        OneOrMany<IDrugStrength> AvailableStrength { get; set; }

        /// <summary>
        /// Any precaution, guidance, contraindication, etc. related to this drug's use by breastfeeding mothers.
        /// </summary>
        OneOrMany<string> BreastfeedingWarning { get; set; }

        /// <summary>
        /// Description of the absorption and elimination of drugs, including their concentration (pharmacokinetics, pK) and biological effects (pharmacodynamics, pD).
        /// </summary>
        OneOrMany<string> ClinicalPharmacology { get; set; }

        /// <summary>
        /// Cost per unit of the drug, as reported by the source being tagged.
        /// </summary>
        OneOrMany<DrugCost?> Cost { get; set; }

        /// <summary>
        /// A dosage form in which this drug/supplement is available, e.g. 'tablet', 'suspension', 'injection'.
        /// </summary>
        OneOrMany<string> DosageForm { get; set; }

        /// <summary>
        /// A dosing schedule for the drug for a given population, either observed, recommended, or maximum dose based on the type used.
        /// </summary>
        OneOrMany<IDoseSchedule> DoseSchedule { get; set; }

        /// <summary>
        /// The class of drug this belongs to (e.g., statins).
        /// </summary>
        OneOrMany<DrugClass?> DrugClass { get; set; }

        /// <summary>
        /// The unit in which the drug is measured, e.g. '5 mg tablet'.
        /// </summary>
        OneOrMany<string> DrugUnit { get; set; }

        /// <summary>
        /// Any precaution, guidance, contraindication, etc. related to consumption of specific foods while taking this drug.
        /// </summary>
        OneOrMany<string> FoodWarning { get; set; }

        /// <summary>
        /// Another drug that is known to interact with this drug in a way that impacts the effect of this drug or causes a risk to the patient. Note: disease interactions are typically captured as contraindications.
        /// </summary>
        OneOrMany<IDrug> InteractingDrug { get; set; }

        /// <summary>
        /// True if the drug is available in a generic form (regardless of name).
        /// </summary>
        OneOrMany<bool?> IsAvailableGenerically { get; set; }

        /// <summary>
        /// True if this item's name is a proprietary/brand name (vs. generic name).
        /// </summary>
        OneOrMany<bool?> IsProprietary { get; set; }

        /// <summary>
        /// Link to the drug's label details.
        /// </summary>
        OneOrMany<Uri> LabelDetails { get; set; }

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
        /// Any information related to overdose on a drug, including signs or symptoms, treatments, contact information for emergency response.
        /// </summary>
        OneOrMany<string> Overdosage { get; set; }

        /// <summary>
        /// Pregnancy category of this drug.
        /// </summary>
        OneOrMany<DrugPregnancyCategory?> PregnancyCategory { get; set; }

        /// <summary>
        /// Any precaution, guidance, contraindication, etc. related to this drug's use during pregnancy.
        /// </summary>
        OneOrMany<string> PregnancyWarning { get; set; }

        /// <summary>
        /// Link to prescribing information for the drug.
        /// </summary>
        OneOrMany<Uri> PrescribingInfo { get; set; }

        /// <summary>
        /// Indicates the status of drug prescription eg. local catalogs classifications or whether the drug is available by prescription or over-the-counter, etc.
        /// </summary>
        Values<DrugPrescriptionStatus?, string> PrescriptionStatus { get; set; }

        /// <summary>
        /// Proprietary name given to the diet plan, typically by its originator or creator.
        /// </summary>
        OneOrMany<string> ProprietaryName { get; set; }

        /// <summary>
        /// Any other drug related to this one, for example commonly-prescribed alternatives.
        /// </summary>
        OneOrMany<IDrug> RelatedDrug { get; set; }

        /// <summary>
        /// The RxCUI drug identifier from RXNORM.
        /// </summary>
        OneOrMany<string> Rxcui { get; set; }

        /// <summary>
        /// Any FDA or other warnings about the drug (text or URL).
        /// </summary>
        Values<string, Uri> Warning { get; set; }
    }

    /// <summary>
    /// A chemical or biologic substance, used as a medical therapy, that has a physiological effect on an organism. Here the term drug is used interchangeably with the term medicine although clinical knowledge make a clear difference between them.
    /// </summary>
    public partial class Drug : Substance, IDrug
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Drug";

        /// <summary>
        /// An active ingredient, typically chemical compounds and/or biologic substances.
        /// </summary>
        [JsonPropertyName("activeIngredient")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<string> ActiveIngredient { get; set; }

        /// <summary>
        /// A route by which this drug may be administered, e.g. 'oral'.
        /// </summary>
        [JsonPropertyName("administrationRoute")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> AdministrationRoute { get; set; }

        /// <summary>
        /// Any precaution, guidance, contraindication, etc. related to consumption of alcohol while taking this drug.
        /// </summary>
        [JsonPropertyName("alcoholWarning")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> AlcoholWarning { get; set; }

        /// <summary>
        /// An available dosage strength for the drug.
        /// </summary>
        [JsonPropertyName("availableStrength")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IDrugStrength> AvailableStrength { get; set; }

        /// <summary>
        /// Any precaution, guidance, contraindication, etc. related to this drug's use by breastfeeding mothers.
        /// </summary>
        [JsonPropertyName("breastfeedingWarning")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> BreastfeedingWarning { get; set; }

        /// <summary>
        /// Description of the absorption and elimination of drugs, including their concentration (pharmacokinetics, pK) and biological effects (pharmacodynamics, pD).
        /// </summary>
        [JsonPropertyName("clinicalPharmacology")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ClinicalPharmacology { get; set; }

        /// <summary>
        /// Cost per unit of the drug, as reported by the source being tagged.
        /// </summary>
        [JsonPropertyName("cost")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DrugCost?> Cost { get; set; }

        /// <summary>
        /// A dosage form in which this drug/supplement is available, e.g. 'tablet', 'suspension', 'injection'.
        /// </summary>
        [JsonPropertyName("dosageForm")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> DosageForm { get; set; }

        /// <summary>
        /// A dosing schedule for the drug for a given population, either observed, recommended, or maximum dose based on the type used.
        /// </summary>
        [JsonPropertyName("doseSchedule")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IDoseSchedule> DoseSchedule { get; set; }

        /// <summary>
        /// The class of drug this belongs to (e.g., statins).
        /// </summary>
        [JsonPropertyName("drugClass")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DrugClass?> DrugClass { get; set; }

        /// <summary>
        /// The unit in which the drug is measured, e.g. '5 mg tablet'.
        /// </summary>
        [JsonPropertyName("drugUnit")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> DrugUnit { get; set; }

        /// <summary>
        /// Any precaution, guidance, contraindication, etc. related to consumption of specific foods while taking this drug.
        /// </summary>
        [JsonPropertyName("foodWarning")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> FoodWarning { get; set; }

        /// <summary>
        /// Another drug that is known to interact with this drug in a way that impacts the effect of this drug or causes a risk to the patient. Note: disease interactions are typically captured as contraindications.
        /// </summary>
        [JsonPropertyName("interactingDrug")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IDrug> InteractingDrug { get; set; }

        /// <summary>
        /// True if the drug is available in a generic form (regardless of name).
        /// </summary>
        [JsonPropertyName("isAvailableGenerically")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<bool?> IsAvailableGenerically { get; set; }

        /// <summary>
        /// True if this item's name is a proprietary/brand name (vs. generic name).
        /// </summary>
        [JsonPropertyName("isProprietary")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<bool?> IsProprietary { get; set; }

        /// <summary>
        /// Link to the drug's label details.
        /// </summary>
        [JsonPropertyName("labelDetails")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<Uri> LabelDetails { get; set; }

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
        /// Any information related to overdose on a drug, including signs or symptoms, treatments, contact information for emergency response.
        /// </summary>
        [JsonPropertyName("overdosage")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Overdosage { get; set; }

        /// <summary>
        /// Pregnancy category of this drug.
        /// </summary>
        [JsonPropertyName("pregnancyCategory")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DrugPregnancyCategory?> PregnancyCategory { get; set; }

        /// <summary>
        /// Any precaution, guidance, contraindication, etc. related to this drug's use during pregnancy.
        /// </summary>
        [JsonPropertyName("pregnancyWarning")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> PregnancyWarning { get; set; }

        /// <summary>
        /// Link to prescribing information for the drug.
        /// </summary>
        [JsonPropertyName("prescribingInfo")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<Uri> PrescribingInfo { get; set; }

        /// <summary>
        /// Indicates the status of drug prescription eg. local catalogs classifications or whether the drug is available by prescription or over-the-counter, etc.
        /// </summary>
        [JsonPropertyName("prescriptionStatus")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<DrugPrescriptionStatus?, string> PrescriptionStatus { get; set; }

        /// <summary>
        /// Proprietary name given to the diet plan, typically by its originator or creator.
        /// </summary>
        [JsonPropertyName("proprietaryName")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ProprietaryName { get; set; }

        /// <summary>
        /// Any other drug related to this one, for example commonly-prescribed alternatives.
        /// </summary>
        [JsonPropertyName("relatedDrug")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IDrug> RelatedDrug { get; set; }

        /// <summary>
        /// The RxCUI drug identifier from RXNORM.
        /// </summary>
        [JsonPropertyName("rxcui")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Rxcui { get; set; }

        /// <summary>
        /// Any FDA or other warnings about the drug (text or URL).
        /// </summary>
        [JsonPropertyName("warning")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> Warning { get; set; }
    }
}

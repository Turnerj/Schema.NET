namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Any condition of the human body that affects the normal functioning of a person, whether physically or mentally. Includes diseases, injuries, disabilities, disorders, syndromes, etc.
    /// </summary>
    public partial interface IMedicalCondition : IMedicalEntity
    {
        /// <summary>
        /// The anatomy of the underlying organ system or structures associated with this entity.
        /// </summary>
        Values<IAnatomicalStructure, IAnatomicalSystem, ISuperficialAnatomy> AssociatedAnatomy { get; set; }

        /// <summary>
        /// Specifying a cause of something in general. e.g in medicine , one of the causative agent(s) that are most directly responsible for the pathophysiologic process that eventually results in the occurrence.
        /// </summary>
        OneOrMany<IMedicalCause> Cause { get; set; }

        /// <summary>
        /// One of a set of differential diagnoses for the condition. Specifically, a closely-related or competing diagnosis typically considered later in the cognitive process whereby this medical condition is distinguished from others most likely responsible for a similar collection of signs and symptoms to reach the most parsimonious diagnosis or diagnoses in a patient.
        /// </summary>
        OneOrMany<IDDxElement> DifferentialDiagnosis { get; set; }

        /// <summary>
        /// Specifying a drug or medicine used in a medication procedure
        /// </summary>
        OneOrMany<IDrug> Drug { get; set; }

        /// <summary>
        /// The characteristics of associated patients, such as age, gender, race etc.
        /// </summary>
        OneOrMany<string> Epidemiology { get; set; }

        /// <summary>
        /// The likely outcome in either the short term or long term of the medical condition.
        /// </summary>
        OneOrMany<string> ExpectedPrognosis { get; set; }

        /// <summary>
        /// The expected progression of the condition if it is not treated and allowed to progress naturally.
        /// </summary>
        OneOrMany<string> NaturalProgression { get; set; }

        /// <summary>
        /// Changes in the normal mechanical, physical, and biochemical functions that are associated with this activity or condition.
        /// </summary>
        OneOrMany<string> Pathophysiology { get; set; }

        /// <summary>
        /// A possible unexpected and unfavorable evolution of a medical condition. Complications may include worsening of the signs or symptoms of the disease, extension of the condition to other organ systems, etc.
        /// </summary>
        OneOrMany<string> PossibleComplication { get; set; }

        /// <summary>
        /// A possible treatment to address this condition, sign or symptom.
        /// </summary>
        OneOrMany<IMedicalTherapy> PossibleTreatment { get; set; }

        /// <summary>
        /// A preventative therapy used to prevent an initial occurrence of the medical condition, such as vaccination.
        /// </summary>
        OneOrMany<IMedicalTherapy> PrimaryPrevention { get; set; }

        /// <summary>
        /// A modifiable or non-modifiable factor that increases the risk of a patient contracting this condition, e.g. age,  coexisting condition.
        /// </summary>
        OneOrMany<IMedicalRiskFactor> RiskFactor { get; set; }

        /// <summary>
        /// A preventative therapy used to prevent reoccurrence of the medical condition after an initial episode of the condition.
        /// </summary>
        OneOrMany<IMedicalTherapy> SecondaryPrevention { get; set; }

        /// <summary>
        /// A sign or symptom of this condition. Signs are objective or physically observable manifestations of the medical condition while symptoms are the subjective experience of the medical condition.
        /// </summary>
        OneOrMany<IMedicalSignOrSymptom> SignOrSymptom { get; set; }

        /// <summary>
        /// The stage of the condition, if applicable.
        /// </summary>
        OneOrMany<IMedicalConditionStage> Stage { get; set; }

        /// <summary>
        /// The status of the study (enumerated).
        /// </summary>
        Values<EventStatusType?, MedicalStudyStatus?, string> Status { get; set; }

        /// <summary>
        /// A more specific type of the condition, where applicable, for example 'Type 1 Diabetes', 'Type 2 Diabetes', or 'Gestational Diabetes' for Diabetes.
        /// </summary>
        OneOrMany<string> Subtype { get; set; }

        /// <summary>
        /// A medical test typically performed given this condition.
        /// </summary>
        OneOrMany<IMedicalTest> TypicalTest { get; set; }
    }

    /// <summary>
    /// Any condition of the human body that affects the normal functioning of a person, whether physically or mentally. Includes diseases, injuries, disabilities, disorders, syndromes, etc.
    /// </summary>
    public partial class MedicalCondition : MedicalEntity, IMedicalCondition
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "MedicalCondition";

        /// <summary>
        /// The anatomy of the underlying organ system or structures associated with this entity.
        /// </summary>
        [JsonPropertyName("associatedAnatomy")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IAnatomicalStructure, IAnatomicalSystem, ISuperficialAnatomy> AssociatedAnatomy { get; set; }

        /// <summary>
        /// Specifying a cause of something in general. e.g in medicine , one of the causative agent(s) that are most directly responsible for the pathophysiologic process that eventually results in the occurrence.
        /// </summary>
        [JsonPropertyName("cause")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IMedicalCause> Cause { get; set; }

        /// <summary>
        /// One of a set of differential diagnoses for the condition. Specifically, a closely-related or competing diagnosis typically considered later in the cognitive process whereby this medical condition is distinguished from others most likely responsible for a similar collection of signs and symptoms to reach the most parsimonious diagnosis or diagnoses in a patient.
        /// </summary>
        [JsonPropertyName("differentialDiagnosis")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IDDxElement> DifferentialDiagnosis { get; set; }

        /// <summary>
        /// Specifying a drug or medicine used in a medication procedure
        /// </summary>
        [JsonPropertyName("drug")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IDrug> Drug { get; set; }

        /// <summary>
        /// The characteristics of associated patients, such as age, gender, race etc.
        /// </summary>
        [JsonPropertyName("epidemiology")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Epidemiology { get; set; }

        /// <summary>
        /// The likely outcome in either the short term or long term of the medical condition.
        /// </summary>
        [JsonPropertyName("expectedPrognosis")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ExpectedPrognosis { get; set; }

        /// <summary>
        /// The expected progression of the condition if it is not treated and allowed to progress naturally.
        /// </summary>
        [JsonPropertyName("naturalProgression")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> NaturalProgression { get; set; }

        /// <summary>
        /// Changes in the normal mechanical, physical, and biochemical functions that are associated with this activity or condition.
        /// </summary>
        [JsonPropertyName("pathophysiology")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Pathophysiology { get; set; }

        /// <summary>
        /// A possible unexpected and unfavorable evolution of a medical condition. Complications may include worsening of the signs or symptoms of the disease, extension of the condition to other organ systems, etc.
        /// </summary>
        [JsonPropertyName("possibleComplication")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> PossibleComplication { get; set; }

        /// <summary>
        /// A possible treatment to address this condition, sign or symptom.
        /// </summary>
        [JsonPropertyName("possibleTreatment")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IMedicalTherapy> PossibleTreatment { get; set; }

        /// <summary>
        /// A preventative therapy used to prevent an initial occurrence of the medical condition, such as vaccination.
        /// </summary>
        [JsonPropertyName("primaryPrevention")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalTherapy> PrimaryPrevention { get; set; }

        /// <summary>
        /// A modifiable or non-modifiable factor that increases the risk of a patient contracting this condition, e.g. age,  coexisting condition.
        /// </summary>
        [JsonPropertyName("riskFactor")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalRiskFactor> RiskFactor { get; set; }

        /// <summary>
        /// A preventative therapy used to prevent reoccurrence of the medical condition after an initial episode of the condition.
        /// </summary>
        [JsonPropertyName("secondaryPrevention")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalTherapy> SecondaryPrevention { get; set; }

        /// <summary>
        /// A sign or symptom of this condition. Signs are objective or physically observable manifestations of the medical condition while symptoms are the subjective experience of the medical condition.
        /// </summary>
        [JsonPropertyName("signOrSymptom")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalSignOrSymptom> SignOrSymptom { get; set; }

        /// <summary>
        /// The stage of the condition, if applicable.
        /// </summary>
        [JsonPropertyName("stage")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalConditionStage> Stage { get; set; }

        /// <summary>
        /// The status of the study (enumerated).
        /// </summary>
        [JsonPropertyName("status")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<EventStatusType?, MedicalStudyStatus?, string> Status { get; set; }

        /// <summary>
        /// A more specific type of the condition, where applicable, for example 'Type 1 Diabetes', 'Type 2 Diabetes', or 'Gestational Diabetes' for Diabetes.
        /// </summary>
        [JsonPropertyName("subtype")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Subtype { get; set; }

        /// <summary>
        /// A medical test typically performed given this condition.
        /// </summary>
        [JsonPropertyName("typicalTest")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalTest> TypicalTest { get; set; }
    }
}

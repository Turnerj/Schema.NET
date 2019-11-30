namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A medical procedure intended primarily for therapeutic purposes, aimed at improving a health condition.
    /// </summary>
    public partial interface ITherapeuticProcedure : IMedicalProcedure
    {
        /// <summary>
        /// A possible complication and/or side effect of this therapy. If it is known that an adverse outcome is serious (resulting in death, disability, or permanent damage; requiring hospitalization; or is otherwise life-threatening or requires immediate medical attention), tag it as a seriouseAdverseOutcome instead.
        /// </summary>
        OneOrMany<IMedicalEntity> AdverseOutcome { get; set; }

        /// <summary>
        /// A dosing schedule for the drug for a given population, either observed, recommended, or maximum dose based on the type used.
        /// </summary>
        OneOrMany<IDoseSchedule> DoseSchedule { get; set; }

        /// <summary>
        /// Specifying a drug or medicine used in a medication procedure
        /// </summary>
        OneOrMany<IDrug> Drug { get; set; }
    }

    /// <summary>
    /// A medical procedure intended primarily for therapeutic purposes, aimed at improving a health condition.
    /// </summary>
    public partial class TherapeuticProcedure : MedicalProcedure, ITherapeuticProcedure
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "TherapeuticProcedure";

        /// <summary>
        /// A possible complication and/or side effect of this therapy. If it is known that an adverse outcome is serious (resulting in death, disability, or permanent damage; requiring hospitalization; or is otherwise life-threatening or requires immediate medical attention), tag it as a seriouseAdverseOutcome instead.
        /// </summary>
        [JsonPropertyName("adverseOutcome")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalEntity> AdverseOutcome { get; set; }

        /// <summary>
        /// A dosing schedule for the drug for a given population, either observed, recommended, or maximum dose based on the type used.
        /// </summary>
        [JsonPropertyName("doseSchedule")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IDoseSchedule> DoseSchedule { get; set; }

        /// <summary>
        /// Specifying a drug or medicine used in a medication procedure
        /// </summary>
        [JsonPropertyName("drug")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IDrug> Drug { get; set; }

        /// <summary>
        /// A factor that indicates use of this therapy for treatment and/or prevention of a condition, symptom, etc. For therapies such as drugs, indications can include both officially-approved indications as well as off-label uses. These can be distinguished by using the ApprovedIndication subtype of MedicalIndication.
        /// </summary>
        [JsonPropertyName("indication")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IMedicalIndication> Indication { get; set; }
    }
}

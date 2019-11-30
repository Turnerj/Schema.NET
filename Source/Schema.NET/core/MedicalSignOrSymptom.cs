namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Any feature associated or not with a medical condition. In medicine a symptom is generally subjective while a sign is objective.
    /// </summary>
    public partial interface IMedicalSignOrSymptom : IMedicalCondition
    {
    }

    /// <summary>
    /// Any feature associated or not with a medical condition. In medicine a symptom is generally subjective while a sign is objective.
    /// </summary>
    public partial class MedicalSignOrSymptom : MedicalCondition, IMedicalSignOrSymptom
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "MedicalSignOrSymptom";

        /// <summary>
        /// Specifying a cause of something in general. e.g in medicine , one of the causative agent(s) that are most directly responsible for the pathophysiologic process that eventually results in the occurrence.
        /// </summary>
        [JsonPropertyName("cause")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IMedicalCause> Cause { get; set; }

        /// <summary>
        /// A possible treatment to address this condition, sign or symptom.
        /// </summary>
        [JsonPropertyName("possibleTreatment")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IMedicalTherapy> PossibleTreatment { get; set; }
    }
}

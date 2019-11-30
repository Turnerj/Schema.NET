namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Any complaint sensed and expressed by the patient (therefore defined as subjective)  like stomachache, lower-back pain, or fatigue.
    /// </summary>
    public partial interface IMedicalSymptom : IMedicalSignOrSymptom
    {
    }

    /// <summary>
    /// Any complaint sensed and expressed by the patient (therefore defined as subjective)  like stomachache, lower-back pain, or fatigue.
    /// </summary>
    public partial class MedicalSymptom : MedicalSignOrSymptom, IMedicalSymptom
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "MedicalSymptom";
    }
}

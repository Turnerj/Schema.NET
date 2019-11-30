namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An indication for treating an underlying condition, symptom, etc.
    /// </summary>
    public partial interface ITreatmentIndication : IMedicalIndication
    {
    }

    /// <summary>
    /// An indication for treating an underlying condition, symptom, etc.
    /// </summary>
    public partial class TreatmentIndication : MedicalIndication, ITreatmentIndication
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "TreatmentIndication";
    }
}

namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An alternative, closely-related condition typically considered later in the differential diagnosis process along with the signs that are used to distinguish it.
    /// </summary>
    public partial interface IDDxElement : IMedicalIntangible
    {
        /// <summary>
        /// One or more alternative conditions considered in the differential diagnosis process as output of a diagnosis process.
        /// </summary>
        OneOrMany<IMedicalCondition> Diagnosis { get; set; }

        /// <summary>
        /// One of a set of signs and symptoms that can be used to distinguish this diagnosis from others in the differential diagnosis.
        /// </summary>
        OneOrMany<IMedicalSignOrSymptom> DistinguishingSign { get; set; }
    }

    /// <summary>
    /// An alternative, closely-related condition typically considered later in the differential diagnosis process along with the signs that are used to distinguish it.
    /// </summary>
    public partial class DDxElement : MedicalIntangible, IDDxElement
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "DDxElement";

        /// <summary>
        /// One or more alternative conditions considered in the differential diagnosis process as output of a diagnosis process.
        /// </summary>
        [JsonPropertyName("diagnosis")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalCondition> Diagnosis { get; set; }

        /// <summary>
        /// One of a set of signs and symptoms that can be used to distinguish this diagnosis from others in the differential diagnosis.
        /// </summary>
        [JsonPropertyName("distinguishingSign")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalSignOrSymptom> DistinguishingSign { get; set; }
    }
}

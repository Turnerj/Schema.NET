namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Any physical manifestation of a person's medical condition discoverable by objective diagnostic tests or physical examination.
    /// </summary>
    public partial interface IMedicalSign : IMedicalSignOrSymptom
    {
        /// <summary>
        /// A physical examination that can identify this sign.
        /// </summary>
        OneOrMany<PhysicalExam?> IdentifyingExam { get; set; }

        /// <summary>
        /// A diagnostic test that can identify this sign.
        /// </summary>
        OneOrMany<IMedicalTest> IdentifyingTest { get; set; }
    }

    /// <summary>
    /// Any physical manifestation of a person's medical condition discoverable by objective diagnostic tests or physical examination.
    /// </summary>
    public partial class MedicalSign : MedicalSignOrSymptom, IMedicalSign
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "MedicalSign";

        /// <summary>
        /// A physical examination that can identify this sign.
        /// </summary>
        [JsonPropertyName("identifyingExam")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<PhysicalExam?> IdentifyingExam { get; set; }

        /// <summary>
        /// A diagnostic test that can identify this sign.
        /// </summary>
        [JsonPropertyName("identifyingTest")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalTest> IdentifyingTest { get; set; }
    }
}

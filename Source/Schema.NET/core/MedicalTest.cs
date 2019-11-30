namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Any medical test, typically performed for diagnostic purposes.
    /// </summary>
    public partial interface IMedicalTest : IMedicalEntity
    {
        /// <summary>
        /// Drugs that affect the test's results.
        /// </summary>
        OneOrMany<IDrug> AffectedBy { get; set; }

        /// <summary>
        /// Range of acceptable values for a typical patient, when applicable.
        /// </summary>
        Values<MedicalEnumeration?, string> NormalRange { get; set; }

        /// <summary>
        /// A sign detected by the test.
        /// </summary>
        OneOrMany<IMedicalSign> SignDetected { get; set; }

        /// <summary>
        /// A condition the test is used to diagnose.
        /// </summary>
        OneOrMany<IMedicalCondition> UsedToDiagnose { get; set; }

        /// <summary>
        /// Device used to perform the test.
        /// </summary>
        OneOrMany<IMedicalDevice> UsesDevice { get; set; }
    }

    /// <summary>
    /// Any medical test, typically performed for diagnostic purposes.
    /// </summary>
    public partial class MedicalTest : MedicalEntity, IMedicalTest
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "MedicalTest";

        /// <summary>
        /// Drugs that affect the test's results.
        /// </summary>
        [JsonPropertyName("affectedBy")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IDrug> AffectedBy { get; set; }

        /// <summary>
        /// Range of acceptable values for a typical patient, when applicable.
        /// </summary>
        [JsonPropertyName("normalRange")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<MedicalEnumeration?, string> NormalRange { get; set; }

        /// <summary>
        /// A sign detected by the test.
        /// </summary>
        [JsonPropertyName("signDetected")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalSign> SignDetected { get; set; }

        /// <summary>
        /// A condition the test is used to diagnose.
        /// </summary>
        [JsonPropertyName("usedToDiagnose")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalCondition> UsedToDiagnose { get; set; }

        /// <summary>
        /// Device used to perform the test.
        /// </summary>
        [JsonPropertyName("usesDevice")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalDevice> UsesDevice { get; set; }
    }
}

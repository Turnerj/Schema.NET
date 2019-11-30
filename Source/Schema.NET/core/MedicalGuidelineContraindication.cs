namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A guideline contraindication that designates a process as harmful and where quality of the data supporting the contraindication is sound.
    /// </summary>
    public partial interface IMedicalGuidelineContraindication : IMedicalGuideline
    {
    }

    /// <summary>
    /// A guideline contraindication that designates a process as harmful and where quality of the data supporting the contraindication is sound.
    /// </summary>
    public partial class MedicalGuidelineContraindication : MedicalGuideline, IMedicalGuidelineContraindication
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "MedicalGuidelineContraindication";
    }
}

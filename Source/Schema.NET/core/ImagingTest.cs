namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Any medical imaging modality typically used for diagnostic purposes.
    /// </summary>
    public partial interface IImagingTest : IMedicalTest
    {
        /// <summary>
        /// Imaging technique used.
        /// </summary>
        OneOrMany<MedicalImagingTechnique?> ImagingTechnique { get; set; }
    }

    /// <summary>
    /// Any medical imaging modality typically used for diagnostic purposes.
    /// </summary>
    public partial class ImagingTest : MedicalTest, IImagingTest
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ImagingTest";

        /// <summary>
        /// Imaging technique used.
        /// </summary>
        [JsonPropertyName("imagingTechnique")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<MedicalImagingTechnique?> ImagingTechnique { get; set; }
    }
}

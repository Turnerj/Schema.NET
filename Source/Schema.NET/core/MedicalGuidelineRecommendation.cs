namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A guideline recommendation that is regarded as efficacious and where quality of the data supporting the recommendation is sound.
    /// </summary>
    public partial interface IMedicalGuidelineRecommendation : IMedicalGuideline
    {
        /// <summary>
        /// Strength of the guideline's recommendation (e.g. 'class I').
        /// </summary>
        OneOrMany<string> RecommendationStrength { get; set; }
    }

    /// <summary>
    /// A guideline recommendation that is regarded as efficacious and where quality of the data supporting the recommendation is sound.
    /// </summary>
    public partial class MedicalGuidelineRecommendation : MedicalGuideline, IMedicalGuidelineRecommendation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "MedicalGuidelineRecommendation";

        /// <summary>
        /// Strength of the guideline's recommendation (e.g. 'class I').
        /// </summary>
        [JsonPropertyName("recommendationStrength")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> RecommendationStrength { get; set; }
    }
}

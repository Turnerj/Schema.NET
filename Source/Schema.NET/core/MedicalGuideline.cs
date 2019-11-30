namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Any recommendation made by a standard society (e.g. ACC/AHA) or consensus statement that denotes how to diagnose and treat a particular condition. Note: this type should be used to tag the actual guideline recommendation; if the guideline recommendation occurs in a larger scholarly article, use MedicalScholarlyArticle to tag the overall article, not this type. Note also: the organization making the recommendation should be captured in the recognizingAuthority base property of MedicalEntity.
    /// </summary>
    public partial interface IMedicalGuideline : IMedicalEntity
    {
        /// <summary>
        /// Strength of evidence of the data used to formulate the guideline (enumerated).
        /// </summary>
        OneOrMany<MedicalEvidenceLevel?> EvidenceLevel { get; set; }

        /// <summary>
        /// Source of the data used to formulate the guidance, e.g. RCT, consensus opinion, etc.
        /// </summary>
        OneOrMany<string> EvidenceOrigin { get; set; }

        /// <summary>
        /// Date on which this guideline's recommendation was made.
        /// </summary>
        Values<int?, DateTime?> GuidelineDate { get; set; }

        /// <summary>
        /// The medical conditions, treatments, etc. that are the subject of the guideline.
        /// </summary>
        OneOrMany<IMedicalEntity> GuidelineSubject { get; set; }
    }

    /// <summary>
    /// Any recommendation made by a standard society (e.g. ACC/AHA) or consensus statement that denotes how to diagnose and treat a particular condition. Note: this type should be used to tag the actual guideline recommendation; if the guideline recommendation occurs in a larger scholarly article, use MedicalScholarlyArticle to tag the overall article, not this type. Note also: the organization making the recommendation should be captured in the recognizingAuthority base property of MedicalEntity.
    /// </summary>
    public partial class MedicalGuideline : MedicalEntity, IMedicalGuideline
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "MedicalGuideline";

        /// <summary>
        /// Strength of evidence of the data used to formulate the guideline (enumerated).
        /// </summary>
        [JsonPropertyName("evidenceLevel")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<MedicalEvidenceLevel?> EvidenceLevel { get; set; }

        /// <summary>
        /// Source of the data used to formulate the guidance, e.g. RCT, consensus opinion, etc.
        /// </summary>
        [JsonPropertyName("evidenceOrigin")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> EvidenceOrigin { get; set; }

        /// <summary>
        /// Date on which this guideline's recommendation was made.
        /// </summary>
        [JsonPropertyName("guidelineDate")]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?> GuidelineDate { get; set; }

        /// <summary>
        /// The medical conditions, treatments, etc. that are the subject of the guideline.
        /// </summary>
        [JsonPropertyName("guidelineSubject")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalEntity> GuidelineSubject { get; set; }
    }
}

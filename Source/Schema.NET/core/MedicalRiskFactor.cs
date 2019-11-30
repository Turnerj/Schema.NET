namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A risk factor is anything that increases a person's likelihood of developing or contracting a disease, medical condition, or complication.
    /// </summary>
    public partial interface IMedicalRiskFactor : IMedicalEntity
    {
        /// <summary>
        /// The condition, complication, etc. influenced by this factor.
        /// </summary>
        OneOrMany<IMedicalEntity> IncreasesRiskOf { get; set; }
    }

    /// <summary>
    /// A risk factor is anything that increases a person's likelihood of developing or contracting a disease, medical condition, or complication.
    /// </summary>
    public partial class MedicalRiskFactor : MedicalEntity, IMedicalRiskFactor
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "MedicalRiskFactor";

        /// <summary>
        /// The condition, complication, etc. influenced by this factor.
        /// </summary>
        [JsonPropertyName("increasesRiskOf")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalEntity> IncreasesRiskOf { get; set; }
    }
}

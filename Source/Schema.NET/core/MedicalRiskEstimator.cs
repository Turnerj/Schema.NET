namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Any rule set or interactive tool for estimating the risk of developing a complication or condition.
    /// </summary>
    public partial interface IMedicalRiskEstimator : IMedicalEntity
    {
        /// <summary>
        /// The condition, complication, or symptom whose risk is being estimated.
        /// </summary>
        OneOrMany<IMedicalEntity> EstimatesRiskOf { get; set; }

        /// <summary>
        /// A modifiable or non-modifiable risk factor included in the calculation, e.g. age, coexisting condition.
        /// </summary>
        OneOrMany<IMedicalRiskFactor> IncludedRiskFactor { get; set; }
    }

    /// <summary>
    /// Any rule set or interactive tool for estimating the risk of developing a complication or condition.
    /// </summary>
    public partial class MedicalRiskEstimator : MedicalEntity, IMedicalRiskEstimator
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "MedicalRiskEstimator";

        /// <summary>
        /// The condition, complication, or symptom whose risk is being estimated.
        /// </summary>
        [JsonPropertyName("estimatesRiskOf")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalEntity> EstimatesRiskOf { get; set; }

        /// <summary>
        /// A modifiable or non-modifiable risk factor included in the calculation, e.g. age, coexisting condition.
        /// </summary>
        [JsonPropertyName("includedRiskFactor")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalRiskFactor> IncludedRiskFactor { get; set; }
    }
}

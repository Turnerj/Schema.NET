namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A simple system that adds up the number of risk factors to yield a score that is associated with prognosis, e.g. CHAD score, TIMI risk score.
    /// </summary>
    public partial interface IMedicalRiskScore : IMedicalRiskEstimator
    {
        /// <summary>
        /// The algorithm or rules to follow to compute the score.
        /// </summary>
        OneOrMany<string> Algorithm { get; set; }
    }

    /// <summary>
    /// A simple system that adds up the number of risk factors to yield a score that is associated with prognosis, e.g. CHAD score, TIMI risk score.
    /// </summary>
    public partial class MedicalRiskScore : MedicalRiskEstimator, IMedicalRiskScore
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "MedicalRiskScore";

        /// <summary>
        /// The algorithm or rules to follow to compute the score.
        /// </summary>
        [JsonPropertyName("algorithm")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Algorithm { get; set; }
    }
}

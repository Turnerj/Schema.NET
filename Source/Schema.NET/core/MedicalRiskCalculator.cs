namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A complex mathematical calculation requiring an online calculator, used to assess prognosis. Note: use the url property of Thing to record any URLs for online calculators.
    /// </summary>
    public partial interface IMedicalRiskCalculator : IMedicalRiskEstimator
    {
    }

    /// <summary>
    /// A complex mathematical calculation requiring an online calculator, used to assess prognosis. Note: use the url property of Thing to record any URLs for online calculators.
    /// </summary>
    public partial class MedicalRiskCalculator : MedicalRiskEstimator, IMedicalRiskCalculator
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "MedicalRiskCalculator";
    }
}

namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A specific dosing schedule for a drug or supplement.
    /// </summary>
    public partial interface IDoseSchedule : IMedicalIntangible
    {
        /// <summary>
        /// The unit of the dose, e.g. 'mg'.
        /// </summary>
        OneOrMany<string> DoseUnit { get; set; }

        /// <summary>
        /// The value of the dose, e.g. 500.
        /// </summary>
        OneOrMany<double?> DoseValue { get; set; }

        /// <summary>
        /// How often the dose is taken, e.g. 'daily'.
        /// </summary>
        OneOrMany<string> Frequency { get; set; }

        /// <summary>
        /// Characteristics of the population for which this is intended, or which typically uses it, e.g. 'adults'.
        /// </summary>
        OneOrMany<string> TargetPopulation { get; set; }
    }

    /// <summary>
    /// A specific dosing schedule for a drug or supplement.
    /// </summary>
    public partial class DoseSchedule : MedicalIntangible, IDoseSchedule
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "DoseSchedule";

        /// <summary>
        /// The unit of the dose, e.g. 'mg'.
        /// </summary>
        [JsonPropertyName("doseUnit")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> DoseUnit { get; set; }

        /// <summary>
        /// The value of the dose, e.g. 500.
        /// </summary>
        [JsonPropertyName("doseValue")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<double?> DoseValue { get; set; }

        /// <summary>
        /// How often the dose is taken, e.g. 'daily'.
        /// </summary>
        [JsonPropertyName("frequency")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Frequency { get; set; }

        /// <summary>
        /// Characteristics of the population for which this is intended, or which typically uses it, e.g. 'adults'.
        /// </summary>
        [JsonPropertyName("targetPopulation")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> TargetPopulation { get; set; }
    }
}

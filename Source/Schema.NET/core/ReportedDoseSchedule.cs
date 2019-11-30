namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A patient-reported or observed dosing schedule for a drug or supplement.
    /// </summary>
    public partial interface IReportedDoseSchedule : IDoseSchedule
    {
    }

    /// <summary>
    /// A patient-reported or observed dosing schedule for a drug or supplement.
    /// </summary>
    public partial class ReportedDoseSchedule : DoseSchedule, IReportedDoseSchedule
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ReportedDoseSchedule";
    }
}

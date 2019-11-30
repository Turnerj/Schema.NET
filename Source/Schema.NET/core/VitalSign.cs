namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Vital signs are measures of various physiological functions in order to assess the most basic body functions.
    /// </summary>
    public partial interface IVitalSign : IMedicalSign
    {
    }

    /// <summary>
    /// Vital signs are measures of various physiological functions in order to assess the most basic body functions.
    /// </summary>
    public partial class VitalSign : MedicalSign, IVitalSign
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "VitalSign";
    }
}

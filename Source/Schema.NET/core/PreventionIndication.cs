namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An indication for preventing an underlying condition, symptom, etc.
    /// </summary>
    public partial interface IPreventionIndication : IMedicalIndication
    {
    }

    /// <summary>
    /// An indication for preventing an underlying condition, symptom, etc.
    /// </summary>
    public partial class PreventionIndication : MedicalIndication, IPreventionIndication
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "PreventionIndication";
    }
}

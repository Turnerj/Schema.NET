namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A treatment of people with physical, emotional, or social problems, using purposeful activity to help them overcome or learn to deal with their problems.
    /// </summary>
    public partial interface IOccupationalTherapy : IMedicalTherapy
    {
    }

    /// <summary>
    /// A treatment of people with physical, emotional, or social problems, using purposeful activity to help them overcome or learn to deal with their problems.
    /// </summary>
    public partial class OccupationalTherapy : MedicalTherapy, IOccupationalTherapy
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "OccupationalTherapy";
    }
}

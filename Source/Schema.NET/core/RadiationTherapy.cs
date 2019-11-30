namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A process of care using radiation aimed at improving a health condition.
    /// </summary>
    public partial interface IRadiationTherapy : IMedicalTherapy
    {
    }

    /// <summary>
    /// A process of care using radiation aimed at improving a health condition.
    /// </summary>
    public partial class RadiationTherapy : MedicalTherapy, IRadiationTherapy
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "RadiationTherapy";
    }
}

namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A process of progressive physical care and rehabilitation aimed at improving a health condition.
    /// </summary>
    public partial interface IPhysicalTherapy : IMedicalTherapy
    {
    }

    /// <summary>
    /// A process of progressive physical care and rehabilitation aimed at improving a health condition.
    /// </summary>
    public partial class PhysicalTherapy : MedicalTherapy, IPhysicalTherapy
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "PhysicalTherapy";
    }
}

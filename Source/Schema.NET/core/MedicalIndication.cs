namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A condition or factor that indicates use of a medical therapy, including signs, symptoms, risk factors, anatomical states, etc.
    /// </summary>
    public partial interface IMedicalIndication : IMedicalEntity
    {
    }

    /// <summary>
    /// A condition or factor that indicates use of a medical therapy, including signs, symptoms, risk factors, anatomical states, etc.
    /// </summary>
    public partial class MedicalIndication : MedicalEntity, IMedicalIndication
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "MedicalIndication";
    }
}

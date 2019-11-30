namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A store that sells reading glasses and similar devices for improving vision.
    /// </summary>
    public partial interface IOptician : IMedicalBusiness
    {
    }

    /// <summary>
    /// A store that sells reading glasses and similar devices for improving vision.
    /// </summary>
    public partial class Optician : MedicalBusiness, IOptician
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Optician";
    }
}

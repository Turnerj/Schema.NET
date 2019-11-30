namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Residence type: Apartment complex.
    /// </summary>
    public partial interface IApartmentComplex : IResidence
    {
    }

    /// <summary>
    /// Residence type: Apartment complex.
    /// </summary>
    public partial class ApartmentComplex : Residence, IApartmentComplex
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "ApartmentComplex";
    }
}

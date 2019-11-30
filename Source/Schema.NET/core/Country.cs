namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A country.
    /// </summary>
    public partial interface ICountry : IAdministrativeArea
    {
    }

    /// <summary>
    /// A country.
    /// </summary>
    public partial class Country : AdministrativeArea, ICountry
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "Country";
    }
}

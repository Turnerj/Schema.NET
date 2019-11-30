namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A city or town.
    /// </summary>
    public partial interface ICity : IAdministrativeArea
    {
    }

    /// <summary>
    /// A city or town.
    /// </summary>
    public partial class City : AdministrativeArea, ICity
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "City";
    }
}

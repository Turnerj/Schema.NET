namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A geographical region, typically under the jurisdiction of a particular government.
    /// </summary>
    public partial interface IAdministrativeArea : IPlace
    {
    }

    /// <summary>
    /// A geographical region, typically under the jurisdiction of a particular government.
    /// </summary>
    public partial class AdministrativeArea : Place, IAdministrativeArea
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "AdministrativeArea";
    }
}

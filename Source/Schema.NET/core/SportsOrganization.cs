namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Represents the collection of all sports organizations, including sports teams, governing bodies, and sports associations.
    /// </summary>
    public partial interface ISportsOrganization : IOrganization
    {
        /// <summary>
        /// A type of sport (e.g. Baseball).
        /// </summary>
        Values<string, Uri> Sport { get; set; }
    }

    /// <summary>
    /// Represents the collection of all sports organizations, including sports teams, governing bodies, and sports associations.
    /// </summary>
    public partial class SportsOrganization : Organization, ISportsOrganization
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "SportsOrganization";

        /// <summary>
        /// A type of sport (e.g. Baseball).
        /// </summary>
        [JsonPropertyName("sport")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> Sport { get; set; }
    }
}

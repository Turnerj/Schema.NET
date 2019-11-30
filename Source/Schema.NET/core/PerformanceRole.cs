namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A PerformanceRole is a Role that some entity places with regard to a theatrical performance, e.g. in a Movie, TVSeries etc.
    /// </summary>
    public partial interface IPerformanceRole : IRole
    {
        /// <summary>
        /// The name of a character played in some acting or performing role, i.e. in a PerformanceRole.
        /// </summary>
        OneOrMany<string> CharacterName { get; set; }
    }

    /// <summary>
    /// A PerformanceRole is a Role that some entity places with regard to a theatrical performance, e.g. in a Movie, TVSeries etc.
    /// </summary>
    public partial class PerformanceRole : Role, IPerformanceRole
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "PerformanceRole";

        /// <summary>
        /// The name of a character played in some acting or performing role, i.e. in a PerformanceRole.
        /// </summary>
        [JsonPropertyName("characterName")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> CharacterName { get; set; }
    }
}

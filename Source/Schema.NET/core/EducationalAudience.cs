namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An EducationalAudience.
    /// </summary>
    public partial interface IEducationalAudience : IAudience
    {
        /// <summary>
        /// An educationalRole of an EducationalAudience.
        /// </summary>
        OneOrMany<string> EducationalRole { get; set; }
    }

    /// <summary>
    /// An EducationalAudience.
    /// </summary>
    public partial class EducationalAudience : Audience, IEducationalAudience
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "EducationalAudience";

        /// <summary>
        /// An educationalRole of an EducationalAudience.
        /// </summary>
        [JsonPropertyName("educationalRole")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> EducationalRole { get; set; }
    }
}

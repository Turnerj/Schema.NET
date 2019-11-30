namespace Schema.NET
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A technical article - Example: How-to (task) topics, step-by-step, procedural troubleshooting, specifications, etc.
    /// </summary>
    public partial interface ITechArticle : IArticle
    {
        /// <summary>
        /// Prerequisites needed to fulfill steps in article.
        /// </summary>
        OneOrMany<string> Dependencies { get; set; }

        /// <summary>
        /// Proficiency needed for this content; expected values: 'Beginner', 'Expert'.
        /// </summary>
        OneOrMany<string> ProficiencyLevel { get; set; }
    }

    /// <summary>
    /// A technical article - Example: How-to (task) topics, step-by-step, procedural troubleshooting, specifications, etc.
    /// </summary>
    public partial class TechArticle : Article, ITechArticle
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [JsonPropertyName("@type")]
        public override string Type => "TechArticle";

        /// <summary>
        /// Prerequisites needed to fulfill steps in article.
        /// </summary>
        [JsonPropertyName("dependencies")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Dependencies { get; set; }

        /// <summary>
        /// Proficiency needed for this content; expected values: 'Beginner', 'Expert'.
        /// </summary>
        [JsonPropertyName("proficiencyLevel")]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ProficiencyLevel { get; set; }
    }
}
